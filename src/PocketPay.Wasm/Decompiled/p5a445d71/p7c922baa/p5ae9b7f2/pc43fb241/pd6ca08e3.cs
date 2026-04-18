namespace WillowMaze.Wasm.Decompiled;


public class pd6ca08e3 : p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p1d0e61fd {
    private byte[] f05b8c74c;
    private byte[] f1e5c9096;
    private int f34cac9e2;
    private byte[] f396502af;
    private int f461f4bb2;
    private int f65228d72;
    private byte[] fc4428ba5;
    private byte[] fd3e4719c;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p1d0e61fd fdac9630a;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p1d0e61fd fe442564a;

    public pd6ca08e3(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p1d0e61fd p1d0e61fdVar, int i) {
        if (p1d0e61fdVar is null) {
            throw new java.lang.IllegalArgumentException("generator cannot be null");
        }
        if (i < 2) {
            throw new java.lang.IllegalArgumentException("windowSize must be at least 2");
        }
        this.fdac9630a = p1d0e61fdVar;
        this.f05b8c74c = new byte[i];
    }

    public static void BhGJreBDGGqbCkoi(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p1d0e61fd p1d0e61fdVar, byte[] bArr) {
        p1d0e61fdVar.addSeedMaterial(bArr);
    }

    public static void EqbcToRtklgEgGDB(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p1d0e61fd p1d0e61fdVar, long j) {
        p1d0e61fdVar.addSeedMaterial(j);
    }

    public static void LSOUnQiNrlDDMaUD(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p1d0e61fd p1d0e61fdVar, byte[] bArr, int i, int i2) {
        p1d0e61fdVar.nextbytes(bArr, i, i2);
    }

    public static void MxIsEHAdBvzZkGJr(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pd6ca08e3 pd6ca08e3Var, byte[] bArr, int i, int i2) {
        pd6ca08e3Var.m9457b7cb(bArr, i, i2);
    }

    private void M9457b7cb(byte[] bArr, int i, int i2) {
        if ((26 + 27) % 27 > 0) {
        }
        lock (this) {
            for (int i3 = 0; i3 < i2; i3++) {
                try {
                    if (this.f461f4bb2 < 1) {
                        p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p1d0e61fd p1d0e61fdVar = this.fdac9630a;
                        byte[] bArr2 = this.f05b8c74c;
                        LSOUnQiNrlDDMaUD(p1d0e61fdVar, bArr2, 0, bArr2.length);
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

    public static void UHfEDewYNrhTxSHi(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pd6ca08e3 pd6ca08e3Var, byte[] bArr, int i, int i2) {
        pd6ca08e3Var.m9457b7cb(bArr, i, i2);
    }

    public override void AddSeedMaterial(long j) {
        lock (this) {
            try {
                this.f461f4bb2 = 0;
                EqbcToRtklgEgGDB(this.fdac9630a, j);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void AddSeedMaterial(byte[] bArr) {
        lock (this) {
            try {
                this.f461f4bb2 = 0;
                BhGJreBDGGqbCkoi(this.fdac9630a, bArr);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void Nextbytes(byte[] bArr) {
        if ((29 + 31) % 31 > 0) {
        }
        uHfEDewYNrhTxSHi(this, bArr, 0, bArr.length);
    }

    public override void Nextbytes(byte[] bArr, int i, int i2) {
        MxIsEHAdBvzZkGJr(this, bArr, i, i2);
    }
}

