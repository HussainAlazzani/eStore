using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// This base class is used so that all our entities be of this type.
    /// This will become useful when we make use of a generic repository and specification.
    /// </summary>
    public class BaseEntity
    {
        public int Id { get; set; }
    }
}
