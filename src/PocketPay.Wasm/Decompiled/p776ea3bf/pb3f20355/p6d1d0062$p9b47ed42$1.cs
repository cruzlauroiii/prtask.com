namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.pb3f20355.p6d1d0062", m533f = "IntegrationDevicesRepositoryImpl.kt", m534i = {}, m535l = {15}, m536m = "getRemoteDevices", m537n = {}, m538s = {})
readonly class p6d1d0062$p9b47ed42$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f862308b2;
    int f8acfd2fe;
    java.lang.object f8d9651e1;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p776ea3bf.pb3f20355.p6d1d0062 this$0;

    p6d1d0062$p9b47ed42$1(p776ea3bf.pb3f20355.p6d1d0062 p6d1d0062Var, kotlin.coroutines.Continuation<? super p776ea3bf.pb3f20355.p6d1d0062$p9b47ed42$1> continuation) {
        super(continuation);
        this.this$0 = p6d1d0062Var;
    }

    public static java.lang.object OQwrvcTJfszgNkDB(p776ea3bf.pb3f20355.p6d1d0062 p6d1d0062Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p6d1d0062Var.getRemoteDevices(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return OQwrvcTJfszgNkDB(this.this$0, null, this);
    }
}

