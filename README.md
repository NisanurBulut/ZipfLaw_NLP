# Zipf Kanunu

Doğal dil işleme alanında kelimelerin kullanım sıklıkları, bir kelimenin taşıdığı anlam sayısı, kelimeler arası uzaklıklar gibi unsurların arasında bir ilişki olduğu fark edilmiştir. Bu anlamdaki ilk çalışmalar, George K. Zipf (1902–1950) tarafından yapılmıştır. Zipf bu çalışmalarını 1932 yılında yayınladığı “Selected Studies of the Principle of Relative Frequency in Language” başlıklı makalesiyle yayımlamıştır ve onun adıyla da yasalaşmıştır.[1]
Zipf’e göre, içeriği ve dili fark etmeksizin, bir metindeki kelimeleri kullanım sıklığına göre azalan şekilde sıraladığımızda, belli bir örüntüye sahip liste elde edilir. Listedeki bir kelimenin kullanım sırasının sıklık ile çarpımı sabit bir sayıyı verir. Bu yasa ilk olarak  ilk olarak  James Joyce'un Ulysses adlı eserinde tatbik edilmiştir, şöyledir;

- en çok kullanılan sözcük metinde,, 2653 kez kullanılırken
- 100. en çok kullanılan,, 265 kez
- 200. en çok kullanılan,, 133 kez kullanılmıştır.

Zipf’in bulgularına göre sözcüklerin büyük çoğunluğu çok nadiren kullanılırken az sayıda birtakım sözcük her zaman kullanılır. Yasa yalnızca bir insan diline ait değildir şimdiye değin içeriği pek çok farklı konuda olan pek çok farklı dildeki metinlerde denenmiştir. Sonrasında fark edilmiştir ki, Zipf yasası insanların gelir dağılımlarına ya da şehir nüfus oranlarına uygulandığında da aynı sonucu vermiştir. Örneğin, Bir ülkedeki en çok nüfusa sahip şehir genellikle bir sonrakinin iki katı kadardır.[2]

![İstatistik](https://github.com/NisanurBulut/ZipfLaw_NLP/blob/master/HW1_NLP/Photos/istatistik1.png)

Birleşik Devletler’deki nüfusa göre en üst sıralarda yer alan şehirlere şöyle bir bakldığında 2010 nüfus sayımında ABD’deki en büyük şehir olan New York’un nüfusu 8.175.133 iken  ikinci sıradaki Los Angeles’ın nüfusu 3.792.621 ve  sonraki üç sırada Chicago, Houston ve Philadelphia yer aldığı görülür. Şehirlerin nüfus sayıları sırasıyla 2.695.598, 2.100.263 ve 1.526.006’dır. Sayıların tam olmadığını açıkça görülmektedir fakat istatistiksel olarak bakıldığında Zipf’in öngörülerini kayda değer biçimde tutar. Yasanın sağlandığını görmek amacıyla, logaritmik fonksiyonda çizilebilir.

Zipf yasasının, şehir büyüklükleri, nüfus oranları ya da metinlerde geçen kelime anlam sıklığındaki uygunluğu gibi daha pek çok alanda doğruluğunun ortaya çıkma sebebi halen bilinmektedir Zipf Yasası birbirimizle iletişim kurma, ticaret yapma ve topluluk oluşturma yöntemlerimizi sağlama bağlayan temel bir toplumsal dinamik kuralın belki de sadece bir yönüdür.[3]

## Zipf Yasası Uygulama Anlatım
Bir metindeki benzeri olmayan kelimeler, yani bir kelimeyi birden fazla kez saymamak şartıyla, metinde kaç kez geçtiği sayılır. 
Freq(word)=Metinde bir kelimenin kaç kez kullanıldığını gösterir.

Bu sıklık listesine göre, her kelime azalan sırada derecelendirilir. Ençok kullanılan kelimenin derecesi(rank) 1 iken ondan sonra gelen en çok kullanılan kelimenin derecesi(rank) 2 olur. Kelimenin anlamıyla ilgilenmeyiz yalnızca sıklık ve derece değerleriyle ilgileniriz.

r=derece(rank)

N=Metinde geçen kelime sayısıdır. Benzersiz kelime sayısı değildir yani bir kelime metin içinde bir den fazla geçebilir ve sayıma dahil edilir.

Prob(r) = freq(r) / N   Zipf  yasasına göre;
r * Prob(r) = A 

Bu formüle göre,  A sabit bir sayıdır ve çoğunlukla 0.01 değerini alır. Zipf yasası istatistiksel bir çıkarımdır her zaman aynı değeri verir şeklinde kesin bir çıkarımı yoktur ancak her zaman yakınsal sonuçlar vermesi beklenir.

Prob(r)=freq(r)/N formülünü dikkate alır ve 
</br><b>Zipf yasasını yeniden yazarsak ;</b>

r * freq(r) = A * N formülü elde edilir.

Zipf yasasını uygulayacak olursak, elde etmemiz gereken ilk şey  freq(r) değeridir. Bu değeri derece yani r ile çarptığımızda elde edeceğimiz sonuçlar  yaklaşık olarak aynıdır. Bunun anlamı, her kelime için r*freq(r) değerinin aynı olacağı değildir. Ama sonuçların birbirine yakın olması beklenir.

- Sıklık değeri en çok ya da en az olan kelimelere ait sonuçlara bakmak aldatıcıdır. Bunlara dair sonuçlar genelde en fazla hataya sahip sonuçlardır. İdeal gözlem için, kelimelerin derecesi 1,10,100,200… şeklinde  olacak şekilde, Zipf yasasına olan uygunluklarına bakılmalıdır. Zipf yasası için ne uygun gösterim nokta grafikleridir. Sonuçlar logaritması alındıktan sonra görüntülendiğinde daha net görülecektir.[5]
- Kodlama aşamasında, şimdiye dek anlatılmış olan Zipf kanunu ilkeleri gösterilmeye çalışılmıştır.

## Zipf Yasası Uygulamasına Örnekler
- Wikipedia’dan temin edilen Amerika’daki en kalabalık ilk kırk şehrin 2015 nüfuslarının gösterimi[6]


![](https://github.com/NisanurBulut/ZipfLaw_NLP/blob/master/HW1_NLP/Photos/sehir-dagilim.jpg)

- TÜİK’in sunduğu Adrese Dayalı Nüfus Kayıt Sistemi verilerinden alınan Türkiye illerinin 2017 nüfus sonuçları

![](https://github.com/NisanurBulut/ZipfLaw_NLP/blob/master/HW1_NLP/Photos/sehir-dagilim.jpg)

Birinci sırada 15 milyon nüfus değeriyle İstanbul vardır. İkinci sırada ki Ankara’nın nüfus oranı 7.5 milyon olması beklenirken 5.5 milyon değerindedir. Ama 3. Sırada İzmir 4.2 milyon değeriyle üçte bir oranına yaklaşır. Onuncu sıradaki Kocaeli 1,5 milyonluk nüfusuyla 15 milyonun onda birini, yirminci sıradaki Aydın 750 binlik nüfusuyla İstanbul nüfusunun yirmide birini tam isabetle tutturur.

- Ak Parti resmi sitesinden alınan seçim beyannamesi

![](https://github.com/NisanurBulut/ZipfLaw_NLP/blob/master/HW1_NLP/Photos/akparti-beyanname.jpg)

AK Parti beyannamesinde geçen tüm kelimelerin sayısı: 90800. Tekrar eden kelimeleri çıkarttığımızda 17644 tekil kelime kalır. Tüm kelimeler geçiş sıklıklarına göre dizildiklerinde en çok kullanılan ilk on kelimenin “ve” (3798), “bir” (1008), “ile” (676), “bu” (620), “için” (597), “olarak” (511), “daha” (463), “yılında” (453), “olan” (402), “devam” (318) olur. Bu metnin de Zipf Kanunu’na uyduğu söylenebilir. 

- CHP resmi sitesinden alınan seçim beyannamesi
![](https://github.com/NisanurBulut/ZipfLaw_NLP/blob/master/HW1_NLP/Photos/chp-beyanname.jpg)

CHP beyannamesinde toplam 30622 kelime vardır. Tekrarsız kelime sayısı 8904’tür. CHP beyannamesinde en sık kullanılan ilk on kelimenin kullanım sıklıkları şöyle sıralanır: “ve” (1589), “bir” (466), “için” (217), “sağlayacağız” (199), “tüm” (182), “bu” (168), “ile” (156), “kamu” (149), “eğitim” (122), “iş” (120).  Bu metin de genel olarak Zipf Kanunu’na uyar. Her ne kadar ikinci sıradaki kelime olan “bir” beklenenden az görülse de on, yirmi, otuz ve kırkıncı sıradaki kelimeler kanununca öngörülen sayılara yakın sıklıkta kullanılmaktadır.
## Zipf Yasasına Dair Uygulama Program

Program, HarryPotter ve felsefe taşı kitabınıın İngilizce aslını ve Türkçe çevirindeki kelime-köklerinin Zipf yasasına uygunluğunu göstermeye çalışır. Ayrıca, kitabın Türkçe çevirisi için her bir kelimenin eklerinin türleriyle birlikte listelemesi ve  zipf kanununa olan uygunluğunun gösterimini yapar.
Metin Üzerinde Yapılan Ön İşlemler
- Pdf formatındaki kitap metinleri, txt dosyası haline getirildi.
- Metin dosyalarında bulunan, bütün kelimeler küçük harf formatına getirildi.
- Kelimeler arasında bulunan, noktalama işaretleri kaldırıldı.
- Zipf kanunu araştırması yapılırken, kelimeler köklerine ayrıldı ve kökleri üzerinden bir hesaplama işlemi yapılmıştır.
- Kelimeler zemberek yardımıyla Türkçe diline ait olup olmadığı kontrolüne tabi tutuldu. Bu sebeple Harry, Privet, Mr, Mss gibi kelimeler sayıma dahil edilmemiştir. Böylece özel isimlerinde kontrol edilmesi gibi bir işlem yükünden muaf olunmuştur.

### <b> Programın Geliştirilmesinde Kullanılan Bileşenler</b>

Yazılı metin üzerinde, kelime analizleri yapabilmek için Zemberek [6] kütüphanesinin .Net formatından  yararlanılmıştır. Sonuçların grafik gösterimleri için LiveChart Framework’ten [7] yararlanılmıştır. Zipf kanununun uygunluğuna dair araştırma sonuçlarını pdf dosya formatında saklamak için iTextSharp [8]  .Net kütüphanesinden yararlanılmıştır.

Program C# programlama dili kullanılarak, Windows Form Application olarak masaüstü olarak geliştirilmiştir.

### <b>Program Çalışmasına Dair Sonuç Gösterimleri</b>

Sonuç gösterimlerinde, ilk 30 kelime dağılımı gösterilmiştir.

1.	<b>Türkçe Metin Üzerinde f*r=A Gösterimi</b>

Türkçe metinde her kelime sayılmış ve kullanım sıklığına göre artan sırada derecelendirilmiştir. Kullanım miktarının, derecesiyle çarpımı yaklaşık olarak yakın sayıları vermelidir. Sonuçların yakın anlamda aynı değerleri verdiğinin gösterimde daha net anlaşılması için daire grafik gösteriminden yararlanılmıştır.

Türkçe metinde, üzerinde araştırma yapılan tekil olmayan 55449 adet kelime bulunmuştur ve  tekil kelime sayısı 13088olarak belirlenmiştir. Bu kelimeler üzerinde kök ayrımı yapıldığında benzersiz olan kök sayısı 2340 olarak saptanmıştır. Köklerde kendi içlerinde sıfat-kök, isim-kök, edat-kök,zamir-kök, bağlaç-kök,zaman-kök,soru-kök,ünlem-kök,imek-kök,yankı-kök,sayı-kök gibi türleriyle sınıflandırılmış ve sayılmıştır.

![](https://github.com/NisanurBulut/ZipfLaw_NLP/blob/master/HW1_NLP/Photos/Anlatim.jpg)


![](https://github.com/NisanurBulut/ZipfLaw_NLP/blob/master/HW1_NLP/Photos/anaEkran.jpg)

Türkçe metinde geçem kelime kökleri sayıldıktan sonra, en çok kullanılan kök için sıralama 1 den başlayacak şekilde derecelendirilmiştir. Kullanım sıklığının, derecesiyle çarpımı sonucunda elde edilen sabit sayı ilk 30 kelime için kesinlikle aynı değildir ancak grafikten de anlaşılacağı üzere yakın değerlere sahiptir.