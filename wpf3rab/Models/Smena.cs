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
    
    public partial class Smena
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Smena()
        {
            this.Grafik_rabot = new HashSet<Grafik_rabot>();
            this.Otchet_smeni = new HashSet<Otchet_smeni>();
        }
    
        public int ID_Smena { get; set; }
        public Nullable<int> ID_Mesta_dobichi { get; set; }
        public Nullable<System.DateTime> Data_nachala { get; set; }
        public Nullable<System.DateTime> Data_konca { get; set; }
        public Nullable<int> ID_Smotryashiy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grafik_rabot> Grafik_rabot { get; set; }
        public virtual Mesta_dobichi Mesta_dobichi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Otchet_smeni> Otchet_smeni { get; set; }
        public virtual Smotryashiy Smotryashiy { get; set; }
    }
}
