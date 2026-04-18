namespace WillowMaze.Wasm.Decompiled;


class p9952cbca$p4c2a8fe7 {
    private readonly int f1c9fe835;
    private readonly short f486af403;
    private readonly byte[] f65097f09;
    private readonly int f6b546849;
    private readonly short f73936967;
    private readonly int f7417cb2c;
    private readonly byte[] f841a2d68;
    private readonly byte[] f90bdefb5;
    private readonly int f995d73cb;
    private readonly short fbaf0d203;
    private readonly byte[] fd8deedf1;
    private readonly short fe91704f0;
    private readonly short ff0f06b8a;

    private p9952cbca$p4c2a8fe7(int i, short s, byte[] bArr) {
        this.f1c9fe835 = i;
        this.f486af403 = s;
        this.f841a2d68 = bArr;
    }

    p9952cbca$p4c2a8fe7(int i, short s, byte[] bArr, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p9952cbca$1 p9952cbca_1) {
        this(i, s, bArr);
    }

    public byte[] GetBody() {
        return this.f841a2d68;
    }

    public int GetSeq() {
        return this.f1c9fe835;
    }

    public short GetType() {
        return this.f486af403;
    }
}

