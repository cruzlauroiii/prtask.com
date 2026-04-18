namespace WillowMaze.Wasm.Decompiled;

public interface P1b0ffaae
{
    Single GetReceiptLink();
    string GetTransactionId();
    pbcebee16 GetTransactionInfo();
    p8f652ce0 GetTransactionStatus();
    Completable SendReceiptBySMS(string P0);
    Completable SendReceiptEmail(string P0);
    Completable SetTransactionSignature(byte[] P0);
    void Vibrate();
}
