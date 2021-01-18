# SatisStokOtomasyonu
KULLANILAN TEKNOLOJİLER & GELİŞTİRME ORTAMI

Proje geliştirilirken C#, Windows Form, MSSQL Server veri tabanı kullanılmıştır. Bu teknolojilerin etkin olarak kullanılabilmesi için, yer yer Connected Mimari, 
daha hızlı işlem yapabilmek içinde yer yer DisConnected Mimari kullanılmıştır. Proje geliştirilirken toplamda dört modül kullanılmıştır.
Bu modüller müşteriler, ürünler, personeller, satışlar. Bu modüller işlevlerini layıkıyla icra ederler.

Proje front tarafında iki arayüz vardır, bunlardan biri müşterilerin giriş yapıp, ürün satın alabildikleri diğeri ise personellerin giriş yapıp ürün 
kaydedebildikleri ve satışların istatistiksel takipleri gibi işlemleri yapabilecekleri arayüzlerden oluşur. GİRİŞ SİSTEMİ Projede iki adet giriş bulunmaktadır. 
Bunlardan bir tanesi personel giriş diğeri ise kullanıcı giriştir.

Seçilen giriş türüne göre ilgili ekran kullanıcıya gösterilir. Burada amaç kullanıcılar ile personelleri birbirinden ayırmaktır. 
Tabi bu işlem yetki üstünden de gayet yapılabilirdi. Fakat burada eğer yetki üstünden bu işlem yapılırsa bazı problemlerle hem programatik olarak hem de güvenlik açısından 
bir takım zafiyetler doğurabilirdi. Örnek vermek gerekirse mesela database’in injection yemesi gibi durumlarda herhangi bir kullanıcının verileri 
çalındığında ilgili yetki kolonundan diğer yetkiyi bulmak o kadar da zor olmaz. Çünkü yetkiler genellikle 701 702 gibi tanımlanır. 
Programatik olarak doğurabileceği problemlere örnek vermek gerekirse inner join sorgularını yazarken bir takım sorunlar yaşabilirdik. Her defasında mesela yetki alanını 
belirtmek gibi. Özetle, iki tane giriş konulmasının sebebi budur. Zaten günümüzde birçok otomasyonun bu şekilde iki adet ya da daha fazla girişe sahip olduğu gözlemlenebilir.

Seçilen giriş türüne göre ilgili ekran kullanıcıya gösterilir. Burada amaç kullanıcılar ile personelleri birbirinden ayırmaktır.
Tabi bu işlem yetki üstünden de gayet yapılabilirdi. Fakat burada eğer yetki üstünden bu işlem yapılırsa bazı problemlerle hem programatik olarak hem de güvenlik açısından 
bir takım zafiyetler doğurabilirdi. Örnek vermek gerekirse mesela database’in injection yemesi gibi durumlarda herhangi bir kullanıcının verileri çalındığında ilgili yetki 
kolonundan diğer yetkiyi bulmak o kadar da zor olmaz.
Çünkü yetkiler genellikle 701 702 gibi tanımlanır. 
Programatik olarak doğurabileceği problemlere örnek vermek gerekirse inner join sorgularını yazarken bir takım sorunlar yaşabilirdik. Her defasında mesela yetki alanını 
belirtmek gibi. Özetle, iki tane giriş konulmasının sebebi budur. Zaten günümüzde birçok otomasyonun bu şekilde iki adet ya da daha fazla girişe sahip olduğu gözlemlenebilir. 
Personel arayüzünde personel ile ilgili işlemler yapılır. 
Aynı zamanda bu işlemlerin yanı sıra ilgili firmanın istatistikleri gözlemlenebilir. Açıklamak gerekirse, personelleri listele menüsü ile personeller üzerinde yeni 
personel ekleme mevcut personelin bilgilerini düzenleme, personel ile ilgili firmanın bağını kesme gibi özellikleri üzerinde bulundurur. Ürün işlemleri kısmına gelecek
olursak ilgili ürünlerin eklendiği kısımdır. 
Burada eklenilen ürün otomatik olarak kullanıcı tarafına yansır. 
Proje en temel anlamda bu fonksiyonlara sahiptir.
