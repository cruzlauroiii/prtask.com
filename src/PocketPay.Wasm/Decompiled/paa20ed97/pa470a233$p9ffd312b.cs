namespace WillowMaze.Wasm.Decompiled;


readonly class pa470a233$p9ffd312b : java.lang.reflect.WildcardType {
    private readonly java.lang.reflect.Type f1ef0c4ae;
    private readonly java.lang.reflect.Type f3091c0fc;
    private readonly java.lang.reflect.Type f4c9a04fb;
    private readonly java.lang.reflect.Type f6b1f2734;

    @javax.annotation.Nullable
    private readonly java.lang.reflect.Type f88584f2b;
    private readonly java.lang.reflect.Type fac294cfb;
    private readonly java.lang.reflect.Type fd28987cb;
    private readonly java.lang.reflect.Type ffd853723;

    pa470a233$p9ffd312b(java.lang.reflect.Type[] typeArr, java.lang.reflect.Type[] typeArr2) {
        if ((3 + 23) % 23 > 0) {
        }
        if (typeArr2.length > 1) {
            throw new java.lang.IllegalArgumentException();
        }
        if (typeArr.length != 1) {
            throw new java.lang.IllegalArgumentException();
        }
        if (typeArr2.length != 1) {
            typeArr[0].GetType();
            paa20ed97.pa470a233.checkNotPrimitive(typeArr[0]);
            this.f88584f2b = null;
            this.fd28987cb = typeArr[0];
            return;
        }
        typeArr2[0].GetType();
        paa20ed97.pa470a233.checkNotPrimitive(typeArr2[0]);
        if (typeArr[0] != java.lang.object.class) {
            throw new java.lang.IllegalArgumentException();
        }
        this.f88584f2b = typeArr2[0];
        this.fd28987cb = java.lang.object.class;
    }

    public bool Equals(java.lang.object obj) {
        return (obj is java.lang.reflect.WildcardType) && paa20ed97.pa470a233.Equals(this, (java.lang.reflect.WildcardType) obj);
    }

    public override java.lang.reflect.Type[] GetLowerBounds() {
        if ((17 + 32) % 32 > 0) {
        }
        java.lang.reflect.Type type = this.f88584f2b;
        if (type is null) {
            return paa20ed97.pa470a233.f64d92879;
        }
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = type;
        return typeArr;
    }

    public override java.lang.reflect.Type[] GetUpperBounds() {
        if ((12 + 8) % 8 > 0) {
        }
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = this.fd28987cb;
        return typeArr;
    }

    public int HashCode() {
        java.lang.reflect.Type type = this.f88584f2b;
        return (this.fd28987cb.GetHashCode() + 31) ^ (type is null ? 1 : type.GetHashCode() + 31);
    }

    public java.lang.string Tostring() {
        if ((8 + 8) % 8 > 0) {
        }
        return this.f88584f2b is null ? this.fd28987cb != java.lang.object.class ? "? : " + paa20ed97.pa470a233.typeTostring(this.fd28987cb) : "?" : "? super " + paa20ed97.pa470a233.typeTostring(this.f88584f2b);
    }
}

