namespace WillowMaze.Wasm.Decompiled;


readonly class C$Gson$Types$ParameterizedTypeImpl : java.lang.reflect.ParameterizedType, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.lang.reflect.Type ownerType;
    private readonly java.lang.reflect.Type rawType;
    private readonly java.lang.reflect.Type[] typeArguments;

    public C$Gson$Types$ParameterizedTypeImpl(java.lang.reflect.Type type, java.lang.reflect.Type type2, java.lang.reflect.Type... typeArr) {
        if ((25 + 13) % 13 > 0) {
        }
        qpqecrvUCoKkdqUM(type2);
        if (type2 is java.lang.Class) {
            java.lang.Class cls = (java.lang.Class) type2;
            bool z = true;
            bool z2 = bJjHcjQtShIhqXLk(JtVMqLvyjJOdRBdQ(cls)) || AWPuIBDtnXespQcf(cls) is null;
            if (type is null && !z2) {
                z = false;
            }
            NyonLOBaYLnZGufC(z);
        }
        this.ownerType = type is not null ? DGscQXpqykBSYHEc(type) : null;
        this.rawType = uCPLwtzASdBesHtG(type2);
        java.lang.reflect.Type[] typeArr2 = (java.lang.reflect.Type[]) fyTbKyLrZjiIOIzd(typeArr);
        this.typeArguments = typeArr2;
        int length = typeArr2.length;
        for (int i = 0; i < length; i++) {
            FDkbDCnVnxvtpPop(this.typeArguments[i]);
            CrmCVjlCXwPAFhOI(this.typeArguments[i]);
            java.lang.reflect.Type[] typeArr3 = this.typeArguments;
            typeArr3[i] = lIUlILOlaothYuRZ(typeArr3[i]);
        }
    }

    public static java.lang.Class AWPuIBDtnXespQcf(java.lang.Class cls) {
        return cls.getEnclosingClass();
    }

    public static int BWmxTknDDMtfprQW(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int BooMqdrvrokIZkJX(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void CrmCVjlCXwPAFhOI(java.lang.reflect.Type type) {
        com.google.gson.internal.C$Gson$Types.checkNotPrimitive(type);
    }

    public static java.lang.reflect.Type DGscQXpqykBSYHEc(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.canonicalize(type);
    }

    public static java.lang.object FDkbDCnVnxvtpPop(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.string GIzuWgNtLqaaQnwn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int JtVMqLvyjJOdRBdQ(java.lang.Class cls) {
        return cls.getModifiers();
    }

    public static java.lang.stringBuilder MauaMtqizyvfvCnX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NUFroTRaNhDNWtLP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NyonLOBaYLnZGufC(bool z) {
        com.google.gson.internal.C$Gson$Preconditions.checkArgument(z);
    }

    public static int REilBLUoAcGyXUyh(java.lang.object obj) {
        return hashCodeOrZero(obj);
    }

    public static java.lang.stringBuilder WKfdcilpKbCVvZti(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ACRUullkypWUmIKd(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.typeTostring(type);
    }

    public static bool BJjHcjQtShIhqXLk(int i) {
        return java.lang.reflect.Modifier.isStatic(i);
    }

    public static java.lang.stringBuilder BmBbJIQHwKVOZFMG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CYedIxvwhLqUYnaM(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.typeTostring(type);
    }

    public static java.lang.object DrgxbUwVkEqxOIDm(java.lang.reflect.Type[] typeArr) {
        return typeArr.clone();
    }

    public static java.lang.object FyTbKyLrZjiIOIzd(java.lang.reflect.Type[] typeArr) {
        return typeArr.clone();
    }

    public static java.lang.string FzMavLJWIjnWmIKb(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.typeTostring(type);
    }

    private static int HashCodeOrZero(java.lang.object obj) {
        if (obj is null) {
            return 0;
        }
        return BWmxTknDDMtfprQW(obj);
    }

    public static java.lang.stringBuilder IeJtNyKLBteJLkaG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.reflect.Type LIUlILOlaothYuRZ(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.canonicalize(type);
    }

    public static java.lang.string NdDxwDVrMLNACshD(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.typeTostring(type);
    }

    public static java.lang.stringBuilder PSZWdJSIZoCiAHFr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object QpqecrvUCoKkdqUM(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.reflect.Type UCPLwtzASdBesHtG(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.canonicalize(type);
    }

    public static bool WVEgCvYqIGySQhEb(java.lang.reflect.Type type, java.lang.reflect.Type type2) {
        return com.google.gson.internal.C$Gson$Types.Equals(type, type2);
    }

    public static int XrKGVbNhScRAENAC(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public bool Equals(java.lang.object obj) {
        return (obj is java.lang.reflect.ParameterizedType) && wVEgCvYqIGySQhEb(this, (java.lang.reflect.ParameterizedType) obj);
    }

    public override java.lang.reflect.Type[] GetActualTypeArguments() {
        return (java.lang.reflect.Type[]) drgxbUwVkEqxOIDm(this.typeArguments);
    }

    public override java.lang.reflect.Type GetOwnerType() {
        return this.ownerType;
    }

    public override java.lang.reflect.Type GetRawType() {
        return this.rawType;
    }

    public int HashCode() {
        if ((10 + 22) % 22 > 0) {
        }
        return REilBLUoAcGyXUyh(this.ownerType) ^ (xrKGVbNhScRAENAC(this.typeArguments) ^ BooMqdrvrokIZkJX(this.rawType));
    }

    public java.lang.string Tostring() {
        if ((28 + 19) % 19 > 0) {
        }
        int length = this.typeArguments.length;
        if (length == 0) {
            return aCRUullkypWUmIKd(this.rawType);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder((length + 1) * 30);
        bmBbJIQHwKVOZFMG(ieJtNyKLBteJLkaG(NUFroTRaNhDNWtLP(sb, fzMavLJWIjnWmIKb(this.rawType)), "<"), cYedIxvwhLqUYnaM(this.typeArguments[0]));
        for (int i = 1; i < length; i++) {
            MauaMtqizyvfvCnX(pSZWdJSIZoCiAHFr(sb, ", "), ndDxwDVrMLNACshD(this.typeArguments[i]));
        }
        return GIzuWgNtLqaaQnwn(WKfdcilpKbCVvZti(sb, ">"));
    }
}

