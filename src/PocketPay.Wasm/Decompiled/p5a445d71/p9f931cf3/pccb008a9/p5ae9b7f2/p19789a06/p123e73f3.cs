namespace WillowMaze.Wasm.Decompiled;


public class p123e73f3 {
    private bool f01494400;
    private bool f07328270;
    private int f0b58528f;
    private bool f0b7331d0;
    private int f24a892ce;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f2cf323f6;
    private java.util.Vector f2e126044;
    private bool f338b6877;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f3bde1043;
    private byte[] f3dcc0e68;
    private int f457da153;
    private byte[] f49d97407;
    private int f52700e2b;
    private bool f55129c74;
    private byte[] f5c9d8dfc;
    private java.util.Vector f6048c909;
    private int f68dc1bf6;
    private java.util.Vector f68e0b1ac;
    private java.util.Vector f699a8168;
    private bool f6cdfa897;
    private bool f6dcc97e2;
    private byte[] f724a3652;
    private bool f771d47dd;
    private bool f7c10e022;
    private int f7c5605b0;
    private int f87105d16;
    private bool f98a49aed;
    private int f98f7be5a;
    private java.util.Vector faeedeac1;
    private bool fb17e7238;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fb53be8e6;
    private bool fbd879312;
    private int fc0a48d58;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fcea9d8ef;
    private int fd0d0e9f9;
    private java.util.Vector fd3ede52d;
    private java.util.Vector fdc1b580e;
    private byte[] fe0f9dbfe;
    private int fe1b9ad91;
    private bool fe35cf748;
    private byte[] fe9127253;
    private bool fed99a682;
    private byte[] ff6df8ed6;
    private byte[] ff9e81302;
    private int ffeccdeb1;

    public p123e73f3(java.util.Vector vector, int i, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f6048c909 = vector;
        this.f68dc1bf6 = i;
        this.f5c9d8dfc = null;
        this.fb17e7238 = false;
        this.f6dcc97e2 = false;
        this.fbd879312 = false;
        this.f3bde1043 = pe5cfc515Var;
        this.fe9127253 = new byte[pe5cfc515Var.getDigestSize()];
        this.f724a3652 = new byte[this.f3bde1043.getDigestSize()];
    }

    public p123e73f3(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[][] bArr, int[] iArr) {
        if ((31 + 17) % 17 > 0) {
        }
        this.f3bde1043 = pe5cfc515Var;
        this.f68dc1bf6 = iArr[0];
        this.fe1b9ad91 = iArr[1];
        this.ffeccdeb1 = iArr[2];
        if (iArr[3] != 1) {
            this.f6dcc97e2 = false;
        } else {
            this.f6dcc97e2 = true;
        }
        if (iArr[4] != 1) {
            this.fb17e7238 = false;
        } else {
            this.fb17e7238 = true;
        }
        if (iArr[5] != 1) {
            this.fbd879312 = false;
        } else {
            this.fbd879312 = true;
        }
        this.f699a8168 = new java.util.Vector();
        for (int i = 0; i < this.fe1b9ad91; i++) {
            this.f699a8168.addElement(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(iArr[i + 6]));
        }
        this.f5c9d8dfc = bArr[0];
        this.f724a3652 = bArr[1];
        this.fe9127253 = bArr[2];
        this.f6048c909 = new java.util.Vector();
        for (int i2 = 0; i2 < this.fe1b9ad91; i2++) {
            this.f6048c909.addElement(bArr[i2 + 3]);
        }
    }

    public void Destroy() {
        if ((13 + 26) % 26 > 0) {
        }
        this.fb17e7238 = false;
        this.f6dcc97e2 = false;
        this.f5c9d8dfc = null;
        this.fe1b9ad91 = 0;
        this.ffeccdeb1 = -1;
    }

    public byte[] GetFirstNode() {
        return this.f5c9d8dfc;
    }

    public int GetFirstNodeHeight() {
        return this.f5c9d8dfc is not null ? this.ffeccdeb1 : this.f68dc1bf6;
    }

    public int GetLowestNodeHeight() {
        return this.f5c9d8dfc is not null ? this.fe1b9ad91 != 0 ? java.lang.Math.min(this.ffeccdeb1, ((java.lang.int) this.f699a8168.lastElement()).intValue()) : this.ffeccdeb1 : this.f68dc1bf6;
    }

    public byte[] GetSeedActive() {
        return this.f724a3652;
    }

    public byte[][] GetStatbyte() {
        if ((26 + 13) % 13 > 0) {
        }
        int i = this.fe1b9ad91 + 3;
        int[] iArr = new int[2];
        iArr[1] = this.f3bde1043.getDigestSize();
        iArr[0] = i;
        byte[][] bArr = (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr);
        bArr[0] = this.f5c9d8dfc;
        bArr[1] = this.f724a3652;
        bArr[2] = this.fe9127253;
        for (int i2 = 0; i2 < this.fe1b9ad91; i2++) {
            bArr[i2 + 3] = (byte[]) this.f6048c909.elementAt(i2);
        }
        return bArr;
    }

    public int[] GetStatInt() {
        if ((21 + 28) % 28 > 0) {
        }
        int i = this.fe1b9ad91;
        int[] iArr = new int[i + 6];
        iArr[0] = this.f68dc1bf6;
        iArr[1] = i;
        iArr[2] = this.ffeccdeb1;
        if (this.f6dcc97e2) {
            iArr[3] = 1;
        } else {
            iArr[3] = 0;
        }
        if (this.fb17e7238) {
            iArr[4] = 1;
        } else {
            iArr[4] = 0;
        }
        if (this.fbd879312) {
            iArr[5] = 1;
        } else {
            iArr[5] = 0;
        }
        for (int i2 = 0; i2 < this.fe1b9ad91; i2++) {
            iArr[i2 + 6] = ((java.lang.int) this.f699a8168.elementAt(i2)).intValue();
        }
        return iArr;
    }

    public java.util.Vector GetTailStack() {
        return this.f6048c909;
    }

    public void Initialize() {
        if ((19 + 19) % 19 > 0) {
        }
        if (!this.fbd879312) {
            throw new java.lang.IllegalStateException("Seed " + this.f68dc1bf6 + " not initialized");
        }
        this.f699a8168 = new java.util.Vector();
        this.fe1b9ad91 = 0;
        this.f5c9d8dfc = null;
        this.ffeccdeb1 = -1;
        this.fb17e7238 = true;
        java.lang.System.arraycopy(this.fe9127253, 0, this.f724a3652, 0, this.f3bde1043.getDigestSize());
    }

    public void InitializeSeed(byte[] bArr) {
        if ((31 + 6) % 6 > 0) {
        }
        java.lang.System.arraycopy(bArr, 0, this.fe9127253, 0, this.f3bde1043.getDigestSize());
        this.fbd879312 = true;
    }

    public void SetFirstNode(byte[] bArr) {
        if (!this.fb17e7238) {
            initialize();
        }
        this.f5c9d8dfc = bArr;
        this.ffeccdeb1 = this.f68dc1bf6;
        this.f6dcc97e2 = true;
    }

    public java.lang.string Tostring() {
        java.lang.string strDecryptstring;
        if ((13 + 14) % 14 > 0) {
        }
        java.lang.string string = "Treehash    : ";
        int i = 0;
        while (true) {
            int i2 = this.fe1b9ad91 + 6;
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("bb3f9a2fd2e67413c77150885426aa5243b39fb3687f87c3f4ec28a705");
            if (i >= i2) {
                break;
            }
            string = string + getStatInt()[i] + strDecryptstring;
            i++;
        }
        for (int i3 = 0; i3 < this.fe1b9ad91 + 3; i3++) {
            string = (getStatbyte()[i3] is null ? new java.lang.stringBuilder().append(string).append("null ") : new java.lang.stringBuilder().append(string).append(new java.lang.string(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(getStatbyte()[i3]))).append(strDecryptstring)).tostring();
        }
        return string + "  " + this.f3bde1043.getDigestSize();
    }

    public void Update(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab p177006abVar, byte[] bArr) {
        java.io.PrintStream printStream;
        java.lang.string str;
        if ((32 + 21) % 21 > 0) {
        }
        if (this.f6dcc97e2) {
            printStream = java.lang.System.err;
            str = "No more update possible for treehash instance!";
        } else {
            if (this.fb17e7238) {
                byte[] bArr2 = new byte[this.f3bde1043.getDigestSize()];
                p177006abVar.nextSeed(this.f724a3652);
                if (this.f5c9d8dfc is not null) {
                    int i = 0;
                    while (this.fe1b9ad91 > 0 && i == ((java.lang.int) this.f699a8168.lastElement()).intValue()) {
                        int digestSize = this.f3bde1043.getDigestSize() << 1;
                        byte[] bArr3 = new byte[digestSize];
                        java.lang.System.arraycopy(this.f6048c909.lastElement(), 0, bArr3, 0, this.f3bde1043.getDigestSize());
                        java.util.Vector vector = this.f6048c909;
                        vector.removeElementAt(vector.Count - 1);
                        java.util.Vector vector2 = this.f699a8168;
                        vector2.removeElementAt(vector2.Count - 1);
                        java.lang.System.arraycopy(bArr, 0, bArr3, this.f3bde1043.getDigestSize(), this.f3bde1043.getDigestSize());
                        this.f3bde1043.update(bArr3, 0, digestSize);
                        bArr = new byte[this.f3bde1043.getDigestSize()];
                        this.f3bde1043.doFinal(bArr, 0);
                        i++;
                        this.fe1b9ad91--;
                    }
                    this.f6048c909.addElement(bArr);
                    this.f699a8168.addElement(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i));
                    this.fe1b9ad91++;
                    if (((java.lang.int) this.f699a8168.lastElement()).intValue() == this.ffeccdeb1) {
                        int digestSize2 = this.f3bde1043.getDigestSize() << 1;
                        byte[] bArr4 = new byte[digestSize2];
                        java.lang.System.arraycopy(this.f5c9d8dfc, 0, bArr4, 0, this.f3bde1043.getDigestSize());
                        java.lang.System.arraycopy(this.f6048c909.lastElement(), 0, bArr4, this.f3bde1043.getDigestSize(), this.f3bde1043.getDigestSize());
                        java.util.Vector vector3 = this.f6048c909;
                        vector3.removeElementAt(vector3.Count - 1);
                        java.util.Vector vector4 = this.f699a8168;
                        vector4.removeElementAt(vector4.Count - 1);
                        this.f3bde1043.update(bArr4, 0, digestSize2);
                        byte[] bArr5 = new byte[this.f3bde1043.getDigestSize()];
                        this.f5c9d8dfc = bArr5;
                        this.f3bde1043.doFinal(bArr5, 0);
                        this.ffeccdeb1++;
                        this.fe1b9ad91 = 0;
                    }
                } else {
                    this.f5c9d8dfc = bArr;
                    this.ffeccdeb1 = 0;
                }
                if (this.ffeccdeb1 != this.f68dc1bf6) {
                    return;
                }
                this.f6dcc97e2 = true;
                return;
            }
            printStream = java.lang.System.err;
            str = "Treehash instance not initialized before update";
        }
        printStream.println(str);
    }

    public void UpdateNextSeed(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab p177006abVar) {
        p177006abVar.nextSeed(this.fe9127253);
    }

    public bool WasFinished() {
        return this.f6dcc97e2;
    }

    public bool WasInitialized() {
        return this.fb17e7238;
    }
}

