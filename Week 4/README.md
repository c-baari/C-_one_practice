## Chapter 4: Loops, Files, and Random Numbers — Important Concepts

< This README contains concepts only. Code examples are intentionally excluded.>

# The while Loop

* A while loop repeats a statement or group of statements as long as a Boolean expression is true.
* A Boolean expression is a condition that evaluates to either true or false.
* A while loop has two main parts: the condition and the loop body.
* The while clause contains the condition that determines whether the loop executes.
* The loop body contains the statements that are repeated.
* Each repetition of a loop is called an iteration.
* A counter variable is used to track how many times a loop runs.
* A while loop is a pretest loop because it tests the condition before executing the loop body.
* If the condition is false initially, the loop body will not execute.
* A variable should be initialized before the loop when its value is needed to control the loop.
* An infinite loop occurs when the loop condition never becomes false.
* Updating the counter variable correctly helps prevent infinite loops.

# Increment and Decrement Operators

* Incrementing a variable means increasing its value.
* Decrementing a variable means decreasing its value.
* The increment operator increases a variable by one.
* The decrement operator decreases a variable by one.
* The increment and decrement operators can be written before or after their operands.
* Postfix mode means the operator appears after the variable.
* Prefix mode means the operator appears before the variable.
* In postfix mode, the original value is used before the variable changes.
* In prefix mode, the variable changes before its value is used.
* The increment and decrement operators are commonly used in loops to update counter variables.

# The for Loop

* A for loop is designed for situations where a counter variable controls the number of iterations.
* A for loop has three main expressions: initialization, test, and update.
* Initialization establishes the initial value of the counter variable.
* The test expression is a Boolean condition that determines whether the loop continues.
* The update expression increases or decreases the counter variable.
* A for loop is a pretest loop because it checks its condition before executing the loop body.
* A for loop can count upward or downward.
* The counter can be increased or decreased by values other than one.
* The initialization, test, and update expressions work together to control the loop.

# The do-while Loop

* A do-while loop repeats a statement or group of statements while a Boolean expression is true.
* A do-while loop is a posttest loop because it checks the condition after executing the loop body.
* The statements inside the loop body execute before the condition is tested.
* A do-while loop executes its body at least once, even if the condition is initially false.
* The condition determines whether another iteration will occur.
* The do-while loop is useful when a task must be performed at least once.

# Using Files for Data Storage

* A program can store data in a file so that the data can be used later.
* Working with files generally involves three steps: opening the file, processing the file, and closing the file.
* Opening a file establishes a connection between the file and the program.
* Processing a file involves reading data from it or writing data to it.
* Closing a file disconnects the file from the program.
* There are two general types of files: text files and binary files.
* A text file stores data encoded as text.
* A binary file stores data in a format that is not directly readable as ordinary text.
* The chapter focuses on working with text files.
* A file object represents a specific file and provides a way for a program to work with it.

# Writing Data to a File

* StreamWriter is a class used to write data to a text file.
* The File class provides methods for creating or opening files for writing.
* File.CreateText creates a text file and returns a StreamWriter object.
* If a file already exists, File.CreateText erases its existing contents.
* File.AppendText opens a file for adding new data without erasing its existing contents.
* The Write method writes data without adding a new line.
* The WriteLine method writes data and then adds a new line.
* A file should be closed after writing is complete.
* A file path specifies the location of a file.
* A file path can include both the directory and the filename.

# Reading Data from a File

* StreamReader is a class used to read data from a text file.
* File.OpenText opens a text file for reading and returns a StreamReader object.
* The ReadLine method reads one line of text and returns it as a string.
* The Read method reads the next character or characters from the input stream.
* The ReadToEnd method reads the remaining content of a stream.
* File.ReadAllText reads the contents of a text file as a string.
* A file should be closed after reading is complete.
* The EndOfStream property indicates whether the end of a file has been reached.
* A loop can use EndOfStream to read a file until no more data remains.
* Reading a file line by line is useful when a file contains multiple records.

# OpenFileDialog and SaveFileDialog Controls

* OpenFileDialog and SaveFileDialog are Windows Forms controls used to display standard Windows file dialog boxes.
* OpenFileDialog displays a dialog box that allows the user to select a file to open.
* SaveFileDialog displays a Save As dialog box that allows the user to select where to save a file.
* These controls are invisible on the form at runtime and appear in the component tray in the Designer.
* The ShowDialog method displays the dialog box.
* The ShowDialog method returns a DialogResult value indicating the user’s choice.
* DialogResult.OK indicates that the user confirmed the selection.
* DialogResult.Cancel indicates that the user canceled the operation.
* The FileName property provides the selected file’s path and filename.
* The InitialDirectory property specifies the directory displayed initially in the dialog box.
* These controls allow users to choose files and locations instead of requiring fixed file paths.

# Random Numbers

* The Random class in .NET is used to generate random numbers.
* A Random object can generate random integers and floating-point numbers.
* The Next method generates a random integer.
* The Next method can also generate an integer within a specified range.
* The upper limit supplied to Next is exclusive, meaning it is not included in the generated values.
* The NextDouble method generates a floating-point number greater than or equal to 0.0 and less than 1.0.
* Random numbers can be useful in simulations, games, and other applications that require varying values.

# The Load Event

* The Load event occurs when a Windows Form is loaded into memory as the application starts displaying the form.
* A Load event handler contains statements that execute when the form loads.
* The Load event handler can be created by double-clicking the form in the Windows Forms Designer.
* Code placed inside the Load event handler executes when the form is launched.
* The Load event is useful for performing initialization tasks before the user begins interacting with the form.

< All the concepts listed above are the concepts we covered in this chapter.>