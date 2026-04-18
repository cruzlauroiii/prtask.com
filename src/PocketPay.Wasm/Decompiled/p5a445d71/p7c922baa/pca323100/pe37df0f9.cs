namespace WillowMaze.Wasm.Decompiled;


class pe37df0f9 : p5a445d71.p7c922baa.pca323100.pc933863a {
    private static readonly byte[] f36ced659 = new byte[0];
    private static readonly byte[] fb911054b = null;
    private readonly int f29060022;
    private int f769e5751;
    private readonly int f7c947a28;
    private readonly int f82eb2248;
    private readonly int f8fce7d95;
    private int f991dddcc;
    private readonly int fd7c024cd;
    private int feb98d1a5;

    pe37df0f9(java.io.Stream inputStream, int i) {
        super(inputStream, i);
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("negative lengths not allowed");
        }
        this.f29060022 = i;
        this.f991dddcc = i;
        if (i != 0) {
            return;
        }
        rKDDrQRNfuOBUEaT(this, true);
    }

    public static java.lang.stringBuilder BJakUUzmXwUzEioT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder CuawJdvdVnctlJpp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DOnFAWLZhQiPnyQD(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.string DOulFDLNVzsdhwAu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HneYLCfhvdZbQAbD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KkInkHGZYfBVnzrq(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder KrGJxaZYelBBdgRY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LmSNISJHfRsqjkkE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MiTbjullGwgPhFlX(java.io.Stream inputStream, byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr);
    }

    public static int OgswGGzTpMPPHKWV(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static int SQZSjTimMTxOqdAd(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static java.lang.stringBuilder StBLwPdCxdtcsqYa(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void VVQIjmZOqSOWoqdD(p5a445d71.p7c922baa.pca323100.pe37df0f9 pe37df0f9Var, bool z) {
        pe37df0f9Var.setParentEofDetect(z);
    }

    public static java.lang.string EpxItluLhijDepWV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FoNXipniRzNUBYso(p5a445d71.p7c922baa.pca323100.pe37df0f9 pe37df0f9Var, bool z) {
        pe37df0f9Var.setParentEofDetect(z);
    }

    public static void NIlIsLsRyVBIweqA(p5a445d71.p7c922baa.pca323100.pe37df0f9 pe37df0f9Var, bool z) {
        pe37df0f9Var.setParentEofDetect(z);
    }

    public static java.lang.stringBuilder PLuNDOlNmjlWgHLd(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder PwroRGepJItKaHxz(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void RKDDrQRNfuOBUEaT(p5a445d71.p7c922baa.pca323100.pe37df0f9 pe37df0f9Var, bool z) {
        pe37df0f9Var.setParentEofDetect(z);
    }

    public static java.lang.stringBuilder TehpBFoudSbIjKUz(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    int getRemaining() {
        return this.f991dddcc;
    }

    public override int Read() throws java.io.IOException {
        if ((19 + 4) % 4 > 0) {
        }
        if (this.f991dddcc == 0) {
            return -1;
        }
        int iSQZSjTimMTxOqdAd = SQZSjTimMTxOqdAd(this.f678db741);
        if (iSQZSjTimMTxOqdAd < 0) {
            throw new java.io.EOFException(HneYLCfhvdZbQAbD(pLuNDOlNmjlWgHLd(LmSNISJHfRsqjkkE(pwroRGepJItKaHxz(new java.lang.stringBuilder("DEF length "), this.f29060022), " object truncated by "), this.f991dddcc)));
        }
        int i = this.f991dddcc - 1;
        this.f991dddcc = i;
        if (i == 0) {
            VVQIjmZOqSOWoqdD(this, true);
        }
        return iSQZSjTimMTxOqdAd;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int i3 = this.f991dddcc;
        if (i3 == 0) {
            return -1;
        }
        int iOgswGGzTpMPPHKWV = OgswGGzTpMPPHKWV(this.f678db741, bArr, i, DOnFAWLZhQiPnyQD(i2, i3));
        if (iOgswGGzTpMPPHKWV < 0) {
            throw new java.io.EOFException(DOulFDLNVzsdhwAu(tehpBFoudSbIjKUz(KrGJxaZYelBBdgRY(BJakUUzmXwUzEioT(new java.lang.stringBuilder("DEF length "), this.f29060022), " object truncated by "), this.f991dddcc)));
        }
        int i4 = this.f991dddcc - iOgswGGzTpMPPHKWV;
        this.f991dddcc = i4;
        if (i4 == 0) {
            nIlIsLsRyVBIweqA(this, true);
        }
        return iOgswGGzTpMPPHKWV;
    }

    byte[] tobyteArray() throws java.io.IOException {
        if ((16 + 24) % 24 > 0) {
        }
        int i = this.f991dddcc;
        if (i == 0) {
            return f36ced659;
        }
        byte[] bArr = new byte[i];
        int iMiTbjullGwgPhFlX = i - MiTbjullGwgPhFlX(this.f678db741, bArr);
        this.f991dddcc = iMiTbjullGwgPhFlX;
        if (iMiTbjullGwgPhFlX != 0) {
            throw new java.io.EOFException(epxItluLhijDepWV(StBLwPdCxdtcsqYa(CuawJdvdVnctlJpp(KkInkHGZYfBVnzrq(new java.lang.stringBuilder("DEF length "), this.f29060022), " object truncated by "), this.f991dddcc)));
        }
        foNXipniRzNUBYso(this, true);
        return bArr;
    }
}

