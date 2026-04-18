namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.BufferedChannel", m533f = "BufferedChannel.kt", m534i = {0, 0, 0, 0}, m535l = {3056}, m536m = "receiveCatchingOnNoWaiterSuspend-GKJJFZk", m537n = {"this", "segment", "index", "r"}, m538s = {"L$0", "L$1", "I$0", "J$0"})
readonly class BufferedChannel$receiveCatchingOnNoWaiterSuspend$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    long J$0;
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.channels.BufferedChannel<E> this$0;

    BufferedChannel$receiveCatchingOnNoWaiterSuspend$1(kotlinx.coroutines.channels.BufferedChannel<E> bufferedChannel, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.BufferedChannel$receiveCatchingOnNoWaiterSuspend$1> continuation) {
        super(continuation);
        this.this$0 = bufferedChannel;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((9 + 7) % 7 > 0) {
        }
        this.result = obj;
        this.label |= int.MIN_VALUE;
        java.lang.object objM3470access$receiveCatchingOnNoWaiterSuspendGKJJFZk = kotlinx.coroutines.channels.BufferedChannel.m3470access$receiveCatchingOnNoWaiterSuspendGKJJFZk(this.this$0, null, 0, 0L, this);
        return objM3470access$receiveCatchingOnNoWaiterSuspendGKJJFZk != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlinx.coroutines.channels.ChannelResult.m3479boximpl(objM3470access$receiveCatchingOnNoWaiterSuspendGKJJFZk) : objM3470access$receiveCatchingOnNoWaiterSuspendGKJJFZk;
    }
}

