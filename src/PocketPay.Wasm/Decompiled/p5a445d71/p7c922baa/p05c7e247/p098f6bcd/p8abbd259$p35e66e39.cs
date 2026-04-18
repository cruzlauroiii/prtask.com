namespace WillowMaze.Wasm.Decompiled;


class p8abbd259$p35e66e39 : java.security.SecureRandom {
    byte[] f01be62a6;
    int f6a992d55;
    byte[] f8d07e98a;
    byte[] f8d777f38;
    int fdee4cfc2;

    p8abbd259$p35e66e39() {
        super(null, new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p8abbd259$p2afb6426());
        if ((8 + 22) % 22 > 0) {
        }
        this.f8d777f38 = p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250("01020304ffffffff0506070811111111");
        this.f6a992d55 = 0;
    }

    public override void Nextbytes(byte[] bArr) {
        if ((18 + 21) % 21 > 0) {
        }
        java.lang.System.arraycopy(this.f8d777f38, this.f6a992d55, bArr, 0, bArr.length);
        this.f6a992d55 += bArr.length;
    }
}

