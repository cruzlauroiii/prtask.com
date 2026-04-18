namespace WillowMaze.Wasm.Decompiled;

public interface P883b57c7
{
    IAsyncEnumerable<object> GetPagedReceipts(pc77da2af P0);
    IAsyncEnumerable<object> GetReceiptByUuid(string P0);
    IAsyncEnumerable<object> GetReceiptPositionsByQuery(string P0, string P1);
    object HasErrorReceipts(object P0);
    object IsFullPaybackReceipt(string P0, object P1);
    object LoadReceiptsStatus(object P0);
    object UpdateReceiptsStatus(object P0);
}
