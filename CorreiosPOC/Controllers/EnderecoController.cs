using CorreiosPOC.Models;
using CorreiosPOC.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorreiosPOC.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepository _repositorio;

        public EnderecoController(IEnderecoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("v1/GetCEPCorreios")]
        public IActionResult GetCEPCorreios(string cep)
        {
            var correios = new ServiceReferenceCorreios.AtendeClienteClient();

            try
            {
                var consulta = correios.consultaCEPAsync(cep.Replace("-", "")).Result;
                if (consulta.@return != null)
                {
                    var res = new Endereco()
                    {
                        cep = cep,
                        endereco = consulta.@return.end,
                        complemento = consulta.@return.complemento2,
                        bairro = consulta.@return.bairro,
                        cidade = consulta.@return.cidade,
                        uf = consulta.@return.uf
                    };

                    return Ok(res);
                }
            }
            catch
            {
                return NotFound();
            }

            return NotFound();
        }

        [HttpGet("v1/ListaEnderecos")]
        public IActionResult ListarEnderecos()
        {
            return Ok(_repositorio.ListarEnderecos());
        }

        [HttpPost("v1/AdicionarEndereco")]
        public IActionResult AdicionarEndereco([FromBody]dynamic json)
        {
            Endereco endereco = new Endereco()
            {
                cep = json.cep,
                bairro = json.bairro,
                cidade = json.cidade,
                complemento = json.complemento,
                endereco = json.endereco,
                uf = json.uf
            };

            if (endereco != null)
            {
                _repositorio.Adicionar(endereco);
                return Ok();
            }

            return NotFound();
        }

        [HttpPut("v1/EditarEndereco/{endereco}")]
        public IActionResult EditarEndereco(int endereco, [FromBody]dynamic json)
        {
            var end = _repositorio.ObterPorId(endereco);

            if (end == null)
            {
                return NotFound();
            }

            end.bairro = json.bairro;
            end.cep = json.cep;
            end.cidade = json.cidade;
            end.complemento = json.complemento;
            end.endereco = json.endereco;
            end.uf = json.uf;

            _repositorio.Editar(end);

            return Ok();
        }

        [HttpDelete("v1/RemoverEndereco/{endereco}")]
        public IActionResult RemoverEndereco(int endereco)
        {
            var end = _repositorio.ObterPorId(endereco);

            if (end == null)
            {
                return NotFound();
            }

            _repositorio.RemoverEndereco(end);

            return Ok();
        }
    }
}
