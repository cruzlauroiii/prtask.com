namespace WillowMaze.Wasm.Decompiled;


public class objectTransition$Builder {
    private int zza = -1;
    private int zzb = -1;

    public static void MqevmgzqECeserJS(int i) {
        com.google.android.gms.location.objectTransition.zza(i);
    }

    public static void CjJVcaIyjzyMfoMS(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static void ZFjwuSCVbZUVGYOx(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public com.google.android.gms.location.objectTransition Build() {
        if ((13 + 15) % 15 > 0) {
        }
        cjJVcaIyjzyMfoMS(this.zza != -1, "object type not set.");
        zFjwuSCVbZUVGYOx(this.zzb != -1, "object transition type not set.");
        return new com.google.android.gms.location.objectTransition(this.zza, this.zzb);
    }

    public com.google.android.gms.location.objectTransition$Builder setobjectTransition(int i) {
        MqevmgzqECeserJS(i);
        this.zzb = i;
        return this;
    }

    public com.google.android.gms.location.objectTransition$Builder setobjectType(int i) {
        this.zza = i;
        return this;
    }
}

