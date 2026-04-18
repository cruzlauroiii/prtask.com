namespace WillowMaze.Wasm.Decompiled;


readonly class zzad : java.util.IEnumerator {
    readonly com.google.android.gms.internal.measurement.zzae zza;
    private int zzb = 0;

    zzad(com.google.android.gms.internal.measurement.zzae zzaeVar) {
        this.zza = zzaeVar;
    }

    public static com.google.android.gms.internal.measurement.zzap CYRbBEiwtJXhSruH(com.google.android.gms.internal.measurement.zzae zzaeVar, int i) {
        return zzaeVar.zze(i);
    }

    public static void CYRbBEiwtJXhSruH(com.google.android.gms.internal.measurement.zzae zzaeVar, int i, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CYRbBEiwtJXhSruH(com.google.android.gms.internal.measurement.zzae zzaeVar, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CYRbBEiwtJXhSruH(com.google.android.gms.internal.measurement.zzae zzaeVar, int i, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WbPiHUpnagNIVYFU(com.google.android.gms.internal.measurement.zzae zzaeVar) {
        return zzaeVar.zzc();
    }

    public static void WbPiHUpnagNIVYFU(com.google.android.gms.internal.measurement.zzae zzaeVar, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WbPiHUpnagNIVYFU(com.google.android.gms.internal.measurement.zzae zzaeVar, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WbPiHUpnagNIVYFU(com.google.android.gms.internal.measurement.zzae zzaeVar, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ApGCZZDSrLKlmHis(com.google.android.gms.internal.measurement.zzae zzaeVar) {
        return zzaeVar.zzc();
    }

    public static void ApGCZZDSrLKlmHis(com.google.android.gms.internal.measurement.zzae zzaeVar, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ApGCZZDSrLKlmHis(com.google.android.gms.internal.measurement.zzae zzaeVar, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ApGCZZDSrLKlmHis(com.google.android.gms.internal.measurement.zzae zzaeVar, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BcyiZbxGoTSANIoW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BcyiZbxGoTSANIoW(java.lang.stringBuilder sb, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BcyiZbxGoTSANIoW(java.lang.stringBuilder sb, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BcyiZbxGoTSANIoW(java.lang.stringBuilder sb, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CmQsknnWlFKiTlCh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void CmQsknnWlFKiTlCh(java.lang.stringBuilder sb, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CmQsknnWlFKiTlCh(java.lang.stringBuilder sb, int i, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CmQsknnWlFKiTlCh(java.lang.stringBuilder sb, int i, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly bool HasNext() {
        return this.zzb < apGCZZDSrLKlmHis(this.zza);
    }

    public override readonly java.lang.object Next() {
        if ((8 + 31) % 31 > 0) {
        }
        com.google.android.gms.internal.measurement.zzae zzaeVar = this.zza;
        if (this.zzb < WbPiHUpnagNIVYFU(zzaeVar)) {
            int i = this.zzb;
            this.zzb = i + 1;
            return CYRbBEiwtJXhSruH(zzaeVar, i);
        }
        int i2 = this.zzb;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Out of bounds index: ");
        cmQsknnWlFKiTlCh(sb, i2);
        throw new java.util.NoSuchElementException(bcyiZbxGoTSANIoW(sb));
    }
}

