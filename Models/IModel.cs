using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IModel
    {
        DateTime InsertDate { get; set; }
        DateTime UpdateDate { get; set; }
    }
}
