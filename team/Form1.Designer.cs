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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Anaheim Angels", "Arizona Diamondbacks", "Atlanta Braves", "Baltimore Orioles", "Boston Americans", "Boston Braves", "Boston Red Sox", "Brooklyn Dodgers", "Chicago Cubs", "Chicago White Sox", "Cincinnati Reds", "Cleveland Indians", "Detroit Tigers", "Florida Marlins", "Kansas City Royals", "Los Angeles Dodgers", "Milwaukee Braves", "Minnesota Twins", "New York Giants", "New York Mets", "New York Yankees", "Oakland Athletics", "Philadelphia Athletics", "Philadelphia Phillies", "Pittsburgh Pirates", "San Francisco Giants", "St. Louis Cardinals", "Toronto Blue Jays", "Washington Senators" });
            listBox1.Location = new Point(296, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 264);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}
