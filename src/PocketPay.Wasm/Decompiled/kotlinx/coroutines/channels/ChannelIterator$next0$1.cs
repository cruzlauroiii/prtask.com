namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelIEnumerator$DefaultImpls", m533f = "Channel.kt", m534i = {0}, m535l = {589}, m536m = "next", m537n = {"$this"}, m538s = {"L$0"})
readonly class ChannelIEnumerator$next0$1<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;

    ChannelIEnumerator$next0$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelIEnumerator$next0$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.channels.ChannelIEnumerator$DefaultImpls.next(null, this);
    }
}

