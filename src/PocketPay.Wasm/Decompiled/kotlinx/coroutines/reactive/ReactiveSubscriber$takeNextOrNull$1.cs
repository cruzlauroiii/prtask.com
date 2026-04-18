namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.reactive.ReactiveSubscriber", m533f = "ReactiveFlow.kt", m534i = {}, m535l = {129}, m536m = "takeNextOrNull", m537n = {}, m538s = {})
readonly class ReactiveSubscriber$takeNextOrNull$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.reactive.ReactiveSubscriber<T> this$0;

    ReactiveSubscriber$takeNextOrNull$1(kotlinx.coroutines.reactive.ReactiveSubscriber<T> reactiveSubscriber, kotlin.coroutines.Continuation<? super kotlinx.coroutines.reactive.ReactiveSubscriber$takeNextOrNull$1> continuation) {
        super(continuation);
        this.this$0 = reactiveSubscriber;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.takeNextOrNull(this);
    }
}

