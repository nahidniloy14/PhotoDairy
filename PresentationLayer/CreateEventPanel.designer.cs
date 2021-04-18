
namespace DigitalPhotoDiary.PresentationLayer
{
    partial class CreateEventPanel
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.eventLabel = new System.Windows.Forms.Label();
            this.eventDateLabel = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createButton = new System.Windows.Forms.Button();
            this.importanceLabel = new System.Windows.Forms.Label();
            this.lowRadioButton = new System.Windows.Forms.RadioButton();
            this.modRadioButton = new System.Windows.Forms.RadioButton();
            this.highRadioButton = new System.Windows.Forms.RadioButton();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(187, 24);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(46, 17);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "label1";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(277, 24);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(46, 17);
            this.userIdLabel.TabIndex = 1;
            this.userIdLabel.Text = "label2";
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLabel.Location = new System.Drawing.Point(87, 107);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(74, 25);
            this.eventLabel.TabIndex = 2;
            this.eventLabel.Text = "Event:";
            // 
            // eventDateLabel
            // 
            this.eventDateLabel.AutoSize = true;
            this.eventDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDateLabel.Location = new System.Drawing.Point(87, 180);
            this.eventDateLabel.Name = "eventDateLabel";
            this.eventDateLabel.Size = new System.Drawing.Size(64, 25);
            this.eventDateLabel.TabIndex = 3;
            this.eventDateLabel.Text = "Date:";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameTextBox.Location = new System.Drawing.Point(176, 106);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(242, 28);
            this.eventNameTextBox.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(176, 179);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(242, 27);
            this.dateTimePicker.TabIndex = 5;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(214, 401);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(97, 41);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // importanceLabel
            // 
            this.importanceLabel.AutoSize = true;
            this.importanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importanceLabel.Location = new System.Drawing.Point(25, 281);
            this.importanceLabel.Name = "importanceLabel";
            this.importanceLabel.Size = new System.Drawing.Size(126, 25);
            this.importanceLabel.TabIndex = 7;
            this.importanceLabel.Text = "Importance:";
            // 
            // lowRadioButton
            // 
            this.lowRadioButton.AutoSize = true;
            this.lowRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowRadioButton.Location = new System.Drawing.Point(176, 286);
            this.lowRadioButton.Name = "lowRadioButton";
            this.lowRadioButton.Size = new System.Drawing.Size(61, 24);
            this.lowRadioButton.TabIndex = 8;
            this.lowRadioButton.TabStop = true;
            this.lowRadioButton.Text = "Low";
            this.lowRadioButton.UseVisualStyleBackColor = true;
            // 
            // modRadioButton
            // 
            this.modRadioButton.AutoSize = true;
            this.modRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modRadioButton.Location = new System.Drawing.Point(253, 286);
            this.modRadioButton.Name = "modRadioButton";
            this.modRadioButton.Size = new System.Drawing.Size(100, 24);
            this.modRadioButton.TabIndex = 9;
            this.modRadioButton.TabStop = true;
            this.modRadioButton.Text = "Modarate";
            this.modRadioButton.UseVisualStyleBackColor = true;
            // 
            // highRadioButton
            // 
            this.highRadioButton.AutoSize = true;
            this.highRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highRadioButton.Location = new System.Drawing.Point(373, 286);
            this.highRadioButton.Name = "highRadioButton";
            this.highRadioButton.Size = new System.Drawing.Size(65, 24);
            this.highRadioButton.TabIndex = 10;
            this.highRadioButton.TabStop = true;
            this.highRadioButton.Text = "High";
            this.highRadioButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(387, 405);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(76, 34);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CreateEventPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 471);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.highRadioButton);
            this.Controls.Add(this.modRadioButton);
            this.Controls.Add(this.lowRadioButton);
            this.Controls.Add(this.importanceLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.eventDateLabel);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "CreateEventPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateEventPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEventPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Label eventDateLabel;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label importanceLabel;
        private System.Windows.Forms.RadioButton lowRadioButton;
        private System.Windows.Forms.RadioButton modRadioButton;
        private System.Windows.Forms.RadioButton highRadioButton;
        private System.Windows.Forms.Button backButton;
    }
}