namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pa912a94d.pb3f20355.p1b930abb", m533f = "StatisticsRepositoryImpl.kt", m534i = {0, 0, 1, 1}, m535l = {22, 23}, m536m = "getStatisticInfo", m537n = {"this", "filter", "this", "sellReceipts"}, m538s = {"L$0", "L$1", "L$0", "L$1"})
readonly class p1b930abb$pa7034dfe$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f30bb295e;
    java.lang.object f38cdd6c1;
    int f55b14df1;
    int f606d783c;
    int f8a36668f;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fdbbaef64;
    readonly pa912a94d.pb3f20355.p1b930abb this$0;

    p1b930abb$pa7034dfe$1(pa912a94d.pb3f20355.p1b930abb p1b930abbVar, kotlin.coroutines.Continuation<? super pa912a94d.pb3f20355.p1b930abb$pa7034dfe$1> continuation) {
        super(continuation);
        this.this$0 = p1b930abbVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getStatisticInfo(null, this);
    }
}

