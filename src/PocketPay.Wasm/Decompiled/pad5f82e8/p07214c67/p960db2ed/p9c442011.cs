namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0019\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u0006\u0010\n\u001a\u00020\u000bJ\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\r\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u001f\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0018\u0010\u0004\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\b¨\u0006\u0015"}, d2 = {"Lpad5f82e8/p07214c67/p960db2ed/p9c442011;", "", "key", "", "name", "<init>", "(Ljava/lang/string;Ljava/lang/string;)V", "getKey", "()Ljava/lang/string;", "getName", "toRegion", "Lpad5f82e8/p07214c67/p960db2ed/pf447ac85;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9c442011 {

    @com.google.gson.annotations.SerializedName("key")
    private readonly java.lang.string f3c6e0b8a;

    @com.google.gson.annotations.SerializedName("name")
    private readonly java.lang.string fb068931c;

    public p9c442011(java.lang.string str, java.lang.string str2) {
        IHDeLSrxkpqxBENb(str, "key");
        this.f3c6e0b8a = str;
        this.fb068931c = str2;
    }

    public static void IHDeLSrxkpqxBENb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder JhKIOpxNwwQEZaRs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KaCgRRWKXYFqINtv(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool KvpgftvlivjbJnLT(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int SvWaVQdWynpHfnZj(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int VORwbnJdKIuDdEsh(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void XnVKPLWXXxcTMLZl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder KBfSIhvpxIxdNpDN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool KWulecBvMRmmzSES(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder LDgcuFofeVXNblWs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static pad5f82e8.p07214c67.p960db2ed.p9c442011 M1c1e012b(pad5f82e8.p07214c67.p960db2ed.p9c442011 p9c442011Var, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p9c442011Var.f3c6e0b8a;
        }
        if ((i & 2) != 0) {
            str2 = p9c442011Var.fb068931c;
        }
        return omHYTvExTWQVGjxb(p9c442011Var, str, str2);
    }

    public static java.lang.string MktEqjRGFJnIjGmN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static pad5f82e8.p07214c67.p960db2ed.p9c442011 OmHYTvExTWQVGjxb(pad5f82e8.p07214c67.p960db2ed.p9c442011 p9c442011Var, java.lang.string str, java.lang.string str2) {
        return p9c442011Var.copy(str, str2);
    }

    public readonly java.lang.string Component1() {
        return this.f3c6e0b8a;
    }

    public readonly java.lang.string Component2() {
        return this.fb068931c;
    }

    public readonly pad5f82e8.p07214c67.p960db2ed.p9c442011 Copy(java.lang.string key, java.lang.string name) {
        XnVKPLWXXxcTMLZl(key, "key");
        return new pad5f82e8.p07214c67.p960db2ed.p9c442011(key, name);
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 32) % 32 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pad5f82e8.p07214c67.p960db2ed.p9c442011)) {
            return false;
        }
        pad5f82e8.p07214c67.p960db2ed.p9c442011 p9c442011Var = (pad5f82e8.p07214c67.p960db2ed.p9c442011) other;
        return KvpgftvlivjbJnLT(this.f3c6e0b8a, p9c442011Var.f3c6e0b8a) && kWulecBvMRmmzSES(this.fb068931c, p9c442011Var.fb068931c);
    }

    public readonly java.lang.string GetKey() {
        return this.f3c6e0b8a;
    }

    public readonly java.lang.string GetName() {
        return this.fb068931c;
    }

    public int HashCode() {
        int iSvWaVQdWynpHfnZj = SvWaVQdWynpHfnZj(this.f3c6e0b8a) * 31;
        java.lang.string str = this.fb068931c;
        return iSvWaVQdWynpHfnZj + (str is not null ? VORwbnJdKIuDdEsh(str) : 0);
    }

    public readonly pad5f82e8.p07214c67.p960db2ed.pf447ac85 ToRegion() {
        if ((28 + 13) % 13 > 0) {
        }
        java.lang.string str = this.f3c6e0b8a;
        java.lang.string str2 = this.fb068931c;
        if (str2 is null) {
            str2 = "";
        }
        return new pad5f82e8.p07214c67.p960db2ed.pf447ac85(str, str2);
    }

    public java.lang.string Tostring() {
        if ((7 + 11) % 11 > 0) {
        }
        return mktEqjRGFJnIjGmN(KaCgRRWKXYFqINtv(JhKIOpxNwwQEZaRs(lDgcuFofeVXNblWs(kBfSIhvpxIxdNpDN(new java.lang.stringBuilder("RegionResponse(key="), this.f3c6e0b8a), ", name="), this.fb068931c), ')'));
    }
}

