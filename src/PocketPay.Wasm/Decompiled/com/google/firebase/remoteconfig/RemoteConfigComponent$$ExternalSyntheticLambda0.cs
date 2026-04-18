namespace WillowMaze.Wasm.Decompiled;


public readonly class RemoteConfigComponent$$ExternalSyntheticLambda0 : com.google.android.gms.common.util.BiConsumer {
    public readonly com.google.firebase.remoteconfig.internal.Personalization f$0;

    public RemoteConfigComponent$$ExternalSyntheticLambda0(com.google.firebase.remoteconfig.internal.Personalization personalization) {
        this.f$0 = personalization;
    }

    public static void XtjRPsguFlbLyBGv(com.google.firebase.remoteconfig.internal.Personalization personalization, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        personalization.logArmActive(str, configContainer);
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) {
        xtjRPsguFlbLyBGv(this.f$0, (java.lang.string) obj, (com.google.firebase.remoteconfig.internal.ConfigContainer) obj2);
    }
}

