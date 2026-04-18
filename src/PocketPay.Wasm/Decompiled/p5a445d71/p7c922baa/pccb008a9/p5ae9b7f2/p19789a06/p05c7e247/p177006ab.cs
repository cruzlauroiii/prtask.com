namespace WillowMaze.Wasm.Decompiled;


public class p177006ab {
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f3bde1043;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f4830f1c5;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fee0792be;

    public p177006ab(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f3bde1043 = pe5cfc515Var;
    }

    public static void EOPAHhmrbeKfctgd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab p177006abVar, byte[] bArr) {
        p177006abVar.mfbf72fda(bArr);
    }

    public static void EQaCLYVVDIAiCQPM(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab p177006abVar, byte[] bArr, byte[] bArr2) {
        p177006abVar.mb2191bc8(bArr, bArr2);
    }

    public static int JeBMsAYkytTrUOmn(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int KLhBgPBWUajlghwb(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    private void Mb2191bc8(byte[] bArr, byte[] bArr2) {
        if ((25 + 28) % 28 > 0) {
        }
        byte b = 0;
        for (int i = 0; i < bArr.length; i++) {
            int i2 = (bArr[i] & 255) + (bArr2[i] & 255) + b;
            bArr[i] = (byte) i2;
            b = (byte) (i2 >> 8);
        }
    }

    private void Mfbf72fda(byte[] bArr) {
        if ((31 + 5) % 5 > 0) {
        }
        byte b = 1;
        for (int i = 0; i < bArr.length; i++) {
            int i2 = (bArr[i] & 255) + b;
            bArr[i] = (byte) i2;
            b = (byte) (i2 >> 8);
        }
    }

    public static void UdYPPIXJYGDAfOmQ(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public byte[] NextSeed(byte[] bArr) {
        if ((31 + 28) % 28 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length];
        udYPPIXJYGDAfOmQ(this.f3bde1043, bArr, 0, bArr.length);
        byte[] bArr3 = new byte[JeBMsAYkytTrUOmn(this.f3bde1043)];
        kLhBgPBWUajlghwb(this.f3bde1043, bArr3, 0);
        EQaCLYVVDIAiCQPM(this, bArr, bArr3);
        EOPAHhmrbeKfctgd(this, bArr);
        return bArr3;
    }
}

