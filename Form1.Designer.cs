namespace TaskManagmentSystem
{
    partial class TaskListForm
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
        private void InitializeComponent() {
            tasksDataGridView1 = new DataGridView();
            addTaskButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tasksDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tasksDataGridView1
            // 
            tasksDataGridView1.BackgroundColor = SystemColors.ControlLight;
            tasksDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tasksDataGridView1.Dock = DockStyle.Top;
            tasksDataGridView1.Location = new Point(0, 0);
            tasksDataGridView1.Name = "tasksDataGridView1";
            tasksDataGridView1.Size = new Size(800, 450);
            tasksDataGridView1.TabIndex = 0;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(34, 480);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(75, 23);
            addTaskButton.TabIndex = 1;
            addTaskButton.Text = "Add Task";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // taskListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(addTaskButton);
            Controls.Add(tasksDataGridView1);
            Name = "taskListForm";
            Text = "Tasks";
            ((System.ComponentModel.ISupportInitialize)tasksDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tasksDataGridView1;
        private Button addTaskButton;
    }
}
