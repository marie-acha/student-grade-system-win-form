namespace GradesDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.StudentGrdList = new System.Windows.Forms.ListBox();
            this.LoadStudentGrdBtn = new System.Windows.Forms.Button();
            this.UpdateScoreBtn = new System.Windows.Forms.Button();
            this.LoadAndDeleteGrpBx = new System.Windows.Forms.GroupBox();
            this.DeleteStudentBtn = new System.Windows.Forms.Button();
            this.UpdateDataGrpBx = new System.Windows.Forms.GroupBox();
            this.UpdateFinalTxtBx = new System.Windows.Forms.TextBox();
            this.UpdateMidtermTxtBx = new System.Windows.Forms.TextBox();
            this.UpdateQuizTxtBox = new System.Windows.Forms.TextBox();
            this.FinalLabel = new System.Windows.Forms.Label();
            this.MidtermLabel = new System.Windows.Forms.Label();
            this.QuizScoreLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SaveGradeGrpBx = new System.Windows.Forms.GroupBox();
            this.SaveGradeBtn = new System.Windows.Forms.Button();
            this.LoadAndDeleteGrpBx.SuspendLayout();
            this.UpdateDataGrpBx.SuspendLayout();
            this.SaveGradeGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(595, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(190, 22);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Student Grade Book";
            // 
            // StudentGrdList
            // 
            this.StudentGrdList.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGrdList.FormattingEnabled = true;
            this.StudentGrdList.ItemHeight = 18;
            this.StudentGrdList.Location = new System.Drawing.Point(23, 54);
            this.StudentGrdList.Name = "StudentGrdList";
            this.StudentGrdList.Size = new System.Drawing.Size(1269, 148);
            this.StudentGrdList.TabIndex = 1;
            this.StudentGrdList.SelectedIndexChanged += new System.EventHandler(this.StudentGrdList_SelectedIndexChanged);
            // 
            // LoadStudentGrdBtn
            // 
            this.LoadStudentGrdBtn.Location = new System.Drawing.Point(71, 31);
            this.LoadStudentGrdBtn.Name = "LoadStudentGrdBtn";
            this.LoadStudentGrdBtn.Size = new System.Drawing.Size(148, 40);
            this.LoadStudentGrdBtn.TabIndex = 2;
            this.LoadStudentGrdBtn.Text = "Load Student Grade";
            this.LoadStudentGrdBtn.UseVisualStyleBackColor = true;
            this.LoadStudentGrdBtn.Click += new System.EventHandler(this.LoadStudentGrdBtn_Click);
            // 
            // UpdateScoreBtn
            // 
            this.UpdateScoreBtn.Location = new System.Drawing.Point(322, 53);
            this.UpdateScoreBtn.Name = "UpdateScoreBtn";
            this.UpdateScoreBtn.Size = new System.Drawing.Size(124, 50);
            this.UpdateScoreBtn.TabIndex = 3;
            this.UpdateScoreBtn.Text = "Update Score";
            this.UpdateScoreBtn.UseVisualStyleBackColor = true;
            this.UpdateScoreBtn.Click += new System.EventHandler(this.UpdateScoreBtn_Click);
            // 
            // LoadAndDeleteGrpBx
            // 
            this.LoadAndDeleteGrpBx.Controls.Add(this.DeleteStudentBtn);
            this.LoadAndDeleteGrpBx.Controls.Add(this.LoadStudentGrdBtn);
            this.LoadAndDeleteGrpBx.Location = new System.Drawing.Point(82, 222);
            this.LoadAndDeleteGrpBx.Name = "LoadAndDeleteGrpBx";
            this.LoadAndDeleteGrpBx.Size = new System.Drawing.Size(278, 149);
            this.LoadAndDeleteGrpBx.TabIndex = 4;
            this.LoadAndDeleteGrpBx.TabStop = false;
            this.LoadAndDeleteGrpBx.Text = "Load and Delete";
            // 
            // DeleteStudentBtn
            // 
            this.DeleteStudentBtn.Location = new System.Drawing.Point(71, 77);
            this.DeleteStudentBtn.Name = "DeleteStudentBtn";
            this.DeleteStudentBtn.Size = new System.Drawing.Size(148, 49);
            this.DeleteStudentBtn.TabIndex = 3;
            this.DeleteStudentBtn.Text = "Delete Selected Student";
            this.DeleteStudentBtn.UseVisualStyleBackColor = true;
            this.DeleteStudentBtn.Click += new System.EventHandler(this.DeleteStudentBtn_Click);
            // 
            // UpdateDataGrpBx
            // 
            this.UpdateDataGrpBx.Controls.Add(this.UpdateFinalTxtBx);
            this.UpdateDataGrpBx.Controls.Add(this.UpdateMidtermTxtBx);
            this.UpdateDataGrpBx.Controls.Add(this.UpdateQuizTxtBox);
            this.UpdateDataGrpBx.Controls.Add(this.FinalLabel);
            this.UpdateDataGrpBx.Controls.Add(this.MidtermLabel);
            this.UpdateDataGrpBx.Controls.Add(this.QuizScoreLabel);
            this.UpdateDataGrpBx.Controls.Add(this.UpdateScoreBtn);
            this.UpdateDataGrpBx.Location = new System.Drawing.Point(379, 222);
            this.UpdateDataGrpBx.Name = "UpdateDataGrpBx";
            this.UpdateDataGrpBx.Size = new System.Drawing.Size(480, 149);
            this.UpdateDataGrpBx.TabIndex = 5;
            this.UpdateDataGrpBx.TabStop = false;
            this.UpdateDataGrpBx.Text = "Update Student Grade";
            // 
            // UpdateFinalTxtBx
            // 
            this.UpdateFinalTxtBx.Location = new System.Drawing.Point(194, 100);
            this.UpdateFinalTxtBx.Name = "UpdateFinalTxtBx";
            this.UpdateFinalTxtBx.Size = new System.Drawing.Size(76, 22);
            this.UpdateFinalTxtBx.TabIndex = 9;
            // 
            // UpdateMidtermTxtBx
            // 
            this.UpdateMidtermTxtBx.Location = new System.Drawing.Point(194, 64);
            this.UpdateMidtermTxtBx.Name = "UpdateMidtermTxtBx";
            this.UpdateMidtermTxtBx.Size = new System.Drawing.Size(76, 22);
            this.UpdateMidtermTxtBx.TabIndex = 8;
            // 
            // UpdateQuizTxtBox
            // 
            this.UpdateQuizTxtBox.Location = new System.Drawing.Point(194, 31);
            this.UpdateQuizTxtBox.Name = "UpdateQuizTxtBox";
            this.UpdateQuizTxtBox.Size = new System.Drawing.Size(76, 22);
            this.UpdateQuizTxtBox.TabIndex = 7;
            // 
            // FinalLabel
            // 
            this.FinalLabel.AutoSize = true;
            this.FinalLabel.Location = new System.Drawing.Point(28, 106);
            this.FinalLabel.Name = "FinalLabel";
            this.FinalLabel.Size = new System.Drawing.Size(115, 16);
            this.FinalLabel.TabIndex = 6;
            this.FinalLabel.Text = "Final Exam Score:";
            // 
            // MidtermLabel
            // 
            this.MidtermLabel.AutoSize = true;
            this.MidtermLabel.Location = new System.Drawing.Point(28, 70);
            this.MidtermLabel.Name = "MidtermLabel";
            this.MidtermLabel.Size = new System.Drawing.Size(134, 16);
            this.MidtermLabel.TabIndex = 5;
            this.MidtermLabel.Text = "Midterm Exam Score:";
            // 
            // QuizScoreLabel
            // 
            this.QuizScoreLabel.AutoSize = true;
            this.QuizScoreLabel.Location = new System.Drawing.Point(28, 31);
            this.QuizScoreLabel.Name = "QuizScoreLabel";
            this.QuizScoreLabel.Size = new System.Drawing.Size(75, 16);
            this.QuizScoreLabel.TabIndex = 4;
            this.QuizScoreLabel.Text = "Quiz Score:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusLabel.Location = new System.Drawing.Point(440, 390);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(360, 76);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status to be updated here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveGradeGrpBx
            // 
            this.SaveGradeGrpBx.Controls.Add(this.SaveGradeBtn);
            this.SaveGradeGrpBx.Location = new System.Drawing.Point(888, 222);
            this.SaveGradeGrpBx.Name = "SaveGradeGrpBx";
            this.SaveGradeGrpBx.Size = new System.Drawing.Size(249, 149);
            this.SaveGradeGrpBx.TabIndex = 7;
            this.SaveGradeGrpBx.TabStop = false;
            this.SaveGradeGrpBx.Text = "Import Grade";
            // 
            // SaveGradeBtn
            // 
            this.SaveGradeBtn.Location = new System.Drawing.Point(44, 50);
            this.SaveGradeBtn.Name = "SaveGradeBtn";
            this.SaveGradeBtn.Size = new System.Drawing.Size(169, 53);
            this.SaveGradeBtn.TabIndex = 0;
            this.SaveGradeBtn.Text = "Save Grade to File";
            this.SaveGradeBtn.UseVisualStyleBackColor = true;
            this.SaveGradeBtn.Click += new System.EventHandler(this.SaveGradeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 490);
            this.Controls.Add(this.SaveGradeGrpBx);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.UpdateDataGrpBx);
            this.Controls.Add(this.LoadAndDeleteGrpBx);
            this.Controls.Add(this.StudentGrdList);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoadAndDeleteGrpBx.ResumeLayout(false);
            this.UpdateDataGrpBx.ResumeLayout(false);
            this.UpdateDataGrpBx.PerformLayout();
            this.SaveGradeGrpBx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ListBox StudentGrdList;
        private System.Windows.Forms.Button LoadStudentGrdBtn;
        private System.Windows.Forms.Button UpdateScoreBtn;
        private System.Windows.Forms.GroupBox LoadAndDeleteGrpBx;
        private System.Windows.Forms.GroupBox UpdateDataGrpBx;
        private System.Windows.Forms.TextBox UpdateFinalTxtBx;
        private System.Windows.Forms.TextBox UpdateMidtermTxtBx;
        private System.Windows.Forms.TextBox UpdateQuizTxtBox;
        private System.Windows.Forms.Label FinalLabel;
        private System.Windows.Forms.Label MidtermLabel;
        private System.Windows.Forms.Label QuizScoreLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.GroupBox SaveGradeGrpBx;
        private System.Windows.Forms.Button DeleteStudentBtn;
        private System.Windows.Forms.Button SaveGradeBtn;
    }
}

