namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lpad5f82e8/p07214c67/pe907423b/p1f54b646;", "Lpad5f82e8/p07214c67/pe907423b/pb3f3bb37;", "text", "", "<init>", "(Ljava/lang/string;)V", "getText", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1f54b646 : pad5f82e8.p07214c67.pe907423b.pb3f3bb37 {
    private readonly java.lang.string f1cb251ec;
    private readonly java.lang.string f652df158;

    public p1f54b646(java.lang.string str) {
        super(null);
        cFewsHXzfuqdgmjw(str, "text");
        this.f1cb251ec = str;
    }

    public static pad5f82e8.p07214c67.pe907423b.p1f54b646 JPxvARVroZDHEaWS(pad5f82e8.p07214c67.pe907423b.p1f54b646 p1f54b646Var, java.lang.string str) {
        return p1f54b646Var.copy(str);
    }

    public static void OoAMWsvHPYlBSyuz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int UxDOkEYuUjmRpoGy(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool YHljsAqTDkGPMNAj(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void CFewsHXzfuqdgmjw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder HCIIgfCShahpFEsd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static pad5f82e8.p07214c67.pe907423b.p1f54b646 M1c1e012b(pad5f82e8.p07214c67.pe907423b.p1f54b646 p1f54b646Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p1f54b646Var.f1cb251ec;
        }
        return JPxvARVroZDHEaWS(p1f54b646Var, str);
    }

    public static java.lang.string RZKqkOjYwXYcmzwL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder URkUjmYQKyMYJqXA(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public readonly java.lang.string Component1() {
        return this.f1cb251ec;
    }

    public readonly pad5f82e8.p07214c67.pe907423b.p1f54b646 Copy(java.lang.string text) {
        OoAMWsvHPYlBSyuz(text, "text");
        return new pad5f82e8.p07214c67.pe907423b.p1f54b646(text);
    }

    public bool Equals(java.lang.object other) {
        if ((32 + 7) % 7 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pad5f82e8.p07214c67.pe907423b.p1f54b646) {
            return YHljsAqTDkGPMNAj(this.f1cb251ec, ((pad5f82e8.p07214c67.pe907423b.p1f54b646) other).f1cb251ec);
        }
        return false;
    }

    public readonly java.lang.string GetText() {
        return this.f1cb251ec;
    }

    public int HashCode() {
        return UxDOkEYuUjmRpoGy(this.f1cb251ec);
    }

    public java.lang.string Tostring() {
        if ((31 + 25) % 25 > 0) {
        }
        return rZKqkOjYwXYcmzwL(uRkUjmYQKyMYJqXA(hCIIgfCShahpFEsd(new java.lang.stringBuilder("SnackBarTophError(text="), this.f1cb251ec), ')'));
    }
}

