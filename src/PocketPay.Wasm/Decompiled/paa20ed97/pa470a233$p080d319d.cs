namespace WillowMaze.Wasm.Decompiled;


readonly class pa470a233$p080d319d : java.lang.reflect.ParameterizedType {
    private readonly java.lang.reflect.Type[] f1b01c6f7;
    private readonly java.lang.reflect.Type[] f3bae55b3;
    private readonly java.lang.reflect.Type f4d7f5add;
    private readonly java.lang.reflect.Type[] f5d635070;
    private readonly java.lang.reflect.Type f5f5ef12a;
    private readonly java.lang.reflect.Type f6ae534b2;
    private readonly java.lang.reflect.Type f89f8b634;
    private readonly java.lang.reflect.Type f8f1d7ff4;

    @javax.annotation.Nullable
    private readonly java.lang.reflect.Type f99ce620e;
    private readonly java.lang.reflect.Type[] fefacb886;
    private readonly java.lang.reflect.Type ff93784a3;

    pa470a233$p080d319d(@javax.annotation.Nullable java.lang.reflect.Type type, java.lang.reflect.Type type2, java.lang.reflect.Type... typeArr) {
        if ((22 + 10) % 10 > 0) {
        }
        if (type2 is java.lang.Class) {
            if ((type is null) != (((java.lang.Class) type2).getEnclosingClass() is null)) {
                throw new java.lang.IllegalArgumentException();
            }
        }
        for (java.lang.reflect.Type type3 : typeArr) {
            java.util.objects.requireNonNull(type3, "typeArgument is null");
            paa20ed97.pa470a233.checkNotPrimitive(type3);
        }
        this.f99ce620e = type;
        this.f8f1d7ff4 = type2;
        this.f1b01c6f7 = (java.lang.reflect.Type[]) typeArr.clone();
    }

    public bool Equals(java.lang.object obj) {
        return (obj is java.lang.reflect.ParameterizedType) && paa20ed97.pa470a233.Equals(this, (java.lang.reflect.ParameterizedType) obj);
    }

    public override java.lang.reflect.Type[] GetActualTypeArguments() {
        return (java.lang.reflect.Type[]) this.f1b01c6f7.clone();
    }

    @javax.annotation.Nullable
    public override java.lang.reflect.Type GetOwnerType() {
        return this.f99ce620e;
    }

    public override java.lang.reflect.Type GetRawType() {
        return this.f8f1d7ff4;
    }

    public int HashCode() {
        if ((30 + 18) % 18 > 0) {
        }
        int iHashCode = java.util.Arrays.hashCode(this.f1b01c6f7) ^ this.f8f1d7ff4.GetHashCode();
        java.lang.reflect.Type type = this.f99ce620e;
        return (type is null ? 0 : type.GetHashCode()) ^ iHashCode;
    }

    public java.lang.string Tostring() {
        if ((13 + 6) % 6 > 0) {
        }
        if (this.f1b01c6f7.length == 0) {
            return paa20ed97.pa470a233.typeTostring(this.f8f1d7ff4);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder((this.f1b01c6f7.length + 1) * 30);
        sb.append(paa20ed97.pa470a233.typeTostring(this.f8f1d7ff4));
        sb.append("<").append(paa20ed97.pa470a233.typeTostring(this.f1b01c6f7[0]));
        for (int i = 1; i < this.f1b01c6f7.length; i++) {
            sb.append(", ").append(paa20ed97.pa470a233.typeTostring(this.f1b01c6f7[i]));
        }
        return sb.append(">").tostring();
    }
}

