# TodoList Application

## Overview

The TodoList application is a simple web-based task management tool built using ASP.NET Core. It allows users to create, edit, and delete tasks, providing a straightforward interface for managing daily activities. The application is designed to be user-friendly and efficient, making it easy for users to keep track of their tasks.

## Features

- **User Authentication**: Secure login and registration system to manage user accounts.
- **Task Management**: Create, read, update, and delete (CRUD) operations for tasks.
- **Responsive Design**: Built with Bootstrap to ensure a seamless experience across devices.
- **Client-side Validation**: Utilizes jQuery Validation for form validation to enhance user experience.
- **Session Management**: Maintains user sessions to keep track of logged-in users.
- **Privacy Policy Page**: A dedicated page to inform users about data handling practices.

## Technologies Used

- **Backend**: ASP.NET Core 8.0
- **Frontend**: HTML, CSS, JavaScript, Bootstrap, jQuery
- **Database**: SQL Server with Entity Framework Core
- **Session Management**: ASP.NET Core Session
- **Version Control**: Git for version control and collaboration

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or any compatible IDE

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/TodoList.git
   cd TodoList
   ```

2. **Restore the NuGet packages**:
   ```bash
   dotnet restore
   ```

3. **Update the database connection string** in `appsettings.json` to match your SQL Server setup.

4. **Run the database migrations**:
   ```bash
   dotnet ef database update
   ```

5. **Start the application**:
   ```bash
   dotnet run
   ```

6. **Open your browser** and navigate to `http://localhost:5282` (or the URL specified in `launchSettings.json`).

## Usage

- **Creating a Task**: Click on "New Note" in the navigation bar to create a new task. Fill in the title and content, then submit the form.
- **Viewing Tasks**: The main page displays a list of your tasks. Each task shows its title and content.
- **Editing a Task**: Click on the "edit" button next to a task to modify it. Update the fields and submit the form.
- **Deleting a Task**: Click on the "delete" button next to a task to remove it from your list.
- **User Authentication**: Users can log in or register to manage their tasks securely.

## Contributing

Contributions are welcome! If you have suggestions for improvements or new features, please feel free to submit a pull request or open an issue.

### How to Contribute

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Push your branch to your forked repository.
5. Submit a pull request to the main repository.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgments

- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Bootstrap Documentation](https://getbootstrap.com/docs/5.1/getting-started/introduction/)
- [jQuery Documentation](https://jquery.com/)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)

## Contact

For any inquiries or feedback, please reach out to [your-email@example.com].
