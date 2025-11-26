using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaonPointWindowsForms.Entities.Model
{
    public class ClassSchedule
    {

        public int id { get; set; }
        public int type_id { get; set; }
        public int trainer_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public int max_capacity { get; set; }

    }
}
