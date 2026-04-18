namespace WillowMaze.Wasm.Decompiled;


public class p2cbc6177 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private byte[] f0f1d38e2;
    private byte[] f22d9e485;
    private int f26da86ed;
    private int f5ee1bfd2;
    private int f68f6fa5f;
    private byte[] f6b4369fa;
    private byte[] f84bea1f0;
    private byte[] fb600b140;
    private byte[] fd4dc31cc;
    private int fec983a13;
    private int ffae95a7f;
    private byte[] ffb0dc05d;

    public p2cbc6177(byte[] bArr, byte[] bArr2, int i) {
        this.fb600b140 = bArr;
        this.f84bea1f0 = bArr2;
        this.fec983a13 = i;
    }

    public byte[] GetDerivationV() {
        return this.fb600b140;
    }

    public byte[] GetEncodingV() {
        return this.f84bea1f0;
    }

    public int GetMacKeySize() {
        return this.fec983a13;
    }
}

