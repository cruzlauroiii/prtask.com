namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2", m533f = "PagingDataTransforms.kt", m534i = {}, m535l = {224, 223}, m536m = "emit", m537n = {}, m538s = {})
public readonly class C0149x5bcfc8c0 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.paging.C0148x894934f3 this$0;

    public C0149x5bcfc8c0(androidx.paging.C0148x894934f3 c0148x894934f3, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = c0148x894934f3;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

