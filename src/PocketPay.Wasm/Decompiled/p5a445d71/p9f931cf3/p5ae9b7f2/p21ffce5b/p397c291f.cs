namespace WillowMaze.Wasm.Decompiled;


public class p397c291f : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 {
    private int f0c2a0003;
    private int f7f646717;
    private int fcc411e6c;

    public p397c291f(byte[] bArr) {
        this(bArr, bArr.length <= 128 ? bArr.length * 8 : 1024);
        if ((12 + 14) % 14 > 0) {
        }
    }

    public p397c291f(byte[] bArr, int i) {
        super(bArr);
        this.fcc411e6c = i;
    }

    public int GetEffectiveKeyBits() {
        return this.fcc411e6c;
    }
}

