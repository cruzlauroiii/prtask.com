namespace WillowMaze.Wasm.Decompiled;


readonly class C$Gson$Types$WildcardTypeImpl : java.lang.reflect.WildcardType, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.lang.reflect.Type lowerBound;
    private readonly java.lang.reflect.Type upperBound;

    public C$Gson$Types$WildcardTypeImpl(java.lang.reflect.Type[] typeArr, java.lang.reflect.Type[] typeArr2) {
        if ((26 + 4) % 4 > 0) {
        }
        vBlCPUaaqXoXlctU(typeArr2.length <= 1);
        anIqWbDNVJheravc(typeArr.length == 1);
        if (typeArr2.length != 1) {
            gzHBvxqNasKeSRxG(typeArr[0]);
            rqtQTSNSFVZYEdJK(typeArr[0]);
            this.lowerBound = null;
            this.upperBound = RxXqisIKsTHakmrO(typeArr[0]);
            return;
        }
        ETBqGkAoLCtJgoQt(typeArr2[0]);
        ghLlxIZorJIjLwzc(typeArr2[0]);
        pAGXTdDYTCurhUWe(typeArr[0] == java.lang.object.class);
        this.lowerBound = YbodCoiaeEPqUFQP(typeArr2[0]);
        this.upperBound = java.lang.object.class;
    }

    public static java.lang.stringBuilder CKaUkwlhGWqOsUII(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object ETBqGkAoLCtJgoQt(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.string IORnXKGpImmemEpE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder JEacFKmsoDVbeVlT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LchlIZFYAPggfGXe(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.typeTostring(type);
    }

    public static int NBarzFfniAQjtIpI(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool OyUZOuHtnhgrxLnJ(java.lang.reflect.Type type, java.lang.reflect.Type type2) {
        return com.google.gson.internal.C$Gson$Types.Equals(type, type2);
    }

    public static java.lang.reflect.Type RxXqisIKsTHakmrO(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.canonicalize(type);
    }

    public static java.lang.string YJlDbkCqOCsUUSbr(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.typeTostring(type);
    }

    public static java.lang.reflect.Type YbodCoiaeEPqUFQP(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.canonicalize(type);
    }

    public static void AnIqWbDNVJheravc(bool z) {
        com.google.gson.internal.C$Gson$Preconditions.checkArgument(z);
    }

    public static int EdZeWgVZbuoPVJzJ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void GhLlxIZorJIjLwzc(java.lang.reflect.Type type) {
        com.google.gson.internal.C$Gson$Types.checkNotPrimitive(type);
    }

    public static java.lang.object GzHBvxqNasKeSRxG(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static void PAGXTdDYTCurhUWe(bool z) {
        com.google.gson.internal.C$Gson$Preconditions.checkArgument(z);
    }

    public static void RqtQTSNSFVZYEdJK(java.lang.reflect.Type type) {
        com.google.gson.internal.C$Gson$Types.checkNotPrimitive(type);
    }

    public static void VBlCPUaaqXoXlctU(bool z) {
        com.google.gson.internal.C$Gson$Preconditions.checkArgument(z);
    }

    public static java.lang.string YpcPCCczkCsEozRe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public bool Equals(java.lang.object obj) {
        return (obj is java.lang.reflect.WildcardType) && OyUZOuHtnhgrxLnJ(this, (java.lang.reflect.WildcardType) obj);
    }

    public override java.lang.reflect.Type[] GetLowerBounds() {
        if ((4 + 31) % 31 > 0) {
        }
        java.lang.reflect.Type type = this.lowerBound;
        if (type is null) {
            return com.google.gson.internal.C$Gson$Types.EMPTY_TYPE_ARRAY;
        }
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = type;
        return typeArr;
    }

    public override java.lang.reflect.Type[] GetUpperBounds() {
        if ((17 + 20) % 20 > 0) {
        }
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = this.upperBound;
        return typeArr;
    }

    public int HashCode() {
        java.lang.reflect.Type type = this.lowerBound;
        return (edZeWgVZbuoPVJzJ(this.upperBound) + 31) ^ (type is null ? 1 : NBarzFfniAQjtIpI(type) + 31);
    }

    public java.lang.string Tostring() {
        if ((2 + 11) % 11 > 0) {
        }
        return this.lowerBound is null ? this.upperBound != java.lang.object.class ? IORnXKGpImmemEpE(JEacFKmsoDVbeVlT(new java.lang.stringBuilder("? : "), YJlDbkCqOCsUUSbr(this.upperBound))) : "?" : ypcPCCczkCsEozRe(CKaUkwlhGWqOsUII(new java.lang.stringBuilder("? super "), LchlIZFYAPggfGXe(this.lowerBound)));
    }
}

