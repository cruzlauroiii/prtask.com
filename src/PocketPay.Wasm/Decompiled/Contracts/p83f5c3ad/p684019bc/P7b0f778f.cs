namespace WillowMaze.Wasm.Decompiled;

public interface P7b0f778f
{
    object CloseBatch(object P0);
    long GetBatchCloseDate();
    object GetCurrentBatchInfo(object P0);
    bool IsBatchClosed(long P0);
    object SendReportToEmail(string P0, p8cf10d23 P1, p8cf10d23 P2, object P3);
    void SetBatchCloseDate(long P0);
}
