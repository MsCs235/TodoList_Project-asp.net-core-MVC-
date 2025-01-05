# TodoList Application

## Overview

The TodoList application is a simple web-based task management tool built using ASP.NET Core. It allows users to create, edit, and delete tasks, providing a straightforward interface for managing daily activities. The application is designed to be user-friendly and efficient, making it easy for users to keep track of their tasks.

## Features

- **User Authentication**: Secure login and registration system to manage user accounts.
- **Task Management**: Create, read, update, and delete (CRUD) operations for tasks.
- **Responsive Design**: Built with Bootstrap to ensure a seamless experience across devices.
- **Client-side**: Utilizes jQuery Validation for client-side validation.
- **Server-side Validation**: ASP.NET Core for server-side validation to enhance user experience and ensure data integrity.
- **Session Management**: Maintains user sessions to keep track of logged-in users.

## Technologies Used

- **Backend**: ASP.NET Core 8.0 MVC
- **Frontend**: HTML, CSS, JavaScript, Bootstrap
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



## Contact

For any inquiries or feedback, please reach out to [Mohammedsalah235@yahoo.com].
