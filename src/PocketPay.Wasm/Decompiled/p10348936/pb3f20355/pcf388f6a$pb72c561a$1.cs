namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pb3f20355.pcf388f6a", m533f = "CurrentInventorizationRepositoryImpl.kt", m534i = {}, m535l = {46, 45}, m536m = "updateCurrentInventorizationPosition", m537n = {}, m538s = {})
readonly class pcf388f6a$pb72c561a$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f38e96664;
    java.lang.object f4ef7a50e;
    java.lang.object fb4a88417;
    int fb696cc26;
    int fd304ba20;
    readonly p10348936.pb3f20355.pcf388f6a this$0;

    pcf388f6a$pb72c561a$1(p10348936.pb3f20355.pcf388f6a pcf388f6aVar, kotlin.coroutines.Continuation<? super p10348936.pb3f20355.pcf388f6a$pb72c561a$1> continuation) {
        super(continuation);
        this.this$0 = pcf388f6aVar;
    }

    public static java.lang.object BhJhQWzWxsSrbBBa(p10348936.pb3f20355.pcf388f6a pcf388f6aVar, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation continuation) {
        return pcf388f6aVar.updateCurrentInventorizationPosition(pd031d465Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return bhJhQWzWxsSrbBBa(this.this$0, null, this);
    }
}

