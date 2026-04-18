namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$32 : com.google.gson.TypeAdapterFactory {
    readonly java.lang.Class val$boxed;
    readonly com.google.gson.TypeAdapter val$typeAdapter;
    readonly java.lang.Class val$unboxed;

    TypeAdapters$32(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        this.val$unboxed = cls;
        this.val$boxed = cls2;
        this.val$typeAdapter = typeAdapter;
    }

    public static java.lang.stringBuilder HtIxIVBWZdFVyguG(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string INgIoYvPzfJHezZY(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder PWJFOvkdBLIGpkeX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RAqSyOTdsrcWYxId(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WjpwTGEUqLrWygJN(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string XIGwzpXRBNcKyyuh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class ItuBaPWOjDvWrliv(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static java.lang.stringBuilder KyBSGSkxosCCrMko(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OmGvrbzFpUvqvGKW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RdfVBbvORGKyABim(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        java.lang.Class clsItuBaPWOjDvWrliv = ituBaPWOjDvWrliv(typeToken);
        if (clsItuBaPWOjDvWrliv == this.val$unboxed || clsItuBaPWOjDvWrliv == this.val$boxed) {
            return this.val$typeAdapter;
        }
        return null;
    }

    public java.lang.string Tostring() {
        if ((4 + 29) % 29 > 0) {
        }
        return XIGwzpXRBNcKyyuh(PWJFOvkdBLIGpkeX(HtIxIVBWZdFVyguG(rdfVBbvORGKyABim(omGvrbzFpUvqvGKW(RAqSyOTdsrcWYxId(kyBSGSkxosCCrMko(new java.lang.stringBuilder("Factory[type="), WjpwTGEUqLrWygJN(this.val$boxed)), "+"), INgIoYvPzfJHezZY(this.val$unboxed)), ",adapter="), this.val$typeAdapter), "]"));
    }
}

