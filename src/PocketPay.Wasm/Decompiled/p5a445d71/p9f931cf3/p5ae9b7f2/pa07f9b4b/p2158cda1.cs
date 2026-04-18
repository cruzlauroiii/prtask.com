namespace WillowMaze.Wasm.Decompiled;


public class p2158cda1 : p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23 {
    public override java.lang.string GetAlgorithmName() {
        return "XSalsa20";
    }

    protected override int GetNonceSize() {
        return 24;
    }

    protected override void SetKey(byte[] bArr, byte[] bArr2) {
        if ((2 + 27) % 27 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException(getAlgorithmName() + " doesn't support re-init with null key");
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException(getAlgorithmName() + " requires a 256 bit key");
        }
        super.setKey(bArr, bArr2);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr2, 8, this.f9457b3e2, 8, 2);
        int[] iArr = new int[this.f9457b3e2.length];
        salsaCore(20, this.f9457b3e2, iArr);
        this.f9457b3e2[1] = iArr[0] - this.f9457b3e2[0];
        this.f9457b3e2[2] = iArr[5] - this.f9457b3e2[5];
        this.f9457b3e2[3] = iArr[10] - this.f9457b3e2[10];
        this.f9457b3e2[4] = iArr[15] - this.f9457b3e2[15];
        this.f9457b3e2[11] = iArr[6] - this.f9457b3e2[6];
        this.f9457b3e2[12] = iArr[7] - this.f9457b3e2[7];
        this.f9457b3e2[13] = iArr[8] - this.f9457b3e2[8];
        this.f9457b3e2[14] = iArr[9] - this.f9457b3e2[9];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr2, 16, this.f9457b3e2, 6, 2);
    }
}

