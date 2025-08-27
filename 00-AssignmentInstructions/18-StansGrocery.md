# Stan's Grocery

## Project Setup

See [Project Setup Instructions](./ProjectSetup.md) for detailed steps on how to set up your C# project and version control for this assignment.

---

## Assignment Instructions

Create a Windows Forms application for Stan's Grocery search. Your program should:

- Load item data from a disk file (e.g., "Grocery.txt") into a global array or suitable data structure when the program starts.
- Allow customers to search for items by:
  - Typing the item’s name in a text box
  - Selecting the item from a combo box
  - Selecting the item from a list box
- The DisplayListBox should show only unique item names in alphabetical order, filtered by the current filter selection.
- The FilterComboBox should:
  - Always have "Show All" as the first option
  - Show unique aisle numbers in descending order when FilterByAisleRadioButton is checked
  - Show unique category names in alphabetical order when FilterByCategoryRadioButton is checked
  - When the user selects an option in the FilterComboBox, display all items matching the selected aisle or category in the DisplayListBox (depending on the current radio button selection).
- When the SearchButton is clicked, the DisplayListBox should show any/all items where any field (name, aisle, or category) contains the search string (case-insensitive, partial match). If no match is found, the DisplayListBox should be empty and the DisplayLabel should say "Sorry no matches for {searchString}".
- The DisplayLabel should show properly formatted information for the selected item (name, aisle, category), e.g.:  
  **You will find Cinnamon on aisle 7 with the Spices & herbs**
- If the item is not found, inform the customer.
- When "zzz" is typed in the search text box, the program should stop.

### Controls and Naming

- Name all files and controls exactly as specified:
  - Files: StansGrocery.sln, StansGroceryForm.cs, SplashScreenForm.cs, AboutForm.cs
  - Controls: SearchTextBox, SearchButton (Accept Button), FilterComboBox, DisplayListBox, DisplayLabel, FilterGroupBox, FilterByAisleRadioButton (default), FilterByCategoryRadioButton
  - Menus: TopMenuStrip (File > Search, Exit; Help > About), ContextMenuStrip (Search, Exit)
  - Other: MainToolTip

### Additional Requirements

- Add the data file "Grocery.txt" to the project folder and load it at startup.
- Use a temporary array to parse and load the data into your main data structure.
- The DisplayListBox should update based on filter and search criteria.
- The FilterComboBox and radio buttons should interact as described above.
- The SearchTextBox and SearchButton should update the DisplayListBox and DisplayLabel appropriately.
- The DisplayLabel should always reflect the currently selected item in the DisplayListBox.

---

Remember to include the standard program information header in your code.

---

When complete, push your code to your GitHub repository and submit the link as instructed.
