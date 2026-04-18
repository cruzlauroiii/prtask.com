namespace WillowMaze.Wasm.Decompiled;

public interface P4802a698
{
    object GetNotSuccessReceiptsUuids(object P0);
    IAsyncEnumerable<object> GetPagedReceipts(pc77da2af P0);
    IAsyncEnumerable<object> GetReceiptByUuid(string P0);
    object HasErrorReceipts(object P0);
    object IsFullPaybackReceipt(string P0, object P1);
    object UpdateReceiptsStatus(List<object> P0, object P1);
}
