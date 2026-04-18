namespace WillowMaze.Wasm.Decompiled;

public interface Pef9926d1
{
    object ClearCurrentSellReceipts(object P0);
    object CreateCurrentSellReceipt(pf79cee86 P0, List<object> P1, List<object> P2, object P3);
    object CreateSinglePayment(p32a285cf P0, object P1);
    object DeletePayment(p32a285cf P0, object P1);
    object DeletePayments(List<object> P0, object P1);
    object DeletePosition(p0160554c P0, object P1);
    object DeletePositions(List<object> P0, object P1);
    object DeleteReceipt(pf79cee86 P0, object P1);
    object GetCurrentSellReceipt(string P0, object P1);
    object GetLastFastSellPosition(string P0, object P1);
    object GetSellReceiptByType(string P0, string P1, object P2);
    object InsertPayment(p32a285cf P0, object P1);
    object InsertPayments(List<object> P0, object P1);
    object InsertPosition(p0160554c P0, object P1);
    object ReplacePosition(p0160554c P0, p0160554c P1, object P2);
    object SelectReceipt(string P0, string P1, object P2);
    object SetLastSellPosition(string P0, string P1, decimal P2, object P3);
    object UpdatePayment(p32a285cf P0, object P1);
    object UpdatePaymentTransaction(string P0, p85cc901a P1, object P2);
    object UpdatePosition(p0160554c P0, object P1);
    object UpdateReceipt(pf79cee86 P0, object P1);
}
