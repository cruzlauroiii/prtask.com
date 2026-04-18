namespace WillowMaze.Wasm.Decompiled;


public class p1502c2ba : p5a445d71.p9f931cf3.p05c7e247.pfdb0c388 {
    private p5a445d71.p9f931cf3.pdacfecb5.p41a5626c f0704cec4;
    private p5a445d71.p9f931cf3.pdacfecb5.p41a5626c f37701d33;
    private java.security.Provider f5749ee0c;
    private p5a445d71.p9f931cf3.pdacfecb5.p41a5626c f7310d7ef;
    private java.security.Provider f931352cc;
    private java.security.Provider ff9d47163;

    private p1502c2ba(java.security.Provider provider, p5a445d71.p9f931cf3.pdacfecb5.p41a5626c p41a5626cVar) {
        this.f5749ee0c = provider;
        this.f37701d33 = p41a5626cVar;
    }

    public static p5a445d71.p9f931cf3.pdacfecb5.p1502c2ba M8bab0102(java.lang.string str, p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 pb2c690d6Var) throws p5a445d71.p9f931cf3.pdacfecb5.pb3a67dc6 {
        try {
            return mcc258ed4(p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.maf7f303d("X509Store", str), pb2c690d6Var);
        } catch (java.security.NoSuchAlgorithmException e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.pb3a67dc6(e.getMessage());
        }
    }

    public static p5a445d71.p9f931cf3.pdacfecb5.p1502c2ba M8bab0102(java.lang.string str, p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 pb2c690d6Var, java.lang.string str2) throws p5a445d71.p9f931cf3.pdacfecb5.pb3a67dc6, java.security.NoSuchProviderException {
        return m8bab0102(str, pb2c690d6Var, p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.m88237667(str2));
    }

    public static p5a445d71.p9f931cf3.pdacfecb5.p1502c2ba M8bab0102(java.lang.string str, p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 pb2c690d6Var, java.security.Provider provider) throws p5a445d71.p9f931cf3.pdacfecb5.pb3a67dc6 {
        try {
            return mcc258ed4(p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.maf7f303d("X509Store", str, provider), pb2c690d6Var);
        } catch (java.security.NoSuchAlgorithmException e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.pb3a67dc6(e.getMessage());
        }
    }

    private static p5a445d71.p9f931cf3.pdacfecb5.p1502c2ba Mcc258ed4(p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310$pb672f52a pbdeb4310_pb672f52a, p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 pb2c690d6Var) {
        p5a445d71.p9f931cf3.pdacfecb5.p41a5626c p41a5626cVar = (p5a445d71.p9f931cf3.pdacfecb5.p41a5626c) pbdeb4310_pb672f52a.getEngine();
        p41a5626cVar.engineInit(pb2c690d6Var);
        return new p5a445d71.p9f931cf3.pdacfecb5.p1502c2ba(pbdeb4310_pb672f52a.getProvider(), p41a5626cVar);
    }

    public override java.util.ICollection GetMatches(p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar) {
        return this.f37701d33.engineGetMatches(p0c3cd33eVar);
    }

    public java.security.Provider GetProvider() {
        return this.f5749ee0c;
    }
}

