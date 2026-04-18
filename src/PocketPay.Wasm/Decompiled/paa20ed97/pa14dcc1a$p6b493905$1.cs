namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0001\u0010\u0000\u001a\u0004\u0018\u00010\u0001*\u00060\u0002j\u0002`\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005H\u0080@"}, d2 = {"suspendAndThrow", "", "Ljava/lang/Exception;", "Lkotlin/Exception;", "continuation", "Lkotlin/coroutines/Continuation;", ""}, m527k = 3, mv = {1, 1, 15})
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "paa20ed97.pa14dcc1a", m533f = "KotlinExtensions.kt", m534i = {0}, m535l = {113}, m536m = "suspendAndThrow", m537n = {"$this$suspendAndThrow"}, m538s = {"L$0"})
readonly class pa14dcc1a$p6b493905$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f0d75874c;
    int f40050459;
    java.lang.object f6fa95baa;
    java.lang.object fac0fdc5d;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fdf690513;

    pa14dcc1a$p6b493905$1(kotlin.coroutines.Continuation continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return paa20ed97.pa14dcc1a.suspendAndThrow(null, this);
    }
}

