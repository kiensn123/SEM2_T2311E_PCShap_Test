using System;
using System.Net.WebSockets;

namespace Bank;

public abstract class Account
{
     public float Balance {get;set;}



     public abstract void Check_balance ();
     public abstract void Tranfrom(float money);

}
