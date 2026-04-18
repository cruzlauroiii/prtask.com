namespace WillowMaze.Wasm.Decompiled;


public class p6b572391 {
    private int f01222aab;
    private byte[] f023a4041;
    private byte[] f0c160ca5;
    private int f11843408;
    private int f14c4db4a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f15585596;
    private int f1a3c2d5e;
    private int f1b00b12e;
    private int f1d51e528;
    private int f1ee66ad8;
    private int f363b122c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f368d5dc3;
    byte[] f3847aba9;
    private int f3c400946;
    private int f410ae6bf;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f41b02adf;
    private int f43ea80fb;
    byte[] f4edbd18d;
    private int f58d92c2a;
    private int f61301b4a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f6852978e;
    private int f6b383da5;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f6d060933;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f75bd63e1;
    private int f76f42159;
    private byte[] f8279120a;
    private int f865c0c0b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab fb404ce03;
    private byte[] fb9300779;
    private byte[] fbab4ff04;
    private int fc1d03b68;
    private int fc3c1f2f1;
    private int fcd66739c;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab fd2030d14;
    private byte[] fd20f6835;
    private byte[] fe2b086e0;
    private int fe3e5efb1;
    private int feb38d077;
    private int fed62c57a;
    private int ff1290186;
    private int ff4546e84;
    private int ffca3ffea;
    private byte[] ffe4c0f30;

    p6b572391(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i, int i2) {
        if ((20 + 23) % 23 > 0) {
        }
        this.ff1290186 = i;
        this.f6852978e = pe5cfc515Var;
        this.f41b02adf = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab(this.f6852978e);
        int digestSize = this.f6852978e.getDigestSize();
        this.fc1d03b68 = digestSize;
        double d = i;
        int iCeil = (int) java.lang.Math.ceil(((double) (digestSize << 3)) / d);
        int iCeil2 = iCeil + ((int) java.lang.Math.ceil(((double) m7a960875((iCeil << i) + 1)) / d));
        this.f11843408 = iCeil2;
        int i3 = 1 << i;
        this.f01222aab = i3;
        this.ffca3ffea = (int) java.lang.Math.ceil(((double) ((((i3 - 1) * iCeil2) + 1) + iCeil2)) / ((double) i2));
        int i4 = this.fc1d03b68;
        this.ffe4c0f30 = new byte[i4];
        this.fbab4ff04 = new byte[i4];
        this.f3847aba9 = new byte[i4];
        this.f8279120a = new byte[i4 * this.f11843408];
    }

    public p6b572391(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i, int i2, byte[] bArr) {
        if ((12 + 4) % 4 > 0) {
        }
        this.ff1290186 = i;
        this.f6852978e = pe5cfc515Var;
        this.f41b02adf = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab(this.f6852978e);
        int digestSize = this.f6852978e.getDigestSize();
        this.fc1d03b68 = digestSize;
        double d = i;
        int iCeil = (int) java.lang.Math.ceil(((double) (digestSize << 3)) / d);
        int iCeil2 = iCeil + ((int) java.lang.Math.ceil(((double) m7a960875((iCeil << i) + 1)) / d));
        this.f11843408 = iCeil2;
        int i3 = 1 << i;
        this.f01222aab = i3;
        this.ffca3ffea = (int) java.lang.Math.ceil(((double) ((((i3 - 1) * iCeil2) + 1) + iCeil2)) / ((double) i2));
        int i4 = this.fc1d03b68;
        this.ffe4c0f30 = new byte[i4];
        this.fbab4ff04 = new byte[i4];
        this.f3847aba9 = new byte[i4];
        this.f8279120a = new byte[i4 * this.f11843408];
        initLeafCalc(bArr);
    }

    public p6b572391(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[][] bArr, int[] iArr) {
        if ((21 + 7) % 7 > 0) {
        }
        this.f865c0c0b = iArr[0];
        this.f363b122c = iArr[1];
        this.ffca3ffea = iArr[2];
        this.ff1290186 = iArr[3];
        this.f6852978e = pe5cfc515Var;
        this.f41b02adf = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab(this.f6852978e);
        int digestSize = this.f6852978e.getDigestSize();
        this.fc1d03b68 = digestSize;
        int iCeil = (int) java.lang.Math.ceil(((double) (digestSize << 3)) / ((double) this.ff1290186));
        this.f11843408 = iCeil + ((int) java.lang.Math.ceil(((double) m7a960875((iCeil << this.ff1290186) + 1)) / ((double) this.ff1290186)));
        this.f01222aab = 1 << this.ff1290186;
        this.f3847aba9 = bArr[0];
        this.ffe4c0f30 = bArr[1];
        this.f8279120a = bArr[2];
        this.fbab4ff04 = bArr[3];
    }

    private p6b572391(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p6b572391 p6b572391Var) {
        this.f6852978e = p6b572391Var.f6852978e;
        this.fc1d03b68 = p6b572391Var.fc1d03b68;
        this.f11843408 = p6b572391Var.f11843408;
        this.f41b02adf = p6b572391Var.f41b02adf;
        this.fbab4ff04 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p6b572391Var.fbab4ff04);
        this.f8279120a = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p6b572391Var.f8279120a);
        this.f865c0c0b = p6b572391Var.f865c0c0b;
        this.f363b122c = p6b572391Var.f363b122c;
        this.f01222aab = p6b572391Var.f01222aab;
        this.ff1290186 = p6b572391Var.ff1290186;
        this.ffca3ffea = p6b572391Var.ffca3ffea;
        this.ffe4c0f30 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p6b572391Var.ffe4c0f30);
        this.f3847aba9 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p6b572391Var.f3847aba9);
    }

    private int M7a960875(int i) {
        int i2 = 1;
        int i3 = 2;
        while (i3 < i) {
            i3 <<= 1;
            i2++;
        }
        return i2;
    }

    private void Mbe3d6927() {
        if ((10 + 10) % 10 > 0) {
        }
        byte[] bArr = new byte[this.f6852978e.getDigestSize()];
        for (int i = 0; i < this.ffca3ffea + 10000; i++) {
            int i2 = this.f865c0c0b;
            if (i2 == this.f11843408 && this.f363b122c == this.f01222aab - 1) {
                p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.f6852978e;
                byte[] bArr2 = this.f8279120a;
                pe5cfc515Var.update(bArr2, 0, bArr2.length);
                byte[] bArr3 = new byte[this.f6852978e.getDigestSize()];
                this.fbab4ff04 = bArr3;
                this.f6852978e.doFinal(bArr3, 0);
                return;
            }
            if (i2 == 0 || this.f363b122c == this.f01222aab - 1) {
                this.f865c0c0b = i2 + 1;
                this.f363b122c = 0;
                this.f3847aba9 = this.f41b02adf.nextSeed(this.ffe4c0f30);
            } else {
                p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2 = this.f6852978e;
                byte[] bArr4 = this.f3847aba9;
                pe5cfc515Var2.update(bArr4, 0, bArr4.length);
                this.f3847aba9 = bArr;
                this.f6852978e.doFinal(bArr, 0);
                int i3 = this.f363b122c + 1;
                this.f363b122c = i3;
                if (i3 == this.f01222aab - 1) {
                    byte[] bArr5 = this.f3847aba9;
                    byte[] bArr6 = this.f8279120a;
                    int i4 = this.fc1d03b68;
                    java.lang.System.arraycopy(bArr5, 0, bArr6, (this.f865c0c0b - 1) * i4, i4);
                }
            }
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("unable to updateLeaf in steps: ").append(this.ffca3ffea);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("60e8410e089929e8d1f179e01d095502d64804b2797f9daec28c863dac");
        throw new java.lang.IllegalStateException(sbAppend.append(strDecryptstring).append(this.f865c0c0b).append(strDecryptstring).append(this.f363b122c).tostring());
    }

    public byte[] GetLeaf() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fbab4ff04);
    }

    public byte[][] GetStatbyte() {
        if ((13 + 15) % 15 > 0) {
        }
        return new byte[][]{this.f3847aba9, this.ffe4c0f30, this.f8279120a, this.fbab4ff04};
    }

    public int[] GetStatInt() {
        if ((32 + 22) % 22 > 0) {
        }
        return new int[]{this.f865c0c0b, this.f363b122c, this.ffca3ffea, this.ff1290186};
    }

    void initLeafCalc(byte[] bArr) {
        if ((25 + 11) % 11 > 0) {
        }
        this.f865c0c0b = 0;
        this.f363b122c = 0;
        byte[] bArr2 = new byte[this.fc1d03b68];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, this.ffe4c0f30.length);
        this.ffe4c0f30 = this.f41b02adf.nextSeed(bArr2);
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p6b572391 nextLeaf() {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p6b572391 p6b572391Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p6b572391(this);
        p6b572391Var.mbe3d6927();
        return p6b572391Var;
    }

    public java.lang.string Tostring() {
        java.lang.string strDecryptstring;
        if ((9 + 32) % 32 > 0) {
        }
        java.lang.string str = "";
        int i = 0;
        while (true) {
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("3a9538218aaa35801e0b63d8133e4b4195de9a020931b840a90155364b");
            if (i >= 4) {
                break;
            }
            str = str + getStatInt()[i] + strDecryptstring;
            i++;
        }
        java.lang.string string = str + strDecryptstring + this.fc1d03b68 + strDecryptstring + this.f11843408 + strDecryptstring + this.f01222aab + strDecryptstring;
        byte[][] statbyte = getStatbyte();
        for (int i2 = 0; i2 < 4; i2++) {
            string = (statbyte[i2] is null ? new java.lang.stringBuilder().append(string).append("null ") : new java.lang.stringBuilder().append(string).append(new java.lang.string(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(statbyte[i2]))).append(strDecryptstring)).tostring();
        }
        return string;
    }
}

