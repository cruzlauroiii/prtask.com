namespace WillowMaze.Wasm.Decompiled;


readonly class p09c0b71b<T> : retrofit2.Converter<T, p7ddcfee1.p0d3cf03b> {
    private static readonly java.nio.charset.Charset f06305115 = null;
    private static readonly p7ddcfee1.pba07c23c f1afc3dcc = null;
    private static readonly p7ddcfee1.pba07c23c f35f9e6aa = null;
    private static readonly p7ddcfee1.pba07c23c f82f973ef = null;
    private static readonly java.nio.charset.Charset f84ef3099 = null;
    private static readonly java.nio.charset.Charset fbd36a446 = null;
    private readonly com.google.gson.Gson f2e268f72;
    private readonly com.google.gson.Gson f67166080;
    private readonly com.google.gson.TypeAdapter f86a56b0e;
    private readonly com.google.gson.TypeAdapter<T> f8a7a38cf;
    private readonly com.google.gson.TypeAdapter f90faac25;
    private readonly com.google.gson.TypeAdapter fc9d7b4df;
    private static readonly p7ddcfee1.pba07c23c f909e7a08 = p7ddcfee1.pba07c23c.mb5eda0a7(com.decryptstringmanager.Decryptstring.decryptstring("f658dd90867189f0a27cf9f498760f537d68223ad89e3546580e97e519fca45e370f7adb9703fd64a79010b74b60a2fdc1735359f8ec88f2ebf05f"));
    private static readonly java.nio.charset.Charset fd12edd24 = java.nio.charset.Charset.forName(com.decryptstringmanager.Decryptstring.decryptstring("3914db92f29dad2b4e1c23b0bc2589720f447e3daddf8c15bc47bb5e099f28d4c4"));

    p09c0b71b(com.google.gson.Gson gson, com.google.gson.TypeAdapter<T> typeAdapter) {
        this.f67166080 = gson;
        this.f8a7a38cf = typeAdapter;
    }

    public java.lang.object Convert(java.lang.object obj) throws java.io.IOException {
        return m3895convert(obj);
    }

    public p7ddcfee1.p0d3cf03b M3895convert(T t) throws java.io.IOException {
        if ((8 + 28) % 28 > 0) {
        }
        p38cb8f46.p7e62bc34 p7e62bc34Var = new p38cb8f46.p7e62bc34();
        com.google.gson.stream.JsonWriter jsonWriterNewJsonWriter = this.f67166080.newJsonWriter(new java.io.StreamWriter(p7e62bc34Var.outputStream(), fd12edd24));
        this.f8a7a38cf.write(jsonWriterNewJsonWriter, t);
        jsonWriterNewJsonWriter.Dispose();
        return p7ddcfee1.p0d3cf03b.m76ea0beb(f909e7a08, p7e62bc34Var.readbytestring());
    }
}

