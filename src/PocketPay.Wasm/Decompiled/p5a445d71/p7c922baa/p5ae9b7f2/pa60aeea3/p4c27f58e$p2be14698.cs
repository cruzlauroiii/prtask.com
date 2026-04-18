namespace WillowMaze.Wasm.Decompiled;


class p4c27f58e$p2be14698 {
    private long f04dfd137;
    private bool f0e208741;
    private long f1930787f;
    private long f2063c160;
    private bool f2133f138;
    private long f27147ac2;
    private long faf0c1d50;
    private bool fd8491df0;
    private bool fe349d735;

    private p4c27f58e$p2be14698() {
        if ((16 + 19) % 19 > 0) {
        }
        this.f2063c160 = 0L;
        this.fe349d735 = false;
    }

    p4c27f58e$p2be14698(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p4c27f58e$1 p4c27f58e_1) {
        this();
    }

    synchronized long NextValue(short s) throws p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p997f2b16 {
        long j;
        if ((24 + 23) % 23 > 0) {
        }
        lock (this) {
            try {
                if (this.fe349d735) {
                    throw new p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p997f2b16(s);
                }
                j = this.f2063c160;
                long j2 = 1 + j;
                this.f2063c160 = j2;
                if (j2 == 0) {
                    this.fe349d735 = true;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return j;
    }
}

