namespace WillowMaze.Wasm.Decompiled;

public class Pffe048ab_1 : EntityInsertionAdapter
{
    private readonly pffe048ab This$0;

    public static string PuENwJXAWEMVOTZv(p94db0041 P0)
    {
        // call: p94db0041.getDeviceId
        return string.Empty;
    }

    public static void FYYViAzfpFQQJFMP(SupportSQLiteStatement P0, int P1, string P2)
    {
        // call: SupportSQLiteStatement.bindString
    }

    public static bool LXrOtSVJOfTYzmnr(p94db0041 P0)
    {
        // call: p94db0041.isKktReadyForDelivery
        return false;
    }

    public static void MrvSWgOwdvgrmNvq(pffe048ab$1 P0, SupportSQLiteStatement P1, p94db0041 P2)
    {
        // call: pffe048ab$1.bind
    }

    public static void OutWAVGWvVpwudaH(SupportSQLiteStatement P0, int P1, long P2)
    {
        // call: SupportSQLiteStatement.bindLong
    }

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: pffe048ab$1.mrvSWgOwdvgrmNvq
    }

    private void Bind(SupportSQLiteStatement P0, p94db0041 P1)
    {
        // call: pffe048ab$1.PuENwJXAWEMVOTZv
        // call: pffe048ab$1.lXrOtSVJOfTYzmnr
        // call: pffe048ab$1.outWAVGWvVpwudaH
        // call: pffe048ab$1.fYYViAzfpFQQJFMP
    }

    private string CreateQuery()
    {
        // str: "INSERT OR REPLACE INTO `device_status` (`deviceId`,`isKktReadyForDelivery`) VALUES (?,?)"
        return string.Empty;
    }

}
