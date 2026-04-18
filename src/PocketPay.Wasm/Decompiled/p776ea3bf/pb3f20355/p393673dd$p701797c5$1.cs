namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.pb3f20355.p393673dd", m533f = "CheckRegisteredUserRepositoryImpl.kt", m534i = {}, m535l = {20}, m536m = "checkRegisteredUser", m537n = {}, m538s = {})
readonly class p393673dd$p701797c5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f067f951d;
    int f7ae2903e;
    int f84859b20;
    java.lang.object fb4a88417;
    java.lang.object fbec3bf63;
    int fd304ba20;
    int fdc07d906;
    int ff2b494a9;
    readonly p776ea3bf.pb3f20355.p393673dd this$0;

    p393673dd$p701797c5$1(p776ea3bf.pb3f20355.p393673dd p393673ddVar, kotlin.coroutines.Continuation<? super p776ea3bf.pb3f20355.p393673dd$p701797c5$1> continuation) {
        super(continuation);
        this.this$0 = p393673ddVar;
    }

    public static java.lang.object DrvLOyefiDyhFuHl(p776ea3bf.pb3f20355.p393673dd p393673ddVar, java.lang.string str, java.lang.string str2, java.lang.string str3, kotlin.coroutines.Continuation continuation) {
        return p393673ddVar.checkRegisteredUser(str, str2, str3, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return drvLOyefiDyhFuHl(this.this$0, null, null, null, this);
    }
}

