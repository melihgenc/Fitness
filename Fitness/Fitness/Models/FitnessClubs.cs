//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fitness.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FitnessClubs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FitnessClubs()
        {
            this.PersonelTrainers = new HashSet<PersonelTrainers>();
        }
    
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Nullable<int> ClubOwnerId { get; set; }
    
        public virtual FitnessClubOwners FitnessClubOwners { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonelTrainers> PersonelTrainers { get; set; }
    }
}
