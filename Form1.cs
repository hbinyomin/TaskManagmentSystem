namespace TaskManagmentSystem
{
    public partial class Form1 : Form
    {
        public void LoadTasks() {
            using (var context = new TaskDbContext()) {
                var taskList = context.Tasks.ToList();
                tasksDataGridView1.DataSource = taskList;
            }
        }
        public Form1()
        {
            InitializeComponent();
            LoadTasks();
        }
    }
}
