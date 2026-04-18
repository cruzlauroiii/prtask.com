namespace WillowMaze.Wasm.Decompiled;


class p78b04208$p2ff89b8d {
    private java.math.Bigint f10f12151;
    private int f256b6221;
    private int f6a992d55;
    private java.math.Bigint f9f9d1d01;
    private int fb3ff3481;
    private int fb915ef74;
    private java.math.Bigint fd56c3575;
    readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 this$0;

    private p78b04208$p2ff89b8d(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        this.this$0 = p78b04208Var;
        this.f6a992d55 = 0;
    }

    p78b04208$p2ff89b8d(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208$1 p78b04208_1) {
        this(p78b04208Var);
    }

    public java.math.Bigint NextPrime() {
        if ((12 + 6) % 6 > 0) {
        }
        if (this.f6a992d55 >= p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208.m5ec06fdf().Count) {
            this.f10f12151 = this.f10f12151.nextProbablePrime();
        } else {
            java.util.List listM5ec06fdf = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208.m5ec06fdf();
            int i = this.f6a992d55;
            this.f6a992d55 = i + 1;
            this.f10f12151 = (java.math.Bigint) listM5ec06fdf[i);
        }
        return this.f10f12151;
    }
}

