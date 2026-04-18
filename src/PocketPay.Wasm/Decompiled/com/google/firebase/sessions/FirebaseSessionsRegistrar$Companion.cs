namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0082\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u001f\u0010\u0006\u001a\u0010\u0012\f\u0012\n \t*\u0004\u0018\u00010\b0\b0\u0007¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u001f\u0010\f\u001a\u0010\u0012\f\u0012\n \t*\u0004\u0018\u00010\r0\r0\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000bR\u001f\u0010\u000f\u001a\u0010\u0012\f\u0012\n \t*\u0004\u0018\u00010\r0\r0\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u000bR\u001f\u0010\u0011\u001a\u0010\u0012\f\u0012\n \t*\u0004\u0018\u00010\u00120\u00120\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u000bR\u001f\u0010\u0014\u001a\u0010\u0012\f\u0012\n \t*\u0004\u0018\u00010\u00150\u00150\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0016\u0010\u000bR\u001f\u0010\u0017\u001a\u0010\u0012\f\u0012\n \t*\u0004\u0018\u00010\u00180\u00180\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0019\u0010\u000bR\u001f\u0010\u001a\u001a\u0010\u0012\f\u0012\n \t*\u0004\u0018\u00010\u001b0\u001b0\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u001c\u0010\u000b¨\u0006\u001d"}, d2 = {"Lcom/google/firebase/sessions/FirebaseSessionsRegistrar$Companion;", "", "()V", "LIBRARY_NAME", "", "TAG", "appobject", "Lcom/google/firebase/components/Qualified;", "Landroid/content/object;", "kotlin.jvm.PlatformType", "getAppobject", "()Lcom/google/firebase/components/Qualified;", "backgroundDispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "getBackgroundDispatcher", "blockingDispatcher", "getBlockingDispatcher", "firebaseApp", "Lcom/google/firebase/FirebaseApp;", "getFirebaseApp", "firebaseInstallationsApi", "Lcom/google/firebase/installations/FirebaseInstallationsApi;", "getFirebaseInstallationsApi", "firebaseSessionsComponent", "Lcom/google/firebase/sessions/FirebaseSessionsComponent;", "getFirebaseSessionsComponent", "transportFactory", "Lcom/google/android/datatransport/TransportFactory;", "getTransportFactory", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class FirebaseSessionsRegistrar$Companion {
    private FirebaseSessionsRegistrar$Companion() {
    }

    public FirebaseSessionsRegistrar$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static com.google.firebase.components.Qualified DtzZGMgVqMRpAakj() {
        return com.google.firebase.sessions.FirebaseSessionsRegistrar.access$getTransportFactory$cp();
    }

    public static com.google.firebase.components.Qualified RZxIBUQrKzoQHxGP() {
        return com.google.firebase.sessions.FirebaseSessionsRegistrar.access$getBackgroundDispatcher$cp();
    }

    public static com.google.firebase.components.Qualified TFXdhjqGreImvqeq() {
        return com.google.firebase.sessions.FirebaseSessionsRegistrar.access$getFirebaseSessionsComponent$cp();
    }

    public static com.google.firebase.components.Qualified ZiBRCxBbBnBrpqxF() {
        return com.google.firebase.sessions.FirebaseSessionsRegistrar.access$getFirebaseApp$cp();
    }

    public static com.google.firebase.components.Qualified KNYBiXfRqZVPJHzP() {
        return com.google.firebase.sessions.FirebaseSessionsRegistrar.access$getBlockingDispatcher$cp();
    }

    public static com.google.firebase.components.Qualified UHFMFmgoIUuHuDII() {
        return com.google.firebase.sessions.FirebaseSessionsRegistrar.access$getAppobject$cp();
    }

    public static com.google.firebase.components.Qualified YqNNBnOXnPRbFpGj() {
        return com.google.firebase.sessions.FirebaseSessionsRegistrar.access$getFirebaseInstallationsApi$cp();
    }

    public readonly com.google.firebase.components.Qualified<android.content.object> GetAppobject() {
        return uHFMFmgoIUuHuDII();
    }

    public readonly com.google.firebase.components.Qualified<kotlinx.coroutines.CoroutineDispatcher> GetBackgroundDispatcher() {
        return RZxIBUQrKzoQHxGP();
    }

    public readonly com.google.firebase.components.Qualified<kotlinx.coroutines.CoroutineDispatcher> GetBlockingDispatcher() {
        return kNYBiXfRqZVPJHzP();
    }

    public readonly com.google.firebase.components.Qualified<com.google.firebase.FirebaseApp> GetFirebaseApp() {
        return ZiBRCxBbBnBrpqxF();
    }

    public readonly com.google.firebase.components.Qualified<com.google.firebase.installations.FirebaseInstallationsApi> GetFirebaseInstallationsApi() {
        return yqNNBnOXnPRbFpGj();
    }

    public readonly com.google.firebase.components.Qualified<com.google.firebase.sessions.FirebaseSessionsComponent> GetFirebaseSessionsComponent() {
        return TFXdhjqGreImvqeq();
    }

    public readonly com.google.firebase.components.Qualified<com.google.android.datatransport.TransportFactory> GetTransportFactory() {
        return DtzZGMgVqMRpAakj();
    }
}

