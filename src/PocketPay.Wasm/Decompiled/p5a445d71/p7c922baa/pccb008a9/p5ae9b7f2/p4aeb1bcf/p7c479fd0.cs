namespace WillowMaze.Wasm.Decompiled;


readonly class p7c479fd0 {
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb f068017dd;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb f0e7f4277;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb f130f4311;
    private readonly int f186db8aa;
    private readonly int f254e03ce;
    private readonly int f2aeed308;
    private readonly int f4aeb6e83;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f5d3f1e28;
    private readonly int f6d3520c7;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f72f81af4;
    private readonly int f7ad5ed95;
    private readonly int f9255f8d1;
    private readonly int f955ac2e8;
    private readonly int f966f9065;
    private readonly int fb2bba600;
    private readonly int fb6ce1724;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;
    private readonly int fe390becb;
    private readonly int ff152fcf9;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 ff3d44500;
    private readonly int ff5a8e923;

    protected p7c479fd0(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((32 + 5) % 5 > 0) {
        }
        if (pe5cfc515Var is null) {
            throw new java.lang.NullPointerException("digest is null");
        }
        this.fc10f7796 = pe5cfc515Var;
        int iFHEtfHsQcSBFphDF = fHEtfHsQcSBFphDF(pe5cfc515Var);
        this.f9255f8d1 = iFHEtfHsQcSBFphDF;
        this.f955ac2e8 = 16;
        int iICwbxuNTcBOAbhCg = (int) iCwbxuNTcBOAbhCg(((double) (iFHEtfHsQcSBFphDF * 8)) / ((double) ZReqsBOiPWdCzzkB(16)));
        this.f966f9065 = iICwbxuNTcBOAbhCg;
        int iCZYNHAgtMHnPgCko = ((int) cZYNHAgtMHnPgCko(HuUsEJQmoUXGjQZg((16 - 1) * iICwbxuNTcBOAbhCg) / IeKuJxPJUiPJLirR(16))) + 1;
        this.f7ad5ed95 = iCZYNHAgtMHnPgCko;
        int i = iICwbxuNTcBOAbhCg + iCZYNHAgtMHnPgCko;
        this.ff5a8e923 = i;
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0 p8868a0f0VarLwbWyTdUhihLAzrz = LwbWyTdUhihLAzrz(ckZwuFyBbKxqrEyw(pe5cfc515Var), iFHEtfHsQcSBFphDF, 16, i);
        this.f130f4311 = p8868a0f0VarLwbWyTdUhihLAzrz;
        if (p8868a0f0VarLwbWyTdUhihLAzrz is null) {
            throw new java.lang.IllegalArgumentException(GIfQXvfbYIrRwjKz(OWPNYxQMGqjtXqkg(new java.lang.stringBuilder("cannot find OID for digest algorithm: "), sxqFtjmamkbMWURc(pe5cfc515Var))));
        }
    }

    public static java.lang.string GIfQXvfbYIrRwjKz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HuUsEJQmoUXGjQZg(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d(i);
    }

    public static int IeKuJxPJUiPJLirR(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0 LwbWyTdUhihLAzrz(java.lang.string str, int i, int i2, int i3) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0.mbd95200a(str, i, i2, i3);
    }

    public static java.lang.stringBuilder OWPNYxQMGqjtXqkg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ZReqsBOiPWdCzzkB(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d(i);
    }

    public static double CZYNHAgtMHnPgCko(double d) {
        if ((2 + 30) % 30 > 0) {
        }
        return java.lang.Math.floor(d);
    }

    public static java.lang.string CkZwuFyBbKxqrEyw(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getAlgorithmName();
    }

    public static int FHEtfHsQcSBFphDF(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m277ad7bf(pe5cfc515Var);
    }

    public static double ICwbxuNTcBOAbhCg(double d) {
        if ((22 + 30) % 30 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static java.lang.string SxqFtjmamkbMWURc(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getAlgorithmName();
    }

    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    protected int GetDigestSize() {
        return this.f9255f8d1;
    }

    protected int GetLen() {
        return this.ff5a8e923;
    }

    protected int GetLen1() {
        return this.f966f9065;
    }

    protected int GetLen2() {
        return this.f7ad5ed95;
    }

    protected p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb GetOid() {
        return this.f130f4311;
    }

    protected int GetWinternitzParameter() {
        return this.f955ac2e8;
    }
}

