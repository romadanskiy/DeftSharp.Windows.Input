﻿using System.Windows.Input;

namespace DeftSharp.Windows.Input.Keyboard;

public sealed class NumButton
{
    public Key Key { get; }
    public int Number { get; }

    public NumButton(Key key, int number)
    {
        Key = key;
        Number = number;
    }
}