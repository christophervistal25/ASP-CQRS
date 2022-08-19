using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Shared.Contracts.Queries
{
    public interface IGetAllHandler<Entity> where Entity : class
    {
        public IEnumerable<Entity> GetAll();
    }
}
