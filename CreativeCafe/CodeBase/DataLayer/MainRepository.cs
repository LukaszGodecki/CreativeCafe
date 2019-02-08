using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CreativeCafe.CodeBase.DataLayer
{
  public class MainRepository
  {
    public static string DefaultConnectionString { get { return ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString; } }
  }
}
