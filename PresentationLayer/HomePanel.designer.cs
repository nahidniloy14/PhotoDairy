
namespace DigitalPhotoDiary.PresentationLayer
{
    partial class HomePanel
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.createEventButton = new System.Windows.Forms.Button();
            this.goToButton = new System.Windows.Forms.Button();
            this.eventsDataGridView = new System.Windows.Forms.DataGridView();
            this.overviewLabel = new System.Windows.Forms.Label();
            this.EventIdLabel = new System.Windows.Forms.Label();
            this.eventIdTextBox = new System.Windows.Forms.TextBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.EventLabel = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteEventButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(490, 19);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(152, 18);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome, AnyOne.";
            // 
            // createEventButton
            // 
            this.createEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventButton.Location = new System.Drawing.Point(1006, 167);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(86, 73);
            this.createEventButton.TabIndex = 1;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = true;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // goToButton
            // 
            this.goToButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToButton.Location = new System.Drawing.Point(647, 406);
            this.goToButton.Name = "goToButton";
            this.goToButton.Size = new System.Drawing.Size(85, 32);
            this.goToButton.TabIndex = 4;
            this.goToButton.Text = "Go";
            this.goToButton.UseVisualStyleBackColor = true;
            this.goToButton.Click += new System.EventHandler(this.goToButton_Click);
            // 
            // eventsDataGridView
            // 
            this.eventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGridView.Location = new System.Drawing.Point(63, 106);
            this.eventsDataGridView.Name = "eventsDataGridView";
            this.eventsDataGridView.RowHeadersWidth = 51;
            this.eventsDataGridView.RowTemplate.Height = 24;
            this.eventsDataGridView.Size = new System.Drawing.Size(884, 178);
            this.eventsDataGridView.TabIndex = 5;
            this.eventsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventsDataGridView_CellClick);
            // 
            // overviewLabel
            // 
            this.overviewLabel.AutoSize = true;
            this.overviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewLabel.Location = new System.Drawing.Point(69, 85);
            this.overviewLabel.Name = "overviewLabel";
            this.overviewLabel.Size = new System.Drawing.Size(175, 18);
            this.overviewLabel.TabIndex = 6;
            this.overviewLabel.Text = "Your Available Events.";
            // 
            // EventIdLabel
            // 
            this.EventIdLabel.AutoSize = true;
            this.EventIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventIdLabel.Location = new System.Drawing.Point(384, 321);
            this.EventIdLabel.Name = "EventIdLabel";
            this.EventIdLabel.Size = new System.Drawing.Size(83, 20);
            this.EventIdLabel.TabIndex = 7;
            this.EventIdLabel.Text = "Event Id:";
            // 
            // eventIdTextBox
            // 
            this.eventIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventIdTextBox.Location = new System.Drawing.Point(499, 318);
            this.eventIdTextBox.Name = "eventIdTextBox";
            this.eventIdTextBox.Size = new System.Drawing.Size(233, 27);
            this.eventIdTextBox.TabIndex = 8;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(567, 477);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(103, 42);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(699, 19);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(18, 18);
            this.userIdLabel.TabIndex = 10;
            this.userIdLabel.Text = "o";
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLabel.Location = new System.Drawing.Point(405, 366);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(62, 20);
            this.EventLabel.TabIndex = 11;
            this.EventLabel.Text = "Event:";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameTextBox.Location = new System.Drawing.Point(499, 363);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(233, 27);
            this.eventNameTextBox.TabIndex = 12;
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEventButton.Location = new System.Drawing.Point(499, 406);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(91, 32);
            this.deleteEventButton.TabIndex = 13;
            this.deleteEventButton.Text = "Delete";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 550);
            this.Controls.Add(this.deleteEventButton);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.eventIdTextBox);
            this.Controls.Add(this.EventIdLabel);
            this.Controls.Add(this.overviewLabel);
            this.Controls.Add(this.eventsDataGridView);
            this.Controls.Add(this.goToButton);
            this.Controls.Add(this.createEventButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "HomePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePanel_FormClosing);
            this.Load += new System.EventHandler(this.HomePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.Button goToButton;
        private System.Windows.Forms.DataGridView eventsDataGridView;
        private System.Windows.Forms.Label overviewLabel;
        private System.Windows.Forms.Label EventIdLabel;
        private System.Windows.Forms.TextBox eventIdTextBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Button deleteEventButton;
    }
}