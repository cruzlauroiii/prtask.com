namespace WillowMaze.Wasm.Decompiled;

public interface P24ddebba
{
    object AddPaymentToReceipt(pad7c4a1f P0, object P1);
    object AddPositionToPayback(pd031d465 P0, object P1);
    object CheckDuplicateReceipt(string P0, object P1);
    object ClearCurrentPaybackReceipts(object P0);
    object ClearPaybackPositions(object P0);
    object ClearPaybackReceipts(object P0);
    object CreatePaybackReceipt(ped663a3e P0, string P1, string P2, string P3, object P4);
    object GetCurrentPaybackPayments(object P0);
    object GetNotePaybackReceipt(object P0);
    IAsyncEnumerable<object> GetPagedSellReceipts();
    object GetPaybackPaymentsInfo(object P0);
    object GetPaybackPositions(object P0);
    object GetPaybackReceiptNumber(object P0);
    object GetPaybackReceiptType(object P0);
    object GetPaybackReceiptsBySellReceiptUuid(string P0, object P1);
    object GetPositionsForPaybackByQuery(string P0, string P1, object P2);
    object GetPositionsForPaybackFromDb(string P0, object P1);
    object GetPositionsForPaybackReceipt(object P0);
    object GetSellReceipt(string P0, object P1);
    object GetShouldPrintReceipt(object P0);
    object IncreasePositionQuantity(pd031d465 P0, pd031d465 P1, object P2);
    object OpenSinglePaymentIfNeeded(object P0);
    object RemoveAllPaymentsFromReceipt(object P0);
    object RemoveCurrentReceipt(object P0);
    object RemovePaymentFromReceipt(string P0, object P1);
    object RemovePositionFromPayback(pd031d465 P0, object P1);
    object ReplacePosition(pd031d465 P0, object P1);
    object SavePaybackReceipt(p18cf5223 P0, string P1, object P2);
    object SaveQueuePaybackReceipt(p18cf5223 P0, string P1, object P2);
    object SetNotePaybackReceipt(string P0, object P1);
    object SetPaymentAddress(string P0, object P1);
    object SetPaymentPlace(string P0, object P1);
    object SetPaymentType(p8c261c90 P0, object P1);
    object SetReceiptClientEmail(string P0, object P1);
    object SetReceiptClientPhone(string P0, object P1);
    object SetShouldPrintReceipt(bool P0, object P1);
    object SetTransactionToFirstPayment(pf8872840 P0, object P1);
    object UpdateReceiptDiscount(decimal P0, object P1);
}
