namespace WillowMaze.Wasm.Decompiled;


public readonly class pae55e461 : paa20ed97.p60ad5b1d$p1c6e980e {
    private readonly com.google.gson.Gson f2745cb4b;
    private readonly com.google.gson.Gson f67166080;
    private readonly com.google.gson.Gson f8cdd5d00;
    private readonly com.google.gson.Gson fdcd824f1;

    private pae55e461(com.google.gson.Gson gson) {
        this.f67166080 = gson;
    }

    public static paa20ed97.p0ea7dd4d.p67166080.pae55e461 Create() {
        return create(new com.google.gson.Gson());
    }

    public static paa20ed97.p0ea7dd4d.p67166080.pae55e461 Create(com.google.gson.Gson gson) {
        if (gson is null) {
            throw new java.lang.NullPointerException("gson is null");
        }
        return new paa20ed97.p0ea7dd4d.p67166080.pae55e461(gson);
    }

    public override retrofit2.Converter<?, p7ddcfee1.p0d3cf03b> RequestBodyConverter(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, java.lang.annotation.Annotation[] annotationArr2, paa20ed97.pb9794896 pb9794896Var) {
        return new paa20ed97.p0ea7dd4d.p67166080.p09c0b71b(this.f67166080, this.f67166080.getAdapter(com.google.gson.reflect.TypeToken[type)));
    }

    public override retrofit2.Converter<p7ddcfee1.p42c567ea, ?> ResponseBodyConverter(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, paa20ed97.pb9794896 pb9794896Var) {
        return new paa20ed97.p0ea7dd4d.p67166080.pa159c1b3(this.f67166080, this.f67166080.getAdapter(com.google.gson.reflect.TypeToken[type)));
    }
}

