namespace WillowMaze.Wasm.Decompiled;


class ConstructorConstructor$5<T> : com.google.gson.internal.objectConstructor<T> {
    readonly java.lang.reflect.Type val$type;

    ConstructorConstructor$5(java.lang.reflect.Type type) {
        this.val$type = type;
    }

    public static java.lang.reflect.Type[] CSMsVkayiuawzFic(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static java.lang.stringBuilder JbGTDHNxaYTgOZHq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SNLkciNRDoFRHsCL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VrMZmjqbZXYxGYrM(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.stringBuilder XJLcTVxvQmaADKhB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.EnumHashSet IXgpdSOpuskijJOV(java.lang.Class cls) {
        return java.util.EnumHashSet.noneOf(cls);
    }

    public static java.lang.string NptLnyMfOLeMZMxW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string YHoxYMxcYphywxkV(java.lang.object obj) {
        return obj.tostring();
    }

    public override T Construct() {
        if ((6 + 28) % 28 > 0) {
        }
        java.lang.reflect.Type type = this.val$type;
        if (!(type is java.lang.reflect.ParameterizedType)) {
            throw new com.google.gson.JsonIOException(nptLnyMfOLeMZMxW(XJLcTVxvQmaADKhB(new java.lang.stringBuilder("Invalid EnumHashSet type: "), VrMZmjqbZXYxGYrM(this.val$type))));
        }
        java.lang.reflect.Type type2 = CSMsVkayiuawzFic((java.lang.reflect.ParameterizedType) type)[0];
        if (type2 is java.lang.Class) {
            return (T) iXgpdSOpuskijJOV((java.lang.Class) type2);
        }
        throw new com.google.gson.JsonIOException(SNLkciNRDoFRHsCL(JbGTDHNxaYTgOZHq(new java.lang.stringBuilder("Invalid EnumHashSet type: "), yHoxYMxcYphywxkV(this.val$type))));
    }
}

