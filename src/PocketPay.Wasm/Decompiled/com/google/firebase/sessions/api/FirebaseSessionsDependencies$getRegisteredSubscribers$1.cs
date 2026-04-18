namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.api.FirebaseSessionsDependencies", m533f = "FirebaseSessionsDependencies.kt", m534i = {0, 0, 0}, m535l = {124}, m536m = "getRegisteredSubscribers$com_google_firebase_firebase_sessions", m537n = {"destination$iv$iv", "subscriberName", "$this$withLock_u24default$iv"}, m538s = {"L$0", "L$2", "L$3"})
readonly class FirebaseSessionsDependencies$getRegisteredSubscribers$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    int label;
    java.lang.object result;
    readonly com.google.firebase.sessions.api.FirebaseSessionsDependencies this$0;

    FirebaseSessionsDependencies$getRegisteredSubscribers$1(com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.api.FirebaseSessionsDependencies$getRegisteredSubscribers$1> continuation) {
        super(continuation);
        this.this$0 = firebaseSessionsDependencies;
    }

    public static java.lang.object BZILcFnUYrbwFDuV(com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies, kotlin.coroutines.Continuation continuation) {
        return firebaseSessionsDependencies.getRegisteredSubscribers$com_google_firebase_firebase_sessions(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return BZILcFnUYrbwFDuV(this.this$0, this);
    }
}

