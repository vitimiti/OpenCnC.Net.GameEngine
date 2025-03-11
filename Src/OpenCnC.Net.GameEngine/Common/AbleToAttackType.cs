namespace OpenCnC.Net.GameEngine.Common;

[Flags]
public enum AbleToAttackType
{
    None = 0,
    Forced = 1 << 0,
    Continued = 1 << 1,
    TunnelNetworkGuard = 1 << 2,
    ContinuedTargetForced = Forced | Continued,
}
