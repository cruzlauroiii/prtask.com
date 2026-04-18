namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2567a5ec.pb3f20355.p09213d05", m533f = "LKTokenRepositoryImpl.kt", m534i = {0}, m535l = {12, 13}, m536m = "getToken", m537n = {"this"}, m538s = {"L$0"})
readonly class p09213d05$pe7110545$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f08bfc6cb;
    java.lang.object f0f2a9190;
    java.lang.object f937c20b5;
    int fa9cec7b2;
    java.lang.object fb4a88417;
    int fbf286cd0;
    int fd304ba20;
    java.lang.object ff9a7b0ee;
    readonly p2567a5ec.pb3f20355.p09213d05 this$0;

    p09213d05$pe7110545$1(p2567a5ec.pb3f20355.p09213d05 p09213d05Var, kotlin.coroutines.Continuation<? super p2567a5ec.pb3f20355.p09213d05$pe7110545$1> continuation) {
        super(continuation);
        this.this$0 = p09213d05Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getToken(this);
    }
}

