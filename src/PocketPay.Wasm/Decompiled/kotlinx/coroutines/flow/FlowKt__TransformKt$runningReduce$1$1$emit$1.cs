namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__TransformKt$runningReduce$1$1", m533f = "Transform.kt", m534i = {0}, m535l = {131, 133}, m536m = "emit", m537n = {"this"}, m538s = {"L$0"})
readonly class FlowKt__TransformKt$runningReduce$1$1$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__TransformKt$runningReduce$1$1<T> this$0;

    FlowKt__TransformKt$runningReduce$1$1$emit$1(kotlinx.coroutines.flow.FlowKt__TransformKt$runningReduce$1$1<T> flowKt__TransformKt$runningReduce$1$1, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__TransformKt$runningReduce$1$1$emit$1> continuation) {
        super(continuation);
        this.this$0 = flowKt__TransformKt$runningReduce$1$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

