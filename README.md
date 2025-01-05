# TodoList Application

## Overview

The TodoList application is a simple web-based task management tool built using ASP.NET Core. It allows users to create, edit, and delete tasks, providing a straightforward interface for managing daily activities.

## Features

- User authentication and session management
- Create, read, update, and delete (CRUD) operations for tasks
- Responsive design using Bootstrap
- Client-side validation with jQuery Validation
- Support for multiple environments (Development, Production)

## Technologies Used

- **Backend**: ASP.NET Core 8.0
- **Frontend**: HTML, CSS, JavaScript, Bootstrap, jQuery
- **Database**: SQL Server with Entity Framework Core
- **Session Management**: ASP.NET Core Session

## Getting Started

### Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or any compatible IDE

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/TodoList.git
   cd TodoList
   ```

2. Restore the NuGet packages:
   ```bash
   dotnet restore
   ```

3. Update the database connection string in `appsettings.json` to match your SQL Server setup.

4. Run the database migrations:
   ```bash
   dotnet ef database update
   ```

5. Start the application:
   ```bash
   dotnet run
   ```

6. Open your browser and navigate to `http://localhost:5282` (or the URL specified in `launchSettings.json`).

## Usage

- **Creating a Task**: Click on "New Note" in the navigation bar to create a new task.
- **Editing a Task**: Click on the "edit" button next to a task in the list to modify it.
- **Deleting a Task**: Click on the "delete" button next to a task to remove it.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any suggestions or improvements.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgments

- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Bootstrap Documentation](https://getbootstrap.com/docs/5.1/getting-started/introduction/)
- [jQuery Documentation](https://jquery.com/)
