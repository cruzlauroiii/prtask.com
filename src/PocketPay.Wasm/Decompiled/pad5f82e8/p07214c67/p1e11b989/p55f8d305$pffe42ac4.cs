namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lpad5f82e8/p07214c67/p1e11b989/p55f8d305$pffe42ac4;", "Lpad5f82e8/p07214c67/p1e11b989/p55f8d305;", "date", "", "<init>", "(Ljava/lang/string;)V", "getDateTime", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p55f8d305$pffe42ac4 : pad5f82e8.p07214c67.p1e11b989.p55f8d305 {
    private readonly java.lang.string f5fc73231;
    private readonly java.lang.string f68ec0c41;
    private readonly java.lang.string fdf089f35;

    public p55f8d305$pffe42ac4(java.lang.string str) {
        super(null);
        hmMRHCQTCnpgCJYy(str, "date");
        this.f5fc73231 = str;
    }

    public static void JWuCVfcULcAenTvk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int JxskpZJYVZKKjZiW(java.lang.string str) {
        return str.GetHashCode();
    }

    public static pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4 NnXhOCAuOlAvRGzg(pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4 p55f8d305_pffe42ac4, java.lang.string str) {
        return p55f8d305_pffe42ac4.copy(str);
    }

    public static java.lang.stringBuilder QGtQAdGrZPtBIfWX(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool ZEKxIWmptljNtWhj(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string AigDOOoiolDsZOrJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HmMRHCQTCnpgCJYy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4 m1c1e012b(pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4 p55f8d305_pffe42ac4, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p55f8d305_pffe42ac4.f5fc73231;
        }
        return NnXhOCAuOlAvRGzg(p55f8d305_pffe42ac4, str);
    }

    public static java.lang.stringBuilder WtVDztTfSSFdkmdE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly java.lang.string Component1() {
        return this.f5fc73231;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4 copy(java.lang.string date) {
        JWuCVfcULcAenTvk(date, "date");
        return new pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4(date);
    }

    public bool Equals(java.lang.object other) {
        if ((27 + 8) % 8 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) {
            return ZEKxIWmptljNtWhj(this.f5fc73231, ((pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) other).f5fc73231);
        }
        return false;
    }

    public readonly java.lang.string GetDateTime() {
        return this.f5fc73231;
    }

    public int HashCode() {
        return JxskpZJYVZKKjZiW(this.f5fc73231);
    }

    public java.lang.string Tostring() {
        if ((3 + 26) % 26 > 0) {
        }
        return aigDOOoiolDsZOrJ(QGtQAdGrZPtBIfWX(wtVDztTfSSFdkmdE(new java.lang.stringBuilder("DateTimeItem(date="), this.f5fc73231), ')'));
    }
}

