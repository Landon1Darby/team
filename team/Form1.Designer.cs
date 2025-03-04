namespace team
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TeamsListBox = new ListBox();
            exitButton = new Button();
            label1 = new Label();
            answerLabel = new Label();
            SuspendLayout();
            // 
            // TeamsListBox
            // 
            TeamsListBox.FormattingEnabled = true;
            TeamsListBox.Items.AddRange(new object[] { "Anaheim Angels", "Arizona Diamondbacks", "Atlanta Braves", "Baltimore Orioles", "Boston Americans", "Boston Braves", "Boston Red Sox", "Brooklyn Dodgers", "Chicago Cubs", "Chicago White Sox", "Cincinnati Reds", "Cleveland Indians", "Detroit Tigers", "Florida Marlins", "Kansas City Royals", "Los Angeles Dodgers", "Milwaukee Braves", "Minnesota Twins", "New York Giants", "New York Mets", "New York Yankees", "Oakland Athletics", "Philadelphia Athletics", "Philadelphia Phillies", "Pittsburgh Pirates", "San Francisco Giants", "St. Louis Cardinals", "Toronto Blue Jays", "Washington Senators" });
            TeamsListBox.Location = new Point(294, 12);
            TeamsListBox.Name = "TeamsListBox";
            TeamsListBox.Size = new Size(150, 264);
            TeamsListBox.TabIndex = 0;
            TeamsListBox.SelectedIndexChanged += TeamsListBox_SelectedIndexChanged;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(326, 463);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(279, 290);
            label1.Name = "label1";
            label1.Size = new Size(184, 86);
            label1.TabIndex = 2;
            label1.Text = "in the year 1903 and 2012 the selected team has won the worldseries this many times";
            // 
            // answerLabel
            // 
            answerLabel.BorderStyle = BorderStyle.FixedSingle;
            answerLabel.Location = new Point(311, 402);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(109, 25);
            answerLabel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 527);
            Controls.Add(answerLabel);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(TeamsListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox TeamsListBox;
        private Button exitButton;
        private Label label1;
        private Label answerLabel;
    }
}
