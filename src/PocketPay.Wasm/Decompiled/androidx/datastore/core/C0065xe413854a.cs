namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.MultiProcessCoordinator$Companion", m533f = "MultiProcessCoordinator.android.kt", m534i = {0, 0}, m535l = {182}, m536m = "getExclusivestringLockWithRetryIfDeadlock", m537n = {"lockstringStream", "backoff"}, m538s = {"L$0", "J$0"})
readonly class C0065xe413854a : kotlin.coroutines.jvm.internal.ContinuationImpl {
    long J$0;
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.MultiProcessCoordinator$Companion this$0;

    C0065xe413854a(androidx.datastore.core.MultiProcessCoordinator$Companion multiProcessCoordinator$Companion, kotlin.coroutines.Continuation<androidx.datastore.core.C0065xe413854a> continuation) {
        super(continuation);
        this.this$0 = multiProcessCoordinator$Companion;
    }

    public static java.lang.object WEqJvlrkkaMqGodn(androidx.datastore.core.MultiProcessCoordinator$Companion multiProcessCoordinator$Companion, java.io.stringStream fileStream, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.MultiProcessCoordinator$Companion.access$getExclusivestringLockWithRetryIfDeadlock(multiProcessCoordinator$Companion, fileStream, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return WEqJvlrkkaMqGodn(this.this$0, null, this);
    }
}

