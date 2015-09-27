using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Collections;
using MVCWebApp.Models;
using System.Data.SqlClient;


namespace Helpers
{
    public class CombosHelper 
    {
        private CombosHelper() {}
        private DatabaseEntities db = new DatabaseEntities();
        
        #region ComboBox GENDER
        public static SelectList BuildComboGender(string gender)
        {
            SelectList selectedList;
            IList<SelectListItem> lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "F", Text = "Female" });
            lista.Add(new SelectListItem() { Value = "M", Text = "Male" });
            
            if (!string.IsNullOrEmpty(gender) && gender.Trim() != "")
                return selectedList = new SelectList(lista, "Value", "Text", gender);
            else 
                return selectedList = new SelectList(lista, "Value", "Text");
        }
        #endregion

    }
}
