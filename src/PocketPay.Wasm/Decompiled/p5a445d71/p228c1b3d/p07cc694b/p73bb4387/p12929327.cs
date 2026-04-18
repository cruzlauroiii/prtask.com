namespace WillowMaze.Wasm.Decompiled;


public class p12929327 : p5a445d71.p228c1b3d.p07cc694b.p34dacb78 {
    private static readonly int f0168d683;
    private static readonly int f21ecc07a = 0;
    private static readonly long f2a8550cc = 5472298452022250685L;
    private static readonly int f42799dd9 = 0;
    private static readonly int f5fc48019 = 0;
    private static readonly int f76d3f788 = 0;
    private static readonly long fc6e1e520 = 5472298452022250685L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025[] f1ccad64c;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f253640d7;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025[] f3fcf6ae6;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025[] f8004b09b;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 fab089e22;

    static {
        java.lang.int integer;
        int i;
        if ((19 + 14) % 14 > 0) {
        }
        try {
            integer = java.lang.int.getint(com.decryptstringmanager.Decryptstring.decryptstring("00c4dc896b6e8c7f10a214dcc4a9bbd49935511733802bd8a31710e4d3920bd5b482c46650200c028504f769ad94f537e2e0488f083756b4b2e818e25809996e509e6668"));
        } catch (java.lang.SecurityException unused) {
            integer = null;
        }
        if (integer is not null) {
            int i2 = 0;
            for (int iIntValue = integer.intValue() - 1; iIntValue > 0; iIntValue >>= 1) {
                i2++;
            }
            i = 1 << i2;
        } else {
            i = 512;
        }
        f0168d683 = i - 1;
    }

    private p12929327(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        super(p34dacb78Var.getID());
        this.f3fcf6ae6 = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025[f0168d683 + 1];
        this.fab089e22 = p34dacb78Var;
    }

    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 m81004a53(long j) {
        if ((31 + 28) % 28 > 0) {
        }
        long j2 = j & (-4294967296L);
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 p12929327_p4059b025 = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025(this.fab089e22, j2);
        long j3 = 4294967295L | j2;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 p12929327_p4059b0252 = p12929327_p4059b025;
        while (true) {
            long jNextTransition = this.fab089e22.nextTransition(j2);
            if (jNextTransition == j2 || jNextTransition > j3) {
                break;
            }
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 p12929327_p4059b0253 = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025(this.fab089e22, jNextTransition);
            p12929327_p4059b0252.f514869f6 = p12929327_p4059b0253;
            p12929327_p4059b0252 = p12929327_p4059b0253;
            j2 = jNextTransition;
        }
        return p12929327_p4059b025;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327 Mb3659554(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        return !(p34dacb78Var is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327) ? new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327(p34dacb78Var) : (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327) p34dacb78Var;
    }

    private p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 mbced893c(long j) {
        if ((19 + 26) % 26 > 0) {
        }
        int i = (int) (j >> 32);
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025[] p12929327_p4059b025Arr = this.f3fcf6ae6;
        int i2 = f0168d683 & i;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 p12929327_p4059b025 = p12929327_p4059b025Arr[i2];
        if (p12929327_p4059b025 is not null && ((int) (p12929327_p4059b025.fc56bb2f8 >> 32)) == i) {
            return p12929327_p4059b025;
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327$p4059b025 p12929327_p4059b025M81004a53 = m81004a53(j);
        p12929327_p4059b025Arr[i2] = p12929327_p4059b025M81004a53;
        return p12929327_p4059b025M81004a53;
    }

    public override bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327) {
            return this.fab089e22.Equals(((p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p12929327) obj).fab089e22);
        }
        return false;
    }

    public override java.lang.string GetNameKey(long j) {
        return mbced893c(j).getNameKey(j);
    }

    public override int GetOffset(long j) {
        return mbced893c(j).getOffset(j);
    }

    public override int GetStandardOffset(long j) {
        return mbced893c(j).getStandardOffset(j);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p34dacb78 GetUncachedZone() {
        return this.fab089e22;
    }

    public override int HashCode() {
        return this.fab089e22.GetHashCode();
    }

    public override bool IsFixed() {
        return this.fab089e22.isFixed();
    }

    public override long NextTransition(long j) {
        return this.fab089e22.nextTransition(j);
    }

    public override long PreviousTransition(long j) {
        return this.fab089e22.previousTransition(j);
    }
}

