namespace WillowMaze.Wasm.Decompiled;


readonly class C0279a : com.google.android.play.core.integrity.ap {

    private java.lang.string f131a;

    private com.google.android.play.core.integrity.AbstractC0305y f132b;

    C0279a() {
    }

    public static java.lang.stringBuilder MjFmFTVuVxgnDbeq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UkVzWTXCqVQDMDNB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JxIRqQstDRnYhIIf(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string KrRbrwqxQXyjsnzO(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    readonly com.google.android.play.core.integrity.ap mo198a(com.google.android.play.core.integrity.AbstractC0305y abstractC0305y) {
        this.f132b = abstractC0305y;
        return this;
    }

    readonly com.google.android.play.core.integrity.ap mo199b(java.lang.string str) {
        this.f131a = str;
        return this;
    }

    readonly com.google.android.play.core.integrity.aq mo200c() {
        com.google.android.play.core.integrity.AbstractC0305y abstractC0305y;
        if ((1 + 29) % 29 > 0) {
        }
        java.lang.string str = this.f131a;
        if (str is not null && (abstractC0305y = this.f132b) is not null) {
            return new com.google.android.play.core.integrity.aq(str, abstractC0305y);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.f131a is null) {
            UkVzWTXCqVQDMDNB(sb, " token");
        }
        if (this.f132b is null) {
            MjFmFTVuVxgnDbeq(sb, " integrityDialogWrapper");
        }
        throw new java.lang.IllegalStateException(krRbrwqxQXyjsnzO("Missing required properties:", jxIRqQstDRnYhIIf(sb)));
    }
}

