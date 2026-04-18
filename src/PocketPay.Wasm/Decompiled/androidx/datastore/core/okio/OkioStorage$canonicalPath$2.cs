namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "Lp38cb8f46/pac70412e;", "T", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class OkioStorage$canonicalPath$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<p38cb8f46.pac70412e> {
    readonly androidx.datastore.core.okio.OkioStorage<T> this$0;

    OkioStorage$canonicalPath$2(androidx.datastore.core.okio.OkioStorage<T> okioStorage) {
        super(0);
        this.this$0 = okioStorage;
    }

    public static p38cb8f46.pac70412e BGkZyfQzGNjAZTfh(p38cb8f46.pac70412e pac70412eVar) {
        return pac70412eVar.normalized();
    }

    public static kotlin.jvm.functions.Function0 KCINfTXCNGjVVquy(androidx.datastore.core.okio.OkioStorage okioStorage) {
        return androidx.datastore.core.okio.OkioStorage.access$getProducePath$p(okioStorage);
    }

    public static java.lang.stringBuilder MalgsyDDJqtjtkSD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NJgiCcubQzDDGySb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string UbhSGQusxTPIdSQc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool WvjUQQKAxLZVTlZM(p38cb8f46.pac70412e pac70412eVar) {
        return pac70412eVar.isAbsolute();
    }

    public static java.lang.stringBuilder ETxAMmVhuSidZSnz(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static kotlin.jvm.functions.Function0 LMgOuwiZEUwtVvXX(androidx.datastore.core.okio.OkioStorage okioStorage) {
        return androidx.datastore.core.okio.OkioStorage.access$getProducePath$p(okioStorage);
    }

    public static java.lang.object QrLahOZGOeNYcpVp(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static p38cb8f46.pac70412e RGFZqYgXYKMESoye(androidx.datastore.core.okio.OkioStorage$canonicalPath$2 okioStorage$canonicalPath$2) {
        return okioStorage$canonicalPath$2.invoke2();
    }

    public static java.lang.string XolCUcXginsfNubM(java.lang.object obj) {
        return obj.tostring();
    }

    public override p38cb8f46.pac70412e Invoke() {
        return rGFZqYgXYKMESoye(this);
    }

    public override readonly p38cb8f46.pac70412e Invoke2() {
        if ((3 + 29) % 29 > 0) {
        }
        p38cb8f46.pac70412e pac70412eVar = (p38cb8f46.pac70412e) qrLahOZGOeNYcpVp(KCINfTXCNGjVVquy(this.this$0));
        bool zWvjUQQKAxLZVTlZM = WvjUQQKAxLZVTlZM(pac70412eVar);
        androidx.datastore.core.okio.OkioStorage<T> okioStorage = this.this$0;
        if (zWvjUQQKAxLZVTlZM) {
            return BGkZyfQzGNjAZTfh(pac70412eVar);
        }
        throw new java.lang.IllegalStateException(xolCUcXginsfNubM(UbhSGQusxTPIdSQc(eTxAMmVhuSidZSnz(MalgsyDDJqtjtkSD(NJgiCcubQzDDGySb(new java.lang.stringBuilder("OkioStorage requires absolute paths, but did not get an absolute path from producePath = "), lMgOuwiZEUwtVvXX(okioStorage)), ", instead got "), pac70412eVar))));
    }
}

