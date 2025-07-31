# 📖 JournalApp

A modern personal journaling web application built with ASP.NET Core and Entity Framework. Capture your thoughts, experiences, and memories with an intuitive and elegant interface.

## ✨ Features

- **📝 Create & Edit**: Write and modify journal entries with a rich text interface
- **👁️ View**: Read your entries with beautiful formatting and metadata display
- **🗑️ Delete**: Safely remove entries with confirmation dialogs
- **📱 Responsive Design**: Works perfectly on desktop, tablet, and mobile devices

## 🛠️ Technology Stack

- **Backend**: ASP.NET Core 9.0
- **Frontend**: Razor Pages, Bootstrap 5, CSS3
- **Database**: SQL Server with Entity Framework Core
- **Styling**: Custom CSS with modern gradients and animations
- **Icons**: Bootstrap Icons
- **Development**: C# 12, LINQ, Dependency Injection

## 🚀 Getting Started

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB or Express)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Carterc7/JournalApp.git
   cd JournalApp
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Update database connection**
   - Open `appsettings.json`
   - Update the `DefaultConnection` string to point to your SQL Server instance

4. **Run database migrations**
   ```bash
   dotnet ef database update
   ```

5. **Start the application**
   ```bash
   dotnet run
   ```

6. **Open your browser**
   - Navigate to `https://localhost:5001` or `http://localhost:5000`

## 📁 Project Structure

```
JournalApp/
├── Data/
│   └── ApplicationDbContext.cs      # Database context
├── Models/
│   └── JournalPost.cs              # Journal entry model
├── Pages/
│   ├── Journal/
│   │   ├── Create.cshtml           # Create new entry
│   │   ├── Edit.cshtml             # Edit existing entry
│   │   ├── Delete.cshtml           # Delete entry
│   │   └── View.cshtml             # View entry details
│   ├── Journal.cshtml              # Main journal list
│   └── Shared/
│       └── _Layout.cshtml          # Main layout template
├── wwwroot/
│   └── css/
│       └── site.css                # Custom styling
└── Program.cs                      # Application entry point
```

## 🔧 Configuration

### Database Connection
Update the connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=JournalApp;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

## 📝 Usage

### Creating a Journal Entry
1. Click "New Entry" on the main page
2. Enter a title and your thoughts
3. Click "Save Entry" to store your entry

### Managing Entries
- **View**: Click "View" to read the full entry
- **Edit**: Click "Edit" to modify an existing entry
- **Delete**: Click "Delete" and confirm to remove an entry


## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

**Made with ❤️ by [Carterc7](https://github.com/Carterc7)**

*Start your journaling journey today!*
