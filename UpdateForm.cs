using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskManagmentSystem {
    public partial class UpdateForm : AddTaskForm{
        public UpdateForm() {
            InitializeComponent();
        }
        public UpdateForm(TaskListForm mainForm) : base(mainForm) {
            this.mainForm = mainForm;
            InitializeComponent();
        }
    }
}
