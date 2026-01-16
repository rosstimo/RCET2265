# GDI+ Graphics (Etch-O-Sketch, etc) in C#

## Introduction

GDI+ is Windows’ graphics engine for drawing on controls. It lets you create custom UIs, games, and drawing apps. Learning GDI+ helps you understand graphics, user interaction, and event-driven programming in C#.

---

**What is GDI+?**
- Windows’ graphics engine for drawing on controls
- Used for custom UI, games, drawing apps

---

**Drawing Basics:**
- Paint event: where custom drawing lives
- `Graphics` object: `e.Graphics` in Paint event
- Methods: `DrawLine`, `DrawRectangle`, `DrawEllipse`, `DrawString`
- Pen and Brush: set color, thickness, fill
- Example:
  ```csharp
  private void Form_Paint(object sender, PaintEventArgs e)
  {
      Pen pen = new Pen(Color.Red, 2);
      e.Graphics.DrawLine(pen, 10, 10, 100, 100);
      e.Graphics.DrawRectangle(pen, 20, 20, 60, 40);
      e.Graphics.DrawEllipse(pen, 50, 50, 30, 30);
      e.Graphics.DrawString("Hello", this.Font, Brushes.Black, 10, 120);
  }
  ```

---

**Drawing Surface:**
- PictureBox or Panel for custom drawing area
- Store “drawing state” (list of points, lines, or bitmap for persistence)
- Double-buffering for smooth, flicker-free drawing

---

**User Interaction:**
- Mouse events: `MouseDown`, `MouseMove`, `MouseUp` for drawing
- Color picker: `ColorDialog` to let user select pen color

---

**Animation & Sound:**
- Use Timer for simple animations (e.g., “shake to erase”)
- `Console.Beep` or SoundPlayer for feedback

---

**Integration:**
- Menus, context menus, tooltips, keyboard shortcuts for drawing actions
- Partial classes: GUI designer code split from logic

---

**Why it Matters:**
- Unleash creativity, real interactive programming, fun as hell
- Teaches UI, graphics, and event handling skills

---

**Practical:**
- Practice drawing lines, shapes, and text in a Paint event.
- Try handling mouse events to let users draw.
- Experiment with colors, animation, and sound.
- Build a simple Etch-O-Sketch or drawing app for fun.

---

## References
- [C# Programming Guide: Graphics](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/graphics-overview)
- [C# Programming Guide: Drawing with GDI+](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-draw-with-gdi)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

