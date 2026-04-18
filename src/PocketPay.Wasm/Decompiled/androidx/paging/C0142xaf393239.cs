namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataTransforms__PagingDataTransformsKt$flatDictionary$$inlined$transform$1$2", m533f = "PagingDataTransforms.kt", m534i = {}, m535l = {225, 223}, m536m = "emit", m537n = {}, m538s = {})
public readonly class C0142xaf393239 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.paging.C0141xdcc0a8ac this$0;

    public C0142xaf393239(androidx.paging.C0141xdcc0a8ac c0141xdcc0a8ac, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = c0141xdcc0a8ac;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

