using core_08_03_25.Abstractions;
using data_08_03_25.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core_08_03_25.Entity
{
    public class Student : IEntity, IModelToEntity
    {
        public IEntity ToEntity(IModel model)
        {
            throw new NotImplementedException();
        }
    }
}
