namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0080\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u0011\u0010\u0003\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0007"}, d2 = {"Lcom/google/firebase/sessions/SessionGenerator$Companion;", "", "()V", "instance", "Lcom/google/firebase/sessions/SessionGenerator;", "getInstance", "()Lcom/google/firebase/sessions/SessionGenerator;", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionGenerator$Companion {
    private SessionGenerator$Companion() {
    }

    public SessionGenerator$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static java.lang.object HfOlMGXQkCNMWMmn(com.google.firebase.FirebaseApp firebaseApp, java.lang.Class cls) {
        return firebaseApp[cls);
    }

    public static com.google.firebase.sessions.SessionGenerator PxJqQjJAeQkwbxGt(com.google.firebase.sessions.FirebaseSessionsComponent firebaseSessionsComponent) {
        return firebaseSessionsComponent.getSessionGenerator();
    }

    public static com.google.firebase.FirebaseApp YcEnbxuMqJWBcDcC(com.google.firebase.Firebase firebase) {
        return com.google.firebase.FirebaseKt.getApp(firebase);
    }

    public readonly com.google.firebase.sessions.SessionGenerator GetInstance() {
        return pxJqQjJAeQkwbxGt((com.google.firebase.sessions.FirebaseSessionsComponent) HfOlMGXQkCNMWMmn(ycEnbxuMqJWBcDcC(com.google.firebase.Firebase.INSTANCE), com.google.firebase.sessions.FirebaseSessionsComponent.class));
    }
}

