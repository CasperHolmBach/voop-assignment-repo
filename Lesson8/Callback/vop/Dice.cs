using System;

namespace Callback.vop;

public class Dice
{
    private static readonly Random _generator = new();
    private static readonly int Max = 6;

    private int _count;

    public int Die1 { get; private set; }

    public int Die2 { get; private set; }

    public int ThrowDice(){
        Die1 = _generator.Next(Max) + 1;
        Die2 = _generator.Next(Max) + 1;
        _count++;
        return Die1 + Die2;
    }
    
    public override string ToString() {
        return _count + ": d1=" + Die1 + ", d2=" + Die2;
    }
    
    public bool EqualsMax(){
        return Die1 == Max && Die2 == Max;
    }
}