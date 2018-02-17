using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace App_ToLend.Models
{
    public class TolendItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Rendered { get; set; }
        public string Rendered_anim { get; set; }
        public string DateSelected { get; set; }
        public string Photo { get; set; }
        
    }
}
