namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigGetParameterHandler$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly com.google.android.gms.common.util.BiConsumer f$0;
    public readonly java.lang.string f$1;
    public readonly com.google.firebase.remoteconfig.internal.ConfigContainer f$2;

    public ConfigGetParameterHandler$$ExternalSyntheticLambda0(com.google.android.gms.common.util.BiConsumer biConsumer, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        this.f$0 = biConsumer;
        this.f$1 = str;
        this.f$2 = configContainer;
    }

    public static void OlSatsdmAQWenwvz(com.google.android.gms.common.util.BiConsumer biConsumer, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler.lambda$callListeners$0(biConsumer, str, configContainer);
    }

    public override readonly void Run() {
        if ((29 + 20) % 20 > 0) {
        }
        OlSatsdmAQWenwvz(this.f$0, this.f$1, this.f$2);
    }
}

