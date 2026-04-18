namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p6a959b9c", m533f = "CurrentPaybackReceiptDbRepositoryImpl.kt", m534i = {}, m535l = {37}, m536m = "getCurrentPaybackReceipt", m537n = {}, m538s = {})
readonly class p6a959b9c$p194f5207$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f10132b3e;
    int f1737c6d4;
    int f3486b789;
    java.lang.object f3c30896a;
    java.lang.object fa8d69cca;
    java.lang.object fb4a88417;
    int fcfa28bd1;
    int fd304ba20;
    java.lang.object fd83455ab;
    readonly p4670093c.pb3f20355.p6a959b9c this$0;

    p6a959b9c$p194f5207$1(p4670093c.pb3f20355.p6a959b9c p6a959b9cVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p6a959b9c$p194f5207$1> continuation) {
        super(continuation);
        this.this$0 = p6a959b9cVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getCurrentPaybackReceipt(null, this);
    }
}

