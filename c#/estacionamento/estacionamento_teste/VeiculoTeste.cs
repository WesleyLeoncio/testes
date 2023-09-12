using estacionamento.models;

namespace estacionamento_teste;

public class VeiculoTestes
{   
    [Fact(DisplayName = "Testa o metodo acelerar do veiculo")]
    [Trait("Funcionalidade", "Acelerar")] //TODO AGRUPA OS TESTE UTILIZANDO CHAVE E VALOR
    public void TestaVeiculoAcelerar()
    {
        //Arrange
        Veiculo veiculo = new Veiculo();
        
        //Act
        veiculo.Acelerar(10);
        
        //Assert
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }
    
    [Fact(DisplayName = "Testa o metodo frear do veiculo")]
    [Trait("Funcionalidade", "Frear")]
    public void TestaVeiculoFrear()
    {
        //Arrange
        Veiculo veiculo = new Veiculo();
        
        //Act
        veiculo.Frear(10);
        
        //Assert
        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }
    
    [Fact(DisplayName = "Valida se o tipo do veiculo é null")]
    public void TestaVeiculoTipoVeiculoCasoSejaNull()
    {
        //Arrange
        Veiculo veiculo = new Veiculo();
        
        //Act
        //TODO veiculo recebeu null comodo padrão
        
        //Assert
        Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
    }
    
    [Fact(DisplayName = "Valida se o tipo do veiculo foi passado")]
    public void TestaVeiculoTipoVeiculoCasoOvalorSejaPassado()
    {
        //Arrange
        Veiculo veiculo = new Veiculo();
        
        //Act
        veiculo.Tipo = TipoVeiculo.Motocicleta;
        
        //Assert
        Assert.Equal(TipoVeiculo.Motocicleta, veiculo.Tipo);
    }

    [Fact(DisplayName = "Testar se a ficha do veiculo está funcionando corretamente")]
    public void TestarDadosFichaVeiculo()
    {
        //Arrange
        Veiculo carro = new Veiculo();
        carro.Proprietario = "Wesley";
        carro.Tipo = TipoVeiculo.Automovel;
        carro.Cor = "Vermelho";
        carro.Modelo = "Ferrari";
        carro.Placa = "ABC-9999";
        
        //Act
        string dadosFicha = carro.ToString();
        
        //Assert 
        Assert.Contains("Ficha do Veiculo:", dadosFicha);
    }
    
}