namespace WillowMaze.Wasm.Decompiled;


public class p0dff68fb {
    private byte[] f00d96d57;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 f08406a6e;
    private java.io.BufferedStream f08dd41e1;
    private java.io.BufferedStream f0a2c14b2;
    private java.io.BufferedStream f13b5bfe9;
    private byte[] f3c6e0b8a;
    private byte[] f3e410a5f;
    private bool f49dd3eef;
    private bool f53c82eba;
    private bool f5d5b5a67;
    private byte[] f75a34643;
    private java.io.BufferedStream f84539516;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 f903dc9f3;
    private byte[] f9cf517a7;
    private java.io.BufferedStream fae251ef8;
    private java.io.BufferedStream fb014e58a;
    private java.io.BufferedStream fc68271a6;
    private java.io.BufferedStream fdea4711b;
    private java.io.BufferedStream fe81cd695;
    private bool ff5254c2d;

    public p0dff68fb() {
        this.f53c82eba = true;
        this.f08406a6e = null;
        this.f13b5bfe9 = null;
        this.fc68271a6 = null;
        this.f3c6e0b8a = null;
    }

    public p0dff68fb(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z) {
        java.security.SecureRandom secureRandom;
        if ((24 + 25) % 25 > 0) {
        }
        java.security.SecureRandom secureRandom2 = null;
        this.f08406a6e = null;
        this.f13b5bfe9 = null;
        this.fc68271a6 = null;
        this.f3c6e0b8a = null;
        this.f53c82eba = z;
        try {
            this.f13b5bfe9 = new java.io.BufferedStream(new java.io.stringStream(str));
        } catch (java.io.stringNotFoundException unused) {
            YETARRbNOpOOSUgN(java.lang.System.err, uNVJHLuuYsGhZclu(DLmSOKoPrSFahxMr(cLciZGYGOaWLOiup(new java.lang.stringBuilder("Input file not found ["), str), "]")));
            OchRdhsuAarTRMLF(1);
        }
        try {
            this.fc68271a6 = new java.io.BufferedStream(new java.io.stringStream(str2));
        } catch (java.io.IOException unused2) {
            uRhxswXIsGRRTglw(java.lang.System.err, WSkXsDEQqkqavwwP(qHFbQHcZkqBvCUYV(KFnPdqzTJfWVuXPG(new java.lang.stringBuilder("Output file not created ["), str2), "]")));
            mHjdhpquZROfRaOT(1);
        }
        if (!z) {
            try {
                java.io.BufferedStream bufferedStream = new java.io.BufferedStream(new java.io.stringStream(str3));
                int iSUIGRAyQEnckuGao = sUIGRAyQEnckuGao(bufferedStream);
                byte[] bArr = new byte[iSUIGRAyQEnckuGao];
                LsTjKmDpDnTNnovU(bufferedStream, bArr, 0, iSUIGRAyQEnckuGao);
                this.f3c6e0b8a = TaAMZLMbpUauChHt(bArr);
                return;
            } catch (java.io.IOException unused3) {
                PgsANDHFxSZowOre(java.lang.System.err, bzgwIxmjsWuhlyBh(ItLAjwfUOPwUKFCA(gNtSDvLLxLkqZrlR(new java.lang.stringBuilder("Decryption key file not found, or not valid ["), str3), "]")));
                IFjAUYLXuXIjuKyU(1);
                return;
            }
        }
        try {
            try {
                secureRandom = new java.security.SecureRandom();
                try {
                    VtJuVXtLZkssaWzf(secureRandom, jhYOYJqqsmKSdunM("www.bouncycastle.org"));
                } catch (java.lang.Exception unused4) {
                    secureRandom2 = secureRandom;
                    sraqqeyVjAyELdaM(java.lang.System.err, "Hmmm, no SHA1PRNG, you need the Sun implementation");
                    SJgbzxNgGvypexKf(1);
                    secureRandom = secureRandom2;
                }
            } catch (java.lang.Exception unused5) {
            }
            p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var = new p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344(secureRandom, 192);
            p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p849bbe50 p849bbe50Var = new p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p849bbe50();
            OurKSHuozhlJOHYi(p849bbe50Var, pf7bb6344Var);
            this.f3c6e0b8a = ctHlWJyGdZhdKVnX(p849bbe50Var);
            java.io.BufferedStream bufferedStream = new java.io.BufferedStream(new java.io.stringStream(str3));
            byte[] bArrIPghwTPbhuouPXto = IPghwTPbhuouPXto(this.f3c6e0b8a);
            HLMMwpjrqAXSNJaV(bufferedStream, bArrIPghwTPbhuouPXto, 0, bArrIPghwTPbhuouPXto.length);
            izJsXxnJRGztHsDC(bufferedStream);
            jufHwUgOuNFiqCZP(bufferedStream);
        } catch (java.io.IOException unused6) {
            mcFhpBVVYZMSNcHu(java.lang.System.err, xhlaIKOZVksyRJUJ(PvHyNPjvzFAXbYdw(qoNKdVaWBMjxvwRt(new java.lang.stringBuilder("Could not decryption create key file ["), str3), "]")));
            MSySxjHQyxqrDTPs(1);
        }
    }

    public static int BjoffusAwOzEyJdK(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        return p32551d15Var.processbytes(bArr, i, i2, bArr2, i3);
    }

    public static void BjoffusAwOzEyJdK(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3, byte b, float f, char c, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void BjoffusAwOzEyJdK(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3, char c, int i4, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BjoffusAwOzEyJdK(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3, float f, char c, int i4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class CokeFuIGKmtqyezb(java.lang.object obj) {
        return obj.GetType();
    }

    public static void CokeFuIGKmtqyezb(java.lang.object obj, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CokeFuIGKmtqyezb(java.lang.object obj, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CokeFuIGKmtqyezb(java.lang.object obj, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DLmSOKoPrSFahxMr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DLmSOKoPrSFahxMr(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DLmSOKoPrSFahxMr(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DLmSOKoPrSFahxMr(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FWqITmDmyFzJhDdL(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p32551d15Var.init(z, pc9ef6b45Var);
    }

    public static void FWqITmDmyFzJhDdL(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, float f, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FWqITmDmyFzJhDdL(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, short s, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FWqITmDmyFzJhDdL(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, bool z2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FXcvxwbYZTgAtvzp(int i) {
        java.lang.System.exit(i);
    }

    public static void FXcvxwbYZTgAtvzp(int i, java.lang.string str, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FXcvxwbYZTgAtvzp(int i, short s, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FXcvxwbYZTgAtvzp(int i, short s, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HLMMwpjrqAXSNJaV(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        bufferedStream.write(bArr, i, i2);
    }

    public static void HLMMwpjrqAXSNJaV(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, float f, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HLMMwpjrqAXSNJaV(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, java.lang.string str, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HLMMwpjrqAXSNJaV(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, java.lang.string str, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void HaVGcmrgfCyxwKqq(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        bufferedStream.write(bArr, i, i2);
    }

    public static void HaVGcmrgfCyxwKqq(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, char c, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HaVGcmrgfCyxwKqq(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, char c, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void HaVGcmrgfCyxwKqq(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, bool z, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IFjAUYLXuXIjuKyU(int i) {
        java.lang.System.exit(i);
    }

    public static void IFjAUYLXuXIjuKyU(int i, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IFjAUYLXuXIjuKyU(int i, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IFjAUYLXuXIjuKyU(int i, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IPghwTPbhuouPXto(byte[] bArr, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IPghwTPbhuouPXto(byte[] bArr, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IPghwTPbhuouPXto(byte[] bArr, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] IPghwTPbhuouPXto(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m97a57645(bArr);
    }

    public static void IYZzquoarxJIrDwz(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, byte[] bArr) {
        p0dff68fbVar.m114a66f4(bArr);
    }

    public static void IYZzquoarxJIrDwz(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, byte[] bArr, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IYZzquoarxJIrDwz(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, byte[] bArr, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IYZzquoarxJIrDwz(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, byte[] bArr, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IfNITZfQLiNubhQA(java.lang.Class cls) {
        return cls.getName();
    }

    public static void IfNITZfQLiNubhQA(java.lang.Class cls, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IfNITZfQLiNubhQA(java.lang.Class cls, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IfNITZfQLiNubhQA(java.lang.Class cls, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ItLAjwfUOPwUKFCA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ItLAjwfUOPwUKFCA(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ItLAjwfUOPwUKFCA(java.lang.stringBuilder sb, java.lang.string str, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ItLAjwfUOPwUKFCA(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KFnPdqzTJfWVuXPG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KFnPdqzTJfWVuXPG(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KFnPdqzTJfWVuXPG(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KFnPdqzTJfWVuXPG(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LsTjKmDpDnTNnovU(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2) {
        return bufferedStream.read(bArr, i, i2);
    }

    public static void LsTjKmDpDnTNnovU(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LsTjKmDpDnTNnovU(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LsTjKmDpDnTNnovU(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MSySxjHQyxqrDTPs(int i) {
        java.lang.System.exit(i);
    }

    public static void MSySxjHQyxqrDTPs(int i, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MSySxjHQyxqrDTPs(int i, char c, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MSySxjHQyxqrDTPs(int i, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NOPyZyXtYsGPqzMA(java.io.BufferedStream bufferedStream) throws java.io.IOException {
        bufferedStream.Dispose();
    }

    public static void NOPyZyXtYsGPqzMA(java.io.BufferedStream bufferedStream, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NOPyZyXtYsGPqzMA(java.io.BufferedStream bufferedStream, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NOPyZyXtYsGPqzMA(java.io.BufferedStream bufferedStream, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int NqHVeOEpbMquxqNV(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i) {
        return p32551d15Var.doFinal(bArr, i);
    }

    public static void NqHVeOEpbMquxqNV(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NqHVeOEpbMquxqNV(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NqHVeOEpbMquxqNV(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OchRdhsuAarTRMLF(int i) {
        java.lang.System.exit(i);
    }

    public static void OchRdhsuAarTRMLF(int i, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OchRdhsuAarTRMLF(int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OchRdhsuAarTRMLF(int i, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OdCsuWhzLaSASjbi(java.io.BufferedStream bufferedStream) {
        bufferedStream.Dispose();
    }

    public static void OdCsuWhzLaSASjbi(java.io.BufferedStream bufferedStream, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OdCsuWhzLaSASjbi(java.io.BufferedStream bufferedStream, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OdCsuWhzLaSASjbi(java.io.BufferedStream bufferedStream, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OurKSHuozhlJOHYi(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p849bbe50 p849bbe50Var, p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        p849bbe50Var.init(pf7bb6344Var);
    }

    public static void OurKSHuozhlJOHYi(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p849bbe50 p849bbe50Var, p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OurKSHuozhlJOHYi(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p849bbe50 p849bbe50Var, p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OurKSHuozhlJOHYi(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p849bbe50 p849bbe50Var, p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PChubCJjCmWlNyfb(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static void PChubCJjCmWlNyfb(java.io.IOException iOException, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PChubCJjCmWlNyfb(java.io.IOException iOException, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PChubCJjCmWlNyfb(java.io.IOException iOException, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PgsANDHFxSZowOre(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void PgsANDHFxSZowOre(java.io.PrintStream printStream, java.lang.string str, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PgsANDHFxSZowOre(java.io.PrintStream printStream, java.lang.string str, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PgsANDHFxSZowOre(java.io.PrintStream printStream, java.lang.string str, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PvHyNPjvzFAXbYdw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PvHyNPjvzFAXbYdw(java.lang.stringBuilder sb, java.lang.string str, float f, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PvHyNPjvzFAXbYdw(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PvHyNPjvzFAXbYdw(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SJgbzxNgGvypexKf(int i) {
        java.lang.System.exit(i);
    }

    public static void SJgbzxNgGvypexKf(int i, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SJgbzxNgGvypexKf(int i, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SJgbzxNgGvypexKf(int i, short s, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TaAMZLMbpUauChHt(byte[] bArr, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TaAMZLMbpUauChHt(byte[] bArr, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TaAMZLMbpUauChHt(byte[] bArr, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] TaAMZLMbpUauChHt(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(bArr);
    }

    public static void TcGtOPCeCPBlouEn(byte[] bArr, int i, int i2, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TcGtOPCeCPBlouEn(byte[] bArr, int i, int i2, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TcGtOPCeCPBlouEn(byte[] bArr, int i, int i2, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] TcGtOPCeCPBlouEn(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m97a57645(bArr, i, i2);
    }

    public static void VtJuVXtLZkssaWzf(java.security.SecureRandom secureRandom, byte[] bArr) {
        secureRandom.setSeed(bArr);
    }

    public static void VtJuVXtLZkssaWzf(java.security.SecureRandom secureRandom, byte[] bArr, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VtJuVXtLZkssaWzf(java.security.SecureRandom secureRandom, byte[] bArr, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VtJuVXtLZkssaWzf(java.security.SecureRandom secureRandom, byte[] bArr, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WSkXsDEQqkqavwwP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WSkXsDEQqkqavwwP(java.lang.stringBuilder sb, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WSkXsDEQqkqavwwP(java.lang.stringBuilder sb, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WSkXsDEQqkqavwwP(java.lang.stringBuilder sb, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WVRLohUcVMzLEXpy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WVRLohUcVMzLEXpy(java.lang.stringBuilder sb, java.lang.string str, char c, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WVRLohUcVMzLEXpy(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WVRLohUcVMzLEXpy(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YETARRbNOpOOSUgN(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void YETARRbNOpOOSUgN(java.io.PrintStream printStream, java.lang.string str, byte b, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YETARRbNOpOOSUgN(java.io.PrintStream printStream, java.lang.string str, java.lang.string str2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YETARRbNOpOOSUgN(java.io.PrintStream printStream, java.lang.string str, short s, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YmysrEmvQIUbZbdk(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p32551d15Var.init(z, pc9ef6b45Var);
    }

    public static void YmysrEmvQIUbZbdk(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YmysrEmvQIUbZbdk(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YmysrEmvQIUbZbdk(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ATOCrhnqLgcUDzpE(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        bufferedStream.write(bArr, i, i2);
    }

    public static void ATOCrhnqLgcUDzpE(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, java.lang.string str, char c, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ATOCrhnqLgcUDzpE(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, java.lang.string str, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ATOCrhnqLgcUDzpE(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, bool z, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AVdoSftZcqWjsteT(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void AVdoSftZcqWjsteT(java.io.PrintStream printStream, java.lang.string str, char c, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AVdoSftZcqWjsteT(java.io.PrintStream printStream, java.lang.string str, java.lang.string str2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AVdoSftZcqWjsteT(java.io.PrintStream printStream, java.lang.string str, bool z, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AXsBdokWDgOmTTEA(java.io.BufferedStream bufferedStream, int i) throws java.io.IOException {
        bufferedStream.write(i);
    }

    public static void AXsBdokWDgOmTTEA(java.io.BufferedStream bufferedStream, int i, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXsBdokWDgOmTTEA(java.io.BufferedStream bufferedStream, int i, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AXsBdokWDgOmTTEA(java.io.BufferedStream bufferedStream, int i, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BnSWlxexSrriVtLq(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, int i) {
        return p32551d15Var.getOutputSize(i);
    }

    public static void BnSWlxexSrriVtLq(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BnSWlxexSrriVtLq(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, int i, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BnSWlxexSrriVtLq(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, int i, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BzgwIxmjsWuhlyBh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BzgwIxmjsWuhlyBh(java.lang.stringBuilder sb, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BzgwIxmjsWuhlyBh(java.lang.stringBuilder sb, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BzgwIxmjsWuhlyBh(java.lang.stringBuilder sb, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CIOyEMadEvufYGpD(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void CIOyEMadEvufYGpD(java.io.PrintStream printStream, java.lang.string str, int i, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CIOyEMadEvufYGpD(java.io.PrintStream printStream, java.lang.string str, java.lang.string str2, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CIOyEMadEvufYGpD(java.io.PrintStream printStream, java.lang.string str, java.lang.string str2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CLciZGYGOaWLOiup(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CLciZGYGOaWLOiup(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CLciZGYGOaWLOiup(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CLciZGYGOaWLOiup(java.lang.stringBuilder sb, java.lang.string str, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CtHlWJyGdZhdKVnX(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p849bbe50 p849bbe50Var, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CtHlWJyGdZhdKVnX(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p849bbe50 p849bbe50Var, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CtHlWJyGdZhdKVnX(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p849bbe50 p849bbe50Var, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] CtHlWJyGdZhdKVnX(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p849bbe50 p849bbe50Var) {
        return p849bbe50Var.generateKey();
    }

    public static void ESRyXIIxwiacGIDc(java.io.IOException iOException) {
        iOException.printStackTrace();
    }

    public static void ESRyXIIxwiacGIDc(java.io.IOException iOException, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ESRyXIIxwiacGIDc(java.io.IOException iOException, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ESRyXIIxwiacGIDc(java.io.IOException iOException, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FFUaJkYVrqoaXSRe(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        return p32551d15Var.processbytes(bArr, i, i2, bArr2, i3);
    }

    public static void FFUaJkYVrqoaXSRe(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3, int i4, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FFUaJkYVrqoaXSRe(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3, short s, int i4, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FFUaJkYVrqoaXSRe(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3, bool z, short s, java.lang.string str, int i4) {
        double d = (42 * 210) + 210;
    }

    public static int FlVgktlGFXbGloTT(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i) {
        return p32551d15Var.doFinal(bArr, i);
    }

    public static void FlVgktlGFXbGloTT(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, int i2, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FlVgktlGFXbGloTT(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, java.lang.string str, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FlVgktlGFXbGloTT(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, byte[] bArr, int i, short s, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GCdNBenvRcwPWhcA(java.lang.string str, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GCdNBenvRcwPWhcA(java.lang.string str, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GCdNBenvRcwPWhcA(java.lang.string str, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] GCdNBenvRcwPWhcA(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m5b936250(str);
    }

    public static java.lang.stringBuilder GNtSDvLLxLkqZrlR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GNtSDvLLxLkqZrlR(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNtSDvLLxLkqZrlR(java.lang.stringBuilder sb, java.lang.string str, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GNtSDvLLxLkqZrlR(java.lang.stringBuilder sb, java.lang.string str, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IzJsXxnJRGztHsDC(java.io.BufferedStream bufferedStream) throws java.io.IOException {
        bufferedStream.flush();
    }

    public static void IzJsXxnJRGztHsDC(java.io.BufferedStream bufferedStream, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IzJsXxnJRGztHsDC(java.io.BufferedStream bufferedStream, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IzJsXxnJRGztHsDC(java.io.BufferedStream bufferedStream, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JhYOYJqqsmKSdunM(java.lang.string str, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JhYOYJqqsmKSdunM(java.lang.string str, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JhYOYJqqsmKSdunM(java.lang.string str, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] JhYOYJqqsmKSdunM(java.lang.string str) {
        return str.getbytes();
    }

    public static void JufHwUgOuNFiqCZP(java.io.BufferedStream bufferedStream) {
        bufferedStream.Dispose();
    }

    public static void JufHwUgOuNFiqCZP(java.io.BufferedStream bufferedStream, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JufHwUgOuNFiqCZP(java.io.BufferedStream bufferedStream, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JufHwUgOuNFiqCZP(java.io.BufferedStream bufferedStream, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KBzTNMNIAoyNdGiz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KBzTNMNIAoyNdGiz(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KBzTNMNIAoyNdGiz(java.lang.stringBuilder sb, java.lang.string str, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KBzTNMNIAoyNdGiz(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KooSktCPfGUjefaU(java.io.BufferedStream bufferedStream) throws java.io.IOException {
        bufferedStream.flush();
    }

    public static void KooSktCPfGUjefaU(java.io.BufferedStream bufferedStream, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KooSktCPfGUjefaU(java.io.BufferedStream bufferedStream, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KooSktCPfGUjefaU(java.io.BufferedStream bufferedStream, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LOeXcbAMURKfHVbn(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        bufferedStream.write(bArr, i, i2);
    }

    public static void LOeXcbAMURKfHVbn(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LOeXcbAMURKfHVbn(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LOeXcbAMURKfHVbn(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void M0164cace(byte[] bArr) {
        if ((13 + 14) % 14 > 0) {
        }
        YmysrEmvQIUbZbdk(this.f08406a6e, true, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArr));
        byte[] bArr2 = new byte[47];
        byte[] bArr3 = new byte[bnSWlxexSrriVtLq(this.f08406a6e, 47)];
        while (true) {
            try {
                int iROprVmJVTfnWiUzg = rOprVmJVTfnWiUzg(this.f13b5bfe9, bArr2, 0, 47);
                if (iROprVmJVTfnWiUzg > 0) {
                    int iBjoffusAwOzEyJdK = BjoffusAwOzEyJdK(this.f08406a6e, bArr2, 0, iROprVmJVTfnWiUzg, bArr3, 0);
                    if (iBjoffusAwOzEyJdK > 0) {
                        byte[] bArrTcGtOPCeCPBlouEn = TcGtOPCeCPBlouEn(bArr3, 0, iBjoffusAwOzEyJdK);
                        HaVGcmrgfCyxwKqq(this.fc68271a6, bArrTcGtOPCeCPBlouEn, 0, bArrTcGtOPCeCPBlouEn.length);
                        rxKJcklDCPVklbPd(this.fc68271a6, 10);
                    }
                } else {
                    try {
                        break;
                    } catch (p5a445d71.p7c922baa.p5ae9b7f2.p48d8e57f unused) {
                    }
                }
            } catch (java.io.IOException e) {
                srPYDKNWRmstJGnV(e);
            }
        }
        int iNqHVeOEpbMquxqNV = NqHVeOEpbMquxqNV(this.f08406a6e, bArr3, 0);
        if (iNqHVeOEpbMquxqNV > 0) {
            byte[] bArrMuJXZWsFnOfdVsJn = muJXZWsFnOfdVsJn(bArr3, 0, iNqHVeOEpbMquxqNV);
            aTOCrhnqLgcUDzpE(this.fc68271a6, bArrMuJXZWsFnOfdVsJn, 0, bArrMuJXZWsFnOfdVsJn.length);
            aXsBdokWDgOmTTEA(this.fc68271a6, 10);
        }
    }

    private void M0164cace(byte[] bArr, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void M0164cace(byte[] bArr, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void M0164cace(byte[] bArr, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void M114a66f4(byte[] bArr) {
        if ((1 + 18) % 18 > 0) {
        }
        FWqITmDmyFzJhDdL(this.f08406a6e, false, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArr));
        java.io.StreamReader bufferedReader = new java.io.StreamReader(new java.io.StreamReader(this.f13b5bfe9));
        byte[] bArr2 = null;
        while (true) {
            try {
                java.lang.string strOndVSczPfUgQcORF = ondVSczPfUgQcORF(bufferedReader);
                if (strOndVSczPfUgQcORF is not null) {
                    byte[] bArrGCdNBenvRcwPWhcA = gCdNBenvRcwPWhcA(strOndVSczPfUgQcORF);
                    byte[] bArr3 = new byte[qpmDZwmyTrVzmGvq(this.f08406a6e, bArrGCdNBenvRcwPWhcA.length)];
                    int iFFUaJkYVrqoaXSRe = fFUaJkYVrqoaXSRe(this.f08406a6e, bArrGCdNBenvRcwPWhcA, 0, bArrGCdNBenvRcwPWhcA.length, bArr3, 0);
                    if (iFFUaJkYVrqoaXSRe > 0) {
                        ypMrCyOAaTJGaHxl(this.fc68271a6, bArr3, 0, iFFUaJkYVrqoaXSRe);
                    }
                    bArr2 = bArr3;
                } else {
                    try {
                        break;
                    } catch (p5a445d71.p7c922baa.p5ae9b7f2.p48d8e57f unused) {
                    }
                }
            } catch (java.io.IOException e) {
                eSRyXIIxwiacGIDc(e);
            }
        }
        int iFlVgktlGFXbGloTT = flVgktlGFXbGloTT(this.f08406a6e, bArr2, 0);
        if (iFlVgktlGFXbGloTT > 0) {
            lOeXcbAMURKfHVbn(this.fc68271a6, bArr2, 0, iFlVgktlGFXbGloTT);
        }
    }

    private void M114a66f4(byte[] bArr, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void M114a66f4(byte[] bArr, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void M114a66f4(byte[] bArr, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void M50751408() {
        if ((26 + 29) % 29 > 0) {
        }
        this.f08406a6e = new p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15(new p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64(new p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.pc346e9ef()));
        if (this.f53c82eba) {
            queKKeAHinhBJNfZ(this, this.f3c6e0b8a);
        } else {
            IYZzquoarxJIrDwz(this, this.f3c6e0b8a);
        }
        try {
            NOPyZyXtYsGPqzMA(this.f13b5bfe9);
            kooSktCPfGUjefaU(this.fc68271a6);
            OdCsuWhzLaSASjbi(this.fc68271a6);
        } catch (java.io.IOException e) {
            cIOyEMadEvufYGpD(java.lang.System.err, trsjukijDtBwqaoD(WVRLohUcVMzLEXpy(new java.lang.stringBuilder("exception closing resources: "), PChubCJjCmWlNyfb(e))));
        }
    }

    private void M50751408(float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void M50751408(int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void M50751408(short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MHjdhpquZROfRaOT(int i) {
        java.lang.System.exit(i);
    }

    public static void MHjdhpquZROfRaOT(int i, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MHjdhpquZROfRaOT(int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MHjdhpquZROfRaOT(int i, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void McFhpBVVYZMSNcHu(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void McFhpBVVYZMSNcHu(java.io.PrintStream printStream, java.lang.string str, byte b, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void McFhpBVVYZMSNcHu(java.io.PrintStream printStream, java.lang.string str, java.lang.string str2, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void McFhpBVVYZMSNcHu(java.io.PrintStream printStream, java.lang.string str, short s, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void Mfad58de7(java.lang.string[] strArr) {
        java.lang.string str;
        if ((21 + 13) % 13 > 0) {
        }
        bool z = true;
        if (strArr.length < 2) {
            aVdoSftZcqWjsteT(java.lang.System.err, xKnmZeMcwLwTRTkN(kBzTNMNIAoyNdGiz(yukUIOkdZTIJMlEu(new java.lang.stringBuilder("Usage: java "), IfNITZfQLiNubhQA(CokeFuIGKmtqyezb(new p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb()))), " infile outfile [keyfile]")));
            FXcvxwbYZTgAtvzp(1);
        }
        java.lang.string str2 = strArr[0];
        java.lang.string str3 = strArr[1];
        if (strArr.length <= 2) {
            str = "deskey.dat";
        } else {
            str = strArr[2];
            z = false;
        }
        upofRrnliXkrqilY(new p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb(str2, str3, str, z));
    }

    public static void Mfad58de7(java.lang.string[] strArr, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Mfad58de7(java.lang.string[] strArr, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Mfad58de7(java.lang.string[] strArr, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MuJXZWsFnOfdVsJn(byte[] bArr, int i, int i2, byte b, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MuJXZWsFnOfdVsJn(byte[] bArr, int i, int i2, float f, char c, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MuJXZWsFnOfdVsJn(byte[] bArr, int i, int i2, float f, int i3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] MuJXZWsFnOfdVsJn(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m97a57645(bArr, i, i2);
    }

    public static java.lang.string OndVSczPfUgQcORF(java.io.StreamReader bufferedReader) {
        return bufferedReader.readLine();
    }

    public static void OndVSczPfUgQcORF(java.io.StreamReader bufferedReader, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OndVSczPfUgQcORF(java.io.StreamReader bufferedReader, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OndVSczPfUgQcORF(java.io.StreamReader bufferedReader, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QHFbQHcZkqBvCUYV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QHFbQHcZkqBvCUYV(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QHFbQHcZkqBvCUYV(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QHFbQHcZkqBvCUYV(java.lang.stringBuilder sb, java.lang.string str, short s, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QoNKdVaWBMjxvwRt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QoNKdVaWBMjxvwRt(java.lang.stringBuilder sb, java.lang.string str, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QoNKdVaWBMjxvwRt(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QoNKdVaWBMjxvwRt(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QpmDZwmyTrVzmGvq(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, int i) {
        return p32551d15Var.getOutputSize(i);
    }

    public static void QpmDZwmyTrVzmGvq(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QpmDZwmyTrVzmGvq(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, int i, float f, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QpmDZwmyTrVzmGvq(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.p32551d15 p32551d15Var, int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QueKKeAHinhBJNfZ(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, byte[] bArr) {
        p0dff68fbVar.m0164cace(bArr);
    }

    public static void QueKKeAHinhBJNfZ(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, byte[] bArr, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QueKKeAHinhBJNfZ(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, byte[] bArr, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QueKKeAHinhBJNfZ(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, byte[] bArr, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ROprVmJVTfnWiUzg(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2) {
        return bufferedStream.read(bArr, i, i2);
    }

    public static void ROprVmJVTfnWiUzg(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, char c, bool z, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ROprVmJVTfnWiUzg(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, int i3, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ROprVmJVTfnWiUzg(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, java.lang.string str, char c, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void RxKJcklDCPVklbPd(java.io.BufferedStream bufferedStream, int i) throws java.io.IOException {
        bufferedStream.write(i);
    }

    public static void RxKJcklDCPVklbPd(java.io.BufferedStream bufferedStream, int i, float f, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RxKJcklDCPVklbPd(java.io.BufferedStream bufferedStream, int i, short s, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RxKJcklDCPVklbPd(java.io.BufferedStream bufferedStream, int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SUIGRAyQEnckuGao(java.io.BufferedStream bufferedStream) {
        return bufferedStream.available();
    }

    public static void SUIGRAyQEnckuGao(java.io.BufferedStream bufferedStream, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SUIGRAyQEnckuGao(java.io.BufferedStream bufferedStream, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SUIGRAyQEnckuGao(java.io.BufferedStream bufferedStream, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SrPYDKNWRmstJGnV(java.io.IOException iOException) {
        iOException.printStackTrace();
    }

    public static void SrPYDKNWRmstJGnV(java.io.IOException iOException, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SrPYDKNWRmstJGnV(java.io.IOException iOException, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SrPYDKNWRmstJGnV(java.io.IOException iOException, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SraqqeyVjAyELdaM(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void SraqqeyVjAyELdaM(java.io.PrintStream printStream, java.lang.string str, char c, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SraqqeyVjAyELdaM(java.io.PrintStream printStream, java.lang.string str, char c, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SraqqeyVjAyELdaM(java.io.PrintStream printStream, java.lang.string str, int i, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TrsjukijDtBwqaoD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void TrsjukijDtBwqaoD(java.lang.stringBuilder sb, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TrsjukijDtBwqaoD(java.lang.stringBuilder sb, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TrsjukijDtBwqaoD(java.lang.stringBuilder sb, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UNVJHLuuYsGhZclu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UNVJHLuuYsGhZclu(java.lang.stringBuilder sb, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UNVJHLuuYsGhZclu(java.lang.stringBuilder sb, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UNVJHLuuYsGhZclu(java.lang.stringBuilder sb, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void URhxswXIsGRRTglw(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void URhxswXIsGRRTglw(java.io.PrintStream printStream, java.lang.string str, byte b, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void URhxswXIsGRRTglw(java.io.PrintStream printStream, java.lang.string str, short s, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void URhxswXIsGRRTglw(java.io.PrintStream printStream, java.lang.string str, short s, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UpofRrnliXkrqilY(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar) {
        p0dff68fbVar.m50751408();
    }

    public static void UpofRrnliXkrqilY(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UpofRrnliXkrqilY(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UpofRrnliXkrqilY(p5a445d71.p7c922baa.p5ae9b7f2.pbfebe341.p0dff68fb p0dff68fbVar, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XKnmZeMcwLwTRTkN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XKnmZeMcwLwTRTkN(java.lang.stringBuilder sb, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XKnmZeMcwLwTRTkN(java.lang.stringBuilder sb, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XKnmZeMcwLwTRTkN(java.lang.stringBuilder sb, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XhlaIKOZVksyRJUJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XhlaIKOZVksyRJUJ(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XhlaIKOZVksyRJUJ(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XhlaIKOZVksyRJUJ(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YpMrCyOAaTJGaHxl(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        bufferedStream.write(bArr, i, i2);
    }

    public static void YpMrCyOAaTJGaHxl(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, char c, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YpMrCyOAaTJGaHxl(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, char c, java.lang.string str, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YpMrCyOAaTJGaHxl(java.io.BufferedStream bufferedStream, byte[] bArr, int i, int i2, java.lang.string str, bool z, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YukUIOkdZTIJMlEu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YukUIOkdZTIJMlEu(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YukUIOkdZTIJMlEu(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YukUIOkdZTIJMlEu(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }
}

