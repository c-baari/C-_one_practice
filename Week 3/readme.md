# Chapter 3: Making Decisions — Important Concepts

*This README contains explanations and important concepts. C# code examples are provided separately.*

## 1. Decision Structures

* A decision structure controls the flow of program execution based on conditions.
* It allows a program to choose which statements should execute depending on whether a condition is true or false.
* Conditions produce Boolean results: `true` or `false`.
* Sequence Structure executes statements in order, while Decision Structure selects actions based on conditions.

## 2. Conditional Statements

* **If Statement:** Executes a block of statements when its condition is true.
* **If-Else Statement:** Provides two alternative execution paths depending on whether the condition is true or false.
* **Nested If:** Places one decision structure inside another to evaluate multiple related conditions.
* **If-Else-If:** Evaluates multiple conditions in order and executes the first block whose condition is true.
* **Else:** Handles situations where none of the previous conditions are true.

**Important:** In an If-Else-If structure, conditions are evaluated from top to bottom.

## 3. Relational Operators

* Relational operators compare two values and return a Boolean result (`true` or `false`).

| Operator | Meaning               | Purpose                                                     |
| -------- | --------------------- | ----------------------------------------------------------- |
| `>`      | Greater than          | Checks whether one value is larger.                         |
| `<`      | Less than             | Checks whether one value is smaller.                        |
| `>=`     | Greater than or equal | Checks whether a value is greater than or equal to another. |
| `<=`     | Less than or equal    | Checks whether a value is smaller than or equal to another. |
| `==`     | Equal to              | Checks whether two values are equal.                        |
| `!=`     | Not equal             | Checks whether two values are different.                    |

**Important:** `=` assigns a value, while `==` compares two values.

## 4. Logical Operators

* Logical operators combine multiple Boolean conditions or reverse a Boolean result.

| Operator | Name | Purpose                                          |    |                                                   |
| -------- | ---- | ------------------------------------------------ | -- | ------------------------------------------------- |
| `&&`     | AND  | Returns true only when both conditions are true. |    |                                                   |
| `        |      | `                                                | OR | Returns true when at least one condition is true. |
| `!`      | NOT  | Reverses a Boolean result.                       |    |                                                   |

* AND requires all conditions to be true.
* OR requires at least one condition to be true.
* NOT changes true to false and false to true.

## 5. Boolean Variables and Flags

* A Boolean variable stores only two possible values: `true` or `false`.
* A flag is a Boolean variable used to indicate whether a particular condition or situation exists.
* Flags help control program execution and track program states.
* A flag can change its value during program execution depending on the situation.

## 6. String Comparison

* String comparison checks whether two text values are equal or different.
* The `==` and `!=` operators can compare string values.
* C# also provides the `String.Compare()` method for comparing strings.
* `String.Compare()` returns:

  * `0` when both strings are equal.
  * A negative value when the first string comes before the second.
  * A positive value when the first string comes after the second.
* String comparison is useful for checking usernames, passwords, and other text input.

## 7. Data Conversion and TryParse()

* Data conversion changes a value from one data type into another.
* TextBox input is stored as a string, even when the user enters numbers.
* `Parse()` converts a string into a specified data type but can produce an exception when the input is invalid.
* `TryParse()` attempts conversion and returns a Boolean result indicating whether the conversion succeeded.
* Common conversion methods include:

  * `int.TryParse()` — Converts input into an integer.
  * `double.TryParse()` — Converts input into a double.
  * `decimal.TryParse()` — Converts input into a decimal.

**Important:** `TryParse()` helps prevent conversion errors caused by invalid numeric input.

## 8. Input Validation

* Input validation checks user input before it is processed by a program.
* It ensures that entered values meet the required conditions.
* Data conversion checks whether input can be converted into the required data type.
* Input validation checks whether the converted value is acceptable.
* Validation improves the accuracy, reliability, and usability of applications.

## 9. Windows Forms Selection Controls

### Radio Buttons

* Radio Buttons allow users to select one option from a group of choices.
* Selecting one Radio Button automatically deselects another Radio Button in the same group.
* The `Checked` property indicates whether a Radio Button is selected.

### Check Boxes

* Check Boxes allow users to select multiple independent options.
* Each Check Box can be selected or deselected independently.
* The `Checked` property indicates whether a Check Box is selected.

### CheckedChanged Event

* `CheckedChanged` is an event that occurs whenever the `Checked` property changes.
* It allows the program to respond immediately when a user selects or deselects a control.

## 10. Multiple-Alternative Decision Structures

### Switch Statement

* A Switch Statement selects an execution path based on the value of an expression.
* It is useful when a program needs to compare one expression against several possible values.

Important Switch keywords:

* `switch` — Evaluates the expression.
* `case` — Defines a possible matching value.
* `break` — Exits the Switch structure.
* `default` — Executes when no Case matches the expression.

**Important:** A Switch Statement is useful for fixed choices such as menu options, days of the week, and department codes.

## 11. List Box Controls

* A List Box is a Windows Forms control used to display a collection of items.
* The `Items` property manages the collection of items displayed in the List Box.

Important List Box properties and methods:

| Property / Method  | Purpose                                    |
| ------------------ | ------------------------------------------ |
| `Items`            | Accesses the collection of items.          |
| `Items.Count`      | Returns the total number of items.         |
| `SelectedItem`     | Retrieves the currently selected item.     |
| `SelectedIndex`    | Returns the position of the selected item. |
| `Items.Add()`      | Adds a new item.                           |
| `Items.Remove()`   | Removes a specified item.                  |
| `Items.RemoveAt()` | Removes an item using its index.           |
| `Items.Clear()`    | Removes all items.                         |

Additional concepts:

* List Box indexes start from zero.
* The first item has an index of `0`.
* `SelectedIndex` returns `-1` when no item is selected.
* `SelectedItem` retrieves the actual selected value, while `SelectedIndex` retrieves its position.

---

# Key Concepts for Revision

* **Decision Structure:** Controls program execution based on conditions.
* **Condition:** An expression that produces true or false.
* **Boolean:** A data type that stores true or false.
* **Flag:** A Boolean variable used to track a program state.
* **Relational Operators:** Compare two values.
* **Logical Operators:** Combine or reverse conditions.
* **Nested If:** An If statement inside another If statement.
* **String Comparison:** Checks whether text values are equal or different.
* **Data Conversion:** Changes a value from one data type to another.
* **TryParse():** Attempts conversion and indicates whether it succeeds.
* **Input Validation:** Checks whether entered data meets program requirements.
* **Radio Button:** Allows one selection within a group.
* **Check Box:** Allows independent selections.
* **Switch:** Selects an execution path based on matching values.
* **List Box:** Displays a collection of selectable items.
* **SelectedIndex:** Returns the position of the selected item.
* **Items.Count:** Returns the number of items in a List Box.

# Important Exam Traps

1. `=` and `==` are different operators.
2. AND (`&&`) requires both conditions to be true.
3. OR (`||`) requires only one condition to be true.
4. NOT (`!`) reverses a Boolean result.
5. If-Else-If evaluates conditions from top to bottom.
6. `Parse()` can produce an exception when input is invalid.
7. `TryParse()` returns true or false depending on conversion success.
8. Radio Buttons in the same group allow one selection, while Check Boxes allow multiple selections.
9. `CheckedChanged` occurs when the Checked property changes.
10. `String.Compare()` returns zero when strings are equal.
11. Switch uses `case` to identify matching values.
12. `break` exits a Switch statement.
13. List Box indexes start at zero, not one.
14. `SelectedIndex = -1` means no item is selected.
15. `Items.Count` returns the number of items, not the index of the last item.

*End of Chapter 3: Making Decisions.*
