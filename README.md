# Driving License Management System (DVDL) : 

A Windows Forms-based application for the Driving & Vehicle License Department (DVLD) to manage driving license operations. The system follows a Three-Layer Architecture (Presentation, Business, Data) and utilizes ADO.NET for data access and manipulation.

## Features
- Issue, renew, and replace driving licenses across multiple vehicle categories.
- Manage driving tests (vision, theoretical, and practical) and schedule appointments.
- Secure user authentication and role-based access.
- Admin dashboard to manage license records, users, and services.
- Efficient data management using ADO.NET for database interaction.

## Technologies Used
- **Windows Forms** for the user interface.
- **Three-Layer Architecture** for clear separation of concerns.
  - Presentation Layer: Handles the user interface using Windows Forms.
  - Business Layer: Implements business logic and validations.
  - Data Access Layer: Uses ADO.NET to interact with the SQL Server database.
- **ADO.NET** for database connectivity and transactions.
- **SQL Server** as the database.

## Prerequisites
- Visual Studio
- .NET Framework
- SQL Server
- Git

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/username/driving-license-management-system.git
   ```

2. **Navigate to the project directory**:
   ```bash
   cd driving-license-management-system
   ```

3. **Open the solution** in Visual Studio:
   - Open the `.sln` file in Visual Studio.

4. **Set up the database**:
   - Create a SQL Server database.
   - Update the connection string in the `app.config` file for the Data Access Layer (DAL) to match your SQL Server instance.
   - Use ADO.NET scripts to initialize the database.

5. **Run the application**:
   - Build the solution in Visual Studio.
   - Run the application from the Presentation Layer (Windows Forms).

## Usage

### Main Modules:
- **Issue New License**: Enter applicant details and issue a new driving license.
- **Renew License**: Renew an existing license by entering the license number.
- **Replace License**: Handle lost or damaged licenses by issuing replacements.
- **Manage Driving Tests**: Schedule and record results for driving tests.
- **Search License**: Search for licenses by applicant's national ID or license number.

## Contributing

Contributions are welcome! Please follow the standard procedure:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make changes and commit (`git commit -m 'Added feature'`).
4. Push the branch (`git push origin feature-branch`).
5. Open a pull request.
