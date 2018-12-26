using CreativeCafe.CodeBase.ServiceLayer.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativeCafe.CodeBase.ServiceLayer.Service
{
  public static partial class MainService
  {
    #region handleCommand
    public static void handleCommand(ICommand command)
    {
      try
      {
        command.Execute();
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc);
        throw;
      }
    }
    #endregion handleCommand
  }
}
