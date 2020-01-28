﻿using JetBrains.Annotations;

namespace Cethleann.Structure.Resource.Texture
{
    // Could also be version, unlikely though.
    // TODO: Compare Atelier Ryza PC and Switch
    [PublicAPI]
    public enum TextureGroupSystem : uint
    {
        // Or WiiU?
        Playstation3 = 0x1,
        // ?? = 0x2,
        // ?? = 0x3,
        // ?? = 0x4,
        ThreeDS = 0x5,
        Vita = 0x6,
        Android = 0x7,
        iOS = 0x8,

        // Assumption
        XboxOne = 0x9,
        Windows = 0xA,

        // Also bad PC ports
        Playstation4 = 0xB,
        
        // ?? = 0xC,
        // ?? = 0xD,
        // ?? = 0xE,
        // ?? = 0xF,
        Switch = 0x10
    }
}