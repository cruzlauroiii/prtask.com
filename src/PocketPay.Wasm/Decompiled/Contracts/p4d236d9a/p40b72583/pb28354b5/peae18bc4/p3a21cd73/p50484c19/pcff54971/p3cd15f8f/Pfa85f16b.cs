namespace WillowMaze.Wasm.Decompiled;

public interface Pfa85f16b
{
    void ApplyResult(peb903202 P0);
    void ApplyTransactionResult(peb903202 P0);
    Instant GetEarliestTimestamp();
    p3e9ee528[] GetEntryModes();
    bool GetFilterDatePresent();
    Instant GetFromDate();
    bool GetHasNoMoreData();
    Instant GetLatestTimeStamp();
    int GetOffset();
    int GetPageSize();
    Dictionary<string, object> GetParams();
    string GetSearchString();
    Instant GetToDate();
    void UpdatePageSettings(int P0, int P1);
}
