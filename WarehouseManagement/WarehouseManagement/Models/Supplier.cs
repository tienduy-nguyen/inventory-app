//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WareHouseManagement.Models
{
    using System;
    using System.Collections.Generic;
    using WarehouseManagement.ViewModel;

    public partial class Supplier: BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            this.Objects = new HashSet<Object>();
        }
    
        public int Id { get; set; }
        private string displayName;
        public string DisplayName { get =>displayName; set { displayName = value; OnPropertyChanged(); } }

        private string address;
        public string Address { get => address; set { address = value; OnPropertyChanged(); } }

        private string phone;
        public string Phone { get => phone; set { phone = value; OnPropertyChanged(); } }

        private string mail;
        public string Mail { get => mail; set { mail = value; OnPropertyChanged(); } }

        private string moreInfo;
        public string MoreInfo { get => moreInfo; set { moreInfo = value; OnPropertyChanged(); } }

        private DateTime? contractDate;
        public Nullable<System.DateTime> ContractDate { get => contractDate; set { contractDate = value; OnPropertyChanged(); } }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Object> Objects { get; set; }
    }
}
