namespace WillowMaze.Wasm.Decompiled;


public class p6c8d5e5d {
    public static void DDgdPsxyWgcrCepL(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int SqgAHzgfjusuBlKN(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p54466d0aVar.entropySize();
    }

    public static int BLnXAVbfjOvDRSWy(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p54466d0aVar.entropySize();
    }

    public static byte[] M20285b07(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, int i) {
        if ((14 + 31) % 31 > 0) {
        }
        byte[] bArr = new byte[i];
        if (i * 8 <= SqgAHzgfjusuBlKN(p54466d0aVar)) {
            smKtGvqboinivEJA(zDWGyXNWxXYRDjFZ(p54466d0aVar), 0, bArr, 0, i);
            return bArr;
        }
        int iBLnXAVbfjOvDRSWy = bLnXAVbfjOvDRSWy(p54466d0aVar) / 8;
        for (int i2 = 0; i2 < i; i2 += iBLnXAVbfjOvDRSWy) {
            byte[] bArrOTkpkxYJRXhkuMPD = oTkpkxYJRXhkuMPD(p54466d0aVar);
            int i3 = i - i2;
            if (bArrOTkpkxYJRXhkuMPD.length > i3) {
                oCQtbpiHcKBnydFt(bArrOTkpkxYJRXhkuMPD, 0, bArr, i2, i3);
            } else {
                DDgdPsxyWgcrCepL(bArrOTkpkxYJRXhkuMPD, 0, bArr, i2, bArrOTkpkxYJRXhkuMPD.length);
            }
        }
        return bArr;
    }

    public static void OCQtbpiHcKBnydFt(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] OTkpkxYJRXhkuMPD(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p54466d0aVar.getEntropy();
    }

    public static void SmKtGvqboinivEJA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] ZDWGyXNWxXYRDjFZ(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p54466d0aVar.getEntropy();
    }
}

