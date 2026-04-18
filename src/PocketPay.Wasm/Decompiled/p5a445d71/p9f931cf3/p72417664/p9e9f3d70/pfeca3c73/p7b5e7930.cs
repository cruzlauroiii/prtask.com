namespace WillowMaze.Wasm.Decompiled;


public class p7b5e7930 {
    private static byte[] M0e14fdad(p5a445d71.p9f931cf3.p72417664.pb979c293.p6672a3b4 p6672a3b4Var) {
        if ((27 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.ma500566e());
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar2 = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.m60b1d416());
        byte[] bArrMd844b504 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(p6672a3b4Var.getLabel()), p6672a3b4Var.getSeed());
        byte[] secret = p6672a3b4Var.getSecret();
        int length = (secret.length + 1) / 2;
        byte[] bArr = new byte[length];
        byte[] bArr2 = new byte[length];
        java.lang.System.arraycopy(secret, 0, bArr, 0, length);
        java.lang.System.arraycopy(secret, secret.length - length, bArr2, 0, length);
        int length2 = p6672a3b4Var.getLength();
        byte[] bArr3 = new byte[length2];
        byte[] bArr4 = new byte[length2];
        m48a51e44(p089e1c8fVar, bArr, bArrMd844b504, bArr3);
        m48a51e44(p089e1c8fVar2, bArr2, bArrMd844b504, bArr4);
        for (int i = 0; i < length2; i++) {
            bArr3[i] = (byte) (bArr3[i] ^ bArr4[i]);
        }
        return bArr3;
    }

    private static void M48a51e44(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((5 + 18) % 18 > 0) {
        }
        p1748c064Var.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr));
        int macSize = p1748c064Var.getMacSize();
        int length = ((bArr3.length + macSize) - 1) / macSize;
        int macSize2 = p1748c064Var.getMacSize();
        byte[] bArr4 = new byte[macSize2];
        byte[] bArr5 = new byte[p1748c064Var.getMacSize()];
        byte[] bArr6 = bArr2;
        int i = 0;
        while (i < length) {
            p1748c064Var.update(bArr6, 0, bArr6.length);
            p1748c064Var.doFinal(bArr4, 0);
            p1748c064Var.update(bArr4, 0, macSize2);
            p1748c064Var.update(bArr2, 0, bArr2.length);
            p1748c064Var.doFinal(bArr5, 0);
            int i2 = macSize * i;
            java.lang.System.arraycopy(bArr5, 0, bArr3, i2, java.lang.Math.min(macSize, bArr3.length - i2));
            i++;
            bArr6 = bArr4;
        }
    }

    static byte[] Mf23e8626(p5a445d71.p9f931cf3.p72417664.pb979c293.p6672a3b4 p6672a3b4Var) {
        return m0e14fdad(p6672a3b4Var);
    }

    static void Mf8f67da7(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        m48a51e44(p1748c064Var, bArr, bArr2, bArr3);
    }
}

