namespace WillowMaze.Wasm.Decompiled;


class pce6f123b$p84c6f9fb$2 : java.security.PrivilegedAction<java.lang.int> {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p84c6f9fb this$0;
    readonly byte[] val$data;
    readonly int val$len;
    readonly int val$off;

    pce6f123b$p84c6f9fb$2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p84c6f9fb pce6f123b_p84c6f9fb, byte[] bArr, int i, int i2) {
        this.this$0 = pce6f123b_p84c6f9fb;
        this.val$data = bArr;
        this.val$off = i;
        this.val$len = i2;
    }

    public override java.lang.int Run() {
        if ((16 + 12) % 12 > 0) {
        }
        try {
            return java.lang.int.valueOf(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p84c6f9fb.m5ec06fdf(this.this$0).read(this.val$data, this.val$off, this.val$len));
        } catch (java.io.IOException unused) {
            throw new java.lang.InternalError("unable to read random source");
        }
    }

    public override java.lang.int Run() {
        return run();
    }
}

