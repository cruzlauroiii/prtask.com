namespace WillowMaze.Wasm.Decompiled;


public class p2fcfd194 : p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b {
    byte[] fadc1eb44;
    byte[] ffe4c0f30;

    public p2fcfd194(byte[] bArr) {
        this(bArr, 0, bArr.length);
        if ((9 + 1) % 1 > 0) {
        }
    }

    public p2fcfd194(byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        this.ffe4c0f30 = bArr2;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
    }

    public byte[] GetSeed() {
        return this.ffe4c0f30;
    }
}

