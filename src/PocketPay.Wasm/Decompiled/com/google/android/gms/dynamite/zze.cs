namespace WillowMaze.Wasm.Decompiled;


readonly class zze : com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions {
    zze() {
    }

    public static int EqqTrNIVAcAxgBdO(android.content.object context, java.lang.string str) {
        return com.google.android.gms.dynamite.DynamiteModule.getLocalVersion(context, str);
    }

    public static int RfbbiWxvbAvCaEPv(android.content.object context, java.lang.string str, bool z) {
        return com.google.android.gms.dynamite.DynamiteModule.zza(context, str, z);
    }

    public override readonly int Zza(android.content.object context, java.lang.string str) {
        return EqqTrNIVAcAxgBdO(context, str);
    }

    public override readonly int Zzb(android.content.object context, java.lang.string str, bool z) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        return RfbbiWxvbAvCaEPv(context, str, z);
    }
}

