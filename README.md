# 🚀 Week 7 Deliverables: Mastering LINQ & Entity Framework Core

Welcome to my repository for Week 7 of the Technical Training Program. This week, I focused intensively on enhancing my data management and database development skills using modern .NET technologies, while strictly adhering to **SOLID** principles to ensure clean, maintainable, and professional code.

## 🛠️ Technologies Used
*   **.NET 10 SDK**: The latest version of the .NET development environment.
*   **Entity Framework Core 10**: For database management using the Code-First approach.
*   **SQL Server 2022**: The primary database engine for all projects.
*   **LINQ**: For performing advanced and professional data queries.

## 📂 Project Structure

I have organized my work into three independent solutions, each focusing on a specific technical aspect:

### 1. Advanced LINQ Exercises (LINQ_Exercises)
In this project, I implemented over **35+ LINQ queries** covering all essential operations:
*   Filtering (Where) and Sorting (OrderBy/ThenBy).
*   Aggregation operations like Average, Max, Min, and Sum.
*   Paging logic using Skip and Take.
*   Grouping data and validating conditions using Quantifiers (Any/All).
*   **SOLID Principles**: Data models were separated from services to ensure code independence and reusability.

### 2. Product Catalog Application (ProductCatalogApp)
A comprehensive CRUD application built with **EF Core Code-First**:
*   Programmatic database design and automatic creation using `Database.EnsureCreated()`.
*   Using **Fluent API** to configure constraints, such as Unique Indexes for product names.
*   An interactive Console Menu system to manage products and categories seamlessly.

### 3. Blog Engine Data Layer (BlogEngineDataLayer)
This project focuses on designing a complex Data Layer:
*   Implementing a **Many-to-Many (M:N)** relationship between Posts and Tags.
*   Setting up a **One-to-Many** relationship between Posts and Comments.
*   Full control over the database schema using **Fluent API** configurations.

## 📄 Educational Documentation
The `Reports` folder contains documents I prepared to summarize my learning journey:
*   **LINQ Cheat Sheet**: A quick reference for all the LINQ commands I mastered.
*   **EF Core Summary**: A summary of the most important concepts in Entity Framework Core.

## 🚀 How to Run
1. Ensure you have **.NET 10 SDK** and **SQL Server 2022** installed.
2. Update the **Connection String** in the Context files to match your local SQL Server instance name.
3. Open the `.sln` (Solution) file for each project using Visual Studio 2022.
4. Press **Start**; the application will automatically create the database and tables upon its first run.

---
**Prepared by:** Ezzaldeen Alrabeei
