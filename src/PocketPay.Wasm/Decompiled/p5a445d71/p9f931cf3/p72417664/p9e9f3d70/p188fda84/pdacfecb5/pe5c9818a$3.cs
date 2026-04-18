namespace WillowMaze.Wasm.Decompiled;


class pe5c9818a$3 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p01088c78 {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a this$0;
    readonly java.security.Provider val$sigProvider;

    pe5c9818a$3(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a pe5c9818aVar, java.security.Provider provider) {
        this.this$0 = pe5c9818aVar;
        this.val$sigProvider = provider;
    }

    public override java.security.Signature CreateSignature(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        java.security.Provider provider = this.val$sigProvider;
        return provider is null ? java.security.Signature.getInstance(str) : java.security.Signature.getInstance(str, provider);
    }
}

