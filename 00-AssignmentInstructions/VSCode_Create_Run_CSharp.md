# How to Create and Run a C# Project in VS Code (Absolute Beginner Guide)

This guide will help you create and run cross-platform C# Console projects in Visual Studio Code (VS Code), and add your project to source control using GitHub. No prior experience is required!

---

## 1. Install Prerequisites

- **VS Code:** Download and install from [code.visualstudio.com](https://code.visualstudio.com/)
- **.NET SDK:** Download and install from [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
- **C# Extension:** In VS Code, go to Extensions (Ctrl+Shift+X), search for "C#" (by Microsoft), and install it.
- **Git:** Install from [git-scm.com](https://git-scm.com/) if not already installed.

---

## 2. Create a New Project Directory

Before creating your solution and project, create a directory for your assignment and navigate into it:

**Command:**
```sh
mkdir HelloWorld
cd HelloWorld
```
- `mkdir HelloWorld` creates a new folder named "HelloWorld".
- `cd HelloWorld` changes into that folder.

---

## 3. Create a New Solution

A solution is a container for one or more projects. It's useful for organizing your code, especially as your assignments grow.

**Command:**
```sh
dotnet new sln -n HelloWorld
```
- `dotnet new sln` creates a new solution file.
- `-n HelloWorld` names the solution the same as your project: "HelloWorld".

---

## 4. Create a New Console App Project

This command creates a new C# console application project.

**Command:**
```sh
dotnet new console -n HelloWorld --framework net8.0 --language "C#" --output HelloWorld
```
- `dotnet new console` creates a new console app project.
- `-n HelloWorld` names the project "HelloWorld".
- `--framework net8.0` targets .NET 8.0 (change if needed).
- `--language "C#"` ensures the project uses C#.
- `--output HelloWorld` puts the project in a folder named "HelloWorld".

---

## 5. Add the Project to the Solution

This command adds your new project to the solution file so everything is organized together.

**Command:**
```sh
dotnet sln HelloWorld.sln add HelloWorld/HelloWorld.csproj
```
- `dotnet sln` manages projects in a solution.
- `HelloWorld.sln` is the solution file (same name as your project).
- `add HelloWorld/HelloWorld.csproj` adds your project to the solution.

---

## 6. Review Your Solution and Project Structure

After adding your project to the solution, your directory should look like this:

```
HelloWorld/                # Your working directory
│
├── HelloWorld.sln         # The solution file
│
└── HelloWorld/            # The project folder
    ├── HelloWorld.csproj  # The C# project file
    ├── Program.cs         # Main program source file
    ├── ...                # Other default project files (e.g., bin/, obj/)
```
- The solution file (`HelloWorld.sln`) is at the root of your working directory.
- The project folder (`HelloWorld/`) contains the project file and source code.
- The project is now registered in the solution, so you can manage it with Visual Studio or the `dotnet` CLI.

---

## 7. Open the Project in VS Code

**Command:**
```sh
code .
```
- Opens the current folder in VS Code.

---

## 8. Run Your Program

Use this command inside your project folder to build and run your app.

**Command:**
```sh
dotnet run
```
- Builds and runs your C# console application.

---

## 9. Add Your Project to Source Control with GitHub

Initialize git and make your first commit:

**Command:**
```sh
git init
git add .
git commit -m "Initial commit"
```

Connect to GitHub and push your code:

**Command:**
```sh
git remote add origin https://github.com/yourusername/HelloWorld.git
git branch -M main
git push -u origin main
```

---

## 10. Tips for Beginners

- Save your work often (`Ctrl+S`).
- Use the Explorer (left sidebar) to see your files.
- If you get stuck, right-click files for more options.
- You can always delete a project and start over if needed.

---

## 11. More Help

- [Microsoft C# Beginner Docs](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [VS Code C# Docs](https://code.visualstudio.com/docs/languages/csharp)
- [GitHub Docs: Get started with Git and VS Code](https://docs.github.com/en/get-started/git-basics)

---

## Summary of the dotnet Section

You learned how to:
- Create a solution to organize your projects (with the same name as your project).
- Create a new C# console project with explicit options.
- Add your project to the solution.
- Open your project in VS Code.
- Build and run your project.
- Add your project to source control and push it to GitHub.

Below is a comprehensive example of all the commands in order:

```sh
# Create a new directory for your project and navigate into it
mkdir HelloWorld
cd HelloWorld

# Create a new solution (same name as your project)
dotnet new sln -n HelloWorld

# Create a new C# console project with explicit options
dotnet new console -n HelloWorld --framework net8.0 --language "C#" --output HelloWorld

# Add the project to the solution
dotnet sln HelloWorld.sln add HelloWorld/HelloWorld.csproj

# Open the project in VS Code
code .

# Run your program (inside the HelloWorld folder)
cd HelloWorld
dotnet run

# Initialize git and make your first commit
git init
git add .
git commit -m "Initial commit"

# Connect to GitHub and push your code
git remote add origin https://github.com/yourusername/HelloWorld.git
git branch -M main
git push -u origin main
```
