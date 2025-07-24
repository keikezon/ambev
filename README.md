# Ambev Developer Evaluation

A .NET 8 application built as part of a technical evaluation.  
This solution focuses on **sales and product management**, implementing a **decoupled, event-driven architecture** using **MediatR** and **Domain Events**.

## 📚 Table of Contents

- [🧾 About](#about)
- [🛠️ Technologies](#technologies)
- [🚀 Getting Started](#getting-started)
- [🐳 Docker Support](#docker-support)
- [📘 Swagger UI](#swagger-ui)
- [🧪 Running Tests](#running-tests)
- [🤝 Contributing](#contributing)
- [📄 License](#license)

## 🧾 About

This project serves as a backend service responsible for handling:
- Sale creation, modification, and cancellation
- Product management
- Event publishing using [MediatR](https://github.com/jbogard/MediatR)

The architecture promotes separation of concerns through **CQRS**, **Domain-Driven Design (DDD)** principles, and **clean architecture** practices.

## 🛠️ Technologies

- [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- C#
- MediatR
- Entity Framework Core
- Swagger / Swashbuckle
- Docker & Docker Compose
- xUnit (for testing)

## 🚀 Getting Started

### Prerequisites

Make sure you have installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Docker](https://www.docker.com/products/docker-desktop)
- Git

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/keikezon/ambev.git
   ```

2. Navigate to the project directory:
   ```bash
   cd Ambev
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

### Running the Application Locally

1. Build the solution:
   ```bash
   dotnet build
   ```

2. Run the application:
   ```bash
   dotnet run --project src/Ambev.DeveloperEvaluation.Application
   ```

## 🐳 Using Docker Compose

1. Ensure `docker-compose.yml` exists and is configured.
2. Run:

```bash
docker-compose up --build
```

## 📘 Swagger UI

Once the application is running (locally or via Docker), you can explore and test the available endpoints using Swagger:

- **Local:**  
  [http://localhost:5000/swagger](http://localhost:5000/swagger)

Swagger provides a visual interface to interact with the API, including request/response schemas and execution testing.

## Postman UI

If you prefer, you can use Postman instead of Swagger to test the API endpoints. The link to the Postman environment is available below:

[Postman link](https://keikezon-83ffa04a-2322996.postman.co/workspace/Keith-Kellen-Zonatto's-Workspac~07fbb38a-06e3-45c1-87f8-9bbf503600a8/collection/46976826-c49d449c-bb6e-4881-b01b-e3f83b3e69c1?action=share&creator=46976826&active-environment=46976826-7393cfd7-fd81-4a7a-b689-978a9891a0c1)

## 🧪 Running Tests

To run all tests:

```bash
dotnet test
```

All test projects are located in the `/tests` folder and cover business logic, validations, and endpoints.

## 🤝 Contributing

Contributions are welcome! Feel free to open issues or submit pull requests.

1. Fork the repository  
2. Create your feature branch  
   ```bash
   git checkout -b feature/awesome-feature
   ```
3. Commit your changes  
   ```bash
   git commit -m "Add some awesome feature"
   ```
4. Push to the branch  
   ```bash
   git push origin feature/awesome-feature
   ```
5. Open a Pull Request

## 📄 License

This project is licensed under the [MIT License](LICENSE).
