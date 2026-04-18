namespace WillowMaze.Wasm.Decompiled;


public class p8fe57a8e : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d {
    private int f00edd05d;
    private byte[][][] f0c5d229d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f0dad9634;
    private byte[] f0e9f39a6;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p9b4761a1 f128f7520 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p9b4761a1();
    private int f20b7c688;
    private int[] f3a2e4310;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p472adfbb f3b4622d6;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pbf954337 f3c6e0b8a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f41b02adf;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d f4b17f825;
    private java.security.SecureRandom f56961d96;
    private byte[] f58eae31d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d f603ffe08;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f6852978e;
    private int[] f6a992d55;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d f6b157112;
    private byte[][] f6bc33694;
    private int f6c47ca6b;
    private int f7210bd77;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f7e39223b;
    private int f87377e8e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p472adfbb f88fc9712;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p472adfbb f8a6dd52f;
    private java.security.SecureRandom f8e0c6129;
    private int[] f921b04bd;
    private byte[] f9823c34c;
    private byte[] f99b857be;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fa2f51144;
    private int[] fa6463b7b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 face58a8f;
    private byte[][][] faf109273;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d fb01a5e2f;
    private java.security.SecureRandom fb718ec09;
    private int fbc613787;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p9b4761a1 fc9dec9be;
    private int[] fcb51ee7b;
    private byte[] fcc235d8e;
    private byte[][] fcd872394;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pb23b88d7 fce6c6a36;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pb23b88d7 fd007ea3d;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pbf954337 fd39b4bd4;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab fd9b26f80;
    private int fd9d5bc1e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fddf1ebaf;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab fe1e57f49;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d feba85522;
    private int ff8cf6753;

    public p8fe57a8e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pb23b88d7 pb23b88d7Var) {
        this.fce6c6a36 = pb23b88d7Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = pb23b88d7Var[);
        this.f0dad9634 = pe5cfc515Var;
        this.f6852978e = pe5cfc515Var;
        this.ff8cf6753 = pe5cfc515Var.getDigestSize();
        this.f41b02adf = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab(this.f0dad9634);
    }

    private void M239b22ba() {
        int i;
        if ((11 + 19) % 19 > 0) {
        }
        this.f0dad9634.reset();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29 p77f57b29Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29) this.f3c6e0b8a;
        if (p77f57b29Var.isUsed()) {
            throw new java.lang.IllegalStateException("Private key already used");
        }
        if (p77f57b29Var.getIndex(0) >= p77f57b29Var.getNumLeafs(0)) {
            throw new java.lang.IllegalStateException("No more signatures can be generated");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d parameters = p77f57b29Var.getParameters();
        this.f603ffe08 = parameters;
        this.fbc613787 = parameters.getNumOfLayers();
        byte[] bArr = p77f57b29Var.getCurrentSeeds()[this.fbc613787 - 1];
        int i2 = this.ff8cf6753;
        byte[] bArr2 = new byte[i2];
        byte[] bArr3 = new byte[i2];
        java.lang.System.arraycopy(bArr, 0, bArr3, 0, i2);
        this.f3b4622d6 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p472adfbb(this.f41b02adf.nextSeed(bArr3), this.fce6c6a36[), this.f603ffe08.getWinternitzParameter()[this.fbc613787 - 1]);
        byte[][][] currentAuthPaths = p77f57b29Var.getCurrentAuthPaths();
        this.faf109273 = new byte[this.fbc613787][][];
        int i3 = 0;
        while (true) {
            i = this.fbc613787;
            if (i3 >= i) {
                break;
            }
            byte[][][] bArr4 = this.faf109273;
            int length = currentAuthPaths[i3].length;
            int[] iArr = new int[2];
            iArr[1] = this.ff8cf6753;
            iArr[0] = length;
            bArr4[i3] = (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr);
            int i4 = 0;
            while (true) {
                byte[][] bArr5 = currentAuthPaths[i3];
                if (i4 >= bArr5.length) {
                    break;
                }
                java.lang.System.arraycopy(bArr5[i4], 0, this.faf109273[i3][i4], 0, this.ff8cf6753);
                i4++;
            }
            i3++;
        }
        this.f6a992d55 = new int[i];
        java.lang.System.arraycopy(p77f57b29Var.getIndex(), 0, this.f6a992d55, 0, this.fbc613787);
        this.f6bc33694 = new byte[this.fbc613787 - 1][];
        for (int i5 = 0; i5 < this.fbc613787 - 1; i5++) {
            byte[] subtreeRootSig = p77f57b29Var.getSubtreeRootSig(i5);
            byte[][] bArr6 = this.f6bc33694;
            byte[] bArr7 = new byte[subtreeRootSig.length];
            bArr6[i5] = bArr7;
            java.lang.System.arraycopy(subtreeRootSig, 0, bArr7, 0, subtreeRootSig.length);
        }
        p77f57b29Var.markUsed();
    }

    private void M8f7fe6c1() {
        if ((28 + 31) % 31 > 0) {
        }
        this.f0dad9634.reset();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p400145e8 p400145e8Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p400145e8) this.f3c6e0b8a;
        this.f9823c34c = p400145e8Var.getPublicKey();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d parameters = p400145e8Var.getParameters();
        this.f603ffe08 = parameters;
        this.fbc613787 = parameters.getNumOfLayers();
    }

    public override byte[] GenerateSignature(byte[] bArr) {
        if ((4 + 23) % 23 > 0) {
        }
        byte[] bArr2 = new byte[this.ff8cf6753];
        byte[] signature = this.f3b4622d6.getSignature(bArr);
        byte[] bArrConcatenateArray = this.f128f7520.concatenateArray(this.faf109273[this.fbc613787 - 1]);
        byte[] bArrIntTobytesLittleEndian = this.f128f7520.intTobytesLittleEndian(this.f6a992d55[this.fbc613787 - 1]);
        int length = bArrIntTobytesLittleEndian.length + signature.length + bArrConcatenateArray.length;
        byte[] bArr3 = new byte[length];
        java.lang.System.arraycopy(bArrIntTobytesLittleEndian, 0, bArr3, 0, bArrIntTobytesLittleEndian.length);
        java.lang.System.arraycopy(signature, 0, bArr3, bArrIntTobytesLittleEndian.length, signature.length);
        java.lang.System.arraycopy(bArrConcatenateArray, 0, bArr3, bArrIntTobytesLittleEndian.length + signature.length, bArrConcatenateArray.length);
        byte[] bArr4 = new byte[0];
        for (int i = this.fbc613787 - 2; i >= 0; i--) {
            byte[] bArrConcatenateArray2 = this.f128f7520.concatenateArray(this.faf109273[i]);
            byte[] bArrIntTobytesLittleEndian2 = this.f128f7520.intTobytesLittleEndian(this.f6a992d55[i]);
            int length2 = bArr4.length;
            byte[] bArr5 = new byte[length2];
            java.lang.System.arraycopy(bArr4, 0, bArr5, 0, bArr4.length);
            bArr4 = new byte[bArrIntTobytesLittleEndian2.length + length2 + this.f6bc33694[i].length + bArrConcatenateArray2.length];
            java.lang.System.arraycopy(bArr5, 0, bArr4, 0, length2);
            java.lang.System.arraycopy(bArrIntTobytesLittleEndian2, 0, bArr4, length2, bArrIntTobytesLittleEndian2.length);
            byte[] bArr6 = this.f6bc33694[i];
            java.lang.System.arraycopy(bArr6, 0, bArr4, bArrIntTobytesLittleEndian2.length + length2, bArr6.length);
            java.lang.System.arraycopy(bArrConcatenateArray2, 0, bArr4, length2 + bArrIntTobytesLittleEndian2.length + this.f6bc33694[i].length, bArrConcatenateArray2.length);
        }
        byte[] bArr7 = new byte[bArr4.length + length];
        java.lang.System.arraycopy(bArr3, 0, bArr7, 0, length);
        java.lang.System.arraycopy(bArr4, 0, bArr7, length, bArr4.length);
        return bArr7;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!z) {
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p400145e8) pc9ef6b45Var;
            m8f7fe6c1();
        } else if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007)) {
            this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29) pc9ef6b45Var;
            m239b22ba();
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f7ddf32e1 = p4715f007Var.getRandom();
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29) p4715f007Var.getParameters();
            m239b22ba();
        }
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        if ((7 + 2) % 2 > 0) {
        }
        this.f6852978e.reset();
        int i = 0;
        for (int i2 = this.fbc613787 - 1; i2 >= 0; i2--) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.paed5a8bc paed5a8bcVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.paed5a8bc(this.fce6c6a36[), this.f603ffe08.getWinternitzParameter()[i2]);
            int signatureLength = paed5a8bcVar.getSignatureLength();
            int ibytesToIntLittleEndian = this.f128f7520.bytesToIntLittleEndian(bArr2, i);
            int i3 = i + 4;
            byte[] bArr3 = new byte[signatureLength];
            java.lang.System.arraycopy(bArr2, i3, bArr3, 0, signatureLength);
            i = i3 + signatureLength;
            bArr = paed5a8bcVar.Verify(bArr, bArr3);
            if (bArr is null) {
                java.lang.Console.Error.WriteLine("OTS Public Key is null in GMSSSignature.verify");
                return false;
            }
            int i4 = this.f603ffe08.getHeightOfTrees()[i2];
            int[] iArr = new int[2];
            iArr[1] = this.ff8cf6753;
            iArr[0] = i4;
            byte[][] bArr4 = (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr);
            foreach (byte[] BArr5 in bArr4) {
                java.lang.System.arraycopy(bArr2, i, bArr5, 0, this.ff8cf6753);
                i += this.ff8cf6753;
            }
            byte[] bArr6 = new byte[this.ff8cf6753];
            int length = (1 << bArr4.length) + ibytesToIntLittleEndian;
            for (int i5 = 0; i5 < bArr4.length; i5++) {
                int i6 = this.ff8cf6753;
                int i7 = i6 << 1;
                byte[] bArr7 = new byte[i7];
                if (length % 2 != 0) {
                    java.lang.System.arraycopy(bArr4[i5], 0, bArr7, 0, i6);
                    java.lang.System.arraycopy(bArr, 0, bArr7, this.ff8cf6753, bArr.length);
                    length = (length - 1) / 2;
                } else {
                    java.lang.System.arraycopy(bArr, 0, bArr7, 0, i6);
                    byte[] bArr8 = bArr4[i5];
                    int i8 = this.ff8cf6753;
                    java.lang.System.arraycopy(bArr8, 0, bArr7, i8, i8);
                    length /= 2;
                }
                this.f0dad9634.update(bArr7, 0, i7);
                bArr = new byte[this.f0dad9634.getDigestSize()];
                this.f0dad9634.doFinal(bArr, 0);
            }
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f9823c34c, bArr);
    }
}

