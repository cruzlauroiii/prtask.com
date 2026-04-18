namespace WillowMaze.Wasm.Decompiled;

public class P50330beb : Pcbd77ab2
{
    public static string F0775463b;
    public static string F0e6685a0;
    private static p50330beb$p910eef8c F1d06a6f6;
    private static p50330beb$p910eef8c F4a3672da;
    private static p50330beb$p910eef8c F6135d4b9;
    private static p50330beb$p910eef8c F910eef8c;
    public static string F9c653790;
    public static string Fa4b2f59a;
    public static string Fe874be73;
    private static p50330beb$p910eef8c Feae04663;
    private readonly p9cd72ef0 F22598d76;
    private readonly p9cd72ef0 Fbc062a59;
    private readonly p9cd72ef0 Ff3395cd5;

    public void Back()
    {
        // call: p9cd72ef0.exit
        // field: p1e11b989.pd3ed68f7.pfd9160bb.p50330beb.ff3395cd5
    }

    public string GetReceiptCredentialsKey()
    {
        // str: "8a27435004d11df3568d3535cc3b04c2aed65a375d5725674d14c25d85a509ab0680fbded2591f43a72ff25f4c35c0"
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public void OpenReceiptSending(string P0, string P1)
    {
        // call: pd3dbf002.ReceiptSendingScreen
        // call: p9cd72ef0.navigateTo
        // field: p1e11b989.pd3ed68f7.pfd9160bb.pd3dbf002.f76425f17
        // field: p1e11b989.pd3ed68f7.pfd9160bb.p50330beb.ff3395cd5
    }

    public void SendResult(string P0, object P1)
    {
        // str: "key"
        // str: "data"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.sendResult
        // field: p1e11b989.pd3ed68f7.pfd9160bb.p50330beb.ff3395cd5
    }

    public void SetResultListener(string P0, p449a7995 P1)
    {
        // str: "key"
        // str: "listener"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.setResultListener
        // field: p1e11b989.pd3ed68f7.pfd9160bb.p50330beb.ff3395cd5
    }

}
