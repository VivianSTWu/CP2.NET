using CP2.API.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace CP2.API.Application.Dtos
{
    public class VendedorDto
    {
        [Required(ErrorMessage = $"Campo {nameof(Nome)} é obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(Email)} é obrigatório")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(Telefone)} é obrigatório")]
        public string Telefone { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; } = string.Empty;
        public DateTime DataContratacao { get; set; }
        public decimal ComissaoPercentual { get; set; }
        public decimal MetaMensal { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
