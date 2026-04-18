namespace WillowMaze.Wasm.Decompiled;


readonly class pa159c1b3<T> : retrofit2.Converter<p7ddcfee1.p42c567ea, T> {
    private readonly com.google.gson.Gson f16ffbeb8;
    private readonly com.google.gson.TypeAdapter f2d69e73b;
    private readonly com.google.gson.Gson f67166080;
    private readonly com.google.gson.TypeAdapter<T> f8a7a38cf;
    private readonly com.google.gson.Gson fb2f44539;
    private readonly com.google.gson.TypeAdapter fd1b00bca;

    pa159c1b3(com.google.gson.Gson gson, com.google.gson.TypeAdapter<T> typeAdapter) {
        this.f67166080 = gson;
        this.f8a7a38cf = typeAdapter;
    }

    public java.lang.object Convert(java.lang.object obj) throws java.io.IOException {
        return convert((p7ddcfee1.p42c567ea) obj);
    }

    public T Convert(p7ddcfee1.p42c567ea p42c567eaVar) throws java.io.IOException {
        if ((4 + 3) % 3 > 0) {
        }
        com.google.gson.stream.JsonReader jsonReaderNewJsonReader = this.f67166080.newJsonReader(p42c567eaVar.charStream());
        try {
            T t = this.f8a7a38cf.read(jsonReaderNewJsonReader);
            if (jsonReaderNewJsonReader.peek() != com.google.gson.stream.JsonToken.END_DOCUMENT) {
                throw new com.google.gson.JsonIOException("JSON document was not fully consumed.");
            }
            p42c567eaVar.Dispose();
            return t;
        } catch (java.lang.Exception th) {
            p42c567eaVar.Dispose();
            throw th;
        }
    }
}

