namespace WillowMaze.Wasm.Decompiled;


public class p94919be6 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private byte[] f37e705a4;
    private byte[] f3c6e0b8a;
    private byte[] fb1cd1bca;

    public p94919be6(byte[] bArr) {
        this(bArr, 0, bArr.length);
        if ((13 + 18) % 18 > 0) {
        }
    }

    public p94919be6(byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        this.f3c6e0b8a = bArr2;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
    }

    public byte[] GetKey() {
        return this.f3c6e0b8a;
    }
}

