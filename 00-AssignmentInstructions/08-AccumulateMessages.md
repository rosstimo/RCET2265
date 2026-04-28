# Accumulate Messages Function

## Purpose

This assignment is about **writing and using a function**.

Your job is to complete the `UserMessages` function so that it stores messages across multiple function calls.

---

## Starter Code


Use the provided starter files:

- [08-AccumulateMessagesStarter/Program.cs](08-AccumulateMessagesStarter/Program.cs)
- [08-AccumulateMessagesStarter/Test.cs](08-AccumulateMessagesStarter/Test.cs)

Do **not** rename the class, method, or files unless.


```csharp
public static string UserMessages(string newMessage, bool clear)
{
   //Write your code here.
   return messages;
}
```

---

## What Your Function Must Do

Write code for `UserMessages` so that it behaves as follows:

1. The function must remember previously entered messages.
2. All saved messages must be erased.
3. Do not save empty messages.
4. Each saved message should end with a newline.
5. The function must return **all currently saved messages**.

---

## Important Rules

1. **You must use the provided function.**
   - The required work belongs in `UserMessages`.
   - There is no need to write any code outside of that function.
   - do not change or modify any code in `Main` or `Test`.

2. **Do not remove the test code.**
   - The tests are there to help you verify that your function works.

---

## How to Work on the Assignment

1. Open the starter project.
2. Find the `UserMessages` function in `Program.cs`.
3. Write your codeinside that function.
4. Run the program with `Test.Auto();` enabled.
5. Fix your code until all automatic tests pass.
6. Optionally switch to `Test.Manual();` and try it yourself.

---

## Submission

When your program is working:

1. Save your work.
2. Commit and push your code to your GitHub repository.
3. Submit the GitHub link as instructed.
