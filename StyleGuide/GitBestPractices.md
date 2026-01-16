# Git and GitHub Repo Best Practices

Don’t be the reason your group project repo looks like a dumpster fire. Here’s how to use Git (and GitHub) the right way, without pissing off your teammates, your instructor, or your future self.

---

## General Rules

* **Commit Early, Commit Often:**

  Don’t write 200 lines then save it all in one commit. Make small, logical commits for each change or feature. If something breaks, you’ll know exactly where.

  **Good:**
  ```sh
  git add Calculator.cs
  git commit -m "Add Add() and Subtract() methods"
  ```

  **Bad:**
  ```sh
  git commit -am "finished homework" # Vague, covers everything, useless
  ```

* **Write Clear Commit Messages:**

  First line: short, to the point (present tense, no period). Extra details after a blank line.

  **Good:**
  ```sh
  git commit -m "Add login validation logic"
  ```

  **Bad:**
  ```sh
  git commit -m "stuff"
  git commit -m "changes"
  ```

* **Don’t Commit Junk:**

  Don’t add or commit `bin/`, `obj/`, `.vs/`, `*.user`, or random output files. Use a `.gitignore` file. If you don’t, expect pain.

* **One Project Per Repo (Usually):**

  Unless your course says otherwise, keep one solution/project per repo. Don’t toss five unrelated projects in one place.

* **Descriptive Repo, Branch, and File Names:**

  - Repo names should use PascalCase, match your main project or solution name, and never include spaces, underscores, your initials, the semester, or any random abbreviations. Example: `InventoryManager`, `RCETCalculator2025`, not `inventory_manager`, `calcProj`, `TJS_Fall2025`, or `Smith_Final`.
  - The repo is owned by you on GitHub. Your name and username are already attached—don’t put your initials or the semester in the repo name. Keep it simple and clear.
  - Branch names should describe what you’re doing—use slashes for feature/bugfix style. Example: `feature/login`, `bugfix/fix-total-calc`. No `stuff`, `dev`, or your first name as a branch name.
  - Commit file names that actually describe what changed. Don’t rename files for no reason, and never leave files named `NewClass1.cs` in your repo. Rename them as soon as you know what they do.

  **Good Repo Names:**
  - `InventoryManager`
  - `PayrollSystem`

  **Bad Repo Names:**
  - `inventory_manager` # underscores
  - `My Repo` # spaces
  - `final_final_thisone` # wtf does that mean?
  - `SmithFinalProject` # don't need your name/initials
  - `CS1150_Fall2025` # don't need the semester

  **Good Branch Names:**
  - `feature/user-auth`
  - `bugfix/rounding-error`

  **Bad Branch Names:**
  - `dev`
  - `stuff`
  - `bob`

  **Good File Names:**
  - `OrderManager.cs`
  - `InvoiceService.cs`

  **Bad File Names:**
  - `final_project_code.cs`
  - `Program2.cs`
  - `foo.cs`

* **README.md:**

  Every repo has one. State what it is, how to run it, and anything a stranger would need to know.

* **No Passwords or Keys:**

  NEVER commit passwords, API keys, or anything secret. If you do, you’ll regret it.

---

## Branching

* **Main is Sacred:**

  `main` (or `master`) should always build and work. Never push broken code there.

* **Feature Branches:**

  Make a new branch for each feature or bugfix. Don’t mix six changes in one branch. Merge when it’s solid.

  **Good:**
  ```sh
  git checkout -b feature/login
  git commit -m "Add login controller"
  ```

* **Pull Before You Push:**

  `git pull` before `git push` to avoid collisions.

---

## Collaboration

* **Don’t Edit Main Directly (Unless Solo):**

  Use PRs (pull requests) for reviews if you’re not working alone. Don’t just force-push to main.

* **Resolve Conflicts ASAP:**

  If you see a merge conflict, don’t ignore it—fix it fast. Don’t commit ugly unresolved merge markers.

* **No Commented-Out Code:**

  Don’t push commented-out garbage. If it’s not needed, delete it. Git history keeps everything anyway.

---

## .gitignore Example

Make sure you have a `.gitignore` file in every repo. Here’s a good starting point for C#/.NET:

```
# Ignore build outputs and user files
bin/
obj/
.vs/
*.user
*.suo
*.exe
*.dll
*.log
```

---

# Git Best Practices

Good git habits help keep your codebase clean and collaborative.

---

* **Commit Often with Clear Messages:**
  ```
  git commit -m "Add Student class and tests"
  // Good: clear, descriptive commit message
  ```

---

* **Don’t Commit Commented-Out Code or Temporary Files:**
  ```
  // Good: remove commented-out code before committing
  // (no example needed)
  ```

---

* **Use Branches for Features and Fixes:**
  ```
  git checkout -b feature/add-login
  // Good: use branches for new features
  ```

---

* **Pull and Push Regularly:**
  ```
  git pull
  git push
  // Good: keep your local and remote repos in sync
  ```

---

* **Write Useful .gitignore Files:**
  ```
  # .gitignore
  bin/
  obj/
  *.user
  // Good: ignore build artifacts and user files
  ```

---

**Summary:**

* Commit early, often, and with clear messages
* Never add build junk, secrets, or massive files
* Use branches for features/bugfixes
* Keep main working
* README on every repo

If you do this, you’ll look like you know what you’re doing (even if you don’t).