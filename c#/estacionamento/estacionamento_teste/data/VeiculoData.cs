using System.Collections;
using estacionamento.models;

namespace estacionamento_teste.data;

public class VeiculoData: IEnumerable<object[]>
{
    private List<Veiculo> ListaVeiculos()
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        veiculos.Add(new Veiculo{Proprietario="Wesley",Placa="ABC-9999",Cor = "Verde", Modelo = "Ferrari"});
        veiculos.Add(new Veiculo{Proprietario="Neuza",Placa="ABD-9999",Cor="Vermelha",Modelo="Fusca"});
        veiculos.Add(new Veiculo{Proprietario="Geraldo",Placa="ABE-9999",Cor="Azul",Modelo="Fusca"});
        veiculos.Add(new Veiculo{Proprietario="Leticia",Placa="ABF-9999",Cor="Rosa",Modelo="Fusca"});
        return veiculos;
    }
    
    private IEnumerator<object[]> GerarData(List<Veiculo> veiculos)
    {
        List<object[]> data = new List<object[]>();
        foreach (Veiculo veiculo in veiculos)
        {
            data.Add(FactoryVeiculoArray(veiculo));
        }

        return data.GetEnumerator();
    }
    
    
    public IEnumerator<object[]> GetEnumerator()
    {
        return this.GerarData(ListaVeiculos());
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private static object[] FactoryVeiculoArray(Veiculo veiculo)
    {
        return new object[]
        {
            veiculo
        };
    }
    
    
}