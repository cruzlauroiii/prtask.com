namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pac143fb7.pbbc980a3", m533f = "DevicesUseCaseImpl.kt", m534i = {0}, m535l = {65, 66}, m536m = "selectDevice", m537n = {"this"}, m538s = {"L$0"})
readonly class pbbc980a3$p64392418$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f0b19f7a9;
    int f2746f31e;
    java.lang.object fb4a88417;
    java.lang.object fc3baea76;
    int fd304ba20;
    readonly pe0212e54.pac143fb7.pbbc980a3 this$0;

    pbbc980a3$p64392418$1(pe0212e54.pac143fb7.pbbc980a3 pbbc980a3Var, kotlin.coroutines.Continuation<? super pe0212e54.pac143fb7.pbbc980a3$p64392418$1> continuation) {
        super(continuation);
        this.this$0 = pbbc980a3Var;
    }

    public static java.lang.object ZzpwvHSnkbPZcZWH(pe0212e54.pac143fb7.pbbc980a3 pbbc980a3Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pbbc980a3Var.selectDevice(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return ZzpwvHSnkbPZcZWH(this.this$0, null, this);
    }
}

