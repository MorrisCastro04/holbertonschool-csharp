## General Information

### What is the meaning behind the name C#?
C# (pronounced "C-sharp") is a modern, object-oriented programming language developed by Microsoft as part of its .NET initiative. The name C# was inspired by the musical notation where a sharp symbol indicates that the note should be a semitone higher, signifying that C# is an evolution of the C language.

### Who is the lead architect of the development team of C#?
Anders Hejlsberg, a Danish software engineer, is the lead architect of the C# development team. He is also known for creating other influential programming languages, such as Turbo Pascal and Delphi.

### What is .NET?
.NET is a free, cross-platform, open-source developer platform for building many different types of applications. It provides a large class library and supports multiple languages, including C#, VB.NET, and F#. .NET allows developers to build applications for web, mobile, desktop, games, and more.

### What is the difference between C# and .NET?
C# is a programming language, while .NET is a framework that supports the development of applications using languages like C#. Essentially, .NET provides the tools, libraries, and runtime necessary to build and run C# applications.

### How to use VSCode and the integrated terminal to initialize, build, and run C# projects
- **Initialize a new project**: Use `dotnet new console -o <project_name>`
- **Build the project**: Navigate to the project directory and use `dotnet build`
- **Run the project**: In the same directory, use `dotnet run`

### How to print text and variables using `Console.Write`
In C#, you can print text and variables to the console using `Console.WriteLine` or `Console.Write`. For example:
```csharp
int number = 10;
Console.WriteLine("The number is: " + number);
```

## Tasks

### 0. Initialize New Project
- **Script**: `0-initialize_new_project.sh`
- **Description**: Initializes a new C# project inside a folder titled `0-new_project`.
- **Command**: `dotnet new console -o 0-new_project`

### 1. Build New Project
- **Script**: `1-build_new_project.sh`
- **Description**: Initializes and builds a new C# project inside a folder titled `1-new_project`.
- **Command**: `dotnet new console -o 1-new_project && cd 1-new_project && dotnet build`

### 2. Run New Project
- **Script**: `2-run_new_project.sh`
- **Description**: Initializes, builds, and runs a new C# project from a folder titled `2-new_project`.
- **Command**: `dotnet new console -o 2-new_project && cd 2-new_project && dotnet run`

### 3. Hello, WriteLine
- **File**: `3-writeline/3-writeline.cs`
- **Description**: A C# script that prints "Programming is like building a multilingual puzzle".
- **Usage**: Run the script with `dotnet run` inside the `3-writeline` directory.

### 4. Print Integer
- **File**: `4-print_integer/4-print_integer.cs`
- **Description**: Prints an integer stored in the variable `number` followed by "Mission Street".
- **Usage**: Run the script with `dotnet run` inside the `4-print_integer` directory.

### 5. Print Float
- **File**: `5-print_float/5-print_float.cs`
- **Description**: Prints a float stored in the variable `number` with two decimal places.
- **Usage**: Run the script with `dotnet run` inside the `5-print_float` directory.

### 6. Print String
- **File**: `6-print_string/6-print_string.cs`
- **Description**: Prints a string stored in the variable `str` three times, followed by its first 9 characters.
- **Usage**: Run the script with `dotnet run` inside the `6-print_string` directory.

### 7. Play with Strings
- **File**: `7-concat/7-concat.cs`
- **Description**: Prints "Welcome to Holberton School!" by concatenating two strings.
- **Usage**: Run the script with `dotnet run` inside the `7-concat` directory.

### 8. Print Variables
- **File**: `8-print_variables/8-print_variables.cs`
- **Description**: Prints the variables as "972 Mission Street".
- **Usage**: Run the script with `dotnet run` inside the `8-print_variables` directory.

### 9. Print Specifiers
- **File**: `9-print_specifiers/9-print_specifiers.cs`
- **Description**: Prints formatted variables as a percentage and currency.
- **Usage**: Run the script with `dotnet run` inside the `9-print_specifiers` directory.

### 10. Copy - Cut - Paste
- **File**: `10-copy_cut_paste/10-copy_cut_paste.cs`
- **Description**: Extracts and prints the first 3 letters, last 2 letters, and the middle word of a variable.
- **Usage**: Run the script with `dotnet run` inside the `10-copy_cut_paste` directory.

### 11. Create a New Sentence
- **File**: `11-concat_edges/11-concat_edges.cs`
- **Description**: Prints "object-oriented programming in C#".
- **Usage**: Run the script with `dotnet run` inside the `11-concat_edges` directory.

### 12. Hello, Error
- **File**: `100-hello_error/100-hello_error.cs`
- **Description**: Prints "and that piece of art is useful - Dora Korpar, 2015-10-19" to `stderr` and exits with status code 1.
- **Usage**: Run the script with `dotnet run` inside the `100-hello_error` directory.
