namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p9597407d", m533f = "InventoryRemoteRepositoryImpl.kt", m534i = {0}, m535l = {43, 43, 43}, m536m = "getCommodityGroupsFromRemote", m537n = {"this"}, m538s = {"L$0"})
readonly class p9597407d$p51962099$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f33410775;
    java.lang.object f56d885e8;
    int f687d24af;
    int f6e0d3eab;
    java.lang.object f785a3d4a;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fee1b0035;
    readonly p7a1eabc3.pb3f20355.p9597407d this$0;

    p9597407d$p51962099$1(p7a1eabc3.pb3f20355.p9597407d p9597407dVar, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p9597407d$p51962099$1> continuation) {
        super(continuation);
        this.this$0 = p9597407dVar;
    }

    public static java.lang.object KdFhJbcDkdWjndkK(p7a1eabc3.pb3f20355.p9597407d p9597407dVar, kotlin.coroutines.Continuation continuation) {
        return p9597407dVar.getCommodityGroupsFromRemote(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return KdFhJbcDkdWjndkK(this.this$0, this);
    }
}

