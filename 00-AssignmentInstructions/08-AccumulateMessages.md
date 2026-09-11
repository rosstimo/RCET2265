# Accumulate Messages Function

## Purpose

This assignment practices writing a method that updates and returns persistent program state.

The starter project already provides the storage, menu, and test code. Your job is to complete the provided `UserMessages` method.

## Starter Files

Use the provided starter files:

- [08-AccumulateMessagesStarter/Program.cs](08-AccumulateMessagesStarter/Program.cs)
- [08-AccumulateMessagesStarter/Test.cs](08-AccumulateMessagesStarter/Test.cs)

Do not rename the provided files, classes, field, or method. Do not modify `Main` or the `Test` class.

The starter code includes this class-level field:

```csharp
private static string messages = "";
```

That field is outside `UserMessages` on purpose. Its value remains available between separate calls to the method. You do not need to create another storage mechanism.

Complete this method:

```csharp
public static string UserMessages(string newMessage, bool clear)
{
    // Write your code here.
    return messages;
}
```

## Required Behavior

Your method must satisfy all of the following rules:

1. If `clear` is `true`, erase all saved messages.
2. When `clear` is `true`, do not save `newMessage` during that call.
3. If `clear` is `false` and `newMessage` is not an empty string, add it to the saved messages.
4. End each saved message with `Environment.NewLine`.
5. Do not add anything when `newMessage` is an empty string.
6. Always return all currently saved messages.

The method will be called many times. Its result therefore depends on both the current arguments and the messages saved by earlier calls.

## Test Your Work

The starter project provides two test modes.

### Automatic test

Run the program and choose `A`.

The automatic tests check empty input, several sequential messages, clearing the saved messages, and clearing midway through a sequence. Continue until all tests pass.

### Manual test

Run the program and choose `M`.

Use the menu to save messages, display them, clear them, and verify the behavior yourself.

Do not remove or modify the provided test code to make a failing implementation appear to pass.

## Submission

When the program is working:

1. Save your work.
2. Commit and push your code to your GitHub repository.
3. Submit the GitHub link as instructed.
