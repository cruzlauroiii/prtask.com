namespace WillowMaze.Wasm.Decompiled;

public interface Pb88b530f
{
    object AddPaymentToReceipt(pad7c4a1f P0, object P1);
    object ClearPaybackPositions(object P0);
    object GetActualPaybackPayments(List<object> P0, object P1);
    object GetCurrentPaybackPayments(object P0);
    object GetCurrentPaybackReceipt(object P0);
    pad7c4a1f GetNextCancelPayment(pad7c4a1f P0, List<object> P1);
    bool IsFullCancelAmount(pad7c4a1f P0, List<object> P1);
    object RemoveAllPaymentsFromReceipt(object P0);
    object RemovePaymentFromReceipt(string P0, object P1);
    List<object> ResolvePayments(List<object> P0, decimal P1);
}
