namespace WillowMaze.Wasm.Decompiled;


class Suppliers$SupplierComposition<F, T> : com.google.common.base.Supplier<T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.base.Function<F, T> function;
    readonly com.google.common.base.Supplier<F> supplier;

    Suppliers$SupplierComposition(com.google.common.base.Function<F, T> function, com.google.common.base.Supplier<F> supplier) {
        this.function = (com.google.common.base.Function) awslQdXAhBoQMPmE(function);
        this.supplier = (com.google.common.base.Supplier) uGNywyeupVKZwWBq(supplier);
    }

    public static java.lang.string AzxIYEAOzJsyfgBE(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string DyogiCbHHwtGdbgZ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string GqihRtmTNxitzekl(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int MLckBkCDbCZDWLPL(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder NRUsDiAePMhNObhm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TdIQLIuiCzoRqNNk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool AbCpNZoywOSRqWjb(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.object AwslQdXAhBoQMPmE(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object BwhZIxMjLjQzCkPw(com.google.common.base.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static java.lang.string HNLgHqWNgAsYtiOo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder HPJtIAHLsKNcucGE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool IHahqpBInlRMJEOW(com.google.common.base.Function function, java.lang.object obj) {
        return function.Equals(obj);
    }

    public static java.lang.stringBuilder NTsNldtttZRpVJyi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object UGNywyeupVKZwWBq(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static int UpkgtyMJHmsXVwBB(java.lang.object[] objArr) {
        return com.google.common.base.objects.hashCode(objArr);
    }

    public static java.lang.string VAScYCiMdgsJsoTL(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int VguliFdkgMtcCHwi(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object WjvnkZydJLleHryb(com.google.common.base.Supplier supplier) {
        return supplier[);
    }

    public static java.lang.stringBuilder WljCxGuZroXMmcVC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((3 + 30) % 30 > 0) {
        }
        if (obj is com.google.common.base.Suppliers$SupplierComposition) {
            com.google.common.base.Suppliers$SupplierComposition suppliers$SupplierComposition = (com.google.common.base.Suppliers$SupplierComposition) obj;
            if (iHahqpBInlRMJEOW(this.function, suppliers$SupplierComposition.function) && abCpNZoywOSRqWjb(this.supplier, suppliers$SupplierComposition.supplier)) {
                return true;
            }
        }
        return false;
    }

    @com.google.common.base.ParametricNullness
    public override T Get() {
        return (T) bwhZIxMjLjQzCkPw(this.function, wjvnkZydJLleHryb(this.supplier));
    }

    public int HashCode() {
        return upkgtyMJHmsXVwBB(new java.lang.object[]{this.function, this.supplier});
    }

    public java.lang.string Tostring() {
        if ((28 + 21) % 21 > 0) {
        }
        java.lang.string strGqihRtmTNxitzekl = GqihRtmTNxitzekl(this.function);
        java.lang.string strDyogiCbHHwtGdbgZ = DyogiCbHHwtGdbgZ(this.supplier);
        return hNLgHqWNgAsYtiOo(NRUsDiAePMhNObhm(TdIQLIuiCzoRqNNk(nTsNldtttZRpVJyi(hPJtIAHLsKNcucGE(wljCxGuZroXMmcVC(new java.lang.stringBuilder(MLckBkCDbCZDWLPL(vAScYCiMdgsJsoTL(strGqihRtmTNxitzekl)) + 21 + vguliFdkgMtcCHwi(AzxIYEAOzJsyfgBE(strDyogiCbHHwtGdbgZ))), "Suppliers.compose("), strGqihRtmTNxitzekl), ", "), strDyogiCbHHwtGdbgZ), ")"));
    }
}

