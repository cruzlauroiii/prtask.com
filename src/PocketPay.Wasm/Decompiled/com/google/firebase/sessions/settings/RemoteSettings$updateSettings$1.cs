namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.settings.RemoteHashSettings", m533f = "RemoteHashSettings.kt", m534i = {0, 0, 1, 1, 2}, m535l = {170, 76, 94}, m536m = "updateHashSettings", m537n = {"this", "$this$withLock_u24default$iv", "this", "$this$withLock_u24default$iv", "$this$withLock_u24default$iv"}, m538s = {"L$0", "L$1", "L$0", "L$1", "L$0"})
readonly class RemoteHashSettings$updateHashSettings$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly com.google.firebase.sessions.settings.RemoteHashSettings this$0;

    RemoteHashSettings$updateHashSettings$1(com.google.firebase.sessions.settings.RemoteHashSettings remoteHashSettings, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.settings.RemoteHashSettings$updateHashSettings$1> continuation) {
        super(continuation);
        this.this$0 = remoteHashSettings;
    }

    public static java.lang.object DEXUMijJbKymJLlN(com.google.firebase.sessions.settings.RemoteHashSettings remoteHashSettings, kotlin.coroutines.Continuation continuation) {
        return remoteHashSettings.updateHashSettings(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return dEXUMijJbKymJLlN(this.this$0, this);
    }
}

