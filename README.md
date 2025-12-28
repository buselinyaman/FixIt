---------------------------------------------------
TR
---------------------------------------------------
🔧 FixIt - Smart Repair Management System

FixIt, kullanıcıların arıza ve tamir taleplerini oluşturabildiği, teknisyenlerin bu talepleri yönetebildiği modern bir tamir yönetim sistemidir.
ASP.NET Core Web API, Entity Framework Core ve JWT Authentication teknolojileriyle geliştirilmiştir.

🚀 Özellikler

🔐 JWT Tabanlı Kimlik Doğrulama
Kullanıcılar güvenli token sistemiyle kayıt olabilir ve giriş yapabilir.

👥 Rol Bazlı Yetkilendirme
Customer, Technician ve Admin rolleriyle erişim kontrolü.

🧾 Tamir Talepleri Yönetimi
Kullanıcılar arıza talebi oluşturabilir, teknisyenler kabul edip tamamlayabilir.

🗂️ Entity Framework Core Entegrasyonu
SQL Server üzerinde güçlü veritabanı ilişkileri.

🖥️ Dashboard (HTML + JS)
Basit ama işlevsel bir arayüzle tamir taleplerini görüntüleme ve işlem yapma.

📘 Swagger UI
API uç noktalarını test etmek için otomatik oluşturulmuş etkileşimli arayüz.

🧩 Kullanılan Teknolojiler
Teknoloji	Açıklama
ASP.NET Core 9.0	Web API altyapısı
Entity Framework Core	ORM ve veritabanı işlemleri
SQL Server	Veritabanı yönetim sistemi
JWT (Json Web Token)	Kimlik doğrulama ve yetkilendirme
Swagger / Swashbuckle	API dökümantasyonu
HTML, CSS, JS	Dashboard arayüzü
⚙️ Kurulum Adımları
1️⃣ Projeyi klonla
git clone https://github.com/buselinyaman/FixIt.git
cd FixIt

2️⃣ Bağımlılıkları yükle
dotnet restore

3️⃣ Veritabanını oluştur
dotnet ef database update

4️⃣ Uygulamayı çalıştır
dotnet run

5️⃣ Tarayıcıdan eriş

Swagger → https://localhost:7072/swagger

Dashboard → https://localhost:7072/dashboard.html

📁 Proje Yapısı
FixIt/
 ┣ Controllers/
 ┃ ┣ AuthController.cs
 ┃ ┣ RequestsController.cs
 ┃ ┗ UsersController.cs
 ┣ Data/
 ┃ ┗ AppDbContext.cs
 ┣ DTOs/
 ┃ ┣ LoginDto.cs
 ┃ ┗ RegisterDto.cs
 ┣ Models/
 ┃ ┣ User.cs
 ┃ ┣ RepairRequest.cs
 ┃ ┣ Category.cs
 ┃ ┗ UserRefreshToken.cs
 ┣ wwwroot/
 ┃ ┣ index.html
 ┃ ┗ dashboard.html
 ┣ appsettings.json
 ┣ Program.cs
 ┗ FixIt.csproj

🔐 JWT Ayarları

appsettings.json içinde JWT ayarlarını şu şekilde ekleyin:

"Jwt": {
  "Key": "super_secret_key_12345",
  "Issuer": "FixItApp",
  "Audience": "FixItUsers",
  "ExpireMinutes": 60
}

🧠 API Kullanımı
🔸 Kayıt Ol (Register)

POST /api/Auth/register

{
  "username": "selinyaman",
  "email": "selin@fixit.com",
  "password": "123456"
}

🔸 Giriş Yap (Login)

POST /api/Auth/login

{
  "email": "selin@fixit.com",
  "password": "123456"
}


➡️ Başarılı giriş sonrası JWT token döner.

🔸 Tüm Talepleri Görüntüle

GET /api/Requests

🔸 Talebi Kabul Et

POST /api/Requests/accept/{id}

🔸 Talebi Tamamla

POST /api/Requests/complete/{id}

🔮 Planlanan Geliştirmeler
Özellik	Açıklama
🔁 Refresh Token Desteği	Access token süresi dolduğunda otomatik yenileme
🧂 Gelişmiş Şifreleme	Salt + Hash sistemi ile ekstra güvenlik
🧩 Kategori Bazlı Eşleşme	Teknisyenler uzmanlık alanına göre atanacak
⚙️ Akıllı Teknisyen Eşleştirme	Algoritmik en uygun teknisyen seçimi
👑 Admin Paneli	Kullanıcı, talep ve sistem yönetimi
📈 İstatistiksel Raporlama	Aylık iş yükü, başarı oranı ve müşteri memnuniyeti
✅ Unit & Integration Testler	xUnit ile otomasyon testleri
🌍 Çoklu Dil Desteği	TR/EN arayüz seçeneği

👩‍💻 Geliştirici

Buse Selin Yaman
💻 ASP.NET | C# | Entity Framework | Web API
📧 selinyaman3000@gmail.com
---------------------------------------------------
EN
---------------------------------------------------
🔧 FixIt - Smart Repair Management System

FixIt is a modern repair management system that allows users to submit repair requests and technicians to manage and complete them efficiently.
Built using ASP.NET Core Web API, Entity Framework Core, and JWT Authentication technologies.

🚀 Features

🔐 JWT-Based Authentication
Secure user registration and login with token-based sessions.

👥 Role-Based Authorization
Roles: Customer, Technician, and Admin.

🧾 Repair Request Management
Customers can create repair requests; technicians can accept and complete them.

🗂️ Entity Framework Core Integration
Strong database management with SQL Server.

🖥️ Dashboard (HTML + JS)
Simple and intuitive web interface for viewing and managing repair requests.

📘 Swagger UI
Interactive documentation and testing for all API endpoints.

🧩 Technologies Used
Technology	Purpose
ASP.NET Core 9.0	Web API framework
Entity Framework Core	ORM and database operations
SQL Server	Database management system
JWT (JSON Web Token)	Authentication and authorization
Swagger / Swashbuckle	API documentation
HTML, CSS, JS	Dashboard front-end
⚙️ Installation Guide
1️⃣ Clone the project
git clone https://github.com/buselinyaman/FixIt.git
cd FixIt

2️⃣ Restore dependencies
dotnet restore

3️⃣ Apply database migrations
dotnet ef database update

4️⃣ Run the application
dotnet run

5️⃣ Access in your browser

Swagger → https://localhost:7072/swagger

Dashboard → https://localhost:7072/dashboard.html

📁 Project Structure
FixIt/
 ┣ Controllers/
 ┃ ┣ AuthController.cs
 ┃ ┣ RequestsController.cs
 ┃ ┗ UsersController.cs
 ┣ Data/
 ┃ ┗ AppDbContext.cs
 ┣ DTOs/
 ┃ ┣ LoginDto.cs
 ┃ ┗ RegisterDto.cs
 ┣ Models/
 ┃ ┣ User.cs
 ┃ ┣ RepairRequest.cs
 ┃ ┣ Category.cs
 ┃ ┗ UserRefreshToken.cs
 ┣ wwwroot/
 ┃ ┣ index.html
 ┃ ┗ dashboard.html
 ┣ appsettings.json
 ┣ Program.cs
 ┗ FixIt.csproj

🔐 JWT Configuration

Add the following section to your appsettings.json file:

"Jwt": {
  "Key": "super_secret_key_12345",
  "Issuer": "FixItApp",
  "Audience": "FixItUsers",
  "ExpireMinutes": 60
}

🧠 API Endpoints
🔸 Register

POST /api/Auth/register

{
  "username": "selinyaman",
  "email": "selin@fixit.com",
  "password": "123456"
}

🔸 Login

POST /api/Auth/login

{
  "email": "selin@fixit.com",
  "password": "123456"
}


➡️ Returns a JWT token on successful authentication.

🔸 Get All Requests

GET /api/Requests

🔸 Accept a Request

POST /api/Requests/accept/{id}

🔸 Complete a Request

POST /api/Requests/complete/{id}

🔮 Future Improvements
Feature	Description
🔁 Refresh Token Support	Automatically renew expired tokens
🧂 Enhanced Password Security	Salt + Hash encryption for passwords
🧩 Category-Based Assignment	Assign technicians based on expertise
⚙️ Smart Technician Matching	Algorithmic matching for optimal technician selection
👑 Admin Panel	Manage users, requests, and system settings
📈 Reporting and Analytics	Monthly workload and performance reports
✅ Unit & Integration Tests	Automated testing with xUnit
🌍 Multi-Language Support	Turkish / English interface options

👩‍💻 Developer
Buse Selin Yaman
💻 ASP.NET | C# | Entity Framework | Web API
📧 selinyaman3000@gmail.com
