using ctBank.entidades; 
using ctbanks.Repositors.DTO;
using ctbanks.Repositors.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctbanks.service
{
    public class contacrrentservice:Icontacorrentservice
    {
        private readonly Icontas icontasrepositor;
        private readonly Icontacorrente _contacorrente;
        private readonly IConfiguration _configuration;

        public contacrrentservice(Icontacorrente contacorrente, Icontas icontas, IConfiguration configuration)
        {
            icontasrepositor = icontas;
            _configuration = configuration;
            _contacorrente = contacorrente;
        }

        public void Adicionar(ContaCorrente contacorrente)
        {
            conta conts = new conta()
            {
                Saldo = contacorrente.Saldo,
                Titular = contacorrente.Titular,
            };
            icontasrepositor.Adicionar(conts);  
            contacorrenteDTO c = new contacorrenteDTO()
            {
                IdConta = conts.id,
                LimiteDeCredito = contacorrente.LimiteDeCredito,
            };
            long id = _contacorrente.Adicionar(c);  
        }

        public void Remover(int id)
        {
            _contacorrente.Remover(id);  // Remove conta corrente pelo id
        }

        public List<ContaCorrente> Listar()
        {
            return _contacorrente.Listar();  // Retorna lista de contas correntes
        }

        public List<ContaCorrente> BuscarPorVeiculoId(int id)
        {
            var veiculo = icontasrepositor.BuscarPorId(id);  // Busca a conta (veículo) pelo ID

            if (veiculo == null)
                return new List<ContaCorrente>();  // Se o veículo não for encontrado, retorna uma lista vazia

            var contacorrente = _contacorrente.BuscarPorVeiculoId(id);  // Busca a conta corrente correspondente ao ID do veículo

            if (contacorrente == null)
                return new List<ContaCorrente>();  // Se a conta corrente não for encontrada, retorna uma lista vazia

            return new List<ContaCorrente>
            {
                new ContaCorrente
                {
                    id = veiculo.id,
                    Saldo = veiculo.Saldo,
                    Titular = veiculo.Titular,
                    LimiteDeCredito = contacorrente.LimiteDeCredito,  // Usar LimiteDeCredito da conta corrente
                }
            };
        }

       
    }
}
