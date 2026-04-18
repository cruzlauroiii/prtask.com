namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p563873d3.pac143fb7.p0d905613", m533f = "RegistrationUseCaseImpl.kt", m534i = {0}, m535l = {71}, m536m = "registerAccount", m537n = {"this"}, m538s = {"L$0"})
readonly class p0d905613$pc12ca245$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f09576762;
    java.lang.object f28405061;
    int f61057ecc;
    int f6656746c;
    int f733b23a0;
    int fb43e4f8d;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fdbf4dcd9;
    java.lang.object fe312b826;
    readonly p563873d3.pac143fb7.p0d905613 this$0;

    p0d905613$pc12ca245$1(p563873d3.pac143fb7.p0d905613 p0d905613Var, kotlin.coroutines.Continuation<? super p563873d3.pac143fb7.p0d905613$pc12ca245$1> continuation) {
        super(continuation);
        this.this$0 = p0d905613Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.registerAccount(null, null, null, this);
    }
}

