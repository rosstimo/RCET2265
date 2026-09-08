# Tools, Setup & Workflow

RCET 2265 uses a real project workflow from the beginning: source files live in a project, the project is version controlled with Git, and the repository is pushed to GitHub.

## Development environment

For Windows desktop work, Visual Studio Community is the normal course environment. Install the .NET desktop development workload when Windows Forms is required.

Use a supported .NET SDK. As of September 2026, .NET 10 is the current LTS release. Do not start new course projects on .NET 6, which is no longer supported.

## Projects and solutions

A C# project normally contains a `.csproj` file and one or more `.cs` source files. A Visual Studio solution can contain one or more projects.

For early console work:

1. Create a Console App project.
2. Give the project a descriptive name.
3. Build before making large changes.
4. Run the program and confirm the output.
5. Commit a working state before the next major change.

Later projects may contain multiple source files and classes. Do not put an entire growing program into one giant source file just because it started that way.

## Git workflow

A useful minimum cycle is:

```text
edit -> build/test -> git status -> git add -> git commit -> git push
```

Use `git status` often. A commit records a useful project state; GitHub is the remote copy and the submission/review point when the assignment says so.

## Debugger habits

Learn these early:

- set and remove breakpoints
- Step Over and Step Into
- inspect local variables
- read compiler and runtime messages before changing code
- make one deliberate change at a time while troubleshooting

## References

- [Visual Studio documentation](https://learn.microsoft.com/en-us/visualstudio/)
- [.NET downloads](https://dotnet.microsoft.com/en-us/download/dotnet)
- [.NET support policy](https://dotnet.microsoft.com/en-us/platform/support/policy)
- [Git documentation](https://git-scm.com/doc)
- [GitHub: Get started](https://docs.github.com/en/get-started)
- [Project Structure](../StyleGuide/ProjectStructure.md)
- [Git Best Practices](../StyleGuide/GitBestPractices.md)
