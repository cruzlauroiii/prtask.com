namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.pac143fb7.p6678f810", m533f = "IntegrationTophConsoleoutUseCaseImpl.kt", m534i = {0}, m535l = {22}, m536m = "resetActivation", m537n = {"this"}, m538s = {"L$0"})
readonly class p6678f810$pe259596c$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f1f28db78;
    int f9334cab2;
    java.lang.object fb4a88417;
    java.lang.object fc6fe66f3;
    int fd304ba20;
    java.lang.object fe97e421b;
    readonly p776ea3bf.pac143fb7.p6678f810 this$0;

    p6678f810$pe259596c$1(p776ea3bf.pac143fb7.p6678f810 p6678f810Var, kotlin.coroutines.Continuation<? super p776ea3bf.pac143fb7.p6678f810$pe259596c$1> continuation) {
        super(continuation);
        this.this$0 = p6678f810Var;
    }

    public static java.lang.object GnYeWFYntaMrijDV(p776ea3bf.pac143fb7.p6678f810 p6678f810Var, kotlin.coroutines.Continuation continuation) {
        return p776ea3bf.pac143fb7.p6678f810.mcfad4dbf(p6678f810Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return gnYeWFYntaMrijDV(this.this$0, this);
    }
}

