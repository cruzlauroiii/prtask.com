namespace WillowMaze.Wasm.Decompiled;

public interface PaymentDataProvider
{
    Dictionary<string, object> GetPaymentDataMap();
    void SetPaymentDataEntry(int P0, ByteArrayWrapper P1);
}
