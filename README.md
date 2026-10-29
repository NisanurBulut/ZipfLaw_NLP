<h1 align="center">
  <img src="docs/images/zipfomancy-logo.png" width="140" alt="Zipfomancy logosu: altın çubuklar, parlayan bir eğri ve sihirli bir kıvılcım"><br>
  Zipfomancy
</h1>

<p align="center">
  <b>🪄 Kelimelerin sayısından büyü çıkaran WPF uygulaması.</b><br>
  Harry Potter kitaplarında <b>Zipf Yasası</b>'nı keşfet: Türkçe ve İngilizce, tek tıkla, mumların ışığında. 🕯️
</p>

<p align="center">
  <a href="https://github.com/NisanurBulut/ZipfLaw_NLP/actions/workflows/dotnet.yml"><img src="https://github.com/NisanurBulut/ZipfLaw_NLP/actions/workflows/dotnet.yml/badge.svg" alt="Derleme durumu"></a>
  <a href="https://github.com/NisanurBulut/ZipfLaw_NLP/releases"><img src="https://img.shields.io/github/v/release/NisanurBulut/ZipfLaw_NLP?color=D3A625&label=s%C3%BCr%C3%BCm" alt="Son sürüm"></a>
  <img src="https://img.shields.io/badge/.NET-10-222F5B" alt=".NET 10">
  <img src="https://img.shields.io/badge/WPF-MVVM-740001" alt="WPF MVVM">
  <img src="https://img.shields.io/badge/ICEANS-2022-1A472A" alt="ICEANS 2022 bildirisi">
  <a href="LICENSE"><img src="https://img.shields.io/badge/lisans-GPL--3.0-D3A625" alt="GPL-3.0 lisansı"></a>
</p>

<p align="center">
  ⭐ <b>Zipfomancy hoşuna gittiyse ya da işine yaradıysa, bir yıldız vermeyi unutma!</b> ⭐
</p>

<p align="center">
  <img src="docs/images/zipfomancy-demo.gif" alt="Zipfomancy: sekmeler arasında gezinme, tablo, çizilen Zipf grafiği ve İngilizce kitabın çözümlenmesi" width="880">
</p>

Zipfomancy bir kitabın metnini okur, kelimeleri sayar, sıklığa göre dizer ve **Zipf Yasası**'nın tutup tutmadığını gösterir.
Sonuçlar üç ekranda toplanır: sayılarla **Özet**, tüm kelimeleriyle **Tablo** ve logaritmik **Grafik**.
Arayüz Harry Potter dünyasından esinlenmiştir: kızıl-altın renkler, süzülen mumlar, parlayan başlık, büyüyen çubuklar ve adım adım çizilen grafik.

Proje, [ICEANS 2022](#-yayın-bilgileri)'de sunulan bildirinin (*Application of Zipf Law on Turkish and English Language Versions of Harry Potter and the Philosopher's Stone*)
uygulamasının modern, **WPF / MVVM** ile yeniden yazılmış hâlidir. İlk WinForms sürümü bu depoda olduğu gibi durmaktadır.

## ✨ Neler yapar?

| | Özellik |
|---|---|
| 📖 | **İki hazır kitap**: Harry Potter ve Felsefe Taşı (Türkçe) ve *Harry Potter and the Sorcerer's Stone* (İngilizce). **Başka metin…** ile istediğin `.txt` dosyasını da çözümleyebilirsin. |
| 🌍 | **Türkçe ve İngilizce**: Türkçe için İ/ı kuralına uygun küçük harfe çevirme ve kesme işaretinden sonraki ekin atılması (*Harry'nin → harry*). |
| 🔢 | **Zipf sayıları**: toplam ve benzersiz kelime, sıra, olasılık, `sıra × sayı` ve `A = sıra × olasılık`. |
| 📊 | **Üç ekran**: Özet (büyüyen çubuklar), Tablo (tüm kelimeler, seçilebilir satırlar) ve Grafik (log-log çizim ile Zipf doğrusu). |
| 🕯️ | **Büyülü arayüz**: süzülen mumlar, parlayan başlık, altın ışıltılı düğmeler, çizilen eğri. Hepsi saf XAML ve çizim kodu; ek arayüz ya da grafik paketi yok. |
| ⚡ | **Akıcı**: çözümleme arka planda çalışır, arayüz donmaz; bu sırada durum satırı yanıp söner. |

## 🖼️ Ekranlar

<table>
  <tr>
    <td align="center"><b>📋 Özet</b><br><img src="docs/images/zipfomancy-ozet.png" width="300" alt="Özet ekranı: sayı kartları ve en sık geçen 15 kelime"></td>
    <td align="center"><b>🗂️ Tablo</b><br><img src="docs/images/zipfomancy-tablo.png" width="300" alt="Tablo ekranı: sıra, kelime, sayı, olasılık ve Zipf sabitleri"></td>
    <td align="center"><b>📈 Grafik</b><br><img src="docs/images/zipfomancy-grafik.png" width="300" alt="Grafik ekranı: logaritmik sıra ve sayı, Zipf doğrusu"></td>
  </tr>
</table>

## 🚀 Hızlı başlangıç

Windows ve [.NET 10 SDK](https://dotnet.microsoft.com/download) gerekir.

```bash
dotnet run --project src/ZipfLaw.Wpf
dotnet test ZipfLaw.sln
```

1. Uygulama açılınca ilk kitap kendiliğinden çözümlenir.
2. **Metin** kutusundan kitabı, **Dil** kutusundan dili seç ya da **Başka metin…** ile kendi dosyanı ekle.
3. **Büyüyü Başlat** düğmesine bas; **Özet**, **Tablo** ve **Grafik** sekmelerini gez.

## 📊 Sonuçlar

Zipf Yasası'na göre bir kelimenin `sıra × sayı` değeri yaklaşık olarak sabittir. Kelimeler olduğu gibi sayıldı (Türkçede kök ayrıştırma yok).
Sıra 1'den 1000'e çıkarken `sıra × sayı` aynı büyüklük mertebesinde kalır; `A = sıra × olasılık` ilk 100 kelimede yaklaşık **0,1**'dir.

| | 🇹🇷 Türkçe | 🇬🇧 İngilizce |
|---|---|---|
| Toplam kelime | 55.687 | 77.911 |
| Benzersiz kelime | 13.769 | 5.972 |
| En sık 3 kelime | bir, harry, dedi | the, and, to |
| Sıra 1 → `sıra × sayı` | `bir` → 1.776 | `the` → 3.630 |
| Sıra 10 → `sıra × sayı` | `hagrid` → 3.620 | `in` → 9.680 |
| Sıra 100 → `sıra × sayı` | `üstüne` → 5.800 | `only` → 11.100 |
| Sıra 1000 → `sıra × sayı` | `sorun` → 8.000 | `narrow` → 10.000 |
| **A** (ilk 100 kelime) | **0,089** | **0,133** |

> [!NOTE]
> Yasa kesin bir eşitlik değil, istatistiksel bir yaklaşıklıktır: değerler birebir aynı çıkmaz, ama grafikte kelimeler Zipf doğrusunun çevresinde dizilir.
> Eski WinForms sürümünde `A` hesabında toplam kelime yerine benzersiz kök sayısı kullanılıyordu; Zipfomancy README'deki formüle uyar (`N` = toplam kelime).

## 📐 Mimari

Kod üç katmandan oluşur ve her sınıf tek bir iş yapar. Çekirdek arayüzü ve dosya okumayı bilmez; ViewModel WPF türü kullanmaz.

<p align="center">
  <img src="docs/images/zipfomancy-uml.svg" alt="Zipfomancy sınıf diyagramı: MainWindow ve ZipfPlot (görünüm), MainViewModel, Book ve BarRow (ViewModel), ZipfAnalyzer, ZipfResult ve WordStat (çekirdek)" width="900">
</p>

| Katman | Renk | Ne yapar? |
|---|---|---|
| 🟥 **Görünüm** (`src/ZipfLaw.Wpf/Views`, `Controls`) | kızıl | XAML ekranları, `ZipfPlot` grafiği, mum animasyonu. |
| 🟨 **ViewModel** (`src/ZipfLaw.Wpf/ViewModels`) | altın | Ekranın durumu ve `AnalyzeCommand` ([CommunityToolkit.Mvvm](https://learn.microsoft.com/dotnet/communitytoolkit/mvvm/)). Dosyayı okur, çekirdeği çağırır. |
| 🟦 **Çekirdek** (`src/ZipfLaw.Core`) | mavi | `ZipfAnalyzer.Analyze(metin, dil)`: paketsiz, arayüzsüz, kolay test edilir. |

**Büyüyü Başlat → `MainViewModel.AnalyzeAsync` → `ZipfAnalyzer.Analyze` → `ZipfResult` → Özet, Tablo, Grafik.**

## 🔬 Zipf nasıl hesaplanır?

1. Metin sözcüklere ayrılır ve küçük harfe çevrilir (Türkçede tr-TR kuralıyla).
2. Aynı sözcükler sayılır, sıklığa göre çoktan aza dizilir; en çok geçene sıra `r = 1` verilir.
3. Her sözcük için `olasılık = sayı / N` hesaplanır (`N` = metindeki toplam kelime sayısı).
4. Zipf Yasası: `r × olasılık = A` yaklaşık sabittir, yani `r × sayı = A × N`.

## 📜 Yayın bilgileri

Bu çalışma uluslararası bir konferansta **sözlü bildiri** olarak sunulmuştur.

| | |
|---|---|
| **Başlık** | *Application of Zipf Law on Turkish and English Language Versions of Harry Potter and the Philosopher's Stone* |
| **Yazar** | Nisanur Bulut |
| **Konferans** | 2nd International Conference on Engineering and Applied Natural Sciences (**ICEANS 2022**) |
| **Tarih ve yer** | 15–18 Ekim 2022, Konya / Türkiye |
| **Sunum türü** | Sözlü (Oral) |
| **Belgeler** | 📄 [Bildiri (PDF)](NB_conference_paper.pdf) · 🏅 [Katılım belgesi (PDF)](Iceans_NisanurBulut_Certificate-037.pdf) · 📘 [Ek belge (PDF)](<Harry Potter ve Felsefe Taşı Kitabının İngilizce ve.pdf>) |

<p align="center">
  <img src="NisanurBulut_iceans.JPG" width="560" alt="ICEANS 2022 katılım belgesi">
</p>

<details>
<summary>📎 Kaynak gösterme (BibTeX)</summary>

```bibtex
@inproceedings{bulut2022zipf,
  author    = {Nisanur Bulut},
  title     = {Application of Zipf Law on Turkish and English Language Versions of Harry Potter and the Philosopher's Stone},
  booktitle = {2nd International Conference on Engineering and Applied Natural Sciences (ICEANS 2022)},
  address   = {Konya, T{\"u}rkiye},
  month     = {October},
  year      = {2022}
}
```

</details>

## 🏷️ Sürümler ve yayın akışı

Çalışma dallarda yürür ve `master`'a **pull request** ile girer. Birleşen her pull request için GitHub Actions otomatik olarak
`vANA.ARA.YAMA` biçiminde (üç basamaklı) bir **GitHub sürümü** yayınlar. Numara başlangıçta `v0.0.0`'dır; hangi basamağın artacağını dal adı belirler:

| Dal adı | Basamak | Örnek | PR etiketi |
|---|---|---|---|
| `major_…` | **ana** sürüm artar, ara ve yama sıfırlanır | `v0.0.0` → `v1.0.0` | 🔴 `breaking` |
| `dev_…` | **ara** sürüm artar, yama sıfırlanır | `v1.0.0` → `v1.1.0` | 🟡 `enhancement` |
| `hotfix_…` ve diğerleri | **yama** artar | `v1.1.0` → `v1.1.1` | 🟠 `bug` |

| Workflow | Ne zaman çalışır? | Ne yapar? |
|---|---|---|
| [`dotnet.yml`](.github/workflows/dotnet.yml) | `master`'a push ve her pull request | Windows'ta derler, testleri çalıştırır, PR'ı dal adına göre etiketler. |
| [`release.yml`](.github/workflows/release.yml) | `master`'a birleşen pull request | Bir sonraki `vX.Y.Z` etiketini ve sürüm notlarını oluşturur. Doğrudan push sürüm üretmez. |
| [`auto-assign.yml`](.github/workflows/auto-assign.yml) | pull request açılınca ve birleşince | PR'ı yazara ve birleştirene atar. |

Yayınlanan sürümler: [**Releases**](https://github.com/NisanurBulut/ZipfLaw_NLP/releases).

## 🗂️ Depo yapısı

| Yol | İçerik |
|---|---|
| `src/ZipfLaw.Core` | Zipf hesabı. Paketsiz sınıf kitaplığı, arayüz ve dosya okuma yok. |
| `src/ZipfLaw.Wpf` | WPF arayüzü: ekranlar, ViewModel, Harry Potter teması, simgeler, animasyonlar, grafik kontrolü. |
| `tests/ZipfLaw.Core.Tests` | xUnit testleri (sayma, sıralama, Zipf sabitleri, Türkçe harf kuralları). |
| `docs/images` | Logo, UML diyagramı, ekran görüntüleri ve README animasyonu. |
| `tools` | Logo ve simge üretimi (`render-assets.ps1`) ile README animasyonunu kaydeden betik (`record-demo-gif.cs`). |
| `ZipfLawNLP/` | İlk WinForms sürümü (.NET Framework, NZemberek, LiveCharts). Olduğu gibi saklanır; CI bunu derlemez. |

> [!TIP]
> Proje adı **Zipfomancy**'dir; klasör ve ad alanı adları (`ZipfLaw.*`) ve depo adı şimdilik değişmedi.

<details>
<summary>🛠️ Görselleri yeniden üretmek</summary>

```bash
powershell -STA -File tools/render-assets.ps1
dotnet build ZipfLaw.sln
dotnet run tools/record-demo-gif.cs
```

`render-assets.ps1`, `tools/logo.xaml` dosyasından logo PNG'sini ve uygulama simgesini (`src/ZipfLaw.Wpf/Assets/zipfomancy.ico`) üretir.
`record-demo-gif.cs` uygulamayı açar, sekmeleri gezer ve pencereyi `docs/images/zipfomancy-demo.gif` olarak kaydeder.
Arayüz değişince önce derleyip animasyonu yeniden kaydet.

</details>

## 📄 Lisans

GPL-3.0, bkz. [LICENSE](LICENSE).

---

<p align="center">
  Kelimelerle, mumlarla ve biraz matematikle yapıldı 🕯️ ·
  <a href="https://github.com/NisanurBulut/ZipfLaw_NLP">⭐ Depoya yıldız ver</a>
</p>

---

# 📚 Zipf Yasası ve orijinal çalışma (WinForms sürümü)

Aşağıdaki bölümler, ilk WinForms uygulamasının ve bildirinin açıklamasıdır (Zemberek ile kök ve ek ayrımı, LiveCharts daire grafikleri dahil).

Doğal dil işleme alanında kelimelerin kullanım sıklıkları, bir kelimenin taşıdığı anlam sayısı, kelimeler arası uzaklıklar gibi unsurların arasında bir ilişki olduğu fark edilmiştir. Bu anlamdaki ilk çalışmalar, George K. Zipf (1902–1950) tarafından yapılmıştır. Zipf bu çalışmalarını 1932 yılında yayınladığı “Selected Studies of the Principle of Relative Frequency in Language” başlıklı makalesiyle yayımlamıştır ve onun adıyla da yasalaşmıştır.[1]
Zipf’e göre, içeriği ve dili fark etmeksizin, bir metindeki kelimeleri kullanım sıklığına göre azalan şekilde sıraladığımızda, belli bir örüntüye sahip liste elde edilir. Listedeki bir kelimenin kullanım sırasının sıklık ile çarpımı sabit bir sayıyı verir. Bu yasa ilk olarak  ilk olarak  James Joyce'un Ulysses adlı eserinde tatbik edilmiştir, şöyledir;

- en çok kullanılan sözcük metinde,, 2653 kez kullanılırken
- 100. en çok kullanılan,, 265 kez
- 200. en çok kullanılan,, 133 kez kullanılmıştır.

Zipf’in bulgularına göre sözcüklerin büyük çoğunluğu çok nadiren kullanılırken az sayıda birtakım sözcük her zaman kullanılır. Yasa yalnızca bir insan diline ait değildir şimdiye değin içeriği pek çok farklı konuda olan pek çok farklı dildeki metinlerde denenmiştir. Sonrasında fark edilmiştir ki, Zipf yasası insanların gelir dağılımlarına ya da şehir nüfus oranlarına uygulandığında da aynı sonucu vermiştir. Örneğin, Bir ülkedeki en çok nüfusa sahip şehir genellikle bir sonrakinin iki katı kadardır.[2]

![İstatistik](https://github.com/NisanurBulut/ZipfLaw_NLP/blob/master/ZipfLawNLP/Photos/istatistik1.png)

Birleşik Devletler’deki nüfusa göre en üst sıralarda yer alan şehirlere şöyle bir bakldığında 2010 nüfus sayımında ABD’deki en büyük şehir olan New York’un nüfusu 8.175.133 iken  ikinci sıradaki Los Angeles’ın nüfusu 3.792.621 ve  sonraki üç sırada Chicago, Houston ve Philadelphia yer aldığı görülür. Şehirlerin nüfus sayıları sırasıyla 2.695.598, 2.100.263 ve 1.526.006’dır. Sayıların tam olmadığını açıkça görülmektedir fakat istatistiksel olarak bakıldığında Zipf’in öngörülerini kayda değer biçimde tutar. Yasanın sağlandığını görmek amacıyla, logaritmik fonksiyonda çizilebilir.

<p align="center">
  <a href="https://github.com/NisanurBulut/ZipfLaw_NLP/actions/workflows/dotnet.yml"><img src="https://github.com/NisanurBulut/ZipfLaw_NLP/actions/workflows/dotnet.yml/badge.svg" alt="Build status"></a>
  <a href="https://github.com/NisanurBulut/ZipfLaw_NLP/releases"><img src="https://img.shields.io/github/v/release/NisanurBulut/ZipfLaw_NLP?color=D3A625" alt="Latest release"></a>
  <img src="https://img.shields.io/badge/.NET-10-222F5B" alt=".NET 10">
  <img src="https://img.shields.io/badge/WPF-MVVM-740001" alt="WPF MVVM">
  <img src="https://img.shields.io/badge/ICEANS-2022-1A472A" alt="ICEANS 2022 paper">
  <a href="LICENSE"><img src="https://img.shields.io/badge/license-GPL--3.0-D3A625" alt="GPL-3.0 license"></a>
</p>

<p align="center">
  ⭐ <b>Do you like Zipfomancy? Please give it a star!</b> ⭐<br>
  It is free and it only takes a second, but it helps me a lot.<br><br>
  <a href="https://github.com/NisanurBulut/ZipfLaw_NLP"><img src="https://img.shields.io/github/stars/NisanurBulut/ZipfLaw_NLP?style=social" alt="Star this repository on GitHub"></a>
</p>

<p align="center">
  <img src="docs/images/zipfomancy-demo.gif" alt="Zipfomancy: moving between the tabs, the table, the chart that draws itself and the English book" width="880">
</p>

Zipfomancy reads a book, counts every word and puts the words in order, from the most common to the least common.
Then it shows you if **Zipf's law** is true for this text.

You see the result on three screens: **Summary**, **Table** and **Chart**.
The app looks like a Harry Potter common room: red and gold colors, floating candles, a glowing title, bars that grow and a chart that draws itself.

> [!NOTE]
> The texts in the app are in Turkish. The tabs are called *Özet* (Summary), *Tablo* (Table) and *Grafik* (Chart).

This is the new version (WPF / MVVM) of the app from my paper at [ICEANS 2022](#-publication).
The first WinForms version is still in this repository.

## ✨ What can it do?

| | Feature |
|---|---|
| 📖 | **Two books are ready to use**: *Harry Potter and the Sorcerer's Stone* in Turkish and in English. With **Başka metin…** (Another text…) you can open any `.txt` file. |
| 🌍 | **Turkish and English**: the Turkish rules for the letters I and ı are correct, and a word like *Harry'nin* is counted as *harry*. |
| 🔢 | **All the Zipf numbers**: total words, different words, rank, probability, `rank × count` and `A = rank × probability`. |
| 📊 | **Three screens**: Summary (bars that grow), Table (every word, rows you can select) and Chart (a log-log plot with the Zipf line). |
| 🕯️ | **A magic look**: floating candles, a glowing title, golden buttons and a curve that draws itself. It uses only XAML and drawing code, with no extra UI or chart package. |
| ⚡ | **Smooth**: the work runs in the background, so the window never freezes. |

## 🖼️ Screens

<table>
  <tr>
    <td align="center"><b>📋 Summary</b><br><img src="docs/images/zipfomancy-ozet.png" width="300" alt="Summary screen: number cards and the 15 most common words"></td>
    <td align="center"><b>🗂️ Table</b><br><img src="docs/images/zipfomancy-tablo.png" width="300" alt="Table screen: rank, word, count, probability and the Zipf numbers"></td>
    <td align="center"><b>📈 Chart</b><br><img src="docs/images/zipfomancy-grafik.png" width="300" alt="Chart screen: rank and count on log scales with the Zipf line"></td>
  </tr>
</table>

## 🚀 Quick start

You need Windows and the [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
dotnet run --project src/ZipfLaw.Wpf
dotnet test ZipfLaw.sln
```

1. The app opens and reads the first book by itself.
2. Choose a book in **Metin** (Text) and a language in **Dil** (Language). Or click **Başka metin…** to open your own file.
3. Click **Büyüyü Başlat** (Start the spell), then look at the three tabs.

## 🤔 What is Zipf's law?

1. Count how often each word is used in a text.
2. Put the words in order. The most common word gets **rank 1**, the next one gets rank 2, and so on.
3. Zipf's law says that **rank × count** is almost the same number for every word.
   So the number 1 word is used about twice as often as the number 2 word, and about three times as often as the number 3 word.

In numbers: `probability = count / N`, where `N` is the number of all words in the text. Then `rank × probability = A`, and `A` is often near 0.1.

The law works for many languages. It also works for other things, for example the sizes of cities.
Nobody knows exactly why. 🪄

## 📊 Results

Here are the numbers for the two books. Words are counted as they are (there is no word stemming for Turkish yet).
When the rank goes from 1 to 1000, `rank × count` stays in the same range, and `A` is close to **0.1** for the first 100 words.

| | 🇹🇷 Turkish | 🇬🇧 English |
|---|---|---|
| All words | 55,687 | 77,911 |
| Different words | 13,769 | 5,972 |
| Top 3 words | bir, harry, dedi | the, and, to |
| Rank 1 → `rank × count` | `bir` → 1,776 | `the` → 3,630 |
| Rank 10 → `rank × count` | `hagrid` → 3,620 | `in` → 9,680 |
| Rank 100 → `rank × count` | `üstüne` → 5,800 | `only` → 11,100 |
| Rank 1000 → `rank × count` | `sorun` → 8,000 | `narrow` → 10,000 |
| **A** (first 100 words) | **0.089** | **0.133** |

> [!NOTE]
> Zipf's law is not an exact rule. The numbers are never the same, but in the chart the words stay near the Zipf line.
> The old WinForms version divided by the number of different stems when it calculated `A`. Zipfomancy uses the formula above, with `N` = all words.

## 📐 Architecture

The code has three layers, and every class does one job. The core knows nothing about the window or about files, and the view model uses no WPF types.

<p align="center">
  <img src="docs/images/zipfomancy-uml.svg" alt="Zipfomancy class diagram: MainWindow and ZipfPlot (view), MainViewModel, Book and BarRow (view model), ZipfAnalyzer, ZipfResult and WordStat (core)" width="900">
</p>

| Layer | Color | What does it do? |
|---|---|---|
| 🟥 **View** (`src/ZipfLaw.Wpf/Views`, `Controls`) | red | The XAML screens, the `ZipfPlot` chart and the candle animation. |
| 🟨 **ViewModel** (`src/ZipfLaw.Wpf/ViewModels`) | gold | The state of the screen and the `AnalyzeCommand` ([CommunityToolkit.Mvvm](https://learn.microsoft.com/dotnet/communitytoolkit/mvvm/)). It reads the file and calls the core. |
| 🟦 **Core** (`src/ZipfLaw.Core`) | blue | `ZipfAnalyzer.Analyze(text, language)`. No packages, no UI, easy to test. |

**Start the spell → `MainViewModel.AnalyzeAsync` → `ZipfAnalyzer.Analyze` → `ZipfResult` → Summary, Table, Chart.**

## 📜 Publication

I presented this work as an **oral presentation** at an international conference.

| | |
|---|---|
| **Title** | *Application of Zipf Law on Turkish and English Language Versions of Harry Potter and the Philosopher's Stone* |
| **Author** | Nisanur Bulut |
| **Conference** | 2nd International Conference on Engineering and Applied Natural Sciences (**ICEANS 2022**) |
| **Date and place** | 15–18 October 2022, Konya, Türkiye |
| **Type** | Oral presentation |
| **Documents** | 📄 [Paper (PDF)](NB_conference_paper.pdf) · 🏅 [Certificate (PDF)](Iceans_NisanurBulut_Certificate-037.pdf) · 📘 [Extra document (PDF)](<Harry Potter ve Felsefe Taşı Kitabının İngilizce ve.pdf>) |

<p align="center">
  <img src="NisanurBulut_iceans.JPG" width="560" alt="ICEANS 2022 certificate of participation">
</p>

<details>
<summary>📎 How to cite (BibTeX)</summary>

```bibtex
@inproceedings{bulut2022zipf,
  author    = {Nisanur Bulut},
  title     = {Application of Zipf Law on Turkish and English Language Versions of Harry Potter and the Philosopher's Stone},
  booktitle = {2nd International Conference on Engineering and Applied Natural Sciences (ICEANS 2022)},
  address   = {Konya, T{\"u}rkiye},
  month     = {October},
  year      = {2022}
}
```

</details>

## 🏷️ Releases and versions

Work happens on branches. A branch reaches `master` with a **pull request** (a request to merge the branch).
When a pull request is merged, GitHub Actions makes a new **GitHub release** with a version number like `v1.2.3`.
The first version is `v0.0.0`. The name of the branch decides which number goes up:

| Branch name | Number that goes up | Example | Label on the pull request |
|---|---|---|---|
| `major_…` | **major** (the other two go back to 0) | `v0.0.0` → `v1.0.0` | 🔴 `breaking` |
| `dev_…` | **minor** (the patch goes back to 0) | `v1.0.0` → `v1.1.0` | 🟡 `enhancement` |
| `hotfix_…` and all other names | **patch** | `v1.1.0` → `v1.1.1` | 🟠 `bug` |

| Workflow | When does it run? | What does it do? |
|---|---|---|
| [`dotnet.yml`](.github/workflows/dotnet.yml) | A push to `master` and every pull request | Builds the app on Windows, runs the tests and puts a label on the pull request. |
| [`release.yml`](.github/workflows/release.yml) | A pull request is merged into `master` | Creates the next `vX.Y.Z` tag and the release notes. A direct push does not make a release. |
| [`auto-assign.yml`](.github/workflows/auto-assign.yml) | A pull request is opened or merged | Assigns the pull request to its author and to the person who merged it. |

All releases are on the [**Releases**](https://github.com/NisanurBulut/ZipfLaw_NLP/releases) page.

## 🗂️ Project structure

| Path | Content |
|---|---|
| `src/ZipfLaw.Core` | The Zipf calculation. A class library with no packages, no UI and no file reading. |
| `src/ZipfLaw.Wpf` | The WPF app: screens, view model, Harry Potter theme, icons, animations and the chart control. |
| `tests/ZipfLaw.Core.Tests` | xUnit tests (counting, order, Zipf numbers, Turkish letter rules). |
| `docs/images` | Logo, banner, UML diagram, screenshots and the animation for this README. |
| `docs/README.tr.md` | The Turkish README, with the full text about the first version. |
| `tools` | A script for the logo and icon (`render-assets.ps1`) and a script that records the animation (`record-demo-gif.cs`). |
| `ZipfLawNLP/` | The first WinForms version (.NET Framework, NZemberek, LiveCharts). It stays as it is, and CI does not build it. |

> [!TIP]
> The project is called **Zipfomancy**. The folder names, the namespaces (`ZipfLaw.*`) and the repository name have not changed yet.

<details>
<summary>🛠️ How to make the images again</summary>

```bash
powershell -STA -File tools/render-assets.ps1
dotnet build ZipfLaw.sln
dotnet run tools/record-demo-gif.cs
```

`render-assets.ps1` makes the logo PNG and the app icon (`src/ZipfLaw.Wpf/Assets/zipfomancy.ico`) from `tools/logo.xaml`.
`record-demo-gif.cs` opens the app, clicks through the tabs and saves the window as `docs/images/zipfomancy-demo.gif`.
After you change the screens, build first and then record the animation again.

</details>

## 🌍 Turkish documentation

The full Turkish text is in [docs/README.tr.md](docs/README.tr.md). It also explains the first WinForms version: Zemberek word stems and endings, the pie charts and the results of that version.

## 📄 License

GPL-3.0, see [LICENSE](LICENSE).

---

<p align="center">
  ⭐ <b>Made with words, candles and a little math. If you like it, please <a href="https://github.com/NisanurBulut/ZipfLaw_NLP">star the repository</a>!</b> ⭐
</p>
