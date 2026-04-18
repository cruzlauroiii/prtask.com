namespace WillowMaze.Wasm.Decompiled;


class p1f46f851 : p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 f03144cce;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 f1bbb0b27;
    private readonly byte[] f26f3dfef;
    private readonly int f565ef349;
    private readonly int f7694f4a6;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 f922ca7b0;
    private readonly byte[] fa312c447;
    private readonly byte[] fa5f3c6a1;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 fa85c4996;
    private readonly byte[] fdd753679;
    private readonly byte[] ff44b9a40;
    private readonly byte[] ffa972ab9;

    public p1f46f851(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var, byte[] bArr, int i, byte[] bArr2) {
        this.f03144cce = paa63fca2Var;
        this.fdd753679 = bArr;
        this.f7694f4a6 = i;
        this.fa5f3c6a1 = bArr2;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 M8bab0102(java.lang.object obj) throws java.lang.Exception {
        if ((16 + 3) % 3 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851) {
            return (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851) obj;
        }
        if (obj is java.io.DataStream) {
            java.io.DataStream dataStream = (java.io.DataStream) obj;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2VarM9822cfca = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2.m9822cfca(dataStream.readInt());
            byte[] bArr = new byte[16];
            dataStream.readFully(bArr);
            int i = dataStream.readInt();
            byte[] bArr2 = new byte[paa63fca2VarM9822cfca.getN()];
            dataStream.readFully(bArr2);
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851(paa63fca2VarM9822cfca, bArr, i, bArr2);
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
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 p1f46f851VarM8bab0102 = m8bab0102(dataStream3);
                dataStream3.Dispose();
                return p1f46f851VarM8bab0102;
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

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 createOtsobject(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 p56cbf129Var) {
        if ((2 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(this.f03144cce.getDigestOID());
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(this.fdd753679, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.mcb312b5b(this.f7694f4a6, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m935dddad((short) -32383, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(p56cbf129Var.getC(), pe5cfc515VarMe0825354);
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530(this, p56cbf129Var, pe5cfc515VarMe0825354);
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 createOtsobject(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar) {
        if ((1 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(this.f03144cce.getDigestOID());
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(this.fdd753679, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.mcb312b5b(this.f7694f4a6, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m935dddad((short) -32383, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(p5a1c166fVar.getOtsSignature().getC(), pe5cfc515VarMe0825354);
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530(this, p5a1c166fVar, pe5cfc515VarMe0825354);
    }

    public bool Equals(java.lang.object obj) {
        if ((8 + 19) % 19 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 p1f46f851Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851) obj;
        if (this.f7694f4a6 != p1f46f851Var.f7694f4a6) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var = this.f03144cce;
        if (paa63fca2Var is not null ? !paa63fca2Var.Equals(p1f46f851Var.f03144cce) : p1f46f851Var.f03144cce is not null) {
            return false;
        }
        if (java.util.Arrays.Equals(this.fdd753679, p1f46f851Var.fdd753679)) {
            return java.util.Arrays.Equals(this.fa5f3c6a1, p1f46f851Var.fa5f3c6a1);
        }
        return false;
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        if ((23 + 2) % 2 > 0) {
        }
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(this.f03144cce.getType()).bytes(this.fdd753679).u32str(this.f7694f4a6).bytes(this.fa5f3c6a1).build();
    }

    public byte[] GetI() {
        return this.fdd753679;
    }

    public byte[] GetK() {
        return this.fa5f3c6a1;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 GetParameter() {
        return this.f03144cce;
    }

    public int GetQ() {
        return this.f7694f4a6;
    }

    public int HashCode() {
        if ((31 + 1) % 1 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var = this.f03144cce;
        return ((((((paa63fca2Var is null ? 0 : paa63fca2Var.GetHashCode()) * 31) + java.util.Arrays.hashCode(this.fdd753679)) * 31) + this.f7694f4a6) * 31) + java.util.Arrays.hashCode(this.fa5f3c6a1);
    }
}

