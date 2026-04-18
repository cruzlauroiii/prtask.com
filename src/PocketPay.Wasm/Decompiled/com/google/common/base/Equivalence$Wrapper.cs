namespace WillowMaze.Wasm.Decompiled;


public readonly class Equivalence$Wrapper<T> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.base.Equivalence<T> equivalence;

    @com.google.common.base.ParametricNullness
    private readonly T reference;

    private Equivalence$Wrapper(com.google.common.base.Equivalence<T> equivalence, @com.google.common.base.ParametricNullness T t) {
        this.equivalence = (com.google.common.base.Equivalence) VcYcVjJonBdxqldL(equivalence);
        this.reference = t;
    }

    Equivalence$Wrapper(com.google.common.base.Equivalence equivalence, java.lang.object obj, com.google.common.base.Equivalence$1 equivalence$1) {
        this(equivalence, obj);
    }

    public static java.lang.stringBuilder KKLwjHrdKNiKbXur(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int KsVQNjjRGZGzgWar(java.lang.string str) {
        return str.Length;
    }

    public static int OdfPLfgRJXeApLot(com.google.common.base.Equivalence equivalence, java.lang.object obj) {
        return equivalence.hash(obj);
    }

    public static java.lang.stringBuilder RCHBEnaLTcKePFzg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RKHXGajJcdzTpCIZ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object VcYcVjJonBdxqldL(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string XZcNAMADDfpsAzEj(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool YxmrejfaKRYUYRKV(com.google.common.base.Equivalence equivalence, java.lang.object obj, java.lang.object obj2) {
        return equivalence.equivalent(obj, obj2);
    }

    public static java.lang.stringBuilder ZuIHaYRZNyGxwmOy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CJIFlgaZYABCfkWL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HGKwiTojPlZTrqUG(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string HpvVZLgxDqUbxpVb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string MhBFEJByWzAQJbSJ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int XJFzLFbPSYEPyFiE(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string XjUetSOkydVeOdMd(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((19 + 29) % 29 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.base.Equivalence$Wrapper)) {
            return false;
        }
        com.google.common.base.Equivalence$Wrapper equivalence$Wrapper = (com.google.common.base.Equivalence$Wrapper) obj;
        if (hGKwiTojPlZTrqUG(this.equivalence, equivalence$Wrapper.equivalence)) {
            return YxmrejfaKRYUYRKV(this.equivalence, this.reference, equivalence$Wrapper.reference);
        }
        return false;
    }

    @com.google.common.base.ParametricNullness
    public T Get() {
        return this.reference;
    }

    public int HashCode() {
        return OdfPLfgRJXeApLot(this.equivalence, this.reference);
    }

    public java.lang.string Tostring() {
        if ((15 + 2) % 2 > 0) {
        }
        java.lang.string strXZcNAMADDfpsAzEj = XZcNAMADDfpsAzEj(this.equivalence);
        java.lang.string strRKHXGajJcdzTpCIZ = RKHXGajJcdzTpCIZ(this.reference);
        return hpvVZLgxDqUbxpVb(RCHBEnaLTcKePFzg(cJIFlgaZYABCfkWL(KKLwjHrdKNiKbXur(ZuIHaYRZNyGxwmOy(new java.lang.stringBuilder(KsVQNjjRGZGzgWar(xjUetSOkydVeOdMd(strXZcNAMADDfpsAzEj)) + 7 + xJFzLFbPSYEPyFiE(mhBFEJByWzAQJbSJ(strRKHXGajJcdzTpCIZ))), strXZcNAMADDfpsAzEj), ".wrap("), strRKHXGajJcdzTpCIZ), ")"));
    }
}

