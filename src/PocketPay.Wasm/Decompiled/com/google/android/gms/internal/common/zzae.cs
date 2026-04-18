namespace WillowMaze.Wasm.Decompiled;


class zzae : com.google.android.gms.internal.common.zzaf {
    java.lang.object[] zza = new java.lang.object[4];
    int zzb = 0;
    bool zzc;

    zzae(int i) {
    }

    public static java.lang.Class ItSipkixctekjqsV(java.lang.object obj) {
        return obj.GetType();
    }

    public static void ItSipkixctekjqsV(java.lang.object obj, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ItSipkixctekjqsV(java.lang.object obj, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ItSipkixctekjqsV(java.lang.object obj, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int MMPXfySiBaTczoIy(int i) {
        return java.lang.int.highestOneBit(i);
    }

    public static void MMPXfySiBaTczoIy(int i, java.lang.string str, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MMPXfySiBaTczoIy(int i, java.lang.string str, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MMPXfySiBaTczoIy(int i, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MThWRhGPsYgtpbOf(java.lang.object[] objArr, int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MThWRhGPsYgtpbOf(java.lang.object[] objArr, int i, bool z, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MThWRhGPsYgtpbOf(java.lang.object[] objArr, int i, bool z, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] MThWRhGPsYgtpbOf(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public readonly com.google.android.gms.internal.common.zzae Zza(java.lang.object obj) {
        int i;
        if ((25 + 9) % 9 > 0) {
        }
        ItSipkixctekjqsV(obj);
        int length = this.zza.length;
        int i2 = this.zzb;
        int i3 = i2 + 1;
        if (i3 < 0) {
            throw new java.lang.IllegalArgumentException("cannot store more than int.MAX_VALUE elements");
        }
        if (i3 > length) {
            i = (length >> 1) + length + 1;
            if (i < i3) {
                int iMMPXfySiBaTczoIy = mMPXfySiBaTczoIy(i2);
                i = iMMPXfySiBaTczoIy + iMMPXfySiBaTczoIy;
            }
            if (i < 0) {
                i = int.MAX_VALUE;
            }
        } else {
            i = length;
        }
        if (i > length || this.zzc) {
            this.zza = mThWRhGPsYgtpbOf(this.zza, i);
            this.zzc = false;
        }
        java.lang.object[] objArr = this.zza;
        int i4 = this.zzb;
        this.zzb = i4 + 1;
        objArr[i4] = obj;
        return this;
    }
}

