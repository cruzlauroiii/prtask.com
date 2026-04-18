namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pb3f20355.pcf388f6a", m533f = "CurrentInventorizationRepositoryImpl.kt", m534i = {}, m535l = {25}, m536m = "getCurrentInventorization", m537n = {}, m538s = {})
readonly class pcf388f6a$pc3bd4f53$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f199424ff;
    int f7d422922;
    java.lang.object f9692cd9c;
    java.lang.object fb4a88417;
    int fc339f918;
    int fc44a2369;
    java.lang.object fd1068aa1;
    int fd304ba20;
    java.lang.object ff858c2ba;
    readonly p10348936.pb3f20355.pcf388f6a this$0;

    pcf388f6a$pc3bd4f53$1(p10348936.pb3f20355.pcf388f6a pcf388f6aVar, kotlin.coroutines.Continuation<? super p10348936.pb3f20355.pcf388f6a$pc3bd4f53$1> continuation) {
        super(continuation);
        this.this$0 = pcf388f6aVar;
    }

    public static java.lang.object IScypUTtxSldYCfs(p10348936.pb3f20355.pcf388f6a pcf388f6aVar, kotlin.coroutines.Continuation continuation) {
        return pcf388f6aVar.getCurrentInventorization(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return iScypUTtxSldYCfs(this.this$0, this);
    }
}

