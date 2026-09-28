# Discourse chapter 1
# Week 1 - C# String Concatenation Practice
## Topics
  1.1 Objects
  1.2 The Program Development Process
  1.8 Getting Started with Visual Studio
  2.1 Getting Started with Forms and Controls
  2.2 Creating the G U I for Your First Visual C# Application
  2.3 Introduction to C# code
  2.4 Writing Code for the Hello World Application
  2.5 Label Controls
  2.6 Making Sense of IntelliSense
  2.7 PictureBox Controls
  2.8 Comments, Blank Lines, and Indentation
  2.9 Writing the Code to Close an Application’s Form
  2.10 Dealing with Syntax Errors
  

## Overview

This practice demonstrates how to:

- Create string variables
- Combine two string values
- Store the combined value in another variable
- Display the result using a Label control

---

## 1. Creating Variables

In this step, three string variables are created to store the user's name information:

- `FirstName` - stores the first name
- `SecondName` - stores the second name
- `FullName` - stores the complete name after combining the first and second names.

The following screenshot shows how the variables are declared in C#.

![Creating Variables](Screenshots/Creating_Variables.png)

```csharp
string FirstName, SecondName, FullName;

```

---

## 2. Concatenating the First Name and Second Name

In this step, the first name and second name are combined using the `+` operator.

A space `" "` is added between the two names so that the final result is displayed correctly.

The result is stored in the `FullName` variable.

The following screenshot shows the string concatenation process.

---

## 3. Displaying the Full Name

After the first name and second name are combined, the value stored in `FullName` is displayed in a Label control.

The `.Text` property of the label is used to show the result on the Windows Form.

The following screenshot shows how the full name is displayed.

```

```