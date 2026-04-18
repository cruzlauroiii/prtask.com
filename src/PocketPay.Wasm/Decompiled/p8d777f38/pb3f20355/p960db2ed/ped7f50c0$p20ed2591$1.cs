namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p960db2ed.ped7f50c0", m533f = "RegionRepositoryImpl.kt", m534i = {}, m535l = {57}, m536m = "getRegionsFromServer", m537n = {}, m538s = {})
readonly class ped7f50c0$p20ed2591$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f1fc05901;
    int f50855357;
    int fb42f6ac6;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p8d777f38.pb3f20355.p960db2ed.ped7f50c0 this$0;

    ped7f50c0$p20ed2591$1(p8d777f38.pb3f20355.p960db2ed.ped7f50c0 ped7f50c0Var, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p960db2ed.ped7f50c0$p20ed2591$1> continuation) {
        super(continuation);
        this.this$0 = ped7f50c0Var;
    }

    public static java.lang.object RZSKaYqcThwBJYLo(p8d777f38.pb3f20355.p960db2ed.ped7f50c0 ped7f50c0Var, kotlin.coroutines.Continuation continuation) {
        return p8d777f38.pb3f20355.p960db2ed.ped7f50c0.m75dcc62e(ped7f50c0Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return RZSKaYqcThwBJYLo(this.this$0, this);
    }
}

