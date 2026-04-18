namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p7ac90152", m533f = "SellReceiptDbRepositoryImpl.kt", m534i = {}, m535l = {30}, m536m = "getCurrentSellReceipt", m537n = {}, m538s = {})
readonly class p7ac90152$p661f6c0a$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f5399cfc2;
    java.lang.object f8da8f364;
    int fb091176c;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p8325324b.pb3f20355.p7ac90152 this$0;

    p7ac90152$p661f6c0a$1(p8325324b.pb3f20355.p7ac90152 p7ac90152Var, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p7ac90152$p661f6c0a$1> continuation) {
        super(continuation);
        this.this$0 = p7ac90152Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getCurrentSellReceipt(null, this);
    }
}

