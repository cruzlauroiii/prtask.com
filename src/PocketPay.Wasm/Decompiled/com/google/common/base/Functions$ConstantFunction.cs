namespace WillowMaze.Wasm.Decompiled;


class Functions$ConstantFunction<E> : com.google.common.base.Function<java.lang.object, E>, java.io.object {
    private static readonly long serialVersionUID = 0;

    @com.google.common.base.ParametricNullness
    private readonly E value;

    public Functions$ConstantFunction(@com.google.common.base.ParametricNullness E e) {
        this.value = e;
    }

    public static java.lang.string CbXatmwIKEVLekyt(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string EJahRaeJvAyvrQtr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool OOlYfQccXDcEywvF(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static java.lang.stringBuilder AjECfsUpwmGxMAkJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MKSbEkckARWjydPy(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder ONkdeqNgSsFjICjx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QIoNDngZDUENtboU(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder StuEvdPlWcLNyXOW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WSUQjGaVrwMCfjVz(java.lang.object obj) {
        return obj.GetHashCode();
    }

    @com.google.common.base.ParametricNullness
    public override E Apply(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.value;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Functions$ConstantFunction)) {
            return false;
        }
        return OOlYfQccXDcEywvF(this.value, ((com.google.common.base.Functions$ConstantFunction) obj).value);
    }

    public int HashCode() {
        E e = this.value;
        if (e is not null) {
            return wSUQjGaVrwMCfjVz(e);
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((26 + 18) % 18 > 0) {
        }
        java.lang.string strMKSbEkckARWjydPy = mKSbEkckARWjydPy(this.value);
        return EJahRaeJvAyvrQtr(ajECfsUpwmGxMAkJ(stuEvdPlWcLNyXOW(oNkdeqNgSsFjICjx(new java.lang.stringBuilder(qIoNDngZDUENtboU(CbXatmwIKEVLekyt(strMKSbEkckARWjydPy)) + 20), "Functions.constant("), strMKSbEkckARWjydPy), ")"));
    }
}

