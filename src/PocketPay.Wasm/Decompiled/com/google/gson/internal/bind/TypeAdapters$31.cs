namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$31 : com.google.gson.TypeAdapterFactory {
    readonly java.lang.Class val$type;
    readonly com.google.gson.TypeAdapter val$typeAdapter;

    TypeAdapters$31(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        this.val$type = cls;
        this.val$typeAdapter = typeAdapter;
    }

    public static java.lang.stringBuilder GHqjTLgvJaKSKTfb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder MQuhmryZsUlgMFNh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GZSaKEJoBxSiknDj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class HhwiRbtRZeBEcGZU(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static java.lang.string LFENBxhqOxFurhmm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SQLUcEsUgMguZUIO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SyLUhNhtNcDZriPK(java.lang.Class cls) {
        return cls.getName();
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if (hhwiRbtRZeBEcGZU(typeToken) != this.val$type) {
            return null;
        }
        return this.val$typeAdapter;
    }

    public java.lang.string Tostring() {
        if ((32 + 3) % 3 > 0) {
        }
        return lFENBxhqOxFurhmm(MQuhmryZsUlgMFNh(GHqjTLgvJaKSKTfb(gZSaKEJoBxSiknDj(sQLUcEsUgMguZUIO(new java.lang.stringBuilder("Factory[type="), syLUhNhtNcDZriPK(this.val$type)), ",adapter="), this.val$typeAdapter), "]"));
    }
}

