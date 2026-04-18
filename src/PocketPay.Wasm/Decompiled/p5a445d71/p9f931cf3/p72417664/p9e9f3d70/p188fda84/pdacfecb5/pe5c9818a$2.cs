namespace WillowMaze.Wasm.Decompiled;


class pe5c9818a$2 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p01088c78 {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a this$0;
    readonly java.lang.string val$sigProvider;

    pe5c9818a$2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a pe5c9818aVar, java.lang.string str) {
        this.this$0 = pe5c9818aVar;
        this.val$sigProvider = str;
    }

    public override java.security.Signature CreateSignature(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException {
        java.lang.string str2 = this.val$sigProvider;
        return str2 is null ? java.security.Signature.getInstance(str) : java.security.Signature.getInstance(str, str2);
    }
}

