namespace WillowMaze.Wasm.Decompiled;


public class pe32c2c6b : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pd9f65fa7 {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 f18b284aa;
    private readonly int f2db95e8e;
    private readonly int f3bb4c88a;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 f6c7501c9;
    private readonly int f9695a4fc;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 fbc6e52ea;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 fc4013924;
    private readonly int fc8181b4d;
    private readonly int fef31fbe7;

    public pe32c2c6b(int i, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 p9064fad6Var) {
        super(false);
        this.f2db95e8e = i;
        this.f6c7501c9 = p9064fad6Var;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b M8bab0102(java.lang.object obj) throws java.lang.Exception {
        java.io.DataStream dataStream;
        if ((15 + 2) % 2 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b) {
            return (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b) obj;
        }
        if (obj is java.io.DataStream) {
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b(((java.io.DataStream) obj).readInt(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6.m8bab0102(obj));
        }
        if (!(obj is byte[])) {
            if (obj is java.io.Stream) {
                return m8bab0102(p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8((java.io.Stream) obj));
            }
            throw new java.lang.IllegalArgumentException("cannot parse " + obj);
        }
        java.io.DataStream dataStream2 = null;
        try {
            dataStream = new java.io.DataStream(new java.io.byteArrayStream((byte[]) obj));
        } catch (java.lang.Exception th) {
            th = th;
        }
        try {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b pe32c2c6bVarM8bab0102 = m8bab0102(dataStream);
            dataStream.Dispose();
            return pe32c2c6bVarM8bab0102;
        } catch (java.lang.Exception th2) {
            th = th2;
            dataStream2 = dataStream;
            if (dataStream2 is not null) {
                dataStream2.Dispose();
            }
            throw th;
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((28 + 3) % 3 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b pe32c2c6bVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b) obj;
        if (this.f2db95e8e == pe32c2c6bVar.f2db95e8e) {
            return this.f6c7501c9.Equals(pe32c2c6bVar.f6c7501c9);
        }
        return false;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 GenerateLMSobject(byte[] bArr) throws java.lang.Exception {
        if ((1 + 13) % 13 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7 pf82a7aa7VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7.m8bab0102(bArr, getL());
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] signedPubKey = pf82a7aa7VarM8bab0102.getSignedPubKey();
            return signedPubKey[signedPubKey.length - 1].getPublicKey().generateOtsobject(pf82a7aa7VarM8bab0102.getSignature()).withSignedPublicKeys(signedPubKey);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("cannot parse signature: " + e.getMessage());
        }
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        if ((1 + 21) % 21 > 0) {
        }
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(this.f2db95e8e).bytes(this.f6c7501c9.getEncoded()).build();
    }

    public int GetL() {
        return this.f2db95e8e;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 GetLMSPublicKey() {
        return this.f6c7501c9;
    }

    public int HashCode() {
        return (this.f2db95e8e * 31) + this.f6c7501c9.GetHashCode();
    }

    public override bool Verify(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 pf502f530Var) {
        if ((28 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] signedPubKeys = pf502f530Var.getSignedPubKeys();
        if (signedPubKeys.length != getL() - 1) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 lMSPublicKey = getLMSPublicKey();
        bool z = false;
        for (int i = 0; i < signedPubKeys.length; i++) {
            if (!p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m34a82b06(lMSPublicKey, signedPubKeys[i].getSignature(), signedPubKeys[i].getPublicKey().tobyteArray())) {
                z = true;
            }
            lMSPublicKey = signedPubKeys[i].getPublicKey();
        }
        return lMSPublicKey.verify(pf502f530Var) & (!z);
    }
}

