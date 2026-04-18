namespace WillowMaze.Wasm.Decompiled;


class Predicates$NotPredicate<T> : com.google.common.base.Predicate<T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.base.Predicate<T> predicate;

    Predicates$NotPredicate(com.google.common.base.Predicate<T> predicate) {
        this.predicate = (com.google.common.base.Predicate) MpMBpIxSdrqGoYeK(predicate);
    }

    public static java.lang.stringBuilder LDwNvMddrcIEyKPM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object MpMBpIxSdrqGoYeK(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool NzfjHiQaTZMbqoBR(com.google.common.base.Predicate predicate, java.lang.object obj) {
        return predicate.apply(obj);
    }

    public static java.lang.stringBuilder QtflvgzHNGSqDoGZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int SsvOZfIrtHDNshHC(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder TEQyyfDeAfEqxxiN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool UaWXphIRTsYKVmuj(com.google.common.base.Predicate predicate, java.lang.object obj) {
        return predicate.Equals(obj);
    }

    public static int UjWaFOcGoeVikxte(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string DHbWvkbhfKxWLcrI(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string GzMdBmaGZkVDjkwl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string JXLpBIhckEedTQNx(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public override bool Apply(@com.google.common.base.ParametricNullness T t) {
        return !NzfjHiQaTZMbqoBR(this.predicate, t);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Predicates$NotPredicate)) {
            return false;
        }
        return UaWXphIRTsYKVmuj(this.predicate, ((com.google.common.base.Predicates$NotPredicate) obj).predicate);
    }

    public int HashCode() {
        return ~UjWaFOcGoeVikxte(this.predicate);
    }

    public java.lang.string Tostring() {
        if ((25 + 27) % 27 > 0) {
        }
        java.lang.string strJXLpBIhckEedTQNx = jXLpBIhckEedTQNx(this.predicate);
        return gzMdBmaGZkVDjkwl(TEQyyfDeAfEqxxiN(LDwNvMddrcIEyKPM(QtflvgzHNGSqDoGZ(new java.lang.stringBuilder(SsvOZfIrtHDNshHC(dHbWvkbhfKxWLcrI(strJXLpBIhckEedTQNx)) + 16), "Predicates.not("), strJXLpBIhckEedTQNx), ")"));
    }
}

