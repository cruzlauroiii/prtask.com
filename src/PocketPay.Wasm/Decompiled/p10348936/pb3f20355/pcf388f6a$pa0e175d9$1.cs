namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pb3f20355.pcf388f6a", m533f = "CurrentInventorizationRepositoryImpl.kt", m534i = {}, m535l = {42}, m536m = "getCurrentInventorizationPositions", m537n = {}, m538s = {})
readonly class pcf388f6a$pa0e175d9$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f35686523;
    int f39d5ba55;
    java.lang.object f43256ba1;
    java.lang.object f782a7269;
    int f9ea541ce;
    java.lang.object fad0f8efb;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p10348936.pb3f20355.pcf388f6a this$0;

    pcf388f6a$pa0e175d9$1(p10348936.pb3f20355.pcf388f6a pcf388f6aVar, kotlin.coroutines.Continuation<? super p10348936.pb3f20355.pcf388f6a$pa0e175d9$1> continuation) {
        super(continuation);
        this.this$0 = pcf388f6aVar;
    }

    public static java.lang.object AtjdOIEQHyWuBvGJ(p10348936.pb3f20355.pcf388f6a pcf388f6aVar, kotlin.coroutines.Continuation continuation) {
        return pcf388f6aVar.getCurrentInventorizationPositions(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return atjdOIEQHyWuBvGJ(this.this$0, this);
    }
}

