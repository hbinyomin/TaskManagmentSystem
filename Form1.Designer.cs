using System.Windows.Forms;

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
            comboBox1 = new ComboBox();
            label1 = new Label();
            applyFiltlerButton = new Button();
            addTaskButton = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)tasksDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tasksDataGridView1
            // 
            tasksDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tasksDataGridView1.BackgroundColor = SystemColors.ControlLight;
            tasksDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tasksDataGridView1.Dock = DockStyle.Bottom;
            tasksDataGridView1.Location = new Point(0, 197);
            tasksDataGridView1.Name = "tasksDataGridView1";
            tasksDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tasksDataGridView1.Size = new Size(948, 369);
            tasksDataGridView1.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(25, 115);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 29);
            deleteButton.TabIndex = 26;
            deleteButton.Text = "Delete Task";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // clearFilterButton
            // 
            clearFilterButton.Location = new Point(266, 57);
            clearFilterButton.Name = "clearFilterButton";
            clearFilterButton.Size = new Size(82, 23);
            clearFilterButton.TabIndex = 25;
            clearFilterButton.Text = "Clear Filters";
            clearFilterButton.UseVisualStyleBackColor = true;
            clearFilterButton.Click += clearFilterButton_Click;
            // 
            // filterByDate
            // 
            filterByDate.Location = new Point(545, 141);
            filterByDate.Name = "filterByDate";
            filterByDate.Size = new Size(74, 23);
            filterByDate.TabIndex = 24;
            filterByDate.Text = "Apply";
            filterByDate.UseVisualStyleBackColor = true;
            filterByDate.Click += filterByDate_Click;
            // 
            // filterByPriority
            // 
            filterByPriority.Location = new Point(315, 140);
            filterByPriority.Name = "filterByPriority";
            filterByPriority.Size = new Size(71, 24);
            filterByPriority.TabIndex = 23;
            filterByPriority.Text = "Apply";
            filterByPriority.UseVisualStyleBackColor = true;
            filterByPriority.Click += filterByPriority_Click;
            // 
            // datePickerFilter
            // 
            datePickerFilter.CustomFormat = " ";
            datePickerFilter.Format = DateTimePickerFormat.Custom;
            datePickerFilter.Location = new Point(421, 112);
            datePickerFilter.MinDate = new DateTime(2025, 12, 1, 0, 0, 10, 0);
            datePickerFilter.Name = "datePickerFilter";
            datePickerFilter.Size = new Size(198, 23);
            datePickerFilter.TabIndex = 22;
            datePickerFilter.Value = new DateTime(2025, 12, 25, 23, 59, 59, 0);
            datePickerFilter.ValueChanged += datePickerFilter_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 94);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 21;
            label4.Text = "Due Date";
            // 
            // priorityPickerFilter
            // 
            priorityPickerFilter.FormattingEnabled = true;
            priorityPickerFilter.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            priorityPickerFilter.Location = new Point(267, 112);
            priorityPickerFilter.Name = "priorityPickerFilter";
            priorityPickerFilter.Size = new Size(119, 23);
            priorityPickerFilter.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 94);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 19;
            label3.Text = "Priority";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(801, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(801, 79);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 16;
            label1.Text = "Sort By";
            // 
            // applyFiltlerButton
            // 
            applyFiltlerButton.Location = new Point(847, 140);
            applyFiltlerButton.Name = "applyFiltlerButton";
            applyFiltlerButton.Size = new Size(75, 23);
            applyFiltlerButton.TabIndex = 15;
            applyFiltlerButton.Text = "Apply";
            applyFiltlerButton.UseVisualStyleBackColor = true;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(25, 76);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(88, 26);
            addTaskButton.TabIndex = 14;
            addTaskButton.Text = "Add Task";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(395, 9);
            label5.Name = "label5";
            label5.Size = new Size(172, 32);
            label5.TabIndex = 27;
            label5.Text = "Task Manager";
            // 
            // TaskListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 566);
            Controls.Add(label5);
            Controls.Add(deleteButton);
            Controls.Add(clearFilterButton);
            Controls.Add(filterByDate);
            Controls.Add(filterByPriority);
            Controls.Add(datePickerFilter);
            Controls.Add(label4);
            Controls.Add(priorityPickerFilter);
            Controls.Add(label3);
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
        private ComboBox comboBox1;
        private Label label1;
        private Button applyFiltlerButton;
        private Button addTaskButton;
        private Label label5;
    }
}
