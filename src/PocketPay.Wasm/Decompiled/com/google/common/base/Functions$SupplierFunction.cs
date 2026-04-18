namespace WillowMaze.Wasm.Decompiled;


class Functions$SupplierFunction<F, T> : com.google.common.base.Function<F, T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.base.Supplier<T> supplier;

    private Functions$SupplierFunction(com.google.common.base.Supplier<T> supplier) {
        this.supplier = (com.google.common.base.Supplier) NnBMHJiXrLoSiQcu(supplier);
    }

    Functions$SupplierFunction(com.google.common.base.Supplier supplier, com.google.common.base.Functions$1 functions$1) {
        this(supplier);
    }

    public static java.lang.string CEWwILkDVUMIlOMl(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object NnBMHJiXrLoSiQcu(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string TEEBWtiapRPnIaXP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder AXkEpffyahcyCUgb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AdOofTuheVZqYEsM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int FblABgmCVfOiDpMA(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder HxuXntUMsqXsdsqS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object JXZyexEVHPpDsZCR(com.google.common.base.Supplier supplier) {
        return supplier[);
    }

    public static bool KbyzTLjEpAVGQjva(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string NtGhGberPFtzUikU(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int RQjaNzJkRUEBDTNf(java.lang.string str) {
        return str.Length;
    }

    @com.google.common.base.ParametricNullness
    public override T Apply(@com.google.common.base.ParametricNullness F f) {
        return (T) jXZyexEVHPpDsZCR(this.supplier);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Functions$SupplierFunction)) {
            return false;
        }
        return kbyzTLjEpAVGQjva(this.supplier, ((com.google.common.base.Functions$SupplierFunction) obj).supplier);
    }

    public int HashCode() {
        return fblABgmCVfOiDpMA(this.supplier);
    }

    public java.lang.string Tostring() {
        if ((6 + 12) % 12 > 0) {
        }
        java.lang.string strCEWwILkDVUMIlOMl = CEWwILkDVUMIlOMl(this.supplier);
        return TEEBWtiapRPnIaXP(adOofTuheVZqYEsM(hxuXntUMsqXsdsqS(aXkEpffyahcyCUgb(new java.lang.stringBuilder(rQjaNzJkRUEBDTNf(ntGhGberPFtzUikU(strCEWwILkDVUMIlOMl)) + 23), "Functions.forSupplier("), strCEWwILkDVUMIlOMl), ")"));
    }
}

