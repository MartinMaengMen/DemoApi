using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Domain.DTO
{
    public class TeamDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaCreacion { get; set; }
        public Team DTOtoEntity()
        {
            Team team = new Team();
            team.Name = Name;
            team.FechaCreacion = FechaCreacion;
            return team;
        }
    }
}
