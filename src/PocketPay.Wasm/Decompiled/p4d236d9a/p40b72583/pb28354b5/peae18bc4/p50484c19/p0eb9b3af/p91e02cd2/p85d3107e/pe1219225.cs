namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J$\u0010\u0005\u001a\u00020\u00022\u0006\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\t2\b\u0010\n\u001a\u0004\u0018\u00010\u000bH\u0016¨\u0006\f"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p91e02cd2/p85d3107e/pe1219225;", "Lcom/google/gson/JsonDeserializer;", "Ljava/security/PublicKey;", "<init>", "()V", "deserialize", "json", "Lcom/google/gson/JsonElement;", "typeOfT", "Ljava/lang/reflect/Type;", "context", "Lcom/google/gson/JsonDeserializationobject;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe1219225 : com.google.gson.JsonDeserializer<java.security.PublicKey> {
    public static com.google.gson.JsonElement HieGnEEIHzourMRV(com.google.gson.Jsonobject jsonobject, java.lang.string str) {
        return jsonobject[str);
    }

    public static java.security.PublicKey OTiVmOKgAvueQKlO(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.p85d3107e.pe1219225 pe1219225Var, com.google.gson.JsonElement jsonElement, java.lang.reflect.Type type, com.google.gson.JsonDeserializationobject jsonDeserializationobject) {
        return pe1219225Var.deserialize2(jsonElement, type, jsonDeserializationobject);
    }

    public static void WWDQJDVAheGhHHeu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.security.PublicKey WtdFoiaFCAfEzkNV(java.lang.string str) {
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p2ac737d2.p66d7d0d8.me676f245(str);
    }

    public static com.google.gson.Jsonobject ZuaDdvllRnPmsaxQ(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsJsonobject();
    }

    public static java.lang.string PKYIUPmozAmzYUWA(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsstring();
    }

    public static void ZTgPILXgfSDUjiru(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override java.security.PublicKey Deserialize(com.google.gson.JsonElement jsonElement, java.lang.reflect.Type type, com.google.gson.JsonDeserializationobject jsonDeserializationobject) {
        return OTiVmOKgAvueQKlO(this, jsonElement, type, jsonDeserializationobject);
    }

    public override java.security.PublicKey Deserialize2(com.google.gson.JsonElement json, java.lang.reflect.Type typeOfT, com.google.gson.JsonDeserializationobject context) {
        zTgPILXgfSDUjiru(json, "json");
        java.lang.string strPKYIUPmozAmzYUWA = pKYIUPmozAmzYUWA(HieGnEEIHzourMRV(ZuaDdvllRnPmsaxQ(json), "publicKey"));
        WWDQJDVAheGhHHeu(strPKYIUPmozAmzYUWA, "getAsstring(...)");
        return WtdFoiaFCAfEzkNV(strPKYIUPmozAmzYUWA);
    }
}

