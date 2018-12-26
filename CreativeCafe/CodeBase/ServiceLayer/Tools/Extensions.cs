using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CreativeCafe.CodeBase.ServiceLayer.Tools
{
  public static class Extensions
  {
    public static bool HasColumn(this IDataRecord dataRecord, string searchedColumnName)
    {
      bool HasSearchedColumn = false;
      for (int iterator = 0, DataReaderFieldsCount = dataRecord.FieldCount; iterator < DataReaderFieldsCount; iterator++)
      {
        string currentIterationColumnName = dataRecord.GetName(iterator);
        if (currentIterationColumnName.Equals(searchedColumnName, StringComparison.InvariantCultureIgnoreCase))
        {
          HasSearchedColumn = true;
          break;
        }
      }
      return HasSearchedColumn;
    }
  }
}