# Primitive Data Types in C#

## Introduction

Primitive data types are the basic building blocks of all programs. They let you store numbers, text, and true/false values. Understanding these types helps you choose the right kind of variable for your data and avoid common mistakes.

---

**Core Types:**
- `int` – whole numbers (e.g. 0, -5, 42)
- `double` – numbers with decimals (e.g. 3.14, -0.5, 1.0)
- `float` – less-precise decimal (rare in intro class, but know it exists)
- `char` – a single character (e.g. 'A', '7', '#')
- `string` – text (e.g. "Hello, World!", "42")
- `bool` – `true` or `false` only

---

**Literal Syntax:**
- `123`, `-5`, `3.14`, `'C'`, `"dog"`, `true`
- Type suffixes: `1.5f` for float, `123L` for long (not common for beginners)

---

### Simple Primitive Types Table

| Type      | .NET Type         | Size (bytes) | Range / Values                                   | When/Why to Use or Not Use                      |
|-----------|-------------------|--------------|--------------------------------------------------|-------------------------------------------------|
| `sbyte`   | System.SByte      | 1            | -128 to 127                                      | Rarely used; only for small signed numbers       |
| `byte`    | System.Byte       | 1            | 0 to 255                                         | For small positive numbers, binary data          |
| `short`   | System.Int16      | 2            | -32,768 to 32,767                                | Rarely used; for memory savings in large arrays  |
| `ushort`  | System.UInt16     | 2            | 0 to 65,535                                      | Rarely used; for large positive numbers only     |
| `int`     | System.Int32      | 4            | -2,147,483,648 to 2,147,483,647                  | Most common for counting, general whole numbers  |
| `uint`    | System.UInt32     | 4            | 0 to 4,294,967,295                               | Rarely used; only for large positive numbers     |
| `long`    | System.Int64      | 8            | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | For very large whole numbers (rare in intro)     |
| `ulong`   | System.UInt64     | 8            | 0 to 18,446,744,073,709,551,615                  | Rarely used; only for huge positive numbers      |
| `char`    | System.Char       | 2            | Unicode characters (U+0000 to U+FFFF)            | For single characters, not strings               |
| `float`   | System.Single     | 4            | ~±1.5×10⁻⁵ to ±3.4×10³⁸ (7 digits precision)    | For decimals when memory is tight; use `double` usually |
| `double`  | System.Double     | 8            | ~±5.0×10⁻³²⁴ to ±1.7×10³⁰⁸ (15-16 digits precision) | Default for decimals, math, science, averages    |
| `decimal` | System.Decimal    | 16           | ±1.0×10⁻²⁸ to ±7.9×10²⁸ (28-29 digits precision) | For money/financial values; slower than `double` |
| `bool`    | System.Boolean    | 1            | `true` or `false`                                | For yes/no, on/off, true/false logic             |

*See the [C# Language Specification: Simple Types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#835-simple-types) for more details.*

---

### What You Need to Know

- **Type Categories:**
  - C# types are either **value types** (store the actual value) or **reference types** (store a reference to the value).
  - All types are based on `object` (the root type in C#).
  - Value types include numbers, `bool`, and `char`. Reference types include `string` and arrays.

- **Simple Types:**
  - Simple types are built-in and have short names (like `int`, `double`).
  - These are just shortcuts for types in the `System` namespace (e.g., `int` is really `System.Int32`).
  - You can use things like `int.MaxValue` or `int.ToString()`.
  - You can write values directly (e.g., `123` for `int`, `'a'` for `char`).

- **Whole Number Types (Integral):**
  - Signed: `sbyte` (8-bit), `short` (16-bit), `int` (32-bit), `long` (64-bit)
  - Unsigned: `byte` (8-bit), `ushort` (16-bit), `uint` (32-bit), `ulong` (64-bit)
  - `char` is a 16-bit unsigned type for Unicode characters.
  - Signed types use two’s complement (how computers store negative numbers).
  - You can't automatically convert other types to `char`.
  - Use `checked`/`unchecked` to control what happens if you go past the max/min value.

- **Decimal and Floating-point Types:**
  - `float` (32-bit) and `double` (64-bit) are for numbers with decimals.
  - They can represent special values like positive/negative zero, infinity, and NaN (Not-a-Number).
  - Sometimes math is done with more precision than you expect—use a cast if you need to force a type.
  - `decimal` (128-bit) is for money and is more exact for decimals (e.g., 0.1 is exact).

- **Boolean Type:**
  - `bool` can only be `true` or `false`.
  - You can't use numbers as booleans (unlike some other languages).
  - Always use a comparison, like `if (x != 0)`.

- **Character Type:**
  - `char` is for a single Unicode character (like `'A'` or `'\n'`).
  - Not all math or operations you can do on numbers work on `char`.

- **String Type:**
  - `string` is for text (like names, sentences, etc.).
  - It's a reference type (it points to the text in memory).
  - Use double quotes for string values (e.g., `"hello"`).

- **Boxing and Unboxing:**
  - Value types (like `int`) can be turned into objects (boxing) and back (unboxing).
  - This lets you use value types in places that expect an object.

---

- **Usage & Examples:**
  - `int age = 21;`
  - `double price = 19.99;`
  - `char grade = 'A';`
  - `string name = "Sheila";`
  - `bool isOn = false;`

- **When to Use Which:**
  - Use `int` for things you count (age, score, number of dogs)
  - Use `double` for math with decimals (money, averages)
  - Use `string` for anything with text (names, user input)
  - Use `bool` for on/off, yes/no, true/false

- **Data Conversion:**
  - Change between types with things like `int.Parse("42")`, `double.Parse("3.14")`, or `ToString()`
  - Watch out: parsing fails if the string isn't a number (use try/catch or `TryParse`)

- **Why it Matters:**
  - Using the wrong type causes bugs and errors
  - Don't use a `double` if you only need to count to 10 (wastes memory)
  - C#'s strong typing helps catch mistakes before your program runs

---

**Practical:**
- Practice declaring variables of different primitive types.
- Try assigning values and printing them to the console.
- Experiment with type conversions and see what works and what causes errors.
- Use the table above to pick the right type for your data.

---

## References
- [C# Programming Guide: Types](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/)
- [C# Language Specification: Simple Types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#835-simple-types)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

