using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WSAuto.Models
{
    [Table("Vehiculo")]
    public class Auto
    {
        public int AutoId { get; set; }

        [Required]//campo obligatorio - DB: NOT NULL
        [Column(TypeName = "varchar(50)")]//tipo de datos de sql server
       // [StringLength(50)]//longitud máxima de la cadena 

        public string Marca { get; set; }

        [Required]//campo obligatorio - DB: NOT NULL
        [Column(TypeName = "varchar(50)")]//tipo de datos de sql server
                                          // [StringLength(50)]//longitud máxima de la cadena 

        public string Modelo { get; set; }



        [Column(TypeName = "varchar(20)")]//tipo de datos de sql server
                                          // [StringLength(50)]//longitud máxima de la cadena 

        public string Color { get; set; }


        [Required]//campo obligatorio - DB: NOT NULL
        [Column(TypeName = "money")]
        public decimal Precio { get; set; }


    }
}
