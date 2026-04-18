namespace WillowMaze.Wasm.Decompiled;

public interface P5701b2ff
{
    object GetPaymentTransaction(p9ded6185 P0, string P1, object P2);
    object GetReceiptLink(p9ded6185 P0, string P1, object P2);
    object GetTransactionFromHistory(p514d8a49 P0, p9ded6185 P1, string P2, object P3);
    object SendReceiptToEmail(p9ded6185 P0, string P1, string P2, object P3);
    object SendReceiptToPhone(p9ded6185 P0, string P1, string P2, object P3);
}
