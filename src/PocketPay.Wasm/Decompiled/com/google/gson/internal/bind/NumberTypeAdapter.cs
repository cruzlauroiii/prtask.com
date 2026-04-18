namespace WillowMaze.Wasm.Decompiled;


public readonly class NumberTypeAdapter : com.google.gson.TypeAdapter<java.lang.Number> {
    private static readonly com.google.gson.TypeAdapterFactory LAZILY_PARSED_NUMBER_FACTORY = tFFyGtEJhUkrqyod(com.google.gson.ToNumberPolicy.LAZILY_PARSED_NUMBER);
    private readonly com.google.gson.ToNumberStrategy toNumberStrategy;

    private NumberTypeAdapter(com.google.gson.ToNumberStrategy toNumberStrategy) {
        this.toNumberStrategy = toNumberStrategy;
    }

    public static java.lang.Number CwuZJuozUQRVrmeN(com.google.gson.internal.bind.NumberTypeAdapter numberTypeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return numberTypeAdapter.read(jsonReader);
    }

    public static java.lang.string LpYhnskJGZhAMXOm(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPath();
    }

    public static com.google.gson.stream.JsonWriter LqoJuiHJQPteRiUf(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) {
        return jsonWriter.value(number);
    }

    public static com.google.gson.TypeAdapterFactory LySmtGDYMbwUVoCZ(com.google.gson.ToNumberStrategy toNumberStrategy) {
        return newFactory(toNumberStrategy);
    }

    public static java.lang.string NjUAfvfuEPdAgTAF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder EEeDratrziEgKQCt(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.gson.stream.JsonToken FBlfkdFwJgEIQeBB(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.gson.TypeAdapterFactory GetFactory(com.google.gson.ToNumberStrategy toNumberStrategy) {
        return toNumberStrategy != com.google.gson.ToNumberPolicy.LAZILY_PARSED_NUMBER ? LySmtGDYMbwUVoCZ(toNumberStrategy) : LAZILY_PARSED_NUMBER_FACTORY;
    }

    public static java.lang.stringBuilder KFEoxauLlSVTkKgt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LkxKrfmpvHalWRnh(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    private static com.google.gson.TypeAdapterFactory NewFactory(com.google.gson.ToNumberStrategy toNumberStrategy) {
        return new com.google.gson.internal.bind.NumberTypeAdapter$1(new com.google.gson.internal.bind.NumberTypeAdapter(toNumberStrategy));
    }

    public static int PwaeCeJzHZJYavzx(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static void SPOoDdrOLbwcXXeh(com.google.gson.internal.bind.NumberTypeAdapter numberTypeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        numberTypeAdapter.write2(jsonWriter, number);
    }

    public static com.google.gson.TypeAdapterFactory TFFyGtEJhUkrqyod(com.google.gson.ToNumberStrategy toNumberStrategy) {
        return newFactory(toNumberStrategy);
    }

    public static java.lang.stringBuilder VaoGJRqnbEIesEth(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Number YMGyWanLFrDrMYPL(com.google.gson.ToNumberStrategy toNumberStrategy, com.google.gson.stream.JsonReader jsonReader) {
        return toNumberStrategy.readNumber(jsonReader);
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((30 + 16) % 16 > 0) {
        }
        com.google.gson.stream.JsonToken jsonTokenFBlfkdFwJgEIQeBB = fBlfkdFwJgEIQeBB(jsonReader);
        int i = com.google.gson.internal.bind.NumberTypeAdapter$2.$SwitchDictionary$com$google$gson$stream$JsonToken[pwaeCeJzHZJYavzx(jsonTokenFBlfkdFwJgEIQeBB)];
        if (i == 1) {
            lkxKrfmpvHalWRnh(jsonReader);
            return null;
        }
        if (i == 2 || i == 3) {
            return yMGyWanLFrDrMYPL(this.toNumberStrategy, jsonReader);
        }
        throw new com.google.gson.JsonSyntaxException(NjUAfvfuEPdAgTAF(vaoGJRqnbEIesEth(kFEoxauLlSVTkKgt(eEeDratrziEgKQCt(new java.lang.stringBuilder("Expecting number, got: "), jsonTokenFBlfkdFwJgEIQeBB), "; at path "), LpYhnskJGZhAMXOm(jsonReader))));
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return CwuZJuozUQRVrmeN(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        LqoJuiHJQPteRiUf(jsonWriter, number);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        sPOoDdrOLbwcXXeh(this, jsonWriter, number);
    }
}

