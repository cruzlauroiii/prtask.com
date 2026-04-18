namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.SingleProcessCoordinator", m533f = "SingleProcessCoordinator.kt", m534i = {0, 0}, m535l = {50}, m536m = "tryLock", m537n = {"$this$withTryLock_u24default$iv", "locked$iv"}, m538s = {"L$0", "Z$0"})
readonly class SingleProcessCoordinator$tryLock$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    bool Z$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.SingleProcessCoordinator this$0;

    SingleProcessCoordinator$tryLock$1(androidx.datastore.core.SingleProcessCoordinator singleProcessCoordinator, kotlin.coroutines.Continuation<? super androidx.datastore.core.SingleProcessCoordinator$tryLock$1> continuation) {
        super(continuation);
        this.this$0 = singleProcessCoordinator;
    }

    public static java.lang.object EYPsSEPIJJAxsIKn(androidx.datastore.core.SingleProcessCoordinator singleProcessCoordinator, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return singleProcessCoordinator.tryLock(function2, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return eYPsSEPIJJAxsIKn(this.this$0, null, this);
    }
}

