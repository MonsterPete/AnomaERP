using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class user_loginEntity
    {
        public Int32 branch_id { get; set; }
        public String branch_name { get; set; }

        public Int32 entity_id { get; set; }
        public String entity_name { get; set; }

        public String username { get; set; }
        public String password { get; set; }
        public String Role { get; set; }
    }
}
