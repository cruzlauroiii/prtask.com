namespace WillowMaze.Wasm.Decompiled;


public class pa60ad8c0 {
    private int f08d0476f;
    private int f0bb42ae8;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pb23b88d7 f158cd8d2;
    private java.util.Vector[] f16d79ff8;
    private bool f21af9b5c;
    private java.util.Vector f2670d06a;
    private java.util.Vector f276eef7c;
    private int[] f2dc2ce77;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f3bde1043;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[] f42339e1e;
    private int f475ca091;
    private byte[][] f4aabbefb;
    private java.util.Vector f539d7960;
    private int f5460c36d;
    private int f5addaaf7;
    private java.util.Vector f6048c909;
    private int f629acb22;
    private byte[] f63a9f0ea;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[] f64474e57;
    private java.util.Vector f699a8168;
    private int[] f6a992d55;
    private bool f6dcc97e2;
    private int f7467dcc5;
    private int f75458076;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[] f7b4edd22;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[] f7bf3b418;
    private int f7ca7ebeb;
    private int f853ca8c3;
    private int[] f9174a813;
    private int f946943c6;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[] f9f957be6;
    private byte[][] fa13f43ed;
    private int fa36f981e;
    private int fa5f3c6a1;
    private java.util.Vector[] fa83ffe9c;
    private bool fa86bd1cd;
    private java.util.Vector fa8fb8151;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pb23b88d7 fa9a25807;
    private bool faaf07321;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pb23b88d7 fb11b9d75;
    private bool fb17e7238;
    private bool fb313499c;
    private int fb9477ee2;
    private bool fbb1808cd;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pb23b88d7 fbe94809c;
    private byte[][] fca6d3837;
    private byte[] fcd1f246d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pb23b88d7 fce6c6a36;
    private byte[] fdcec9ea0;
    private int fe051da17;
    private int fe1d25114;
    private int[] fe51e96ed;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fe6202997;
    private java.util.Vector fe783f607;
    private java.util.Vector febbd0f91;
    private bool febe5fc16;
    private byte[] fee1cee44;
    private int ff229bbe3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 ff59c2931;
    private int ff8cf6753;
    private int[] ffb729cb1;
    private java.util.Vector[] ffd527e9a;

    public pa60ad8c0(int i, int i2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pb23b88d7 pb23b88d7Var) {
        if ((22 + 7) % 7 > 0) {
        }
        this.f853ca8c3 = i;
        this.fce6c6a36 = pb23b88d7Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = pb23b88d7Var[);
        this.f3bde1043 = pe5cfc515Var;
        int digestSize = pe5cfc515Var.getDigestSize();
        this.ff8cf6753 = digestSize;
        this.fa5f3c6a1 = i2;
        this.f6a992d55 = new int[i];
        int[] iArr = new int[2];
        iArr[1] = digestSize;
        iArr[0] = i;
        this.fa13f43ed = (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr);
        this.f63a9f0ea = new byte[this.ff8cf6753];
        this.f16d79ff8 = new java.util.Vector[this.fa5f3c6a1 - 1];
        for (int i3 = 0; i3 < i2 - 1; i3++) {
            this.f16d79ff8[i3] = new java.util.Vector();
        }
    }

    public byte[][] GetAuthPath() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pe53b0e07.md329fd77(this.fa13f43ed);
    }

    public java.util.Vector[] GetRetain() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pe53b0e07.md329fd77(this.f16d79ff8);
    }

    public byte[] GetRoot() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f63a9f0ea);
    }

    public java.util.Vector GetStack() {
        if ((13 + 3) % 3 > 0) {
        }
        java.util.Vector vector = new java.util.Vector();
        java.util.Enumeration enumerationElements = this.f6048c909.elements();
        while (enumerationElements.hasMoreElements()) {
            vector.addElement(enumerationElements.nextElement());
        }
        return vector;
    }

    public byte[][] GetStatbyte() {
        if ((25 + 15) % 15 > 0) {
        }
        java.util.Vector vector = this.f6048c909;
        int size = vector is not null ? vector.Count : 0;
        int i = this.f853ca8c3 + 1 + size;
        int[] iArr = new int[2];
        iArr[1] = 64;
        iArr[0] = i;
        byte[][] bArr = (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr);
        bArr[0] = this.f63a9f0ea;
        int i2 = 0;
        while (i2 < this.f853ca8c3) {
            int i3 = i2 + 1;
            bArr[i3] = this.fa13f43ed[i2];
            i2 = i3;
        }
        for (int i4 = 0; i4 < size; i4++) {
            bArr[this.f853ca8c3 + 1 + i4] = (byte[]) this.f6048c909.elementAt(i4);
        }
        return bArr;
    }

    public int[] GetStatInt() {
        if ((10 + 8) % 8 > 0) {
        }
        java.util.Vector vector = this.f6048c909;
        int size = vector is not null ? vector.Count : 0;
        int i = this.f853ca8c3;
        int[] iArr = new int[i + 8 + size];
        iArr[0] = i;
        iArr[1] = this.ff8cf6753;
        iArr[2] = this.fa5f3c6a1;
        iArr[3] = this.ff229bbe3;
        iArr[4] = this.f75458076;
        if (this.f6dcc97e2) {
            iArr[5] = 1;
        } else {
            iArr[5] = 0;
        }
        if (this.fb17e7238) {
            iArr[6] = 1;
        } else {
            iArr[6] = 0;
        }
        iArr[7] = size;
        for (int i2 = 0; i2 < this.f853ca8c3; i2++) {
            iArr[i2 + 8] = this.f6a992d55[i2];
        }
        for (int i3 = 0; i3 < size; i3++) {
            iArr[this.f853ca8c3 + 8 + i3] = ((java.lang.int) this.f699a8168.elementAt(i3)).intValue();
        }
        return iArr;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[] GetTreehash() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pe53b0e07.md329fd77(this.f42339e1e);
    }

    public void Initialize(java.util.Vector vector) {
        int i;
        if ((23 + 15) % 15 > 0) {
        }
        this.f42339e1e = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[this.f853ca8c3 - this.fa5f3c6a1];
        int i2 = 0;
        while (true) {
            i = this.f853ca8c3;
            if (i2 >= i - this.fa5f3c6a1) {
                break;
            }
            this.f42339e1e[i2] = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3(vector, i2, this.fce6c6a36[));
            i2++;
        }
        this.f6a992d55 = new int[i];
        int[] iArr = new int[2];
        iArr[1] = this.ff8cf6753;
        iArr[0] = i;
        this.fa13f43ed = (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr);
        this.f63a9f0ea = new byte[this.ff8cf6753];
        this.f6048c909 = new java.util.Vector();
        this.f699a8168 = new java.util.Vector();
        this.fb17e7238 = true;
        this.f6dcc97e2 = false;
        for (int i3 = 0; i3 < this.f853ca8c3; i3++) {
            this.f6a992d55[i3] = -1;
        }
        this.f16d79ff8 = new java.util.Vector[this.fa5f3c6a1 - 1];
        for (int i4 = 0; i4 < this.fa5f3c6a1 - 1; i4++) {
            this.f16d79ff8[i4] = new java.util.Vector();
        }
        this.ff229bbe3 = 3;
        this.f75458076 = 0;
    }

    public void InitializeTreehashSeed(byte[] bArr, int i) {
        this.f42339e1e[i].initializeSeed(bArr);
    }

    public java.lang.string Tostring() {
        java.lang.string strDecryptstring;
        if ((27 + 20) % 20 > 0) {
        }
        java.util.Vector vector = this.f6048c909;
        int size = vector is not null ? vector.Count : 0;
        java.lang.string str = "";
        int i = 0;
        while (true) {
            int i2 = this.f853ca8c3 + 8 + size;
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("52f9c7348b7958db27a9836544160ab4a594f79de55e676d61ba608633");
            if (i >= i2) {
                break;
            }
            str = str + getStatInt()[i] + strDecryptstring;
            i++;
        }
        for (int i3 = 0; i3 < this.f853ca8c3 + 1 + size; i3++) {
            str = str + new java.lang.string(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(getStatbyte()[i3])) + strDecryptstring;
        }
        return str + "  " + this.fce6c6a36[).getDigestSize();
    }

    public void Update(byte[] bArr) {
        if ((20 + 10) % 10 > 0) {
        }
        if (this.f6dcc97e2) {
            java.lang.Console.Write("Too much updates for Tree!!");
            return;
        }
        if (!this.fb17e7238) {
            java.lang.Console.Error.WriteLine("GMSSRootCalc not initialized!");
            return;
        }
        int[] iArr = this.f6a992d55;
        int i = iArr[0] + 1;
        iArr[0] = i;
        if (i == 1) {
            java.lang.System.arraycopy(bArr, 0, this.fa13f43ed[0], 0, this.ff8cf6753);
        } else if (i == 3 && this.f853ca8c3 > this.fa5f3c6a1) {
            this.f42339e1e[0].setFirstNode(bArr);
        }
        int i2 = this.f6a992d55[0];
        if ((i2 - 3) % 2 == 0 && i2 >= 3 && this.f853ca8c3 == this.fa5f3c6a1) {
            this.f16d79ff8[0].insertElementAt(bArr, 0);
        }
        if (this.f6a992d55[0] == 0) {
            this.f6048c909.addElement(bArr);
            this.f699a8168.addElement(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(0));
            return;
        }
        int i3 = this.ff8cf6753;
        byte[] bArr2 = new byte[i3];
        int i4 = i3 << 1;
        byte[] bArr3 = new byte[i4];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, i3);
        int i5 = 0;
        while (this.f6048c909.Count > 0 && i5 == ((java.lang.int) this.f699a8168.lastElement()).intValue()) {
            java.lang.System.arraycopy(this.f6048c909.lastElement(), 0, bArr3, 0, this.ff8cf6753);
            java.util.Vector vector = this.f6048c909;
            vector.removeElementAt(vector.Count - 1);
            java.util.Vector vector2 = this.f699a8168;
            vector2.removeElementAt(vector2.Count - 1);
            int i6 = this.ff8cf6753;
            java.lang.System.arraycopy(bArr2, 0, bArr3, i6, i6);
            this.f3bde1043.update(bArr3, 0, i4);
            bArr2 = new byte[this.f3bde1043.getDigestSize()];
            this.f3bde1043.doFinal(bArr2, 0);
            i5++;
            if (i5 < this.f853ca8c3) {
                int[] iArr2 = this.f6a992d55;
                int i7 = iArr2[i5] + 1;
                iArr2[i5] = i7;
                if (i7 == 1) {
                    java.lang.System.arraycopy(bArr2, 0, this.fa13f43ed[i5], 0, this.ff8cf6753);
                }
                if (i5 >= this.f853ca8c3 - this.fa5f3c6a1) {
                    if (i5 == 0) {
                        java.lang.Console.WriteLine("M���P");
                    }
                    int i8 = this.f6a992d55[i5];
                    if ((i8 - 3) % 2 == 0 && i8 >= 3) {
                        this.f16d79ff8[i5 - (this.f853ca8c3 - this.fa5f3c6a1)].insertElementAt(bArr2, 0);
                    }
                } else if (this.f6a992d55[i5] == 3) {
                    this.f42339e1e[i5].setFirstNode(bArr2);
                }
            }
        }
        this.f6048c909.addElement(bArr2);
        this.f699a8168.addElement(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i5));
        if (i5 != this.f853ca8c3) {
            return;
        }
        this.f6dcc97e2 = true;
        this.fb17e7238 = false;
        this.f63a9f0ea = (byte[]) this.f6048c909.lastElement();
    }

    public void Update(byte[] bArr, byte[] bArr2) {
        if ((11 + 17) % 17 > 0) {
        }
        int i = this.f75458076;
        if (i < this.f853ca8c3 - this.fa5f3c6a1 && this.ff229bbe3 - 2 == this.f6a992d55[0]) {
            initializeTreehashSeed(bArr, i);
            this.f75458076++;
            this.ff229bbe3 *= 2;
        }
        update(bArr2);
    }

    public bool WasFinished() {
        return this.f6dcc97e2;
    }

    public bool WasInitialized() {
        return this.fb17e7238;
    }
}

