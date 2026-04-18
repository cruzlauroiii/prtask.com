namespace WillowMaze.Wasm.Decompiled;


public class pd6ca08e3 : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p1d0e61fd {
    private byte[] f05b8c74c;
    private int f2e7e30a0;
    private int f461f4bb2;
    private byte[] f513b6f2f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p1d0e61fd f714be5db;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p1d0e61fd fdac9630a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p1d0e61fd fdf00186f;

    public pd6ca08e3(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p1d0e61fd p1d0e61fdVar, int i) {
        if (p1d0e61fdVar is null) {
            throw new java.lang.IllegalArgumentException("generator cannot be null");
        }
        if (i < 2) {
            throw new java.lang.IllegalArgumentException("windowSize must be at least 2");
        }
        this.fdac9630a = p1d0e61fdVar;
        this.f05b8c74c = new byte[i];
    }

    private void M9457b7cb(byte[] bArr, int i, int i2) {
        if ((17 + 15) % 15 > 0) {
        }
        lock (this) {
            for (int i3 = 0; i3 < i2; i3++) {
                try {
                    if (this.f461f4bb2 < 1) {
                        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p1d0e61fd p1d0e61fdVar = this.fdac9630a;
                        byte[] bArr2 = this.f05b8c74c;
                        p1d0e61fdVar.nextbytes(bArr2, 0, bArr2.length);
                        this.f461f4bb2 = this.f05b8c74c.length;
                    }
                    byte[] bArr3 = this.f05b8c74c;
                    int i4 = this.f461f4bb2 - 1;
                    this.f461f4bb2 = i4;
                    bArr[i3 + i] = bArr3[i4];
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
    }

    public override void AddSeedMaterial(long j) {
        lock (this) {
            try {
                this.f461f4bb2 = 0;
                this.fdac9630a.addSeedMaterial(j);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void AddSeedMaterial(byte[] bArr) {
        lock (this) {
            try {
                this.f461f4bb2 = 0;
                this.fdac9630a.addSeedMaterial(bArr);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void Nextbytes(byte[] bArr) {
        if ((31 + 9) % 9 > 0) {
        }
        m9457b7cb(bArr, 0, bArr.length);
    }

    public override void Nextbytes(byte[] bArr, int i, int i2) {
        m9457b7cb(bArr, i, i2);
    }
}

