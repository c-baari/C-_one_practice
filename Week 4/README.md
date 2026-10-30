# Chapter 4: Loops, Files, and Random Numbers

*This README contains important concepts, explanations, and exam notes. C# code examples are provided separately.*

## 1. The While Loop

* A While Loop repeats a statement or group of statements as long as its Boolean condition remains true.
* A Boolean expression is a condition that evaluates to either `true` or `false`.
* A While Loop has two main parts:

  * **Condition:** Determines whether the loop should continue executing.
  * **Loop Body:** Contains the statements that are repeated.
* Each repetition of a loop is called an iteration.
* A counter variable tracks how many times a loop executes.
* A While Loop is a **pretest loop** because it checks its condition before executing the loop body.
* If the condition is initially false, the loop body will not execute.
* A counter variable should be initialized before the loop when it controls the loop's execution.
* An infinite loop occurs when the condition never becomes false.
* Updating the counter correctly helps prevent infinite loops.

## 2. Increment and Decrement Operators

* Incrementing increases a variable's value by one.
* Decrementing decreases a variable's value by one.

Important operators:

| Operator | Meaning                    |
| -------- | -------------------------- |
| `++`     | Increases a variable by 1. |
| `--`     | Decreases a variable by 1. |

There are two ways to use these operators:

**Prefix Mode**

* The operator appears before the variable.
* The variable changes before its value is used.

**Postfix Mode**

* The operator appears after the variable.
* The original value is used before the variable changes.

Examples of notation:

* `++number` — Prefix increment.
* `number++` — Postfix increment.
* `--number` — Prefix decrement.
* `number--` — Postfix decrement.

**Important:** Both prefix and postfix change the variable by one. Their difference matters when the expression's value is used in another operation.

## 3. The For Loop

* A For Loop repeats statements using a counter variable.
* It is useful when the number of iterations is known or controlled by a counting condition.
* A For Loop contains three main expressions:

1. **Initialization:** Establishes the initial value of the counter.
2. **Test:** Checks whether the loop should continue.
3. **Update:** Changes the counter after each iteration.

* A For Loop is a **pretest loop** because it checks its condition before executing the loop body.
* The loop can count upward or downward.
* The counter can increase or decrease by values other than one.
* Initialization, test, and update work together to control the loop.

**Important:** A For Loop can execute zero times if its initial condition is false.

## 4. The Do-While Loop

* A Do-While Loop repeats statements while its Boolean condition remains true.
* It is a **posttest loop** because the condition is checked after the loop body executes.
* The statements inside the loop execute before the condition is evaluated.
* A Do-While Loop always executes its body at least once, even when the initial condition is false.
* It is useful when an operation must happen at least once before checking whether it should repeat.

**Important difference:**

* While Loop: Checks the condition first.
* For Loop: Checks the condition first.
* Do-While Loop: Checks the condition after execution.

## 5. Using Files for Data Storage

* File handling allows a program to store information permanently so it can be accessed later.
* Unlike ordinary variables, file data can remain available after the program closes.
* Working with files generally involves three steps:

1. **Opening:** Establishes a connection between the program and the file.
2. **Processing:** Reads information from the file or writes information into it.
3. **Closing:** Releases the file resource after processing.

### Types of Files

* **Text File:** Stores information as readable text.

* **Binary File:** Stores information in binary form, which is not normally readable as ordinary text.

* This chapter focuses mainly on text file operations.

* A file object provides access to a specific file and allows a program to perform file operations.

## 6. Writing Data to a File

* `StreamWriter` is a .NET class used to write text into files.
* The `File` class provides methods for creating and opening files.
* `File.CreateText()` creates a text file and returns a StreamWriter object.
* If the file already exists, `File.CreateText()` replaces its existing contents.
* `File.AppendText()` opens a file for adding new content without deleting existing information.

### Important Writing Methods

| Method        | Purpose                                                    |
| ------------- | ---------------------------------------------------------- |
| `Write()`     | Writes content without automatically moving to a new line. |
| `WriteLine()` | Writes content and moves to the next line.                 |
| `Close()`     | Closes the StreamWriter.                                   |

Additional concepts:

* A file path identifies the location of a file.
* A file path can contain a directory and filename.
* Closing a file helps ensure that written data is properly saved and resources are released.
* `using` statements can automatically close file resources when the operation finishes.

**Important difference:**

* `CreateText()` creates or replaces a file.
* `AppendText()` adds content to an existing file without replacing its previous contents.

## 7. Reading Data from a File

* `StreamReader` is a .NET class used to read text from files.
* `File.OpenText()` opens a text file for reading and returns a StreamReader object.

### Important Reading Methods and Properties

| Method / Property | Purpose                                                                |
| ----------------- | ---------------------------------------------------------------------- |
| `ReadLine()`      | Reads one line and returns it as a string.                             |
| `Read()`          | Reads the next character and returns its character code as an integer. |
| `ReadToEnd()`     | Reads all remaining content from the stream.                           |
| `EndOfStream`     | Indicates whether the end of the file has been reached.                |
| `Close()`         | Closes the StreamReader.                                               |

Additional concepts:

* A loop can use `EndOfStream` to continue reading until no more content remains.
* Reading line by line is useful when a file contains multiple records.
* `File.ReadAllText()` reads the entire contents of a text file and returns them as a string.
* A file should be closed after reading is complete.
* `using` statements can automatically release the StreamReader resource.

## 8. OpenFileDialog and SaveFileDialog Controls

* These are Windows Forms controls that display standard Windows file selection dialog boxes.
* They allow users to choose files and locations instead of requiring the programmer to specify fixed paths.
* Both controls are invisible at runtime and appear in the component tray in the Windows Forms Designer.

### OpenFileDialog

* Displays a dialog box that allows users to select an existing file to open.
* The selected file's path is available through the `FileName` property.

### SaveFileDialog

* Displays a Save As dialog box that allows users to choose where to save a file.
* The selected destination path is available through the `FileName` property.

### Important Properties and Methods

| Property / Method  | Purpose                                            |
| ------------------ | -------------------------------------------------- |
| `ShowDialog()`     | Displays the dialog box.                           |
| `FileName`         | Returns the selected file path and filename.       |
| `InitialDirectory` | Specifies the directory displayed initially.       |
| `Filter`           | Limits the file types displayed in the dialog box. |

### DialogResult Values

* `DialogResult.OK` indicates that the user confirmed the selection.
* `DialogResult.Cancel` indicates that the user canceled the operation.

**Important:** Selecting a file through OpenFileDialog does not automatically read its contents. The program must still perform the reading operation.

Similarly, SaveFileDialog selects a destination but does not automatically write data into the file.

## 9. Random Numbers

* The `Random` class in .NET generates pseudorandom numbers.
* A Random object can generate random integers and floating-point numbers.
* Random numbers are useful in games, simulations, and applications that require varying values.

### Important Methods

**Next()**

* Generates a nonnegative random integer.
* It can generate an integer within a specified range.
* The upper limit is exclusive, meaning it is not included.

**NextDouble()**

* Generates a floating-point number greater than or equal to `0.0` and less than `1.0`.
* Its possible range is `[0.0, 1.0)`.

**Important:** To generate a random integer from 1 to 10, the upper limit must be 11 because the upper limit is exclusive.

## 10. The Load Event

* The Load event occurs when a Windows Form is loaded and is preparing to be displayed.
* A Load event handler contains statements that execute during the form's loading process.
* It can be created by double-clicking the form in the Windows Forms Designer.
* Code inside the Load event handler executes when the form loads.
* It is useful for initialization tasks before the user begins interacting with the application.

Common initialization tasks include:

* Setting default values.
* Loading information from files.
* Adding initial items to controls.
* Preparing variables.
* Setting the initial state of the form.

---

# Key Concepts for Revision

* **While Loop:** Repeats statements while a condition is true.
* **For Loop:** Repeats statements using initialization, test, and update expressions.
* **Do-While Loop:** Executes the loop body at least once before checking the condition.
* **Iteration:** One complete execution of a loop body.
* **Counter:** A variable used to track loop repetitions.
* **Infinite Loop:** A loop that never terminates because its condition remains true.
* **Increment:** Increases a variable by one.
* **Decrement:** Decreases a variable by one.
* **Prefix:** Changes a variable before its value is used.
* **Postfix:** Uses the original value before changing the variable.
* **StreamWriter:** Writes text into a file.
* **StreamReader:** Reads text from a file.
* **CreateText():** Creates or replaces a text file.
* **AppendText():** Adds new content without replacing existing content.
* **Write():** Writes without automatically adding a new line.
* **WriteLine():** Writes and moves to a new line.
* **ReadLine():** Reads one line from a file.
* **Read():** Reads the next character.
* **ReadToEnd():** Reads all remaining content.
* **EndOfStream:** Indicates whether the end of a file has been reached.
* **OpenFileDialog:** Allows users to select an existing file.
* **SaveFileDialog:** Allows users to select a file-saving location.
* **Random:** A class used to generate pseudorandom numbers.
* **Next():** Generates a random integer.
* **NextDouble():** Generates a random floating-point number between 0.0 and 1.0, excluding 1.0.
* **Load Event:** Executes initialization code when a form loads.

# Important Exam Traps

1. While and For are pretest loops.
2. Do-While is a posttest loop.
3. A Do-While Loop executes at least once.
4. A While Loop may execute zero times.
5. An infinite loop occurs when its condition never becomes false.
6. `++` increases a variable by one.
7. `--` decreases a variable by one.
8. Prefix changes the variable before its value is used.
9. Postfix uses the original value before changing the variable.
10. `File.CreateText()` replaces existing file contents.
11. `File.AppendText()` preserves existing contents and adds new information.
12. `Write()` does not automatically add a new line.
13. `WriteLine()` automatically moves to a new line.
14. `StreamWriter` writes data, while `StreamReader` reads data.
15. `ReadLine()` reads one line, while `ReadToEnd()` reads all remaining content.
16. `EndOfStream` helps determine when file reading should stop.
17. `DialogResult.OK` means the user confirmed the selection.
18. `DialogResult.Cancel` means the user canceled the operation.
19. `FileName` returns the selected path and filename.
20. OpenFileDialog selects a file but does not automatically read it.
21. SaveFileDialog selects a destination but does not automatically save data.
22. `Random.Next()` excludes its specified upper limit.
23. `Random.NextDouble()` returns values from 0.0 up to, but not including, 1.0.
24. The Load event is useful for initializing a Windows Form.

*End of Chapter 4: Loops, Files, and Random Numbers.*
