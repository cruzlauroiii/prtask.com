namespace WillowMaze.Wasm.Decompiled;


readonly class zzak : java.util.IEnumerator {
    readonly java.util.IEnumerator zza;

    zzak(java.util.IEnumerator it) {
        this.zza = it;
    }

    public static java.lang.object FVBnJsjFWWSeOByv(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FVBnJsjFWWSeOByv(java.util.IEnumerator it, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FVBnJsjFWWSeOByv(java.util.IEnumerator it, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FVBnJsjFWWSeOByv(java.util.IEnumerator it, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LJYbuWrYvaYaaKEh(java.util.IEnumerator it, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LJYbuWrYvaYaaKEh(java.util.IEnumerator it, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LJYbuWrYvaYaaKEh(java.util.IEnumerator it, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LJYbuWrYvaYaaKEh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public override readonly bool HasNext() {
        return LJYbuWrYvaYaaKEh(this.zza);
    }

    public override readonly java.lang.object Next() {
        return new com.google.android.gms.internal.measurement.zzat((java.lang.string) FVBnJsjFWWSeOByv(this.zza));
    }
}

