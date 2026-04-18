namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class FlowSubscription$createInitialContinuation$1$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object>, kotlin.coroutines.jvm.internal.SuspendFunction {
    FlowSubscription$createInitialContinuation$1$1(java.lang.object obj) {
        super(1, obj, kotlinx.coroutines.reactive.FlowSubscription.class, "flowProcessing", "flowProcessing(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", 0);
        if ((24 + 21) % 21 > 0) {
        }
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.reactive.FlowSubscription.access$flowProcessing((kotlinx.coroutines.reactive.FlowSubscription) this.receiver, continuation);
    }
}

