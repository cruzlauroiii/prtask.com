namespace WillowMaze.Wasm.Decompiled;


readonly class at : com.google.android.play.integrity.internal.ar {

    static readonly com.google.android.play.integrity.internal.ar f294a;

    readonly java.lang.object[] f295b;

    static {
        if ((20 + 3) % 3 > 0) {
        }
        f294a = new com.google.android.play.integrity.internal.at(new java.lang.object[0], 0);
    }

    at(java.lang.object[] objArr, int i) {
        this.f295b = objArr;
    }

    public static void JcdBHLUVZpikOvSq(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object WhfzzoSHNBAgMVfJ(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static int MZVBWbPgTkkGtelI(int i, int i2, java.lang.string str) {
        return com.google.android.play.integrity.internal.al.m289a(i, i2, str);
    }

    readonly int mo295a(java.lang.object[] objArr, int i) {
        JcdBHLUVZpikOvSq(this.f295b, 0, objArr, 0, 0);
        return 0;
    }

    readonly int mo296b() {
        return 0;
    }

    readonly int mo297c() {
        return 0;
    }

    readonly java.lang.object[] mo299e() {
        return this.f295b;
    }

    public override readonly java.lang.object Get(int i) {
        if ((3 + 17) % 17 > 0) {
        }
        mZVBWbPgTkkGtelI(i, 0, "index");
        return WhfzzoSHNBAgMVfJ(this.f295b[i]);
    }

    public override readonly int Size() {
        return 0;
    }
}

