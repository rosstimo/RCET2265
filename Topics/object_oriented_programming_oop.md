# Object-Oriented Programming (OOP) in C#

## Introduction

Object-oriented programming (OOP) is a way to organize and structure your code using classes and objects. It helps you build real, maintainable, and understandable programs. This section covers the basics of classes, objects, inheritance, access modifiers, and more.

---

**Classes & Objects:**
- Blueprint (`class`), real thing (`object`)
- Fields, properties, methods; creating new objects with `new`
- Example:
  ```csharp
  class Person
  {
      public string Name;
      public void SayHello()
      {
          Console.WriteLine($"Hello, my name is {Name}.");
      }
  }
  Person p = new Person();
  p.Name = "Sheila";
  p.SayHello();
  ```

---

**Constructors:**
- Special methods to set up new objects
- Default and parameterized constructors
- Example:
  ```csharp
  class Car
  {
      public string Model;
      public Car(string model)
      {
          Model = model;
      }
  }
  Car myCar = new Car("Toyota");
  Console.WriteLine(myCar.Model); // Toyota
  ```

---

**Static vs. Instance:**
- Static members belong to the class, not any object
- Example:
  ```csharp
  class Counter
  {
      public static int Total;
      public int Value;
      public Counter()
      {
          Total++;
      }
  }
  Counter c1 = new Counter();
  Counter c2 = new Counter();
  Console.WriteLine(Counter.Total); // 2
  ```

---

**Namespaces & Fully Qualified Names:**
- Organize code, prevent conflicts, tie to folders/files
- Use `Project.ClassName` to disambiguate
- Example:
  ```csharp
  namespace MyApp
  {
      class Widget {}
  }
  MyApp.Widget w = new MyApp.Widget();
  ```

---

**File/Project Structure:**
- One class per file, folders map to namespaces
- Solution, project, file hierarchy in Visual Studio

---

**Access Modifiers:**
- `public`, `private`, `protected`, `internal`, `protected internal`, `private protected`
- "Who can touch your stuff"—focus on public/private for intro, explain with analogies
- Example:
  ```csharp
  class BankAccount
  {
      private double balance;
      public void Deposit(double amount)
      {
          balance += amount;
      }
      public double GetBalance()
      {
          return balance;
      }
  }
  ```

---

**Inheritance:**
- `: BaseClass`, derived classes inherit fields/methods
- Use `base` to access parent stuff
- When to use (code reuse, logic), when not to (don’t just inherit everything)
- Simple overrides: `virtual`, `override` for methods
- Example:
  ```csharp
  class Animal
  {
      public virtual void Speak() { Console.WriteLine("Animal sound"); }
  }
  class Dog : Animal
  {
      public override void Speak() { Console.WriteLine("Woof!"); }
  }
  Dog d = new Dog();
  d.Speak(); // Woof!
  ```

---

**Class Libraries:**
- Reusable collections of classes/methods; how to create, reference, and use

---

**Partial Classes:**
- Used by Visual Studio designer to split GUI and logic

---

**Not Covered Yet:**
- Interfaces, abstract classes—mention for curiosity, do in advanced

---

**Why it Matters:**
- OOP is how you build real, maintainable, and understandable programs
- Good OOP = less pain when your projects grow

---

**Practical:**
- Practice creating classes and objects.
- Try using constructors, access modifiers, and inheritance.
- Organize your code with namespaces and separate files.
- Experiment with static members and class libraries.

---

## References
- [C# Programming Guide: Classes and Objects](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes-and-objects)
- [C# Programming Guide: Inheritance](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance)
- [C# Programming Guide: Access Modifiers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

