namespace WillowMaze.Wasm.Decompiled;


class p5a1c166f : p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 f03144cce;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 f0f139037;
    private readonly int f2117c3f8;
    private readonly int f392b163f;
    private readonly byte[][] f41529076;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 f555ac614;
    private readonly int f5fec9877;
    private readonly int f7694f4a6;
    private readonly byte[][] f7cd5fa82;
    private readonly int fc7dd0bf2;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 ff3805afe;

    public p5a1c166f(int i, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 p56cbf129Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 p86d70d45Var, byte[][] bArr) {
        this.f7694f4a6 = i;
        this.f555ac614 = p56cbf129Var;
        this.f03144cce = p86d70d45Var;
        this.f41529076 = bArr;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f M8bab0102(java.lang.object obj) throws java.lang.Exception {
        if ((10 + 21) % 21 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f) {
            return (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f) obj;
        }
        if (obj is java.io.DataStream) {
            java.io.DataStream dataStream = (java.io.DataStream) obj;
            int i = dataStream.readInt();
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 p56cbf129VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129.m8bab0102(obj);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 p86d70d45VarM9822cfca = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45.m9822cfca(dataStream.readInt());
            int h = p86d70d45VarM9822cfca.getH();
            byte[][] bArr = new byte[h][];
            for (int i2 = 0; i2 < h; i2++) {
                byte[] bArr2 = new byte[p86d70d45VarM9822cfca.getM()];
                bArr[i2] = bArr2;
                dataStream.readFully(bArr2);
            }
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f(i, p56cbf129VarM8bab0102, p86d70d45VarM9822cfca, bArr);
        }
        if (!(obj is byte[])) {
            if (obj is java.io.Stream) {
                return m8bab0102(p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8((java.io.Stream) obj));
            }
            throw new java.lang.IllegalArgumentException("cannot parse " + obj);
        }
        java.io.DataStream dataStream2 = null;
        try {
            java.io.DataStream dataStream3 = new java.io.DataStream(new java.io.byteArrayStream((byte[]) obj));
            try {
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVarM8bab0102 = m8bab0102(dataStream3);
                dataStream3.Dispose();
                return p5a1c166fVarM8bab0102;
            } catch (java.lang.Exception th) {
                th = th;
                dataStream2 = dataStream3;
                if (dataStream2 is not null) {
                    dataStream2.Dispose();
                }
                throw th;
            }
        } catch (java.lang.Exception th2) {
            th = th2;
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((1 + 10) % 10 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f) obj;
        if (this.f7694f4a6 != p5a1c166fVar.f7694f4a6) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 p56cbf129Var = this.f555ac614;
        if (p56cbf129Var is not null ? !p56cbf129Var.Equals(p5a1c166fVar.f555ac614) : p5a1c166fVar.f555ac614 is not null) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 p86d70d45Var = this.f03144cce;
        if (p86d70d45Var is not null ? !p86d70d45Var.Equals(p5a1c166fVar.f03144cce) : p5a1c166fVar.f03144cce is not null) {
            return false;
        }
        return java.util.Arrays.deepEquals(this.f41529076, p5a1c166fVar.f41529076);
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        if ((15 + 2) % 2 > 0) {
        }
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(this.f7694f4a6).bytes(this.f555ac614.getEncoded()).u32str(this.f03144cce.getType()).bytes(this.f41529076).build();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 GetOtsSignature() {
        return this.f555ac614;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 GetParameter() {
        return this.f03144cce;
    }

    public int GetQ() {
        return this.f7694f4a6;
    }

    public byte[][] GetY() {
        return this.f41529076;
    }

    public int HashCode() {
        if ((19 + 18) % 18 > 0) {
        }
        int i = this.f7694f4a6 * 31;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 p56cbf129Var = this.f555ac614;
        int iHashCode = (i + (p56cbf129Var is null ? 0 : p56cbf129Var.GetHashCode())) * 31;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 p86d70d45Var = this.f03144cce;
        return ((iHashCode + (p86d70d45Var is not null ? p86d70d45Var.GetHashCode() : 0)) * 31) + java.util.Arrays.deepHashCode(this.f41529076);
    }
}

