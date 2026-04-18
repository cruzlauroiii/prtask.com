namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p9597407d", m533f = "InventoryRemoteRepositoryImpl.kt", m534i = {0, 0, 0, 1, 1, 1, 2, 2, 2}, m535l = {21, 22, 20}, m536m = "getAllCommoditiesFromRemote", m537n = {"this", "result", "cursor", "this", "result", "cursor", "this", "result", "cursor"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$0", "L$1", "L$2"})
readonly class p9597407d$pdfd9fb62$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    int f5a5d2ae2;
    int f8ca0eac6;
    java.lang.object faac3e854;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p7a1eabc3.pb3f20355.p9597407d this$0;

    p9597407d$pdfd9fb62$1(p7a1eabc3.pb3f20355.p9597407d p9597407dVar, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p9597407d$pdfd9fb62$1> continuation) {
        super(continuation);
        this.this$0 = p9597407dVar;
    }

    public static java.lang.object CvgBmutKXIfXjukt(p7a1eabc3.pb3f20355.p9597407d p9597407dVar, kotlin.coroutines.Continuation continuation) {
        return p9597407dVar.getAllCommoditiesFromRemote(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return cvgBmutKXIfXjukt(this.this$0, this);
    }
}

