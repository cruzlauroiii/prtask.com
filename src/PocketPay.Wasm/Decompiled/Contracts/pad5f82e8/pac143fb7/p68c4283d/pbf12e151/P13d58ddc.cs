namespace WillowMaze.Wasm.Decompiled;

public interface P13d58ddc
{
    void ChangeActivityLifecycleState(Lifecycle$Event P0);
    void FiscalizeReceipt(p8c261c90 P0, string P1, string P2, string P3);
    void Navigate(string P0, string P1);
    void NavigateBack(string P0);
    void NavigateBackTo(string P0);
    void PrepareSendReceipt(p8c261c90 P0, string P1, string P2, string P3);
    void SaveReceiptToQueue(p8c261c90 P0, string P1, string P2, string P3);
    void SaveReceiptToQueueError(p8c261c90 P0, string P1, string P2, string P3);
    void SendErrorReceipt(p8c261c90 P0, string P1, string P2, string P3);
}
