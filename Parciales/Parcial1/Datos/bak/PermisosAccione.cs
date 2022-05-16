namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PermisosAccione
    {
        public int Id { get; set; }

        public int IdAccion { get; set; }

        public int IdPermiso { get; set; }

        public virtual Accione Accione { get; set; }

        public virtual Permiso Permiso { get; set; }
    }
}
