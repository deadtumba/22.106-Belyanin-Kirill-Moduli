//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.Models1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pasport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pasport()
        {
            this.Sotrudnik = new HashSet<Sotrudnik>();
        }
    
        public int ID_Pasport { get; set; }
        public string Imya { get; set; }
        public string Familiya { get; set; }
        public string Otchestvo { get; set; }
        public Nullable<System.DateTime> Data_rozhdenia { get; set; }
        public Nullable<System.DateTime> Data_vidachy { get; set; }
        public string Kem_vidan { get; set; }
        public Nullable<int> Nomer { get; set; }
        public Nullable<int> Seria { get; set; }
        public Nullable<int> ID_Propiska { get; set; }
        public Nullable<int> ID_Pol { get; set; }
    
        public virtual Pol Pol { get; set; }
        public virtual Propiska Propiska { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sotrudnik> Sotrudnik { get; set; }
    }
}
