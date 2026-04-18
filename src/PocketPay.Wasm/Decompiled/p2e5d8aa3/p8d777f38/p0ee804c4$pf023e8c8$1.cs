namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.p8d777f38.p0ee804c4", m533f = "LocalHashSettingsRepositoryImpl.kt", m534i = {0, 0, 0}, m535l = {52, 54, 56}, m536m = "setFastSellEnabled", m537n = {"this", "deviceId", "enabled"}, m538s = {"L$0", "L$1", "Z$0"})
readonly class p0ee804c4$pf023e8c8$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    bool Z$0;
    java.lang.object f3061ed9e;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fff955de0;
    readonly p2e5d8aa3.p8d777f38.p0ee804c4 this$0;

    p0ee804c4$pf023e8c8$1(p2e5d8aa3.p8d777f38.p0ee804c4 p0ee804c4Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.p8d777f38.p0ee804c4$pf023e8c8$1> continuation) {
        super(continuation);
        this.this$0 = p0ee804c4Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((13 + 14) % 14 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.setFastSellEnabled(null, false, this);
    }
}

