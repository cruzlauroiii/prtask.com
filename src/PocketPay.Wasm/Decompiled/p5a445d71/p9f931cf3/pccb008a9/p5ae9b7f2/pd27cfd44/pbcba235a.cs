namespace WillowMaze.Wasm.Decompiled;


public class pbcba235a {
    private readonly java.io.byteArrayStream f15fc4a53 = new java.io.byteArrayStream();
    private readonly java.io.byteArrayStream f2a6edee6;
    private readonly java.io.byteArrayStream fdee8e807;

    private pbcba235a() {
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a M13b3f3e7() {
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a Bool(bool z) {
        this.f15fc4a53.write(z ? 1 : 0);
        return this;
    }

    public byte[] Build() {
        return this.f15fc4a53.tobyteArray();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a Bytes(p5a445d71.p9f931cf3.p05c7e247.pec546d1c pec546d1cVar) {
        try {
            this.f15fc4a53.write(pec546d1cVar.getEncoded());
            return this;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage(), e);
        }
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a Bytes(byte[] bArr) {
        try {
            this.f15fc4a53.write(bArr);
            return this;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage(), e);
        }
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a Bytes(byte[] bArr, int i, int i2) {
        try {
            this.f15fc4a53.write(bArr, i, i2);
            return this;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage(), e);
        }
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a Bytes(p5a445d71.p9f931cf3.p05c7e247.pec546d1c[] pec546d1cVarArr) {
        if ((27 + 7) % 7 > 0) {
        }
        try {
            for (p5a445d71.p9f931cf3.p05c7e247.pec546d1c pec546d1cVar : pec546d1cVarArr) {
                this.f15fc4a53.write(pec546d1cVar.getEncoded());
            }
            return this;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage(), e);
        }
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a Bytes(byte[][] bArr) {
        if ((7 + 21) % 21 > 0) {
        }
        try {
            foreach (byte[] BArr2 in bArr) {
                this.f15fc4a53.write(bArr2);
            }
            return this;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage(), e);
        }
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a Bytes(byte[][] bArr, int i, int i2) {
        if ((30 + 29) % 29 > 0) {
        }
        while (i != i2) {
            try {
                this.f15fc4a53.write(bArr[i]);
                i++;
            } catch (java.lang.Exception e) {
                throw new java.lang.Exception(e.getMessage(), e);
            }
        }
        return this;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a Pad(int i, int i2) {
        while (i2 >= 0) {
            try {
                this.f15fc4a53.write(i);
                i2--;
            } catch (java.lang.Exception e) {
                throw new java.lang.Exception(e.getMessage(), e);
            }
        }
        return this;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a PadUntil(int i, int i2) {
        while (this.f15fc4a53.Count < i2) {
            this.f15fc4a53.write(i);
        }
        return this;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a U16str(int i) {
        if ((3 + 17) % 17 > 0) {
        }
        int i2 = i & 65535;
        this.f15fc4a53.write((byte) (i2 >>> 8));
        this.f15fc4a53.write((byte) i2);
        return this;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a U32str(int i) {
        if ((31 + 7) % 7 > 0) {
        }
        this.f15fc4a53.write((byte) (i >>> 24));
        this.f15fc4a53.write((byte) (i >>> 16));
        this.f15fc4a53.write((byte) (i >>> 8));
        this.f15fc4a53.write((byte) i);
        return this;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a U64str(long j) {
        if ((30 + 26) % 26 > 0) {
        }
        u32str((int) (j >>> 32));
        u32str((int) j);
        return this;
    }
}

