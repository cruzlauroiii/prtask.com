namespace WillowMaze.Wasm.Decompiled;


class p0b7b2d36$1 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p01088c78 {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36 this$0;

    p0b7b2d36$1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36 p0b7b2d36Var) {
        this.this$0 = p0b7b2d36Var;
    }

    public override java.security.Signature CreateSignature(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException {
        try {
            return this.this$0.f723435f3.createSignature(str);
        } catch (java.lang.Exception unused) {
            return java.security.Signature.getInstance(str);
        }
    }
}

