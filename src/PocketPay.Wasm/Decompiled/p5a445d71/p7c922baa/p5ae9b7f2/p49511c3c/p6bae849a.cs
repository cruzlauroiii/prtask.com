namespace WillowMaze.Wasm.Decompiled;


public class p6bae849a : p5a445d71.p7c922baa.p5ae9b7f2.pc953f774 {
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f2bf0077b;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;

    public p6bae849a(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
    }

    public static java.lang.stringBuilder ACNDrtdLCSCBRHec(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] AUAOCyWvWQHxgWAg(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p6bae849a p6bae849aVar) {
        return p6bae849aVar.mde3e38ba();
    }

    public static byte[] EDRvRkgdEwMvjFHW(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p6bae849a p6bae849aVar) {
        return p6bae849aVar.mde3e38ba();
    }

    public static int LbGzkxjgMFhlNbUu(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.lang.string MlcdQzDSaKJJQWVW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PUeKfJoQUhYPgoSQ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void PcBKLWEtpfmaZUrl(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 UYZPmnShTpoAkKmC(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p6bae849a p6bae849aVar, int i) {
        return p6bae849aVar.generateDerivedParameters(i);
    }

    public static int WoxbcUjyGDlzHPMh(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static java.lang.stringBuilder WwGuHngTBxXrjpAc(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int AFMrFMKNdpGlzdCc(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void DVoAMVEHHPhDdGJF(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static java.lang.string HQTjQtJesigKxUUS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder IfKIKGIPzvixHjyj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private byte[] Mde3e38ba() {
        if ((1 + 25) % 25 > 0) {
        }
        int iLbGzkxjgMFhlNbUu = LbGzkxjgMFhlNbUu(this.fc10f7796);
        byte[] bArr = new byte[iLbGzkxjgMFhlNbUu];
        dVoAMVEHHPhDdGJF(this.fc10f7796, this.f5f4dcc3b, 0, this.f5f4dcc3b.length);
        PcBKLWEtpfmaZUrl(this.fc10f7796, this.fceb20772, 0, this.fceb20772.length);
        WoxbcUjyGDlzHPMh(this.fc10f7796, bArr, 0);
        for (int i = 1; i < this.f40e092b2; i++) {
            xgWzxWZSDrxmrcxC(this.fc10f7796, bArr, 0, iLbGzkxjgMFhlNbUu);
            wJDATYCcytfZToiP(this.fc10f7796, bArr, 0);
        }
        return bArr;
    }

    public static int VXajzFAvkexHbbkj(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int WJDATYCcytfZToiP(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void XgWzxWZSDrxmrcxC(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedMacParameters(int i) {
        return UYZPmnShTpoAkKmC(this, i);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i) {
        if ((9 + 6) % 6 > 0) {
        }
        int i2 = i / 8;
        if (i2 > aFMrFMKNdpGlzdCc(this.fc10f7796)) {
            throw new java.lang.IllegalArgumentException(MlcdQzDSaKJJQWVW(ACNDrtdLCSCBRHec(PUeKfJoQUhYPgoSQ(new java.lang.stringBuilder("Can't generate a derived key "), i2), " bytes long.")));
        }
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(EDRvRkgdEwMvjFHW(this), 0, i2);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i, int i2) {
        if ((14 + 10) % 10 > 0) {
        }
        int i3 = i / 8;
        int i4 = i2 / 8;
        int i5 = i3 + i4;
        if (i5 > vXajzFAvkexHbbkj(this.fc10f7796)) {
            throw new java.lang.IllegalArgumentException(hQTjQtJesigKxUUS(ifKIKGIPzvixHjyj(WwGuHngTBxXrjpAc(new java.lang.stringBuilder("Can't generate a derived key "), i5), " bytes long.")));
        }
        byte[] bArrAUAOCyWvWQHxgWAg = AUAOCyWvWQHxgWAg(this);
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArrAUAOCyWvWQHxgWAg, 0, i3), bArrAUAOCyWvWQHxgWAg, i3, i4);
    }
}

