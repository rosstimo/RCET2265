# GDI+ Graphics in Windows Forms

Windows Forms exposes GDI+ drawing through `System.Drawing`. This is useful for simple custom graphics and assignments such as an Etch-A-Sketch-style application.

## Draw in a paint event

Custom drawing should normally occur in a control's `Paint` event using the `Graphics` object supplied by the event arguments.

```csharp
private void DrawingPanel_Paint(object? sender, PaintEventArgs e)
{
    using Pen pen = new(Color.Red, 2);

    e.Graphics.DrawLine(pen, 10, 10, 100, 100);
    e.Graphics.DrawRectangle(pen, 20, 20, 60, 40);
    e.Graphics.DrawEllipse(pen, 50, 50, 30, 30);
}
```

Objects such as `Pen` that own unmanaged drawing resources should be disposed. A `using` declaration handles that automatically.

## Preserve drawing state

Pixels drawn directly to a control are not your program's permanent drawing state. A repaint can erase them. Store the information needed to recreate the image, such as points, line segments, shapes, or a backing bitmap, and redraw it when the control repaints.

## Interaction

Mouse events such as `MouseDown`, `MouseMove`, and `MouseUp` can update the stored drawing state. Call `Invalidate()` when the control needs to be repainted.

## Animation

A Windows Forms `Timer` can drive simple periodic updates. Change the model/state on the timer event, then repaint. Avoid putting an uncontrolled busy loop on the UI thread.

## References

- [Overview of graphics in Windows Forms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/overview-of-graphics)
- [Getting started with graphics programming](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/getting-started-with-graphics-programming)
- [Windows Forms control events](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/events)
