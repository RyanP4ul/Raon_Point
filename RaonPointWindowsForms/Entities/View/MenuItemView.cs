using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaonPointWindowsForms.Entities.View
{
    public class MenuItemView
    {
        public string Title { get; set; }
        public Image Image { get; set; }
        public Action Action { get; set; }
    }
}
