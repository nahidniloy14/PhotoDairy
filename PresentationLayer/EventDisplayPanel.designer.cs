
namespace DigitalPhotoDiary.PresentationLayer
{
    partial class EventDisplayPanel
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
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.homeBackButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.modificationDateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.storyGroypBox = new System.Windows.Forms.GroupBox();
            this.storyLabel1 = new System.Windows.Forms.Label();
            this.storyGroupBox = new System.Windows.Forms.GroupBox();
            this.storyLabel2 = new System.Windows.Forms.Label();
            this.addPhotoButton1 = new System.Windows.Forms.Button();
            this.addPhotoButton2 = new System.Windows.Forms.Button();
            this.addStoryButton1 = new System.Windows.Forms.Button();
            this.addStoryButton2 = new System.Windows.Forms.Button();
            this.storyTextBox1 = new System.Windows.Forms.TextBox();
            this.storyTextBox2 = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.eventIdLabel = new System.Windows.Forms.Label();
            this.updatePhotoButton1 = new System.Windows.Forms.Button();
            this.updatePhotoButton2 = new System.Windows.Forms.Button();
            this.updateStoryButton1 = new System.Windows.Forms.Button();
            this.updateStoryButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.storyGroypBox.SuspendLayout();
            this.storyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(93, 50);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(59, 20);
            this.eventNameLabel.TabIndex = 0;
            this.eventNameLabel.Text = "label1";
            // 
            // homeBackButton
            // 
            this.homeBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBackButton.Location = new System.Drawing.Point(546, 558);
            this.homeBackButton.Name = "homeBackButton";
            this.homeBackButton.Size = new System.Drawing.Size(70, 38);
            this.homeBackButton.TabIndex = 1;
            this.homeBackButton.Text = "Back";
            this.homeBackButton.UseVisualStyleBackColor = true;
            this.homeBackButton.Click += new System.EventHandler(this.homeBackButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(835, 30);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 20);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "label1";
            // 
            // modificationDateLabel
            // 
            this.modificationDateLabel.AutoSize = true;
            this.modificationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationDateLabel.Location = new System.Drawing.Point(823, 60);
            this.modificationDateLabel.Name = "modificationDateLabel";
            this.modificationDateLabel.Size = new System.Drawing.Size(59, 20);
            this.modificationDateLabel.TabIndex = 3;
            this.modificationDateLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(97, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 258);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(637, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(414, 258);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // storyGroypBox
            // 
            this.storyGroypBox.Controls.Add(this.storyLabel1);
            this.storyGroypBox.Location = new System.Drawing.Point(159, 397);
            this.storyGroypBox.Name = "storyGroypBox";
            this.storyGroypBox.Size = new System.Drawing.Size(330, 50);
            this.storyGroypBox.TabIndex = 6;
            this.storyGroypBox.TabStop = false;
            this.storyGroypBox.Text = "Story:";
            this.storyGroypBox.Enter += new System.EventHandler(this.storyGroypBox_Enter);
            // 
            // storyLabel1
            // 
            this.storyLabel1.AutoSize = true;
            this.storyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel1.Location = new System.Drawing.Point(6, 18);
            this.storyLabel1.Name = "storyLabel1";
            this.storyLabel1.Size = new System.Drawing.Size(164, 18);
            this.storyLabel1.TabIndex = 1;
            this.storyLabel1.Text = "Your Story Will Be Here";
            // 
            // storyGroupBox
            // 
            this.storyGroupBox.Controls.Add(this.storyLabel2);
            this.storyGroupBox.Location = new System.Drawing.Point(637, 397);
            this.storyGroupBox.Name = "storyGroupBox";
            this.storyGroupBox.Size = new System.Drawing.Size(319, 50);
            this.storyGroupBox.TabIndex = 7;
            this.storyGroupBox.TabStop = false;
            this.storyGroupBox.Text = "Story:";
            // 
            // storyLabel2
            // 
            this.storyLabel2.AutoSize = true;
            this.storyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel2.Location = new System.Drawing.Point(18, 20);
            this.storyLabel2.Name = "storyLabel2";
            this.storyLabel2.Size = new System.Drawing.Size(168, 18);
            this.storyLabel2.TabIndex = 2;
            this.storyLabel2.Text = "Your Story Will Be Here.";
            // 
            // addPhotoButton1
            // 
            this.addPhotoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPhotoButton1.Location = new System.Drawing.Point(27, 379);
            this.addPhotoButton1.Name = "addPhotoButton1";
            this.addPhotoButton1.Size = new System.Drawing.Size(109, 38);
            this.addPhotoButton1.TabIndex = 8;
            this.addPhotoButton1.Text = "AddPhoto";
            this.addPhotoButton1.UseVisualStyleBackColor = true;
            // 
            // addPhotoButton2
            // 
            this.addPhotoButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPhotoButton2.Location = new System.Drawing.Point(986, 379);
            this.addPhotoButton2.Name = "addPhotoButton2";
            this.addPhotoButton2.Size = new System.Drawing.Size(111, 38);
            this.addPhotoButton2.TabIndex = 9;
            this.addPhotoButton2.Text = "AddPhoto";
            this.addPhotoButton2.UseVisualStyleBackColor = true;
            // 
            // addStoryButton1
            // 
            this.addStoryButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStoryButton1.Location = new System.Drawing.Point(344, 507);
            this.addStoryButton1.Name = "addStoryButton1";
            this.addStoryButton1.Size = new System.Drawing.Size(98, 38);
            this.addStoryButton1.TabIndex = 10;
            this.addStoryButton1.Text = "AddStory";
            this.addStoryButton1.UseVisualStyleBackColor = true;
            // 
            // addStoryButton2
            // 
            this.addStoryButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStoryButton2.Location = new System.Drawing.Point(715, 507);
            this.addStoryButton2.Name = "addStoryButton2";
            this.addStoryButton2.Size = new System.Drawing.Size(108, 38);
            this.addStoryButton2.TabIndex = 11;
            this.addStoryButton2.Text = "AddStory";
            this.addStoryButton2.UseVisualStyleBackColor = true;
            // 
            // storyTextBox1
            // 
            this.storyTextBox1.Location = new System.Drawing.Point(159, 468);
            this.storyTextBox1.Name = "storyTextBox1";
            this.storyTextBox1.Size = new System.Drawing.Size(330, 22);
            this.storyTextBox1.TabIndex = 12;
            // 
            // storyTextBox2
            // 
            this.storyTextBox2.Location = new System.Drawing.Point(637, 468);
            this.storyTextBox2.Name = "storyTextBox2";
            this.storyTextBox2.Size = new System.Drawing.Size(319, 22);
            this.storyTextBox2.TabIndex = 13;
            this.storyTextBox2.TextChanged += new System.EventHandler(this.storyTextBox2_TextChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(494, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(94, 20);
            this.userNameLabel.TabIndex = 14;
            this.userNameLabel.Text = "Username";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(615, 9);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(94, 20);
            this.userIdLabel.TabIndex = 15;
            this.userIdLabel.Text = "Username";
            // 
            // eventIdLabel
            // 
            this.eventIdLabel.AutoSize = true;
            this.eventIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventIdLabel.Location = new System.Drawing.Point(258, 50);
            this.eventIdLabel.Name = "eventIdLabel";
            this.eventIdLabel.Size = new System.Drawing.Size(59, 20);
            this.eventIdLabel.TabIndex = 16;
            this.eventIdLabel.Text = "label1";
            // 
            // updatePhotoButton1
            // 
            this.updatePhotoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePhotoButton1.Location = new System.Drawing.Point(27, 432);
            this.updatePhotoButton1.Name = "updatePhotoButton1";
            this.updatePhotoButton1.Size = new System.Drawing.Size(109, 38);
            this.updatePhotoButton1.TabIndex = 17;
            this.updatePhotoButton1.Text = "Update";
            this.updatePhotoButton1.UseVisualStyleBackColor = true;
            // 
            // updatePhotoButton2
            // 
            this.updatePhotoButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePhotoButton2.Location = new System.Drawing.Point(986, 423);
            this.updatePhotoButton2.Name = "updatePhotoButton2";
            this.updatePhotoButton2.Size = new System.Drawing.Size(111, 38);
            this.updatePhotoButton2.TabIndex = 18;
            this.updatePhotoButton2.Text = "Update";
            this.updatePhotoButton2.UseVisualStyleBackColor = true;
            // 
            // updateStoryButton1
            // 
            this.updateStoryButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStoryButton1.Location = new System.Drawing.Point(229, 507);
            this.updateStoryButton1.Name = "updateStoryButton1";
            this.updateStoryButton1.Size = new System.Drawing.Size(100, 38);
            this.updateStoryButton1.TabIndex = 19;
            this.updateStoryButton1.Text = "Update";
            this.updateStoryButton1.UseVisualStyleBackColor = true;
            // 
            // updateStoryButton2
            // 
            this.updateStoryButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStoryButton2.Location = new System.Drawing.Point(829, 507);
            this.updateStoryButton2.Name = "updateStoryButton2";
            this.updateStoryButton2.Size = new System.Drawing.Size(100, 38);
            this.updateStoryButton2.TabIndex = 20;
            this.updateStoryButton2.Text = "Update";
            this.updateStoryButton2.UseVisualStyleBackColor = true;
            // 
            // EventDisplayPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 608);
            this.Controls.Add(this.updateStoryButton2);
            this.Controls.Add(this.updateStoryButton1);
            this.Controls.Add(this.updatePhotoButton2);
            this.Controls.Add(this.updatePhotoButton1);
            this.Controls.Add(this.eventIdLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.storyTextBox2);
            this.Controls.Add(this.storyTextBox1);
            this.Controls.Add(this.addStoryButton2);
            this.Controls.Add(this.addStoryButton1);
            this.Controls.Add(this.addPhotoButton2);
            this.Controls.Add(this.addPhotoButton1);
            this.Controls.Add(this.storyGroupBox);
            this.Controls.Add(this.storyGroypBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.modificationDateLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.homeBackButton);
            this.Controls.Add(this.eventNameLabel);
            this.Name = "EventDisplayPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventDisplayPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventDisplayPanel_FormClosed);
            this.Load += new System.EventHandler(this.EventDisplayPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.storyGroypBox.ResumeLayout(false);
            this.storyGroypBox.PerformLayout();
            this.storyGroupBox.ResumeLayout(false);
            this.storyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Button homeBackButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label modificationDateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox storyGroypBox;
        private System.Windows.Forms.GroupBox storyGroupBox;
        private System.Windows.Forms.Button addPhotoButton1;
        private System.Windows.Forms.Button addPhotoButton2;
        private System.Windows.Forms.Button addStoryButton1;
        private System.Windows.Forms.Button addStoryButton2;
        private System.Windows.Forms.TextBox storyTextBox1;
        private System.Windows.Forms.TextBox storyTextBox2;
        private System.Windows.Forms.Label storyLabel1;
        private System.Windows.Forms.Label storyLabel2;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label eventIdLabel;
        private System.Windows.Forms.Button updatePhotoButton1;
        private System.Windows.Forms.Button updatePhotoButton2;
        private System.Windows.Forms.Button updateStoryButton1;
        private System.Windows.Forms.Button updateStoryButton2;
    }
}