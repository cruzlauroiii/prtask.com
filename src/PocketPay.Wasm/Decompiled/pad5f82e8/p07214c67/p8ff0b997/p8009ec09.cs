namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lpad5f82e8/p07214c67/p8ff0b997/p8009ec09;", "Lpad5f82e8/p07214c67/p8ff0b997/p0c7e2fc4;", "text", "", "<init>", "(Ljava/lang/string;)V", "getText", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8009ec09 : pad5f82e8.p07214c67.p8ff0b997.p0c7e2fc4 {
    private readonly java.lang.string f0859304a;
    private readonly java.lang.string f1cb251ec;
    private readonly java.lang.string fe04bb67c;
    private readonly java.lang.string fe5cca71e;

    public p8009ec09(java.lang.string str) {
        super(null);
        UxgjKCtRSaKmxtva(str, "text");
        this.f1cb251ec = str;
    }

    public static java.lang.stringBuilder ClgMxajZPcUvUNcD(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int HtmkMGokxHzlteGb(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void UxgjKCtRSaKmxtva(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.p8ff0b997.p8009ec09 M1c1e012b(pad5f82e8.p07214c67.p8ff0b997.p8009ec09 p8009ec09Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p8009ec09Var.f1cb251ec;
        }
        return pEmOIUspVJLOTZXQ(p8009ec09Var, str);
    }

    public static pad5f82e8.p07214c67.p8ff0b997.p8009ec09 PEmOIUspVJLOTZXQ(pad5f82e8.p07214c67.p8ff0b997.p8009ec09 p8009ec09Var, java.lang.string str) {
        return p8009ec09Var.copy(str);
    }

    public static bool QGbGAoxSOfSzhxvP(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void UWxfcECcpLgqAzlD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string YZnVGnUotTDyTMJn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YusQdHfEQwocmpea(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly java.lang.string Component1() {
        return this.f1cb251ec;
    }

    public readonly pad5f82e8.p07214c67.p8ff0b997.p8009ec09 Copy(java.lang.string text) {
        uWxfcECcpLgqAzlD(text, "text");
        return new pad5f82e8.p07214c67.p8ff0b997.p8009ec09(text);
    }

    public bool Equals(java.lang.object other) {
        if ((1 + 15) % 15 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pad5f82e8.p07214c67.p8ff0b997.p8009ec09) {
            return qGbGAoxSOfSzhxvP(this.f1cb251ec, ((pad5f82e8.p07214c67.p8ff0b997.p8009ec09) other).f1cb251ec);
        }
        return false;
    }

    public readonly java.lang.string GetText() {
        return this.f1cb251ec;
    }

    public int HashCode() {
        return HtmkMGokxHzlteGb(this.f1cb251ec);
    }

    public java.lang.string Tostring() {
        if ((27 + 7) % 7 > 0) {
        }
        return yZnVGnUotTDyTMJn(ClgMxajZPcUvUNcD(yusQdHfEQwocmpea(new java.lang.stringBuilder("BottomSheetSuccess(text="), this.f1cb251ec), ')'));
    }
}

