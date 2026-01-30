
using System.Threading.Channels;

public class Conta
{
    
    public int NumIndicartor;
    public string Holder { get; set; }

    public double Balance
    {
        get;
        set
        {
            if (Balance < 0)
            {
                Console.WriteLine("Valor inválido");
            }
            else
            {
                Console.WriteLine("Saldo cadastrado com sucesso");
            }
        }
    }

    public int Password { get; set; }
    public bool ActiveAccont { get; set; }

    private int Choice = -1;
    Random identifierNumber = new Random();

    private string menu = @"
    
    1. Cadastrar nova conta
    2. Mostrar saldo da conta
    3. Contas cadastradas
    4. Mostrar dados do cliente

    0. Sair
    ";
    
    
    public void Home()
    {
        Console.WriteLine(menu);
        Console.WriteLine("Digite a opção desejada:");
        Choice = int.Parse(Console.ReadLine()!);
        
        Thread.Sleep(3000);

        switch (Choice)
        {
            case 1: 
                RegisterUser();
                break;
            
            case 2: 
                Console.WriteLine("Você escolheu a opção 2");
                break;
            
            case 3: 
                Console.WriteLine("Você escolheu a opção 3");
                break;
            
            case 4: 
                ShowData();
                break;
            
            default: 
                Console.WriteLine("Opção inválida");
                break;    
        }
    }
    
    

    public void RegisterUser()
    {
        Console.Clear();
        
        Console.WriteLine("Qual o nome do titular da conta: ");
        Holder = Console.ReadLine()!;

        Console.WriteLine("\nDigite o quanto tem na sua conta: ");
        Balance = double.Parse(Console.ReadLine()!);

        Console.WriteLine("\nAgora digite uma senha para proteger sua conta: ");
        Password = Console.Read();
    }
    
    


    public void ShowData()
        {
            Console.WriteLine($"Número indicador da conta: {NumIndicartor = identifierNumber.Next(1000, 10000)}");
            Console.WriteLine($"Titular da conta: {Holder}");
            Console.WriteLine($"Saldo disponível: {Balance}");
            if (ActiveAccont)
            {
                Console.WriteLine("A sua conta está ativa");
            }
            else
            {
                Console.WriteLine("Infelizmente sua conta não está ativa, entre em contato com um gerente");
            }
        }
}

