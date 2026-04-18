namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$lambda$5$$inlined$map$1$2", m533f = "PageFetcherSnapshot.kt", m534i = {}, m535l = {223}, m536m = "emit", m537n = {}, m538s = {})
public readonly class C0136x9c78ba7e : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.paging.C0135xb65f7e31 this$0;

    public C0136x9c78ba7e(androidx.paging.C0135xb65f7e31 c0135xb65f7e31, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = c0135xb65f7e31;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

