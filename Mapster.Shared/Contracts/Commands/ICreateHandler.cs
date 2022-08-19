using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Shared.Contracts.Commands
{
    public interface ICreateHandler<Entity> where Entity : class
    {
        public void Handle(Entity entity);
    }
}
