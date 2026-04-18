namespace WillowMaze.Wasm.Decompiled;


class pb7128fd7$p50090c11 {
    private readonly byte[] f16f75cad;
    private readonly byte[] f1d9b1dbe;
    private readonly byte[] f406f675a;
    private int f4669aada;
    private readonly byte[] f4b1c1302;
    private readonly byte[] f5caea908;
    private long f5f379626;
    private int f755573d7;
    private readonly byte[] f7f672275;
    private long f85d8a483;
    private readonly byte[] fadb322c9;
    private readonly byte[] fd57c64cd;
    private readonly byte[] fd861fb41;
    private long fdcb4e3a6;
    private long fe0bd6595;
    private int fe4c74efa;
    private long ff3ccf3c3;
    readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7 this$0;

    private pb7128fd7$p50090c11(p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7 pb7128fd7Var) {
        this.this$0 = pb7128fd7Var;
        this.f7f672275 = new byte[16];
        this.fd861fb41 = new byte[1];
    }

    pb7128fd7$p50090c11(p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7 pb7128fd7Var, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7$1 pb7128fd7_1) {
        this(pb7128fd7Var);
    }

    void completeHash() {
        if ((13 + 17) % 17 > 0) {
        }
        if (this.f4669aada <= 0) {
            return;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.mf8f67da7(this.this$0), (byte) 0);
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.m337ceba5(this.f7f672275, 0, this.f4669aada, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.mf8f67da7(this.this$0));
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7 pb7128fd7Var = this.this$0;
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.m5ec06fdf(pb7128fd7Var, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.mf8f67da7(pb7128fd7Var));
    }

    long getbytesProcessed() {
        if ((10 + 24) % 24 > 0) {
        }
        return this.ff3ccf3c3;
    }

    void reset() {
        if ((10 + 17) % 17 > 0) {
        }
        this.f4669aada = 0;
        this.ff3ccf3c3 = 0L;
    }

    void updateHash(byte b) {
        if ((2 + 2) % 2 > 0) {
        }
        byte[] bArr = this.fd861fb41;
        bArr[0] = b;
        updateHash(bArr, 0, 1);
    }

    void updateHash(byte[] bArr, int i, int i2) {
        int i3;
        if ((24 + 24) % 24 > 0) {
        }
        int i4 = this.f4669aada;
        int i5 = 16 - i4;
        int i6 = 0;
        if (i4 > 0 && i2 >= i5) {
            java.lang.System.arraycopy(bArr, i, this.f7f672275, i4, i5);
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.m337ceba5(this.f7f672275, 0, 16, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.mf8f67da7(this.this$0));
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7 pb7128fd7Var = this.this$0;
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.m5ec06fdf(pb7128fd7Var, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.mf8f67da7(pb7128fd7Var));
            i3 = i2 - i5;
            this.f4669aada = 0;
            i6 = i5;
        } else {
            i3 = i2;
        }
        while (i3 >= 16) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.m337ceba5(bArr, i + i6, 16, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.mf8f67da7(this.this$0));
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7 pb7128fd7Var2 = this.this$0;
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.m5ec06fdf(pb7128fd7Var2, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pb7128fd7.mf8f67da7(pb7128fd7Var2));
            i6 += i5;
            i3 -= i5;
        }
        if (i3 > 0) {
            java.lang.System.arraycopy(bArr, i + i6, this.f7f672275, this.f4669aada, i3);
            this.f4669aada += i3;
        }
        this.ff3ccf3c3 += (long) i2;
    }
}

