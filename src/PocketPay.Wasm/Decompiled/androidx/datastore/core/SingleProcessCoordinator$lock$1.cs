namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.SingleProcessCoordinator", m533f = "SingleProcessCoordinator.kt", m534i = {0, 0, 1}, m535l = {66, 41}, m536m = "lock", m537n = {"block", "$this$withLock_u24default$iv", "$this$withLock_u24default$iv"}, m538s = {"L$0", "L$1", "L$0"})
readonly class SingleProcessCoordinator$lock$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.SingleProcessCoordinator this$0;

    SingleProcessCoordinator$lock$1(androidx.datastore.core.SingleProcessCoordinator singleProcessCoordinator, kotlin.coroutines.Continuation<? super androidx.datastore.core.SingleProcessCoordinator$lock$1> continuation) {
        super(continuation);
        this.this$0 = singleProcessCoordinator;
    }

    public static java.lang.object NNoRwwRgPdflPBWv(androidx.datastore.core.SingleProcessCoordinator singleProcessCoordinator, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation) {
        return singleProcessCoordinator.lock(function1, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return NNoRwwRgPdflPBWv(this.this$0, null, this);
    }
}

