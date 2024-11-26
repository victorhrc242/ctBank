using ctBank.entidades;  
using ctbanks.Repositors.DTO;
using ctbanks.Repositors.Interfaces;
using Microsoft.Extensions.Configuration;

namespace ctbanks.service
{
    public class contaservicepoupanca:Icontapoupancaservice
    {
        private readonly Icontas icontasrepositor;
        private readonly IContapoupanca _contapoupanca;
        private readonly IConfiguration _configuration;

        public contaservicepoupanca(IContapoupanca contapoupanca, Icontas icontas, IConfiguration configuration)
        {
            icontasrepositor = icontas;
            _configuration = configuration;
            _contapoupanca = contapoupanca;
        }

        public void Adicionar(ContaPoupanca contspoupsncs)
        {
            conta conts = new conta()
            {
                Saldo = contspoupsncs.Saldo,
                Titular = contspoupsncs.Titular,
            };
            icontasrepositor.Adicionar(conts);
            contapopancaDTO c = new contapopancaDTO()
            {
                IdConta = conts.id,
                TaxaDeJuros = contspoupsncs.TaxaDeJuros
            };
            long id = _contapoupanca.Adicionar(c);
        }

        public void Remover(int id)
        {
            _contapoupanca.Remover(id);
        }

        public List<ContaPoupanca> Listar()
        {
            return _contapoupanca.Listar();
        }

        public List<ContaPoupanca> BuscarPorVeiculoId(int id)
        {
            var veiculo = icontasrepositor.BuscarPorId(id);

            if (veiculo == null)
                return new List<ContaPoupanca>();

            var contapoupanca = _contapoupanca.BuscarPorId(id);

            if (contapoupanca == null)
                return new List<ContaPoupanca>();


            return new List<ContaPoupanca>
            {
                new ContaPoupanca
                {
                    id = veiculo.id,
                    Saldo = veiculo.Saldo,
                    Titular = veiculo.Titular,
                    TaxaDeJuros = contapoupanca.TaxaDeJuros,
                }
            };
        }

        public ContaPoupanca BuscarPorId(int id)
        {
            return _contapoupanca.BuscarPorId(id);
        }
    }
}
