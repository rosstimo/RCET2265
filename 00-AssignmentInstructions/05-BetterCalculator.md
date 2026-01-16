# Better Calculator

## Project Setup

See [Project Setup Instructions](./ProjectSetup.md) for detailed steps on how to set up your C# project and version control for this assignment.

---

## Assignment Instructions

Extend the capability of your simple calculator program. Your program should:

1. Ask the user for two numbers. Allow the user to enter "Q" at any time to quit.
2. Validate user input. If the input is not a whole number or "Q", prompt the user again.
3. Present a menu to choose an arithmetic operation:
    - 1. Add
    - 2. Subtract
    - 3. Multiply
    - 4. Divide
4. If the user enters an invalid menu option, prompt them again.
5. Display the result of the chosen operation in a clear format (e.g., `4 + 3 = 7`).
6. After each calculation, prompt the user to enter two numbers again or "Q" to quit.
7. If the user enters "Q" at any prompt, display a goodbye message and exit.
8. Wait for the user to press Enter before closing the console window.
9. Remember to include the standard program information header in your code.

---

**Example Output:**

```console
Please enter two numbers. Enter "Q" at any time to quit.
Choose a Number: t
You entered "t", please enter a whole number.
Choose a Number: 4
You entered "4"
Choose a Number: 3
You entered "3"
Choose one of the following options:
1. Add
2. Subtract
3. Multiply
4. Divide
7
You entered "7"
Choose one of the following options:
1. Add
2. Subtract
3. Multiply
4. Divide
1
You entered "1"
4 + 3 = 7
Please enter two numbers. Enter "Q" at any time to quit.
Choose a Number: q
You entered "q"
Have a nice day
Press enter to close this window
```

---

When complete, push your code to your GitHub repository and submit the link as instructed.
