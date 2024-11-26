using ctBank.entidades;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
   
    public class contacorrentecontroller
    {
        private readonly Icontacorrentservice _icontacorrenteservice;
        public contacorrentecontroller(Icontacorrentservice icontacorrentservice, IConfiguration config)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _icontacorrenteservice= icontacorrentservice;
        }
        [HttpPost("adicionar-conta")]
        public void Adicionar(ContaCorrente contacorrente)
        {
            _icontacorrenteservice.Adicionar(contacorrente);
        }
        [HttpDelete("delete-conta")]
       public void Remover(int id)
        {
            _icontacorrenteservice.Remover(id);
        }
        [HttpGet("listar-contas")]
       public List<ContaCorrente> Listar()
        {
          return _icontacorrenteservice.Listar();
        }

        [HttpGet("listar-conta-por-id")]
        public List<ContaCorrente> BuscarPorVeiculoId(int id)
        {
            return _icontacorrenteservice.BuscarPorVeiculoId(id);
        }

    }
}
