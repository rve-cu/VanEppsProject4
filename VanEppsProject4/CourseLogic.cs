using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanEppsProject4
{
    class CourseLogic
    {
        private List<string> errorList; // validation errors
        private CourseProcessing courseProcessing;

        public CourseLogic()
        {
            this.courseProcessing = new CourseProcessing();
        }

        private string GetMessages(List<string> messageList)
        {
            // loop through message list and return formatted string
            // e.g., CourseLogic.errorList, CourseProcessing.changeList

            string messages = "";

            int count = messageList.Count;

            // ensure list has elements, otherwise return empty string
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    messages += messageList[i];

                    if (i < (count - 1))
                    {
                        messages += "\r\n";
                    }
                }
            }

            return messages;
        }

        public string GetErrors()
        {
            return this.GetMessages(this.errorList);
        }

        public bool ValidateInput(Control input, string inputKey)
        {
            // initialize errorList to empty list
            this.errorList = new List<string>();

            // get type of input control
            string type = input.GetType().Name;
            
            switch (type)
            {
                case "TextBox":
                    // ensure text has been entered in textbox
                    bool isPresent = this.IsPresent(input, type);
                    
                    if (inputKey == "load")
                    {
                        // ensure course load is an unsigned integer
                        return isPresent && this.IsUnsignedInteger(input);
                    }
                    else if (inputKey == "name")
                    {
                        // ensure student name is valid (alphabetic and at least one space to indicate first and last name)
                        return isPresent && this.IsAlphabetic(input) && this.IsFullName(input);
                    }
                    
                    return isPresent;

                case "MonthCalendar":
                    // ensure calendar has valid date selected
                    MonthCalendar calendar = (MonthCalendar)input;
                    long min = new DateTime(2019, 1, 1).Ticks;
                    long max = new DateTime(2019, 1, 31).Ticks;
                    bool isWithinRange = this.IsWithinRange(calendar.SelectionStart.Ticks, type, min, max);
                    
                    if (! isWithinRange)
                    {
                        // add error
                        this.errorList.Add(input.Tag.ToString() + " must be between January 1st and 31st, 2019.");
                    }

                    return isWithinRange;

                case "ComboBox":
                    // options pulled from db, validation not required
                    return true;

                case "GroupBox":
                    bool isChecked = IsChecked(input);
                    if (! isChecked)
                    {
                        // add error
                        this.errorList.Add(input.Tag.ToString() + " must be entered. Please select either \"Hybrid\" or \"Online\".");
                    }
                    return isChecked;
            }

            return true;
        }

        private bool IsPresent(Control input, string type)
        {
            // Ensure input has been entered into control
            if (type == "TextBox" && input.Text.Trim() == "")
            {
                // add error if textbox contains empty string
                this.errorList.Add(input.Tag.ToString() + " is required.");
                return false;
            }
            return true;
        }

        private bool IsAlphabetic(Control input)
        {
            // check input against regex, checking for letters and spaces
            Regex regex = new Regex(@"(?i)^[a-z\s]+$");

            if (!regex.IsMatch(input.Text))
            {
                // add error if input contains non-alphabetic or space characters
                this.errorList.Add(input.Tag.ToString() + " must be a valid alphabetic string. Please enter only letters and spaces.");
                return false;
            }
            return true;
        }

        private bool IsFullName(Control input)
        {
            if (input.Text.Trim().IndexOf(" ") == -1)
            {
                // add error if input does not contain space separating first and last names
                this.errorList.Add(input.Tag.ToString() + " must be a full name. Please enter first and last name, separated by a space.");
                return false;
            }
            return true;
        }

        private bool IsUnsignedInteger(Control input)
        {
            int number = 0;

            if (! Int32.TryParse(input.Text, out number) || number < 0)
            {
                // add error if input is not an unsigned integer
                this.errorList.Add(input.Tag.ToString() + " must be a positive integer or zero. Please enter a whole number greater than or equal to zero.");
                return false;
            }
            return true;
        }

        private bool IsWithinRange(long value, string type, long min, long max)
        {
            // determine if input value is within range
            return (value >= min && value <= max);
        }

        private bool IsChecked(Control input)
        {
            foreach (RadioButton rdo in input.Controls)
            {
                if (rdo.Checked)
                {
                    return true;
                }
            }
            // return false if no radio buttons within group box are checked
            return false;
        }

        public string AddCourse(SortedList<string, Control> courseInputs)
        {
            // reset changeList
            this.courseProcessing.ResetChanges();

            // save course data to CourseProcessing class properties

            // convert course load input to int, save to courseLoad property
            this.courseProcessing.CourseLoad = Int32.Parse(courseInputs["load"].Text.Trim());

            // save student name input to studentName property
            this.courseProcessing.StudentName = courseInputs["name"].Text.Trim();

            // save start date input to courseStart property
            this.courseProcessing.CourseStart = String.Format(
                "{0:MMM d (ddd)}",
                ((MonthCalendar)courseInputs["date"]).SelectionStart
            );

            // save course number input to courseNumber property
            this.courseProcessing.CourseNumber = ((ComboBox)courseInputs["course"]).Text;

            // get course type from checked radio button
            string courseType = "";
            foreach (RadioButton rdo in courseInputs["type"].Controls)
            {
                if (rdo.Checked)
                {
                    courseType = rdo.Text;
                    break;
                }
            }
            // save course type input to courseType property
            this.courseProcessing.CourseType = courseType;

            // return any messages related to property updates
            return this.GetMessages(this.courseProcessing.GetChanges());
        }

        public void DisplayCourse(SortedList<string, Control> courseOutputs)
        {
            // return error message if no course data has been saved yet
            if (! this.courseProcessing.IsSaved())
            {
                MessageBox.Show("No course data to display. Please enter course data under \"Add Course\" then click \"Save\".");
                return;
            }

            // get course load value from courseLoad property
            courseOutputs["load"].Text = this.courseProcessing.CourseLoad.ToString();

            // get student name value from studentName property
            courseOutputs["name"].Text = this.courseProcessing.StudentName;

            // get start date value from courseStart property
            courseOutputs["date"].Text = this.courseProcessing.CourseStart;

            // get course number value from courseNumber property
            courseOutputs["course"].Text = this.courseProcessing.CourseNumber;

            // get course type value from courseType property
            courseOutputs["type"].Text = this.courseProcessing.CourseType;
        }
    }
}
