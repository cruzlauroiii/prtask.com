namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.list.SellReceiptListForPaybackobject$observeSellReceiptsLoadState$1$1$invokeSuspend$$inlined$map$1$2", m533f = "SellReceiptListForPaybackobject.kt", m534i = {}, m535l = {223}, m536m = "emit", m537n = {}, m538s = {})
public readonly class C0494xc4ea50e5 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f1b7b6675;
    int f5109a5d8;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p4670093c.p2486923a.p10ae9fc7.C0493x8f418258 this$0;

    public C0494xc4ea50e5(p4670093c.p2486923a.p10ae9fc7.C0493x8f418258 c0493x8f418258, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = c0493x8f418258;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

