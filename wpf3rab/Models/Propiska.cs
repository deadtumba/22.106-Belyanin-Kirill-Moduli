//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpf3rab.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Propiska
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Propiska()
        {
            this.Pasport = new HashSet<Pasport>();
        }
    
        public int ID_Propiska { get; set; }
        public string Region { get; set; }
        public string Rayon { get; set; }
        public string Punkt { get; set; }
        public string Ulitca { get; set; }
        public string Dom { get; set; }
        public Nullable<System.DateTime> Data_registracii { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pasport> Pasport { get; set; }
    }
}