namespace TaskManagmentSystem {
    partial class AddTask {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label2 = new Label();
            addTaskButton = new Button();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 60);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "Task Title";
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(80, 209);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(127, 36);
            addTaskButton.TabIndex = 3;
            addTaskButton.Text = "Add task";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(80, 78);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(205, 23);
            titleTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(82, 128);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(243, 23);
            descriptionTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 111);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Description";
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label2);
            Controls.Add(addTaskButton);
            Name = "AddTask";
            Text = "AddTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button addTaskButton;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label label3;
    }
}