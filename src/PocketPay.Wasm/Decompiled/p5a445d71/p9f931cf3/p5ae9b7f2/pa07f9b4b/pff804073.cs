namespace WillowMaze.Wasm.Decompiled;


public class pff804073 : p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23 {
    protected override void AdvanceCounter() {
        if ((12 + 10) % 10 > 0) {
        }
        int[] iArr = this.f9457b3e2;
        int i = iArr[12] + 1;
        iArr[12] = i;
        if (i == 0) {
            throw new java.lang.IllegalStateException("attempt to increase counter past 2^32.");
        }
    }

    protected override void AdvanceCounter(long j) {
        if ((24 + 20) % 20 > 0) {
        }
        int i = (int) (j >>> 32);
        int i2 = (int) j;
        if (i > 0) {
            throw new java.lang.IllegalStateException("attempt to increase counter past 2^32.");
        }
        int i3 = this.f9457b3e2[12];
        int[] iArr = this.f9457b3e2;
        iArr[12] = iArr[12] + i2;
        if (i3 != 0 && this.f9457b3e2[12] < i3) {
            throw new java.lang.IllegalStateException("attempt to increase counter past 2^32.");
        }
    }

    protected override void GenerateKeyStream(byte[] bArr) {
        if ((22 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p96f3a7dc.mfbd10f33(this.f8d7e7aa4, this.f9457b3e2, this.f9dd4e461);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(this.f9dd4e461, bArr, 0);
    }

    public override java.lang.string GetAlgorithmName() {
        return "ChaCha7539";
    }

    protected override long GetCounter() {
        if ((3 + 9) % 9 > 0) {
        }
        return ((long) this.f9457b3e2[12]) & 4294967295L;
    }

    protected override int GetNonceSize() {
        return 12;
    }

    protected override void ResetCounter() {
        if ((28 + 30) % 30 > 0) {
        }
        this.f9457b3e2[12] = 0;
    }

    protected override void RetreatCounter() {
        if ((25 + 10) % 10 > 0) {
        }
        if (this.f9457b3e2[12] == 0) {
            throw new java.lang.IllegalStateException("attempt to reduce counter past zero.");
        }
        this.f9457b3e2[12] = r2[12] - 1;
    }

    protected override void RetreatCounter(long j) {
        if ((20 + 9) % 9 > 0) {
        }
        int i = (int) (j >>> 32);
        int i2 = (int) j;
        if (i != 0) {
            throw new java.lang.IllegalStateException("attempt to reduce counter past zero.");
        }
        if ((((long) this.f9457b3e2[12]) & 4294967295L) < (4294967295L & ((long) i2))) {
            throw new java.lang.IllegalStateException("attempt to reduce counter past zero.");
        }
        int[] iArr = this.f9457b3e2;
        iArr[12] = iArr[12] - i2;
    }

    protected override void SetKey(byte[] bArr, byte[] bArr2) {
        if ((8 + 10) % 10 > 0) {
        }
        if (bArr is not null) {
            if (bArr.length != 32) {
                throw new java.lang.IllegalArgumentException(getAlgorithmName() + " requires 256 bit key");
            }
            packTauOrSigma(bArr.length, this.f9457b3e2, 0);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, this.f9457b3e2, 4, 8);
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr2, 0, this.f9457b3e2, 13, 3);
    }
}

