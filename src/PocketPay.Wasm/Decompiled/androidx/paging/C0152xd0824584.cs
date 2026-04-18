namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$filter$$inlined$transform$1$2", m533f = "PagingDataTransforms.jvm.kt", m534i = {}, m535l = {225, 223}, m536m = "emit", m537n = {}, m538s = {})
public readonly class C0152xd0824584 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.paging.C0151xaf3c12b7 this$0;

    public C0152xd0824584(androidx.paging.C0151xaf3c12b7 c0151xaf3c12b7, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = c0151xaf3c12b7;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

