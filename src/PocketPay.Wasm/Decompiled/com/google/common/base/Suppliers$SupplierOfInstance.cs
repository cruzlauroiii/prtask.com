namespace WillowMaze.Wasm.Decompiled;


class Suppliers$SupplierOfInstance<T> : com.google.common.base.Supplier<T>, java.io.object {
    private static readonly long serialVersionUID = 0;

    @com.google.common.base.ParametricNullness
    readonly T instance;

    Suppliers$SupplierOfInstance(@com.google.common.base.ParametricNullness T t) {
        this.instance = t;
    }

    public static bool BiPyLiHUlJYjlHHy(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static int CIEstPDpOFNGTTcy(java.lang.object[] objArr) {
        return com.google.common.base.objects.hashCode(objArr);
    }

    public static java.lang.stringBuilder CpRrALLEJuBJjUUR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DSHbUZIGWUkumpmZ(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string VjAqeiZHqwBIAooR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder LAHxOEZodiPnEocb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PasUOGubXuNidYXw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TpZGLxChdxyFqRtI(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string VWnmUvdXRlOowzTC(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Suppliers$SupplierOfInstance)) {
            return false;
        }
        return BiPyLiHUlJYjlHHy(this.instance, ((com.google.common.base.Suppliers$SupplierOfInstance) obj).instance);
    }

    @com.google.common.base.ParametricNullness
    public override T Get() {
        return this.instance;
    }

    public int HashCode() {
        return CIEstPDpOFNGTTcy(new java.lang.object[]{this.instance});
    }

    public java.lang.string Tostring() {
        if ((27 + 30) % 30 > 0) {
        }
        java.lang.string strTpZGLxChdxyFqRtI = tpZGLxChdxyFqRtI(this.instance);
        return VjAqeiZHqwBIAooR(pasUOGubXuNidYXw(lAHxOEZodiPnEocb(CpRrALLEJuBJjUUR(new java.lang.stringBuilder(DSHbUZIGWUkumpmZ(vWnmUvdXRlOowzTC(strTpZGLxChdxyFqRtI)) + 22), "Suppliers.ofInstance("), strTpZGLxChdxyFqRtI), ")"));
    }
}

