using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagmentSystem {
    internal class Task {
        public int Id {
            get; set;
        }
        public string Title { get; set; } =null!;
        public string? Description {
            get; set;
        }
        public DateTime? DueDate {
            get; set;
        }
        public int PriorityLevel {
            get; set;
        }

        public Task() {
        }
    }
}
