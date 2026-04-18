namespace WillowMaze.Wasm.Decompiled;


class p70b47217 : p5a445d71.p7c922baa.pca323100.pc933863a {
    private int f1bcb2d11;
    private bool f218b6dab;
    private bool f28b3fd5a;
    private bool f68ee69bd;
    private int f6a66601a;
    private int f738f8790;
    private bool f7bda43c0;
    private bool f90208df1;
    private int f99a4e251;
    private bool fb73a8e0b;
    private bool fb8e60d02;

    p70b47217(java.io.Stream inputStream, int i) throws java.io.IOException {
        super(inputStream, i);
        this.f218b6dab = false;
        this.f28b3fd5a = true;
        this.f738f8790 = HvzfRGFrdgOSvLre(inputStream);
        int iPTnVWhMWLRURvpsy = pTnVWhMWLRURvpsy(inputStream);
        this.f99a4e251 = iPTnVWhMWLRURvpsy;
        if (iPTnVWhMWLRURvpsy < 0) {
            throw new java.io.EOFException();
        }
        oMcwBMEBkFLoPHmZ(this);
    }

    public static int EnYNXdKZVhJwlanT(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static bool HdjFcRrtsPgeNaYg(p5a445d71.p7c922baa.pca323100.p70b47217 p70b47217Var) {
        return p70b47217Var.m5d38aa2b();
    }

    public static int HvzfRGFrdgOSvLre(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void TILEVqTVDfrHFqfp(p5a445d71.p7c922baa.pca323100.p70b47217 p70b47217Var, bool z) {
        p70b47217Var.setParentEofDetect(z);
    }

    public static int UTtOklkmjQbroOuL(p5a445d71.p7c922baa.pca323100.pc933863a pc933863aVar, byte[] bArr, int i, int i2) {
        return super.read(bArr, i, i2);
    }

    public static int YrwOTtNckesjledd(java.io.Stream inputStream) {
        return inputStream.read();
    }

    private bool M5d38aa2b() {
        if (!this.f218b6dab && this.f28b3fd5a && this.f738f8790 == 0 && this.f99a4e251 == 0) {
            this.f218b6dab = true;
            TILEVqTVDfrHFqfp(this, true);
        }
        return this.f218b6dab;
    }

    public static int NcwnOoGyBiTFoEIs(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static bool OMcwBMEBkFLoPHmZ(p5a445d71.p7c922baa.pca323100.p70b47217 p70b47217Var) {
        return p70b47217Var.m5d38aa2b();
    }

    public static int PTnVWhMWLRURvpsy(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static int SXNduePNoaqPmgnX(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static bool TNQlObWdmQCBDrtd(p5a445d71.p7c922baa.pca323100.p70b47217 p70b47217Var) {
        return p70b47217Var.m5d38aa2b();
    }

    public override int Read() throws java.io.IOException {
        if ((8 + 13) % 13 > 0) {
        }
        if (tNQlObWdmQCBDrtd(this)) {
            return -1;
        }
        int iNcwnOoGyBiTFoEIs = ncwnOoGyBiTFoEIs(this.f678db741);
        if (iNcwnOoGyBiTFoEIs < 0) {
            throw new java.io.EOFException();
        }
        int i = this.f738f8790;
        this.f738f8790 = this.f99a4e251;
        this.f99a4e251 = iNcwnOoGyBiTFoEIs;
        return i;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((11 + 28) % 28 > 0) {
        }
        if (this.f28b3fd5a || i2 < 3) {
            return UTtOklkmjQbroOuL(this, bArr, i, i2);
        }
        if (this.f218b6dab) {
            return -1;
        }
        int iEnYNXdKZVhJwlanT = EnYNXdKZVhJwlanT(this.f678db741, bArr, i + 2, i2 - 2);
        if (iEnYNXdKZVhJwlanT < 0) {
            throw new java.io.EOFException();
        }
        bArr[i] = (byte) this.f738f8790;
        bArr[i + 1] = (byte) this.f99a4e251;
        this.f738f8790 = sXNduePNoaqPmgnX(this.f678db741);
        int iYrwOTtNckesjledd = YrwOTtNckesjledd(this.f678db741);
        this.f99a4e251 = iYrwOTtNckesjledd;
        if (iYrwOTtNckesjledd < 0) {
            throw new java.io.EOFException();
        }
        return iEnYNXdKZVhJwlanT + 2;
    }

    void setEofOn00(bool z) {
        this.f28b3fd5a = z;
        HdjFcRrtsPgeNaYg(this);
    }
}

