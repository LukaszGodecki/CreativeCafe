using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCafe.CodeBase.DataLayer.Queries
{
  public interface IQuery<T>
  {
    T Execute();
  }
}
