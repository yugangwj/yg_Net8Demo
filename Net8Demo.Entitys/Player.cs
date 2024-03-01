using System.Collections;
using System.Data;

namespace Net8Demo.Entitys
{
    public class Player
    {
        public Guid Id { get; set; }

        public String Account { get; set; } = null!;

        public String AccountType { get; set; } = null!;

        public DateTime DateCreated { get; set; }

        public ICollection<Character> Characters { get; set; } = null!;

        public Player()
        {
            DateCreated = DateTime.Now;
        }
    }
}
