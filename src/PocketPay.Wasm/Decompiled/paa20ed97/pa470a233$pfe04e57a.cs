namespace WillowMaze.Wasm.Decompiled;


readonly class pa470a233$pfe04e57a : java.lang.reflect.GenericArrayType {
    private readonly java.lang.reflect.Type f2b3d37bf;
    private readonly java.lang.reflect.Type fa63c30b1;
    private readonly java.lang.reflect.Type fcd31f0e5;
    private readonly java.lang.reflect.Type ff10ca647;
    private readonly java.lang.reflect.Type ffb97987f;

    pa470a233$pfe04e57a(java.lang.reflect.Type type) {
        this.f2b3d37bf = type;
    }

    public bool Equals(java.lang.object obj) {
        return (obj is java.lang.reflect.GenericArrayType) && paa20ed97.pa470a233.Equals(this, (java.lang.reflect.GenericArrayType) obj);
    }

    public override java.lang.reflect.Type GetGenericComponentType() {
        return this.f2b3d37bf;
    }

    public int HashCode() {
        return this.f2b3d37bf.GetHashCode();
    }

    public java.lang.string Tostring() {
        return paa20ed97.pa470a233.typeTostring(this.f2b3d37bf) + com.decryptstringmanager.Decryptstring.decryptstring("be0527e649ea899e064741d39494ba2253a2c1ac031d5e1d4dc2f3de9a36");
    }
}

