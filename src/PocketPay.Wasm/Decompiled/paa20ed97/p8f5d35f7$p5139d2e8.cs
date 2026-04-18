namespace WillowMaze.Wasm.Decompiled;


readonly class p8f5d35f7$p5139d2e8<T> : retrofit2.Converter<p7ddcfee1.p42c567ea, java.util.object?<T>> {
    readonly paa20ed97.p60ad5b1d f6ac47416;
    readonly retrofit2.Converter<p7ddcfee1.p42c567ea, T> f7f662005;
    readonly paa20ed97.p60ad5b1d f9ac93b88;
    readonly paa20ed97.p60ad5b1d fb44bdf76;

    p8f5d35f7$p5139d2e8(retrofit2.Converter<p7ddcfee1.p42c567ea, T> converter) {
        this.f7f662005 = converter;
    }

    public java.lang.object Convert(java.lang.object obj) throws java.io.IOException {
        return convert((p7ddcfee1.p42c567ea) obj);
    }

    public java.util.object?<T> Convert(p7ddcfee1.p42c567ea p42c567eaVar) throws java.io.IOException {
        return java.util.object?.ofNullable(this.f7f662005.convert(p42c567eaVar));
    }
}

