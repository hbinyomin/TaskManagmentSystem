using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskManagmentSystem {
    public partial class AddTask : Form {
        TaskListForm mainForm;
        public AddTask(TaskListForm mainForm) {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e) {
            using (var context = new TaskDbContext()) {
            
                string taskTitle = titleTextBox.Text;
                string taskDescription = descriptionTextBox.Text;
                try {
                    Task task = new Task(taskTitle,taskDescription);
                    context.Tasks.Add(task);
                    int changes = context.SaveChanges();

                    if (changes > 0) {
                        this.mainForm.LoadTasks();
                        MessageBox.Show("The task was added successfully");
                        this.Close();
                    }
                }
                catch (SqlException ex) {
                    MessageBox.Show("An error occured while processing your request.p\n" + ex.Message);
                }


            }
        }
    }
}
