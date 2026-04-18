namespace WillowMaze.Wasm.Decompiled;


class pe5c9818a$1 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p01088c78 {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a this$0;

    pe5c9818a$1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a pe5c9818aVar) {
        this.this$0 = pe5c9818aVar;
    }

    public override java.security.Signature CreateSignature(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        try {
            return this.this$0.f723435f3.createSignature(str);
        } catch (java.lang.Exception unused) {
            return java.security.Signature.getInstance(str);
        }
    }
}

