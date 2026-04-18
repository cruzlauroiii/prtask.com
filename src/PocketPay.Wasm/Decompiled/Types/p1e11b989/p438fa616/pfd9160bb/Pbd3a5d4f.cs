namespace WillowMaze.Wasm.Decompiled;

public class Pbd3a5d4f : P0fce535b
{
    private readonly p9cd72ef0 Fd796fd65;
    private readonly p9cd72ef0 Fe362ad17;
    private readonly p9cd72ef0 Ff3395cd5;

    public void NewRootIntermediatePaybackReceipt()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pa7d115db.IntermediatePaybackReceiptScreen
        // field: p1e11b989.p438fa616.pfd9160bb.pbd3a5d4f.ff3395cd5
        // field: p1e11b989.p438fa616.pfd9160bb.pa7d115db.f76425f17
    }

    public void NewRootIntermediateSellReceipt()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pa7d115db.mc1a7579c
        // field: p1e11b989.p438fa616.pfd9160bb.pa7d115db.f76425f17
        // field: p1e11b989.p438fa616.pfd9160bb.pbd3a5d4f.ff3395cd5
    }

    public void OpenIntermediatePaybackReceipt()
    {
        // call: p9cd72ef0.navigateTo
        // call: pa7d115db.IntermediatePaybackReceiptScreen
        // field: p1e11b989.p438fa616.pfd9160bb.pbd3a5d4f.ff3395cd5
        // field: p1e11b989.p438fa616.pfd9160bb.pa7d115db.f76425f17
    }

    public void OpenIntermediateSellReceipt()
    {
        // call: p9cd72ef0.navigateTo
        // call: pa7d115db.mc1a7579c
        // field: p1e11b989.p438fa616.pfd9160bb.pa7d115db.f76425f17
        // field: p1e11b989.p438fa616.pfd9160bb.pbd3a5d4f.ff3395cd5
    }

    public void ReplaceIntermediateSell(decimal P0)
    {
        // str: "customerChange"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.replaceScreen
        // call: pa7d115db.IntermediateSellReceiptScreen
        // field: p1e11b989.p438fa616.pfd9160bb.pa7d115db.f76425f17
        // field: p1e11b989.p438fa616.pfd9160bb.pbd3a5d4f.ff3395cd5
    }

}
