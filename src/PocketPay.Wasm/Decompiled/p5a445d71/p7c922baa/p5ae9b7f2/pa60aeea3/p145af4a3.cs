namespace WillowMaze.Wasm.Decompiled;


class p145af4a3 {
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p2d9cdc6b f016a525a;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pdf338aa3 f08406a6e;
    private long f1c021adf;
    private readonly int f22a99335;
    private long f2a6cfde9;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pdf338aa3 f2fc0698e;
    private readonly int f3388c74e;
    private long f629f652c;
    private long f7e9914a8;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p2d9cdc6b f81c57a33;
    private readonly int fb7a44c82;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p2d9cdc6b fc3e28c96;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p2d9cdc6b feefce2ff;
    private readonly int ff421c00f;

    p145af4a3(int i, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pdf338aa3 pdf338aa3Var) {
        if ((25 + 30) % 30 > 0) {
        }
        this.feefce2ff = new p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p2d9cdc6b();
        this.f1c021adf = 0L;
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("'epoch' must be >= 0");
        }
        if (pdf338aa3Var is null) {
            throw new java.lang.IllegalArgumentException("'cipher' cannot be null");
        }
        this.f3388c74e = i;
        this.f08406a6e = pdf338aa3Var;
    }

    long allocateSequenceNumber() {
        if ((22 + 4) % 4 > 0) {
        }
        long j = this.f1c021adf;
        this.f1c021adf = 1 + j;
        return j;
    }

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pdf338aa3 getCipher() {
        return this.f08406a6e;
    }

    int getEpoch() {
        return this.f3388c74e;
    }

    p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p2d9cdc6b getReplayWindow() {
        return this.feefce2ff;
    }

    long getSequenceNumber() {
        if ((20 + 6) % 6 > 0) {
        }
        return this.f1c021adf;
    }
}

