namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.pac143fb7.pa99796e8", m533f = "IntegrationTophAuthUseCaseImpl.kt", m534i = {0, 1}, m535l = {43, 43}, m536m = "isNeedMkConsoleout", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class pa99796e8$pe4b240e9$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f0a3cde0d;
    java.lang.object f14a1e238;
    java.lang.object f4bfcf076;
    java.lang.object f9fe80c6d;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd7a7ec2e;
    readonly p776ea3bf.pac143fb7.pa99796e8 this$0;

    pa99796e8$pe4b240e9$1(p776ea3bf.pac143fb7.pa99796e8 pa99796e8Var, kotlin.coroutines.Continuation<? super p776ea3bf.pac143fb7.pa99796e8$pe4b240e9$1> continuation) {
        super(continuation);
        this.this$0 = pa99796e8Var;
    }

    public static java.lang.object YkVzXUgKgJRvWNNT(p776ea3bf.pac143fb7.pa99796e8 pa99796e8Var, kotlin.coroutines.Continuation continuation) {
        return p776ea3bf.pac143fb7.pa99796e8.m32872c7c(pa99796e8Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return YkVzXUgKgJRvWNNT(this.this$0, this);
    }
}

