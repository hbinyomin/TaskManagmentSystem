using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskManagmentSystem {
    public partial class UpdateForm : Form {
        internal TaskListForm mainForm;

        public UpdateForm(TaskListForm mainForm) {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void updateTaskButton_Click(object sender, EventArgs e) {

        }

        private void dueDatePicker1_ValueChanged(object sender, EventArgs e) {
            dueDatePicker1.Format = DateTimePickerFormat.Long;
        }
    }
}
