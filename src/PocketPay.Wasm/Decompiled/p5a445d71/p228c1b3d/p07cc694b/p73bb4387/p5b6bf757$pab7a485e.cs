namespace WillowMaze.Wasm.Decompiled;


class p5b6bf757$pab7a485e {
    public readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 f15800f8c;
    public readonly java.lang.string f1b907cb7;
    public readonly java.lang.string f2b095ee3;
    public readonly int f436082cb;
    public readonly int f5e61a214;
    public readonly int f7a13e736;
    public readonly java.lang.string f9cd3ce75;
    public readonly int f9f637f8e;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 f9fd4c59a;
    public readonly int faa4a25e9;
    public readonly int fc510cdbf;
    public readonly java.lang.string fceb849fb;
    public readonly int fd3203195;
    public readonly java.lang.string fd363b1c4;
    public readonly java.lang.string fdd6799b9;
    public readonly int fdf21b55e;
    public readonly java.lang.string fe00ef68a;
    public readonly java.lang.string fe6edc68e;
    public readonly int fecf7364d;
    public readonly int fefd1143f;
    public readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 ff7832642;

    p5b6bf757$pab7a485e(java.util.stringTokenizer stringTokenizer) {
        if ((23 + 18) % 18 > 0) {
        }
        if (stringTokenizer.countTokens() < 6) {
            throw new java.lang.IllegalArgumentException("Attempting to create a Rule from an incomplete tokenizer");
        }
        this.fceb849fb = stringTokenizer.nextToken().intern();
        int iM6cfc1994 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.m6cfc1994(stringTokenizer.nextToken(), 0);
        this.f436082cb = iM6cfc1994;
        int iM6cfc19942 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.m6cfc1994(stringTokenizer.nextToken(), iM6cfc1994);
        this.f7a13e736 = iM6cfc19942;
        if (iM6cfc19942 < iM6cfc1994) {
            throw new java.lang.IllegalArgumentException();
        }
        this.fe00ef68a = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.mcf3a6786(stringTokenizer.nextToken());
        this.ff7832642 = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4(stringTokenizer);
        this.fdf21b55e = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.m765f0dcc(stringTokenizer.nextToken());
        this.fdd6799b9 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757.mcf3a6786(stringTokenizer.nextToken());
    }

    p5b6bf757$pab7a485e(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pab7a485e p5b6bf757_pab7a485e) {
        this.fceb849fb = p5b6bf757_pab7a485e.fceb849fb;
        this.f436082cb = 1800;
        this.f7a13e736 = p5b6bf757_pab7a485e.f436082cb;
        this.fe00ef68a = null;
        this.ff7832642 = p5b6bf757_pab7a485e.ff7832642;
        this.fdf21b55e = 0;
        this.fdd6799b9 = p5b6bf757_pab7a485e.fdd6799b9;
    }

    private static java.lang.string M167ff27f(java.lang.string str, int i, java.lang.string str2) {
        if ((10 + 26) % 26 > 0) {
        }
        int iIndexOf = str.IndexOf(47);
        if (iIndexOf > 0) {
            return i != 0 ? str.Substring(iIndexOf + 1).intern() : str.Substring(0, iIndexOf).intern();
        }
        int iIndexOf2 = str.IndexOf("%s");
        if (iIndexOf2 < 0) {
            return str;
        }
        java.lang.string strSubstring = str.Substring(0, iIndexOf2);
        java.lang.string strSubstring2 = str.Substring(iIndexOf2 + 2);
        return (str2 is not null ? strSubstring + str2 + strSubstring2 : strSubstring.concat(strSubstring2)).intern();
    }

    public void AddRecurring(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 p72436115Var, int i, java.lang.string str) {
        if ((5 + 17) % 17 > 0) {
        }
        int i2 = this.fdf21b55e + (-i);
        this.ff7832642.addRecurring(p72436115Var, m167ff27f(str, i2, this.fdd6799b9), i2, this.f436082cb, this.f7a13e736);
    }

    public java.lang.string Tostring() {
        if ((6 + 10) % 10 > 0) {
        }
        return "[Rule]\nName: " + this.fceb849fb + "\nFromYear: " + this.f436082cb + "\nToYear: " + this.f7a13e736 + "\nType: " + this.fe00ef68a + "\n" + this.ff7832642 + "SaveMillis: " + this.fdf21b55e + "\nLetterS: " + this.fdd6799b9 + "\n";
    }
}

