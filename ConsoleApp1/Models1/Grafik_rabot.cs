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
    
    public partial class Grafik_rabot
    {
        public int ID_Grafik_rabot { get; set; }
        public Nullable<int> ID_Smena { get; set; }
        public Nullable<int> ID_Sotrudnik { get; set; }
    
        public virtual Smena Smena { get; set; }
        public virtual Sotrudnik Sotrudnik { get; set; }
    }
}