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
    
    public partial class subempresas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public subempresas()
        {
            this.contratos = new HashSet<contratos>();
        }
    
        public int Sub_Id { get; set; }
        public string Sub_Nom { get; set; }
        public Nullable<int> Sub_Cant { get; set; }
        public int Emp_Id { get; set; }
        public string Sub_Estado { get; set; }
        public string Sub_Dir { get; set; }
        public int Com_Id { get; set; }
    
        public virtual comunas comunas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contratos> contratos { get; set; }
        public virtual empresas empresas { get; set; }
    }
}
