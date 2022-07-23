# Pansiyon Uygulaması
Bu uygulama pansiyonda kalacak olan müşterileri sisteme ekleyen ve gerekli işlemleri gerçekleştiren bir otomasyondur. Uygulama çalıştırıldığı esnada ilk olarak admin girişi sayfası gelmektedir. E-mail ve şifre ile başarılı bir girişin ardından,
* Yeniden bir admin girişi butonu,
* Müşteri ekle,
* Odalar,
* Müşteriler,
* Stok bilgisi,
* Çıkış 
butonları bulunmaktadır. 
![](https://github.com/SimgeTerzioglu/PansiyonUygulamasi/blob/master/anasayfa.png)

# Müşteri Ekle:
Bu butona tıklandığında gelen sayfada gerekli müşteri bilgileri girilerek müşteri kaydedilir. Bu sayfada ayrıca odaları gösteren bir tablo daha bulunmaktadır. Bu tabloda dolu olan odalar kırmızı renk ile ve o odada kalan müşteri adı ile birlikte gösterilmektedir. Yeni müşterinin kalacağı oda boş olan odalardan birine tıklanılarak seçilir. Müşteri ekleme işlemi bu şekilde gerçekleştirilir.

![](https://github.com/SimgeTerzioglu/PansiyonUygulamasi/blob/master/musteriekle.png)

# Odalar:
Odalar sayfasında sadece odalar bulunmaktadır. Dolu olan odalar kırmızı bir renk ile gösterilir. Müşterinin adı ve hangi tarihte çıkış yapacağı da gösterilmektedir. Müşterilerin çıkış tarihi geçtikten sonra odalar tekrardan yeşil renge döner.
![](https://github.com/SimgeTerzioglu/PansiyonUygulamasi/blob/master/odalar.png)

# Müşteriler:
Bu butona tıklanıldığında listeleme, güncelleme, silme, temizleme ve arama işlemleri yapılabilmektedir.
* Listeleme butonuna tıklanıldığında kayıtlı olan tüm müşteriler aşağıdaki alanda listelenir. 
* Listenen müşterilerin id numarasına tıklandığında o müşterinin bilgileri yukarıdaki ilgili kutucuklara gelmektedir. Orada herhangi bir değişiklik yapılmasının ardından güncelle butonuna basıldığında müşterinin güncel bilgileri kaydedilmiş olur. 
* Sil butonuna tıklanıldığında müşteri silinir.
* Temizle butonuna basıldığında müşteri bilgilerinin gözüktüğü kutucuklar temizlenir. Bu alanlarda başka bir müşteri yeniden görüntülenebilir.
* Ara butonunun altındaki kutucuğa aranmak istenen müşterinin adı veya adı ve soyadı yazıldığında o isimdeki müşteriler listelenir.
![](https://github.com/SimgeTerzioglu/PansiyonUygulamasi/blob/master/musteribilgileri.png)

# Stok Bilgisi: 
Bu butona tıklanıldığında yiyecek malzemesi, içecek malzemesi ve temizlik malzemesi sayılarını girebileceğimiz alanlar gelmektedir. Gerekli sayıları girdiğimizde ekle ve azalt butonlarını kullanarak ekleme ve azaltma yapabiliriz. Her ekleme ve azaltma sonrasında güncel sayı tarihleriyle birlikte listelenir.
![](https://github.com/SimgeTerzioglu/PansiyonUygulamasi/blob/master/stokbilgileri.png)

# Çıkış:
Bu butona tıklanıldığında çıkış işlemi gerçekleştirilir.
