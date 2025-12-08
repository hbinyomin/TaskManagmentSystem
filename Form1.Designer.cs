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
            applyFiltlerButton = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            priorityPickerFilter = new ComboBox();
            label4 = new Label();
            datePickerFilter = new DateTimePicker();
            filterByPriority = new Button();
            filterByDate = new Button();
            clearFilterButton = new Button();
            deleteButton = new Button();
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
            tasksDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tasksDataGridView1.Size = new Size(800, 367);
            tasksDataGridView1.TabIndex = 0;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(22, 402);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(75, 23);
            addTaskButton.TabIndex = 1;
            addTaskButton.Text = "Add Task";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // applyFiltlerButton
            // 
            applyFiltlerButton.Location = new Point(705, 441);
            applyFiltlerButton.Name = "applyFiltlerButton";
            applyFiltlerButton.Size = new Size(75, 23);
            applyFiltlerButton.TabIndex = 2;
            applyFiltlerButton.Text = "Apply";
            applyFiltlerButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(589, 396);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 3;
            label1.Text = "Sort By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(578, 442);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 376);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 5;
            label2.Text = "Filter By";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 409);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Priority";
            // 
            // priorityPickerFilter
            // 
            priorityPickerFilter.FormattingEnabled = true;
            priorityPickerFilter.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            priorityPickerFilter.Location = new Point(156, 427);
            priorityPickerFilter.Name = "priorityPickerFilter";
            priorityPickerFilter.Size = new Size(45, 23);
            priorityPickerFilter.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 409);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Due Date";
            // 
            // datePickerFilter
            // 
            datePickerFilter.Location = new Point(299, 427);
            datePickerFilter.MinDate = new DateTime(2025, 12, 8, 0, 0, 10, 0);
            datePickerFilter.Name = "datePickerFilter";
            datePickerFilter.Size = new Size(198, 23);
            datePickerFilter.TabIndex = 9;
            datePickerFilter.Value = new DateTime(2025, 12, 25, 23, 59, 59, 0);
            // 
            // filterByPriority
            // 
            filterByPriority.Location = new Point(155, 456);
            filterByPriority.Name = "filterByPriority";
            filterByPriority.Size = new Size(120, 24);
            filterByPriority.TabIndex = 10;
            filterByPriority.Text = "Filter By Priority";
            filterByPriority.UseVisualStyleBackColor = true;
            filterByPriority.Click += filterByPriority_Click;
            // 
            // filterByDate
            // 
            filterByDate.Location = new Point(299, 456);
            filterByDate.Name = "filterByDate";
            filterByDate.Size = new Size(114, 23);
            filterByDate.TabIndex = 11;
            filterByDate.Text = "Filter By Date";
            filterByDate.UseVisualStyleBackColor = true;
            filterByDate.Click += filterByDate_Click;
            // 
            // clearFilterButton
            // 
            clearFilterButton.Location = new Point(395, 487);
            clearFilterButton.Name = "clearFilterButton";
            clearFilterButton.Size = new Size(102, 23);
            clearFilterButton.TabIndex = 12;
            clearFilterButton.Text = "Clear Filters";
            clearFilterButton.UseVisualStyleBackColor = true;
            clearFilterButton.Click += clearFilterButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(27, 446);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete Selected Task";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // TaskListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(deleteButton);
            Controls.Add(clearFilterButton);
            Controls.Add(filterByDate);
            Controls.Add(filterByPriority);
            Controls.Add(datePickerFilter);
            Controls.Add(label4);
            Controls.Add(priorityPickerFilter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(applyFiltlerButton);
            Controls.Add(addTaskButton);
            Controls.Add(tasksDataGridView1);
            Name = "TaskListForm";
            Text = "Tasks";
            ((System.ComponentModel.ISupportInitialize)tasksDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tasksDataGridView1;
        private Button addTaskButton;
        private Button applyFiltlerButton;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private ComboBox priorityPickerFilter;
        private Label label4;
        private DateTimePicker datePickerFilter;
        private Button filterByPriority;
        private Button filterByDate;
        private Button clearFilterButton;
        private Button deleteButton;
    }
}
