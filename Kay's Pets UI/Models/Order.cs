using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Kays_Pets_UI.Models
{
    public class Order
    {

        [DisallowNull]
        public int Id { get; set; }

        public DateTime OrderPlaced { get; set; }
        
        public DateTime? OrderFulfilled { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }

    }
}
