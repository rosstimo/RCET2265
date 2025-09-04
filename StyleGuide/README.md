# RCET C# Style Guide

This directory contains the official style guide for RCET C# coursework. Use this README as a quick reference for the most important style rules. For full explanations and examples, follow the links in the table of contents below.

---

## Quick Reference Cheat Sheet

**File & Project Structure:**
- One public type per file; file name matches the type (e.g., `Product.cs` for `class Product`).
- Folders mirror namespaces; avoid dumping files at the root.
- Use PascalCase for all file and folder names; no spaces or underscores (e.g., `MyApp.Models`).
- Use plural folder names for collections (e.g., `Models`, `Assignments`).
- See: [ProjectStructure.md](ProjectStructure.md)

**Commenting:**
- Use `//` for short comments above the code they describe.
- Comment the "why" not the "what"—explain intent, not obvious code.
- Keep comments up to date; remove stale or misleading comments.
- Use XML comments (`/// <summary>...</summary>`) for public APIs.
- No commented-out code in releases.
- See: [Commenting.md](Commenting.md)

**Naming Conventions:**
- Use PascalCase for types, classes, public members, and methods (e.g., `MyClass`, `CalculateSum`).
- Use camelCase for local variables and parameters (e.g., `int count`, `string name`).
- Private fields: camelCase with a leading underscore (e.g., `_count`).
- Constants: ALL_CAPS with underscores (e.g., `MAX_RETRIES`, `DEFAULT_TIMEOUT`).
- Boolean names should read like questions (e.g., `isReady`, `hasItems`).
- No Hungarian notation or type/scope prefixes except `I` for interfaces and `_` for private fields.
- Avoid abbreviations unless widely accepted (e.g., `URL`, `ID`).
- See: [NamingConventions.md](NamingConventions.md)

**Indentation & Spacing:**
- Indent code blocks by 4 spaces (never tabs).
- Put a space after keywords (e.g. `if (` not `if(`).
- Never mix tabs and spaces.
- Indent continuation lines an extra 4 spaces.
- Space after commas, no extra spaces inside parentheses/brackets.
- No trailing whitespace.
- See: [IndentationAndSpacing.md](IndentationAndSpacing.md)

**Formatting & Braces:**
- Always put opening and closing braces `{}` on their own lines (Allman style). Example:
  ```csharp
  if (condition)
  {
      Console.WriteLine("Allman style");
  }
  ```
- Always use braces, even for single-line `if` or loop bodies.
- One statement and one declaration per line.
- Use blank lines to separate logical sections (e.g., between methods).
- See: [CodeFormatting.md](CodeFormatting.md)

**Code Layout & Structure:**
- One public type per file; file name matches the type.
- Order members as follows: fields, properties, constructors, methods.
- Explicitly specify access modifiers (e.g., `public`, `private`).
- Use file-scoped namespaces at the top of the file. 

- See: [CodeLayoutAndStructure.md](CodeLayoutAndStructure.md)

**Git & GitHub:**
- Commit often with clear messages.
- Don’t commit commented-out code or temporary files.
- Use branches for features and bug fixes.
- See: [GitBestPractices.md](GitBestPractices.md)

---

## Table of Contents

- [ProjectStructure.md](ProjectStructure.md) — Project Structure
- [Commenting.md](Commenting.md) — Commenting
- [NamingConventions.md](NamingConventions.md) — Naming Conventions
- [IndentationAndSpacing.md](IndentationAndSpacing.md) — Indentation and Spacing
- [CodeFormatting.md](CodeFormatting.md) — Code Formatting
- [CodeLayoutAndStructure.md](CodeLayoutAndStructure.md) — Code Layout and Structure
- [GitBestPractices.md](GitBestPractices.md) — Git & GitHub Best Practices

---

For comprehensive explanations and more examples, follow the links above. All RCET C# assignments must follow these style rules.
