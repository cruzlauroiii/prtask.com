namespace WillowMaze.Wasm.Decompiled;


class pf96351d6$p3f5abfcd : java.lang.Action {
    private bool f2bdf0c37;
    private int f4f2abb7d;
    private bool f5dbed858;
    private int f886bb73b;
    private int fb4229211;
    private bool fef399b2d;
    readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pf96351d6 this$0;

    private pf96351d6$p3f5abfcd(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pf96351d6 pf96351d6Var) {
        this.this$0 = pf96351d6Var;
        this.f886bb73b = 0;
        this.fef399b2d = false;
    }

    pf96351d6$p3f5abfcd(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pf96351d6 pf96351d6Var, p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pf96351d6$1 pf96351d6_1) {
        this(pf96351d6Var);
    }

    public static void FKVdsCTdocLfltJi(java.lang.Thread thread) {
        thread.start();
    }

    public static void ZvSRZRZNuYlewFDK(long j) throws java.lang.InterruptedException {
        java.lang.Thread.sleep(j);
    }

    public byte[] GenerateSeed(int i, bool z) {
        if ((7 + 26) % 26 > 0) {
        }
        java.lang.Thread thread = new java.lang.Thread(this);
        byte[] bArr = new byte[i];
        this.f886bb73b = 0;
        this.fef399b2d = false;
        FKVdsCTdocLfltJi(thread);
        if (!z) {
            i *= 8;
        }
        int i2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            while (this.f886bb73b == i2) {
                try {
                    ZvSRZRZNuYlewFDK(1L);
                } catch (java.lang.InterruptedException unused) {
                }
            }
            i2 = this.f886bb73b;
            if (z) {
                bArr[i3] = (byte) (i2 & 255);
            } else {
                int i4 = i3 / 8;
                bArr[i4] = (byte) ((bArr[i4] << 1) | (i2 & 1));
            }
        }
        this.fef399b2d = true;
        return bArr;
    }

    public override void Run() {
        while (!this.fef399b2d) {
            this.f886bb73b++;
        }
    }
}

