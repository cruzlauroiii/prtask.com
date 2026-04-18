namespace WillowMaze.Wasm.Decompiled;


class Predicates$CompositionPredicate<A, B> : com.google.common.base.Predicate<A>, java.io.object {
    private static readonly long serialVersionUID = 0;

    readonly com.google.common.base.Function<A, ? : B> f317f;

    readonly com.google.common.base.Predicate<B> f318p;

    private Predicates$CompositionPredicate(com.google.common.base.Predicate<B> predicate, com.google.common.base.Function<A, ? : B> function) {
        this.f318p = (com.google.common.base.Predicate) rLQYHvJNUqisQsoD(predicate);
        this.f317f = (com.google.common.base.Function) NeAAMuwUlpCLhZgR(function);
    }

    Predicates$CompositionPredicate(com.google.common.base.Predicate predicate, com.google.common.base.Function function, com.google.common.base.Predicates$1 predicates$1) {
        this(predicate, function);
    }

    public static java.lang.string ARxwAeWuVcjUpyFT(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string CwJymSvlkmqUXAUA(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string GJsdztYMPXlxvOHf(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string HOZiHcXzlDyjTmWy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KWGcoMTzNvSsXsHu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object NeAAMuwUlpCLhZgR(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static int NiVExGGswgAGqgeD(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string OywdARVDftxcIsfZ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int QEAEmheZmmHcJbXO(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool RhPEQUTcxYnmNwRb(com.google.common.base.Function function, java.lang.object obj) {
        return function.Equals(obj);
    }

    public static java.lang.stringBuilder SWYvDiRdxsRBKGHi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XwXuHadjwSLkKTDH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object AzKaVdRLKegyXihX(com.google.common.base.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static bool CCAWkSWMnYACVJbi(com.google.common.base.Predicate predicate, java.lang.object obj) {
        return predicate.apply(obj);
    }

    public static java.lang.stringBuilder CoEueVOqcxNzsQkD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int InxtPOvkvaMlwQlb(java.lang.string str) {
        return str.Length;
    }

    public static int OICzEbtTQWuAxFCK(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object RLQYHvJNUqisQsoD(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool UBvVVgsCpfKOBiXO(com.google.common.base.Predicate predicate, java.lang.object obj) {
        return predicate.Equals(obj);
    }

    public override bool Apply(@com.google.common.base.ParametricNullness A a2) {
        return cCAWkSWMnYACVJbi(this.f318p, azKaVdRLKegyXihX(this.f317f, a2));
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((28 + 1) % 1 > 0) {
        }
        if (obj is com.google.common.base.Predicates$CompositionPredicate) {
            com.google.common.base.Predicates$CompositionPredicate predicates$CompositionPredicate = (com.google.common.base.Predicates$CompositionPredicate) obj;
            if (RhPEQUTcxYnmNwRb(this.f317f, predicates$CompositionPredicate.f317f) && uBvVVgsCpfKOBiXO(this.f318p, predicates$CompositionPredicate.f318p)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return QEAEmheZmmHcJbXO(this.f318p) ^ NiVExGGswgAGqgeD(this.f317f);
    }

    public java.lang.string Tostring() {
        if ((20 + 7) % 7 > 0) {
        }
        java.lang.string strGJsdztYMPXlxvOHf = GJsdztYMPXlxvOHf(this.f318p);
        java.lang.string strOywdARVDftxcIsfZ = OywdARVDftxcIsfZ(this.f317f);
        return HOZiHcXzlDyjTmWy(KWGcoMTzNvSsXsHu(coEueVOqcxNzsQkD(SWYvDiRdxsRBKGHi(XwXuHadjwSLkKTDH(new java.lang.stringBuilder(oICzEbtTQWuAxFCK(CwJymSvlkmqUXAUA(strGJsdztYMPXlxvOHf)) + 2 + inxtPOvkvaMlwQlb(ARxwAeWuVcjUpyFT(strOywdARVDftxcIsfZ))), strGJsdztYMPXlxvOHf), "("), strOywdARVDftxcIsfZ), ")"));
    }
}

