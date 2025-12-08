using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskManagmentSystem {
    public partial class AddTaskForm : Form {
        internal TaskListForm? mainForm;

        public AddTaskForm() {
            InitializeComponent();
        }
        public AddTaskForm(TaskListForm mainForm) : this() {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e) {
            using (var context = new TaskDbContext()) {

                string? taskTitle = string.IsNullOrWhiteSpace(titleTextBox.Text) ? null : titleTextBox.Text;
                string? taskDescription = string.IsNullOrWhiteSpace(descriptionTextBox.Text) ? null : descriptionTextBox.Text;
                DateTime date = dueDatePicker1.Value;


                // break this out into helper function - validate data
                if (taskTitle == null) {
                    MessageBox.Show("You must assign a title to a task");
                    return;
                }
                if (taskDescription == null) {
                    MessageBox.Show("You must assign a description to a task");
                    return;
                }

                if (priorityComboBox1.SelectedItem==null) {
                    MessageBox.Show("You must assign a priority to a task");
                    return;
                }
                if (dueDatePicker1.Format == DateTimePickerFormat.Custom) {
                    //Indicates that user didn't select a date yet
                    MessageBox.Show("You must assign a date to a task");
                    return;
                }

                //At this point, selectedItem is not null
                Priority priority = (Priority)priorityComboBox1.SelectedItem;

                try {
                    Task task = new Task(taskTitle: taskTitle, description: taskDescription, dueDate: date, priorityLevel: priority);
                    context.Tasks.Add(task);
                    int changes = context.SaveChanges();

                    if (changes > 0) {
                        this.mainForm.LoadTasks();
                        MessageBox.Show("The task was added successfully");
                        this.Close();
                    }
                }
                catch (DbUpdateException ex) {
                    MessageBox.Show("Sorry, an unexpected error happened.\n" + ex.Message);
                }


            }
        }

        private void dueDatePicker1_ValueChanged(object sender, EventArgs e) {
            dueDatePicker1.Format = DateTimePickerFormat.Long;
        }
    }
}
