using ctBank.entidades;

public interface Icontacorrentservice
{
     void Adicionar(ContaCorrente contacorrente);

     void Remover(int id);

     List<ContaCorrente> Listar();


     List<ContaCorrente> BuscarPorVeiculoId(int id);


}



