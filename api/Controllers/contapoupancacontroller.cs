using ctBank.entidades;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class contapoupancacontroller
    {
        private readonly Icontapoupancaservice _icontacorrenteservice;
        public contapoupancacontroller(Icontapoupancaservice icontacorrentservice, IConfiguration config)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _icontacorrenteservice = icontacorrentservice;
        }
        [HttpPost("adicionar-contapoupanca")]
      public  void Adicionar(ContaPoupanca contspoupsncs)
        {
            _icontacorrenteservice.Adicionar(contspoupsncs);
        }

        [HttpDelete("deletar-conta")]
       public void Remover(int id)
        {
            _icontacorrenteservice.Remover(id);
        }
        [HttpGet("listar")]
      public  List<ContaPoupanca> Listar()
        {
            return _icontacorrenteservice.Listar();
        }

        [HttpGet("listar-contapoupanca")]
      public  List<ContaPoupanca> BuscarPorVeiculoId(int id)
        {
            return _icontacorrenteservice.BuscarPorVeiculoId(id);
        }

    }
}
