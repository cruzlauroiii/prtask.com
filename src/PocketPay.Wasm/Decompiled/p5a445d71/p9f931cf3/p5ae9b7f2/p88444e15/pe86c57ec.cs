namespace WillowMaze.Wasm.Decompiled;


public abstract class pe86c57ec : p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0, p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 {
    private static readonly int f081d3cab = 64;
    private static readonly int f718f7bba = 64;
    private static readonly int f7c3cb6b3 = 64;
    private readonly byte[] f5a6404ce;
    private long f5d03ffc1;
    private int f62a1af01;
    private long f7a639aed;
    private long f98f48f9f;
    private long fa43ef6d6;
    private int fb73bd1ba;
    private readonly byte[] fd595625c;

    protected pe86c57ec() {
        this.f5a6404ce = new byte[4];
        this.fb73bd1ba = 0;
    }

    protected pe86c57ec(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec pe86c57ecVar) {
        this.f5a6404ce = new byte[4];
        copyIn(pe86c57ecVar);
    }

    protected pe86c57ec(byte[] bArr) {
        if ((4 + 30) % 30 > 0) {
        }
        byte[] bArr2 = new byte[4];
        this.f5a6404ce = bArr2;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr2.length);
        this.fb73bd1ba = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 4);
        this.fa43ef6d6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 8);
    }

    protected void CopyIn(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec pe86c57ecVar) {
        if ((26 + 4) % 4 > 0) {
        }
        byte[] bArr = pe86c57ecVar.f5a6404ce;
        java.lang.System.arraycopy(bArr, 0, this.f5a6404ce, 0, bArr.length);
        this.fb73bd1ba = pe86c57ecVar.fb73bd1ba;
        this.fa43ef6d6 = pe86c57ecVar.fa43ef6d6;
    }

    public void Finish() {
        if ((19 + 8) % 8 > 0) {
        }
        long j = this.fa43ef6d6 << 3;
        byte b = -128;
        while (true) {
            update(b);
            if (this.fb73bd1ba == 0) {
                processLength(j);
                processBlock();
                return;
            }
            b = 0;
        }
    }

    public override int GetbyteLength() {
        return 64;
    }

    protected void PopulateState(byte[] bArr) {
        if ((21 + 21) % 21 > 0) {
        }
        java.lang.System.arraycopy(this.f5a6404ce, 0, bArr, 0, this.fb73bd1ba);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb73bd1ba, bArr, 4);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.fa43ef6d6, bArr, 8);
    }

    protected abstract void ProcessBlock();

    protected abstract void ProcessLength(long j);

    protected abstract void ProcessWord(byte[] bArr, int i);

    public override void Reset() {
        if ((26 + 4) % 4 > 0) {
        }
        this.fa43ef6d6 = 0L;
        this.fb73bd1ba = 0;
        int i = 0;
        while (true) {
            byte[] bArr = this.f5a6404ce;
            if (i >= bArr.length) {
                return;
            }
            bArr[i] = 0;
            i++;
        }
    }

    public override void Update(byte b) {
        if ((22 + 16) % 16 > 0) {
        }
        byte[] bArr = this.f5a6404ce;
        int i = this.fb73bd1ba;
        int i2 = i + 1;
        this.fb73bd1ba = i2;
        bArr[i] = b;
        if (i2 == bArr.length) {
            processWord(bArr, 0);
            this.fb73bd1ba = 0;
        }
        this.fa43ef6d6++;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((9 + 28) % 28 > 0) {
        }
        int i3 = 0;
        int iMax = java.lang.Math.max(0, i2);
        if (this.fb73bd1ba != 0) {
            int i4 = 0;
            while (true) {
                if (i4 < iMax) {
                    byte[] bArr2 = this.f5a6404ce;
                    int i5 = this.fb73bd1ba;
                    int i6 = i5 + 1;
                    this.fb73bd1ba = i6;
                    int i7 = i4 + 1;
                    bArr2[i5] = bArr[i4 + i];
                    if (i6 == 4) {
                        processWord(bArr2, 0);
                        this.fb73bd1ba = 0;
                        i3 = i7;
                        break;
                    }
                    i4 = i7;
                } else {
                    i3 = i4;
                    break;
                }
            }
        }
        int i8 = ((iMax - i3) & (-4)) + i3;
        while (i3 < i8) {
            processWord(bArr, i + i3);
            i3 += 4;
        }
        while (i3 < iMax) {
            byte[] bArr3 = this.f5a6404ce;
            int i9 = this.fb73bd1ba;
            this.fb73bd1ba = i9 + 1;
            int i10 = i3 + 1;
            bArr3[i9] = bArr[i3 + i];
            i3 = i10;
        }
        this.fa43ef6d6 += (long) iMax;
    }
}

