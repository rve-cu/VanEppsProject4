using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanEppsProject4
{
    public partial class frmCourses : Form
    {
        private CourseLogic courseLogic;

        public frmCourses()
        {
            InitializeComponent();

            // initialize CourseLogic field -- this handles validation and interaction with CourseProcessing class
            this.courseLogic = new CourseLogic();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // add inputs to sorted list of strings => controls
            SortedList<string, Control> courseInputs = new SortedList<string, Control> {
                ["load"] = txtLoad,
                ["name"] = txtName,
                ["date"] = calDate,
                ["course"] = cbxCourse,
                ["type"] = gbxType
            };

            bool isValid = false;

            // iterate through controls and validate input
            foreach (KeyValuePair<string, Control> courseInput in courseInputs)
            {
                // validate input
                isValid = this.courseLogic.ValidateInput(courseInput.Value, courseInput.Key);

                // if input not valid
                if (! isValid)
                {
                    courseInput.Value.Focus(); // return focus to control
                    MessageBox.Show(this.courseLogic.GetErrors()); // display message box with list of errors
                    return;
                }
            }

            if (isValid)
            {
                string changes = this.courseLogic.AddCourse(courseInputs);
                if (changes.Length > 0)
                {
                    MessageBox.Show(changes);
                }
            }
        }

        private void btnDisplayCourse_Click(object sender, EventArgs e)
        {
            // add outputs to sorted list of strings => controls
            SortedList<string, Control> courseOutputs = new SortedList<string, Control>
            {
                ["load"] = txtDisplayLoad,
                ["name"] = txtDisplayName,
                ["date"] = txtDisplayDate,
                ["course"] = txtDisplayCourse,
                ["type"] = txtDisplayType
            };

            this.courseLogic.DisplayCourse(courseOutputs);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // exit application
            Application.Exit();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coursesDataSet._2019Spring' table. You can move, or remove it, as needed.
            this._2019SpringTableAdapter.Fill(this.coursesDataSet._2019Spring);

        }
    }
}
