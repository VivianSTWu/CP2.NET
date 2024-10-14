using System.ComponentModel.DataAnnotations;

namespace CP2.API.Application.Dtos
{
    public class FornecedorDto
    {
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(Cnpj)} é obrigatório")]
        public string Cnpj { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(Telefone)} é obrigatório")]
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(Email)} é obrigatório")]
        public string Email { get; set; } = string.Empty;
        public DateTime CriadoEm { get; set; }
    }
}
