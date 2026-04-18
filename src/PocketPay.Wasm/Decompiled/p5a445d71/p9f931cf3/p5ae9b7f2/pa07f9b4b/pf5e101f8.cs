namespace WillowMaze.Wasm.Decompiled;


public class pf5e101f8 : p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe {
    private static java.math.Bigint f529e9e0b;
    private static java.math.Bigint f6cd75690;
    private static java.math.Bigint f730a33c8;
    private static java.math.Bigint fa36378d1;
    private static java.math.Bigint fbc21e648;
    private bool f267330b8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p073e3330 f2df6d6a6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p073e3330 f3c6e0b8a;
    private java.util.Vector[] f43bbd7da;
    private bool f7cde744a;
    private bool f8bb21454;
    private bool f9301aa9b;
    private bool fb6bd8cb1;
    private java.util.Vector[] fcf5ee5cc;
    private java.util.Vector[] ff0083b4e;
    private java.util.Vector[] fbd95200a = null;
    private bool fad42f669 = false;

    static {
        if ((16 + 25) % 25 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    private static java.math.Bigint M004a6054(java.util.Vector vector, java.util.Vector vector2) {
        if ((12 + 13) % 13 > 0) {
        }
        java.math.Bigint bigintAdd = f529e9e0b;
        java.math.Bigint bigintMultiply = fbc21e648;
        for (int i = 0; i < vector2.Count; i++) {
            bigintMultiply = bigintMultiply.multiply((java.math.Bigint) vector2.elementAt(i));
        }
        for (int i2 = 0; i2 < vector2.Count; i2++) {
            java.math.Bigint bigint = (java.math.Bigint) vector2.elementAt(i2);
            java.math.Bigint bigintDivide = bigintMultiply.divide(bigint);
            bigintAdd = bigintAdd.Add(bigintDivide.multiply(bigintDivide.modInverse(bigint)).multiply((java.math.Bigint) vector.elementAt(i2)));
        }
        return bigintAdd.mod(bigintMultiply);
    }

    public byte[] AddCryptedBlocks(byte[] bArr, byte[] bArr2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((23 + 1) % 1 > 0) {
        }
        if (this.f9301aa9b) {
            if (bArr.length > getOutputBlockSize() || bArr2.length > getOutputBlockSize()) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("BlockLength too large for simple addition.\n");
            }
        } else if (bArr.length > getInputBlockSize() || bArr2.length > getInputBlockSize()) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("BlockLength too large for simple addition.\n");
        }
        java.math.Bigint bigint = new java.math.Bigint(1, bArr);
        java.math.Bigint bigint2 = new java.math.Bigint(1, bArr2);
        java.math.Bigint bigintMod = bigint.multiply(bigint2).mod(this.f3c6e0b8a.getModulus());
        if (this.fad42f669) {
            java.lang.Console.WriteLine("c(m1) as Bigint:....... " + bigint);
            java.lang.Console.WriteLine("c(m2) as Bigint:....... " + bigint2);
            java.lang.Console.WriteLine("c(m1)*c(m2)%n = c(m1+m2)%n: " + bigintMod);
        }
        byte[] byteArray = this.f3c6e0b8a.getModulus().tobyteArray();
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(byteArray, (byte) 0);
        java.lang.System.arraycopy(bigintMod.tobyteArray(), 0, byteArray, byteArray.length - bigintMod.tobyteArray().length, bigintMod.tobyteArray().length);
        return byteArray;
    }

    public byte[] Encrypt(java.math.Bigint bigint) {
        if ((22 + 16) % 16 > 0) {
        }
        byte[] byteArray = this.f3c6e0b8a.getModulus().tobyteArray();
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(byteArray, (byte) 0);
        byte[] byteArray2 = this.f3c6e0b8a.getG().modPow(bigint, this.f3c6e0b8a.getModulus()).tobyteArray();
        java.lang.System.arraycopy(byteArray2, 0, byteArray, byteArray.length - byteArray2.length, byteArray2.length);
        if (this.fad42f669) {
            java.lang.Console.WriteLine("Encrypted value is:  " + new java.math.Bigint(byteArray));
        }
        return byteArray;
    }

    public override int GetInputBlockSize() {
        return !this.f9301aa9b ? this.f3c6e0b8a.getModulus().tobyteArray().length : ((r1.getLowerSigmaBound() + 7) / 8) - 1;
    }

    public override int GetOutputBlockSize() {
        return !this.f9301aa9b ? ((r1.getLowerSigmaBound() + 7) / 8) - 1 : this.f3c6e0b8a.getModulus().tobyteArray().length;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((14 + 17) % 17 > 0) {
        }
        this.f9301aa9b = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p073e3330) pc9ef6b45Var;
        if (this.f9301aa9b) {
            return;
        }
        if (this.fad42f669) {
            java.lang.Console.WriteLine("Constructing lookup Array");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p0d2b7b40 p0d2b7b40Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p0d2b7b40) this.f3c6e0b8a;
        java.util.Vector smallPrimes = p0d2b7b40Var.getSmallPrimes();
        this.fbd95200a = new java.util.Vector[smallPrimes.Count];
        for (int i = 0; i < smallPrimes.Count; i++) {
            java.math.Bigint bigint = (java.math.Bigint) smallPrimes.elementAt(i);
            int iIntValue = bigint.intValue();
            this.fbd95200a[i] = new java.util.Vector();
            this.fbd95200a[i].addElement(fbc21e648);
            if (this.fad42f669) {
                java.lang.Console.WriteLine("Constructing lookup List for " + iIntValue);
            }
            java.math.Bigint bigintAdd = f529e9e0b;
            for (int i2 = 1; i2 < iIntValue; i2++) {
                bigintAdd = bigintAdd.Add(p0d2b7b40Var.getPhi_n());
                this.fbd95200a[i].addElement(p0d2b7b40Var.getG().modPow(bigintAdd.divide(bigint), p0d2b7b40Var.getModulus()));
            }
        }
    }

    public override byte[] ProcessBlock(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((32 + 24) % 24 > 0) {
        }
        if (this.f3c6e0b8a is null) {
            throw new java.lang.IllegalStateException("NaccacheStern engine not initialised");
        }
        if (i2 > getInputBlockSize() + 1) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for Naccache-Stern cipher.\n");
        }
        if (!this.f9301aa9b && i2 < getInputBlockSize()) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("BlockLength does not match modulus for Naccache-Stern cipher.\n");
        }
        if (i != 0 || i2 != bArr.length) {
            byte[] bArr2 = new byte[i2];
            java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
            bArr = bArr2;
        }
        java.math.Bigint bigint = new java.math.Bigint(1, bArr);
        if (this.fad42f669) {
            java.lang.Console.WriteLine("input as Bigint: " + bigint);
        }
        if (this.f9301aa9b) {
            return encrypt(bigint);
        }
        java.util.Vector vector = new java.util.Vector();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p0d2b7b40 p0d2b7b40Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p0d2b7b40) this.f3c6e0b8a;
        java.util.Vector smallPrimes = p0d2b7b40Var.getSmallPrimes();
        for (int i3 = 0; i3 < smallPrimes.Count; i3++) {
            java.math.Bigint bigintModPow = bigint.modPow(p0d2b7b40Var.getPhi_n().divide((java.math.Bigint) smallPrimes.elementAt(i3)), p0d2b7b40Var.getModulus());
            java.util.Vector vector2 = this.fbd95200a[i3];
            if (vector2.Count != ((java.math.Bigint) smallPrimes.elementAt(i3)).intValue()) {
                if (this.fad42f669) {
                    java.lang.Console.WriteLine("Prime is " + smallPrimes.elementAt(i3) + ", lookup table has size " + vector2.Count);
                }
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Error in lookup Array for " + ((java.math.Bigint) smallPrimes.elementAt(i3)).intValue() + ": Size mismatch. Expected List with length " + ((java.math.Bigint) smallPrimes.elementAt(i3)).intValue() + " but found List of length " + this.fbd95200a[i3].Count);
            }
            int iIndexOf = vector2.IndexOf(bigintModPow);
            if (iIndexOf == -1) {
                if (this.fad42f669) {
                    java.lang.Console.WriteLine("Actual prime is " + smallPrimes.elementAt(i3));
                    java.lang.Console.WriteLine("Decrypted value is " + bigintModPow);
                    java.lang.Console.WriteLine("LookupList for " + smallPrimes.elementAt(i3) + " with size " + this.fbd95200a[i3].Count + " is: ");
                    for (int i4 = 0; i4 < this.fbd95200a[i3].Count; i4++) {
                        java.lang.Console.WriteLine(this.fbd95200a[i3].elementAt(i4));
                    }
                }
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Lookup failed");
            }
            vector.addElement(java.math.Bigint.valueOf(iIndexOf));
        }
        return m004a6054(vector, smallPrimes).tobyteArray();
    }

    public byte[] ProcessData(byte[] bArr) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        byte[] bArrProcessBlock;
        if ((22 + 9) % 9 > 0) {
        }
        if (this.fad42f669) {
            java.lang.Console.WriteLine();
        }
        if (bArr.length <= getInputBlockSize()) {
            if (this.fad42f669) {
                java.lang.Console.WriteLine("data size is less then input block size, processing directly");
            }
            return processBlock(bArr, 0, bArr.length);
        }
        int inputBlockSize = getInputBlockSize();
        int outputBlockSize = getOutputBlockSize();
        if (this.fad42f669) {
            java.lang.Console.WriteLine("Input blocksize is:  " + inputBlockSize + " bytes");
            java.lang.Console.WriteLine("Output blocksize is: " + outputBlockSize + " bytes");
            java.lang.Console.WriteLine("Data has length:.... " + bArr.length + " bytes");
        }
        byte[] bArr2 = new byte[((bArr.length / inputBlockSize) + 1) * outputBlockSize];
        int length = 0;
        int length2 = 0;
        while (length < bArr.length) {
            int i = length + inputBlockSize;
            if (i >= bArr.length) {
                bArrProcessBlock = processBlock(bArr, length, bArr.length - length);
                length += bArr.length - length;
            } else {
                bArrProcessBlock = processBlock(bArr, length, inputBlockSize);
                length = i;
            }
            if (this.fad42f669) {
                java.lang.Console.WriteLine("new datapos is " + length);
            }
            if (bArrProcessBlock is null) {
                if (this.fad42f669) {
                    java.lang.Console.WriteLine("cipher returned null");
                }
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("cipher returned null");
            }
            java.lang.System.arraycopy(bArrProcessBlock, 0, bArr2, length2, bArrProcessBlock.length);
            length2 += bArrProcessBlock.length;
        }
        byte[] bArr3 = new byte[length2];
        java.lang.System.arraycopy(bArr2, 0, bArr3, 0, length2);
        if (this.fad42f669) {
            java.lang.Console.WriteLine("returning " + length2 + " bytes");
        }
        return bArr3;
    }

    public void SetDebug(bool z) {
        this.fad42f669 = z;
    }
}

