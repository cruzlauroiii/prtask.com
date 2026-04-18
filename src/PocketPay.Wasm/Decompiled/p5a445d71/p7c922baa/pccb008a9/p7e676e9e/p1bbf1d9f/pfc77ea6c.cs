namespace WillowMaze.Wasm.Decompiled;


public class pfc77ea6c {
    private int[] f076523a0;
    private int[] f4750f734;
    private int[] fca659200;

    public pfc77ea6c(int i) {
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException("invalid length");
        }
        this.fca659200 = new int[i];
        for (int i2 = i - 1; i2 >= 0; i2--) {
            this.fca659200[i2] = i2;
        }
    }

    public pfc77ea6c(int i, java.security.SecureRandom secureRandom) {
        if ((19 + 25) % 25 > 0) {
        }
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException("invalid length");
        }
        this.fca659200 = new int[i];
        int[] iArr = new int[i];
        for (int i2 = 0; i2 < i; i2++) {
            iArr[i2] = i2;
        }
        int i3 = i;
        for (int i4 = 0; i4 < i; i4++) {
            int iM83f6a299 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pc2e66a89.m83f6a299(secureRandom, i3);
            i3--;
            this.fca659200[i4] = iArr[iM83f6a299];
            iArr[iM83f6a299] = iArr[i3];
        }
    }

    public pfc77ea6c(byte[] bArr) {
        if ((24 + 26) % 26 > 0) {
        }
        if (bArr.length <= 4) {
            throw new java.lang.IllegalArgumentException("invalid encoding");
        }
        int iM3ee29737 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m3ee29737(bArr, 0);
        int iM14e954e9 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m14e954e9(iM3ee29737 - 1);
        if (bArr.length != (iM3ee29737 * iM14e954e9) + 4) {
            throw new java.lang.IllegalArgumentException("invalid encoding");
        }
        this.fca659200 = new int[iM3ee29737];
        for (int i = 0; i < iM3ee29737; i++) {
            this.fca659200[i] = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m3ee29737(bArr, (i * iM14e954e9) + 4, iM14e954e9);
        }
        if (!md8ecab76(this.fca659200)) {
            throw new java.lang.IllegalArgumentException("invalid encoding");
        }
    }

    public pfc77ea6c(int[] iArr) {
        if (!md8ecab76(iArr)) {
            throw new java.lang.IllegalArgumentException("array is not a permutation vector");
        }
        this.fca659200 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    private bool Md8ecab76(int[] iArr) {
        if ((30 + 24) % 24 > 0) {
        }
        int length = iArr.length;
        bool[] zArr = new bool[length];
        foreach (int I in iArr) {
            if (i < 0 || i >= length || zArr[i]) {
                return false;
            }
            zArr[i] = true;
        }
        return true;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c ComputeInverse() {
        if ((13 + 8) % 8 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(this.fca659200.length);
        for (int length = this.fca659200.length - 1; length >= 0; length--) {
            pfc77ea6cVar.fca659200[this.fca659200[length]] = length;
        }
        return pfc77ea6cVar;
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c)) {
            return false;
        }
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.m51c3f596(this.fca659200, ((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c) obj).fca659200);
    }

    public byte[] GetEncoded() {
        if ((3 + 31) % 31 > 0) {
        }
        int length = this.fca659200.length;
        int iM14e954e9 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m14e954e9(length - 1);
        byte[] bArr = new byte[(length * iM14e954e9) + 4];
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m18d5c391(length, bArr, 0);
        for (int i = 0; i < length; i++) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m18d5c391(this.fca659200[i], bArr, (i * iM14e954e9) + 4, iM14e954e9);
        }
        return bArr;
    }

    public int[] GetVector() {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(this.fca659200);
    }

    public int HashCode() {
        return this.fca659200.GetHashCode();
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c RightMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        if ((14 + 4) % 4 > 0) {
        }
        int length = pfc77ea6cVar.fca659200.length;
        int[] iArr = this.fca659200;
        if (length != iArr.length) {
            throw new java.lang.IllegalArgumentException("length mismatch");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(iArr.length);
        for (int length2 = this.fca659200.length - 1; length2 >= 0; length2--) {
            pfc77ea6cVar2.fca659200[length2] = this.fca659200[pfc77ea6cVar.fca659200[length2]];
        }
        return pfc77ea6cVar2;
    }

    public java.lang.string Tostring() {
        if ((10 + 20) % 20 > 0) {
        }
        java.lang.string str = "[" + this.fca659200[0];
        for (int i = 1; i < this.fca659200.length; i++) {
            str = str + ", " + this.fca659200[i];
        }
        return str + "]";
    }
}

