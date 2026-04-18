namespace WillowMaze.Wasm.Decompiled;

public interface P71d96ecc
{
    object ClearCurrentPaybackPayments(object P0);
    object ClearCurrentPaybackPositions(object P0);
    object ClearCurrentPaybackReceipts(object P0);
    object CreateCurrentPaybackReceipt(pe39a6d57 P0, List<object> P1, object P2);
    object CreateSinglePayment(p0fc46d65 P0, object P1);
    object DeleteCurrentPaybackPayment(string P0, object P1);
    object GetCurrentPaybackPayments(object P0);
    object GetCurrentPaybackPositions(object P0);
    object GetCurrentPaybackReceipt(string P0, object P1);
    object InsertPayment(p0fc46d65 P0, object P1);
    object InsertPayments(List<object> P0, object P1);
    object InsertPositions(List<object> P0, object P1);
    object InsertReceipt(pe39a6d57 P0, object P1);
    object RemoveCurrentReceipt(pe39a6d57 P0, object P1);
    object UpdateCurrentPaybackReceipt(pe39a6d57 P0, object P1);
    object UpdatePaymentTransaction(string P0, string P1, string P2, string P3, string P4, string P5, string P6, string P7, object P8);
    object UpdatePosition(pb1f8808e P0, object P1);
    object UpdatePositions(List<object> P0, object P1);
}
