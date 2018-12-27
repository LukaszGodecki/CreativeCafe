using CreativeCafe.CodeBase.DataLayer.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativeCafe.CodeBase.ServiceLayer.Service
{
  public static partial class MainService
  {
    #region handleQuery
    public static T handleQuery<T>(IQuery<T> query)
    {
      try
      {
        return query.Execute();
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc);
        throw;
      }
    }
    #endregion handleQuery
  }
}
