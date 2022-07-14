using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAspFromScratch
{
    public class User
    {
        [Comment("Primary key :) alert(\"hello\")")]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
