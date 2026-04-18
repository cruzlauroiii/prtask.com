namespace WillowMaze.Wasm.Decompiled;

public class P7734f16c : P11c216e8
{
    private readonly p9cd72ef0 F12ef81da;
    private readonly p9cd72ef0 F5a374515;
    private readonly p9cd72ef0 F92680f93;
    private readonly p9cd72ef0 Ff3395cd5;

    public void BackFromFlowTo(p2fc3359e P0)
    {
        // str: "screen"
        // call: p9cd72ef0.backTo
        // call: Intrinsics.checkNotNullParameter
        // field: pd2a57dc1.pfd9160bb.p7734f16c.ff3395cd5
    }

    public void FinishAllFlows()
    {
        // call: p9cd72ef0.finishChain
        // field: pd2a57dc1.pfd9160bb.p7734f16c.ff3395cd5
    }

    public void FinishFlow()
    {
        // call: p9cd72ef0.exit
        // field: pd2a57dc1.pfd9160bb.p7734f16c.ff3395cd5
    }

    public void ReplaceFlow(p2fc3359e P0)
    {
        // str: "screen"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.replaceScreen
        // field: pd2a57dc1.pfd9160bb.p7734f16c.ff3395cd5
    }

    public void SendResult(string P0, object P1)
    {
        // str: "data"
        // str: "key"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.sendResult
        // field: pd2a57dc1.pfd9160bb.p7734f16c.ff3395cd5
    }

    public void SetResultListener(string P0, p449a7995 P1)
    {
        // str: "listener"
        // str: "key"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.setResultListener
        // field: pd2a57dc1.pfd9160bb.p7734f16c.ff3395cd5
    }

    public void StartFlow(p2fc3359e P0)
    {
        // str: "screen"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.navigateTo
        // field: pd2a57dc1.pfd9160bb.p7734f16c.ff3395cd5
    }

    public void StartRootFlow(p2fc3359e P0)
    {
        // str: "screen"
        // call: p9cd72ef0.newRootScreen
        // call: Intrinsics.checkNotNullParameter
        // field: pd2a57dc1.pfd9160bb.p7734f16c.ff3395cd5
    }

}
