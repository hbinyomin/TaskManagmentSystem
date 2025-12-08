using Microsoft.VisualBasic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TaskManagmentSystem
{
    public partial class TaskListForm : Form {
       
        public void loadGrid(DataGridView grid, List<Task> taskList) {
            tasksDataGridView1.DataSource = taskList;
            tasksDataGridView1.Columns["Id"]?.Visible = false;
        }
        public void LoadTasks() {
            using (var context = new TaskDbContext()) {
                var taskList = context.Tasks.ToList();
                //tasksDataGridView1.DataSource = ;
                loadGrid(tasksDataGridView1, taskList);
            }
        }
        public TaskListForm() {
            InitializeComponent();
            LoadTasks();
        }

        private void addTaskButton_Click(object sender, EventArgs e) {
            new AddTask(this).ShowDialog();
        }

        private void filterByPriority_Click(object sender, EventArgs e) {
            int priority = priorityPickerFilter.SelectedIndex;
            using (var context = new TaskDbContext()) {
                var taskList = context.Tasks.Where(t => t.PriorityLevel == priority).ToList();
                loadGrid(tasksDataGridView1, taskList);
            }
        }

        private void filterByDate_Click(object sender, EventArgs e) {
            DateTime dueDate = datePickerFilter.Value.Date;
            using (var context = new TaskDbContext()) {
                var taskList = context.Tasks.Where(t => t.DueDate == dueDate).ToList();
                loadGrid(tasksDataGridView1, taskList);
            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e) {
            this.LoadTasks();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            var rowTask = tasksDataGridView1.CurrentRow?.DataBoundItem as Task;
            if (rowTask != null) {
                Console.WriteLine("");
                using (var context = new TaskDbContext()) {
                    var taskList = context.Tasks.Remove(rowTask);
                    context.SaveChanges();
                    LoadTasks();
                }
            }
        }
    }
}
