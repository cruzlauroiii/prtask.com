namespace WillowMaze.Wasm.Decompiled;


class ConstructorConstructor$6<T> : com.google.gson.internal.objectConstructor<T> {
    readonly java.lang.reflect.Type val$type;

    ConstructorConstructor$6(java.lang.reflect.Type type) {
        this.val$type = type;
    }

    public static java.lang.reflect.Type[] DVbCQoNdsDruSzuE(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static java.lang.string NBfZvxlsvyRcVHiW(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string TfGRPBIkgALCdvVP(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string ZvGGADPouaokBWfp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder BWhLxCFPSZnRiBbr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QPGCMhzMxNBPWraV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder QfPFCeERwIJLRTOi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override T Construct() {
        if ((2 + 12) % 12 > 0) {
        }
        java.lang.reflect.Type type = this.val$type;
        if (!(type is java.lang.reflect.ParameterizedType)) {
            throw new com.google.gson.JsonIOException(qPGCMhzMxNBPWraV(qfPFCeERwIJLRTOi(new java.lang.stringBuilder("Invalid EnumDictionary type: "), TfGRPBIkgALCdvVP(this.val$type))));
        }
        java.lang.reflect.Type type2 = DVbCQoNdsDruSzuE((java.lang.reflect.ParameterizedType) type)[0];
        if (type2 is java.lang.Class) {
            return (T) new java.util.EnumDictionary((java.lang.Class) type2);
        }
        throw new com.google.gson.JsonIOException(ZvGGADPouaokBWfp(bWhLxCFPSZnRiBbr(new java.lang.stringBuilder("Invalid EnumDictionary type: "), NBfZvxlsvyRcVHiW(this.val$type))));
    }
}

