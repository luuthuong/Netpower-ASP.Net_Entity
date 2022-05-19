﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netpower.Intern2022.Entities.Model
{
    public class Role
    {
        public string Name { get; set; }
    }
    [Table("ROLE")]
    public class RoleModel : Role
    {
        public Guid ID { get; set; }
    }
}