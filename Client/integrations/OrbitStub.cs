using System.Collections.Generic;
using EFT;

namespace RAID_REVIEW
{
    /// <summary>
    /// No-op stand-in for <c>Orbit.cs</c>, compiled only when <c>ORBIT.dll</c> is missing
    /// from <c>dependencies/4.1.X</c> (see RAID-REVIEW.csproj). Same public surface; every
    /// caller is gated on <see cref="RAID_REVIEW.ORBIT__DETECTED"/>, so without ORBIT none
    /// of this runs, and with ORBIT installed the recordings simply carry no ORBIT data.
    /// </summary>
    class Orbit_Integration
    {
        public static void InitReflection() { }

        public static void ResetSessionState() { }

        public static void RefreshAgentCache() { }

        public static bool IsBotGhost(Player player) => false;

        public static List<TrackingOrbitGhostFight> GetGhostFights(string sessionId, long time)
            => new List<TrackingOrbitGhostFight>();

        public static List<TrackingOrbitGhostWake> GetGhostWakes(string sessionId, long time)
            => new List<TrackingOrbitGhostWake>();

        public static List<TrackingOrbitGhostHearing> GetGhostHearing(string sessionId, long time)
            => new List<TrackingOrbitGhostHearing>();

        public static TrackingOrbitBotObjective GetBotObjectiveData(Player player, string sessionId, long time)
            => null;

        public static TrackingOrbitField GetAdvectionFieldSnapshot(string sessionId, long time) => null;

        public static TrackingOrbitMainObjectives GetMainObjectivesSnapshot(string sessionId, long time) => null;

        public static int GetMainObjectivesRevision() => 0;
    }
}
