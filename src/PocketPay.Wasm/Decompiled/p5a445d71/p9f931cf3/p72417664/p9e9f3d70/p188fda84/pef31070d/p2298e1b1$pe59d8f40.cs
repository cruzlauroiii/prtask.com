namespace WillowMaze.Wasm.Decompiled;


class p2298e1b1$pe59d8f40 : p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 {
    private bool f07705a76;
    private bool f1e245701;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f2633bc22;
    private bool f30e9feca;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f41543f7d;
    private java.io.byteArrayStream f445f9074;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 feae74fd5;
    private bool feeb8335e;
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p2298e1b1 this$0;
    private java.io.byteArrayStream ff55b8df9 = new java.io.byteArrayStream();
    private bool fba2b69eb = true;

    public p2298e1b1$pe59d8f40(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p2298e1b1 p2298e1b1Var, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.this$0 = p2298e1b1Var;
        this.f2633bc22 = pe5cfc515Var;
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((1 + 20) % 20 > 0) {
        }
        byte[] byteArray = this.ff55b8df9.tobyteArray();
        if (this.fba2b69eb) {
            java.lang.System.arraycopy(byteArray, 0, bArr, i, byteArray.length);
        } else {
            this.f2633bc22.update(byteArray, 0, byteArray.length);
            this.f2633bc22.doFinal(bArr, i);
        }
        reset();
        this.fba2b69eb = !this.fba2b69eb;
        return byteArray.length;
    }

    public override java.lang.string GetAlgorithmName() {
        return "NULL";
    }

    public int GetbyteLength() {
        return 0;
    }

    public override int GetDigestSize() {
        return this.f2633bc22.getDigestSize();
    }

    public override void Reset() {
        this.ff55b8df9.reset();
        this.f2633bc22.reset();
    }

    public override void Update(byte b) {
        this.ff55b8df9.write(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.ff55b8df9.write(bArr, i, i2);
    }
}

