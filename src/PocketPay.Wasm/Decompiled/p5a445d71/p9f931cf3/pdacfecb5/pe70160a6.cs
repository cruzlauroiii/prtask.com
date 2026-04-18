namespace WillowMaze.Wasm.Decompiled;


public class pe70160a6 : p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p8b95144c {
    private p5a445d71.p9f931cf3.pdacfecb5.pbabfe1c0 f37701d33;
    private java.security.Provider f41799daa;
    private java.security.Provider f5749ee0c;
    private java.security.Provider f63197a15;
    private p5a445d71.p9f931cf3.pdacfecb5.pbabfe1c0 fe90fdbe2;
    private p5a445d71.p9f931cf3.pdacfecb5.pbabfe1c0 ff6597431;

    private pe70160a6(java.security.Provider provider, p5a445d71.p9f931cf3.pdacfecb5.pbabfe1c0 pbabfe1c0Var) {
        this.f5749ee0c = provider;
        this.f37701d33 = pbabfe1c0Var;
    }

    public static p5a445d71.p9f931cf3.pdacfecb5.pe70160a6 M8bab0102(java.lang.string str) throws p5a445d71.p9f931cf3.pdacfecb5.ped32af0c {
        try {
            return mfbf80224(p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.maf7f303d("X509StreamParser", str));
        } catch (java.security.NoSuchAlgorithmException e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.ped32af0c(e.getMessage());
        }
    }

    public static p5a445d71.p9f931cf3.pdacfecb5.pe70160a6 M8bab0102(java.lang.string str, java.lang.string str2) throws p5a445d71.p9f931cf3.pdacfecb5.ped32af0c, java.security.NoSuchProviderException {
        return m8bab0102(str, p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.m88237667(str2));
    }

    public static p5a445d71.p9f931cf3.pdacfecb5.pe70160a6 M8bab0102(java.lang.string str, java.security.Provider provider) throws p5a445d71.p9f931cf3.pdacfecb5.ped32af0c {
        try {
            return mfbf80224(p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.maf7f303d("X509StreamParser", str, provider));
        } catch (java.security.NoSuchAlgorithmException e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.ped32af0c(e.getMessage());
        }
    }

    private static p5a445d71.p9f931cf3.pdacfecb5.pe70160a6 Mfbf80224(p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310$pb672f52a pbdeb4310_pb672f52a) {
        if ((30 + 9) % 9 > 0) {
        }
        return new p5a445d71.p9f931cf3.pdacfecb5.pe70160a6(pbdeb4310_pb672f52a.getProvider(), (p5a445d71.p9f931cf3.pdacfecb5.pbabfe1c0) pbdeb4310_pb672f52a.getEngine());
    }

    public java.security.Provider GetProvider() {
        return this.f5749ee0c;
    }

    public void Init(java.io.Stream inputStream) {
        this.f37701d33.engineInit(inputStream);
    }

    public void Init(byte[] bArr) {
        this.f37701d33.engineInit(new java.io.byteArrayStream(bArr));
    }

    public override java.lang.object Read() throws p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6 {
        return this.f37701d33.engineRead();
    }

    public override java.util.ICollection ReadAll() throws p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6 {
        return this.f37701d33.engineReadAll();
    }
}

