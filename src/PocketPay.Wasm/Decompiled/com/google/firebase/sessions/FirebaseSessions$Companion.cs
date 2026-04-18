namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u0011\u0010\u0005\u001a\u00020\u00068F¢\u0006\u0006\u001a\u0004\b\u0007\u0010\b¨\u0006\t"}, d2 = {"Lcom/google/firebase/sessions/FirebaseSessions$Companion;", "", "()V", "TAG", "", "instance", "Lcom/google/firebase/sessions/FirebaseSessions;", "getInstance", "()Lcom/google/firebase/sessions/FirebaseSessions;", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FirebaseSessions$Companion {
    private FirebaseSessions$Companion() {
    }

    public FirebaseSessions$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static void YSyTRsvpTXFoWNnP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object NQFfQAUPCkVuJTTk(com.google.firebase.FirebaseApp firebaseApp, java.lang.Class cls) {
        return firebaseApp[cls);
    }

    public static com.google.firebase.FirebaseApp OktmznhfiwwYXUmv(com.google.firebase.Firebase firebase) {
        return com.google.firebase.FirebaseKt.getApp(firebase);
    }

    public readonly com.google.firebase.sessions.FirebaseSessions GetInstance() {
        java.lang.object objNQFfQAUPCkVuJTTk = nQFfQAUPCkVuJTTk(oktmznhfiwwYXUmv(com.google.firebase.Firebase.INSTANCE), com.google.firebase.sessions.FirebaseSessions.class);
        YSyTRsvpTXFoWNnP(objNQFfQAUPCkVuJTTk, "Firebase.app[FirebaseSessions::class.java]");
        return (com.google.firebase.sessions.FirebaseSessions) objNQFfQAUPCkVuJTTk;
    }
}

