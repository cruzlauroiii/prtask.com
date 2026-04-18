namespace WillowMaze.Wasm.Decompiled;

public interface P2b91276d
{
    object ClearPaybackReceipts(object P0);
    object ClearPayments(object P0);
    object ClearPositions(object P0);
    object ClearSellReceipts(object P0);
    object DeleteQueueReceipt(p25a7e996 P0, object P1);
    object GetErrorPaybackReceipts(object P0);
    object GetErrorSellReceipts(object P0);
    object GetNotSuccessPaybackReceipts(object P0);
    object GetNotSuccessSellReceipts(object P0);
    object GetPaybackPositionCount(string P0, object P1);
    object GetPaybackPositionsFullCount(string P0, object P1);
    object GetPaybackReceiptWithPositions(string P0, object P1);
    object GetPaybackReceiptsBetweenDateTimes(long P0, long P1, string P2, object P3);
    object GetPaybackReceiptsWithPositions(string P0, object P1);
    object GetQueueReceiptsCount(object P0);
    object GetQueueReceiptsWithPositions(object P0);
    IAsyncEnumerable<object> GetReceiptByUuid(string P0);
    object GetReceiptTotalCount(object P0);
    PagingSource GetReceipts(string P0, long P1, long P2, List<object> P3, List<object> P4);
    object GetSellReceiptWithPositions(string P0, object P1);
    object GetSellReceiptsBetweenDateTimes(long P0, long P1, string P2, object P3);
    object GetSellReceiptsCount(object P0);
    object GetSellReceiptsWithPayback(int P0, int P1, object P2);
    object InsertPaybackReceipt(pa2839366 P0, object P1);
    object InsertPayment(List<object> P0, object P1);
    object InsertPosition(List<object> P0, object P1);
    object InsertQueueReceipt(p25a7e996 P0, object P1);
    object InsertReceiptTotalCount(pa6b2262c P0, object P1);
    object InsertSellReceipt(p36ac2c8d P0, object P1);
    object SavePaybackReceipt(pa2839366 P0, List<object> P1, List<object> P2, object P3);
    object SaveQueuePaybackReceipt(p25a7e996 P0, pa2839366 P1, List<object> P2, List<object> P3, object P4);
    object SaveQueueSellReceipt(p25a7e996 P0, p36ac2c8d P1, List<object> P2, List<object> P3, object P4);
    object SaveReceipts(List<object> P0, object P1);
    object SaveSellReceipt(p36ac2c8d P0, List<object> P1, List<object> P2, object P3);
    object UpdateAllReceipts(List<object> P0, List<object> P1, object P2);
    object UpdatePaybackReceipts(List<object> P0, object P1);
    object UpdatePayment(pe8fa6fcd P0, object P1);
    object UpdateSellReceipts(List<object> P0, object P1);
}
