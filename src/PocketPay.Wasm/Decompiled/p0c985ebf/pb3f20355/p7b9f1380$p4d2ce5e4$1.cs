namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p0c985ebf.pb3f20355.p7b9f1380", m533f = "InspectionRepositoryImpl.kt", m534i = {0}, m535l = {57, 56}, m536m = "updateInspectionReason", m537n = {"reason"}, m538s = {"L$0"})
readonly class p7b9f1380$p4d2ce5e4$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f48fbdf5c;
    java.lang.object fa5abcd5e;
    int facf3424e;
    java.lang.object fb4a88417;
    int fd03dc0ab;
    int fd304ba20;
    java.lang.object fd7cb13e8;
    int fe66fdb01;
    int ff1b5e6c7;
    readonly p0c985ebf.pb3f20355.p7b9f1380 this$0;

    p7b9f1380$p4d2ce5e4$1(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, kotlin.coroutines.Continuation<? super p0c985ebf.pb3f20355.p7b9f1380$p4d2ce5e4$1> continuation) {
        super(continuation);
        this.this$0 = p7b9f1380Var;
    }

    public static java.lang.object JVOPXbLuPHbGmQax(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p7b9f1380Var.updateInspectionReason(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return jVOPXbLuPHbGmQax(this.this$0, null, this);
    }
}

