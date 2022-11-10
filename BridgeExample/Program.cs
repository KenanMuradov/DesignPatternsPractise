using BridgeExample.AbstractionLawer.Concretes;
using BridgeExample.ImplementationLayer.Concretes;
using System;

namespace IteratorExample;

public class Program
{
    public static void Main()
    {
        SonyRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
        sonyRemoteControl.SwitchOn();
        sonyRemoteControl.SetChannel(101);
        sonyRemoteControl.SwitchOff();

        Console.WriteLine();
        SamsungRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
        samsungRemoteControl.SwitchOn();
        samsungRemoteControl.SetChannel(202);
        samsungRemoteControl.SwitchOff();

        Console.ReadKey();
    }
}