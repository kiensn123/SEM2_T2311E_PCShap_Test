using System;

namespace Bank;

public class Foreign_currency
{
    public float USD{get;set;}
    public float VND{get;set;}

    public float USD_to_VND(float money){
        return (money*USD)/VND;
    }
    public float VND_to_USD(float money){
         return (money*VND)/USD;
    }

}
