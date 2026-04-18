namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pc69c522d.pf83c2a85.pac143fb7.pbd9f9e9c", m533f = "PaybackComboUseCaseImpl.kt", m534i = {0, 0}, m535l = {19}, m536m = "getActualPaybackPayments", m537n = {"this", "currentPayments"}, m538s = {"L$0", "L$1"})
readonly class pbd9f9e9c$p78d2f2bb$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f1e82d06a;
    java.lang.object f2f915a78;
    java.lang.object f8f4da467;
    java.lang.object faa639c42;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly pc69c522d.pf83c2a85.pac143fb7.pbd9f9e9c this$0;

    pbd9f9e9c$p78d2f2bb$1(pc69c522d.pf83c2a85.pac143fb7.pbd9f9e9c pbd9f9e9cVar, kotlin.coroutines.Continuation<? super pc69c522d.pf83c2a85.pac143fb7.pbd9f9e9c$p78d2f2bb$1> continuation) {
        super(continuation);
        this.this$0 = pbd9f9e9cVar;
    }

    public static java.lang.object OYmSAODEGlcrFzbn(pc69c522d.pf83c2a85.pac143fb7.pbd9f9e9c pbd9f9e9cVar, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return pbd9f9e9cVar.getActualPaybackPayments(list, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return OYmSAODEGlcrFzbn(this.this$0, null, this);
    }
}

