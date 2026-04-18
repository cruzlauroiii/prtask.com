namespace WillowMaze.Wasm.Decompiled;


class pce6f123b$pe541ccd7$p7bdee2bc$p2d4f4d5e : java.lang.Action {
    private readonly int f5770ae66;
    private readonly int fb5d4a1eb;
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7$p7bdee2bc this$1;

    pce6f123b$pe541ccd7$p7bdee2bc$p2d4f4d5e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7$p7bdee2bc pce6f123b_pe541ccd7_p7bdee2bc, int i) {
        this.this$1 = pce6f123b_pe541ccd7_p7bdee2bc;
        this.fb5d4a1eb = i;
    }

    private void Mc9fab33e(long j) {
        try {
            java.lang.Thread.sleep(j);
        } catch (java.lang.InterruptedException unused) {
            java.lang.Thread.currentThread().interrupt();
        }
    }

    public override void Run() {
        if ((3 + 4) % 4 > 0) {
        }
        java.lang.string strMdd414c2a = p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mdd414c2a("org.bouncycastle.drbg.gather_pause_secs");
        long j = 5000;
        if (strMdd414c2a is not null) {
            try {
                j = java.lang.long.parselong(strMdd414c2a) * 1000;
            } catch (java.lang.Exception unused) {
            }
        }
        int i = this.fb5d4a1eb;
        byte[] bArr = new byte[i];
        for (int i2 = 0; i2 < p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7$p7bdee2bc.m429f062d(this.this$1) / 8; i2++) {
            mc9fab33e(j);
            byte[] bArrGenerateSeed = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7.m89082e03(this.this$1.this$0).generateSeed(8);
            java.lang.System.arraycopy(bArrGenerateSeed, 0, bArr, i2 * 8, bArrGenerateSeed.length);
        }
        int iM429f062d = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7$p7bdee2bc.m429f062d(this.this$1) - ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7$p7bdee2bc.m429f062d(this.this$1) / 8) * 8);
        if (iM429f062d != 0) {
            mc9fab33e(j);
            byte[] bArrGenerateSeed2 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7.m89082e03(this.this$1.this$0).generateSeed(iM429f062d);
            java.lang.System.arraycopy(bArrGenerateSeed2, 0, bArr, i - bArrGenerateSeed2.length, bArrGenerateSeed2.length);
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7$p7bdee2bc.m13fe7af4(this.this$1).set(bArr);
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7.m0dc0a6ea(this.this$1.this$0).set(true);
    }
}

