using estacionamento.models;

namespace estacionamento_teste;

public class VeiculoTestes
{   
    [Fact]
    public void TestaVeiculoAcelerar()
    {
        //Arrange
        Veiculo veiculo = new Veiculo();
        
        //Act
        veiculo.Acelerar(10);
        
        //Assert
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }
    
    [Fact]
    public void TestaVeiculoFrear()
    {
        //Arrange
        Veiculo veiculo = new Veiculo();
        
        //Act
        veiculo.Frear(10);
        
        //Assert
        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }
    
    [Fact]
    public void TestaVeiculoTipoVeiculoCasoSejaNull()
    {
        //Arrange
        Veiculo veiculo = new Veiculo();
        
        //Act
        //TODO veiculo recebeu null comodo padrão
        
        //Assert
        Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
    }
    
    [Fact]
    public void TestaVeiculoTipoVeiculoCasoOvalorSejaPassado()
    {
        //Arrange
        Veiculo veiculo = new Veiculo();
        
        //Act
        veiculo.Tipo = TipoVeiculo.Motocicleta;
        
        //Assert
        Assert.Equal(TipoVeiculo.Motocicleta, veiculo.Tipo);
    }
    
}