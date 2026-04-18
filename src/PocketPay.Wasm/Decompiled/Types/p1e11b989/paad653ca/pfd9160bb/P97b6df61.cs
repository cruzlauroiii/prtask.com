namespace WillowMaze.Wasm.Decompiled;

public class P97b6df61 : P542529df
{
    public static p97b6df61$p910eef8c F0b00600a;
    public static string F1955944c;
    public static p97b6df61$p910eef8c F41094a6f;
    public static p97b6df61$p910eef8c F591f9445;
    public static string F70e2edd2;
    public static string F743fd27d;
    public static p97b6df61$p910eef8c F910eef8c;
    public static p97b6df61$p910eef8c Fcd477a5b;
    private readonly p9cd72ef0 F1f946736;
    private readonly p9cd72ef0 F8ec0a6a0;
    private readonly p9cd72ef0 Fd284cf74;
    private readonly p9cd72ef0 Ff3395cd5;

    public void Back()
    {
        // call: p9cd72ef0.exit
        // field: p1e11b989.paad653ca.pfd9160bb.p97b6df61.ff3395cd5
    }

    public string GetNoteKey()
    {
        // str: "aa3d13838598cd4e186e75d375ee5eee50cf5e6fe2ae4bc070afb305516a1b1458e7e70cb0112c04719c"
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public void OpenNoteReceiptScreen(string P0, p5a409c20 P1)
    {
        // str: "note"
        // str: "operationType"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.navigateTo
        // call: p6c3616a9.NoteReceiptScreen
        // field: p1e11b989.paad653ca.pfd9160bb.p97b6df61.ff3395cd5
        // field: p1e11b989.paad653ca.pfd9160bb.p6c3616a9.f76425f17
    }

    public void SendResult(string P0, object P1)
    {
        // str: "key"
        // str: "data"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.sendResult
        // field: p1e11b989.paad653ca.pfd9160bb.p97b6df61.ff3395cd5
    }

    public void SetResultListener(string P0, p449a7995 P1)
    {
        // str: "listener"
        // str: "key"
        // call: p9cd72ef0.setResultListener
        // call: Intrinsics.checkNotNullParameter
        // field: p1e11b989.paad653ca.pfd9160bb.p97b6df61.ff3395cd5
    }

}
