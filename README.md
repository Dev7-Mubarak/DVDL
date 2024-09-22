#  Driving License Management System 🚗

A **Windows Forms** application for the **Driving & Vehicle License Department (DVLD)** to manage driving license operations. The system follows a **Three-Layer Architecture** (Presentation, Business, Data) and utilizes **ADO.NET** for data access.

## ✨ Features
- 📜 Issue, renew, and replace driving licenses.
- 📅 Schedule and manage driving tests (vision, theory, practical).
- 🔐 Secure user authentication with role-based access control.
- 🛠️ Admin dashboard for managing license records and users.
- 💾 Efficient data management using **ADO.NET** for database access.

## 🛠️ Technologies Used
- **Windows Forms** for the UI.
- **Three-Layer Architecture**:
  - Presentation Layer: Windows Forms UI.
  - Business Layer: Business logic and validations.
  - Data Access Layer: ADO.NET for SQL Server interaction.
- **ADO.NET** for database connectivity.
- **SQL Server** as the database.

## 🗃️ Database Design

The database follows a relational model to store data related to drivers, licenses, tests, and applications. The key entities include:

- **Drivers**: Stores information about individuals applying for or holding licenses.
- **Licenses**: Records the issued, renewed, or replaced licenses with details like class, issue date, and fees.
- **Tests**: Tracks driver tests and their results.
- **Applications**: Manages the application process for new licenses, renewals, and replacements.

### Database Schema:

![DVLD Database](https://github.com/user-attachments/assets/df98c72a-fc71-4605-b2f1-bb8e4439b94c)

This diagram represents the schema and relationships between different entities in the system. The database ensures consistency and integrity in managing the licensing process, with clear relationships between applicants, tests, licenses, and applications.

## 🚀 Installation

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
   - Update the connection string in the `app.config` file for the Data Access Layer (DAL).
   - Initialize the database using ADO.NET scripts.

5. **Run the application**:
   - Build the solution in Visual Studio.
   - Run the Windows Forms application.


## 🤝 Contributing

We welcome contributions! Follow these steps:
1. Fork the repository.
2. Create a feature branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -m 'Add feature'`).
4. Push the branch (`git push origin feature-branch`).
5. Open a pull request.

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
