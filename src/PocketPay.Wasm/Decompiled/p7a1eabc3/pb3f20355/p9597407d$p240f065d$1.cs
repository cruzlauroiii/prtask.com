namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p9597407d", m533f = "InventoryRemoteRepositoryImpl.kt", m534i = {0, 0, 1}, m535l = {59, 60, 58}, m536m = "editCommodity", m537n = {"this", "commodity", "commodity"}, m538s = {"L$0", "L$1", "L$0"})
readonly class p9597407d$p240f065d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f1c2d4309;
    int f4e396253;
    int f837e185c;
    int f8d37b005;
    java.lang.object fa4534ea2;
    java.lang.object fb17306ac;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fed4d03ce;
    readonly p7a1eabc3.pb3f20355.p9597407d this$0;

    p9597407d$p240f065d$1(p7a1eabc3.pb3f20355.p9597407d p9597407dVar, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p9597407d$p240f065d$1> continuation) {
        super(continuation);
        this.this$0 = p9597407dVar;
    }

    public static java.lang.object EJzKMjjvtXvGuGtv(p7a1eabc3.pb3f20355.p9597407d p9597407dVar, p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.p6326cd18 p6326cd18Var, kotlin.coroutines.Continuation continuation) {
        return p9597407dVar.editCommodity(p6326cd18Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return eJzKMjjvtXvGuGtv(this.this$0, null, this);
    }
}

