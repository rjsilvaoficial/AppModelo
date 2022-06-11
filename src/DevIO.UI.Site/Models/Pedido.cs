using System;

namespace DevIO.UI.Site.Models
{
    public class Pedido
    {
        public Pedido()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

    }
}
