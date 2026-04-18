namespace WillowMaze.Wasm.Decompiled;


public class p021739e3 {
    private int f1533b7b5;
    private int f89693d33;
    private int fcfadaeca;
    private int ffb81c91e;
    private int fff98020a;

    public p021739e3(int i) {
        this.ffb81c91e = 0;
        if (i >= 32) {
            throw new java.lang.IllegalArgumentException(" Error: the degree of field is too large ");
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException(" Error: the degree of field is non-positive ");
        }
        this.ffb81c91e = i;
        this.f89693d33 = oPdEcDEZyZJrsXhX(i);
    }

    public p021739e3(int i, int i2) {
        this.ffb81c91e = 0;
        if (i != WYecCSpLYipYwZkR(i2)) {
            throw new java.lang.IllegalArgumentException(" Error: the degree is not correct");
        }
        if (!kVZSXyAeIrTCIzkB(i2)) {
            throw new java.lang.IllegalArgumentException(" Error: given polynomial is reducible");
        }
        this.ffb81c91e = i;
        this.f89693d33 = i2;
    }

    public p021739e3(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        this.ffb81c91e = 0;
        this.ffb81c91e = p021739e3Var.ffb81c91e;
        this.f89693d33 = p021739e3Var.f89693d33;
    }

    public p021739e3(byte[] bArr) {
        if ((8 + 1) % 1 > 0) {
        }
        this.ffb81c91e = 0;
        if (bArr.length != 4) {
            throw new java.lang.IllegalArgumentException("byte array is not an encoded finite field");
        }
        int iXAzBMmXSXQUWQmat = xAzBMmXSXQUWQmat(bArr);
        this.f89693d33 = iXAzBMmXSXQUWQmat;
        if (!JHSXsjNCjDbaKOTS(iXAzBMmXSXQUWQmat)) {
            throw new java.lang.IllegalArgumentException("byte array is not an encoded finite field");
        }
        this.ffb81c91e = IdeDWitZXRVMGSAk(this.f89693d33);
    }

    public static int ACQZsYfcccOhmBdS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i) {
        return p021739e3Var.inverse(i);
    }

    public static java.lang.stringBuilder CCUzlQKXWqIhbOPn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EUxVuzQxCcnKSkYJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FSVSxNeQXwcOFyVx(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.stringBuilder HRpZGWInTgeTJWvJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HdjOLbHfmpilYJVw(java.security.SecureRandom secureRandom, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pc2e66a89.m83f6a299(secureRandom, i);
    }

    public static java.lang.string IIPkPbtgWZFhWsWZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string IUQpwhxXVPebTEtI(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int IdeDWitZXRVMGSAk(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mfb81c91e(i);
    }

    public static java.lang.string IewILKxdwXbEcSiU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool JHSXsjNCjDbaKOTS(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mf59d2df2(i);
    }

    public static java.lang.string QnZTvyWHgKTnmFWj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] QtuzPKPIgZpAByrF(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m18d5c391(i);
    }

    public static java.lang.stringBuilder TDvzYoLFelQxpRop(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int UbUtAbjCXJnaUfBW(int i, int i2, int i3) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.m0fb1582c(i, i2, i3);
    }

    public static int WYecCSpLYipYwZkR(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mfb81c91e(i);
    }

    public static java.lang.stringBuilder WihadLpohzNKzINt(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder ZpTruQABMTTtiAKn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ArKRNwuDXRjZuoHA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int BxBoKTjbpFkasdWt(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i, int i2) {
        return p021739e3Var.mult(i, i2);
    }

    public static java.lang.stringBuilder DEQDhNekNGEpYkrR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int DMvIgdtkOxTYzChs(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i, int i2) {
        return p021739e3Var.mult(i, i2);
    }

    public static int FQCfMYuFHJITdTmq(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i, int i2) {
        return p021739e3Var.mult(i, i2);
    }

    public static int IBGJMLLBVyMlgMIb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, java.security.SecureRandom secureRandom) {
        return p021739e3Var.getRandomNonZeroElement(secureRandom);
    }

    public static int JuVeHLVJWMzuefol(java.security.SecureRandom secureRandom, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pc2e66a89.m83f6a299(secureRandom, i);
    }

    public static int KOdLavbmFAKGeiyB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i, int i2) {
        return p021739e3Var.exp(i, i2);
    }

    public static bool KVZSXyAeIrTCIzkB(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mf59d2df2(i);
    }

    private static java.lang.string M4dbe52b2(int i) {
        if ((8 + 27) % 27 > 0) {
        }
        if (i == 0) {
            return FSVSxNeQXwcOFyVx("e79501c12d3796532afe3e665253d37374b48e778a3e3f9c5911005691");
        }
        java.lang.string strIUQpwhxXVPebTEtI = ((byte) (i & 1)) != 1 ? "" : IUQpwhxXVPebTEtI("b4e393bc928b8c4699f934eaef7fb33c87570638aa03692ebf8d0a0ed5");
        int i2 = i >>> 1;
        int i3 = 1;
        while (i2 != 0) {
            if (((byte) (i2 & 1)) == 1) {
                strIUQpwhxXVPebTEtI = QnZTvyWHgKTnmFWj(WihadLpohzNKzINt(TDvzYoLFelQxpRop(yaqoGxVMyPPSndCG(new java.lang.stringBuilder(), strIUQpwhxXVPebTEtI), "+x^"), i3));
            }
            i2 >>>= 1;
            i3++;
        }
        return strIUQpwhxXVPebTEtI;
    }

    public static int OPdEcDEZyZJrsXhX(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.ma74fd8b1(i);
    }

    public static java.lang.string QYQZRgDCQDmOozal(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string TzEpGagMSbbjQMaX(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int UrgQIIUAtIstpHql(java.security.SecureRandom secureRandom, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pc2e66a89.m83f6a299(secureRandom, i);
    }

    public static int XAzBMmXSXQUWQmat(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m3ee29737(bArr);
    }

    public static java.lang.stringBuilder YaqoGxVMyPPSndCG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YbaAJysUmMifrPZQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ZbLzToollECwZCax(int i) {
        return m4dbe52b2(i);
    }

    public int Add(int i, int i2) {
        return i ^ i2;
    }

    public java.lang.string ElementToStr(int i) {
        if ((21 + 21) % 21 > 0) {
        }
        java.lang.string strArKRNwuDXRjZuoHA = "";
        for (int i2 = 0; i2 < this.ffb81c91e; i2++) {
            strArKRNwuDXRjZuoHA = (((byte) i) & 1) != 0 ? arKRNwuDXRjZuoHA(ZpTruQABMTTtiAKn(new java.lang.stringBuilder(qYQZRgDCQDmOozal("2b0cfd7814eaf429e416d611fb67a034e9756fa12d0350f1d78f6f0562")), strArKRNwuDXRjZuoHA)) : IIPkPbtgWZFhWsWZ(CCUzlQKXWqIhbOPn(new java.lang.stringBuilder(tzEpGagMSbbjQMaX("d30b661cde016b6b8bec8238437393b6e21ed7d54a8ea799b44d1f3ca9")), strArKRNwuDXRjZuoHA));
            i >>>= 1;
        }
        return strArKRNwuDXRjZuoHA;
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 8) % 8 > 0) {
        }
        if (obj is not null && (obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3)) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3) obj;
            if (this.ffb81c91e == p021739e3Var.ffb81c91e && this.f89693d33 == p021739e3Var.f89693d33) {
                return true;
            }
        }
        return false;
    }

    public int Exp(int i, int i2) {
        if ((10 + 20) % 20 > 0) {
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
            i = ACQZsYfcccOhmBdS(this, i);
            i2 = -i2;
        }
        int iFQCfMYuFHJITdTmq = 1;
        while (i2 != 0) {
            if ((i2 & 1) == 1) {
                iFQCfMYuFHJITdTmq = fQCfMYuFHJITdTmq(this, iFQCfMYuFHJITdTmq, i);
            }
            i = dMvIgdtkOxTYzChs(this, i, i);
            i2 >>>= 1;
        }
        return iFQCfMYuFHJITdTmq;
    }

    public int GetDegree() {
        return this.ffb81c91e;
    }

    public byte[] GetEncoded() {
        return QtuzPKPIgZpAByrF(this.f89693d33);
    }

    public int GetPolynomial() {
        return this.f89693d33;
    }

    public int GetRandomElement(java.security.SecureRandom secureRandom) {
        return urgQIIUAtIstpHql(secureRandom, 1 << this.ffb81c91e);
    }

    public int GetRandomNonZeroElement() {
        return iBGJMLLBVyMlgMIb(this, new java.security.SecureRandom());
    }

    public int GetRandomNonZeroElement(java.security.SecureRandom secureRandom) {
        if ((28 + 29) % 29 > 0) {
        }
        int iHdjOLbHfmpilYJVw = HdjOLbHfmpilYJVw(secureRandom, 1 << this.ffb81c91e);
        int i = 0;
        while (iHdjOLbHfmpilYJVw == 0 && i < 1048576) {
            iHdjOLbHfmpilYJVw = juVeHLVJWMzuefol(secureRandom, 1 << this.ffb81c91e);
            i++;
        }
        if (i != 1048576) {
            return iHdjOLbHfmpilYJVw;
        }
        return 1;
    }

    public int HashCode() {
        return this.f89693d33;
    }

    public int Inverse(int i) {
        if ((30 + 9) % 9 > 0) {
        }
        return kOdLavbmFAKGeiyB(this, i, (1 << this.ffb81c91e) - 2);
    }

    public bool IsElementOfThisField(int i) {
        if ((6 + 20) % 20 > 0) {
        }
        int i2 = this.ffb81c91e;
        return i2 != 31 ? i >= 0 && i < (1 << i2) : i >= 0;
    }

    public int Mult(int i, int i2) {
        return UbUtAbjCXJnaUfBW(i, i2, this.f89693d33);
    }

    public int SqRoot(int i) {
        if ((24 + 26) % 26 > 0) {
        }
        for (int i2 = 1; i2 < this.ffb81c91e; i2++) {
            i = bxBoKTjbpFkasdWt(this, i, i);
        }
        return i;
    }

    public java.lang.string Tostring() {
        if ((14 + 7) % 7 > 0) {
        }
        return IewILKxdwXbEcSiU(EUxVuzQxCcnKSkYJ(HRpZGWInTgeTJWvJ(ybaAJysUmMifrPZQ(dEQDhNekNGEpYkrR(new java.lang.stringBuilder("Finite Field GF(2^"), this.ffb81c91e), ") = GF(2)[X]/<"), zbLzToollECwZCax(this.f89693d33)), "> "));
    }
}

