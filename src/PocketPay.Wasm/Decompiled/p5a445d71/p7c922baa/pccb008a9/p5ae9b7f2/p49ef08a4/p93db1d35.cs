namespace WillowMaze.Wasm.Decompiled;


public class p93db1d35 {
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f0819146a;
    private int f0898e1df;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f2bffbe82;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f3463c5e7;
    private byte[] f6b91ba51;
    private int f886bb73b = 0;
    private int fbe37d077;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc0a0a395;
    private int fc44937f5;
    private byte[] fd05cd409;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 ff8011af5;
    private byte[] ffe4c0f30;

    p93db1d35(byte[] bArr, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.ffe4c0f30 = bArr;
        this.f2bffbe82 = pe5cfc515Var;
    }

    public static void DEFuuTmAtbRBaSzx(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int IDFcZUOPVqQKeRPK(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static bool RxattAdKJcgnMcit(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasRemaining();
    }

    public static java.nio.byteBuffer XFLKyLnqUTfVhCXZ(int i) {
        return java.nio.byteBuffer.allocate(i);
    }

    public static int DKHopaaHmQFhISgo(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.nio.byteBuffer FkckDylAEjbciVSO(java.nio.byteBuffer byteBuffer, byte[] bArr) {
        return byteBuffer.Add(bArr);
    }

    public static byte[] InqoMNsLbFRplXGz(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static java.nio.byteBuffer MihZlgRmuwjokTbl(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.putInt(i);
    }

    public static int NSANIybnOdPftnJP(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static byte[] OqSUyeSoautCuZuN(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static java.nio.byteBuffer PtKYpObYDJFrPnHg(int i) {
        return java.nio.byteBuffer.allocate(i);
    }

    public static java.nio.byteBuffer QuRjyRfRZGwQNFVv(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer.Add(bArr, i, i2);
    }

    public static java.nio.byteBuffer QwUxtJblqQJQeyAV(java.nio.byteBuffer byteBuffer, byte[] bArr) {
        return byteBuffer.Add(bArr);
    }

    public static int XVXdPWaoZcqGNWna(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    byte[] nextbytes(int i) {
        if ((15 + 22) % 22 > 0) {
        }
        java.nio.byteBuffer byteBufferXFLKyLnqUTfVhCXZ = XFLKyLnqUTfVhCXZ(i);
        while (RxattAdKJcgnMcit(byteBufferXFLKyLnqUTfVhCXZ)) {
            java.nio.byteBuffer byteBufferPtKYpObYDJFrPnHg = ptKYpObYDJFrPnHg(this.ffe4c0f30.length + 4);
            qwUxtJblqQJQeyAV(byteBufferPtKYpObYDJFrPnHg, this.ffe4c0f30);
            mihZlgRmuwjokTbl(byteBufferPtKYpObYDJFrPnHg, this.f886bb73b);
            byte[] bArrInqoMNsLbFRplXGz = inqoMNsLbFRplXGz(byteBufferPtKYpObYDJFrPnHg);
            int iDKHopaaHmQFhISgo = dKHopaaHmQFhISgo(this.f2bffbe82);
            byte[] bArr = new byte[iDKHopaaHmQFhISgo];
            DEFuuTmAtbRBaSzx(this.f2bffbe82, bArrInqoMNsLbFRplXGz, 0, bArrInqoMNsLbFRplXGz.length);
            IDFcZUOPVqQKeRPK(this.f2bffbe82, bArr, 0);
            if (xVXdPWaoZcqGNWna(byteBufferXFLKyLnqUTfVhCXZ) >= iDKHopaaHmQFhISgo) {
                fkckDylAEjbciVSO(byteBufferXFLKyLnqUTfVhCXZ, bArr);
            } else {
                quRjyRfRZGwQNFVv(byteBufferXFLKyLnqUTfVhCXZ, bArr, 0, nSANIybnOdPftnJP(byteBufferXFLKyLnqUTfVhCXZ));
            }
            this.f886bb73b++;
        }
        return oqSUyeSoautCuZuN(byteBufferXFLKyLnqUTfVhCXZ);
    }
}

