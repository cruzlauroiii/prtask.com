namespace WillowMaze.Wasm.Decompiled;


class Functions$PredicateFunction<T> : com.google.common.base.Function<T, java.lang.bool>, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.base.Predicate<T> predicate;

    private Functions$PredicateFunction(com.google.common.base.Predicate<T> predicate) {
        this.predicate = (com.google.common.base.Predicate) DLqxITlemGAiaILq(predicate);
    }

    Functions$PredicateFunction(com.google.common.base.Predicate predicate, com.google.common.base.Functions$1 functions$1) {
        this(predicate);
    }

    public static java.lang.object DLqxITlemGAiaILq(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string EsOmdvKKKhAhIrhj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int GcINcBcGfcgiQuFR(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.bool PFbnGGkjTtrIMLUK(com.google.common.base.Functions$PredicateFunction functions$PredicateFunction, java.lang.object obj) {
        return functions$PredicateFunction.apply(obj);
    }

    public static java.lang.stringBuilder PGXxSNeVPjnQoeXe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PLuPUULSSwqXriwY(java.lang.string str) {
        return str.Length;
    }

    public static bool PxqiIjnSFiXUqBhp(com.google.common.base.Predicate predicate, java.lang.object obj) {
        return predicate.apply(obj);
    }

    public static java.lang.string VMKzBcwcJthINKJH(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.bool IhSGmeYzVsSuAreS(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool LnpxwOPXIrMEApnS(com.google.common.base.Predicate predicate, java.lang.object obj) {
        return predicate.Equals(obj);
    }

    public static java.lang.string PknxjQtxnYPKcLbm(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder YFbYVqhvNTTEvqjl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YxvZYwEFjcMSSLVN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override java.lang.bool Apply(@com.google.common.base.ParametricNullness T t) {
        return ihSGmeYzVsSuAreS(PxqiIjnSFiXUqBhp(this.predicate, t));
    }

    public override java.lang.bool Apply(@com.google.common.base.ParametricNullness java.lang.object obj) {
        return PFbnGGkjTtrIMLUK(this, obj);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Functions$PredicateFunction)) {
            return false;
        }
        return lnpxwOPXIrMEApnS(this.predicate, ((com.google.common.base.Functions$PredicateFunction) obj).predicate);
    }

    public int HashCode() {
        return GcINcBcGfcgiQuFR(this.predicate);
    }

    public java.lang.string Tostring() {
        if ((32 + 32) % 32 > 0) {
        }
        java.lang.string strVMKzBcwcJthINKJH = VMKzBcwcJthINKJH(this.predicate);
        return EsOmdvKKKhAhIrhj(PGXxSNeVPjnQoeXe(yFbYVqhvNTTEvqjl(yxvZYwEFjcMSSLVN(new java.lang.stringBuilder(PLuPUULSSwqXriwY(pknxjQtxnYPKcLbm(strVMKzBcwcJthINKJH)) + 24), "Functions.forPredicate("), strVMKzBcwcJthINKJH), ")"));
    }
}

