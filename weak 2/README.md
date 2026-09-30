# C# Chapter 2 — Processing Data

## Topics:
  * 2.1 Reading Input with TextBox Controls
  * 2.2 A First Look at Variables
  * 2.3 Numeric Data Type and Variables
  * 2.4 Performing Calculations
  * 2.5 Inputting and Outputting Numeric Values
  * 2.6 Formatting Numbers with the ToString Method
  * 2.7 Simple Exception Handling
  * 2.8 Using Named Constants

### 2.1 Reading Input with TextBox Controls
* Understand TextBox controls.
* Read input entered by the user.
* Use the `.Text` property to retrieve input.
* Store user input in variables.

### 2.2 A First Look at Variables

* Understand what variables are.
* Declare and initialize variables.
* Assign values to variables.
* Understand variable names and data types.
* Change the value stored in a variable.
 
* Assignment Compatibility. 
* You can assign a value to a variable only if the value is compatible   with the variable’s data type.
* Only strings are compatible with the string data type

 
 
### 2.3 Numeric Data Types and Variables

Learn the main numeric data types:

* `int` — whole numbers
* `long` — large whole numbers
* `float` — decimal numbers
* `double` — decimal numbers with greater precision
* `decimal` — precise decimal values

Understand how data types determine what values a variable can store.

### 2.4 Performing Calculations

Learn how to perform calculations using:

* `+` Addition
* `-` Subtraction
* `*` Multiplication
* `/` Division
* `%` Modulus (remainder)

Also understand:

* Operator precedence
* Integer division
* Decimal division
* Mathematical expressions using variables

### 2.5 Inputting and Outputting Numeric Values

* Understand that TextBox input is received as a `string`.
* Convert strings into numeric values.
* Use methods such as:

  * `int.Parse()`
  * `double.Parse()`
  * `decimal.Parse()`
* Display numeric results using `ToString()`.

### 2.6 Formatting Numbers with the ToString Method

Learn how to format numeric values when displaying them.

Important examples:

* `ToString()`
* `ToString("C")` — currency
* `ToString("N2")` — number with two decimal places

Understand how formatting affects the way numbers are displayed.

### 2.7 Simple Exception Handling

Learn how to handle errors using:

* `try`
* `catch`

Understand how exception handling can prevent a program from terminating unexpectedly when invalid input or another error occurs.

### 2.8 Using Named Constants

* Understand what a constant is.
* Declare constants using `const`.
* Understand the difference between variables and constants.
* Know why named constants are useful.

Example:

```csharp
const double TAX_RATE = 0.15;
```

A constant's value cannot be changed after it is declared.

---

# Key Concepts

* **TextBox** — A control used to receive input from the user.
* **`.Text`** — Gets the text stored in a TextBox.
* **Variable** — A named storage location for a value.
* **Data Type** — Determines what type of value a variable can store.
* **`int`** — Stores whole numbers.
* **`double`** — Stores decimal numbers.
* **`Parse()`** — Converts a string into a numeric value.
* **`ToString()`** — Converts a value into text.
* **`try`** — Contains code that might cause an exception.
* **`catch`** — Handles an exception.
* **Constant** — A named value that cannot be changed.
* **`const`** — Keyword used to declare a constant.

---

# 

* `TextBox.Text` returns a **string**.
* A number typed into a TextBox is still received as a **string**.
* Numeric strings usually need to be converted before calculations.
* `int.Parse()` converts a string to an integer.
* `double.Parse()` converts a string to a double.
* `/` performs division.
* `%` returns the remainder.
* Integer division can produce an integer result.
* `ToString()` converts a value to text.
* `ToString("C")` formats a value as currency.
* `ToString("N2")` displays a number with two decimal places.
* Invalid numeric input can cause an exception.
* `try/catch` can be used to handle exceptions.
* A `const` value cannot be changed after declaration.
* Know the difference between declaring, initializing, and assigning a variable.


---