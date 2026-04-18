namespace WillowMaze.Wasm.Decompiled;

public interface TransactionInterface
{
    void AbortTransaction();
    void Clean();
    Q ExecuteCommand(N P0);
    void InitiatePayment(PaymentDataProvider P0);
    void ProceedWithMastercardTransaction(PaymentDataProvider P0, byte[] P1);
    void ReadCard(List<object> P0);
    void ResumeTransactionProcessing(byte[] P0);
}
