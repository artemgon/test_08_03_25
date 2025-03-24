using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_08_03_25.Abstractions;

namespace data_08_03_25.Models
{
    public class StudentModel : IModel
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Course { get; set; }
        public List<SubjectModel>? Subjects { get; set; }

        public StudentModel()
        {
            Subjects = [];
        }

        public StudentModel(int id, string name, string surname, string course)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Course = course;
            Subjects = [];
        }

        public StudentModel(int id, string name, string surname, string course, List<SubjectModel> subjects)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Course = course;
            Subjects = subjects;
        }
    }
}
