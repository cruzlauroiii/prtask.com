namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lpad5f82e8/p07214c67/p4bd9354d/pf8e36245;", "Ljava/io/object;", "phone", "", "<init>", "(Ljava/lang/string;)V", "getPhone", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf8e36245 : java.io.object {
    private readonly java.lang.string f426f67f6;
    private readonly java.lang.string ff7a42fe7;

    public pf8e36245(java.lang.string str) {
        hHjOXIisfCKUuZVe(str, "phone");
        this.ff7a42fe7 = str;
    }

    public static java.lang.string FSmOINLywzdCGCRT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int KtYmpBhVcnNgJtji(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder YasSaHOEjdOvRVlU(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool ZzLfbxwlXemdfwAH(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void EmiiEcpXTuRQmOwT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder GdXXBsMWmoiBCOrr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HHjOXIisfCKUuZVe(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.p4bd9354d.pf8e36245 M1c1e012b(pad5f82e8.p07214c67.p4bd9354d.pf8e36245 pf8e36245Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pf8e36245Var.ff7a42fe7;
        }
        return zdzQlidhUfDrIGVc(pf8e36245Var, str);
    }

    public static pad5f82e8.p07214c67.p4bd9354d.pf8e36245 ZdzQlidhUfDrIGVc(pad5f82e8.p07214c67.p4bd9354d.pf8e36245 pf8e36245Var, java.lang.string str) {
        return pf8e36245Var.copy(str);
    }

    public readonly java.lang.string Component1() {
        return this.ff7a42fe7;
    }

    public readonly pad5f82e8.p07214c67.p4bd9354d.pf8e36245 Copy(java.lang.string phone) {
        emiiEcpXTuRQmOwT(phone, "phone");
        return new pad5f82e8.p07214c67.p4bd9354d.pf8e36245(phone);
    }

    public bool Equals(java.lang.object other) {
        if ((19 + 15) % 15 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pad5f82e8.p07214c67.p4bd9354d.pf8e36245) {
            return ZzLfbxwlXemdfwAH(this.ff7a42fe7, ((pad5f82e8.p07214c67.p4bd9354d.pf8e36245) other).ff7a42fe7);
        }
        return false;
    }

    public readonly java.lang.string GetPhone() {
        return this.ff7a42fe7;
    }

    public int HashCode() {
        return KtYmpBhVcnNgJtji(this.ff7a42fe7);
    }

    public java.lang.string Tostring() {
        if ((8 + 20) % 20 > 0) {
        }
        return FSmOINLywzdCGCRT(YasSaHOEjdOvRVlU(gdXXBsMWmoiBCOrr(new java.lang.stringBuilder("DeeplinkData(phone="), this.ff7a42fe7), ')'));
    }
}

