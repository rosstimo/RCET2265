# Windows Forms GUI in C#

Windows Forms is a **Windows desktop** UI framework. It is useful in RCET 2265 for learning event-driven programming, controls, forms, and the separation between user-interface code and program logic.

## Controls and properties

Common controls include:

- `Label`
- `Button`
- `TextBox`
- `CheckBox`
- `RadioButton`
- `ComboBox`
- `ListBox`

Controls are objects with properties, methods, and events.

## Events

A GUI usually spends most of its time waiting for an event. A button click event handler might look like:

```csharp
private void SubmitButton_Click(object? sender, EventArgs e)
{
    MessageBox.Show("Button clicked!");
}
```

Keep event handlers focused. If the work is reusable or substantial, put it in another method or class and call it from the event handler.

## Forms and partial classes

A Windows Form is a class. Visual Studio normally splits designer-generated code and your code using a partial class. Do not manually edit generated designer code unless you know exactly why you are doing it.

## Keyboard usability

Learn to configure:

- tab order
- access keys
- Accept button for Enter
- Cancel button for Escape
- appropriate focus behavior

A GUI should not require the mouse for every action.

## Dialogs

Windows Forms provides dialogs such as `OpenFileDialog`, `SaveFileDialog`, `ColorDialog`, and `FontDialog`. Check the dialog result before using the selected value.

## References

- [Windows Forms documentation](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
- [Windows Forms control events](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/events)
