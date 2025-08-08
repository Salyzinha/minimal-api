using System.ComponentModel.DataAnnotations;

namespace MinimalApi.DTOs
{
    public record VeiculoDTO
    {
        [Required(ErrorMessage = "O nome do veículo é obrigatório.")]
        [StringLength(150, ErrorMessage = "O nome do veículo deve ter no máximo 150 caracteres.")]
        public string Nome { get; init; } = string.Empty;

        [Required(ErrorMessage = "A marca do veículo é obrigatória.")]
        [StringLength(100, ErrorMessage = "A marca do veículo deve ter no máximo 100 caracteres.")]
        public string Marca { get; init; } = string.Empty;

        [Required(ErrorMessage = "O ano do veículo é obrigatório.")]
        [Range(1951, 2100, ErrorMessage = "Aceitamos veículos apenas a partir de 1951.")]
        public int Ano { get; init; }
    }
}

