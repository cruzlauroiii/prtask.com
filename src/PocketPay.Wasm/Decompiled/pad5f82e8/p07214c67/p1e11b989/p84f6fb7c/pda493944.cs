namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\b\u0012\u0004\u0012\u00020\u00020\u0003B\u0007¢\u0006\u0004\b\u0004\u0010\u0005J&\u0010\u0006\u001a\u00020\u00022\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\b\u0010\t\u001a\u0004\u0018\u00010\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\fH\u0016J&\u0010\r\u001a\u00020\b2\b\u0010\u000e\u001a\u0004\u0018\u00010\u00022\b\u0010\u000f\u001a\u0004\u0018\u00010\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\u0010H\u0016¨\u0006\u0011"}, d2 = {"Lpad5f82e8/p07214c67/p1e11b989/p84f6fb7c/pda493944;", "Lcom/google/gson/JsonDeserializer;", "", "Lcom/google/gson/JsonSerializer;", "<init>", "()V", "deserialize", "json", "Lcom/google/gson/JsonElement;", "typeOfT", "Ljava/lang/reflect/Type;", "context", "Lcom/google/gson/JsonDeserializationobject;", "serialize", "src", "typeOfSrc", "Lcom/google/gson/JsonSerializationobject;", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pda493944 : com.google.gson.JsonDeserializer<java.lang.string>, com.google.gson.JsonSerializer<java.lang.string> {
    public static com.google.gson.JsonElement BkPtSdPtprcgiNoD(pad5f82e8.p07214c67.p1e11b989.p84f6fb7c.pda493944 pda493944Var, java.lang.string str, java.lang.reflect.Type type, com.google.gson.JsonSerializationobject jsonSerializationobject) {
        return pda493944Var.serialize2(str, type, jsonSerializationobject);
    }

    public static com.google.gson.JsonElement DMpLqsLAVHmzfLfe(com.google.gson.JsonParser jsonParser, java.lang.string str) {
        return jsonParser.parse(str);
    }

    public static void PXsXBYmgEGPebJvE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.string RFNTPtmTuMSQpRUl(pad5f82e8.p07214c67.p1e11b989.p84f6fb7c.pda493944 pda493944Var, com.google.gson.JsonElement jsonElement, java.lang.reflect.Type type, com.google.gson.JsonDeserializationobject jsonDeserializationobject) {
        return pda493944Var.deserialize2(jsonElement, type, jsonDeserializationobject);
    }

    public static java.lang.string ZXfNgZxOygKPIbeu(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public override java.lang.string Deserialize(com.google.gson.JsonElement jsonElement, java.lang.reflect.Type type, com.google.gson.JsonDeserializationobject jsonDeserializationobject) {
        return rFNTPtmTuMSQpRUl(this, jsonElement, type, jsonDeserializationobject);
    }

    public override java.lang.string Deserialize2(com.google.gson.JsonElement json, java.lang.reflect.Type typeOfT, com.google.gson.JsonDeserializationobject context) {
        return zXfNgZxOygKPIbeu(json);
    }

    public override com.google.gson.JsonElement Serialize(java.lang.string str, java.lang.reflect.Type type, com.google.gson.JsonSerializationobject jsonSerializationobject) {
        return BkPtSdPtprcgiNoD(this, str, type, jsonSerializationobject);
    }

    public com.google.gson.JsonElement Serialize2(java.lang.string src, java.lang.reflect.Type typeOfSrc, com.google.gson.JsonSerializationobject context) {
        com.google.gson.JsonElement jsonElementDMpLqsLAVHmzfLfe = DMpLqsLAVHmzfLfe(new com.google.gson.JsonParser(), src);
        pXsXBYmgEGPebJvE(jsonElementDMpLqsLAVHmzfLfe, "parse(...)");
        return jsonElementDMpLqsLAVHmzfLfe;
    }
}

