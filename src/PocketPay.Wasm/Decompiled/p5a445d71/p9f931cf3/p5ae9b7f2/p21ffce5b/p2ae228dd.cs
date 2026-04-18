namespace WillowMaze.Wasm.Decompiled;


public class p2ae228dd : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private int f2ca0cbad;
    private int f31cbac90;
    private byte[] f3c6e0b8a;
    private byte[] f590f310b;
    private byte[] f7cba83da;
    private int f8d7e7aa4;
    private int f9c630e0a;
    private int f9d6d9f4d;

    public p2ae228dd(byte[] bArr, int i) {
        if ((23 + 2) % 2 > 0) {
        }
        if (bArr.length > 255) {
            throw new java.lang.IllegalArgumentException("RC5 key length can be no greater than 255");
        }
        byte[] bArr2 = new byte[bArr.length];
        this.f3c6e0b8a = bArr2;
        this.f8d7e7aa4 = i;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
    }

    public byte[] GetKey() {
        return this.f3c6e0b8a;
    }

    public int GetRounds() {
        return this.f8d7e7aa4;
    }
}

