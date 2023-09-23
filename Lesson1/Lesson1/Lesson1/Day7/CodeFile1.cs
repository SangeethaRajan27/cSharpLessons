public delegate void SMSMessageHandler(long phoneNo, string msg);

public delegate void EmailMessageHandler(string emailAddress, string msg);

public enum AccountType

{

    SavingsAccount = 0, CurrentAccount = 1, FixedDepositeAccount = 2, LoanAccount = 3

}

class Account

{

    public readonly long AccountNumber;

    public readonly int CustomerID;

    public AccountType TypeOfAccount;

    public const float MIN_Balance = 2000f;

    public const float MAX_Balance = 2000000f;

    private float currentBalance = 0;

    public string EmailAddress = string.Empty;

    public long PhoneNumber;

    public float CurrentBalance

    {

        get => currentBalance;

        set

        {

            if (value < 0)

            {

                throw new Exception("Insufficent Balance");

            }

            if (value > MAX_Balance)

            {

                throw new Exception("Very Large Balance");

            }

            currentBalance = value;

        }

    }



    public Account(long accountNumber, int customerid)

    {

        AccountNumber = accountNumber;

        CustomerID = customerid;

    }

}

public enum MessagePriority

{

    Normal = 0, Urgent = 1, Low = 2, High = 3

}

class Message

{

    public string To = string.Empty;

    public string From = string.Empty;

    public string Subject = string.Empty;

    public string Body = string.Empty;

    public string Attachment = string.Empty;

    public MessagePriority Priority = MessagePriority.Normal;

    public Message() { }

}

class AccountController

{

    private readonly Account account;

    public event SMSMessageHandler? SmsSignal;

    public event EmailMessageHandler? EmailSignal;

    public AccountController(Account account)

    {

        this.account = account;

    }

    public void DoWithdrawal(float amount)

    {



        if (amount < 50)

        {

            throw new Exception("Amount to Withdraw must be > 50");

        }

        if (account == null)

        {

            throw new Exception("Account Not FOUND");

        }

        try

        {

            account.CurrentBalance -= amount;

            string msg = $"Withdraw Successful Your Balance{account.CurrentBalance}";

            //MessageController mc = new MessageController();

            //mc.SendEmail(account.EmailAddress, msg);

            //mc.SendSMS(account.PhoneNumber, msg);

            if (SmsSignal != null)

            {

                SmsSignal(account.PhoneNumber, msg);

            }

            if (EmailSignal != null)

            {

                EmailSignal(account.EmailAddress, msg);

            }

        }

        catch (Exception err)

        {

            Console.WriteLine($"ERROR!!! - {err.Message}");

        }

    }

    public void DoDeposit(float amount)

    {



        if (amount > 200000)

        {

            throw new Exception("Amount to Deposit must be < 200000 ");

        }

        if (account == null)

        {

            throw new Exception("Account Not FOUND");

        }

        try

        {

            account.CurrentBalance += amount;

            string msg = $"Deposit Successful Your Balance{account.CurrentBalance}";

            //MessageController mc = new MessageController();

            //mc.SendEmail(account.EmailAddress, msg);

            //mc.SendSMS(account.PhoneNumber, msg);

            if (SmsSignal != null)

            {

                SmsSignal(account.PhoneNumber, msg);

            }

            if (EmailSignal != null)

            {

                EmailSignal(account.EmailAddress, msg);

            }

        }

        catch (Exception err)

        {

            Console.WriteLine($"ERROR!!! - {err.Message}");

        }

    }

}

interface IMessageCreater

{

    void SendSMS(long phoneNo, string msg);

    void SendEmail(string emailAddress, string msg);

    void ReceiveSMS(string msg);

    void ReceiveEmail(string msg);

}

class MessageController : IMessageCreater

{

    public void ReceiveEmail(string msg)

    {

        try

        {

            Console.WriteLine("Not Implemented");

        }

        catch (Exception err)

        {

            Console.WriteLine(err.Message);

        }

    }



    public void ReceiveSMS(string msg)

    {

        throw new NotImplementedException();

    }



    public void SendEmail(string emailAddress, string msg)

    {

        Console.WriteLine($"Email sent to: {emailAddress} Message:{msg}");

    }



    public void SendSMS(long phoneNo, string msg)

    {

        Console.WriteLine($"SMS sent to: {phoneNo} Message:{msg}");



    }

}

class TestEvents

{

    public static void TestOne()

    {

        Account account = new Account(accountNumber: 5674328, customerid: 10001);

        MessageController messageController = new MessageController();

        AccountController accountController = new AccountController(account);

        accountController.EmailSignal += messageController.SendEmail;

        accountController.SmsSignal += messageController.SendSMS;



        Console.WriteLine($"Opening Balance: {account.CurrentBalance}");

        accountController.DoDeposit(amount: 150000);

        Console.WriteLine($"Balance After Deposit: {account.CurrentBalance}");

        accountController.DoWithdrawal(amount: 25000);

        Console.WriteLine($"Balance After Withdrawal: {account.CurrentBalance}");



    }



}