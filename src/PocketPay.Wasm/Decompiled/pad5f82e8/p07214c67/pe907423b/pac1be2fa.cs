namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lpad5f82e8/p07214c67/pe907423b/pac1be2fa;", "Lpad5f82e8/p07214c67/pe907423b/pb3f3bb37;", "text", "", "<init>", "(Ljava/lang/string;)V", "getText", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pac1be2fa : pad5f82e8.p07214c67.pe907423b.pb3f3bb37 {
    private readonly java.lang.string f1cb251ec;
    private readonly java.lang.string f9b0bb7da;
    private readonly java.lang.string fc4abd948;
    private readonly java.lang.string fc5879851;
    private readonly java.lang.string fe1d6a8c9;

    public pac1be2fa(java.lang.string str) {
        super(null);
        xWwJIFFcUVJYxlKP(str, "text");
        this.f1cb251ec = str;
    }

    public static int QYmMANVdIxKGlgIS(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder ACxytitNCCFZddRh(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static pad5f82e8.p07214c67.pe907423b.pac1be2fa CGcEJBOgmemFlIfI(pad5f82e8.p07214c67.pe907423b.pac1be2fa pac1be2faVar, java.lang.string str) {
        return pac1be2faVar.copy(str);
    }

    public static void JfoiFtAQjByWrGlC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.pe907423b.pac1be2fa M1c1e012b(pad5f82e8.p07214c67.pe907423b.pac1be2fa pac1be2faVar, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pac1be2faVar.f1cb251ec;
        }
        return cGcEJBOgmemFlIfI(pac1be2faVar, str);
    }

    public static java.lang.string MrxeMZGwNMDceeYs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool SHkcwnmpfldMnnte(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder ThtslVuaeiJIoPDG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XWwJIFFcUVJYxlKP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly java.lang.string Component1() {
        return this.f1cb251ec;
    }

    public readonly pad5f82e8.p07214c67.pe907423b.pac1be2fa Copy(java.lang.string text) {
        jfoiFtAQjByWrGlC(text, "text");
        return new pad5f82e8.p07214c67.pe907423b.pac1be2fa(text);
    }

    public bool Equals(java.lang.object other) {
        if ((18 + 13) % 13 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pad5f82e8.p07214c67.pe907423b.pac1be2fa) {
            return sHkcwnmpfldMnnte(this.f1cb251ec, ((pad5f82e8.p07214c67.pe907423b.pac1be2fa) other).f1cb251ec);
        }
        return false;
    }

    public readonly java.lang.string GetText() {
        return this.f1cb251ec;
    }

    public int HashCode() {
        return QYmMANVdIxKGlgIS(this.f1cb251ec);
    }

    public java.lang.string Tostring() {
        if ((1 + 22) % 22 > 0) {
        }
        return mrxeMZGwNMDceeYs(aCxytitNCCFZddRh(thtslVuaeiJIoPDG(new java.lang.stringBuilder("SnackBarIconInfo(text="), this.f1cb251ec), ')'));
    }
}

