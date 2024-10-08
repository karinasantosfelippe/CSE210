namespace Develop03;

public static class AppConstants
{
    public static readonly List<Scripture> SCRIPTURES = [
        new(new Reference("Proverbs", 3, [5, 6]), "Trust in the Lord with all thine heart and lean not unto thine own understanding; in al thy ways acknowledge him, and he shall direct thy paths."),
            new(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new(new Reference("James", 1, [5, 6, 7, 8]), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed. For let not that man think that he shall receive any thing of the Lord. A double minded man is unstable in all his ways.")
    ];
}