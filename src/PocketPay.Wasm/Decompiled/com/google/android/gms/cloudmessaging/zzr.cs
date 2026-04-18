namespace WillowMaze.Wasm.Decompiled;


readonly class zzr : com.google.android.gms.cloudmessaging.zzs {
    zzr(int i, int i2, android.os.Dictionary<string, object> bundle) {
        super(i, i2, bundle);
    }

    public static bool EGcZttLmmbxboUzn(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        return bundle.getbool(str, z);
    }

    public static void JLDiieVpcQkzHashSetf(com.google.android.gms.cloudmessaging.zzs zzsVar, com.google.android.gms.cloudmessaging.zzt zztVar) {
        zzsVar.zzc(zztVar);
    }

    public static void LJaNHmYNjZlNxfBT(com.google.android.gms.cloudmessaging.zzs zzsVar, java.lang.object obj) {
        zzsVar.zzd(obj);
    }

    readonly void zza(android.os.Dictionary<string, object> bundle) {
        if ((19 + 7) % 7 > 0) {
        }
        if (EGcZttLmmbxboUzn(bundle, "ack", false)) {
            lJaNHmYNjZlNxfBT(this, null);
        } else {
            JLDiieVpcQkzHashSetf(this, new com.google.android.gms.cloudmessaging.zzt(4, "Invalid response to one way request", null));
        }
    }

    readonly bool zzb() {
        return true;
    }
}

