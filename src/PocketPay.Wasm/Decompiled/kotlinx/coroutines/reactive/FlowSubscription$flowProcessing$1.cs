namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.reactive.FlowSubscription", m533f = "ReactiveFlow.kt", m534i = {0}, m535l = {209}, m536m = "flowProcessing", m537n = {"this"}, m538s = {"L$0"})
readonly class FlowSubscription$flowProcessing$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.reactive.FlowSubscription<T> this$0;

    FlowSubscription$flowProcessing$1(kotlinx.coroutines.reactive.FlowSubscription<T> flowSubscription, kotlin.coroutines.Continuation<? super kotlinx.coroutines.reactive.FlowSubscription$flowProcessing$1> continuation) {
        super(continuation);
        this.this$0 = flowSubscription;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.reactive.FlowSubscription.access$flowProcessing(this.this$0, this);
    }
}

