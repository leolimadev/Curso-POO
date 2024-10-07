// Exercício: Processamento de Transações Bancárias
// Melhoria 01 - Cada tipo de transação implementa a interface ITransaction. Agora é fácil adicionar novos métodos de pagamento sem modificar a estrutura existente.

public interface ITransaction
{
    void Process();
}

public class BankTransfer : ITransaction
{
    public void Process()
    {
        Console.WriteLine("Processing bank transfer...");
    }
}

public class CreditCardPayment : ITransaction
{
    public void Process()
    {
        Console.WriteLine("Processing credit card payment...");
    }
}

//=========================================================================================

// Exercício: Cálculo de Salários de Funcionários (RH)
// Melhoria 02: O cálculo de salário foi abstraído para que cada tipo de funcionário implemente seu próprio cálculo. 
// A classe base Employee pode ser expandida para novos cargos sem modificar o código existente.

public abstract class Employee
{
    public abstract void CalculateSalary();
}

public class Manager : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Calculating manager salary...");
    }
}

public class Intern : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Calculating intern salary...");
    }
}

//=========================================================================================

// Exercício: Relatórios Financeiros
// Problema: A classe FinancialReport mistura a lógica de diferentes tipos de relatórios, tornando o código difícil de gerenciar e escalar.
// Melhoria: Cada tipo de relatório implementa a interface IReport, permitindo a extensão para novos tipos de relatórios sem impactar o código existente.

public interface IReport
{
    void Generate();
}

public class MonthlyReport : IReport
{
    public void Generate()
    {
        Console.WriteLine("Generating monthly report...");
    }
}

public class YearlyReport : IReport
{
    public void Generate()
    {
        Console.WriteLine("Generating yearly report...");
    }
}




//=========================================================================================
// Exercício: Benefícios de Funcionários
// Problema: A classe Benefits está acoplada a diferentes tipos de benefícios, tornando difícil adicionar novos planos de benefício sem alterar o código.
// Melhoria: Cada benefício é implementado separadamente utilizando a interface IBenefit, permitindo a adição de novos benefícios de forma simples.

public interface IBenefit
{
    void Apply();
}

public class HealthInsurance : IBenefit
{
    public void Apply()
    {
        Console.WriteLine("Applying health insurance...");
    }
}

public class PensionPlan : IBenefit
{
    public void Apply()
    {
        Console.WriteLine("Applying pension plan...");
    }
}

//=========================================================================================
// Exercício: Empréstimos Bancários
// Problema: A classe Loan está acoplada a diferentes tipos de empréstimos, o que torna difícil escalar o código para novos tipos de empréstimos.
// Melhoria: A classe Loan foi tornada abstrata, permitindo que cada tipo de empréstimo tenha sua própria implementação. 
// Isso facilita a adição de novos tipos de empréstimos sem modificar a lógica existente.

public abstract class Loan
{
    public abstract void Calculate();
}

public class PersonalLoan : Loan
{
    public override void Calculate()
    {
        Console.WriteLine("Calculating personal loan...");
    }
}

public class Mortgage : Loan
{
    public override void Calculate()
    {
        Console.WriteLine("Calculating mortgage...");
    }
}
