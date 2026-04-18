namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.MultiProcessCoordinator", m533f = "MultiProcessCoordinator.android.kt", m534i = {0, 0, 0, 1, 1, 2, 2}, m535l = {211, 47, 48}, m536m = "lock", m537n = {"this", "block", "$this$withLock_u24default$iv", "block", "$this$withLock_u24default$iv", "$this$withLock_u24default$iv", "lock"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$0", "L$2"})
readonly class MultiProcessCoordinator$lock$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.MultiProcessCoordinator this$0;

    MultiProcessCoordinator$lock$1(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, kotlin.coroutines.Continuation<? super androidx.datastore.core.MultiProcessCoordinator$lock$1> continuation) {
        super(continuation);
        this.this$0 = multiProcessCoordinator;
    }

    public static java.lang.object AiIAwZEkVKVOIstR(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation) {
        return multiProcessCoordinator.lock(function1, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return aiIAwZEkVKVOIstR(this.this$0, null, this);
    }
}

