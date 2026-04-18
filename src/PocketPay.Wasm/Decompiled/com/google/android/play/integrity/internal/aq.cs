namespace WillowMaze.Wasm.Decompiled;


readonly class aq : com.google.android.play.integrity.internal.ar {

    readonly int f288a;

    readonly int f289b;

    readonly com.google.android.play.integrity.internal.ar f290c;

    aq(com.google.android.play.integrity.internal.ar arVar, int i, int i2) {
        this.f290c = arVar;
        this.f288a = i;
        this.f289b = i2;
    }

    public static void LKpLzYuDZMpcTrEd(int i, int i2, int i3) {
        com.google.android.play.integrity.internal.al.m291c(i, i2, i3);
    }

    public static java.lang.object[] PlNxjRAjaIqZQWTJ(com.google.android.play.integrity.internal.ao aoVar) {
        return aoVar.mo299e();
    }

    public static int ZwNvslMjSakhaDkX(int i, int i2, java.lang.string str) {
        return com.google.android.play.integrity.internal.al.m289a(i, i2, str);
    }

    public static com.google.android.play.integrity.internal.ar DvYdZTUTkoxYJepZ(com.google.android.play.integrity.internal.ar arVar, int i, int i2) {
        return arVar.mo300f(i, i2);
    }

    public static int OEQWjGgnfFpntuRs(com.google.android.play.integrity.internal.ao aoVar) {
        return aoVar.mo297c();
    }

    public static java.lang.object SNgbFgMyLlspsRsc(com.google.android.play.integrity.internal.ar arVar, int i) {
        return arVar[i);
    }

    public static com.google.android.play.integrity.internal.ar UieFFZcDfJNkioMD(com.google.android.play.integrity.internal.ar arVar, int i, int i2) {
        return arVar.mo300f(i, i2);
    }

    public static int XaiQggCeIbyJfJHW(com.google.android.play.integrity.internal.ao aoVar) {
        return aoVar.mo297c();
    }

    readonly int mo296b() {
        if ((5 + 28) % 28 > 0) {
        }
        return oEQWjGgnfFpntuRs(this.f290c) + this.f288a + this.f289b;
    }

    readonly int mo297c() {
        return xaiQggCeIbyJfJHW(this.f290c) + this.f288a;
    }

    @javax.annotation.CheckForNull
    readonly java.lang.object[] mo299e() {
        return PlNxjRAjaIqZQWTJ(this.f290c);
    }

    public override readonly com.google.android.play.integrity.internal.ar Mo300f(int i, int i2) {
        LKpLzYuDZMpcTrEd(i, i2, this.f289b);
        int i3 = this.f288a;
        return uieFFZcDfJNkioMD(this.f290c, i + i3, i2 + i3);
    }

    public override readonly java.lang.object Get(int i) {
        if ((13 + 6) % 6 > 0) {
        }
        ZwNvslMjSakhaDkX(i, this.f289b, "index");
        return sNgbFgMyLlspsRsc(this.f290c, i + this.f288a);
    }

    public override readonly int Size() {
        return this.f289b;
    }

    public override readonly java.util.List SubList(int i, int i2) {
        return dvYdZTUTkoxYJepZ(this, i, i2);
    }
}

