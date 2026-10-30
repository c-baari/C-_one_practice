##   C# File Handling


File handling is an important concept in C# programming. It allows applications to read, create, modify, and delete files stored on a computer.

## This assignment covers two main concepts:

1. Other File Reading Methods.
2. Deleting Files and Items Inside Files.

The practical examples for these concepts will be implemented using a Windows Forms Application in Visual Studio 2022.

⸻

## 1. Other File Reading Methods in C#

C# provides several methods for reading information from text files. Apart from Read(), ReadLine(), ReadToEnd(), and ReadAllText(), other methods include ReadAllLines() and ReadLines().

# 1.1 ReadAllLines()

ReadAllLines() reads all lines from a text file and stores them in an array of strings. Each line is stored as a separate element.

This method is useful when an application needs to access and process all lines in a file.

# 1.2 ReadLines()

ReadLines() provides the lines of a text file as a sequence. Unlike ReadAllLines(), it does not load all the lines into memory at once.

This method is useful when processing large text files because it allows the program to process the lines as they are requested.

# Difference Between ReadAllLines() and ReadLines()

ReadAllLines() loads all lines into an array, whereas ReadLines() provides the lines as a sequence. Both methods allow developers to process text files line by line.

⸻

## 2. Deleting Files and Items Inside Files

# 2.1 Deleting Files

Deleting a file means removing the entire file from its location on the computer.

In C#, the File.Delete() method is used to delete a file.

Before deleting a file, an application can use File.Exists() to check whether the file exists. This helps prevent unnecessary deletion attempts when the file is missing.

Deleting a file removes the file itself rather than just the information stored inside it.

# 2.2 Deleting Items Inside Files

Deleting items inside a file means removing specific information while keeping the file itself.

For example, a text file may contain a list of student names. If a particular student’s name needs to be removed, the application can read the file, identify the name, remove the matching entry, and save the remaining information.

C# does not provide a general File.DeleteItem() method for deleting an arbitrary line from a text file. Instead, developers can use methods such as File.ReadAllLines() and File.WriteAllLines() together with filtering operations to update the file.

This approach is useful when managing lists of students, employee records, or other text-based information.

# Difference Between Deleting Files and Deleting Items

Deleting a file removes the entire file from its location. Deleting an item removes selected information from the file while preserving the remaining contents.

⸻

⸻

# Conclusion

C# provides useful methods for reading and managing text files. ReadAllLines() and ReadLines() allow developers to read files line by line.

The File.Delete() method removes an entire file, while deleting a specific item requires reading the file, removing the selected information, and saving the updated contents.