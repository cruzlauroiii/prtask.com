namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RemoteConfigKt$configUpdates$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration $registration;

    RemoteConfigKt$configUpdates$1$1(com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration configUpdateListenerRegistration) {
        super(0);
        this.$registration = configUpdateListenerRegistration;
    }

    public static void PLmgAfAIihspKMuD(com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration configUpdateListenerRegistration) {
        configUpdateListenerRegistration.Remove();
    }

    public static void RYBnSYtYyWWFvzlF(com.google.firebase.remoteconfig.RemoteConfigKt$configUpdates$1$1 remoteConfigKt$configUpdates$1$1) {
        remoteConfigKt$configUpdates$1$1.invoke2();
    }

    public override kotlin.Unit Invoke() {
        RYBnSYtYyWWFvzlF(this);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        PLmgAfAIihspKMuD(this.$registration);
    }
}

