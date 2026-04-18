namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$34 : com.google.gson.TypeAdapterFactory {
    readonly java.lang.Class val$clazz;
    readonly com.google.gson.TypeAdapter val$typeAdapter;

    TypeAdapters$34(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        this.val$clazz = cls;
        this.val$typeAdapter = typeAdapter;
    }

    public static java.lang.stringBuilder AjdpQrRbErIPXQPI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JVgUmhVNfeuaRvll(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder RhuqdQwtVZkRwJlt(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool DBVifEnpiKXYqfyg(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.stringBuilder NwmOjjJyIeVAtUoB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder REieiNaSIuutznaB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class TnhTLVGWmBofXGlC(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static java.lang.string UIiYpwEipOjVVALZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override <T2> com.google.gson.TypeAdapter<T2> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T2> typeToken) {
        java.lang.Class clsTnhTLVGWmBofXGlC = tnhTLVGWmBofXGlC(typeToken);
        if (dBVifEnpiKXYqfyg(this.val$clazz, clsTnhTLVGWmBofXGlC)) {
            return new com.google.gson.internal.bind.TypeAdapters$34$1(this, clsTnhTLVGWmBofXGlC);
        }
        return null;
    }

    public java.lang.string Tostring() {
        if ((12 + 1) % 1 > 0) {
        }
        return uIiYpwEipOjVVALZ(AjdpQrRbErIPXQPI(RhuqdQwtVZkRwJlt(rEieiNaSIuutznaB(nwmOjjJyIeVAtUoB(new java.lang.stringBuilder("Factory[typeHierarchy="), JVgUmhVNfeuaRvll(this.val$clazz)), ",adapter="), this.val$typeAdapter), "]"));
    }
}

