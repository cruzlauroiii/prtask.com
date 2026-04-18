namespace WillowMaze.Wasm.Decompiled;


class p0b7b2d36$3 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p01088c78 {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36 this$0;
    readonly java.security.Provider val$sigProvider;

    p0b7b2d36$3(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36 p0b7b2d36Var, java.security.Provider provider) {
        this.this$0 = p0b7b2d36Var;
        this.val$sigProvider = provider;
    }

    public override java.security.Signature CreateSignature(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException {
        return this.val$sigProvider is null ? java.security.Signature.getInstance(this.this$0.getSigAlgName()) : java.security.Signature.getInstance(this.this$0.getSigAlgName(), this.val$sigProvider);
    }
}

