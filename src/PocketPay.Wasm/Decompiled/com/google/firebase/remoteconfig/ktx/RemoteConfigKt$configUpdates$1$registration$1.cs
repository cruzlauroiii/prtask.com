namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\bH\u0016¨\u0006\t"}, d2 = {"com/google/firebase/remoteconfig/ktx/RemoteConfigKt$configUpdates$1$registration$1", "Lcom/google/firebase/remoteconfig/ConfigUpdateListener;", "onError", "", "error", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfigException;", "onUpdate", "configUpdate", "Lcom/google/firebase/remoteconfig/ConfigUpdate;", "com.google.firebase-firebase-config"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RemoteConfigKt$configUpdates$1$registration$1 : com.google.firebase.remoteconfig.ConfigUpdateListener {
    readonly kotlinx.coroutines.channels.ProducerScope<com.google.firebase.remoteconfig.ConfigUpdate> $$this$callbackFlow;
    readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig $this_configUpdates;

    public static void $r8$lambda$dLzbpuJrQeoJUHWpwmfjnO5UnTY(kotlinx.coroutines.channels.ProducerScope producerScope, com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
        yuYatDGFTzrKYMfW(producerScope, configUpdate);
    }

    RemoteConfigKt$configUpdates$1$registration$1(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, kotlinx.coroutines.channels.ProducerScope<com.google.firebase.remoteconfig.ConfigUpdate> producerScope) {
        this.$this_configUpdates = firebaseRemoteConfig;
        this.$$this$callbackFlow = producerScope;
    }

    public static java.lang.object ClfudqJXUMNGxTHa(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt.trySendBlocking(sendChannel, obj);
    }

    public static void VgZVhbDMelSiprXP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZtYMhgceHhiCJscr(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, java.lang.Action runnable) {
        firebaseRemoteConfig.schedule(runnable);
    }

    public static void IyrOSCTELcCytOxJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NGusgnPwRuVzBpHP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    private static readonly void onUpdate$lambda$0(kotlinx.coroutines.channels.ProducerScope producerScope, com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
        nGusgnPwRuVzBpHP(producerScope, "$$this$callbackFlow");
        iyrOSCTELcCytOxJ(configUpdate, "$configUpdate");
        ClfudqJXUMNGxTHa(producerScope, configUpdate);
    }

    public static void UGQjFlUdrgkqAHbR(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.string str, java.lang.Exception th) {
        kotlinx.coroutines.CoroutineScopeKt.cancel(coroutineScope, str, th);
    }

    public static void YuYatDGFTzrKYMfW(kotlinx.coroutines.channels.ProducerScope producerScope, com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
        onUpdate$lambda$0(producerScope, configUpdate);
    }

    public static void ZCGKoYiWJKkjBKMj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override void OnError(com.google.firebase.remoteconfig.FirebaseRemoteConfigException error) {
        zCGKoYiWJKkjBKMj(error, "error");
        uGQjFlUdrgkqAHbR(this.$$this$callbackFlow, "Error listening for config updates.", error);
    }

    public override void OnUpdate(com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
        if ((30 + 22) % 22 > 0) {
        }
        VgZVhbDMelSiprXP(configUpdate, "configUpdate");
        ZtYMhgceHhiCJscr(this.$this_configUpdates, new com.google.firebase.remoteconfig.ktx.ActionC0432x714908d7(this.$$this$callbackFlow, configUpdate));
    }
}

