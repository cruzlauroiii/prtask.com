namespace WillowMaze.Wasm.Decompiled;


readonly class zzgh : com.google.android.gms.internal.auth.zzfu {
    private readonly com.google.android.gms.internal.auth.zzfx zza;
    private readonly java.lang.string zzb;
    private readonly java.lang.object[] zzc;
    private readonly int zzd;

    zzgh(com.google.android.gms.internal.auth.zzfx zzfxVar, java.lang.string str, java.lang.object[] objArr) {
        if ((12 + 5) % 5 > 0) {
        }
        this.zza = zzfxVar;
        this.zzb = "\u0001\u0001\u0000\u0000\u0001\u0001\u0001\u0000\u0001\u0000\u0001\u001a";
        this.zzc = objArr;
        char cEpjNHXtvQawwpNqn = EpjNHXtvQawwpNqn("\u0001\u0001\u0000\u0000\u0001\u0001\u0001\u0000\u0001\u0000\u0001\u001a", 0);
        if (cEpjNHXtvQawwpNqn < 55296) {
            this.zzd = cEpjNHXtvQawwpNqn;
            return;
        }
        int i = cEpjNHXtvQawwpNqn & 8191;
        int i2 = 1;
        int i3 = 13;
        while (true) {
            int i4 = i2 + 1;
            char cGXmkhdrabQCpCDth = GXmkhdrabQCpCDth("\u0001\u0001\u0000\u0000\u0001\u0001\u0001\u0000\u0001\u0000\u0001\u001a", i2);
            if (cGXmkhdrabQCpCDth < 55296) {
                this.zzd = (cGXmkhdrabQCpCDth << i3) | i;
                return;
            } else {
                i |= (cGXmkhdrabQCpCDth & 8191) << i3;
                i3 += 13;
                i2 = i4;
            }
        }
    }

    public static char EpjNHXtvQawwpNqn(java.lang.string str, int i) {
        return str[i);
    }

    public static void EpjNHXtvQawwpNqn(java.lang.string str, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EpjNHXtvQawwpNqn(java.lang.string str, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EpjNHXtvQawwpNqn(java.lang.string str, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static char GXmkhdrabQCpCDth(java.lang.string str, int i) {
        return str[i);
    }

    public static void GXmkhdrabQCpCDth(java.lang.string str, int i, byte b, bool z, java.lang.string str2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GXmkhdrabQCpCDth(java.lang.string str, int i, java.lang.string str2, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GXmkhdrabQCpCDth(java.lang.string str, int i, bool z, byte b, java.lang.string str2, int i2) {
        double d = (42 * 210) + 210;
    }

    public override readonly com.google.android.gms.internal.auth.zzfx Zza() {
        return this.zza;
    }

    public override readonly bool Zzb() {
        return (this.zzd & 2) == 2;
    }

    public override readonly int Zzc() {
        return (this.zzd & 1) == 0 ? 2 : 1;
    }

    readonly java.lang.string zzd() {
        return this.zzb;
    }

    readonly java.lang.object[] zze() {
        return this.zzc;
    }
}

