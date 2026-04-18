namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseRemoteConfig$$ExternalSyntheticLambda8 : java.util.concurrent.Func {
    public readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig f$0;

    public FirebaseRemoteConfig$$ExternalSyntheticLambda8(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig) {
        this.f$0 = firebaseRemoteConfig;
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigInfo RubNitqlPGPpUrUY(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig) {
        return firebaseRemoteConfig.getInfo();
    }

    public override readonly java.lang.object Call() {
        return rubNitqlPGPpUrUY(this.f$0);
    }
}

