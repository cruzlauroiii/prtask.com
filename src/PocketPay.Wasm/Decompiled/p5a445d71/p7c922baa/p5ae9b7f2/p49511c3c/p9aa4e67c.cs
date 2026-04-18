namespace WillowMaze.Wasm.Decompiled;


public class p9aa4e67c : p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 {
    private byte[] f004d9ad7;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f9842e92f;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fa123585d;
    private int fb0013e59;
    private int fb319422e;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;
    private byte[] fc8e25da1;
    private byte[] fcc603659;
    private byte[] ffe4c0f30;

    public p9aa4e67c(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
        this.fb0013e59 = jWhkZxellgOAJyTf(pe5cfc515Var);
    }

    public static void EAbfZeygjNKahMsn(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void OOQRrAUOUyJRWata(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p9aa4e67c p9aa4e67cVar, int i, byte[] bArr) {
        p9aa4e67cVar.m634ed66f(i, bArr);
    }

    public static void PJaDnvXiFTJemRqb(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
    }

    public static void QVpwZufXbrNvtemW(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void TrpEygwoZTvmleen(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p9aa4e67c p9aa4e67cVar, int i, byte[] bArr) {
        p9aa4e67cVar.m634ed66f(i, bArr);
    }

    public static int VQUQnLGtBvoTxDMj(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void WdgJkBzXRzqtHXYN(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void ZOjvsqYhhvtpjjFG(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int BPXDiheoJYCgjLcp(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static int JWhkZxellgOAJyTf(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    private void M634ed66f(int i, byte[] bArr) {
        bArr[0] = (byte) (i >>> 24);
        bArr[1] = (byte) (i >>> 16);
        bArr[2] = (byte) (i >>> 8);
        bArr[3] = (byte) i;
    }

    public static void MoXjJTnNyrJCNcaS(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static byte[] VCadYYDHBeezHSWZ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2fcfd194 p2fcfd194Var) {
        return p2fcfd194Var.getSeed();
    }

    public static void YQKaCcedAQFImaog(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws java.lang.IllegalArgumentException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        int i3;
        if ((1 + 13) % 13 > 0) {
        }
        if (bArr.length - i2 < i) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too small");
        }
        byte[] bArr2 = new byte[this.fb0013e59];
        byte[] bArr3 = new byte[4];
        PJaDnvXiFTJemRqb(this.fc10f7796);
        if (i2 <= this.fb0013e59) {
            i3 = 0;
        } else {
            i3 = 0;
            do {
                TrpEygwoZTvmleen(this, i3, bArr3);
                p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
                byte[] bArr4 = this.ffe4c0f30;
                moXjJTnNyrJCNcaS(pe5cfc515Var, bArr4, 0, bArr4.length);
                ZOjvsqYhhvtpjjFG(this.fc10f7796, bArr3, 0, 4);
                VQUQnLGtBvoTxDMj(this.fc10f7796, bArr2, 0);
                int i4 = this.fb0013e59;
                yQKaCcedAQFImaog(bArr2, 0, bArr, (i3 * i4) + i, i4);
                i3++;
            } while (i3 < i2 / this.fb0013e59);
        }
        if (this.fb0013e59 * i3 < i2) {
            OOQRrAUOUyJRWata(this, i3, bArr3);
            p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var2 = this.fc10f7796;
            byte[] bArr5 = this.ffe4c0f30;
            EAbfZeygjNKahMsn(pe5cfc515Var2, bArr5, 0, bArr5.length);
            QVpwZufXbrNvtemW(this.fc10f7796, bArr3, 0, 4);
            bPXDiheoJYCgjLcp(this.fc10f7796, bArr2, 0);
            int i5 = this.fb0013e59;
            WdgJkBzXRzqtHXYN(bArr2, 0, bArr, i + (i3 * i5), i2 - (i3 * i5));
        }
        return i2;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.p873e950b p873e950bVar) {
        if (!(p873e950bVar is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2fcfd194)) {
            throw new java.lang.IllegalArgumentException("MGF parameters required for MGF1Generator");
        }
        this.ffe4c0f30 = vCadYYDHBeezHSWZ((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2fcfd194) p873e950bVar);
    }
}

