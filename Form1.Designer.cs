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
            deleteButton = new Button();
            clearFilterButton = new Button();
            filterByDate = new Button();
            filterByPriority = new Button();
            datePickerFilter = new DateTimePicker();
            label4 = new Label();
            priorityPickerFilter = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            applyFiltlerButton = new Button();
            addTaskButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tasksDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tasksDataGridView1
            // 
            tasksDataGridView1.BackgroundColor = SystemColors.ControlLight;
            tasksDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tasksDataGridView1.Dock = DockStyle.Bottom;
            tasksDataGridView1.Location = new Point(0, 159);
            tasksDataGridView1.Name = "tasksDataGridView1";
            tasksDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tasksDataGridView1.Size = new Size(948, 369);
            tasksDataGridView1.TabIndex = 0;
            tasksDataGridView1.CellContentClick += tasksDataGridView1_CellContentClick;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(19, 71);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 23);
            deleteButton.TabIndex = 26;
            deleteButton.Text = "Delete Task";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // clearFilterButton
            // 
            clearFilterButton.Location = new Point(472, 114);
            clearFilterButton.Name = "clearFilterButton";
            clearFilterButton.Size = new Size(102, 23);
            clearFilterButton.TabIndex = 25;
            clearFilterButton.Text = "Clear Filters";
            clearFilterButton.UseVisualStyleBackColor = true;
            // 
            // filterByDate
            // 
            filterByDate.Location = new Point(376, 76);
            filterByDate.Name = "filterByDate";
            filterByDate.Size = new Size(114, 23);
            filterByDate.TabIndex = 24;
            filterByDate.Text = "Filter By Date";
            filterByDate.UseVisualStyleBackColor = true;
            // 
            // filterByPriority
            // 
            filterByPriority.Location = new Point(232, 76);
            filterByPriority.Name = "filterByPriority";
            filterByPriority.Size = new Size(120, 24);
            filterByPriority.TabIndex = 23;
            filterByPriority.Text = "Filter By Priority";
            filterByPriority.UseVisualStyleBackColor = true;
            // 
            // datePickerFilter
            // 
            datePickerFilter.Location = new Point(376, 47);
            datePickerFilter.MinDate = new DateTime(2025, 12, 8, 0, 0, 10, 0);
            datePickerFilter.Name = "datePickerFilter";
            datePickerFilter.Size = new Size(198, 23);
            datePickerFilter.TabIndex = 22;
            datePickerFilter.Value = new DateTime(2025, 12, 25, 23, 59, 59, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(376, 29);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 21;
            label4.Text = "Due Date";
            // 
            // priorityPickerFilter
            // 
            priorityPickerFilter.FormattingEnabled = true;
            priorityPickerFilter.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            priorityPickerFilter.Location = new Point(233, 47);
            priorityPickerFilter.Name = "priorityPickerFilter";
            priorityPickerFilter.Size = new Size(87, 23);
            priorityPickerFilter.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 29);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 19;
            label3.Text = "Priority";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(306, 6);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 18;
            label2.Text = "Filter By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(720, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(731, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 16;
            label1.Text = "Sort By";
            // 
            // applyFiltlerButton
            // 
            applyFiltlerButton.Location = new Point(847, 70);
            applyFiltlerButton.Name = "applyFiltlerButton";
            applyFiltlerButton.Size = new Size(75, 23);
            applyFiltlerButton.TabIndex = 15;
            applyFiltlerButton.Text = "Apply";
            applyFiltlerButton.UseVisualStyleBackColor = true;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(19, 32);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(88, 26);
            addTaskButton.TabIndex = 14;
            addTaskButton.Text = "Add Task";
            addTaskButton.UseVisualStyleBackColor = true;
            // 
            // TaskListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 528);
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
        private Button deleteButton;
        private Button clearFilterButton;
        private Button filterByDate;
        private Button filterByPriority;
        private DateTimePicker datePickerFilter;
        private Label label4;
        private ComboBox priorityPickerFilter;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button applyFiltlerButton;
        private Button addTaskButton;
    }
}
