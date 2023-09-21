﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apis_web_services_projeto_reciclaí.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required]
        public Perfil Perfil { get; set; }

        public TipoLixo TipoLixo { get; set; } 

    }

    public enum Perfil
    {
        Solicitante,
        Coletor
    }

    public enum TipoLixo
    {
        Eletrodomestico,
        Eletroportateis,
        Monitores,
        Iluminacao,
        Fios_cabos,
        Pilhas_baterias,
        Ti_telecomunicacao,
        Paineis_fotovoltaicos
    }
}
