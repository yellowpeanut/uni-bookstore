//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public decimal Id { get; set; }
        public decimal CatalogId { get; set; }
        public decimal BookId { get; set; }
        public decimal Quantity { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Store Store { get; set; }
    }
}