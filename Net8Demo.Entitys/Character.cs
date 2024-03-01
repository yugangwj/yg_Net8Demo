using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net8Demo.Entitys
{
    public class Character
    {
        public Guid Id { get; set; }

        public String NickName { get; set; } = null!;

        public String Classes { get; set; }= null!;

        public int Leave { get; set; }

        public DateTime DateCreated { get; set; }


        public Guid PlayerId { get; set; }

        public Player Player { get; set; } = null!;
    }
}
