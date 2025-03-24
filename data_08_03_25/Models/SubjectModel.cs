using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_08_03_25.Abstractions;

namespace data_08_03_25.Models
{
    public class SubjectModel : IModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public MarkModel? Mark { get; set; }

        public SubjectModel()
        {
            Mark = new MarkModel();
        }

        public SubjectModel(int id, string name)
        {
            Id = id;
            Name = name;
            Mark = new MarkModel();
        }

        public SubjectModel(int id, string name, MarkModel mark)
        {
            Id = id;
            Name = name;
            Mark = mark;
        }
    }
}
