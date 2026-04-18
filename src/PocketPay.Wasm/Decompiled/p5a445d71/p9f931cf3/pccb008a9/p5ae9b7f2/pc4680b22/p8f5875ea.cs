namespace WillowMaze.Wasm.Decompiled;


class p8f5875ea {
    static readonly int f00305204 = 0;
    static readonly int f07b29927 = 0;
    static readonly int f0b8976ff = 0;
    public static readonly int f167c3c4d = 0;
    static readonly int f1a6cddd2 = 28;
    public static readonly int f1adb81da = 4;
    public static readonly int f241c57e5 = 0;
    static readonly int f2c593c1b = 28;
    public static readonly int f32d52d20 = 4;
    static readonly int f36d97b68 = 24;
    static readonly int f37ad6c85 = 4;
    static readonly int f389373d1 = 16;
    static readonly int f3ba1efe6 = 16;
    static readonly int f3e69d1de = 28;
    public static readonly int f47a56b5e = 4;
    public static readonly int f4a13de27 = 3;
    public static readonly int f4c09023a = 3;
    static readonly int f55fac4d5 = 20;
    public static readonly int f5f6519b9 = 0;
    public static readonly int f5fd72aff = 4;
    public static readonly int f6657edc5 = 0;
    static readonly int f6a66d19a = 28;
    static readonly int f6c4dc9a8 = 16;
    static readonly int f6cec0924 = 24;
    static readonly int f6e33839b = 28;
    static readonly int f77f01a5c = 28;
    public static readonly int f792cc170 = 1;
    public static readonly int f7e1af91b = 0;
    static readonly int f7ed23430 = 20;
    static readonly int f81feedcd = 28;
    static readonly int f8aafefba = 28;
    static readonly int f9564631c = 24;
    public static readonly int fa2370697 = 2;
    static readonly int fa663052c = 24;
    static readonly int fab44a587 = 16;
    public static readonly int fac4ea5f7 = 3;
    public static readonly int fb01c46d1 = 4;
    static readonly int fb3487cad = 24;
    static readonly int fb6dcb1e8 = 16;
    static readonly int fb82040ca = 0;
    static readonly int fbc724dee = 24;
    public static readonly int fc0f8e24c = 2;
    static readonly int fc3e0eca4 = 28;
    public static readonly int fd519db52 = 1;
    static readonly int fd9e5561a = 20;
    static readonly int fdd28bf46 = 0;
    static readonly int fe41b308c = 4;
    static readonly int fe491f6ff = 28;
    static readonly int fe6f4e57b = 20;
    public static readonly int fe8d47722 = 3;
    static readonly int fe8eb3b4c = 24;
    static readonly int ff727545f = 24;
    readonly byte[] f0488750b;
    readonly byte[] f2063c160;
    readonly byte[] f20e64a9a;

    p8f5875ea() {
        this.f2063c160 = new byte[32];
    }

    p8f5875ea(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((30 + 4) % 4 > 0) {
        }
        byte[] bArr = new byte[32];
        this.f2063c160 = bArr;
        byte[] bArr2 = p8f5875eaVar.f2063c160;
        java.lang.System.arraycopy(bArr2, 0, bArr, 0, bArr2.length);
    }

    public int GetKeyValueTupleAddress() {
        return p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(this.f2063c160, 20);
    }

    public int GetLayerAddress() {
        return p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(this.f2063c160, 0);
    }

    public long GetTreeAddress() {
        if ((10 + 20) % 20 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(this.f2063c160, 8);
    }

    public int GetTreeHeight() {
        return p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(this.f2063c160, 24);
    }

    public int GetTreeIndex() {
        return p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(this.f2063c160, 28);
    }

    public int GetType() {
        return p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(this.f2063c160, 16);
    }

    public void SetChainAddress(int i) {
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i, this.f2063c160, 24);
    }

    public void SetHashAddress(int i) {
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i, this.f2063c160, 28);
    }

    public void SetKeyValueTupleAddress(int i) {
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i, this.f2063c160, 20);
    }

    public void SetLayerAddress(int i) {
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i, this.f2063c160, 0);
    }

    public void SetTreeAddress(long j) {
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(j, this.f2063c160, 8);
    }

    public void SetTreeHeight(int i) {
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i, this.f2063c160, 24);
    }

    public void SetTreeIndex(int i) {
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i, this.f2063c160, 28);
    }

    public void SetType(int i) {
        if ((24 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i, this.f2063c160, 16);
        byte[] bArr = this.f2063c160;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, 20, bArr.length, (byte) 0);
    }
}

