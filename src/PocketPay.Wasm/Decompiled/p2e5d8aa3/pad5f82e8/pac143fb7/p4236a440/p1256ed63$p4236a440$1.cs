namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.pad5f82e8.pac143fb7.p4236a440.p1256ed63", m533f = "ConsoleoutUseCaseImpl.kt", m534i = {0, 1}, m535l = {43, 52}, m536m = "logout", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class p1256ed63$p4236a440$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f03799d11;
    int f63205439;
    java.lang.object fb4a88417;
    java.lang.object fce29bf19;
    int fd304ba20;
    java.lang.object fedff6b5b;
    readonly p2e5d8aa3.pad5f82e8.pac143fb7.p4236a440.p1256ed63 this$0;

    p1256ed63$p4236a440$1(p2e5d8aa3.pad5f82e8.pac143fb7.p4236a440.p1256ed63 p1256ed63Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.pad5f82e8.pac143fb7.p4236a440.p1256ed63$p4236a440$1> continuation) {
        super(continuation);
        this.this$0 = p1256ed63Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.logout(this);
    }
}

