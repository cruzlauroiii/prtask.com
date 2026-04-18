namespace WillowMaze.Wasm.Decompiled;

public interface P8eeb7ddb
{
    object ClearCurrentPaybackPositions(object P0);
    object ClearCurrentPaybackReceipts(object P0);
    object CreateCurrentPaybackReceipt(pe39a6d57 P0, List<object> P1, object P2);
    object CreateSinglePayment(p0fc46d65 P0, object P1);
    object DeletePayment(string P0, object P1);
    object DeletePayments(object P0);
    object GetCurrentPaybackPayments(object P0);
    object GetCurrentPaybackPositions(object P0);
    object GetCurrentPaybackReceipt(string P0, object P1);
    object InsertPayment(p0fc46d65 P0, object P1);
    object RemoveCurrentReceipt(pe39a6d57 P0, object P1);
    object UpdateCurrentPaybackPosition(pb1f8808e P0, object P1);
    object UpdateCurrentPaybackPositions(List<object> P0, object P1);
    object UpdateCurrentPaybackReceipt(pe39a6d57 P0, object P1);
    object UpdatePaymentTransaction(string P0, p85cc901a P1, object P2);
}
