using ctBank.entidades;
using ctbanks.Repositors.DTO;
using ctbanks.Repositors;

public interface Icontapoupancaservice
{
     void Adicionar(ContaPoupanca contspoupsncs);


     void Remover(int id);


     List<ContaPoupanca> Listar();


     List<ContaPoupanca> BuscarPorVeiculoId(int id);


     ContaPoupanca BuscarPorId(int id);

}

