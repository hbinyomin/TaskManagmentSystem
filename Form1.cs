namespace TaskManagmentSystem
{
    public partial class TaskListForm : Form {
        public void LoadTasks() {
            using (var context = new TaskDbContext()) {
                var taskList = context.Tasks.ToList();
                tasksDataGridView1.DataSource = taskList;
            }
        }
        public TaskListForm() {
            InitializeComponent();
            LoadTasks();
        }

        private void addTaskButton_Click(object sender, EventArgs e) {
            new AddTask(this).ShowDialog();
        }
    }
}
