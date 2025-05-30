namespace assignment1
{
    partial class TrainDisplay
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
            lblCurrentStation = new Label();
            lblRailwayTrack = new Label();
            lblCurrentStationName = new Label();
            lblRailwayTrackNumber = new Label();
            SuspendLayout();
            // 
            // lblCurrentStation
            // 
            lblCurrentStation.AutoSize = true;
            lblCurrentStation.Location = new Point(40, 47);
            lblCurrentStation.Name = "lblCurrentStation";
            lblCurrentStation.Size = new Size(111, 20);
            lblCurrentStation.TabIndex = 0;
            lblCurrentStation.Text = "Current Station:";
            // 
            // lblRailwayTrack
            // 
            lblRailwayTrack.AutoSize = true;
            lblRailwayTrack.Location = new Point(40, 125);
            lblRailwayTrack.Name = "lblRailwayTrack";
            lblRailwayTrack.Size = new Size(101, 20);
            lblRailwayTrack.TabIndex = 1;
            lblRailwayTrack.Text = "Railway Track:";
            // 
            // lblCurrentStationName
            // 
            lblCurrentStationName.AutoSize = true;
            lblCurrentStationName.Location = new Point(157, 47);
            lblCurrentStationName.Name = "lblCurrentStationName";
            lblCurrentStationName.Size = new Size(0, 20);
            lblCurrentStationName.TabIndex = 3;
            // 
            // lblRailwayTrackNumber
            // 
            lblRailwayTrackNumber.AutoSize = true;
            lblRailwayTrackNumber.Location = new Point(147, 125);
            lblRailwayTrackNumber.Name = "lblRailwayTrackNumber";
            lblRailwayTrackNumber.Size = new Size(0, 20);
            lblRailwayTrackNumber.TabIndex = 4;
            // 
            // TrainDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 203);
            Controls.Add(lblRailwayTrackNumber);
            Controls.Add(lblCurrentStationName);
            Controls.Add(lblRailwayTrack);
            Controls.Add(lblCurrentStation);
            Name = "TrainDisplay";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentStation;
        private Label lblRailwayTrack;
        private Label lblCurrentStationName;
        private Label lblRailwayTrackNumber;
    }
}