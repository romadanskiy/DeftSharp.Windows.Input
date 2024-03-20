﻿using System;
using System.Collections.Generic;
using DeftSharp.Windows.Input.Mouse;

namespace DeftSharp.Windows.Input.Shared.Extensions;

internal static class EnumExtensions
{
    public static IEnumerable<MouseEvent> ToMouseEvents(this PreventMouseOption preventEvent)
    {
        var preventEvents = new List<MouseEvent>();

        switch (preventEvent)
        {
            case PreventMouseOption.Move:
                preventEvents.Add(MouseEvent.Move);
                break;
            case PreventMouseOption.LeftButton:
                preventEvents.Add(MouseEvent.LeftButtonDown);
                preventEvents.Add(MouseEvent.LeftButtonUp);
                break;
            case PreventMouseOption.RightButton:
                preventEvents.Add(MouseEvent.RightButtonDown);
                preventEvents.Add(MouseEvent.RightButtonUp);
                break;
            case PreventMouseOption.MiddleButton:
                preventEvents.Add(MouseEvent.MiddleButtonDown);
                preventEvents.Add(MouseEvent.MiddleButtonUp);
                break;
            case PreventMouseOption.Wheel:
                preventEvents.Add(MouseEvent.Wheel);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(preventEvent), preventEvent,
                    $"Invalid value for argument {nameof(preventEvent)}: {preventEvent}");
        }

        return preventEvents;
    }
}