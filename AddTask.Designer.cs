using System.Windows.Forms;

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
            priorityLabel = new Label();
            dueDatePicker1 = new DateTimePicker();
            dueDateLabel = new Label();
            priorityComboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 24);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "Task Title";
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(117, 244);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(127, 27);
            addTaskButton.TabIndex = 3;
            addTaskButton.Text = "Add task";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(39, 42);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(205, 23);
            titleTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(41, 92);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(203, 23);
            descriptionTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 75);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Description";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(44, 130);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(45, 15);
            priorityLabel.TabIndex = 9;
            priorityLabel.Text = "Priority";
            // 
            // dueDatePicker1
            // 
            dueDatePicker1.CustomFormat = " ";
            dueDatePicker1.Format = DateTimePickerFormat.Custom;
            dueDatePicker1.Location = new Point(44, 201);
            dueDatePicker1.Name = "dueDatePicker1";
            dueDatePicker1.Size = new Size(200, 23);
            dueDatePicker1.TabIndex = 10;
            dueDatePicker1.ValueChanged += dueDatePicker1_ValueChanged;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new Point(44, 183);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(55, 15);
            dueDateLabel.TabIndex = 11;
            dueDateLabel.Text = "Due Date";
            // 
            // priorityComboBox1
            // 
            priorityComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityComboBox1.FormattingEnabled = true;
            priorityComboBox1.DataSource = Enum.GetValues(typeof(Priority));
            priorityComboBox1.SelectedIndex = -1;
            priorityComboBox1.Location = new Point(44, 148);
            priorityComboBox1.Name = "priorityComboBox1";
            priorityComboBox1.Size = new Size(200, 23);
            priorityComboBox1.TabIndex = 12;
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 304);
            Controls.Add(priorityComboBox1);
            Controls.Add(dueDateLabel);
            Controls.Add(dueDatePicker1);
            Controls.Add(priorityLabel);
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
        private Label priorityLabel;
        private DateTimePicker dueDatePicker1;
        private Label dueDateLabel;
        private ComboBox priorityComboBox1;
    }
}