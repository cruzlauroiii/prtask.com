namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ReceiveChannel$DefaultImpls", m533f = "Channel.kt", m534i = {}, m535l = {372}, m536m = "receiveOrNull", m537n = {}, m538s = {})
readonly class ReceiveChannel$receiveOrNull$1<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;

    ReceiveChannel$receiveOrNull$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ReceiveChannel$receiveOrNull$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.channels.ReceiveChannel$DefaultImpls.receiveOrNull(null, this);
    }
}

