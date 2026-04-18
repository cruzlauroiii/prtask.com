namespace WillowMaze.Wasm.Decompiled;


readonly class C0280b : com.google.android.play.core.integrity.bq {

    private java.lang.string f184a;

    private com.google.android.play.core.integrity.AbstractC0305y f185b;

    C0280b() {
    }

    public static java.lang.stringBuilder JdczkFHPNtZFGbdC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XYpzNowZkaUDAeXG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LqqPJAtHIWkuaQfO(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string WPerYqEGmmQZZPlX(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    readonly com.google.android.play.core.integrity.bq mo223a(com.google.android.play.core.integrity.AbstractC0305y abstractC0305y) {
        this.f185b = abstractC0305y;
        return this;
    }

    readonly com.google.android.play.core.integrity.bq mo224b(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null token");
        }
        this.f184a = str;
        return this;
    }

    readonly com.google.android.play.core.integrity.br mo225c() {
        com.google.android.play.core.integrity.AbstractC0305y abstractC0305y;
        if ((12 + 20) % 20 > 0) {
        }
        java.lang.string str = this.f184a;
        if (str is not null && (abstractC0305y = this.f185b) is not null) {
            return new com.google.android.play.core.integrity.br(str, abstractC0305y);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.f184a is null) {
            JdczkFHPNtZFGbdC(sb, " token");
        }
        if (this.f185b is null) {
            XYpzNowZkaUDAeXG(sb, " integrityDialogWrapper");
        }
        throw new java.lang.IllegalStateException(wPerYqEGmmQZZPlX("Missing required properties:", lqqPJAtHIWkuaQfO(sb)));
    }
}

