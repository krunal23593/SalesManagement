
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SalesManagement.Data
{

using System;
    using System.Collections.Generic;
    
public partial class Order
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Order()
    {

        this.Sales = new HashSet<Sale>();

    }


    public int Id { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public System.Guid TransactionId { get; set; }

    public decimal TotalCost { get; set; }

    public System.DateTime OrderDate { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Sale> Sales { get; set; }

    public virtual Product Product { get; set; }

    public virtual Order_Details Order_Details { get; set; }

}

}
