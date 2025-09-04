# Intro to C# Programming – Full Course Core Topics (Final Draft)

---

## 1. Tools, Setup & Workflow
- **Visual Studio:** Download, install, update; configure settings; learn the interface and essential shortcuts (F5, F10, F11, etc.).
- **Creating Projects:** Console and WinForms apps, project/solution structure, good naming habits.
- **Git & GitHub:** Install Git, create repos, commit, push, pull, backup your code, and recover when you screw up.
- **IDE Habits:** Breakpoints, stepping, watches, navigating code, quick actions.
- **Documentation:** Use F1, read C# docs, MSDN, StackOverflow, error messages.

## 2. Program Structure & Syntax
- **Anatomy:** namespace, class, Main method. Code is always in a class.
- **Comments:** Single-line, multi-line, doc comments, and *why* you comment.
- **Code Style:** Indentation, naming conventions (PascalCase, camelCase, ALL_CAPS), file headers, no mixing tabs/spaces.
- **RCET C# Style Guide:** Follow it or lose points.
- **`using` Statements:** Ignore at first; only care when you need extra libraries.

## 3. Primitive Data Types
- **Core Types:** `int`, `double`, `float`, `char`, `string`, `bool`.
- **Literals & Suffixes:** 123, 3.14, 'A', "dog", true; demo type suffixes.
- **Usage:** Real-world examples. `int` for counts, `string` for text, `bool` for true/false, etc.
- **Data Conversion:** `Parse`, `TryParse`, `ToString()`; avoid conversion bugs.
- **Why It Matters:** Wrong type = bugs. C# catches mistakes early.

## 4. Basic Operators
- **Arithmetic:** +, -, *, /, %
- **Assignment:** =, +=, -=, etc.
- **Comparison:** ==, !=, <, >, <=, >=
- **Logical:** &&, ||, !
- **String Concatenation:** +, interpolation.
- **Operator Precedence:** Parentheses save lives.
- **Why:** Get these wrong and you’ll have no idea why your code misbehaves.

## 5. Variables & Constants
- **Declaration/Initialization:** Syntax, good names, always initialize.
- **Scope:** Local vs. class-level, avoid shadowing.
- **Explicit Typing:** Always use actual type (not `var`) for beginners.
- **Constants:** `const`, naming conventions, magic numbers are evil.
- **Habits:** Use variables for clarity, delete dead code.

## 6. Getting Started & Console Fundamentals
- **Console:** WriteLine, Write, ReadLine, Beep, Clear. Fun demos.
- **Running Programs:** F5, output window, ReadLine to pause.
- **Docs/Help:** F1, search for anything. Learn to RTFM.
- **Debugging:** Breakpoints, step through.
- **Why:** Console is where you get strong before you move to GUI.

## 7. String Manipulation & Formatting
- **Creation:** Literals, concatenation, interpolation.
- **Methods:** ToUpper, ToLower, Substring, IndexOf, Contains, Split, Join.
- **Formatting/Padding:** Format, PadLeft/Right, interpolation.
- **Parsing:** Parse, TryParse for input, always validate.
- **Why:** Strings are everywhere, learn to manipulate or die trying.

## 8. Math & The Math Class
- **Basic Math:** +, -, *, /, %, beware integer division.
- **Math Class:** Abs, Pow, Sqrt, Round, Min/Max. Random numbers.
- **Order:** PEMDAS, always use parentheses if unsure.
- **Real Use:** Tables, scoring, games.
- **Why:** You can’t do science or games without it.

## 9. Control Flow & Error Types
- **Conditionals:** if, else if, else (keep it flat), switch (simple).
- **Boolean Logic:** &&, ||, !
- **Ternary Operator:** (demo, not required).
- **Error Types:**
    - Compiler errors: won’t build
    - Exceptions: runtime crash
    - Logic errors: runs, wrong output
    - Style violations: ugly but “works”
- **Practical:** See, fix, and learn from all four.

## 10. Try/Catch & Debugging
- **try/catch:** Catch errors, don’t let programs crash. Always show error to user.
- **Read Error Messages:** Whole message and stack trace.
- **Debugging Tools:** Breakpoints, step into/over, Watches, Locals, Autos. Use from day one.
- **Why:** Real programming is fixing bugs, not just writing code.

## 11. Loops
- **Types:** for, while, do-while.
- **Loop Control:** break, continue. Nested loops: use with care.
- **Mistakes:** Off-by-one, infinite loops—find, fix, repeat.
- **Tasks:** Counting, summing, searching, table generation.
- **Why:** Loops = automation, data processing, real work.

## 12. Collections & Data Structures
- **Arrays:** Declare, init, loop, index, zero-based, multi-dimensional (demo).
- **Lists (`List<T>`):** Dynamic, .Add, .Remove, .Count, foreach, convert to/from arrays.
- **Dictionaries:** Key/value pairs, ContainsKey, TryGetValue, real-world uses.
- **Stack/Queue:** LIFO/FIFO, Push/Pop/Peek, Enqueue/Dequeue/Peek. Use cases: undo, print jobs.
- **Why:** Data structures = power tools for solving problems.

## 13. Methods & Functions
- **Subroutines (`void`):** Do stuff, no return. Syntax: `void Foo() {}`
- **Functions (return):** Return values. Syntax: `int Add(int x, int y)`
- **Scope/Lifetime:** Local, class-level, static variables.
- **Argument Passing:** By value (default), by reference (ref/out, demo).
- **Overloading:** Same name, diff parameters.
- **Recursion:** Calls itself, always with a base case. Factorial, Fibonacci, etc.
- **Why:** Methods = organization, reuse, clarity.

## 14. Object-Oriented Programming (OOP)
- **Classes/Objects:** Blueprint vs. instance, fields, properties, methods.
- **Constructors:** Default and parameterized.
- **Static vs. Instance:** Shared vs. per object.
- **Namespaces & Fully Qualified Names:** Prevent conflicts, relate to folders/files.
- **Project/File Structure:** One class per file, folders=namespaces, Visual Studio solution/project hierarchy.
- **Access Modifiers:** public, private, protected, internal, etc. (Who gets to touch what.)
- **Inheritance:** : BaseClass, base/derived, code reuse, override (virtual/override).
- **Class Libraries:** Reusable, referenced across projects.
- **Partial Classes:** Designer/code split for GUIs.
- **NOT in Beginner:** Interfaces, abstract classes—just mention.

## 15. File I/O
- **Text Files:** ReadAllText, ReadAllLines, WriteAllText, WriteAllLines, AppendAllText/Lines. StreamReader/Writer for line-by-line (with using block). Always try/catch.
- **Dialogs (WinForms):** OpenFileDialog, SaveFileDialog, ColorDialog, FontDialog, PrintDialog.
- **Path Handling:** Path.Combine. Avoid hardcoded paths.
- **Demo Only (Advanced):** Binary file read/write, random access, serialization (JSON/XML), async file I/O, FileSystemWatcher.
- **Why:** Save/load data, configs, user input.

## 16. WinForms GUI
- **Controls:** Labels, buttons, textboxes, checkboxes, radios, combos, lists.
- **Menus/Context Menus:** MenuStrip, ContextMenuStrip, File/Edit/Help layout.
- **ToolTips/Access Keys:** Hover help, Alt+key, Accept (Enter)/Cancel (Esc), tab order.
- **Multiple Forms:** Show, ShowDialog, splash screens, dialog/main windows.
- **Dialogs:** Open/Save/Color/Font/Print with error handling.
- **Naming:** Files/forms: MainForm.cs, SplashScreenForm.cs. Controls: SubmitButton, NameTextBox, etc.
- **OOP Structure:** Each form = class; partial classes for designer/code; keep logic out of UI handlers.
- **Events:** What, why, how; every GUI is event-driven.
- **Habits:** Clean layout, separation of logic/UI, test with keyboard/mouse.

## 17. GDI+ Graphics (Etch-O-Sketch, etc)
- **What:** GDI+ lets you draw on controls, create custom UI, mini-games.
- **Drawing:** Paint event, Graphics object, DrawLine/Rectangle/Ellipse/String, Pen/Brush.
- **Surface:** PictureBox/Panel, drawing state, double-buffering for smoothness.
- **Interaction:** MouseDown/Move/Up for drawing; ColorDialog for pen color.
- **Animation/Sound:** Timer for shake/animation, Beep/SoundPlayer for fun.
- **Integration:** Menus, shortcuts, tooltips, partial classes.
- **Why:** Teaches UI, graphics, event handling, and lets students build cool shit.

## 18. Professionalism, Documentation & Habits
- **Commenting:** Intent, file headers, summaries. Not just “what” but “why.”
- **Git:** Commit early/often, clear messages, backup to GitHub, recover fast.
- **Assignment Submission:** Follow naming/file/repo instructions, Canvas/GitHub.
- **Rubric Adherence:** Read/check every time.
- **Docs/Help:** Always RTFM before you panic. Ask for help right: show your error, what you tried, expected outcome.

## 19. Not in This Course (Save for Advanced)
- **Interfaces:** interface keyword, contracts for classes, polymorphism
- **Abstract Classes/Methods:** abstract keyword, inheritance patterns
- **LINQ:** SQL-like queries for collections
- **Async/Await, Multithreading:** Asynchronous programming, Tasks
- **Design Patterns:** MVC, MVVM, Singleton, Factory, etc.
- **Serialization (Complex):** Full JSON, XML, binary persistence
- **Networking/Web APIs:** HTTP, REST APIs, sockets
- **Database Programming:** SQL, Entity Framework
- **FileSystemWatcher:** Live file monitoring
- **Custom Controls/Advanced WinForms:** Owner-drawn, drag-and-drop
- **Live Graphics/Game Loops:** GDI+ animation for games
- **Command Line Arguments:** Demo if time, not required
- **Throwing Exceptions:** `throw` keyword for custom errors
- **Advanced Access Modifiers:** protected internal, private protected

*Want more? Take the advanced class, or ask Sheila for a private tour of hell.*

