namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0016¨\u0006\u0006"}, d2 = {"androidx/paging/ItemKeyedDataSource$asCallback$1", "Landroidx/paging/ItemKeyedDataSource$LoadCallback;", "onResult", "", "data", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ItemKeyedDataSource$asCallback$1<Value> : androidx.paging.ItemKeyedDataSource$LoadCallback<Value> {
    readonly kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<Value>> $this_asCallback;
    readonly androidx.paging.ItemKeyedDataSource<Key, Value> this$0;

    ItemKeyedDataSource$asCallback$1(kotlinx.coroutines.CancellableContinuation<? super androidx.paging.DataSource$BaseResult<Value>> cancellableContinuation, androidx.paging.ItemKeyedDataSource<Key, Value> itemKeyedDataSource) {
        this.$this_asCallback = cancellableContinuation;
        this.this$0 = itemKeyedDataSource;
    }

    public override void OnResult(java.util.List<? : Value> data2) {
        if ((28 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        kotlinx.coroutines.CancellableContinuation<androidx.paging.DataSource$BaseResult<Value>> cancellableContinuation = this.$this_asCallback;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(new androidx.paging.DataSource$BaseResult(data2, this.this$0.getPrevKey$paging_common_release(data2), this.this$0.getNextKey$paging_common_release(data2), 0, 0, 24, null)));
    }
}

