//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Horario
    {
        public int id_cine { get; set; }
        public int id_pelicula { get; set; }
        public Nullable<int> id_tanda { get; set; }
        public Nullable<int> id_sala { get; set; }
    
        public virtual Cine Cine { get; set; }
        public virtual Pelicula Pelicula { get; set; }
        public virtual Sala Sala { get; set; }
        public virtual Tanda Tanda { get; set; }
    }
}