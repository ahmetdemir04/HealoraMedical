# Stok Takip Programı

Healora – Akıllı Hastane Otomasyon Sistemi

Healora, kişisel gelişim amacıyla prototip olarak geliştirilmiş, modüler yapıya sahip bir hastane otomasyon sistemidir. Doktor, sekreter ve hasta olmak üzere üç ana kullanıcı rolünü destekleyen bu sistem, sağlık süreçlerini dijital ortamda daha düzenli ve erişilebilir hale getirmeyi hedefler.

- Hastalar, sistem üzerinden kolayca randevu alabilir, geçmiş ve gelecek randevularını görüntüleyebilir, kronik - hastalık bilgilerine ulaşabilir ve istedikleri doktordan randevu talebinde bulunabilirler.

- Sekreterler, doktor ve hasta işlemlerini kolaylıkla yönetebilir; randevuları düzenleyebilir, doktor bilgilerini güncelleyebilir, hastalar adına randevu oluşturabilir ve genel duyurular paylaşabilir.

- Doktorlar ise günlük randevu listesini saat bazlı olarak görüntüleyebilir, hastaları sırasıyla kabul edebilir ve tedavi süreci için gerekli ilaç ve teşhis bilgilerini detaylı olarak kaydedebilir.

<p>Programın çalışır halde bulunan video: {https://youtu.be/I1IvXdikRns}
 
# Proje Veritabanının Kurulumu ve Yapılandırılması
<p>Uygulamanın veritabanını kendi SQL Server Management Studio ortamınıza eklemek için aşağıdaki adımları takip ediniz:</p>
1. SQL Server Management Studio'yu açınız. <br>
2. Sol kısımdaki Databases bölümüne sağ tıklayarak Restore Database seçeneğine tıklayınız.<br>
3. Açılan panelde Device radio butonuna tıklayıp yanındaki 3 noktaya tıklayınız.<br>
4. Açılan panelde "Add" butonuna basınız.<br>
5. Açılan dosya gezgininde "DbHealoraMedical.bak" dosyasını nereye koyduysanız onu bulup seçiniz.<br>
6. Seçtikten sonra açık olan tüm panelerde okay, okay diyerek database kurunuz. <br>
6. Ardından Visual Studio ortamında App.config dosyasını açınız. <br>
7. ConnectionStrings etkiketinin içerisindeki datasource kısmına kendi local data base isminizi yazınız. <br>

Belirtilen adımları eksiksiz uyguladığınız takdirde proje sorunsuz bir şekilde çalışacaktır.

## Giriş Ekranı Sayfası

![img](Screenshots/direction.png)

## Doktor Giriş Sayfası

![img](Screenshots/dr1.png)

## Doktor İşlem Sayfaı

![img](Screenshots/dr2.png)

## Kronik Hastalıkları Görme Sayfası

![img](Screenshots/dr3.png)

## Sekreter Giriş Sayfası

![img](Screenshots/skt1.png)

## Sekreter İşlem Sayfaı

![img](Screenshots/skt2.png)

## Aktif Randevuları Görme Sayfası

![img](Screenshots/skt3.png)

## Doktor Ekleme/Silme/Güncelleme Sayfası

![img](Screenshots/skt4.png)

## Hasta Ekleme/Silme/Güncelleme Sayfası

![img](Screenshots/skt5.png)

## Randevu Ekleme/Silme/Güncelleme Sayfası

![img](Screenshots/skt6.png)

## Duyuru Ekleme Sayfası

![img](Screenshots/dy1.png)

## Hasta Giriş Sayfası

![img](Screenshots/pt1.png)

## Hasta İşlem Sayfaı

![img](Screenshots/pt2.png)

## Hasta Randevu Alma Sayfaı

![img](Screenshots/pt3.png)
