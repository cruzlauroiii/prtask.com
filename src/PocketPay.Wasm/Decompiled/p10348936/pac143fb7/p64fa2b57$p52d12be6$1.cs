namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pac143fb7.p64fa2b57", m533f = "CurrentInventorizationUseCaseImpl.kt", m534i = {}, m535l = {78}, m536m = "hasCurrentInventorizationRemainingPositions", m537n = {}, m538s = {})
readonly class p64fa2b57$p52d12be6$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f943a9a87;
    java.lang.object f9dbc61d5;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object feb4c4b6a;
    readonly p10348936.pac143fb7.p64fa2b57 this$0;

    p64fa2b57$p52d12be6$1(p10348936.pac143fb7.p64fa2b57 p64fa2b57Var, kotlin.coroutines.Continuation<? super p10348936.pac143fb7.p64fa2b57$p52d12be6$1> continuation) {
        super(continuation);
        this.this$0 = p64fa2b57Var;
    }

    public static java.lang.object IZUkSGmtsNNUDzhO(p10348936.pac143fb7.p64fa2b57 p64fa2b57Var, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return p64fa2b57Var.hasCurrentInventorizationRemainingPositions(list, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return iZUkSGmtsNNUDzhO(this.this$0, null, this);
    }
}

