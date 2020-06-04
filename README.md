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

# Zipf Yasası Uygulama Anlatım
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

# Zipf Yasası Uygulamasına Örnekler
- Wikipedia’dan temin edilen Amerika’daki en kalabalık ilk kırk şehrin 2015 nüfuslarının gösterimi[6]


![Nüfus yoğunluğunun şehir bazlı dağılımı](https://github.com/NisanurBulut/ZipfLaw_NLP/blob/master/HW1_NLP/Photos/sehir-dagilim.jpg)
