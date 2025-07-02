```markdown
# 🧪 ASP.NET + SQL Server: Stored Procedure Demo

This is a basic training/demo repository demonstrating how to connect an **ASP.NET Core** web application to a **SQL Server database** using **stored procedures** and **ADO.NET**.

It’s ideal for students, beginners, or developers learning how to use database procedures in .NET applications.

---

## 🧩 What’s Covered

- Using stored procedures with ADO.NET
- Basic CRUD operations
- SQL Server integration
- Connecting via `SqlConnection`, `SqlCommand`, etc.
- Frontend-to-database flow in ASP.NET

---

## 📁 Folder Structure

```

ASP.NET\_DATBASE\_PROCEDURS/
├─ Controllers/
│  └─ StudentController.cs       # Handles HTTP actions
├─ Models/
│  └─ Student.cs                 # Student model
├─ Views/
│  └─ Student/                   # Razor views (Index, Add, Edit, etc.)
├─ StoredProcedures.sql          # SQL script with CREATE PROCEDURE statements
├─ appsettings.json              # DB connection string
├─ Program.cs / Startup.cs       # ASP.NET Core startup files
└─ README.md

````

---

## 🛠 How to Run

1. **Clone the repo**
   ```bash
   git clone https://github.com/Krutik090/ASP.NET_DATBASE_PROCEDURS.git
   cd ASP.NET_DATBASE_PROCEDURS
````

2. **Configure SQL Server**

   * Open `StoredProcedures.sql` in SQL Server and run it to create the required procedures and table.
   * Update your connection string in `appsettings.json`.

3. **Run the project**

   * Open in **Visual Studio**
   * Press `F5` or click **Start**

---

## ✅ Prerequisites

* .NET Core SDK (>= 6.0)
* SQL Server (LocalDB or full version)
* Visual Studio 2022 (recommended)

---

## 🙋‍♂️ Author

**Krutik Thakar**
GitHub: [@Krutik090](https://github.com/Krutik090)

---

## 📄 License

This repository is for educational and training purposes. No license applied.

```

---

### 📌 Notes:

- Since this is **just a training/demo repo**, I’ve added “no license applied” at the bottom. You can still add a license (like MIT) if you plan to open it up for public use.
- The folder structure assumes you're following the default MVC layout in ASP.NET Core.

```
