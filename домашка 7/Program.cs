using System;

class BankAccount
{
    public decimal Balance;
    public string Number;

    public BankAccount(string number, decimal balance)
    {
        Number = number;
        Balance = balance;
    }

    public void Transfer(BankAccount from, decimal amount)
    {
        if (from == null || amount <= 0)
        {
            Console.WriteLine("Некорректные данные перевода");
            return;
        }
        if (from.Balance < amount)
        {
            Console.WriteLine("Недостаточно средств");
            return;
        }
        from.Balance -= amount;
        this.Balance += amount;
        Console.WriteLine($"Переведено {amount} со счёта {from.Number} на {this.Number}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount a = new BankAccount("111", 1000);
        BankAccount b = new BankAccount("222", 500);

        b.Transfer(a, 300);     
        b.Transfer(a, -100);    
        b.Transfer(null, 50); 
        b.Transfer(a, 10000);  

        Console.WriteLine($"A = {a.Balance}, B = {b.Balance}");
    }
}