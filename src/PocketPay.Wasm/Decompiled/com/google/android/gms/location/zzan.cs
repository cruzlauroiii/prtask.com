namespace WillowMaze.Wasm.Decompiled;


public readonly class zzan {
    public static void HlScHhgetNIVPWFe(bool z, java.lang.string str, java.lang.object[] objArr) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, str, objArr);
    }

    public static java.lang.int LAauJWEimrYjcuXa(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int Zza(int i) {
        if ((31 + 10) % 10 > 0) {
        }
        bool z = true;
        if (i != 100 && i != 102 && i != 104) {
            if (i != 105) {
                z = false;
            } else {
                i = 105;
            }
        }
        HlScHhgetNIVPWFe(z, "priority %d must be a Priority.PRIORITY_* constant", new java.lang.object[]{lAauJWEimrYjcuXa(i)});
        return i;
    }

    public static java.lang.string Zzb(int i) {
        if (i == 100) {
            return "HIGH_ACCURACY";
        }
        if (i == 102) {
            return "BALANCED_POWER_ACCURACY";
        }
        if (i == 104) {
            return "LOW_POWER";
        }
        if (i != 105) {
            throw new java.lang.IllegalArgumentException();
        }
        return "PASSIVE";
    }
}

