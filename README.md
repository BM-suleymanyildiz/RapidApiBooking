# 🏨 Otel Arama Proje Tanımı (Booking.com API Entegrasyonu)

Bu proje, RapidAPI üzerinde bulunan Booking.com API'si kullanılarak geliştirilmiş bir otel arama ve listeleme uygulamasıdır. Kullanıcıların belirlediği kriterlere uygun otelleri API üzerinden çekip web sitesinde listeleme işlemi gerçekleştirilmiştir.

## 🔍 Anasayfa İşlevselliği

Anasayfa, kullanıcıların otel arama kriterlerini girmesi için tasarlanmıştır. Kullanıcılardan aşağıdaki bilgiler alınır:

- 🗺️ Filtrelemek istedikleri şehir bilgisi  
- 📅 Giriş ve çıkış tarihleri  
- 👤 Yetişkin kişi sayısı  
- 🧒 Çocuk sayısı  

## ✔️ Sonuç Sayfası & Detay Görüntüleme

Girilen kriterlere uyan oteller liste halinde gösterilir. Kullanıcılar, listelenen otellerin temel bilgilerini görebilir ve daha detaylı bilgi almak için otelin üzerine tıklayabilirler.

Gösterilen bilgiler:

- 🏠 Otel adı  
- ⭐ Otel puanı  
- 👥 Kaç kişi tarafından değerlendirme yapıldığı  
- 💰 Fiyat bilgisi  
- ℹ️ Adres, şehir, ülke  
- 🖼️ Otele ait fotoğraflar  
- 🛁 Otel olanakları (Amenities)  

## 🛠️ Kullanılan Teknolojiler

- 💻 ASP.NET Core (8.0) – Projenin temel geliştirme çatısıdır.  
- 🏗️ Tek Katmanlı Mimari – Hızlı geliştirme ve basitlik adına tercih edilmiştir.  
- 🌐 Booking.com API (RapidAPI üzerinden) – Otel verilerini çekmek için kullanılan API.  

### 📡 Kullanılan Booking.com API Endpoint’leri

- 🔍 **Auto Complete Endpoint:**  
  Kullanıcının girdiği şehir bilgisine karşılık gelen City ID ve Destination ID gibi konum verileri elde edildi.

- 🏨 **Search Hotels Endpoint:**  
  Elde edilen Destination ID ve diğer filtreleme kriterleri (giriş/çıkış tarihleri, yetişkin/çocuk sayısı) kullanılarak otellerin listesi çekildi.

- 🖼️ **Get Hotel Photos Endpoint:**  
  Listelenen otellerin Hotel ID’leri kullanılarak ilgili otellere ait fotoğraflar elde edildi.

- ℹ️ **Get Hotel Details Endpoint:**  
  Seçilen bir otelin tüm detaylı bilgilerini (açıklama, fiyat dökümü, daha fazla fotoğraf, olanaklar, inceleme skorları vb.) çekmek için kullanıldı.

## 📦 ViewModel Yapıları ve Veri Yönetimi

- API'den gelen karmaşık JSON verilerini uygulamanın ihtiyaçlarına göre karşılamak, yönetmek ve View katmanına düzenli bir şekilde aktarmak için özel ViewModel sınıfları oluşturulmuştur.
- `HttpClient`: API isteklerini güvenli ve etkin bir şekilde göndermek ve yanıtları almak için kullanılmıştır.
- `Newtonsoft.Json`: API'den gelen JSON formatındaki verilerin C# nesnelerine dönüştürülmesi (deserialization) ve C# nesnelerinin JSON'a dönüştürülmesi (serialization) işlemleri için kullanılmıştır.

## ⚙️ Proje Detayları ve İş Akışı

1. **Şehir ID’si ve Destination ID’si Elde Etme**  
   Kullanıcının girdiği şehir bilgisi Auto Complete Endpoint’e parametre olarak gönderilir. Bu istekten dönen yanıttan, ilgili şehrin benzersiz City ID’si ve otel aramalarında kullanılacak Destination ID’si alınır.

2. **Otel Listesi Çekme**  
   Destination ID ve kullanıcının belirttiği giriş/çıkış tarihleri, yetişkin/çocuk sayıları gibi filtreleme kriterleri Search Hotels Endpoint’e gönderilir. Bu sayede kriterlere uygun otellerin listesi alınır.

3. **Otel Detayları ve Fotoğrafları Çekme**  
   Kullanıcı bir otele tıkladığında, otelin Hotel ID’si kullanılarak hem Get Hotel Details hem de Get Hotel Photos endpoint’lerine istek gönderilir.  
   - Get Hotel Details Endpoint’inden: Açıklama, oda detayları, fiyat bilgileri, olanaklar, yorum skorları gibi bilgiler alınır.  
   - Get Hotel Photos Endpoint’inden: Yüksek çözünürlüklü otel fotoğrafları alınır.

4. **Veri Yönetimi**  
   Tüm veriler, önceden tanımlanmış özel ViewModel sınıfları aracılığıyla C# nesnelerine dönüştürülür ve uygulamanın ihtiyaç duyduğu şekilde kullanılır. Bu sayede veri bütünlüğü korunur ve kod okunabilirliği artırılır.

## 🖼️ Proje Görselleri

<img width="2121" height="1018" alt="Ekran görüntüsü 2025-07-14 225138" src="https://github.com/user-attachments/assets/57cf94e1-30c1-4b9f-9420-c62844d5ba19" />

<img width="1357" height="718" alt="Ekran görüntüsü 2025-07-14 225151" src="https://github.com/user-attachments/assets/65b55496-8d5f-4b3a-8b74-554a1b9e5167" />

<img width="1031" height="1079" alt="Ekran görüntüsü 2025-07-14 225220" src="https://github.com/user-attachments/assets/25bdf031-2368-4c8c-babf-2a5b4e1715cf" />

<img width="876" height="818" alt="Ekran görüntüsü 2025-07-14 225243" src="https://github.com/user-attachments/assets/c9a60467-917d-4287-b086-b852a2a865d5" />



