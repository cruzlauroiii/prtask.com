namespace WillowMaze.Wasm.Decompiled;

public interface P3851083a
{
    object AddPaymentToReceipt(pad7c4a1f P0, object P1);
    object AddPositionToReceipt(pd031d465 P0, object P1);
    object CheckDuplicateReceipt(string P0, object P1);
    object ClearCurrentSellReceipts(object P0);
    object ClearReceiptDiscount(object P0);
    object ClearSellReceipts(object P0);
    object GetNoteReceipt(object P0);
    object GetReceiptPayments(object P0);
    object GetReceiptPositions(object P0);
    object HasUnfinishedReceipt(object P0);
    object IncreasePositionQuantity(pd031d465 P0, decimal P1, object P2);
    object OpenEmptySellReceipt(object P0);
    object OpenNotEmptySellReceipt(ped663a3e P0, object P1);
    object OpenOrEditSellReceipt(object P0);
    object OpenSinglePaymentIfNeeded(object P0);
    object RemoveAllPaymentsFromReceipt(object P0);
    object RemoveAllPositionsFromReceipt(object P0);
    object RemoveCurrentReceipt(object P0);
    object RemovePaymentFromReceipt(pad7c4a1f P0, object P1);
    object RemovePositionFromReceipt(pd031d465 P0, object P1);
    object ReplacePosition(pd031d465 P0, pd031d465 P1, object P2);
    object SetNoteReceipt(string P0, object P1);
    object SetPaymentAddress(string P0, object P1);
    object SetPaymentPlace(string P0, object P1);
    object SetPaymentType(p8c261c90 P0, object P1);
    object SetQRPayInfo(pc5f0acf1 P0, object P1);
    object SetReceiptClientEmail(string P0, object P1);
    object SetReceiptClientPhone(string P0, object P1);
    object SetShouldPrintReceipt(bool P0, object P1);
    object SetTransactionToFirstPayment(pf8872840 P0, object P1);
    object UpdatePayment(pad7c4a1f P0, string P1, object P2);
    object UpdatePayment(pad7c4a1f P0, object P1);
    object UpdatePosition(pd031d465 P0, object P1);
    object UpdateReceiptDiscount(decimal P0, object P1);
}
