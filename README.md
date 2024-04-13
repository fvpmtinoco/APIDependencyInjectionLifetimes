# ASP.NET Core Dependency Injection Lifetimes Demonstration

## Project Overview

This ASP.NET Core project is designed to illustrate the use of dependency injection (DI) lifetimes—Transient, Scoped, and Singleton—within a web application. It demonstrates how these DI lifetimes affect the behavior and lifecycle of services.

### Goals

- **Educate** on the different DI lifetimes available in ASP.NET Core.
- **Showcase** the distinct behaviors of transient, scoped, and singleton services within the same application context.
- **Provide a practical reference** about DI in ASP.NET Core.

### Architecture
#### Project Structure
**Controllers**: Contains DILifetimeController which demonstrates the lifetimes by injecting different types of services.
**Services**: Implements transient, scoped, and singleton services which are used within the controller to demonstrate their lifetimes.
#### Key Components
**IOperationTransient, IOperationScoped, IOperationSingleton**: Interfaces representing different lifetimes.
**OperationService**: A service that encapsulates transient, scoped, and singleton services, injected into the controller.
#### API Endpoints
**GET /DILifetime**: Demonstrates and returns the operation IDs for services with different lifetimes, showing how each is initialized and reused within and across requests.
Contributing
