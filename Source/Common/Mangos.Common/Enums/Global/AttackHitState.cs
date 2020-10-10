﻿
namespace Mangos.Common.Enums.Global
{
    public enum AttackHitState : int
    {
        HIT_UNARMED = HITINFO_NORMALSWING,
        HIT_NORMAL = HITINFO_HITANIMATION,
        HIT_NORMAL_OFFHAND = HITINFO_HITANIMATION + HITINFO_LEFTSWING,
        HIT_MISS = HITINFO_MISS,
        HIT_MISS_OFFHAND = HITINFO_MISS + HITINFO_LEFTSWING,
        HIT_CRIT = HITINFO_CRITICALHIT,
        HIT_CRIT_OFFHAND = HITINFO_CRITICALHIT + HITINFO_LEFTSWING,
        HIT_RESIST = HITINFO_RESIST,
        HIT_CRUSHING_BLOW = HITINFO_CRUSHING,
        HIT_GLANCING_BLOW = HITINFO_GLANCING,
        HITINFO_NORMALSWING = 0x0,
        HITINFO_UNK = 0x1,
        HITINFO_HITANIMATION = 0x2,
        HITINFO_LEFTSWING = 0x4,
        HITINFO_RANGED = 0x8,
        HITINFO_MISS = 0x10,
        HITINFO_ABSORB = 0x20,
        HITINFO_RESIST = 0x40,
        HITINFO_UNK2 = 0x100,
        HITINFO_CRITICALHIT = 0x200,
        HITINFO_BLOCK = 0x800,
        HITINFO_UNK3 = 0x2000,
        HITINFO_CRUSHING = 0x8000,
        HITINFO_GLANCING = 0x10000,
        HITINFO_NOACTION = 0x10000,
        HITINFO_SWINGNOHITSOUND = 0x80000
    }
}