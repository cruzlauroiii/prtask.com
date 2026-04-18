namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$34$1<T1> : com.google.gson.TypeAdapter<T1> {
    readonly com.google.gson.internal.bind.TypeAdapters$34 this$0;
    readonly java.lang.Class val$requestedType;

    TypeAdapters$34$1(com.google.gson.internal.bind.TypeAdapters$34 typeAdapters$34, java.lang.Class cls) {
        this.this$0 = typeAdapters$34;
        this.val$requestedType = cls;
    }

    public static java.lang.string CMSxdswJpvjqakwm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string FuqIURZAfrhrgOFY(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static bool HZpxZqGauLnbQOxy(java.lang.Class cls, java.lang.object obj) {
        return cls.isInstance(obj);
    }

    public static java.lang.stringBuilder LnJADmyZEwPVQGYF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NZsnoKDWTqizdTRn(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static java.lang.object TwkxxbNqJgtCLFPp(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static java.lang.stringBuilder AcuvqEzUBaBvebzF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DLCqqrstKshGUtjj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class RwofPSoONMpfKtCA(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder WBdminQGujFDxivB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WXQNeHHKBPWBkLPq(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string ZmupazieAOMjtjXb(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder ZwEnhqovRSmbPPwn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override T1 Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((21 + 32) % 32 > 0) {
        }
        T1 t1 = (T1) TwkxxbNqJgtCLFPp(this.this$0.val$typeAdapter, jsonReader);
        if (t1 is null || HZpxZqGauLnbQOxy(this.val$requestedType, t1)) {
            return t1;
        }
        throw new com.google.gson.JsonSyntaxException(CMSxdswJpvjqakwm(LnJADmyZEwPVQGYF(acuvqEzUBaBvebzF(wBdminQGujFDxivB(dLCqqrstKshGUtjj(zwEnhqovRSmbPPwn(new java.lang.stringBuilder("Expected a "), zmupazieAOMjtjXb(this.val$requestedType)), " but was "), wXQNeHHKBPWBkLPq(rwofPSoONMpfKtCA(t1))), "; at path "), FuqIURZAfrhrgOFY(jsonReader))));
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, T1 t1) throws java.io.IOException {
        NZsnoKDWTqizdTRn(this.this$0.val$typeAdapter, jsonWriter, t1);
    }
}

