namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0432x714908d7 : java.lang.Action {
    public readonly kotlinx.coroutines.channels.ProducerScope f$0;
    public readonly com.google.firebase.remoteconfig.ConfigUpdate f$1;

    public ActionC0432x714908d7(kotlinx.coroutines.channels.ProducerScope producerScope, com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
        this.f$0 = producerScope;
        this.f$1 = configUpdate;
    }

    public static void TQYuODoFlINNxBdo(kotlinx.coroutines.channels.ProducerScope producerScope, com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
        com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1$registration$1.$r8$lambda$dLzbpuJrQeoJUHWpwmfjnO5UnTY(producerScope, configUpdate);
    }

    public override readonly void Run() {
        tQYuODoFlINNxBdo(this.f$0, this.f$1);
    }
}

