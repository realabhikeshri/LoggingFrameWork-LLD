# Logging Framework – Machine Coding (Low Level Design)

## 📌 Overview
This project implements a **custom Logging Framework** using **Low Level Design (LLD)** principles in **C#**.  

The framework supports multiple log levels, configurable appenders, and clean separation of concerns similar to real-world logging systems like **Log4j / NLog**.

---

## 🧠 Design Principles Used
- **Single Responsibility Principle**
- **Open/Closed Principle**
- **Strategy Pattern**
- **Separation of Concerns**
- Thread-safe logging

---

## 🏗️ Features
- Multiple log levels (DEBUG, INFO, WARN, ERROR, FATAL)
- Configurable minimum log level
- Multiple log appenders
- Console logging
- File logging
- Thread-safe file writes
- Easy extensibility for new appenders (DB, HTTP, Kafka, etc.)

---

## 🧩 Tech Stack
- **Language:** C#
- **Framework:** .NET
- **Design Focus:** Low Level Design / Machine Coding

---

## 🗂️ Project Structure
```text
LoggingFrameworkLLD
│
├── Enums
│   └── LogLevel.cs
│
├── Models
│   └── LogMessage.cs
│
├── Interfaces
│   ├── ILogger.cs
│   └── ILogAppender.cs
│
├── Appenders
│   ├── ConsoleAppender.cs
│   └── FileAppender.cs
│
├── Config
│   └── LoggerConfig.cs
│
├── Core
│   └── Logger.cs
│
└── Program.cs
