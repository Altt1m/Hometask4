class Order
{
    private string payer_iban, payer_name;
    private string receiver_iban, receiver_name;
    // Тут можна було б зробити одну змінну на рахунок та ім'я, але, гадаю, так буде зрозуміліше

    public void EnterIBANs() // Entering IBAN
    {
        Console.Write("Завдання 1.\nВведіть розрахунковий номер (IBAN) платника: ");
        payer_iban = Console.ReadLine();

        void EnterPayerName() // Local Payer Name setter
        {
            Console.Write("І ще введіть повне ім'я платника: ");
            payer_name = Console.ReadLine();
        }
        EnterPayerName();


        Console.Write("\nТепер введіть розрахунковий номер (IBAN) одержувача: ");
        receiver_iban = Console.ReadLine();

        void EnterReceiverName() // Local Receiver Name setter
        {
            Console.Write("І ще введіть повне ім'я отримувача: ");
            receiver_name = Console.ReadLine();
        }
        EnterReceiverName();
    }

    public void ShowOrder()
    {
        Console.WriteLine($"\nІм'я платника: {payer_name}. IBAN: {payer_iban}");
        Console.WriteLine($"Ім'я одержувача: {receiver_name}. IBAN: {receiver_iban}");
    }

    // Other methods
}

