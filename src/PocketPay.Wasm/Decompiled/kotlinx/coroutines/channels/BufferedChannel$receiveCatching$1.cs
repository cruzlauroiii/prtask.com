namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.BufferedChannel", m533f = "BufferedChannel.kt", m534i = {}, m535l = {739}, m536m = "receiveCatching-JP2dKIU$suspendImpl", m537n = {}, m538s = {})
readonly class BufferedChannel$receiveCatching$1<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.channels.BufferedChannel<E> this$0;

    BufferedChannel$receiveCatching$1(kotlinx.coroutines.channels.BufferedChannel<E> bufferedChannel, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.BufferedChannel$receiveCatching$1> continuation) {
        super(continuation);
        this.this$0 = bufferedChannel;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        java.lang.object objM3471receiveCatchingJP2dKIU$suspendImpl = kotlinx.coroutines.channels.BufferedChannel.m3471receiveCatchingJP2dKIU$suspendImpl(this.this$0, this);
        return objM3471receiveCatchingJP2dKIU$suspendImpl != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlinx.coroutines.channels.ChannelResult.m3479boximpl(objM3471receiveCatchingJP2dKIU$suspendImpl) : objM3471receiveCatchingJP2dKIU$suspendImpl;
    }
}

