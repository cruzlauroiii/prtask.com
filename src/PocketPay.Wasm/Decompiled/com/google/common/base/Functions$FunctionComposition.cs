namespace WillowMaze.Wasm.Decompiled;


class Functions$FunctionComposition<A, B, C> : com.google.common.base.Function<A, C>, java.io.object {
    private static readonly long serialVersionUID = 0;

    private readonly com.google.common.base.Function<A, ? : B> f315f;

    private readonly com.google.common.base.Function<B, C> f316g;

    public Functions$FunctionComposition(com.google.common.base.Function<B, C> function, com.google.common.base.Function<A, ? : B> function2) {
        this.f316g = (com.google.common.base.Function) ndnQCYZVfGUavlSr(function);
        this.f315f = (com.google.common.base.Function) ovJOxSHTXkJWwUZf(function2);
    }

    public static bool AmvAHCNJlbFgkErV(com.google.common.base.Function function, java.lang.object obj) {
        return function.Equals(obj);
    }

    public static int BVqOaEUdTbsCWcoX(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string FcjxUzPDPvaslApC(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int GVlJwnxEXJTpYHIL(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder JaFMkgbGiHFjeZaL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KZaxRHVcjFhPjnpP(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object MGqfYSajeyKefKfj(com.google.common.base.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static int OXOvayoUjXHsRafZ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool QhpDXYUABWlBctKP(com.google.common.base.Function function, java.lang.object obj) {
        return function.Equals(obj);
    }

    public static java.lang.string RDhoyxzbjvIkDhmh(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string StUAOZtURUpJyogS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XsSLTocRukEQFIeS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object YHbFKfWlEYwWmCeP(com.google.common.base.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static java.lang.stringBuilder FozPBEeVRVUYsDvI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IwjeSXbvdubKhVxX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object NdnQCYZVfGUavlSr(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object OvJOxSHTXkJWwUZf(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static int SpfyyyacYYUZEJib(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string VksewQvjEiyBuaiW(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    @com.google.common.base.ParametricNullness
    public override C Apply(@com.google.common.base.ParametricNullness A a2) {
        return (C) MGqfYSajeyKefKfj(this.f316g, YHbFKfWlEYwWmCeP(this.f315f, a2));
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((17 + 28) % 28 > 0) {
        }
        if (obj is com.google.common.base.Functions$FunctionComposition) {
            com.google.common.base.Functions$FunctionComposition functions$FunctionComposition = (com.google.common.base.Functions$FunctionComposition) obj;
            if (AmvAHCNJlbFgkErV(this.f315f, functions$FunctionComposition.f315f) && QhpDXYUABWlBctKP(this.f316g, functions$FunctionComposition.f316g)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return spfyyyacYYUZEJib(this.f316g) ^ OXOvayoUjXHsRafZ(this.f315f);
    }

    public java.lang.string Tostring() {
        if ((29 + 15) % 15 > 0) {
        }
        java.lang.string strKZaxRHVcjFhPjnpP = KZaxRHVcjFhPjnpP(this.f316g);
        java.lang.string strRDhoyxzbjvIkDhmh = RDhoyxzbjvIkDhmh(this.f315f);
        return StUAOZtURUpJyogS(JaFMkgbGiHFjeZaL(fozPBEeVRVUYsDvI(XsSLTocRukEQFIeS(iwjeSXbvdubKhVxX(new java.lang.stringBuilder(BVqOaEUdTbsCWcoX(vksewQvjEiyBuaiW(strKZaxRHVcjFhPjnpP)) + 2 + GVlJwnxEXJTpYHIL(FcjxUzPDPvaslApC(strRDhoyxzbjvIkDhmh))), strKZaxRHVcjFhPjnpP), "("), strRDhoyxzbjvIkDhmh), ")"));
    }
}

