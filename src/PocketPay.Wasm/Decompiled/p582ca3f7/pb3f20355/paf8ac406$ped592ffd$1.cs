namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p582ca3f7.pb3f20355.paf8ac406", m533f = "DeeplinkDataRepositoryImpl.kt", m534i = {0}, m535l = {86}, m536m = "loadDeeplinkData", m537n = {"this"}, m538s = {"L$0"})
readonly class paf8ac406$ped592ffd$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f1ea36493;
    int f64f6eb9f;
    java.lang.object f71ce29aa;
    java.lang.object f9f043cfc;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fd4b777a3;
    readonly p582ca3f7.pb3f20355.paf8ac406 this$0;

    paf8ac406$ped592ffd$1(p582ca3f7.pb3f20355.paf8ac406 paf8ac406Var, kotlin.coroutines.Continuation<? super p582ca3f7.pb3f20355.paf8ac406$ped592ffd$1> continuation) {
        super(continuation);
        this.this$0 = paf8ac406Var;
    }

    public static java.lang.object ISRJyhDBVNFRKzfp(p582ca3f7.pb3f20355.paf8ac406 paf8ac406Var, kotlin.coroutines.Continuation continuation) {
        return paf8ac406Var.loadDeeplinkData(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return iSRJyhDBVNFRKzfp(this.this$0, this);
    }
}

