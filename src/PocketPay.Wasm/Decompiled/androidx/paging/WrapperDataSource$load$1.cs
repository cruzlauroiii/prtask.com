namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.WrapperDataSource", m533f = "WrapperDataSource.jvm.kt", m534i = {0}, m535l = {68}, m536m = "load$suspendImpl", m537n = {"$this"}, m538s = {"L$0"})
readonly class WrapperDataSource$load$1<Key, ValueFrom, ValueTo> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.paging.WrapperDataSource<Key, ValueFrom, ValueTo> this$0;

    WrapperDataSource$load$1(androidx.paging.WrapperDataSource<Key, ValueFrom, ValueTo> wrapperDataSource, kotlin.coroutines.Continuation<? super androidx.paging.WrapperDataSource$load$1> continuation) {
        super(continuation);
        this.this$0 = wrapperDataSource;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.paging.WrapperDataSource.load$suspendImpl(this.this$0, null, this);
    }
}

