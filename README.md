這是一個適用於 **WPF + MVVM + SQL Server** 的登入系統範本 (`WPF-Login-MVVM-main`) 的 README 範本，你可以根據需求進一步調整內容。  

---

## **📌 WPF-Login-MVVM-main**  
🔥 **C# & SQL Server MVVM Login Template**  

### **📖 專案簡介**  
本專案是一個基於 **C# WPF (Windows Presentation Foundation)** 框架的登入系統，採用 **MVVM 架構**，並使用 **SQL Server** 作為後端資料庫。  

適合作為 **WPF 應用程式開發** 的登入功能範本，具有 **資料庫驗證、使用者管理、分層架構** 等基本功能。  

---

### **🛠️ 技術棧**
- **C# .NET** (WPF)  
- **MVVM 架構** (Model-View-ViewModel)  
- **SQL Server** (使用 ADO.NET 進行資料庫存取)  
- **Entity Framework / Dapper** (可選)  
- **XAML** (前端 UI 設計)  

---

### **📂 專案結構**
```
📦 WPF-Login-MVVM-main
│── 📁 Models          # 定義資料模型 (UserModel.cs)
│── 📁 ViewModels      # 負責 UI 邏輯 (LoginViewModel.cs, MainViewModel.cs)
│── 📁 Views           # XAML UI (LoginView.xaml, MainView.xaml)
│── 📁 Repositories    # 負責 SQL 資料庫存取 (UserRepository.cs)
│── 📁 Properties      # 應用程式設定檔
│── App.xaml          # WPF 入口
│── App.config        # SQL Server 連線設定
│── MainWindow.xaml   # 主視窗
│── README.md         # 本文件
```

---

### **⚙️ 環境設定**
#### **1️⃣ 安裝必要工具**
- **Visual Studio 2022** (建議)
- **SQL Server** (可使用 LocalDB 或 SQL Server Express)
- **SSMS (SQL Server Management Studio)** (用於管理資料庫)

#### **2️⃣ 建立 SQL Server 資料庫**
1. **開啟 SSMS**，建立新的資料庫 `MVVMLoginDb`
2. 建立 `User` 資料表：
   ```sql
   CREATE TABLE [dbo].[User] (
       Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
       Username NVARCHAR(50) NOT NULL UNIQUE,
       Password NVARCHAR(50) NOT NULL,
       Name NVARCHAR(100),
       LastName NVARCHAR(100),
       Email NVARCHAR(100) UNIQUE
   );
   ```
3. 插入測試資料：
   ```sql
   INSERT INTO [dbo].[User] (Username, Password, Name, LastName, Email)
   VALUES ('admin', 'admin', 'Jay', 'Code', 'jay@gmail.com');
   ```
![image](https://github.com/user-attachments/assets/57a7d396-8fda-4a53-aa0e-ae19200315c9)

#### **3️⃣ 設定 `App.config`**
修改 `App.config` 來匹配你的 SQL Server 連線：
```xml
<connectionStrings>
    <add name="DefaultConnection" 
         connectionString="Server=(local); Database=MVVMLoginDb; Integrated Security=True;"
         providerName="System.Data.SqlClient"/>
</connectionStrings>
```

---

### **🚀 執行專案**
1. **開啟 `WPF-Login-MVVM-main.sln` (Visual Studio 2022)**
2. **確保 SQL Server 正常運行**
3. **執行專案 (`F5`)**
4. 使用測試帳號登入：
   ```
   Username: admin
   Password: admin
   ```
![image](https://github.com/user-attachments/assets/4f6bd8dc-d354-4736-bd8d-5aa689f5e9c2)

---

### **🔧 主要功能**
✅ **使用者登入驗證** (SQL Server 驗證)  
✅ **MVVM 架構分離 UI 和邏輯**  
✅ **XAML UI 設計 (WPF)**  
✅ **使用 SQL Server 本機連線**  

---


### **📜 授權**
本專案基於 **MIT License**，歡迎自由修改與使用！ 😊  

---
