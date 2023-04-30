using Stratis.SmartContracts;
using System;

public class HelloWorld : SmartContract
{
    public HelloWorld(ISmartContractState smartContractState)
    : base(smartContractState)
    {
    }

    private string Greeting
    {
        get
        {
            return this.PersistentState.GetString("Greeting");
        }
        set
        {
            this.PersistentState.SetString("Greeting", value);
        }
    }

    public string SayHello() => Greeting;
}