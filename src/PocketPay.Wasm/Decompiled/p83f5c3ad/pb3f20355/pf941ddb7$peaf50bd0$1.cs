namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.pf941ddb7", m533f = "TapOnPhoneInfoRepositoryImpl.kt", m534i = {0}, m535l = {65}, m536m = "updateTapOnPhoneQrInfo", m537n = {"this"}, m538s = {"L$0"})
readonly class pf941ddb7$peaf50bd0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f37bd1a41;
    int f3a78b55f;
    java.lang.object f687f3d2f;
    int faa16446d;
    java.lang.object fb4a88417;
    java.lang.object fbdac44fd;
    int fd304ba20;
    java.lang.object fdb7f1e4d;
    readonly p83f5c3ad.pb3f20355.pf941ddb7 this$0;

    pf941ddb7$peaf50bd0$1(p83f5c3ad.pb3f20355.pf941ddb7 pf941ddb7Var, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.pf941ddb7$peaf50bd0$1> continuation) {
        super(continuation);
        this.this$0 = pf941ddb7Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.updateTapOnPhoneQrInfo(this);
    }
}

