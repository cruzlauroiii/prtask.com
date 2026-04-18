namespace WillowMaze.Wasm.Decompiled;

public interface Pbcebee16
{
    long GetAmount();
    string GetAuthCode();
    long GetAvailableAmount();
    string GetBatchRef();
    long GetBatchSequenceNumber();
    string GetBeautifyPanNumber();
    string GetCallbackUrl();
    Instant GetCanceled();
    long GetCanceledAmount();
    string GetCharCurrency();
    bool GetConfirmed();
    int GetCurrency();
    bool GetCurrentBatch();
    pb5e4db9f GetCvmMethod();
    p3e9ee528 GetEntryMode();
    string GetExternalId();
    string GetFormattedAmount();
    string GetFormattedAvailableAmount();
    string GetFormattedMessage();
    string GetFormattedSumAmount();
    string GetMaskedPan();
    string GetOrderQrUrl();
    string GetPrintedAmount();
    string GetRefId();
    string GetReferenceNumber();
    string GetResponseCode();
    string GetResponseMessage();
    long GetSequenceNumber();
    string GetStan();
    p5070f570 GetState();
    string GetStringState();
    Instant GetTimestamp();
    string GetTimestampString();
    p74d4c71f GetType();
}
