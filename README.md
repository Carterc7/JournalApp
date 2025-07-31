# 📖 JournalApp

A beautiful, modern personal journaling web application built with ASP.NET Core and Entity Framework. Capture your thoughts, experiences, and memories with an intuitive and elegant interface.

![JournalApp Screenshot](https://via.placeholder.com/800x400/6366f1/ffffff?text=JournalApp+Preview)

## ✨ Features

- **📝 Create & Edit**: Write and modify journal entries with a rich text interface
- **👁️ View**: Read your entries with beautiful formatting and metadata display
- **🗑️ Delete**: Safely remove entries with confirmation dialogs
- **📱 Responsive Design**: Works perfectly on desktop, tablet, and mobile devices
- **🎨 Modern UI**: Clean, intuitive interface with smooth animations
- **💾 Persistent Storage**: All entries are saved to a SQL Server database
- **🔄 Real-time Updates**: See changes immediately across all pages

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

## 🎨 Design Features

### Color Scheme
- **Primary**: Indigo (#6366f1) with purple (#8b5cf6) accents
- **Background**: Subtle gradient from light gray to white
- **Journal Entries**: Light slate background for better contrast
- **Success/Error**: Emerald green and red for status indicators

### Interactive Elements
- **Hover Effects**: Cards lift and shadows change on hover
- **Smooth Transitions**: All interactions have 0.3s ease transitions
- **Form Focus**: Input fields have subtle animations when focused
- **Button Animations**: Buttons lift slightly on hover

### Responsive Design
- **Mobile-First**: Optimized for all screen sizes
- **Flexible Layout**: Cards adapt to different viewport widths
- **Touch-Friendly**: Large touch targets for mobile devices

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

### Customization
- **Colors**: Modify CSS variables in `wwwroot/css/site.css`
- **Styling**: Update Bootstrap classes and custom CSS
- **Functionality**: Extend models and add new features

## 📝 Usage

### Creating a Journal Entry
1. Click "New Entry" on the main page
2. Enter a title and your thoughts
3. Click "Save Entry" to store your entry

### Managing Entries
- **View**: Click "View" to read the full entry
- **Edit**: Click "Edit" to modify an existing entry
- **Delete**: Click "Delete" and confirm to remove an entry

### Navigation
- Use the navbar to quickly access different sections
- Breadcrumb navigation helps you know where you are
- All pages have clear "Back" buttons

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet) for the robust web framework
- [Bootstrap](https://getbootstrap.com/) for the responsive UI components
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) for data access
- [Bootstrap Icons](https://icons.getbootstrap.com/) for the beautiful icons

## 📞 Support

If you have any questions or need help, please:
- Open an [Issue](https://github.com/Carterc7/JournalApp/issues)
- Check the [Wiki](https://github.com/Carterc7/JournalApp/wiki) for documentation
- Contact the maintainer

---

**Made with ❤️ by [Carterc7](https://github.com/Carterc7)**

*Start your journaling journey today!* 