namespace WillowMaze.Wasm.Decompiled;

public interface Pa36ef9b5
{
    object AddPositionToPayback(pd031d465 P0, object P1);
    object AddPositionToReceipt(pd031d465 P0, object P1);
    object CheckDuplicateReceipt(string P0, object P1);
    object ClearPaybackPositions(object P0);
    object CreatePaybackReceipt(ped663a3e P0, object P1);
    object GetActualPositionUUID(p4cc9492b$pca87b160 P0, object P1);
    object GetCurrentPaybackReceipt(object P0);
    object GetNotePaybackReceipt(object P0);
    IAsyncEnumerable<object> GetPagedSellReceipts();
    object GetPaybackPositions(object P0);
    object GetPaybackReceiptNumber(object P0);
    object GetPaybackReceiptType(object P0);
    object GetPaybackReceiptsBySellReceiptUuid(string P0, object P1);
    pd031d465 GetPositionWithoutMarkByNotNullCommodityId(List<object> P0, pd031d465 P1);
    object GetPositionsForPaybackByQuery(string P0, string P1, object P2);
    object GetPositionsForPaybackFromDb(string P0, object P1);
    object GetPositionsForPaybackReceipt(object P0);
    object GetQuantityPaybackPositionByUuid(string P0, object P1);
    object GetQuantityPositionForPaybackByUuid(string P0, object P1);
    object GetSellReceiptForPayback(string P0, object P1);
    object GetShouldPrintReceipt(object P0);
    object IncreasePositionQuantity(pd031d465 P0, pd031d465 P1, object P2);
    bool IsAnimationNotePreviewShown();
    bool IsAnimationPreviewShown();
    object OpenSinglePaymentIfNeeded(object P0);
    object RemoveCurrentPaybackReceipt(object P0);
    object RemovePositionFromPayback(pd031d465 P0, object P1);
    object ReplacePosition(pd031d465 P0, object P1);
    void SetAnimationNotePreviewIsShown();
    void SetAnimationPreviewIsShown();
    object SetNotePaybackReceipt(string P0, object P1);
    object SetPaymentAddress(string P0, object P1);
    object SetPaymentPlace(string P0, object P1);
    object SetPaymentType(p8c261c90 P0, object P1);
    object SetReceiptClientEmail(string P0, object P1);
    object SetReceiptClientPhone(string P0, object P1);
    object SetShouldPrintReceipt(bool P0, object P1);
    object SetTransactionToFirstPayment(pf8872840 P0, object P1);
    object UpdateReceiptDiscount(object P0);
}
