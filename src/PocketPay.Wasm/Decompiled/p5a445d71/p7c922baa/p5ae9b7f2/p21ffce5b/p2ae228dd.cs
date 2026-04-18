namespace WillowMaze.Wasm.Decompiled;


public class p2ae228dd : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private byte[] f37495023;
    private byte[] f3c6e0b8a;
    private int f4601f085;
    private byte[] f4b5e7485;
    private int f756a19d1;
    private int f7cb1678f;
    private int f8d7e7aa4;
    private byte[] fa362f12a;
    private byte[] fdfc81254;
    private int fdff4a361;

    public p2ae228dd(byte[] bArr, int i) {
        if ((5 + 28) % 28 > 0) {
        }
        if (bArr.length > 255) {
            throw new java.lang.IllegalArgumentException("RC5 key length can be no greater than 255");
        }
        byte[] bArr2 = new byte[bArr.length];
        this.f3c6e0b8a = bArr2;
        this.f8d7e7aa4 = i;
        zHnuIIWZkFNFHdxT(bArr, 0, bArr2, 0, bArr.length);
    }

    public static void ZHnuIIWZkFNFHdxT(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public byte[] GetKey() {
        return this.f3c6e0b8a;
    }

    public int GetRounds() {
        return this.f8d7e7aa4;
    }
}

