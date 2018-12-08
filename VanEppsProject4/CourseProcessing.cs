using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanEppsProject4
{
    class CourseProcessing
    {
        private List<string> changeList = new List<string> { }; // changed values
        private int courseLoad;
        private string studentName;
        private string courseStart;
        private string courseNumber;
        private string courseType;
        private bool saved; // determines whether values have been saved at least once

        public bool IsSaved()
        {
            return this.saved;
        }

        public List<string> GetChanges()
        {
            // update saved property upon first save
            // upon further saves, previous values for properties will be passed through
            if (! IsSaved())
            {
                this.saved = true;
            }

            return changeList;
        }

        public void ResetChanges()
        {
            this.changeList = new List<string> { };
        }

        public int CourseLoad
        {
            get
            {
                return courseLoad;
            }
            set
            {
                if (courseLoad != value)
                {
                    // only populate "from" value if property previously saved
                    string from = "";
                    if (this.saved)
                    {
                        from = " from " + courseLoad;
                    }

                    // Notify that value has changed, update property
                    this.changeList.Add("Course load changed" + from + " to " + value + ".");
                    courseLoad = value;
                }
            }
        }

        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                if (studentName != value)
                {
                    // only populate "from" value if property previously saved
                    string from = "";
                    if (this.saved)
                    {
                        from = " from \"" + studentName + "\"";
                    }

                    // Notify that value has changed, update property
                    this.changeList.Add("Student name changed" + from + " to \"" + value + "\".");
                    studentName = value;
                }
            }
        }

        public string CourseStart
        {
            get
            {
                return courseStart;
            }
            set
            {
                if (courseStart != value)
                {
                    // only populate "from" value if property previously saved
                    string from = "";
                    if (this.saved)
                    {
                        from = " from " + courseStart;
                    }

                    // Notify that value has changed, update property
                    this.changeList.Add("Course start changed" + from + " to " + value + ".");
                    courseStart = value;
                }
            }
        }

        public string CourseNumber
        {
            get
            {
                return courseNumber;
            }
            set
            {
                if (courseNumber != value)
                {
                    // only populate "from" value if property previously saved
                    string from = "";
                    if (this.saved)
                    {
                        from = " from " + courseNumber;
                    }

                    // Notify that value has changed, update property
                    this.changeList.Add("Course changed" + from + " to " + value + ".");
                    courseNumber = value;
                }
            }
        }

        public string CourseType
        {
            get
            {
                return courseType;
            }
            set
            {
                if (courseType != value)
                {
                    // only populate "from" value if property previously saved
                    string from = "";
                    if (this.saved)
                    {
                        from = " from " + courseType;
                    }

                    // Notify that value has changed, update property
                    this.changeList.Add("Course type changed" + from + " to " + value + ".");
                    courseType = value;
                }
            }
        }
    }
}
