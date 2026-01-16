# Etch-O-Sketch

## Project Setup

See [Project Setup Instructions](./ProjectSetup.md) for detailed steps on how to set up your C# project and version control for this assignment.

---

## Assignment Instructions

Create a Windows Forms application that simulates an Etch-A-Sketch. Your form must include:

- A DisplayPictureBox for drawing (drawing only occurs within this box)
- Buttons: SelectColor, DrawWaveforms, Clear, Exit
- Top menu and context menu with:
  - File: Exit
  - Edit: Select Color, Draw Waveforms, Clear
  - Help: About
- Tooltips on the picture box and all buttons
- Proper tab order for all user input and controls
- Access keys for each button and/or menu item
- DrawWaveformsButton as the accept button (Enter)
- Clear button as the cancel button (Esc)

### Drawing and User Interaction

- Drawing occurs when the left mouse button is held and moved over the picture box.
- Present the color dialog for the user to select a new color for drawing on these events:
  - Select Color button
  - Select Color top menu item
  - Select Color context menu item
  - Mouse middle click on the picture box
- When the Erase button is clicked, the picture box should "shake" and be erased. (include a sound for extra street cred)
- When the Draw Waveforms button is clicked:
  - The picture box is erased
  - A 10x10 scope graticule is drawn evenly spaced within the picture box
  - Sine, Cosine, and Tangent waves are drawn in different colors, filling the picture box top to bottom, one cycle wide

---

## Example Form

(Include a screenshot or diagram of the expected form layout if available.)

---


When complete, push your code to your GitHub repository and submit the link as instructed.
