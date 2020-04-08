using CorreiosPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorreiosPOC.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly Context _context;

        public EnderecoRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Endereco> ListarEnderecos()
        {
            var lista = _context.Endereco.ToList();
            return lista;
        }

        public void Adicionar(Endereco endereco)
        {
            _context.Endereco.Add(endereco);
            _context.SaveChanges();
        }

        public void Editar(Endereco endereco)
        {
            _context.Endereco.Update(endereco);
            _context.SaveChanges();
        }        

        public Endereco ObterPorId(int id)
        {
            return _context.Endereco.Find(id);             
        }

        public void RemoverEndereco(Endereco endereco)
        {
            _context.Endereco.Remove(endereco);
            _context.SaveChanges();
        }
    }
}
