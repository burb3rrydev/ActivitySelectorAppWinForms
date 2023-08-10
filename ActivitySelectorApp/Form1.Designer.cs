namespace ActivitySelectorApp
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
            radioIndoor = new RadioButton();
            radioOutdoor = new RadioButton();
            listBoxActivities = new ListBox();
            chkIncludeNotes = new CheckBox();
            chkQuietPlace = new CheckBox();
            chkGroupActivity = new CheckBox();
            btnSubmit = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // radioIndoor
            // 
            radioIndoor.AutoSize = true;
            radioIndoor.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            radioIndoor.Location = new Point(52, 36);
            radioIndoor.Name = "radioIndoor";
            radioIndoor.Size = new Size(84, 29);
            radioIndoor.TabIndex = 0;
            radioIndoor.TabStop = true;
            radioIndoor.Text = "Indoor";
            radioIndoor.UseVisualStyleBackColor = true;
            // 
            // radioOutdoor
            // 
            radioOutdoor.AutoSize = true;
            radioOutdoor.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            radioOutdoor.Location = new Point(185, 36);
            radioOutdoor.Name = "radioOutdoor";
            radioOutdoor.Size = new Size(99, 29);
            radioOutdoor.TabIndex = 1;
            radioOutdoor.TabStop = true;
            radioOutdoor.Text = "Outdoor";
            radioOutdoor.UseVisualStyleBackColor = true;
            // 
            // listBoxActivities
            // 
            listBoxActivities.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxActivities.FormattingEnabled = true;
            listBoxActivities.ItemHeight = 21;
            listBoxActivities.Location = new Point(52, 87);
            listBoxActivities.Name = "listBoxActivities";
            listBoxActivities.Size = new Size(203, 109);
            listBoxActivities.TabIndex = 2;
            // 
            // chkIncludeNotes
            // 
            chkIncludeNotes.AutoSize = true;
            chkIncludeNotes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkIncludeNotes.Location = new Point(52, 205);
            chkIncludeNotes.Name = "chkIncludeNotes";
            chkIncludeNotes.Size = new Size(124, 25);
            chkIncludeNotes.TabIndex = 3;
            chkIncludeNotes.Text = "Include Notes";
            chkIncludeNotes.UseVisualStyleBackColor = true;
            // 
            // chkQuietPlace
            // 
            chkQuietPlace.AutoSize = true;
            chkQuietPlace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkQuietPlace.Location = new Point(52, 236);
            chkQuietPlace.Name = "chkQuietPlace";
            chkQuietPlace.Size = new Size(107, 25);
            chkQuietPlace.TabIndex = 4;
            chkQuietPlace.Text = "Quiet Place";
            chkQuietPlace.UseVisualStyleBackColor = true;
            // 
            // chkGroupActivity
            // 
            chkGroupActivity.AutoSize = true;
            chkGroupActivity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkGroupActivity.Location = new Point(52, 267);
            chkGroupActivity.Name = "chkGroupActivity";
            chkGroupActivity.Size = new Size(128, 25);
            chkGroupActivity.TabIndex = 5;
            chkGroupActivity.Text = "Group Activity";
            chkGroupActivity.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaptionText;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = SystemColors.Window;
            btnSubmit.Location = new Point(52, 312);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(203, 36);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(52, 364);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 7;
            lblResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(325, 503);
            Controls.Add(lblResult);
            Controls.Add(btnSubmit);
            Controls.Add(chkGroupActivity);
            Controls.Add(chkQuietPlace);
            Controls.Add(chkIncludeNotes);
            Controls.Add(listBoxActivities);
            Controls.Add(radioOutdoor);
            Controls.Add(radioIndoor);
            Name = "Form1";
            Text = "Activity Selector";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioIndoor;
        private RadioButton radioOutdoor;
        private ListBox listBoxActivities;
        private CheckBox chkIncludeNotes;
        private CheckBox chkQuietPlace;
        private CheckBox chkGroupActivity;
        private Button btnSubmit;
        private Label lblResult;
    }
}