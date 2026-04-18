namespace WillowMaze.Wasm.Decompiled;

public interface Pc556a05a
{
    void Back();
    void BackToReceiptStatuses();
    string GetReceiptStatusChangedKey();
    string GetReceiptStatusesFilterKey();
    void OpenReceiptStatusDetails(string P0);
    void OpenReceiptStatuses();
    void OpenReceiptStatusesFilter(pc77da2af P0);
    void SendResult(string P0, object P1);
    void SetResultListener(string P0, p449a7995 P1);
}
