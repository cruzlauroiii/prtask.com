namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p1e11b989.p9acb4454.pac143fb7.p50496a4d", m533f = "ReceiptStatusUseCaseImpl.kt", m534i = {0}, m535l = {31, 32}, m536m = "updateReceiptsStatus", m537n = {"this"}, m538s = {"L$0"})
readonly class p50496a4d$p29f5c9af$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f231cb9fe;
    int f2ce89b99;
    int f4217cc9f;
    int f5e21f865;
    int fb31aac8e;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p1e11b989.p9acb4454.pac143fb7.p50496a4d this$0;

    p50496a4d$p29f5c9af$1(p1e11b989.p9acb4454.pac143fb7.p50496a4d p50496a4dVar, kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.pac143fb7.p50496a4d$p29f5c9af$1> continuation) {
        super(continuation);
        this.this$0 = p50496a4dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.updateReceiptsStatus(this);
    }
}

