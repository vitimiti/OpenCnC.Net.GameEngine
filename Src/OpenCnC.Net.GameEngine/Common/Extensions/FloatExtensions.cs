using OpenCnC.Net.Math;

namespace OpenCnC.Net.GameEngine.Common.Extensions;

public static class FloatExtensions
{
    private const float LogicFramesPerSecond = 30F;
    private const float MillisecondsPerSecond = 1000F;

    private static float LogicFramesPerMillisecond => LogicFramesPerSecond / MillisecondsPerSecond;

    private static float MillisecondsPerLogicFrame => MillisecondsPerSecond / LogicFramesPerSecond;

    private static float SecondsPerLogicFrame => 1F / LogicFramesPerSecond;

    public static float AsDurationConvertFromMillisecondsToFrames(this float milliseconds) =>
        milliseconds * LogicFramesPerMillisecond;

    public static float AsVelocityInSecondsConvertToFrames(this float distancePerSecond) =>
        distancePerSecond * SecondsPerLogicFrame;

    public static float AsAccelerationInSecondsConvertToFrames(this float distancePerSecondSquared)
    {
        var secondsPerLogicFrameSquared = SecondsPerLogicFrame * SecondsPerLogicFrame;
        return distancePerSecondSquared * secondsPerLogicFrameSquared;
    }

    public static float AsAngularVelocityInDegreesPerSecondConvertToRadiansPerFrame(
        this float degreesPerSecond
    )
    {
        float radiansPerDegree = new Degrees(1).ToRadians().Value;
        return degreesPerSecond * (SecondsPerLogicFrame * radiansPerDegree);
    }
}
