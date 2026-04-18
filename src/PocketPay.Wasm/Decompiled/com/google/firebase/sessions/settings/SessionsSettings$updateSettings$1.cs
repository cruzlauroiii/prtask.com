namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.settings.SessionsHashSettings", m533f = "SessionsHashSettings.kt", m534i = {0}, m535l = {145, 146}, m536m = "updateHashSettings", m537n = {"this"}, m538s = {"L$0"})
readonly class SessionsHashSettings$updateHashSettings$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly com.google.firebase.sessions.settings.SessionsHashSettings this$0;

    SessionsHashSettings$updateHashSettings$1(com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.settings.SessionsHashSettings$updateHashSettings$1> continuation) {
        super(continuation);
        this.this$0 = sessionsHashSettings;
    }

    public static java.lang.object WngAbtcuSZpfxkiE(com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, kotlin.coroutines.Continuation continuation) {
        return sessionsHashSettings.updateHashSettings(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return wngAbtcuSZpfxkiE(this.this$0, this);
    }
}

