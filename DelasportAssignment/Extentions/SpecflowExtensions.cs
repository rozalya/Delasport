using DelasportAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DelasportAssignment.Extentions
{
   public static class SpecflowExtensions
    {
        public static RegisterUser ChangeValues(Table table, DataContex dataContext)
        {
            var obj = dataContext.RegisterUser;
            foreach (var row in table.Rows)
            {
                foreach (var item in row)
                {
                    PropertyInfo pi = obj.GetType().GetProperty(item.Key);
                    pi.SetValue(obj, item.Value);
                }

            }
            return obj;
        }
    }
}
