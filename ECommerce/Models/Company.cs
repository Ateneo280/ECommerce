using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Display(Name = "Nombre de la Empresa")]
        [Index("IX_CompanyName", IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [NotMapped]
        [Display(Name = "Logo de la Empresa")]
        public HttpPostedFileBase LogoFile { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar un {0}.")]
        [Display(Name = "Departamento")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar una {0}.")]
        [Display(Name = "Ciudad")]
        public int CityId { get; set; }


        public virtual Department Department { get; set; }


        public virtual City City { get; set; }
    }
}