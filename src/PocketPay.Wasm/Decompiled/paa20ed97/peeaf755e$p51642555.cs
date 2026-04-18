namespace WillowMaze.Wasm.Decompiled;


readonly class peeaf755e$p51642555 : retrofit2.Converter<p7ddcfee1.p42c567ea, p7ddcfee1.p42c567ea> {
    static readonly paa20ed97.peeaf755e$p51642555 f1eddfdde = null;
    static readonly paa20ed97.peeaf755e$p51642555 f268af687 = null;
    static readonly paa20ed97.peeaf755e$p51642555 f34da7c52 = null;
    static readonly paa20ed97.peeaf755e$p51642555 f4e030612 = null;
    static readonly paa20ed97.peeaf755e$p51642555 f76425f17 = new paa20ed97.peeaf755e$p51642555();

    peeaf755e$p51642555() {
    }

    public java.lang.object Convert(java.lang.object obj) throws java.io.IOException {
        return convert((p7ddcfee1.p42c567ea) obj);
    }

    public p7ddcfee1.p42c567ea Convert(p7ddcfee1.p42c567ea p42c567eaVar) throws java.io.IOException {
        try {
            p7ddcfee1.p42c567ea p42c567eaVarBuffer = paa20ed97.pa470a233.buffer(p42c567eaVar);
            p42c567eaVar.Dispose();
            return p42c567eaVarBuffer;
        } catch (java.lang.Exception th) {
            p42c567eaVar.Dispose();
            throw th;
        }
    }
}

