namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pac143fb7.p64fa2b57", m533f = "CurrentInventorizationUseCaseImpl.kt", m534i = {0, 1, 1}, m535l = {21, 22, 23}, m536m = "createCurrentInventorization", m537n = {"this", "this", "selectedEmployee"}, m538s = {"L$0", "L$0", "L$1"})
readonly class p64fa2b57$pe887bdd2$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f08d44c63;
    java.lang.object fb299f937;
    java.lang.object fb4a88417;
    java.lang.object fc3745bee;
    int fd304ba20;
    java.lang.object ff1a89b7b;
    readonly p10348936.pac143fb7.p64fa2b57 this$0;

    p64fa2b57$pe887bdd2$1(p10348936.pac143fb7.p64fa2b57 p64fa2b57Var, kotlin.coroutines.Continuation<? super p10348936.pac143fb7.p64fa2b57$pe887bdd2$1> continuation) {
        super(continuation);
        this.this$0 = p64fa2b57Var;
    }

    public static java.lang.object YPlPhEKkscImUDrZ(p10348936.pac143fb7.p64fa2b57 p64fa2b57Var, kotlin.coroutines.Continuation continuation) {
        return p64fa2b57Var.createCurrentInventorization(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return yPlPhEKkscImUDrZ(this.this$0, this);
    }
}

