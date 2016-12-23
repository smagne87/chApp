using chApp.DAL.Models.DataModelTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static chApp.DAL.Models.DataModel;

namespace chApp.BLL
{
    public class BaseBL
    {
        protected bool HasTableRowData(DataTable table)
        {
            return table.Rows.Count > 0;
        }
    }
}