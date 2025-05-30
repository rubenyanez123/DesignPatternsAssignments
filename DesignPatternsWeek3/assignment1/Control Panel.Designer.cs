namespace assignment1
{
    partial class ControlPanel
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
            btnNextStation = new Button();
            btnNewDisplay = new Button();
            SuspendLayout();
            // 
            // btnNextStation
            // 
            btnNextStation.Location = new Point(74, 54);
            btnNextStation.Name = "btnNextStation";
            btnNextStation.Size = new Size(159, 88);
            btnNextStation.TabIndex = 0;
            btnNextStation.Text = "Next Station";
            btnNextStation.UseVisualStyleBackColor = true;
            btnNextStation.Click += btnNextStation_Click;
            // 
            // btnNewDisplay
            // 
            btnNewDisplay.Location = new Point(24, 293);
            btnNewDisplay.Name = "btnNewDisplay";
            btnNewDisplay.Size = new Size(121, 64);
            btnNewDisplay.TabIndex = 1;
            btnNewDisplay.Text = "New Display";
            btnNewDisplay.UseVisualStyleBackColor = true;
            btnNewDisplay.Click += btnNewDisplay_Click;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 383);
            Controls.Add(btnNewDisplay);
            Controls.Add(btnNextStation);
            Name = "ControlPanel";
            Text = "Control Panel";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNextStation;
        private Button btnNewDisplay;
    }
}
