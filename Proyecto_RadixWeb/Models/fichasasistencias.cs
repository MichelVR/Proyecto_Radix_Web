//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_RadixWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class fichasasistencias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fichasasistencias()
        {
            this.personas = new HashSet<personas>();
        }
    
        public int FAsi_Id { get; set; }
        public Nullable<int> FAsi_CanD { get; set; }
        public byte[] FAsi_Dia { get; set; }
        public Nullable<int> FAsi_CanS { get; set; }
        public Nullable<int> FAsi_CanM { get; set; }
        public Nullable<int> FAsi_CanH { get; set; }
        public string Cos_Id { get; set; }
        public Nullable<System.DateTime> FAsi_Fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personas> personas { get; set; }
    }
}
