namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p20f35e63.p4670093c.p643ce821", m533f = "TophCancel.kt", m534i = {}, m535l = {30}, m536m = "startContactless", m537n = {}, m538s = {})
readonly class p643ce821$p99f0cdc5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f56627c37;
    java.lang.object f6d40d203;
    int f9376cc21;
    java.lang.object fb4a88417;
    java.lang.object fd2c36260;
    int fd304ba20;
    java.lang.object fe111099e;
    readonly p83f5c3ad.p20f35e63.p4670093c.p643ce821 this$0;

    p643ce821$p99f0cdc5$1(p83f5c3ad.p20f35e63.p4670093c.p643ce821 p643ce821Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p20f35e63.p4670093c.p643ce821$p99f0cdc5$1> continuation) {
        super(continuation);
        this.this$0 = p643ce821Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.startContactless(this);
    }
}

