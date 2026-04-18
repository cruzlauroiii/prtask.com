namespace WillowMaze.Wasm.Decompiled;

public interface Pab691ef3
{
    object AddPaymentToReceipt(pad7c4a1f P0, object P1);
    pad7c4a1f CreatePayment(p8c261c90 P0, decimal P1);
    object GetCurrentSellPayments(object P0);
    object GetCurrentSellReceipt(object P0);
    object RemoveAllPaymentsFromReceipt(object P0);
    object RemovePaymentFromReceipt(pad7c4a1f P0, object P1);
    object UpdatePayment(pad7c4a1f P0, object P1);
}
