using System;

public class RegistroExtrato {
    private string cpfPessoa;
    private DateTime dataInclusao;
    protected double valorTransacao;
    protected string tipoTransacao; // Aceitar entrada e saida como valores possiveis
}

public class Extrato {
    private string cpfPessoa;
    private string nomePessoa;
    private double valorInicial;
    protected List<RegistroExtrato> movimentacoes;

    public double CalcularSaldo(){
        throw new Exception();
    }
}



