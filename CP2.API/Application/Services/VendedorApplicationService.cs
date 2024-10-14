using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;

namespace CP2.API.Application.Services
{
    public class VendedorApplicationService : IVendedorApplicationService
    {
        private readonly IVendedorRepository _repository;

        public VendedorApplicationService(IVendedorRepository repository)
        {
            _repository = repository;
        }
        public VendedorEntity? DeletarDadosVendedor(int id)
        {
            return _repository.DeletarDados(id);
        }

        public VendedorEntity? EditarDadosVendedor(int id, VendedorDto entity)
        {
            var vendedor = new VendedorEntity
            {
                Id = id,
                Nome = entity.Nome,
                Email = entity.Email,
                Telefone = entity.Telefone,
                DataNascimento = entity.DataNascimento,
                Endereco = entity.Endereco,
                DataContratacao = entity.DataContratacao,
                ComissaoPercentual = entity.ComissaoPercentual,
                MetaMensal = entity.MetaMensal,
                CriadoEm = entity.CriadoEm
            };
            return _repository.EditarDados(vendedor);
        }

        public IEnumerable<VendedorEntity>? ObterTodosVendedores()
        {
            return _repository.ObterTodos();
        }

        public VendedorEntity? ObterVendedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public VendedorEntity? SalvarDadosVendedor(VendedorDto entity)
        {
            var vendedor = new VendedorEntity
            {
                Nome = entity.Nome,
                Email = entity.Email,
                Telefone = entity.Telefone,
                DataNascimento = entity.DataNascimento,
                Endereco = entity.Endereco,
                DataContratacao = entity.DataContratacao,
                ComissaoPercentual = entity.ComissaoPercentual,
                MetaMensal = entity.MetaMensal,
                CriadoEm = entity.CriadoEm
            };
            return _repository.SalvarDados(vendedor);
        }
    }
}
