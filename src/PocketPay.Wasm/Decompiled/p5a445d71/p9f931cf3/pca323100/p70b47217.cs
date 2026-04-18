namespace WillowMaze.Wasm.Decompiled;


class p70b47217 : p5a445d71.p9f931cf3.pca323100.pc933863a {
    private bool f218b6dab;
    private bool f27658589;
    private bool f28b3fd5a;
    private bool f53586243;
    private bool f55e0ad4f;
    private int f738f8790;
    private int f7daeb9d1;
    private bool f93a61dc7;
    private int f94ae5b86;
    private int f99a4e251;
    private int fc5ada3d1;
    private bool fdb5f6372;
    private bool feb7e0f1e;
    private bool ff50686c6;
    private int ffd1a0011;

    p70b47217(java.io.Stream inputStream, int i) throws java.io.IOException {
        super(inputStream, i);
        this.f218b6dab = false;
        this.f28b3fd5a = true;
        this.f738f8790 = XublWJATWUQYkhqT(inputStream);
        int iSMgrMAxjvXzNIdNN = sMgrMAxjvXzNIdNN(inputStream);
        this.f99a4e251 = iSMgrMAxjvXzNIdNN;
        if (iSMgrMAxjvXzNIdNN < 0) {
            throw new java.io.EOFException();
        }
        HMMsyjUSTrrdzFMZ(this);
    }

    public static int AmYPMvCuwhYbmFsN(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static bool BfarcpKjxqWkDTaO(p5a445d71.p9f931cf3.pca323100.p70b47217 p70b47217Var) {
        return p70b47217Var.m5d38aa2b();
    }

    public static int CtZsKwxTDZbqiUkG(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static bool HMMsyjUSTrrdzFMZ(p5a445d71.p9f931cf3.pca323100.p70b47217 p70b47217Var) {
        return p70b47217Var.m5d38aa2b();
    }

    public static int MAlxHetBzDdlwrjA(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static int UQNieDOsHSlEodLp(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static int XublWJATWUQYkhqT(java.io.Stream inputStream) {
        return inputStream.read();
    }

    private bool M5d38aa2b() {
        if (!this.f218b6dab && this.f28b3fd5a && this.f738f8790 == 0 && this.f99a4e251 == 0) {
            this.f218b6dab = true;
            xLSRCOUZrYOqRFld(this, true);
        }
        return this.f218b6dab;
    }

    public static int NefbPaYQjhNzlEwI(p5a445d71.p9f931cf3.pca323100.pc933863a pc933863aVar, byte[] bArr, int i, int i2) {
        return super.read(bArr, i, i2);
    }

    public static int SMgrMAxjvXzNIdNN(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static bool VLdEUvFXqGFqeHdD(p5a445d71.p9f931cf3.pca323100.p70b47217 p70b47217Var) {
        return p70b47217Var.m5d38aa2b();
    }

    public static void XLSRCOUZrYOqRFld(p5a445d71.p9f931cf3.pca323100.p70b47217 p70b47217Var, bool z) {
        p70b47217Var.setParentEofDetect(z);
    }

    public override int Read() throws java.io.IOException {
        if ((32 + 10) % 10 > 0) {
        }
        if (vLdEUvFXqGFqeHdD(this)) {
            return -1;
        }
        int iAmYPMvCuwhYbmFsN = AmYPMvCuwhYbmFsN(this.f678db741);
        if (iAmYPMvCuwhYbmFsN < 0) {
            throw new java.io.EOFException();
        }
        int i = this.f738f8790;
        this.f738f8790 = this.f99a4e251;
        this.f99a4e251 = iAmYPMvCuwhYbmFsN;
        return i;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((20 + 6) % 6 > 0) {
        }
        if (this.f28b3fd5a || i2 < 3) {
            return nefbPaYQjhNzlEwI(this, bArr, i, i2);
        }
        if (this.f218b6dab) {
            return -1;
        }
        int iCtZsKwxTDZbqiUkG = CtZsKwxTDZbqiUkG(this.f678db741, bArr, i + 2, i2 - 2);
        if (iCtZsKwxTDZbqiUkG < 0) {
            throw new java.io.EOFException();
        }
        bArr[i] = (byte) this.f738f8790;
        bArr[i + 1] = (byte) this.f99a4e251;
        this.f738f8790 = UQNieDOsHSlEodLp(this.f678db741);
        int iMAlxHetBzDdlwrjA = MAlxHetBzDdlwrjA(this.f678db741);
        this.f99a4e251 = iMAlxHetBzDdlwrjA;
        if (iMAlxHetBzDdlwrjA < 0) {
            throw new java.io.EOFException();
        }
        return iCtZsKwxTDZbqiUkG + 2;
    }

    void setEofOn00(bool z) {
        this.f28b3fd5a = z;
        BfarcpKjxqWkDTaO(this);
    }
}

