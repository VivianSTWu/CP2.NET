using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;

namespace CP2.API.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorApplicationService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public FornecedorEntity? DeletarDadosFornecedor(int id)
        {
            return _repository.DeletarDados(id);
        }

        public FornecedorEntity? EditarDadosFornecedor(int id, FornecedorDto entity)
        {
            var fornecedor = new FornecedorEntity
            {
                Id = id,
                Nome = entity.Nome,
                Cnpj = entity.Cnpj,
                Endereco = entity.Endereco,
                Telefone = entity.Telefone,
                Email = entity.Email,
                CriadoEm = entity.CriadoEm
            };
            return _repository.EditarDados(fornecedor);
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            return _repository.ObterTodos();
        }

        public FornecedorEntity? SalvarDadosFornecedor(FornecedorDto entity)
        {
            var fornecedor = new FornecedorEntity
            {
                Nome = entity.Nome,
                Cnpj = entity.Cnpj,
                Endereco = entity.Endereco,
                Telefone = entity.Telefone,
                Email = entity.Email,
                CriadoEm = entity.CriadoEm
            };
            return _repository.SalvarDados(fornecedor);
        }
    }
}
