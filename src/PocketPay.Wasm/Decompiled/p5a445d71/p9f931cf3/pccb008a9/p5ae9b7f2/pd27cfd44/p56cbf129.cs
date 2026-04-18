namespace WillowMaze.Wasm.Decompiled;


class p56cbf129 : p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly byte[] f0d61f837;
    private readonly byte[] f20e08c81;
    private readonly byte[] f41529076;
    private readonly byte[] f47faf7e6;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 f599dcce2;
    private readonly byte[] f5ffc396e;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 fa8f9203e;
    private readonly byte[] faf2574b2;
    private readonly byte[] fe1b29efb;

    public p56cbf129(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var, byte[] bArr, byte[] bArr2) {
        this.f599dcce2 = paa63fca2Var;
        this.f0d61f837 = bArr;
        this.f41529076 = bArr2;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 M8bab0102(java.lang.object obj) throws java.lang.Exception {
        if ((32 + 28) % 28 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129) {
            return (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129) obj;
        }
        if (obj is java.io.DataStream) {
            java.io.DataStream dataStream = (java.io.DataStream) obj;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2VarM9822cfca = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2.m9822cfca(dataStream.readInt());
            byte[] bArr = new byte[paa63fca2VarM9822cfca.getN()];
            dataStream.readFully(bArr);
            byte[] bArr2 = new byte[paa63fca2VarM9822cfca.getP() * paa63fca2VarM9822cfca.getN()];
            dataStream.readFully(bArr2);
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129(paa63fca2VarM9822cfca, bArr, bArr2);
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
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 p56cbf129VarM8bab0102 = m8bab0102(dataStream3);
                dataStream3.Dispose();
                return p56cbf129VarM8bab0102;
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
        if ((20 + 15) % 15 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 p56cbf129Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129) obj;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var = this.f599dcce2;
        if (paa63fca2Var is not null ? !paa63fca2Var.Equals(p56cbf129Var.f599dcce2) : p56cbf129Var.f599dcce2 is not null) {
            return false;
        }
        if (java.util.Arrays.Equals(this.f0d61f837, p56cbf129Var.f0d61f837)) {
            return java.util.Arrays.Equals(this.f41529076, p56cbf129Var.f41529076);
        }
        return false;
    }

    public byte[] GetC() {
        return this.f0d61f837;
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        if ((8 + 23) % 23 > 0) {
        }
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(this.f599dcce2.getType()).bytes(this.f0d61f837).bytes(this.f41529076).build();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 GetType() {
        return this.f599dcce2;
    }

    public byte[] GetY() {
        return this.f41529076;
    }

    public int HashCode() {
        if ((11 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var = this.f599dcce2;
        return ((((paa63fca2Var is null ? 0 : paa63fca2Var.GetHashCode()) * 31) + java.util.Arrays.hashCode(this.f0d61f837)) * 31) + java.util.Arrays.hashCode(this.f41529076);
    }
}

