namespace WillowMaze.Wasm.Decompiled;


public class p9064fad6 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pd9f65fa7 {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 f181d2f2c;
    private readonly byte[] f26221e5e;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 f2b7b3c54;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 f46f389ce;
    private readonly byte[] f517831dc;
    private readonly byte[] f69e2e8a2;
    private readonly byte[] f6b59253f;
    private readonly byte[] f7cb1c335;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 f995a495f;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 fa197093d;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 fab39ec47;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 fb35d9538;
    private readonly byte[] fce499dea;
    private readonly byte[] fdd753679;
    private readonly byte[] ff2c922f8;

    public p9064fad6(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 p86d70d45Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var, byte[] bArr, byte[] bArr2) {
        super(false);
        this.f995a495f = p86d70d45Var;
        this.f2b7b3c54 = paa63fca2Var;
        this.fdd753679 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        this.fce499dea = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 M8bab0102(java.lang.object obj) throws java.lang.Exception {
        java.io.DataStream dataStream;
        if ((2 + 10) % 10 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6) {
            return (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6) obj;
        }
        if (obj is java.io.DataStream) {
            java.io.DataStream dataStream2 = (java.io.DataStream) obj;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 p86d70d45VarM9822cfca = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45.m9822cfca(dataStream2.readInt());
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2VarM9822cfca = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2.m9822cfca(dataStream2.readInt());
            byte[] bArr = new byte[16];
            dataStream2.readFully(bArr);
            byte[] bArr2 = new byte[p86d70d45VarM9822cfca.getM()];
            dataStream2.readFully(bArr2);
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6(p86d70d45VarM9822cfca, paa63fca2VarM9822cfca, bArr2, bArr);
        }
        if (!(obj is byte[])) {
            if (obj is java.io.Stream) {
                return m8bab0102(p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8((java.io.Stream) obj));
            }
            throw new java.lang.IllegalArgumentException("cannot parse " + obj);
        }
        java.io.DataStream dataStream3 = null;
        try {
            dataStream = new java.io.DataStream(new java.io.byteArrayStream((byte[]) obj));
        } catch (java.lang.Exception th) {
            th = th;
        }
        try {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 p9064fad6VarM8bab0102 = m8bab0102(dataStream);
            dataStream.Dispose();
            return p9064fad6VarM8bab0102;
        } catch (java.lang.Exception th2) {
            th = th2;
            dataStream3 = dataStream;
            if (dataStream3 is not null) {
                dataStream3.Dispose();
            }
            throw th;
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((6 + 31) % 31 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 p9064fad6Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6) obj;
        if (this.f995a495f.Equals(p9064fad6Var.f995a495f) && this.f2b7b3c54.Equals(p9064fad6Var.f2b7b3c54) && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.fdd753679, p9064fad6Var.fdd753679)) {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.fce499dea, p9064fad6Var.fce499dea);
        }
        return false;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 GenerateLMSobject(byte[] bArr) {
        if ((25 + 18) % 18 > 0) {
        }
        try {
            return generateOtsobject(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f.m8bab0102(bArr));
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("cannot parse signature: " + e.getMessage());
        }
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 generateOtsobject(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar) {
        if ((9 + 15) % 15 > 0) {
        }
        int type = getOtsParameters().getType();
        if (p5a1c166fVar.getOtsSignature().getType().getType() != type) {
            throw new java.lang.IllegalArgumentException("ots type from lsm signature does not match ots signature type from embedded ots signature");
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2.m9822cfca(type), this.fdd753679, p5a1c166fVar.getQ(), null).createOtsobject(p5a1c166fVar);
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        return tobyteArray();
    }

    public byte[] GetI() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fdd753679);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3 GetLMSParameters() {
        if ((24 + 16) % 16 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3(getSigParameters(), getOtsParameters());
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 GetOtsParameters() {
        return this.f2b7b3c54;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 GetSigParameters() {
        return this.f995a495f;
    }

    public byte[] GetT1() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fce499dea);
    }

    public int HashCode() {
        if ((20 + 31) % 31 > 0) {
        }
        return (((((this.f995a495f.GetHashCode() * 31) + this.f2b7b3c54.GetHashCode()) * 31) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.fdd753679)) * 31) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.fce499dea);
    }

    bool matchesT1(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(this.fce499dea, bArr);
    }

    byte[] refI() {
        return this.fdd753679;
    }

    byte[] tobyteArray() {
        if ((17 + 10) % 10 > 0) {
        }
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(this.f995a495f.getType()).u32str(this.f2b7b3c54.getType()).bytes(this.fdd753679).bytes(this.fce499dea).build();
    }

    public override bool Verify(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 pf502f530Var) {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m34a82b06(this, pf502f530Var);
    }
}

