namespace WillowMaze.Wasm.Decompiled;

public class Pffe048ab_2 : EntityDeletionOrUpdateAdapter
{
    private readonly pffe048ab This$0;

    public static string SMzbGWaIkRoMBLLL(p94db0041 P0)
    {
        // call: p94db0041.getDeviceId
        return string.Empty;
    }

    public static void FpVvAYUHlZAXfUwM(SupportSQLiteStatement P0, int P1, long P2)
    {
        // call: SupportSQLiteStatement.bindLong
    }

    public static void HyALfppoWCmXtfFq(SupportSQLiteStatement P0, int P1, string P2)
    {
        // call: SupportSQLiteStatement.bindString
    }

    public static void JeaPuETLUjglkJiJ(SupportSQLiteStatement P0, int P1, string P2)
    {
        // call: SupportSQLiteStatement.bindString
    }

    public static bool MXJwMApwKCJDnunB(p94db0041 P0)
    {
        // call: p94db0041.isKktReadyForDelivery
        return false;
    }

    public static string TacafgABvXTodTYn(p94db0041 P0)
    {
        // call: p94db0041.getDeviceId
        return string.Empty;
    }

    public static void YOTWEtKejdhyzlCW(pffe048ab$2 P0, SupportSQLiteStatement P1, p94db0041 P2)
    {
        // call: pffe048ab$2.bind
    }

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: pffe048ab$2.yOTWEtKejdhyzlCW
    }

    private void Bind(SupportSQLiteStatement P0, p94db0041 P1)
    {
        // call: pffe048ab$2.tacafgABvXTodTYn
        // call: pffe048ab$2.hyALfppoWCmXtfFq
        // call: pffe048ab$2.mXJwMApwKCJDnunB
        // call: pffe048ab$2.jeaPuETLUjglkJiJ
        // call: pffe048ab$2.SMzbGWaIkRoMBLLL
        // call: pffe048ab$2.fpVvAYUHlZAXfUwM
    }

    private string CreateQuery()
    {
        // str: "UPDATE OR ABORT `device_status` SET `deviceId` = ?,`isKktReadyForDelivery` = ? WHERE `deviceId` = ?"
        return string.Empty;
    }

}
