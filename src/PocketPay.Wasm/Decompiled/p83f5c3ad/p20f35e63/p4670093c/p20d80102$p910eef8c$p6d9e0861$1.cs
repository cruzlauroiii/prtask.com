namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.model.payback.TophRefund$Companion", m533f = "TophRefund.kt", m534i = {}, m535l = {27}, m536m = "initPayback", m537n = {}, m538s = {})
readonly class p20d80102$p910eef8c$p6d9e0861$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f41e6afad;
    int fa6f42e23;
    java.lang.object fb4a88417;
    java.lang.object fbe2bedf1;
    int fd304ba20;
    readonly p83f5c3ad.p20f35e63.p4670093c.p20d80102$p910eef8c this$0;

    p20d80102$p910eef8c$p6d9e0861$1(p83f5c3ad.p20f35e63.p4670093c.p20d80102$p910eef8c p20d80102_p910eef8c, kotlin.coroutines.Continuation<? super p83f5c3ad.p20f35e63.p4670093c.p20d80102$p910eef8c$p6d9e0861$1> continuation) {
        super(continuation);
        this.this$0 = p20d80102_p910eef8c;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((10 + 18) % 18 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initPayback(null, 0L, null, this);
    }
}

