using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagmentSystem {
    public class Task {
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
        //public Task(string taskTitle, string description, DateTime dueDate, int priorityLevel) {
        public Task(string taskTitle, string description,DateTime dueDate, int priorityLevel) {
            this.Title = taskTitle;
            this.Description = description;
            this.DueDate = dueDate.Date;
            this.PriorityLevel = priorityLevel;
        }


    }
}
