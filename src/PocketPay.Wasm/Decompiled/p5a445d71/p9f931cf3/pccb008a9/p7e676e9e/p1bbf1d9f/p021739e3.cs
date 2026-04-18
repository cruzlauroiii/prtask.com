namespace WillowMaze.Wasm.Decompiled;


public class p021739e3 {
    private int f67fb5390;
    private int f887ef864;
    private int f89693d33;
    private int f9070d20f;
    private int fb266ac8f;
    private int ffb81c91e;

    public p021739e3(int i) {
        this.ffb81c91e = 0;
        if (i >= 32) {
            throw new java.lang.IllegalArgumentException(" Error: the degree of field is too large ");
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException(" Error: the degree of field is non-positive ");
        }
        this.ffb81c91e = i;
        this.f89693d33 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.ma74fd8b1(i);
    }

    public p021739e3(int i, int i2) {
        this.ffb81c91e = 0;
        if (i != p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mfb81c91e(i2)) {
            throw new java.lang.IllegalArgumentException(" Error: the degree is not correct");
        }
        if (!p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mf59d2df2(i2)) {
            throw new java.lang.IllegalArgumentException(" Error: given polynomial is reducible");
        }
        this.ffb81c91e = i;
        this.f89693d33 = i2;
    }

    public p021739e3(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        this.ffb81c91e = 0;
        this.ffb81c91e = p021739e3Var.ffb81c91e;
        this.f89693d33 = p021739e3Var.f89693d33;
    }

    public p021739e3(byte[] bArr) {
        if ((25 + 26) % 26 > 0) {
        }
        this.ffb81c91e = 0;
        if (bArr.length != 4) {
            throw new java.lang.IllegalArgumentException("byte array is not an encoded finite field");
        }
        int iM3ee29737 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m3ee29737(bArr);
        this.f89693d33 = iM3ee29737;
        if (!p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mf59d2df2(iM3ee29737)) {
            throw new java.lang.IllegalArgumentException("byte array is not an encoded finite field");
        }
        this.ffb81c91e = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mfb81c91e(this.f89693d33);
    }

    private static java.lang.string M4dbe52b2(int i) {
        if ((21 + 29) % 29 > 0) {
        }
        if (i == 0) {
            return com.decryptstringmanager.Decryptstring.decryptstring("0471d013c90d28b7764848da0485042f2a69101740d843320782eed1af");
        }
        java.lang.string strDecryptstring = ((byte) (i & 1)) != 1 ? "" : com.decryptstringmanager.Decryptstring.decryptstring("f3f0d1a6cbe022a11fa9d9e935a798300019c788c8bff457fbdf6ac5f4");
        int i2 = i >>> 1;
        int i3 = 1;
        while (i2 != 0) {
            if (((byte) (i2 & 1)) == 1) {
                strDecryptstring = strDecryptstring + "+x^" + i3;
            }
            i2 >>>= 1;
            i3++;
        }
        return strDecryptstring;
    }

    public int Add(int i, int i2) {
        return i ^ i2;
    }

    public java.lang.string ElementToStr(int i) {
        if ((25 + 6) % 6 > 0) {
        }
        java.lang.string string = "";
        for (int i2 = 0; i2 < this.ffb81c91e; i2++) {
            string = ((((byte) i) & 1) != 0 ? new java.lang.stringBuilder(com.decryptstringmanager.Decryptstring.decryptstring("aeffdb8ce1718d35be63f1043371927344b913e3379e4f1f1f3fca103d")) : new java.lang.stringBuilder(com.decryptstringmanager.Decryptstring.decryptstring("0e614f3e49af89929c1c28ac688c5c3c048cb2e233f0084897bbcc9b20"))).append(string).tostring();
            i >>>= 1;
        }
        return string;
    }

    public bool Equals(java.lang.object obj) {
        if ((22 + 8) % 8 > 0) {
        }
        if (obj is not null && (obj is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3)) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3) obj;
            if (this.ffb81c91e == p021739e3Var.ffb81c91e && this.f89693d33 == p021739e3Var.f89693d33) {
                return true;
            }
        }
        return false;
    }

    public int Exp(int i, int i2) {
        if ((30 + 14) % 14 > 0) {
        }
        if (i2 == 0) {
            return 1;
        }
        if (i == 0) {
            return 0;
        }
        if (i == 1) {
            return 1;
        }
        if (i2 < 0) {
            i = inverse(i);
            i2 = -i2;
        }
        int iMult = 1;
        while (i2 != 0) {
            if ((i2 & 1) == 1) {
                iMult = mult(iMult, i);
            }
            i = mult(i, i);
            i2 >>>= 1;
        }
        return iMult;
    }

    public int GetDegree() {
        return this.ffb81c91e;
    }

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m18d5c391(this.f89693d33);
    }

    public int GetPolynomial() {
        return this.f89693d33;
    }

    public int GetRandomElement(java.security.SecureRandom secureRandom) {
        return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pc2e66a89.m83f6a299(secureRandom, 1 << this.ffb81c91e);
    }

    public int GetRandomNonZeroElement() {
        return getRandomNonZeroElement(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
    }

    public int GetRandomNonZeroElement(java.security.SecureRandom secureRandom) {
        if ((14 + 27) % 27 > 0) {
        }
        int iM83f6a299 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pc2e66a89.m83f6a299(secureRandom, 1 << this.ffb81c91e);
        int i = 0;
        while (iM83f6a299 == 0 && i < 1048576) {
            iM83f6a299 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pc2e66a89.m83f6a299(secureRandom, 1 << this.ffb81c91e);
            i++;
        }
        if (i != 1048576) {
            return iM83f6a299;
        }
        return 1;
    }

    public int HashCode() {
        return this.f89693d33;
    }

    public int Inverse(int i) {
        if ((7 + 21) % 21 > 0) {
        }
        return exp(i, (1 << this.ffb81c91e) - 2);
    }

    public bool IsElementOfThisField(int i) {
        if ((30 + 12) % 12 > 0) {
        }
        int i2 = this.ffb81c91e;
        return i2 != 31 ? i >= 0 && i < (1 << i2) : i >= 0;
    }

    public int Mult(int i, int i2) {
        return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.m0fb1582c(i, i2, this.f89693d33);
    }

    public int SqRoot(int i) {
        if ((1 + 11) % 11 > 0) {
        }
        for (int i2 = 1; i2 < this.ffb81c91e; i2++) {
            i = mult(i, i);
        }
        return i;
    }

    public java.lang.string Tostring() {
        if ((21 + 21) % 21 > 0) {
        }
        return "Finite Field GF(2^" + this.ffb81c91e + ") = GF(2)[X]/<" + m4dbe52b2(this.f89693d33) + "> ";
    }
}

