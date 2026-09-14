# Create and Run a C# Project in VS Code

This guide shows the RCET 2265 command-line project setup used with Visual Studio Code. The course currently targets **.NET 10 (LTS)** and uses an explicit `Program` class and `Main` method.

## 1. Install Prerequisites

Install:

- [Visual Studio Code](https://code.visualstudio.com/)
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Microsoft's **C#** extension for VS Code
- [Git](https://git-scm.com/) if it is not already installed

Verify the .NET SDK from a terminal:

```sh
dotnet --version
```

## 2. Create the Assignment Directory

Create a directory for the solution and move into it:

```sh
mkdir HelloWorld
cd HelloWorld
```

## 3. Create the Solution

```sh
dotnet new sln --format sln -n HelloWorld
```

The course uses the traditional `.sln` solution format. With the .NET 10 SDK, `dotnet new sln` defaults to the newer `.slnx` format, so `--format sln` is intentional here.

## 4. Create the Console Project

```sh
dotnet new console -n HelloWorld --framework net10.0 --language "C#" --use-program-main --output HelloWorld
```

The important options are:

- `--framework net10.0` targets .NET 10.
- `--language "C#"` selects C#.
- `--use-program-main` generates an explicit `Program` class and `Main` method instead of top-level statements.
- `--output HelloWorld` creates the project in the `HelloWorld/` subdirectory.

## 5. Add the Project to the Solution

```sh
dotnet sln HelloWorld.sln add HelloWorld/HelloWorld.csproj
```

The directory should now look approximately like this:

```text
HelloWorld/
├── HelloWorld.sln
└── HelloWorld/
    ├── HelloWorld.csproj
    └── Program.cs
```

Generated `bin/` and `obj/` directories will appear after building or running the project and should not be committed to Git.

## 6. Open the Solution Directory in VS Code

From the outer `HelloWorld/` directory:

```sh
code .
```

## 7. Build and Run

You can run the project from the outer solution directory without changing directories:

```sh
dotnet run --project HelloWorld/HelloWorld.csproj
```

Or move into the project directory first:

```sh
cd HelloWorld
dotnet run
```

Correct compiler errors before continuing.

## 8. Create the Git Repository

Return to the outer solution directory if necessary, then initialize Git and inspect the working tree:

```sh
git init
git status
git add .
git status
git commit -m "Create HelloWorld project"
```

Create an empty GitHub repository with the same project name, then connect and push it:

```sh
git remote add origin https://github.com/yourusername/HelloWorld.git
git branch -M main
git push -u origin main
```

## 9. Normal Work Cycle

Use this cycle throughout the assignment:

```text
edit -> build/test -> git status -> git add -> git commit -> git push
```

Use `git status` before staging and again before committing so you know what is being recorded.

## Complete Command Sequence

```sh
mkdir HelloWorld
cd HelloWorld

dotnet new sln --format sln -n HelloWorld

dotnet new console \
    -n HelloWorld \
    --framework net10.0 \
    --language "C#" \
    --use-program-main \
    --output HelloWorld

dotnet sln HelloWorld.sln add HelloWorld/HelloWorld.csproj

code .

dotnet run --project HelloWorld/HelloWorld.csproj

git init
git status
git add .
git status
git commit -m "Create HelloWorld project"

git remote add origin https://github.com/yourusername/HelloWorld.git
git branch -M main
git push -u origin main
```

## References

- [.NET CLI documentation](https://learn.microsoft.com/en-us/dotnet/core/tools/)
- [`dotnet new`](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new)
- [C# in Visual Studio Code](https://code.visualstudio.com/docs/languages/csharp)
- [Git documentation](https://git-scm.com/doc)
