# WinForms GUI in C#

## Introduction

Windows Forms (WinForms) is a framework for building desktop applications with graphical user interfaces (GUIs) in C#. It lets you create windows, buttons, textboxes, menus, and more. WinForms is a great way for beginners to learn about event-driven programming and user interaction.

---

**Basic Controls:**
- Labels, buttons, textboxes, checkboxes, radio buttons, combo boxes, list boxes
- Example:
  ```csharp
  // Add a Button to your form and handle its click event
  private void SubmitButton_Click(object sender, EventArgs e)
  {
      MessageBox.Show("Button clicked!");
  }
  ```

---

**Menus & Context Menus:**
- Main menu (MenuStrip), context menu (ContextMenuStrip) for right-click actions
- Standard layout: File/Edit/Help, with appropriate commands

---

**ToolTips & Access Keys:**
- ToolTips for all controls (hover help)
- Access keys (`&` in text for Alt+key shortcuts)
- Accept button (Enter), Cancel button (Esc)
- Set tab order for good keyboard navigation

---

**Multiple Forms:**
- Show/hide multiple forms (Show, ShowDialog)
- Splash screen, dialog boxes vs main window

---

**Dialog Boxes:**
- OpenFileDialog, SaveFileDialog, ColorDialog, FontDialog, PrintDialog
- Use results, error handling

---

**Naming Conventions:**
- Files/forms: `MainForm.cs`, `SplashScreenForm.cs`
- Controls: `SubmitButton`, `NameTextBox`, etc.

---

**OOP Structure:**
- Each form is a class; controls are objects
- Event handlers: wire up, keep logic short, call other methods for real work
- Partial classes: designer-generated code vs your logic

---

**Events:**
- Event-driven model: what, why, how; buttons, input, timers

---

**Good Habits:**
- Layout for readability and usability
- Separate logic from UI (don’t cram everything into a button click)
- Test with both mouse and keyboard

---

**Practical:**
- Create a simple form with a button and textbox. Handle the button click to show a message.
- Add a menu and a context menu. Try using a dialog box.
- Practice naming controls and organizing your code.

---

## References
- [C# Programming Guide: Windows Forms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
- [C# Programming Guide: Event Handling](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/events-overview)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

