# Employee Management System (C# Console Application)

## Project Description

This project is a **simple Employee Management System built using C# as a Console Application**. The goal of this project is to practice basic C# programming concepts such as classes, lists, loops, and working with user input.

The application runs in the console and provides a menu where users can perform different operations related to employee management. Through this menu, users can add employees, view all employees, search for a specific employee, delete employee records, and view top employees.

Each employee record contains important information such as Employee ID, First Name, Last Name, Department, Salary, and Level. All employee data is stored in memory using a List collection during the program execution.

This project helped me understand how to structure a small application, manage data using collections, and implement common operations such as adding, searching, and deleting records. It is designed as a beginner-friendly project for learning C# and basic object-oriented programming concepts.

---
   _____                       _                                         ____                  _
  | ____|  _ __ ___    _ __   | |   ___    _   _    ___    ___   ___    / ___|   _   _   ___  | |_    ___   _ __ ___
  |  _|   | '_ ` _ \  | '_ \  | |  / _ \  | | | |  / _ \  / _ \ / __|   \___ \  | | | | / __| | __|  / _ \ | '_ ` _ \
  | |___  | | | | | | | |_) | | | | (_) | | |_| | |  __/ |  __/ \__ \    ___) | | |_| | \__ \ | |_  |  __/ | | | | | |
  |_____| |_| |_| |_| | .__/  |_|  \___/   \__, |  \___|  \___| |___/   |____/   \__, | |___/  \__|  \___| |_| |_| |_|
                      |_|                  |___/                                 |___/
# Technologies Used

* C#
* .NET Console Application
* List Collection
* Object-Oriented Programming (OOP)

---

# Features

## 1. Add Employee

This feature allows the user to add a new employee to the system. The user is asked to enter the following details:

                      |_|                  |___/                                 |___/
┌─Employees Management System─┐
│                             │
│                             │
│                             │
│                             │
│   1: Add Employee           │
│      2: show Employees      │
│      3: Search Employee     │
│      4: Delete Employee     │
│      5: show top Employees  │
│      6: Exit                │
│                             │
│                             │
│                             │
│                             │
└─────────────────────────────┘
* Employee ID
* First Name
* Last Name
* Department
* Salary
* Level

Example Input

Employee Id : 98382
First Name : Himanshu
Last Name : Kumar
Department : IT
Salary : 20000
Level : L7

---

## 2. Show Employees

This option displays all employee records that have been added to the system.

Example Output
                            Employees List
┌────────┬──────────┬───────────┬────────────┬────────┬─────────────┬───────┐
│ Emp Id │ Emp Name │ Last Name │ Department │ Salary │ Salary Type │ Layer │
└────────┴──────────┴───────────┴────────────┴────────┴─────────────┴───────┘

---

## 3. Search Employee

Users can search for an employee by entering the employee's first name. If a matching record is found, the employee details are displayed.

Example

Search Name : Himanshu

Output

98382 Himanshu Kumar 20000

---

## 4. Delete Employee

This option allows the user to delete an employee record using the Employee ID. The system asks for confirmation before deleting the record.

Example

Enter Employee Id : 98382
Are you sure you want to delete (y/n)

---

## 5. Show Top Employees

This feature displays top employees based on level or defined conditions.

Example Output

98382 Himanshu Kumar IT 20000 L7
948239 Pramanshu Singh IT 39283 L7

---

## 6. Exit

This option exits the application and closes the program.

---

# Menu Interface

The program works through a menu-driven interface:

1. Add Employee
2. Show Employees
3. Search Employee
4. Delete Employee
5. Show Top Employees
6. Exit

---

# Example Program Flow

Add Employee

Enter Employee Id
98382

Enter First Name
Himanshu

Enter Last Name
Kumar

Enter Salary
20000

Enter Department
IT

Enter Level
L7

---

# Project Structure

EmployeeManagementSystem

Program.cs
Employee.cs

---

# Concepts Used

This project demonstrates the following C# concepts:

* Classes and Objects
* List Collection
* Loops
* Conditional Statements
* Methods
* Console Input and Output

---

