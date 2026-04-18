namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p960db2ed.ped7f50c0", m533f = "RegionRepositoryImpl.kt", m534i = {0, 1, 1, 1}, m535l = {36, 39}, m536m = "getRegions", m537n = {"this", "this", "regions", "suggestion"}, m538s = {"L$0", "L$0", "L$1", "L$2"})
readonly class ped7f50c0$pa715d521$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    java.lang.object L$6;
    java.lang.object L$7;
    int f6c95b2ee;
    java.lang.object f9284a77f;
    java.lang.object fb4a88417;
    int fbacf35fe;
    java.lang.object fd1a492df;
    int fd304ba20;
    int fd355e316;
    readonly p8d777f38.pb3f20355.p960db2ed.ped7f50c0 this$0;

    ped7f50c0$pa715d521$1(p8d777f38.pb3f20355.p960db2ed.ped7f50c0 ped7f50c0Var, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p960db2ed.ped7f50c0$pa715d521$1> continuation) {
        super(continuation);
        this.this$0 = ped7f50c0Var;
    }

    public static java.lang.object KAcoDYJCGiNtytxt(p8d777f38.pb3f20355.p960db2ed.ped7f50c0 ped7f50c0Var, kotlin.coroutines.Continuation continuation) {
        return ped7f50c0Var.getRegions(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return kAcoDYJCGiNtytxt(this.this$0, this);
    }
}

