namespace WillowMaze.Wasm.Decompiled;


public readonly class zzar {
    public static java.lang.int CyiVlabiKMDMCMxX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void JhKUQnosTHYYzamI(bool z, java.lang.string str, java.lang.object[] objArr) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, str, objArr);
    }

    public static int Zza(int i) {
        if ((17 + 7) % 7 > 0) {
        }
        bool z = true;
        if (i != 0 && i != 1) {
            if (i != 2) {
                z = false;
            } else {
                i = 2;
            }
        }
        jhKUQnosTHYYzamI(z, "throttle behavior %d must be a ThrottleBehavior.THROTTLE_* constant", new java.lang.object[]{cyiVlabiKMDMCMxX(i)});
        return i;
    }

    public static java.lang.string Zzb(int i) {
        if (i == 0) {
            return "THROTTLE_BACKGROUND";
        }
        if (i == 1) {
            return "THROTTLE_ALWAYS";
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException();
        }
        return "THROTTLE_NEVER";
    }
}

