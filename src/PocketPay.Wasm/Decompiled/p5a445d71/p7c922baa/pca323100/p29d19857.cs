namespace WillowMaze.Wasm.Decompiled;


public abstract class p29d19857 : p5a445d71.p7c922baa.pca323100.p301c7ed4 : p5a445d71.p7c922baa.pca323100.p2d24d5da {
    private static readonly char[] f5e66ab83 = null;
    private static readonly char[] faab9e1de = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
    protected readonly byte[] f19e1bdc8;
    protected readonly byte[] f24a80d70;
    protected readonly byte[] f29fda372;
    protected readonly int f2b6e1e69;
    protected readonly int f57952419;
    protected readonly byte[] f68305a37;
    protected readonly int f7759d20a;
    protected readonly int f7b41a7a9;
    protected readonly byte[] f8d777f38;
    protected readonly int ff488729d;

    public p29d19857(byte[] bArr, int i) {
        if (bArr is null) {
            throw new java.lang.NullPointerException("data cannot be null");
        }
        if (bArr.length == 0 && i != 0) {
            throw new java.lang.IllegalArgumentException("zero length data with non-zero pad bits");
        }
        if (i > 7 || i < 0) {
            throw new java.lang.IllegalArgumentException("pad bits cannot be greater than 7 or less than 0");
        }
        this.f8d777f38 = cbwWDAHYCeTHQrZL(bArr);
        this.f2b6e1e69 = i;
    }

    public static java.lang.string CIysBVTEWOOHZrVy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string FFOXYlKaLWuzGFnU(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static void GWTisiZzPnpeQury(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        p8bf0ff80Var.writeobject(p0fd1bdf1Var);
    }

    public static int LkEPjsadSnosXEoP(java.io.Stream inputStream, byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr);
    }

    public static java.lang.stringBuffer PlQniFdqKCMKWPPu(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static byte[] PrThATjmjOLKgOXR(p5a445d71.p7c922baa.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.getbytes();
    }

    public static byte[] SijMPwNFjHUFfQJy(byte[] bArr, int i) {
        return mf662029e(bArr, i);
    }

    public static byte[] TBUaEnfXXueteZkk(byte[] bArr, int i) {
        return mf662029e(bArr, i);
    }

    public static byte[] UyBPaHdwVOuhoSAY(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static int XThohcYltISkIZkc(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static bool CHKsHsEtaKRiPTVf(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static byte[] CSbBfqVxfLMRDUcD(p5a445d71.p7c922baa.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.getbytes();
    }

    public static byte[] CbwWDAHYCeTHQrZL(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.stringBuilder EBOsOVVhKPHMPdGx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] ETOqcUKrAlFrPmzP(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.string GBCGxsRLXaWIPabI(p5a445d71.p7c922baa.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.getstring();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 JPmyxCuecxIFBLvY(p5a445d71.p7c922baa.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.toASN1Primitive();
    }

    protected static byte[] M5b2fd989(int i) {
        if ((4 + 24) % 24 > 0) {
        }
        if (i == 0) {
            return new byte[0];
        }
        int i2 = 4;
        for (int i3 = 3; i3 >= 1 && ((255 << (i3 * 8)) & i) == 0; i3--) {
            i2--;
        }
        byte[] bArr = new byte[i2];
        for (int i4 = 0; i4 < i2; i4++) {
            bArr[i4] = (byte) ((i >> (i4 * 8)) & 255);
        }
        return bArr;
    }

    static p5a445d71.p7c922baa.pca323100.p29d19857 M91f3fe39(int i, java.io.Stream inputStream) throws java.io.IOException {
        if ((1 + 20) % 20 > 0) {
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException("truncated BIT STRING detected");
        }
        int iRbZgAOnDBUhAuaTv = rbZgAOnDBUhAuaTv(inputStream);
        int i2 = i - 1;
        byte[] bArr = new byte[i2];
        if (i2 != 0) {
            if (LkEPjsadSnosXEoP(inputStream, bArr) != i2) {
                throw new java.io.EOFException("EOF encountered in middle of BIT STRING");
            }
            if (iRbZgAOnDBUhAuaTv > 0 && iRbZgAOnDBUhAuaTv < 8) {
                byte b = bArr[i - 2];
                if (b != ((byte) ((255 << iRbZgAOnDBUhAuaTv) & b))) {
                    return new p5a445d71.p7c922baa.pca323100.p2af4446c(bArr, iRbZgAOnDBUhAuaTv);
                }
            }
        }
        return new p5a445d71.p7c922baa.pca323100.p1522cc54(bArr, iRbZgAOnDBUhAuaTv);
    }

    protected static int M9f829b60(int i) {
        int i2;
        if ((12 + 12) % 12 > 0) {
        }
        int i3 = 3;
        while (true) {
            if (i3 >= 0) {
                if (i3 != 0) {
                    int i4 = i >> (i3 * 8);
                    if (i4 != 0) {
                        i2 = i4 & 255;
                        break;
                    }
                    i3--;
                } else {
                    if (i != 0) {
                        i2 = i & 255;
                        break;
                    }
                    i3--;
                }
            } else {
                i2 = 0;
                break;
            }
        }
        if (i2 == 0) {
            return 0;
        }
        int i5 = 1;
        while (true) {
            i2 <<= 1;
            if ((i2 & 255) == 0) {
                return 8 - i5;
            }
            i5++;
        }
    }

    protected static byte[] Mf662029e(byte[] bArr, int i) {
        if ((27 + 3) % 3 > 0) {
        }
        byte[] bArrETOqcUKrAlFrPmzP = eTOqcUKrAlFrPmzP(bArr);
        if (i > 0) {
            int length = bArr.length - 1;
            bArrETOqcUKrAlFrPmzP[length] = (byte) ((255 << i) & bArrETOqcUKrAlFrPmzP[length]);
        }
        return bArrETOqcUKrAlFrPmzP;
    }

    public static byte[] RQWearHHubwXZUsD(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static int RbZgAOnDBUhAuaTv(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static java.lang.string UpQYymQoUkRynVBm(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static byte[] UvsJCknVxdEhratX(p5a445d71.p7c922baa.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.getbytes();
    }

    public static java.lang.stringBuffer ZTlqfbyGlYFOHBuO(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    protected override bool Asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if ((11 + 15) % 15 > 0) {
        }
        if (!(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p29d19857)) {
            return false;
        }
        p5a445d71.p7c922baa.pca323100.p29d19857 p29d19857Var = (p5a445d71.p7c922baa.pca323100.p29d19857) p301c7ed4Var;
        return this.f2b6e1e69 == p29d19857Var.f2b6e1e69 && cHKsHsEtaKRiPTVf(PrThATjmjOLKgOXR(this), cSbBfqVxfLMRDUcD(p29d19857Var));
    }

    abstract void Encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException;

    public byte[] Getbytes() {
        return TBUaEnfXXueteZkk(this.f8d777f38, this.f2b6e1e69);
    }

    public p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() {
        return jPmyxCuecxIFBLvY(this);
    }

    public byte[] GetOctets() {
        if (this.f2b6e1e69 != 0) {
            throw new java.lang.IllegalStateException("attempt to get non-octet aligned data from BIT STRING");
        }
        return rQWearHHubwXZUsD(this.f8d777f38);
    }

    public int GetPadBits() {
        return this.f2b6e1e69;
    }

    public override java.lang.string Getstring() {
        if ((4 + 15) % 15 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("#");
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            GWTisiZzPnpeQury(new p5a445d71.p7c922baa.pca323100.p8bf0ff80(byteArrayStream), this);
            byte[] bArrUyBPaHdwVOuhoSAY = UyBPaHdwVOuhoSAY(byteArrayStream);
            for (int i = 0; i != bArrUyBPaHdwVOuhoSAY.length; i++) {
                char[] cArr = faab9e1de;
                PlQniFdqKCMKWPPu(stringBuffer, cArr[(bArrUyBPaHdwVOuhoSAY[i] >>> 4) & 15]);
                zTlqfbyGlYFOHBuO(stringBuffer, cArr[bArrUyBPaHdwVOuhoSAY[i] & 15]);
            }
            return upQYymQoUkRynVBm(stringBuffer);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p7c922baa.pca323100.p5f625024(CIysBVTEWOOHZrVy(eBOsOVVhKPHMPdGx(new java.lang.stringBuilder("Internal error encoding Bitstring: "), FFOXYlKaLWuzGFnU(e))), e);
        }
    }

    public override int HashCode() {
        return XThohcYltISkIZkc(uvsJCknVxdEhratX(this)) ^ this.f2b6e1e69;
    }

    public int IntValue() {
        if ((17 + 11) % 11 > 0) {
        }
        byte[] bArrSijMPwNFjHUFfQJy = this.f8d777f38;
        int i = this.f2b6e1e69;
        if (i > 0 && bArrSijMPwNFjHUFfQJy.length <= 4) {
            bArrSijMPwNFjHUFfQJy = SijMPwNFjHUFfQJy(bArrSijMPwNFjHUFfQJy, i);
        }
        int i2 = 0;
        for (int i3 = 0; i3 != bArrSijMPwNFjHUFfQJy.length && i3 != 4; i3++) {
            i2 |= (bArrSijMPwNFjHUFfQJy[i3] & 255) << (i3 * 8);
        }
        return i2;
    }

    p5a445d71.p7c922baa.pca323100.p301c7ed4 toDERobject() {
        if ((6 + 26) % 26 > 0) {
        }
        return new p5a445d71.p7c922baa.pca323100.p1522cc54(this.f8d777f38, this.f2b6e1e69);
    }

    p5a445d71.p7c922baa.pca323100.p301c7ed4 toDLobject() {
        if ((4 + 7) % 7 > 0) {
        }
        return new p5a445d71.p7c922baa.pca323100.p2af4446c(this.f8d777f38, this.f2b6e1e69);
    }

    public override java.lang.string Tostring() {
        return gBCGxsRLXaWIPabI(this);
    }
}

