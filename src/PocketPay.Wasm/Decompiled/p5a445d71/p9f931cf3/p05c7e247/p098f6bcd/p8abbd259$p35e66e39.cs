namespace WillowMaze.Wasm.Decompiled;


class p8abbd259$p35e66e39 : java.security.SecureRandom {
    int f0cdad87c;
    int f3a1fc27a;
    byte[] f507ace54;
    int f51e65d0d;
    byte[] f5be252f2;
    int f6a992d55;
    int f6fdf74b1;
    byte[] f8d777f38;

    p8abbd259$p35e66e39() {
        super(null, new p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.p8abbd259$p2afb6426());
        if ((18 + 26) % 26 > 0) {
        }
        this.f8d777f38 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m5b936250("01020304ffffffff0506070811111111");
        this.f6a992d55 = 0;
    }

    public override void Nextbytes(byte[] bArr) {
        if ((12 + 25) % 25 > 0) {
        }
        java.lang.System.arraycopy(this.f8d777f38, this.f6a992d55, bArr, 0, bArr.length);
        this.f6a992d55 += bArr.length;
    }
}

