using Microsoft.VisualBasic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TaskManagmentSystem{
    public partial class TaskListForm : Form {

        public TaskListForm() {
            InitializeComponent();
            LoadTasks();
        }

        private void addTaskButton_Click(object sender, EventArgs e) {
            new AddTaskForm(this).ShowDialog();
        }

        private void filterByPriority_Click(object sender, EventArgs e) {
            Priority priority = (Priority)priorityPickerFilter.SelectedIndex;

            using (var context = new TaskDbContext()) {
                var taskList = context.Tasks.Where(t => t.PriorityLevel == priority).ToList();
                loadGrid(tasksDataGridView1, taskList);
            }
        }

        private void filterByDate_Click(object sender, EventArgs e) {
            if (datePickerFilter.Format != DateTimePickerFormat.Long) {
                // If the format has not been changed to Long, then user hasn't selected a value yet
                return;
            }
            DateTime dueDate = datePickerFilter.Value.Date;
            using (var context = new TaskDbContext()) {
                var taskList = context.Tasks.Where(t => t.DueDate == dueDate).ToList();
                loadGrid(tasksDataGridView1, taskList);
            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e) {
            this.LoadTasks();
            //Add here to clear filter text use helper function...
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            var rowTask = tasksDataGridView1.CurrentRow?.DataBoundItem as Task;
            if (rowTask != null) {
                using (var context = new TaskDbContext()) {
                    var taskList = context.Tasks.Remove(rowTask);
                    context.SaveChanges();
                    MessageBox.Show("Task was deleted successfully");
                    LoadTasks();
                }
            }
        }

        private void editTaskButton_Click(object sender, EventArgs e) {
            var rowTask = tasksDataGridView1.CurrentRow?.DataBoundItem as Task;
            if (rowTask != null) {
                new UpdateTaskForm(this,tasksDataGridView1).ShowDialog();
            }
        }

        //helper functions

        public void LoadTasks() {
            using (var context = new TaskDbContext()) {
                var taskList = context.Tasks.ToList();
                loadGrid(tasksDataGridView1, taskList);
            }
        }

        public void loadGrid(DataGridView grid, List<Task> taskList) {
            tasksDataGridView1.DataSource = taskList;
            tasksDataGridView1.Columns["PriorityLevel"]?.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tasksDataGridView1.Columns["PriorityLevel"]?.Width = 110;
            tasksDataGridView1.Columns["DueDate"]?.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tasksDataGridView1.Columns["DueDate"]?.Width = 130;
            tasksDataGridView1.Columns["Title"]?.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tasksDataGridView1.Columns["Title"]?.Width = 180;
            tasksDataGridView1.Columns["Id"]?.Visible = false;
            tasksDataGridView1.ClearSelection();
        }

        private void datePickerFilter_ValueChanged(object sender, EventArgs e) {
            datePickerFilter.Format = DateTimePickerFormat.Long;
        }

       
    }
}
