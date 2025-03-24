using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_08_03_25.Abstractions;

namespace data_08_03_25.Models
{
    public class MarkModel : IModel
    {
        public int ID { get; set; }
        public List<int>? Marks { get; set; }
        public int? GPA { get; set; }

        public MarkModel()
        {
            Marks = [];
        }

        public MarkModel(int id, List<int> marks)
        {
            ID = id;
            Marks = marks;
        }

        public MarkModel(int id, List<int> marks, int gpa)
        {
            ID = id;
            Marks = marks;
            GPA = gpa;
        }

    }
}
