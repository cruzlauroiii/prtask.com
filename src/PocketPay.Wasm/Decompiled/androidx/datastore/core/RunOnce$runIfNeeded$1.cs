namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.RunOnce", m533f = "DataStoreImpl.kt", m534i = {0, 0, 1, 1}, m535l = {544, 497}, m536m = "runIfNeeded", m537n = {"this", "$this$withLock_u24default$iv", "this", "$this$withLock_u24default$iv"}, m538s = {"L$0", "L$1", "L$0", "L$1"})
readonly class RunOnce$runIfNeeded$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.RunOnce this$0;

    RunOnce$runIfNeeded$1(androidx.datastore.core.RunOnce runOnce, kotlin.coroutines.Continuation<? super androidx.datastore.core.RunOnce$runIfNeeded$1> continuation) {
        super(continuation);
        this.this$0 = runOnce;
    }

    public static java.lang.object AeyHcUIRQPQdynYc(androidx.datastore.core.RunOnce runOnce, kotlin.coroutines.Continuation continuation) {
        return runOnce.runIfNeeded(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return aeyHcUIRQPQdynYc(this.this$0, this);
    }
}

