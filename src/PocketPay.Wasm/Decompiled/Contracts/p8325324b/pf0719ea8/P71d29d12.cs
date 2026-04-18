namespace WillowMaze.Wasm.Decompiled;

public interface P71d29d12
{
    object ClearCurrentSellPayments(object P0);
    object ClearCurrentSellReceipts(object P0);
    object CreateCurrentSellReceipt(pf79cee86 P0, List<object> P1, List<object> P2, object P3);
    object CreateSinglePayment(p32a285cf P0, object P1);
    object DeletePayment(p32a285cf P0, object P1);
    object DeletePayments(List<object> P0, object P1);
    object DeletePosition(p0160554c P0, object P1);
    object DeletePositions(List<object> P0, object P1);
    object DeleteReceipt(pf79cee86 P0, object P1);
    object GetCurrentSellReceipt(string P0, object P1);
    object GetSellReceiptByType(string P0, string P1, object P2);
    object InsertPayment(p32a285cf P0, object P1);
    object InsertPayments(List<object> P0, object P1);
    object InsertPosition(p0160554c P0, object P1);
    object InsertPositions(List<object> P0, object P1);
    object InsertReceipt(pf79cee86 P0, object P1);
    object ReplacePosition(p0160554c P0, p0160554c P1, object P2);
    object SelectCurrentReceipt(string P0, string P1, object P2);
    object SelectReceipt(string P0, string P1, object P2);
    object UnselectReceipts(string P0, object P1);
    object UpdatePayment(p32a285cf P0, object P1);
    object UpdatePaymentTransaction(string P0, string P1, string P2, string P3, string P4, string P5, string P6, string P7, object P8);
    object UpdatePosition(p0160554c P0, object P1);
    object UpdateReceipt(pf79cee86 P0, object P1);
}
