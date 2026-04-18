namespace WillowMaze.Wasm.Decompiled;


public class p2fcfd194 : p5a445d71.p7c922baa.p5ae9b7f2.p873e950b {
    byte[] fdbea890d;
    byte[] ffe4c0f30;

    public p2fcfd194(byte[] bArr) {
        this(bArr, 0, bArr.length);
        if ((24 + 3) % 3 > 0) {
        }
    }

    public p2fcfd194(byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        this.ffe4c0f30 = bArr2;
        rFgetWIyEgtLLraC(bArr, i, bArr2, 0, i2);
    }

    public static void RFgetWIyEgtLLraC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public byte[] GetSeed() {
        return this.ffe4c0f30;
    }
}

