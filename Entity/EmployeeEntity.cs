using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class EmployeeEntity
    {
        public Int32 employee_id { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String nickname { get; set; }
        public String gender { get; set; }
        public DateTime date_of_birth { get; set; }
        public String citizen_id { get; set; }
        public Int32 position_id { get; set; }
        public Int32 working_time_id { get; set; }
        public Int32 create_by { get; set; }
        public DateTime create_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
