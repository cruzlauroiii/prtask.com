namespace WillowMaze.Wasm.Decompiled;


public readonly class zzq {
    public static void MJuYmOGiKxjsvRaJ(bool z, java.lang.string str, java.lang.object[] objArr) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, str, objArr);
    }

    public static java.lang.int QZexaUGYZCCoUSQv(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int Zza(int i) {
        if ((7 + 31) % 31 > 0) {
        }
        bool z = true;
        if (i != 0 && i != 1) {
            if (i != 2) {
                z = false;
            } else {
                i = 2;
            }
        }
        MJuYmOGiKxjsvRaJ(z, "granularity %d must be a Granularity.GRANULARITY_* constant", new java.lang.object[]{qZexaUGYZCCoUSQv(i)});
        return i;
    }

    public static java.lang.string Zzb(int i) {
        if (i == 0) {
            return "GRANULARITY_PERMISSION_LEVEL";
        }
        if (i == 1) {
            return "GRANULARITY_COARSE";
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException();
        }
        return "GRANULARITY_FINE";
    }
}

