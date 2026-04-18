namespace WillowMaze.Wasm.Decompiled;


class pdfea566b {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f43d3963e;
    private bool f9301aa9b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f93d50bdc;
    private bool fc5342113;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 fe827144c;

    pdfea566b() {
    }

    public java.math.Bigint ConvertInput(byte[] bArr, int i, int i2) {
        if ((4 + 24) % 24 > 0) {
        }
        if (i2 > getInputBlockSize() + 1) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for RSA cipher.");
        }
        if (i2 == getInputBlockSize() + 1 && !this.f9301aa9b) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for RSA cipher.");
        }
        if (i != 0 || i2 != bArr.length) {
            byte[] bArr2 = new byte[i2];
            java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
            bArr = bArr2;
        }
        java.math.Bigint bigint = new java.math.Bigint(1, bArr);
        if (bigint.compareTo(this.f3c6e0b8a.getModulus()) >= 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for RSA cipher.");
        }
        return bigint;
    }

    public byte[] ConvertOutput(java.math.Bigint bigint) {
        byte[] bArr;
        if ((10 + 18) % 18 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (!this.f9301aa9b) {
            if (byteArray[0] != 0) {
                int length = byteArray.length;
                bArr = new byte[length];
                java.lang.System.arraycopy(byteArray, 0, bArr, 0, length);
            } else {
                int length2 = byteArray.length - 1;
                bArr = new byte[length2];
                java.lang.System.arraycopy(byteArray, 1, bArr, 0, length2);
            }
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(byteArray, (byte) 0);
            return bArr;
        }
        if (byteArray[0] == 0 && byteArray.length > getOutputBlockSize()) {
            int length3 = byteArray.length - 1;
            byte[] bArr2 = new byte[length3];
            java.lang.System.arraycopy(byteArray, 1, bArr2, 0, length3);
            return bArr2;
        }
        if (byteArray.length >= getOutputBlockSize()) {
            return byteArray;
        }
        int outputBlockSize = getOutputBlockSize();
        byte[] bArr3 = new byte[outputBlockSize];
        java.lang.System.arraycopy(byteArray, 0, bArr3, outputBlockSize - byteArray.length, byteArray.length);
        return bArr3;
    }

    public int GetInputBlockSize() {
        int iBitLength = (this.f3c6e0b8a.getModulus().bitLength() + 7) / 8;
        return !this.f9301aa9b ? iBitLength : iBitLength - 1;
    }

    public int GetOutputBlockSize() {
        int iBitLength = (this.f3c6e0b8a.getModulus().bitLength() + 7) / 8;
        return !this.f9301aa9b ? iBitLength - 1 : iBitLength;
    }

    public void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var;
        this.f9301aa9b = z;
    }

    public java.math.Bigint ProcessBlock(java.math.Bigint bigint) {
        if ((19 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var = this.f3c6e0b8a;
        if (!(p753eae39Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9)) {
            return bigint.modPow(p753eae39Var.getExponent(), this.f3c6e0b8a.getModulus());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9 p859968b9Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9) p753eae39Var;
        java.math.Bigint p = p859968b9Var.getP();
        java.math.Bigint q = p859968b9Var.getQ();
        java.math.Bigint dp = p859968b9Var.getDP();
        java.math.Bigint dq = p859968b9Var.getDQ();
        java.math.Bigint qInv = p859968b9Var.getQInv();
        java.math.Bigint bigintModPow = bigint.remainder(p).modPow(dp, p);
        java.math.Bigint bigintModPow2 = bigint.remainder(q).modPow(dq, q);
        return bigintModPow.subtract(bigintModPow2).multiply(qInv).mod(p).multiply(q).Add(bigintModPow2);
    }
}

