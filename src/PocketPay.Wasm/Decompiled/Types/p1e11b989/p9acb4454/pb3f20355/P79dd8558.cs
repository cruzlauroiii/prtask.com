namespace WillowMaze.Wasm.Decompiled;

public class P79dd8558 : P5926f3a5
{
    private readonly pfc4f327e F084c9fad;
    private readonly pfc4f327e Fab9c8018;
    private readonly pfc4f327e Fd3a22299;
    private readonly pfc4f327e Ff5378e9d;

    public object GetReceipts(string P0, int P1, int P2, long P3, long P4, List<object> P5, List<object> P6, string P7, string P8, object P9)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // str: "Error while loading receipts"
        // call: Exception.<init>
        // call: Response.isSuccessful
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p79dd8558$pbf619c3e$1.<init>
        // call: Response.body
        // call: IllegalStateException.<init>
        // call: ResultKt.throwOnFailure
        // call: pfc4f327e.getReceipts
        // field: p1e11b989.p9acb4454.pb3f20355.p79dd8558$pbf619c3e$1.fd304ba20
        // field: p1e11b989.p9acb4454.pb3f20355.p79dd8558$pbf619c3e$1.fb4a88417
        // field: p1e11b989.p9acb4454.pb3f20355.p79dd8558.fab9c8018
        // type: IllegalStateException
        // type: p79dd8558$pbf619c3e$1
        // type: Exception
        return default!;
    }

    public object GetReceiptsStatus(List<object> P0, object P1)
    {
        // call: CollectionsKt.emptyList
        return default!;
    }

}
