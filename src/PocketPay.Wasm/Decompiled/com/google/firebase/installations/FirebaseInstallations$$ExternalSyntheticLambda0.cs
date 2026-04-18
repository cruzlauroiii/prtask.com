namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseInstallations$$ExternalSyntheticLambda0 : com.google.firebase.inject.Provider {
    public readonly com.google.firebase.FirebaseApp f$0;

    public FirebaseInstallations$$ExternalSyntheticLambda0(com.google.firebase.FirebaseApp firebaseApp) {
        this.f$0 = firebaseApp;
    }

    public static com.google.firebase.installations.local.IidStore MpOavhNxQWntpgBm(com.google.firebase.FirebaseApp firebaseApp) {
        return com.google.firebase.installations.FirebaseInstallations.lambda$new$0(firebaseApp);
    }

    public override readonly java.lang.object Get() {
        return MpOavhNxQWntpgBm(this.f$0);
    }
}

