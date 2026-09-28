## Screenshot one
# C# Student Information Form

This program collects student information from TextBoxes and displays it in a Label. It also provides a **Clear** button to reset all fields.

```csharp
private void btnshow_Click(object sender, EventArgs e)
{
    String fname, department;
    int id, semester;

    fname = txtname.Text;
    department = txtdept.Text;
    id = int.Parse(txtid.Text);
    semester = int.Parse(txtsemester.Text);

    lbloutput.Text = "Name: " + fname +
                     " Department: " + department +
                     " ID: " + id +
                     " Semester: " + semester;
}

private void btnclear_Click(object sender, EventArgs e)
{
    txtname.Clear();
    txtdept.Clear();
    txtid.Clear();
    txtsemester.Clear();
    lbloutput.Text = "";
}
```

### How It Works

**Show Button (`btnshow_Click`)**

* Gets name and department from TextBoxes.
* Converts ID and semester from text to integers.
* Displays all information in `lbloutput`.

**Clear Button (`btnclear_Click`)**

* `.Clear()` removes text from each TextBox.
* `lbloutput.Text = ""` clears the output Label.

### Example Output

```text
Name: Ali Department: IT ID: 101 Semester: 2
```

## Screenshot one
# C# Date Display Form

This program collects date information, displays the complete date, clears the fields, and closes the form.

```csharp
private void btnshowoutput_Click(object sender, EventArgs e)
{
    String day_of_the_week = txtdayoftheweek.Text;
    String name_of_the_month = txtdayofthemonth.Text;
    String day_of_the_month = txtmonth.Text;
    int year = int.Parse(txtyear.Text);

    String full_date = day_of_the_week + " " +
                       name_of_the_month + " " +
                       day_of_the_month + " " + year;

    lbloutput.Text = full_date;
}
```

### Buttons

* **Show Output** → Reads the date values and displays the full date in `lbloutput`.
* **Clear** → Clears all TextBoxes and the output Label.
* **Close** → `this.Close()` closes the Windows Form.

### Key Concepts

* `.Text` → Gets the value from a TextBox.
* `int.Parse()` → Converts text to an integer.
* `+` → Joins strings together.
* `.Clear()` → Removes TextBox content.
* `this.Close()` → Closes the current form.

### Example Output

```text
Monday September 28 2026
```
