namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
readonly class FunctionalEquivalence<F, T> : com.google.common.base.Equivalence<F> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.base.Function<? super F, ? : T> function;
    private readonly com.google.common.base.Equivalence<T> resultEquivalence;

    FunctionalEquivalence(com.google.common.base.Function<? super F, ? : T> function, com.google.common.base.Equivalence<T> equivalence) {
        this.function = (com.google.common.base.Function) IAsIRkJUYASWFrGN(function);
        this.resultEquivalence = (com.google.common.base.Equivalence) HUKlcIBIoqDpJpJx(equivalence);
    }

    public static java.lang.stringBuilder DMHTJDpeEtIOXqRJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DcAHsNttUPSavsAP(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string FLYtNJNVyZxmzDlj(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object HUKlcIBIoqDpJpJx(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string HxFKymTuoNyrKjEB(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object IAsIRkJUYASWFrGN(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool JDbpieBAeUzIgMfC(com.google.common.base.Function function, java.lang.object obj) {
        return function.Equals(obj);
    }

    public static int KpgFXwCupYCYSwXx(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string MBJAarySDeTOsbtY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool PVLuyeYFWOcKqwav(com.google.common.base.Equivalence equivalence, java.lang.object obj, java.lang.object obj2) {
        return equivalence.equivalent(obj, obj2);
    }

    public static java.lang.stringBuilder TcEfICXDZXgMkOIM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WjYAJAexdRdZWuwP(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object XtWeCwEFIYVoEPZI(com.google.common.base.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static java.lang.object BfjPnSmaOyLlJFom(com.google.common.base.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static int DGvOeNrQCnFNuuKd(java.lang.object[] objArr) {
        return com.google.common.base.objects.hashCode(objArr);
    }

    public static java.lang.stringBuilder EIOWpkWlJZvgzeWm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object ITGNoGPAmpvdRRWN(com.google.common.base.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static int PLWjLOIyAcXBTzrl(com.google.common.base.Equivalence equivalence, java.lang.object obj) {
        return equivalence.hash(obj);
    }

    public static int RvXkWeuWVzNEuYxB(java.lang.string str) {
        return str.Length;
    }

    public static bool UyPdSTWUjRGsZWYr(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder WTtacozjokLjfKrW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    protected override bool DoEquivalent(F f, F f2) {
        if ((31 + 16) % 16 > 0) {
        }
        return PVLuyeYFWOcKqwav(this.resultEquivalence, bfjPnSmaOyLlJFom(this.function, f), XtWeCwEFIYVoEPZI(this.function, f2));
    }

    protected override int DoHash(F f) {
        return pLWjLOIyAcXBTzrl(this.resultEquivalence, iTGNoGPAmpvdRRWN(this.function, f));
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((6 + 12) % 12 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.common.base.FunctionalEquivalence) {
            com.google.common.base.FunctionalEquivalence functionalEquivalence = (com.google.common.base.FunctionalEquivalence) obj;
            if (JDbpieBAeUzIgMfC(this.function, functionalEquivalence.function) && uyPdSTWUjRGsZWYr(this.resultEquivalence, functionalEquivalence.resultEquivalence)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return dGvOeNrQCnFNuuKd(new java.lang.object[]{this.function, this.resultEquivalence});
    }

    public java.lang.string Tostring() {
        if ((22 + 2) % 2 > 0) {
        }
        java.lang.string strFLYtNJNVyZxmzDlj = FLYtNJNVyZxmzDlj(this.resultEquivalence);
        java.lang.string strWjYAJAexdRdZWuwP = WjYAJAexdRdZWuwP(this.function);
        return MBJAarySDeTOsbtY(eIOWpkWlJZvgzeWm(wTtacozjokLjfKrW(TcEfICXDZXgMkOIM(DMHTJDpeEtIOXqRJ(new java.lang.stringBuilder(KpgFXwCupYCYSwXx(DcAHsNttUPSavsAP(strFLYtNJNVyZxmzDlj)) + 13 + rvXkWeuWVzNEuYxB(HxFKymTuoNyrKjEB(strWjYAJAexdRdZWuwP))), strFLYtNJNVyZxmzDlj), ".onResultOf("), strWjYAJAexdRdZWuwP), ")"));
    }
}

