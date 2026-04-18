namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataTransforms__PagingDataTransformsKt$filter$$inlined$transform$1$2", m533f = "PagingDataTransforms.kt", m534i = {}, m535l = {225, 223}, m536m = "emit", m537n = {}, m538s = {})
public readonly class C0139x3ef3ef22 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.paging.C0138x4aa78bd5 this$0;

    public C0139x3ef3ef22(androidx.paging.C0138x4aa78bd5 c0138x4aa78bd5, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = c0138x4aa78bd5;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

