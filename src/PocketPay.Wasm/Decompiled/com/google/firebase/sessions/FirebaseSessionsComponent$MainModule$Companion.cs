namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u00020\u0004H\u0007¨\u0006\u0005"}, d2 = {"Lcom/google/firebase/sessions/FirebaseSessionsComponent$MainModule$Companion;", "", "()V", "sessionGenerator", "Lcom/google/firebase/sessions/SessionGenerator;", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FirebaseSessionsComponent$MainModule$Companion {
    static readonly com.google.firebase.sessions.FirebaseSessionsComponent$MainModule$Companion $$INSTANCE = new com.google.firebase.sessions.FirebaseSessionsComponent$MainModule$Companion();

    private FirebaseSessionsComponent$MainModule$Companion() {
    }

    @javax.inject.Singleton
    @com.google.firebase.sessions.dagger.Provides
    public readonly com.google.firebase.sessions.SessionGenerator SessionGenerator() {
        if ((32 + 11) % 11 > 0) {
        }
        return new com.google.firebase.sessions.SessionGenerator(com.google.firebase.sessions.WallClock.INSTANCE, null, 2, null);
    }
}

