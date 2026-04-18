namespace WillowMaze.Wasm.Decompiled;


readonly class Types$GenericArrayTypeImpl : java.lang.reflect.GenericArrayType, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.lang.reflect.Type componentType;

    Types$GenericArrayTypeImpl(java.lang.reflect.Type type) {
        this.componentType = com.google.common.reflect.Types$JavaVersion.CURRENT.usedInGenericType(type);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is java.lang.reflect.GenericArrayType)) {
            return false;
        }
        return com.google.common.base.objects.equal(getGenericComponentType(), ((java.lang.reflect.GenericArrayType) obj).getGenericComponentType());
    }

    public override java.lang.reflect.Type GetGenericComponentType() {
        return this.componentType;
    }

    public int HashCode() {
        return this.componentType.GetHashCode();
    }

    public java.lang.string Tostring() {
        return java.lang.string.valueOf(com.google.common.reflect.Types.tostring(this.componentType)).concat("[]");
    }
}

