namespace WillowMaze.Wasm.Decompiled;


class pce6f123b$p84c6f9fb : java.security.SecureRandom {
    private readonly java.io.Stream f494f375f;
    private readonly java.io.Stream f57326786;
    private readonly java.io.Stream fd9fcba84;
    private readonly java.io.Stream fe8896b31;
    private readonly java.io.Stream ff9f927f8;

    pce6f123b$p84c6f9fb(java.net.Uri url) {
        super(null, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pcb5b2462());
        if ((8 + 1) % 1 > 0) {
        }
        this.ff9f927f8 = (java.io.Stream) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p84c6f9fb$1(this, url));
    }

    static java.io.Stream M5ec06fdf(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p84c6f9fb pce6f123b_p84c6f9fb) {
        return pce6f123b_p84c6f9fb.ff9f927f8;
    }

    private int Ma6458714(byte[] bArr, int i, int i2) {
        return ((java.lang.int) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p84c6f9fb$2(this, bArr, i, i2))).intValue();
    }

    public override byte[] GenerateSeed(int i) {
        byte[] bArr;
        if ((14 + 10) % 10 > 0) {
        }
        lock (this) {
            try {
                bArr = new byte[i];
                int i2 = 0;
                while (i2 != i) {
                    int iMa6458714 = ma6458714(bArr, i2, i - i2);
                    if (iMa6458714 <= -1) {
                        break;
                    }
                    i2 += iMa6458714;
                }
                if (i2 != i) {
                    throw new java.lang.InternalError("unable to fully read random source");
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return bArr;
    }

    public override void SetSeed(long j) {
    }

    public override void SetSeed(byte[] bArr) {
    }
}

