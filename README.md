# Income Expense Management System using ASP.NET Core Web API

This project is a simple yet powerful Income Expense Management System developed using ASP.NET Core Web API. It allows users to track their income and expenses efficiently, providing insights into their financial activities.

## Features

- User Authentication: Secure user registration and login system.
- Income Management: Add, edit, delete and view income records.
- Expense Management: Add, edit, delete and view expense records.
- Category Management: Manage income and expense categories.
- Reporting: Generate reports to analyze income and expense trends over time.

## Technologies Used

- ASP.NET Core Web API
- Entity Framework Core for ORM
- SQL Server for database management
- Swagger UI for API documentation

## Setup Instructions

1. **Clone the Repository**: 
    ```bash
    git clone https://github.com/Aditya665/Income-Expense-Management-System-using-ASP.NET-Core-Web-API.git
    ```

2. **Database Setup**:
    - Ensure you have SQL Server installed and running.
    - Update the connection string in `appsettings.json` to match your SQL Server instance.
    - Run the Entity Framework migrations to create the necessary tables:
        ```bash
        dotnet ef database update
        ```

3. **Running the Application**:
    - Build and run the ASP.NET Core Web API project.

4. **API Documentation**:
    - Once the application is running, you can access the Swagger UI documentation locally by navigating to:
        ```
        http://localhost:<port>/swagger
        ```
    - Alternatively, you can access the hosted Swagger documentation at [Swagger Hosted](http://ecommarceshop.runasp.net/swagger/index.html).

## Configuration

- **Database Connection**: Modify the connection string in `appsettings.json` to point to your SQL Server instance.

## Contributing

Contributions are welcome! If you find any bugs or have suggestions for improvements, feel free to open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

---

**Note:** This project is currently under development. Some features may be incomplete or subject to change. Contributions and feedback are appreciated as we work to improve and finalize the system.
