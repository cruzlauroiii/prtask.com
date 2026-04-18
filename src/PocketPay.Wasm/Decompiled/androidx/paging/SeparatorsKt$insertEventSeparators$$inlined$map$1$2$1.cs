namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SeparatorsKt$insertEventSeparators$$inlined$map$1$2", m533f = "Separators.kt", m534i = {}, m535l = {224, 223}, m536m = "emit", m537n = {}, m538s = {})
public readonly class SeparatorsKt$insertEventSeparators$$inlined$map$1$2$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.paging.SeparatorsKt$insertEventSeparators$$inlined$map$1$2 this$0;

    public SeparatorsKt$insertEventSeparators$$inlined$map$1$2$1(androidx.paging.SeparatorsKt$insertEventSeparators$$inlined$map$1$2 separatorsKt$insertEventSeparators$$inlined$map$1$2, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = separatorsKt$insertEventSeparators$$inlined$map$1$2;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

