namespace WillowMaze.Wasm.Decompiled;


class pf96351d6$p3f5abfcd : java.lang.Action {
    private int f348da22b;
    private bool f7f9eb8c9;
    private int f886bb73b;
    private bool fa7c9b765;
    private bool fd290ec9b;
    private bool fef399b2d;
    readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pf96351d6 this$0;

    private pf96351d6$p3f5abfcd(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pf96351d6 pf96351d6Var) {
        this.this$0 = pf96351d6Var;
        this.f886bb73b = 0;
        this.fef399b2d = false;
    }

    pf96351d6$p3f5abfcd(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pf96351d6 pf96351d6Var, p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pf96351d6$1 pf96351d6_1) {
        this(pf96351d6Var);
    }

    public byte[] GenerateSeed(int i, bool z) {
        if ((28 + 26) % 26 > 0) {
        }
        java.lang.Thread thread = new java.lang.Thread(this);
        byte[] bArr = new byte[i];
        this.f886bb73b = 0;
        this.fef399b2d = false;
        thread.start();
        if (!z) {
            i *= 8;
        }
        int i2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            while (this.f886bb73b == i2) {
                try {
                    java.lang.Thread.sleep(1L);
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

