namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.model.payback.TophCancel$Companion", m533f = "TophCancel.kt", m534i = {}, m535l = {24}, m536m = "initPayback", m537n = {}, m538s = {})
readonly class p643ce821$p910eef8c$p6d9e0861$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f0ffcd3d6;
    java.lang.object f736797ef;
    java.lang.object f8a7186a5;
    java.lang.object fb10a5ba4;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c this$0;

    p643ce821$p910eef8c$p6d9e0861$1(p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c p643ce821_p910eef8c, kotlin.coroutines.Continuation<? super p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c$p6d9e0861$1> continuation) {
        super(continuation);
        this.this$0 = p643ce821_p910eef8c;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((1 + 4) % 4 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initPayback(null, 0L, null, this);
    }
}

