using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskManagmentSystem {
    public partial class UpdateTaskForm : Form {
        internal TaskListForm mainForm;
        internal int? taskId;
        //TODO - move these to class variables  - private Task rowTask, private taskInstance;
        

        public UpdateTaskForm(TaskListForm mainForm,DataGridView dataGrid) {
            this.mainForm = mainForm;
            InitializeComponent();
            popluateForm(dataGrid);
        }

        private void popluateForm(DataGridView dataGrid) {
            var rowTask = dataGrid.CurrentRow?.DataBoundItem as Task;
            // to do - clean this up, I'm rusing at the end to get this working... this can be cleaned a lot...
            this.taskId = rowTask?.Id;

            if (rowTask != null) {
                using (var context = new TaskDbContext()) {
                    var taskInstance = context.Tasks.Find(rowTask.Id);
                    // TODO  - show message to user if db error - not finding task

                    if (taskInstance != null) {
                        titleTextBox.Text = taskInstance.Title;
                        descriptionTextBox.Text = taskInstance.Description;
                        priorityComboBox1.SelectedItem = (Priority)taskInstance.PriorityLevel;
                        dueDatePicker1.Value = taskInstance.DueDate;
                    }
                }
            }
        }


        private void updateTaskButton_Click(object sender, EventArgs e) {
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

                var context = new TaskDbContext();
                var taskInstance = context.Tasks.Find(this.taskId);
                if (taskInstance != null) {
                    taskInstance.Title = taskTitle;
                    taskInstance.Description = taskDescription;
                    taskInstance.PriorityLevel = priority;
                    taskInstance.DueDate = date;
                }
                
                int changes = context.SaveChanges();

                if (changes > 0) {
                    this.mainForm.LoadTasks();
                    MessageBox.Show("The task was Updated successfully");
                    this.Close();
                }
            }
            // need to see why complier failed when using the specific Exception...
            catch (Exception ex) {
                MessageBox.Show("Sorry, an unexpected error happened.\n" + ex.Message);
            }

       

        }

        private void dueDatePicker1_ValueChanged(object sender, EventArgs e) {
            dueDatePicker1.Format = DateTimePickerFormat.Long;
        }
    }
}
