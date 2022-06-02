### C# ve MySql Kullanılarak Hazırlanmış Kütüphane Otomasyonu Projesi
# Projenin Amacı ve Kapsamı:
Projemizin amacı okulumuzda öğrenim görmekte olan öğrencilere kitap kayıt ve kitap işlemleri verilerinin saklayabilecek hızlıca sistemi kullanıp memurlara erişim imkanı sağlayacak, kitap, öğrenci akademisyen bilgilerini girmesini ve düzenlemesini kolayca yapabileceği bilgisayar destekli bir sistemin ortaya konmasıdır.
</br>
Bu amaç doğrultusunda kütüphanede bulunan kitapların takibi, emanet , öğrenci , akademisyen kaydı ve kütüphane memurlarının raporları veya istediği bilgiyi kolay bir şekilde araması gibi detaylar yer almaktadır.
</br>
# Proje Süreci ve İlerleyişi: 
a)İlk olarak kütüphane memurları ile görüşüp eksiklikleri ve hataları belirledik.
</br>
b)Memurların ihtiyaç ve isteklerine göre ilerleyiş sürecimizi taslağa dökebilmek için gereksinim analizi ve E&R diyagramı oluşturduk. 
</br>
c)Oluşturduğumuz taslaklara göre kullanım pratikliği ve değişkenlerin elverişliliği sağlayan **MySql** veritabanını kullanarak tablolarımızı oluşturduk.
</br>
d)Sade ve kolay kullanım sağlayan bir tasarım modeli oluşturduk.
</br>
e)**C#** kullanarak back end kodlarımızı oluşturduk ve projemizi tamamladık.
</br>
# Otomasyonun Kullanım Şekli ve Prensipleri:
1)Kullanıcı girişi için exe dosyasını açıyoruz ve bizi kullanıcı giriş ekranı karşılıyor.Kayıtlı bir kullanıcıysak bilgileri doldurup giriş yap tuşuna basıyoruz ve anasayfaya yönlendiriliyoruz.
</br>
![girispaneli](https://user-images.githubusercontent.com/100084384/171525572-acf2ad2c-5546-4d50-a9f3-3f5ed01e4bd4.JPG)
</br>
2)Otomasyona kayıtlı değilsek kullanıcı giriş ekranından kayıt ol tuşuna basıyoruz ve kaydolma ekranını açıyoruz ve bilgileri doldurarak kaydol tuşuna basıyoruz ve kaydoluyoruz.
</br>
![kaydolekrani](https://user-images.githubusercontent.com/100084384/171525738-34238d9a-abef-4481-8449-20d3d53cdd21.JPG)
</br>
3)Kullanıcı bilgilerini doğru girip **Giriş Yap** butonuna bastıktan sonra bizi anasayfa karşılıyor ve soldaki menüden otomasyonun bütün fonksiyonlarına erişebiliyoruz.
![anasayfa](https://user-images.githubusercontent.com/100084384/171525816-f4858ad5-3c0c-4651-b862-a277e0b57869.JPG)
</br>
4)Anasayfadan kullanıcı listesi butonuna basınca üye listesi açılıyor ve buradan üyeleri görüntüleyebiliyoruz.Adına , üye numarasına ve bölümüne göre arama yapabiliyoruz.
![kullanicilistesi](https://user-images.githubusercontent.com/100084384/171525899-08fb40d5-8056-416e-ab56-17163b7cd7db.JPG)
</br>
5)Kullanıcı ekle sayfasından üyeleri görüntüleyebiliyor aynı zamanda bölüm ve üye ekleyebiliyoruz.
![kullaniciekle](https://user-images.githubusercontent.com/100084384/171525956-09285988-3858-4bb6-940c-0f82a996a649.JPG)
</br>
6)Kullanıcı güncelle sayfasından üyeleri görüntüleyebiliyoruz ve güncelleyebiliyoruz.
</br>
![kullaniciguncelle](https://user-images.githubusercontent.com/100084384/171526020-ed747d44-8438-48c6-979b-737b64d337f6.JPG)
7)Kullanıcı sil bölümünden üyeleri görrüntüleyip silmek istediğimiz üyeyi seçiyoruz ve siliyoruz.
![kullanicisil](https://user-images.githubusercontent.com/100084384/171526060-13a426db-d6de-46ef-848f-d0d6d78727cc.JPG)
</br>
8)Anasayfadan kitap listesi butonuna basınca kitap listesi açılıyor ve buradan kitapları görüntüleyebiliyoruz.Adına , yazarına , demirbaş numarasına , çevirmenine ve yayınevine göre arama yapabiliyoruz.
![kitaplistesi](https://user-images.githubusercontent.com/100084384/171526147-cedfdf29-e832-4919-b69a-4daf4344617c.JPG)
</br>
9)Kitap ekle sayfasından kitapları görüntüleyebiliyor aynı zamanda kategori ve kitap ekleyebiliyoruz.
![kitapekle](https://user-images.githubusercontent.com/100084384/171526188-54845faa-3b57-43f4-b9c4-72edb097f04d.JPG)
</br>
10)Kitap güncelle sayfasından kitapları görüntüleyebilir adına , yazarına , demirbaş numarasına , çevirmenine ve yayınevine göre arama yaptıktan sonra güncelleyebiliriz.
![kitapguncelle](https://user-images.githubusercontent.com/100084384/171526249-31b5c221-b4e5-4bd9-964e-53c92611e36a.JPG)
</br>
11)Kitap sil sayfasından arattığımız kitabı seçip silebiliriz.
![kitapsil](https://user-images.githubusercontent.com/100084384/171526292-a45bcd5c-b819-47df-a139-d4c30ecc40ed.JPG)
</br>
12)Ödünç ver sayfasından üye bilgilerini ve kitap ismini aratıp **Ödünç Ver** butonuna basarsak alttaki datagridView da ödünç tablosu görünecektir ve kitap emanet edilecektir.
![oduncver](https://user-images.githubusercontent.com/100084384/171526421-93112464-6276-4df8-943a-7092f423cd38.JPG)
</br>
13)Geri al sayfasından emanetin teslim durumu kontrol edebilir alış tarihine , son teslim tarihine ve teslim edildiği tarihe erişebilir kitabın teslim edilmemişse emanete tıklatıp **Geri Al** butonuna basarsak kitap emanet verilmiş ve kitap listesinde rafta olarak gözükecektir.
![gerial](https://user-images.githubusercontent.com/100084384/171526469-811b0358-3eac-4fd5-bab4-820f99efb7c5.JPG)
</br>
14)Raporlar butonuna basarak kütüphane içerisinde memurun ihtiyacı olan istatistikler verilere ulaşabiliriz.
![raporlar](https://user-images.githubusercontent.com/100084384/171526544-389f072e-33b8-4636-8b3b-801206a6314e.JPG)
</br>
15)Kitap ekle veya güncelle listesinden durumu **kayıp** olarak belirtilmiş kitap varsa kaybolan kitaplar sayfasında görünür ve daha sonra bulunması durumunda kitabın durumu değiştirilerek rafa tekrar eklenir.
![kayipkitap](https://user-images.githubusercontent.com/100084384/171526558-e291ac30-823f-4b33-9cc4-3c058fb94918.JPG)
</br>
