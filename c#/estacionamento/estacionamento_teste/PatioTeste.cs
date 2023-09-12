using estacionamento_teste.data;
using estacionamento.models;

namespace estacionamento_teste;

public class PatioTeste
{
    

    [Fact(DisplayName = "Valida o faturamento")]
    public void ValidarFaturamento()
    {
        //Arrange
        Patio estacionamento = new Patio();
        Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = "Wesley";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Cor = "Vermelho";
        veiculo.Modelo = "Ferrari";
        veiculo.Placa = "ABC-9999";
        
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
        
        //Act
        double faturamento = estacionamento.TotalFaturado();
        
        //Assert
        Assert.Equal(2,faturamento);

    }
    
    //TODO PARA TESTAR  UM CONJUNTO DE DADOS EM UM MESMO TESTE UTILIZANDO CLASS DATA
    [Theory(DisplayName = "Valida o faturamento com varios automoveis utilizando class data")]
    [ClassData(typeof(VeiculoData))]
    public void ValidarFaturamentoComVariosVeiculosAutomovelUtilizandoClassData(Veiculo veiculoTeste)
    {
        //Arrange
        Patio estacionamento = new Patio();
        Veiculo veiculo = veiculoTeste;
        
        
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa!);
        
        //Act
        double faturamento = estacionamento.TotalFaturado();
        
        //Assert
        Assert.Equal(2,faturamento);
    }
    
    //TODO PARA TESTAR  UM CONJUNTO DE DADOS EM UM MESMO TESTE
    [Theory(DisplayName = "Valida o faturamento com varios automoveis")]
    [InlineData("Wesley", "ABC-1234", "Preto","Ferrari")]
    [InlineData("Leticia", "ABD-1234", "Vermelho","Ferrari")]
    public void ValidarFaturamentoComVariosVeiculosAutomovel(string propriedade, string placa,
        string cor, string modelo)
    {
        //Arrange
        Patio estacionamento = new Patio();
        Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = propriedade;
        veiculo.Cor = cor;
        veiculo.Modelo = modelo;
        veiculo.Placa = placa;
        
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
        
        //Act
        double faturamento = estacionamento.TotalFaturado();
        
        //Assert
        Assert.Equal(2,faturamento);
    }

    [Fact(DisplayName = "Valida a busca do veiculo no patio")]
    public void LocalizaVeiculoNoPatio()
    {
        //Arrange
        Patio estacionamento = new Patio();
        Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = "Wesley";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Cor = "Vermelho";
        veiculo.Modelo = "Ferrari";
        veiculo.Placa = "ABC-9999";
        
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        
        //Act
        Veiculo? consulta = estacionamento.PesquisarVeiculo(veiculo.Placa);
        
        //Assert
        Assert.NotNull(consulta);
        Assert.Equal(veiculo.Placa, consulta?.Placa);
    }

    [Fact(DisplayName = "Testa metodo de alterar dados do veiculo")]
    public void TestaAlterarDadosVeiculo(){
        Patio estacionamento = new Patio();
        Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = "Wesley";
        veiculo.Cor = "Vermelho";
        veiculo.Modelo = "Ferrari";
        veiculo.Placa = "ABC-9999";
        
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        
        Veiculo veiculoAlterado = new Veiculo();
        veiculoAlterado.Placa = veiculo.Placa;
        veiculoAlterado.Proprietario = "Wesley Leôncio";
        veiculoAlterado.Cor = "Verde";
        veiculoAlterado.Modelo = "Ferrari";
        
        //Act 
        Veiculo? alterado = estacionamento.AlterarDadosVeiculo(veiculoAlterado);
        
        //Assert
        Assert.NotNull(alterado);
        Assert.Equal(veiculoAlterado.Proprietario, alterado?.Proprietario);
        Assert.Equal(veiculoAlterado.Cor, alterado?.Cor);
        Assert.Equal(veiculoAlterado.Modelo, alterado?.Modelo);
    }
   
    
    [Fact(DisplayName = "Valida se o nome do proprietario está no formato correto",
        Skip = "Teste ainda não implementado")]
    public void ValidaNomeProprietario()
    {
        
    }
}