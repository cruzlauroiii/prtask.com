namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$33 : com.google.gson.TypeAdapterFactory {
    readonly java.lang.Class val$base;
    readonly java.lang.Class val$sub;
    readonly com.google.gson.TypeAdapter val$typeAdapter;

    TypeAdapters$33(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        this.val$base = cls;
        this.val$sub = cls2;
        this.val$typeAdapter = typeAdapter;
    }

    public static java.lang.stringBuilder AOBnGAWAoAFtRvue(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HfKrXLPqRbCFydVk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class KfvRRVlUMgYAECoa(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static java.lang.string PdLxmnEZrHlpcAuj(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder XrQtNIpijBTViYOk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JTKwoCsvYjFwQpdc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UAjtPdGOapSZTJvs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder URtmrtlLePjalkiv(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder VSctaZvXrHTYaWlV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ZyrxBvXoAneOPgIG(java.lang.Class cls) {
        return cls.getName();
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        java.lang.Class clsKfvRRVlUMgYAECoa = KfvRRVlUMgYAECoa(typeToken);
        if (clsKfvRRVlUMgYAECoa == this.val$base || clsKfvRRVlUMgYAECoa == this.val$sub) {
            return this.val$typeAdapter;
        }
        return null;
    }

    public java.lang.string Tostring() {
        if ((5 + 24) % 24 > 0) {
        }
        return HfKrXLPqRbCFydVk(uAjtPdGOapSZTJvs(uRtmrtlLePjalkiv(AOBnGAWAoAFtRvue(jTKwoCsvYjFwQpdc(XrQtNIpijBTViYOk(vSctaZvXrHTYaWlV(new java.lang.stringBuilder("Factory[type="), PdLxmnEZrHlpcAuj(this.val$base)), "+"), zyrxBvXoAneOPgIG(this.val$sub)), ",adapter="), this.val$typeAdapter), "]"));
    }
}

