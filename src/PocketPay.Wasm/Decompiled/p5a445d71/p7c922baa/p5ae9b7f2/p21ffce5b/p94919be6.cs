namespace WillowMaze.Wasm.Decompiled;


public class p94919be6 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private byte[] f3c6e0b8a;
    private byte[] fd9cbdd4a;

    public p94919be6(byte[] bArr) {
        this(bArr, 0, bArr.length);
        if ((3 + 3) % 3 > 0) {
        }
    }

    public p94919be6(byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        this.f3c6e0b8a = bArr2;
        ymfpykrLUsJaLuCw(bArr, i, bArr2, 0, i2);
    }

    public static void YmfpykrLUsJaLuCw(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public byte[] GetKey() {
        return this.f3c6e0b8a;
    }
}

