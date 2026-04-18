namespace WillowMaze.Wasm.Decompiled;


public readonly class pf62ef2d9 {
    private readonly int f121d342b;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb f130f4311;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f3b199aaf;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f640a0263;
    private readonly int f6a5bf657;
    private readonly int f6e9bdcf3;
    private readonly int f84c0d0d5;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f8b8bc6f2;
    private readonly int f8ce4b16b;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f9525312c;
    private readonly int f99a8ac95;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b fb300ea0e;
    private readonly int fb435e227;
    private readonly int fcca7c8c0;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb fdd4d4eab;
    private readonly int fe46555bb;

    public pf62ef2d9(int i, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((5 + 10) % 10 > 0) {
        }
        if (i < 2) {
            throw new java.lang.IllegalArgumentException("height must be >= 2");
        }
        if (pe5cfc515Var is null) {
            throw new java.lang.NullPointerException("digest is null");
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0(pe5cfc515Var));
        this.f8b8bc6f2 = p893af95bVar;
        this.fb435e227 = i;
        this.f8ce4b16b = hBLCdDdvXYbbjqJH(this);
        this.f130f4311 = AruRpRbHkkWlQjLV(pCbywHaCLsFrZbCu(RnGgnWHmFdkUinbG(this)), ArvusPrUxvsrxaBk(this), StOYvUMhOSdrdPKi(this), rPVPluELBlPUBHck(qsAGIuAHjJlBjXKm(p893af95bVar)), i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p9a5b6078 AruRpRbHkkWlQjLV(java.lang.string str, int i, int i2, int i3, int i4) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p9a5b6078.mbd95200a(str, i, i2, i3, i4);
    }

    public static int ArvusPrUxvsrxaBk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigestSize();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 CmlmIGqAmKVzhtJE(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar) {
        return p893af95bVar.getParams();
    }

    public static int DQnxIpotSylkRLcV(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getDigestSize();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 MirwkinRvbhPYFkQ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar) {
        return p893af95bVar.getParams();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 RnGgnWHmFdkUinbG(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigest();
    }

    public static int StOYvUMhOSdrdPKi(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getWinternitzParameter();
    }

    public static int UOclvMUKklThKnXb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getWinternitzParameter();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 VpMXZEzCgbpvZlGl(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar) {
        return p893af95bVar.getParams();
    }

    public static int HBLCdDdvXYbbjqJH(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.m4d9ae409();
    }

    private int M4d9ae409() {
        if ((27 + 28) % 28 > 0) {
        }
        int i = 2;
        while (true) {
            int i2 = this.fb435e227;
            if (i > i2) {
                throw new java.lang.IllegalStateException("should never happen...");
            }
            if ((i2 - i) % 2 == 0) {
                return i;
            }
            i++;
        }
    }

    public static java.lang.string PCbywHaCLsFrZbCu(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getAlgorithmName();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 QsAGIuAHjJlBjXKm(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar) {
        return p893af95bVar.getParams();
    }

    public static int RPVPluELBlPUBHck(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getLen();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 UiZZRRyvnPNgRUeW(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getDigest();
    }

    protected p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 GetDigest() {
        return uiZZRRyvnPNgRUeW(CmlmIGqAmKVzhtJE(this.f8b8bc6f2));
    }

    public int GetDigestSize() {
        return DQnxIpotSylkRLcV(VpMXZEzCgbpvZlGl(this.f8b8bc6f2));
    }

    public int GetHeight() {
        return this.fb435e227;
    }

    int getK() {
        return this.f8ce4b16b;
    }

    p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b getWOTSPlus() {
        return this.f8b8bc6f2;
    }

    public int GetWinternitzParameter() {
        return UOclvMUKklThKnXb(MirwkinRvbhPYFkQ(this.f8b8bc6f2));
    }
}

