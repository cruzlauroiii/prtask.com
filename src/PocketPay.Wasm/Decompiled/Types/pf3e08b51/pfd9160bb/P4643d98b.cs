namespace WillowMaze.Wasm.Decompiled;

public class P4643d98b : P02eb2260
{
    public static string F5b1a3b5e;
    private static p4643d98b$p910eef8c F910eef8c;
    private static p4643d98b$p910eef8c Fa296ad66;
    private static p4643d98b$p910eef8c Fd64c8804;
    public static string Fdae50bce;
    private readonly p9cd72ef0 F01a79c56;
    private readonly p9cd72ef0 F2909fc79;
    private readonly p9cd72ef0 F6829ee86;
    private readonly p9cd72ef0 Fe6d1764a;
    private readonly p9cd72ef0 Ff3395cd5;

    public void Back()
    {
        // call: p9cd72ef0.exit
        // field: pf3e08b51.pfd9160bb.p4643d98b.ff3395cd5
    }

    public void BackToLauncher()
    {
        // call: p6f7b3c79.LauncherScreen
        // call: p9cd72ef0.backTo
        // field: pf3e08b51.pfd9160bb.p4643d98b.ff3395cd5
        // field: pf3e08b51.pfd9160bb.p6f7b3c79.f76425f17
    }

    public void Finish()
    {
        // call: p9cd72ef0.finishChain
        // field: pf3e08b51.pfd9160bb.p4643d98b.ff3395cd5
    }

    public string GetLauncherResultKey()
    {
        // str: "f7eb2c820308765bf31d92e4b26ac788fa0fd7c3e207e192beb7fa2016f344e8975d0cae0ae30136fb3b83c0d69901"
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public p2fc3359e GetLauncherScreen()
    {
        // call: p6f7b3c79.LauncherScreen
        // field: pf3e08b51.pfd9160bb.p6f7b3c79.f76425f17
        return default!;
    }

    public void OpenDocumentsMenu()
    {
        // call: p6f7b3c79.DocumentsMenuScreen
        // call: p9cd72ef0.navigateTo
        // field: pf3e08b51.pfd9160bb.p6f7b3c79.f76425f17
        // field: pf3e08b51.pfd9160bb.p4643d98b.ff3395cd5
    }

    public void OpenReviewApp()
    {
        // call: p6f7b3c79.ReviewAppScreen
        // call: p9cd72ef0.navigateTo
        // field: pf3e08b51.pfd9160bb.p6f7b3c79.f76425f17
        // field: pf3e08b51.pfd9160bb.p4643d98b.ff3395cd5
    }

    public void StartLauncherFlow()
    {
        // call: p6f7b3c79.LauncherScreen
        // call: p9cd72ef0.newRootScreen
        // field: pf3e08b51.pfd9160bb.p4643d98b.ff3395cd5
        // field: pf3e08b51.pfd9160bb.p6f7b3c79.f76425f17
    }

}
