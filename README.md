### C# ve MySql Kullanılarak Hazırlanmış Kütüphane Otomasyonu Projesi
# Projenin Amacı ve Kapsamı:
Projemizin amacı okulumuzda öğrenim görmekte olan öğrencilere kitap kayıt ve kitap işlemleri verilerinin saklayabilecek hızlıca sistemi kullanıp memurlara erişim imkanı sağlayacak, kitap, öğrenci akademisyen bilgilerini girmesini ve düzenlemesini kolayca yapabileceği bilgisayar destekli bir sistemin ortaya konmasıdır.
</br>
Bu amaç doğrultusunda kütüphanede bulunan kitapların takibi, emanet , öğrenci , akademisyen kaydı ve kütüphane memurlarının raporları veya istediği bilgiyi kolay bir şekilde araması gibi detaylar yer almaktadır.
</br>
# Proje Süreci ve İlerleyişi: 
a)İlk olarak kütüphane memurları ile görüşüp eksiklikleri ve hataları belirledik.
b)Memurların ihtiyaç ve isteklerine göre ilerleyiş sürecimizi taslağa dökebilmek için gereksinim analizi ve E&R diyagramı oluşturduk. 
c)Oluşturduğumuz taslaklara göre kullanım pratikliği ve değişkenlerin elverişliliği sağlayan **MySql** veritabanını kullanarak tablolarımızı oluşturduk.
d)Sade ve kolay kullanım sağlayan bir tasarım modeli oluşturduk.
e)**C#** kullanarak back end kodlarımızı oluşturduk ve projemizi tamamladık.
</br>
# Otomasyonun Kullanım Şekli ve Prensipleri:
1)Kullanıcı girişi için exe dosyasını açıyoruz ve bizi kullanıcı giriş ekranı karşılıyor.Kayıtlı bir kullanıcıysak bilgileri doldurup giriş yap tuşuna basıyoruz ve anasayfaya yönlendiriliyoruz.
</br>
2)Otomasyona kayıtlı değilsek kullanıcı giriş ekranından kayıt ol tuşuna basıyoruz ve kaydolma ekranını açıyoruz ve bilgileri doldurarak kaydol tuşuna basıyoruz ve kaydoluyoruz.
</br>
3)Kullanıcı bilgilerini doğru girip **Giriş Yap** butonuna bastıktan sonra bizi anasayfa karşılıyor ve soldaki menüden otomasyonun bütün fonksiyonlarına erişebiliyoruz.
</br>
4)Anasayfadan kullanıcı listesi butonuna basınca üye listesi açılıyor ve buradan üyeleri görüntüleyebiliyoruz.Adına , üye numarasına ve bölümüne göre arama yapabiliyoruz.
</br>
5)Kullanıcı ekle sayfasından üyeleri görüntüleyebiliyor aynı zamanda bölüm ve  üye ekleyebiliyoruz.
</br>
6)Kullanıcı güncelle sayfasından üyeleri görüntüleyebilir ve güncelleyebiliriz.
</br>
7)Kullanıcı sil bölümünden üyeleri görrüntüleyip silmek istediğimiz üyeyi seçiyoruz ve siliyoruz.
</br>
8)Anasayfadan kitap listesi butonuna basınca kitap listesi açılıyor ve buradan kitapları görüntüleyebiliyoruz.Adına , yazarına , demirbaş numarasına , çevirmenine ve yayınevine göre arama yapabiliyoruz.
</br>
9)Kitap ekle sayfasından kitapları görüntüleyebiliyor aynı zamanda kategori ve  kitap ekleyebiliyoruz.
</br>
10)Kitap güncelle sayfasından kitapları görüntüleyebilir adına , yazarına , demirbaş numarasına , çevirmenine ve yayınevine göre arama yaptıktan sonra güncelleyebiliriz.
</br>
11)Kitap sil sayfasından arattığımız kitabı seçip silebiliriz.
</br>
12)Ödünç ver sayfasından üye bilgilerini ve kitap ismini aratıp **Ödünç Ver** butonuna basarsak alttaki datagridView da ödünç tablosu görünecektir ve kitap emanet edilecektir.
</br>
13)Geri al sayfasından emanetin teslim durumu kontrol edebilir alış tarihine , son teslim tarihine ve teslim edildiği tarihe erişebilir kitabın teslim edilmemişse emanete tıklatıp Geri Al butonuna basarsak kitap emanet verilmiş gözükecektir ve hem kitap listesinde rafta olarak gözükecetir.
</br>
14)Raporlar butonuna basarak kütüphane içerisinde memurun ihtiyacı olan istatistikler verilere ulaşabiliriz.
</br>
15)Kitap ekle veya güncelle listesinden durumu **kayıp** olarak belirtilmiş kitap varsa kaybolan kitaplar sayfasında görünür ve daha sonra bulunması durumunda kitabın durumu değiştirilerek rafa tekrar eklenir.
</br>
