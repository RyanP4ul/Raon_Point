using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaonPointWindowsForms.Entities.Model
{
    public class Membership
    {

        public int id { get; set; }
        public int member_id { get; set; }
        public string plan { get; set; }
        public DateTime joining_date { get; set; }
        public DateTime expiration_date { get; set; }
    }
}
