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
    
    public partial class fichadescuentos
    {
        public int Desc_Id { get; set; }
        public string Desc_Nom { get; set; }
        public int TDes_Id { get; set; }
        public float Desc_PorcValor { get; set; }
        public float Desc_ValorMax { get; set; }
        public string Desc_Forma { get; set; }
    
        public virtual tiposdescuentos tiposdescuentos { get; set; }
    }
}
