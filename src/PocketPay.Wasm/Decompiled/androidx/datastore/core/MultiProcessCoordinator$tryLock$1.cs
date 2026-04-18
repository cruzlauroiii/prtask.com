namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.MultiProcessCoordinator", m533f = "MultiProcessCoordinator.android.kt", m534i = {0, 0, 1, 1, 1}, m535l = {62, 87}, m536m = "tryLock", m537n = {"$this$withTryLock_u24default$iv", "locked$iv", "$this$withTryLock_u24default$iv", "lock", "locked$iv"}, m538s = {"L$0", "Z$0", "L$0", "L$2", "Z$0"})
readonly class MultiProcessCoordinator$tryLock$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    bool Z$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.MultiProcessCoordinator this$0;

    MultiProcessCoordinator$tryLock$1(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, kotlin.coroutines.Continuation<? super androidx.datastore.core.MultiProcessCoordinator$tryLock$1> continuation) {
        super(continuation);
        this.this$0 = multiProcessCoordinator;
    }

    public static java.lang.object LlKlbjjOPFpQmdCi(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return multiProcessCoordinator.tryLock(function2, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return llKlbjjOPFpQmdCi(this.this$0, null, this);
    }
}

