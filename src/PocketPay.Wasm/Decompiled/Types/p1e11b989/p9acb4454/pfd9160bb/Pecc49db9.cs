namespace WillowMaze.Wasm.Decompiled;

public class Pecc49db9 : Pc556a05a
{
    public static string F2151611d;
    public static string F231ab82e;
    public static string F6644a0ae;
    public static string F86d253b0;
    private static pecc49db9$p910eef8c F910eef8c;
    public static string F91abbbbe;
    public static string F93cd7658;
    private static pecc49db9$p910eef8c Fb0993f10;
    private static pecc49db9$p910eef8c Fbab6360e;
    public static string Fd08e4837;
    private static pecc49db9$p910eef8c Fd3025e90;
    private readonly p9cd72ef0 F17fe779b;
    private readonly p9cd72ef0 F71ee0cf3;
    private readonly p9cd72ef0 Ff3395cd5;

    public void Back()
    {
        // call: p9cd72ef0.exit
        // field: p1e11b989.p9acb4454.pfd9160bb.pecc49db9.ff3395cd5
    }

    public void BackToReceiptStatuses()
    {
        // call: p9cd72ef0.backTo
        // call: p70d62ec5.ReceiptStatusesScreen
        // field: p1e11b989.p9acb4454.pfd9160bb.pecc49db9.ff3395cd5
        // field: p1e11b989.p9acb4454.pfd9160bb.p70d62ec5.f76425f17
    }

    public string GetReceiptStatusChangedKey()
    {
        // str: "2e64febadd19b04626d02ba38426be0687f6bd004b71a7037c87fba8d99b58a93ef7f0bbfeeabb05c22a69fc8f99b2b57..."
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public string GetReceiptStatusesFilterKey()
    {
        // str: "5fb6d47fc901bec557957b719987b6667675f6cd3882b5c39d26e99d9cfc199e90319d4766ed9f54857394cf75d2bb5fa..."
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public void OpenReceiptStatusDetails(string P0)
    {
        // str: "receiptUuid"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.navigateTo
        // call: p70d62ec5.ReceiptStatusDetailsScreen
        // field: p1e11b989.p9acb4454.pfd9160bb.pecc49db9.ff3395cd5
        // field: p1e11b989.p9acb4454.pfd9160bb.p70d62ec5.f76425f17
    }

    public void OpenReceiptStatuses()
    {
        // call: p70d62ec5.ReceiptStatusesScreen
        // call: p9cd72ef0.navigateTo
        // field: p1e11b989.p9acb4454.pfd9160bb.pecc49db9.ff3395cd5
        // field: p1e11b989.p9acb4454.pfd9160bb.p70d62ec5.f76425f17
    }

    public void OpenReceiptStatusesFilter(pc77da2af P0)
    {
        // str: "filter"
        // call: p9cd72ef0.navigateTo
        // call: Intrinsics.checkNotNullParameter
        // call: p70d62ec5.ReceiptStatusesFilterScreen
        // field: p1e11b989.p9acb4454.pfd9160bb.p70d62ec5.f76425f17
        // field: p1e11b989.p9acb4454.pfd9160bb.pecc49db9.ff3395cd5
    }

    public void SendResult(string P0, object P1)
    {
        // str: "data"
        // str: "key"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.sendResult
        // field: p1e11b989.p9acb4454.pfd9160bb.pecc49db9.ff3395cd5
    }

    public void SetResultListener(string P0, p449a7995 P1)
    {
        // str: "key"
        // str: "listener"
        // call: p9cd72ef0.setResultListener
        // call: Intrinsics.checkNotNullParameter
        // field: p1e11b989.p9acb4454.pfd9160bb.pecc49db9.ff3395cd5
    }

}
