using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Configurations
{
    internal class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
           builder.Ignore(x=>x.ID);

            builder.HasKey(x=>new { x.OrderId, x.ProductId });

            builder.HasOne(x => x.Product)
                .WithMany(x=>x.OrderDetails)
                .HasForeignKey(x => x.ProductId);

        }
    }
}
