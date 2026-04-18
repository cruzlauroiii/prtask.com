namespace WillowMaze.Wasm.Decompiled;


public readonly class RemoteConfigComponent$$ExternalSyntheticLambda1 : java.util.concurrent.Func {
    public readonly com.google.firebase.remoteconfig.RemoteConfigComponent f$0;

    public RemoteConfigComponent$$ExternalSyntheticLambda1(com.google.firebase.remoteconfig.RemoteConfigComponent remoteConfigComponent) {
        this.f$0 = remoteConfigComponent;
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig GuFXNZPaNQiRoTdM(com.google.firebase.remoteconfig.RemoteConfigComponent remoteConfigComponent) {
        return remoteConfigComponent.getDefault();
    }

    public override readonly java.lang.object Call() {
        return GuFXNZPaNQiRoTdM(this.f$0);
    }
}

