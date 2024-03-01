using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net8Demo.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net8Demo.EntityFramework.Mappings
{
    public class PlayerMap : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(player => player.Account).HasMaxLength(50);
            builder.Property(player => player.AccountType).HasMaxLength(10);
            builder.Property(player => player.Account).IsUnicode();
        }
    }
}
