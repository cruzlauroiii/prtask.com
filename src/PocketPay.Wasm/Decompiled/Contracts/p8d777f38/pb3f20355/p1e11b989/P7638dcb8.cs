namespace WillowMaze.Wasm.Decompiled;

public interface P7638dcb8
{
    object ClearPaybackReceipts(object P0);
    object ClearSellReceipts(object P0);
    object DeleteQueueReceipt(p93478e59 P0, object P1);
    object GetNotSuccessReceiptsUuids(object P0);
    object GetPaybackPositionsInfoFromDb(string P0, object P1);
    object GetPaybackReceipt(string P0, object P1);
    object GetPaybackReceiptsBetweenDateTimes(long P0, long P1, string P2, object P3);
    object GetPaybackReceiptsBySellReceiptUuid(string P0, object P1);
    object GetQueueReceipts(object P0);
    object GetQueueReceiptsCount(object P0);
    IAsyncEnumerable<object> GetReceiptByUuid(string P0);
    PagingSource GetReceipts(pd751e33c P0, long P1, long P2, List<object> P3, List<object> P4);
    object GetSellReceipt(string P0, object P1);
    object GetSellReceipts(int P0, int P1, object P2);
    object GetSellReceiptsBetweenDateTimes(long P0, long P1, string P2, object P3);
    object GetSellReceiptsCount(object P0);
    object HasErrorReceipts(object P0);
    object InsertReceiptTotalCount(int P0, object P1);
    object IsFullPaybackReceipt(string P0, object P1);
    object SavePaybackReceipt(p18cf5223 P0, string P1, object P2);
    object SaveQueuePaybackReceipt(p18cf5223 P0, string P1, object P2);
    object SaveQueueSellReceipt(ped663a3e P0, string P1, object P2);
    object SaveReceipts(List<object> P0, object P1);
    object SaveSellReceipt(ped663a3e P0, string P1, object P2);
    object UpdatePayment(pad7c4a1f P0, string P1, object P2);
    object UpdateReceiptsStatus(List<object> P0, object P1);
}
