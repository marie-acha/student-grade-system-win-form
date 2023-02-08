using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GradesDemo
{
    public partial class Form1 : Form
    {
        List<Student> StudentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeleteStudentBtn_Click(object sender, EventArgs e)
        {
            int labelIndex = StudentGrdList.SelectedIndex;
            if(labelIndex <= 0)
            {
                StatusLabel.Text = "Please select a student to delete";
            }else if(StudentList.Count > 0)
            {
                StatusLabel.Text = "Deleted record for student id: " + StudentList[labelIndex - 1].Id;
                StudentList.RemoveAt(labelIndex - 1);
                StudentGrdList.Items.RemoveAt(labelIndex);
            }
        }

        private void SaveGradeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter saveStudentGradeStream = new StreamWriter("Update_student-grade.csv"))
                {
                    string headerOutput = "student_id,first_name,last_name,quiz_score,midterm_score,final_score,total_grade,grade_letter";
                    saveStudentGradeStream.WriteLine(headerOutput);
                    foreach(Student student in StudentList)
                    {
                        string studentItem = student.Id + "," + student.FirstName + "," + student.LastName
                            + "," + student.Quiz + "," + student.Midterm + "," + student.Final + "," +
                            student.TotalCourseGrade + "," + student.GradeLetterString;
                        saveStudentGradeStream.WriteLine(studentItem);
                    }
                }
                StatusLabel.Text = "Saved " + StudentList.Count + " records into the output student grade file";
                StudentList.Clear();
                StudentGrdList.Items.Clear();

                SecondForm mySecondForm = new SecondForm();

                mySecondForm.OutputLabel.Text = "Thank you! \n " + StatusLabel.Text;
                mySecondForm.ShowDialog();

            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStudentGrdBtn_Click(object sender, EventArgs e)
        {
            StudentList.Clear();
            try
            {
                using (StreamReader loadStudentGradeStream = new StreamReader("student_grades.csv"))
                {
                    string eachGrade;
                    if (!loadStudentGradeStream.EndOfStream)
                    {
                        eachGrade = loadStudentGradeStream.ReadLine();
                        MessageBox.Show("Loading " + eachGrade);
                    }
                    while (!loadStudentGradeStream.EndOfStream)
                    {
                        eachGrade = loadStudentGradeStream.ReadLine();
                        string[] eachStudentFields = eachGrade.Split(',');
                        string studentId = eachStudentFields[0];
                        string firstName = eachStudentFields[1];
                        string lastName = eachStudentFields[2];
                        string quizStr = eachStudentFields[3];
                        string midtermStr = eachStudentFields[4];
                        string finalStr = eachStudentFields[5];
                        //parsing
                        int.TryParse(quizStr, out int quizScore);
                        int.TryParse(midtermStr, out int midtermScore);
                        int.TryParse(finalStr, out int finalScore);

                        Student eachStudenItem = new Student(studentId, firstName, lastName, quizScore, midtermScore, finalScore);
                        StudentList.Add (eachStudenItem);

                    }
                }
                LoadAllStudentToListBox();
                StatusLabel.Text = "Loaded " + StudentList.Count + " students from the input file";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAllStudentToListBox()
        {
            StudentGrdList.Items.Clear();
            StudentGrdList.Items.Add(string.Format("{0, -20}{1, -20}{2,-20}{3,-20}{4,-15}{5,-15}{6,-15}{7,-15}",
                "student_id", "first_name", "last_name", "quiz_score", "midterm_score", "final_score","total_grade","grade"));
            foreach(Student student in StudentList)
            {
                StudentGrdList.Items.Add(student);
            }
        }

        private void UpdateScoreBtn_Click(object sender, EventArgs e)
        {
            int labelIndex = StudentGrdList.SelectedIndex;
            if (labelIndex <= 0)
            {
                StatusLabel.Text = "Please select a student to update score";
            }else if(UpdateQuizTxtBox.Text == "")
            {
                StatusLabel.Text = "Quiz Score cannot be empty";
            }else if(UpdateMidtermTxtBx.Text == "")
            {
                StatusLabel.Text = "Midterm Score cannot be empty";
            }else if(UpdateFinalTxtBx.Text == "")
            {
                StatusLabel.Text = "Final Score cannot be empty";
            }else if(!int.TryParse(UpdateQuizTxtBox.Text, out int quiz) || quiz < 0 || quiz > 50)
            {
                StatusLabel.Text = "Quiz score must be whole number >= 0 and max score is 50";
            }else if(!int.TryParse(UpdateMidtermTxtBx.Text, out int midterm) || midterm < 0 || midterm > 50)
            {
                StatusLabel.Text = "Midterm score must be whole number >= 0 and max score is 50";
            }else if(!int.TryParse(UpdateFinalTxtBx.Text, out int final) || final < 0 || final > 100)
            {
                StatusLabel.Text = "Final score must be whole number >= 0 and max score is 100";
            }else if(StudentList.Count > 0)
            {
                StudentList[labelIndex - 1].Quiz = quiz;
                StudentList[labelIndex - 1].Midterm = midterm;
                StudentList[labelIndex - 1].Final = final;
                StudentGrdList.Items[labelIndex] = StudentList[labelIndex - 1];
                StatusLabel.Text = "Score for studentId " + StudentList[labelIndex - 1].Id + " has been updated";
                UpdateQuizTxtBox.Text = "";
                UpdateMidtermTxtBx.Text = "";
                UpdateFinalTxtBx.Text = "";
            }
        }

        private void StudentGrdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lblindex = StudentGrdList.SelectedIndex;
            if (lblindex > -1)
            {
                if (lblindex == 0)
                {
                    StatusLabel.Text = "You have selected the header line";
                    UpdateQuizTxtBox.Clear();
                    UpdateMidtermTxtBx.Clear();
                    UpdateFinalTxtBx.Clear();
                }else if(StudentList.Count > 0)
                {
                    UpdateQuizTxtBox.Text = StudentList[lblindex - 1].Quiz.ToString();
                    UpdateMidtermTxtBx.Text = StudentList[lblindex - 1].Midterm.ToString();
                    UpdateFinalTxtBx.Text = StudentList[lblindex - 1].Final.ToString();
                }
            }
        }
    }
}
