## Chapter 3: Making Decisions — Important Concepts

«This README contains concepts only. Code examples are intentionally excluded.»

# Decision Structures

• A decision structure controls the flow of program execution based on conditions.

• It allows a program to choose which statements should execute.

• A condition produces a Boolean result: true or false.

• Sequence Structure executes statements in order, while Decision Structure selects actions based on conditions.

# Conditional Statements

• An If statement executes statements when a condition is true.

• An If-Else statement provides two alternative execution paths.

• A Nested If places one decision structure inside another.

• An If-Else-If statement evaluates multiple conditions to determine the appropriate action.

# Relational Operators

• Relational operators compare two values and return a Boolean result.

• Greater than (>) checks whether one value is greater than another.

• Less than (<) checks whether one value is smaller than another.

• Greater than or equal (>=) checks whether a value is greater than or equal to another.

• Less than or equal (<=) checks whether a value is less than or equal to another.

• Equal to (==) checks whether two values are equal.

• Not equal (!=) checks whether two values are different.

# Logical Operators

• Logical operators combine or reverse Boolean conditions.

• AND (&&) returns true when both conditions are true.

• OR (||) returns true when at least one condition is true.

• NOT (!) reverses a Boolean value.

# Boolean Variables and Flags

• A Boolean variable stores only two possible values: true or false.

• A flag is a Boolean variable used to indicate whether a particular condition exists.

• Flags help control program execution and track specific program states.

# String Comparison

• String comparison checks whether two text values are equal or different.

• C# provides relational operators and the String.Compare() method for comparing strings.

• String comparison helps programs make decisions based on text input.

# Data Conversion and TryParse

• Data conversion changes a value from one data type to another.

• TextBox input is stored as a string, even when it contains numbers.

• TryParse() checks whether input can be successfully converted into a specified data type.

• Common methods include int.TryParse(), double.TryParse(), and decimal.TryParse().

• TryParse() helps prevent errors caused by invalid numeric input.

# Input Validation

• Input validation checks user input before it is used in a program.

• It ensures that entered values meet the required conditions.

• Data conversion checks whether input can be converted, while input validation checks whether the converted value is acceptable.

• Input validation helps improve the accuracy and reliability of applications.

# Windows Forms Selection Controls

• Radio Buttons allow users to select one option from a group of choices.

• Selecting one Radio Button automatically deselects another option in the same group.

• Check Boxes allow users to select multiple independent options.

• The Checked property indicates whether a Radio Button or Check Box is selected.

• The CheckedChanged event occurs whenever the Checked property changes.

# Multiple-Alternative Decision Structures

• A Switch Statement selects an execution path based on matching values.

• The Switch evaluates an expression.

• Case defines possible matching values.

• Break exits the Switch structure.

• Default handles values that do not match any Case.

# List Box Controls

• A List Box is a Windows Forms control used to display a collection of items.

• The Items property contains the collection of items.

• Items.Count returns the total number of items in the List Box.

• SelectedItem retrieves the currently selected item.

• SelectedIndex returns the position of the selected item.

• List Box indexes start from zero.

• A SelectedIndex value of -1 indicates that no item is selected.

• Items can be added, selected, removed, or cleared.

«All of these concepts are the topics covered in Chapter 3: Making Decisions in C#.»