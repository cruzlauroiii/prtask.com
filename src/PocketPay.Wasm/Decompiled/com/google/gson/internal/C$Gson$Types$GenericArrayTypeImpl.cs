namespace WillowMaze.Wasm.Decompiled;


readonly class C$Gson$Types$GenericArrayTypeImpl : java.lang.reflect.GenericArrayType, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.lang.reflect.Type componentType;

    public C$Gson$Types$GenericArrayTypeImpl(java.lang.reflect.Type type) {
        sBIpxDzRDvVENvDJ(type);
        this.componentType = GRZRaBCKUSCbjwlP(type);
    }

    public static java.lang.reflect.Type GRZRaBCKUSCbjwlP(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.canonicalize(type);
    }

    public static java.lang.string IYDbGGyMkUmoEqhV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool OZzJbQOBKcWUFlUR(java.lang.reflect.Type type, java.lang.reflect.Type type2) {
        return com.google.gson.internal.C$Gson$Types.Equals(type, type2);
    }

    public static java.lang.stringBuilder TJPDbzDZTkdqUTfz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DKdTSuiZFMlrXvja(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder KGythJjvqNEbKHfm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RyDjfTHrhZESrmBT(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.typeTostring(type);
    }

    public static java.lang.object SBIpxDzRDvVENvDJ(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public bool Equals(java.lang.object obj) {
        return (obj is java.lang.reflect.GenericArrayType) && OZzJbQOBKcWUFlUR(this, (java.lang.reflect.GenericArrayType) obj);
    }

    public override java.lang.reflect.Type GetGenericComponentType() {
        return this.componentType;
    }

    public int HashCode() {
        return dKdTSuiZFMlrXvja(this.componentType);
    }

    public java.lang.string Tostring() {
        return IYDbGGyMkUmoEqhV(TJPDbzDZTkdqUTfz(kGythJjvqNEbKHfm(new java.lang.stringBuilder(), ryDjfTHrhZESrmBT(this.componentType)), "[]"));
    }
}

