// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
// <copyright file="BaseComponent.cs" company="Klepacze Games">
// Copyright (c) Klepacze Games. All rights reserved.
// </copyright>
// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

using System;
using Godot;

namespace T3G.Common.Components.Bases;

/// <summary>
/// Base component
/// </summary>
public partial class BaseComponent : Node3D
{
    /// <summary>
    /// ready function
    /// </summary>
    public override void _Ready()
    {
        GD.Print("Component Test");
    }
}
