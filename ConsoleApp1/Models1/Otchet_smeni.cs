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
    
    public partial class Otchet_smeni
    {
        public int ID_Otchet_smeni { get; set; }
        public Nullable<int> ID_Smeni { get; set; }
        public Nullable<int> ID_Metalla { get; set; }
        public string Kolichestvo_dobitogo_metalla { get; set; }
        public Nullable<int> Kolichestvo_rabotnikov { get; set; }
    
        public virtual Metalli Metalli { get; set; }
        public virtual Smena Smena { get; set; }
    }
}
