namespace WillowMaze.Wasm.Decompiled;

public interface P11c216e8
{
    void BackFromFlowTo(p2fc3359e P0);
    void FinishAllFlows();
    void FinishFlow();
    void ReplaceFlow(p2fc3359e P0);
    void SendResult(string P0, object P1);
    void SetResultListener(string P0, p449a7995 P1);
    void StartFlow(p2fc3359e P0);
    void StartRootFlow(p2fc3359e P0);
}
