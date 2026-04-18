namespace WillowMaze.Wasm.Decompiled;

public class Pf38d8cc7 : PagingSource
{
    private readonly p7638dcb8 F1e9486a4;
    private readonly p7638dcb8 Ff2fed930;

    public int GetRefreshKey(PagingState P0)
    {
        // str: "state"
        // call: Intrinsics.checkNotNullParameter
        // call: PagingState.getAnchorPosition
        // call: PagingSource$LoadResult$Page.getNextKey
        // call: PagingState.closestPageToPosition
        // call: int.valueOf
        // call: int.intValue
        // call: PagingSource$LoadResult$Page.getPrevKey
        return 0;
    }

    public object GetRefreshKey(PagingState P0)
    {
        // call: pf38d8cc7.getRefreshKey
        return default!;
    }

    public object Load(PagingSource$LoadParams P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: int.intValue
        // call: IllegalStateException.<init>
        // call: ResultKt.throwOnFailure
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: PagingSource$LoadParams.getKey
        // call: pf38d8cc7$pec4d1eb3$1.<init>
        // call: PagingSource$LoadParams.getLoadSize
        // call: p7638dcb8.getSellReceiptsCount
        // call: System.Numerics.BigInteger.intValue
        // call: p1e021f83.<init>
        // call: PagingSource$LoadResult$Error.<init>
        // call: Ref$IntRef.<init>
        // call: p7638dcb8.getSellReceipts
        // call: CollectionsKt.collectionSizeOrDefault
        // call: List<object>.<init>
        // call: IEnumerable<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: Boxing.boxInt
        // call: ped663a3e.m1c1e012b
        // field: p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1.fd304ba20
        // field: p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1.L$1
        // field: p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1.L$0
        // field: p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1.I$1
        // field: p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1.I$0
        // field: p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1.fb4a88417
        // field: p4670093c.pb3f20355.pf38d8cc7.ff2fed930
        // field: kotlin.jvm.internal.Ref$IntRef.element
        // type: PagingSource$LoadResult$Error
        // type: IllegalStateException
        // type: pf38d8cc7$pec4d1eb3$1
        // type: p1e021f83
        // type: Ref$IntRef
        // type: List<object>
        // type: PagingSource$LoadResult$Page
        return default!;
    }

}
