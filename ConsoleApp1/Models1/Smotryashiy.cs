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
    
    public partial class Smotryashiy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Smotryashiy()
        {
            this.Smena = new HashSet<Smena>();
        }
    
        public int ID_Smotryashiy { get; set; }
        public Nullable<int> ID_Sotrudnik { get; set; }
        public string Imya_naznachivshego { get; set; }
        public string Familiya_naznachivshego { get; set; }
        public string Otchestvo_naznachivshego { get; set; }
        public Nullable<System.DateTime> Data_naznacheniya { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Smena> Smena { get; set; }
        public virtual Sotrudnik Sotrudnik { get; set; }
    }
}
