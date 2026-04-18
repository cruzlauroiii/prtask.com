namespace WillowMaze.Wasm.Decompiled;

public class Paf462909_6 : EntityInsertionAdapter
{
    private readonly paf462909 This$0;

    public static void OVPGjhzkjfhLYCXC(SupportSQLiteStatement P0, int P1, long P2)
    {
        // call: SupportSQLiteStatement.bindLong
    }

    public static int TIMbuhPIEiscudZn(p25a7e996 P0)
    {
        // call: p25a7e996.getId
        return 0;
    }

    public static void TwmcfHYdfpEixwOA(paf462909$6 P0, SupportSQLiteStatement P1, p25a7e996 P2)
    {
        // call: paf462909$6.bind
    }

    public static void UEMQvKICGUHqHEdi(SupportSQLiteStatement P0, int P1, string P2)
    {
        // call: SupportSQLiteStatement.bindString
    }

    public static string YYXsLiONHBLbiJAb(p25a7e996 P0)
    {
        // call: p25a7e996.getReceiptUuid
        return string.Empty;
    }

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: paf462909$6.twmcfHYdfpEixwOA
    }

    private void Bind(SupportSQLiteStatement P0, p25a7e996 P1)
    {
        // call: paf462909$6.yYXsLiONHBLbiJAb
        // call: paf462909$6.OVPGjhzkjfhLYCXC
        // call: paf462909$6.uEMQvKICGUHqHEdi
        // call: paf462909$6.TIMbuhPIEiscudZn
    }

    private string CreateQuery()
    {
        // str: "INSERT OR ABORT INTO `queue_receipt` (`id`,`receiptUuid`) VALUES (nullif(?, 0),?)"
        return string.Empty;
    }

}
