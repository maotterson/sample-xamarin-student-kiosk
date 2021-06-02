using System;
using System.Collections.Generic;
using System.Text;

namespace SampleXamarin2.Models
{
    class CheckIn
    {
        public string StudentId { get; set; }
        public string Name { get; set; }

        public CheckIn(string studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
    }
}
