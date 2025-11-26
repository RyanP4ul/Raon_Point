using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaonPointWindowsForms.Entities.Model
{
    public class Member
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string plans { get; set; }
        public DateTime joining_date { get; set; }
        public DateTime expiration_date { get; set; }
        public DateTime check_out_date { get; set; }
        public DateTime check_in_date { get; set; }
        public bool is_verified { get; set; }
        public int check_in_count { get; set; }
        public DateTime created_at { get; set; }
    }
}
