using CorreiosPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorreiosPOC.Repositories
{
    public interface IEnderecoRepository
    {
        IEnumerable<Endereco> ListarEnderecos();
        void Adicionar(Endereco endereco);
        void Editar(Endereco endereco);
        Endereco ObterPorId(int id);
        void RemoverEndereco(Endereco endereco);
    }
}
