namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.SessionFirelogPublisherImpl", m533f = "SessionFirelogPublisher.kt", m534i = {0}, m535l = {100}, m536m = "shouldConsoleSession", m537n = {"this"}, m538s = {"L$0"})
readonly class SessionFirelogPublisherImpl$shouldConsoleSession$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly com.google.firebase.sessions.SessionFirelogPublisherImpl this$0;

    SessionFirelogPublisherImpl$shouldConsoleSession$1(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.SessionFirelogPublisherImpl$shouldConsoleSession$1> continuation) {
        super(continuation);
        this.this$0 = sessionFirelogPublisherImpl;
    }

    public static java.lang.object YRkjikrCYhZEVroJ(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl, kotlin.coroutines.Continuation continuation) {
        return com.google.firebase.sessions.SessionFirelogPublisherImpl.access$shouldConsoleSession(sessionFirelogPublisherImpl, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return YRkjikrCYhZEVroJ(this.this$0, this);
    }
}

