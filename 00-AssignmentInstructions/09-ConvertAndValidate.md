# Convert and Validate

## Purpose

This assignment practices writing a method that reports success with a `bool` return value and returns a converted integer through an `out` parameter.

Use `int.TryParse` for the actual string-to-integer conversion. The work in this assignment is organizing that behavior into your own method and then using the method from a repeated console interaction.

## Project Setup

See [Project Setup Instructions](./ProjectSetup.md) for the standard C# project and version-control setup.

## Conversion Method

Write a method that:

- takes a `string` containing the text to convert;
- takes an `out int` parameter for the converted value;
- uses `int.TryParse` to attempt the conversion;
- returns `true` when the conversion succeeds;
- returns `false` when the conversion fails.

An `out` parameter must be assigned before the method returns. With `int.TryParse`, the output value is the converted integer on success and `0` on failure. Do not try to preserve a previous value in the caller when conversion fails.

The method should let the caller use one result to answer two questions:

- Did the conversion work?
- If it worked, what integer was produced?

## Main Program

In `Main`:

1. Repeatedly prompt the user to enter a whole number or choose to quit.
2. Call your conversion method for numeric input.
3. If the method returns `true`, display the converted integer.
4. If the method returns `false`, display a clear error message and continue prompting.
5. Continue until the user chooses to exit.

Keep the conversion logic in the method rather than duplicating it in `Main`.

## Before You Submit

Verify at least these cases:

- a positive whole number;
- a negative whole number;
- `0`;
- nonnumeric text;
- a value outside the range of `int`;
- the quit path.

Include the standard program information header required by the course style guide.

When complete, commit and push your work to your GitHub repository and submit the link as instructed.
