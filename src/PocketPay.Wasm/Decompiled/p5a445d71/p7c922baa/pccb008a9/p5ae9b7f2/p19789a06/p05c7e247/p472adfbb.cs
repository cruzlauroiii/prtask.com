namespace WillowMaze.Wasm.Decompiled;


public class p472adfbb {
    private int f11843408;
    private byte[][] f3847aba9;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f41b02adf;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f529a83e8;
    private int f583f9bdd;
    private int f585b8c62;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f5a728431;
    private byte[][] f60a42cc3;
    private int f62b211b9;
    private int f65ff20dd;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f6852978e;
    private int f81c6d154;
    private byte[][] f9d024d7a;
    private int f9d4ce7f5;
    private byte[][] f9eac30ab;
    private int fa0d6359d;
    private int fb2c703f6;
    private int fbe11ffd6;
    private int fc1d03b68;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc71de287;
    private byte[][] fe3b19842;
    private int fe774a04f;
    private int ff1290186;
    private int ff6df73d3;
    private int ff7285b5b;
    private int ffaeafdf5;

    public p472adfbb(byte[] bArr, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i) {
        if ((15 + 4) % 4 > 0) {
        }
        this.ff1290186 = i;
        this.f6852978e = pe5cfc515Var;
        this.f41b02adf = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab(this.f6852978e);
        int iTcSpAoghJHbUwtfX = TcSpAoghJHbUwtfX(this.f6852978e);
        this.fc1d03b68 = iTcSpAoghJHbUwtfX;
        double d = i;
        int iNPuaPtzqQzjRsVOk = (int) nPuaPtzqQzjRsVOk(((double) (iTcSpAoghJHbUwtfX << 3)) / d);
        this.f9d4ce7f5 = iNPuaPtzqQzjRsVOk;
        int iSDmViOVdVDDDWYdC = sDmViOVdVDDDWYdC(this, (iNPuaPtzqQzjRsVOk << i) + 1);
        this.ff6df73d3 = iSDmViOVdVDDDWYdC;
        int iNzZhkqjpgcmueSiP = this.f9d4ce7f5 + ((int) NzZhkqjpgcmueSiP(((double) iSDmViOVdVDDDWYdC) / d));
        this.f11843408 = iNzZhkqjpgcmueSiP;
        int[] iArr = new int[2];
        iArr[1] = this.fc1d03b68;
        iArr[0] = iNzZhkqjpgcmueSiP;
        this.f3847aba9 = (byte[][]) xdJXmNsfTewZBpvU(java.lang.byte.TYPE, iArr);
        int i2 = this.fc1d03b68;
        byte[] bArr2 = new byte[i2];
        eINOrKOEbzautzWS(bArr, 0, bArr2, 0, i2);
        for (int i3 = 0; i3 < this.f11843408; i3++) {
            this.f3847aba9[i3] = dYExAKAPEJQSndpb(this.f41b02adf, bArr2);
        }
    }

    public static void CFKPAeFfxXcVyNjV(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int CFqstNlFGSzbbncF(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void CVfRpSIdoWVVLHuB(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int CYkghSmykdaYKPOG(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static int DNmllzcnGzkYDqao(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int DrvPwnwdfiGmZXWk(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void EIiTzenIYEkfdutA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int EebyLmBMuQMhPhTY(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void FGXERpqoundcqYZq(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int GQxvISSskbOSSIlR(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int LBbiRutvIMvQkZuL(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static int NautjifSPvkFpDxn(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static double NzZhkqjpgcmueSiP(double d) {
        if ((22 + 1) % 1 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void OiUFHvJWHLHaIPTp(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void PmpXNbkfwJhFIOXq(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int QYSqwFlHygvfsdAU(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static int QomfCGoXpEHEtKxX(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void RAaWzoAfrYZpUnIn(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int RKTlNmCwAEmjCPxk(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int RmWTcqchDLDSFskb(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void RrjMbIUSpLxCytaE(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void TSwFIhkWejcheSzc(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int TcSpAoghJHbUwtfX(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int VQdIMHzrooeqbJjK(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static int VjGbKsyBOdeykzij(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void XZimcNwBrpQfvHSk(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int YUIzQUxsfMSHShvY(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void YxOJHVYvpMGiOWXb(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void CMscGwMDoYPXyQCk(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void DDLuBRoTwoCRDOpX(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void DGHaWaOaFuMZOPTN(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] DYExAKAPEJQSndpb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab p177006abVar, byte[] bArr) {
        return p177006abVar.nextSeed(bArr);
    }

    public static void DdRDXdjtHBvvYAqe(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void DksWQNfoVRyVMzSs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int DzTgxpeHmHnlZCol(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void EINOrKOEbzautzWS(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int EfLwLjlWfJDrTZmc(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void GqLCOllaXLglRyaH(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void HeVjJjSDtDFkRPqr(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void IsrsBzJcXbSBMYSc(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int KKuFRwWhtsXakHTA(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void MkwMirYvGLtrIVSd(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void MyxBSWLWsLSKZaMW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static double NPuaPtzqQzjRsVOk(double d) {
        if ((4 + 14) % 14 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static int NQgjEEutLkhrZVmf(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int NwGcxnMSNixJTzdW(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void PRcMSShAUUJqRNeI(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int PgZvxnHWgJLwFoCe(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void QSZhnlPLrgfdJTsv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void RNWfKhnnUaZlQxuC(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int SCRFhPuAzAcPaouD(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int SDmViOVdVDDDWYdC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p472adfbb p472adfbbVar, int i) {
        return p472adfbbVar.getConsole(i);
    }

    public static void USUlBDBzqgtwBeNY(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void UyQjDTolZAIxVAXn(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int VoVImnrotUZFSrfd(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void WSldZFuvpBncsbdD(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int WvOkAoEmIUxJfiYc(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static java.lang.object XdJXmNsfTewZBpvU(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static void YGQyTFqIfUGiFXzh(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void ZtpebCZLXAXESEYj(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public int GetConsole(int i) {
        int i2 = 1;
        int i3 = 2;
        while (i3 < i) {
            i3 <<= 1;
            i2++;
        }
        return i2;
    }

    public byte[][] GetPrivateKey() {
        return this.f3847aba9;
    }

    public byte[] GetPublicKey() {
        if ((28 + 30) % 30 > 0) {
        }
        int i = this.f11843408;
        int i2 = this.fc1d03b68;
        int i3 = i * i2;
        byte[] bArr = new byte[i3];
        byte[] bArr2 = new byte[i2];
        int i4 = 1 << this.ff1290186;
        for (int i5 = 0; i5 < this.f11843408; i5++) {
            p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.f6852978e;
            byte[] bArr3 = this.f3847aba9[i5];
            cMscGwMDoYPXyQCk(pe5cfc515Var, bArr3, 0, bArr3.length);
            byte[] bArr4 = new byte[pgZvxnHWgJLwFoCe(this.f6852978e)];
            VQdIMHzrooeqbJjK(this.f6852978e, bArr4, 0);
            for (int i6 = 2; i6 < i4; i6++) {
                RAaWzoAfrYZpUnIn(this.f6852978e, bArr4, 0, bArr4.length);
                bArr4 = new byte[QomfCGoXpEHEtKxX(this.f6852978e)];
                kKuFRwWhtsXakHTA(this.f6852978e, bArr4, 0);
            }
            int i7 = this.fc1d03b68;
            uSUlBDBzqgtwBeNY(bArr4, 0, bArr, i7 * i5, i7);
        }
        ztpebCZLXAXESEYj(this.f6852978e, bArr, 0, i3);
        byte[] bArr5 = new byte[nQgjEEutLkhrZVmf(this.f6852978e)];
        EebyLmBMuQMhPhTY(this.f6852978e, bArr5, 0);
        return bArr5;
    }

    public byte[] GetSignature(byte[] bArr) {
        int i;
        if ((3 + 28) % 28 > 0) {
        }
        int i2 = this.f11843408;
        int i3 = this.fc1d03b68;
        byte[] bArr2 = new byte[i2 * i3];
        byte[] bArr3 = new byte[i3];
        dDLuBRoTwoCRDOpX(this.f6852978e, bArr, 0, bArr.length);
        int iVoVImnrotUZFSrfd = voVImnrotUZFSrfd(this.f6852978e);
        byte[] bArr4 = new byte[iVoVImnrotUZFSrfd];
        dzTgxpeHmHnlZCol(this.f6852978e, bArr4, 0);
        int i4 = this.ff1290186;
        char c = '\b';
        bool z = true;
        if (8 % i4 == 0) {
            int i5 = 8 / i4;
            int i6 = (1 << i4) - 1;
            byte[] bArr5 = new byte[this.fc1d03b68];
            int i7 = 0;
            int i8 = 0;
            for (int i9 = 0; i9 < iVoVImnrotUZFSrfd; i9++) {
                for (int i10 = 0; i10 < i5; i10++) {
                    int i11 = bArr4[i9] & i6;
                    i7 += i11;
                    wSldZFuvpBncsbdD(this.f3847aba9[i8], 0, bArr5, 0, this.fc1d03b68);
                    while (i11 > 0) {
                        heVjJjSDtDFkRPqr(this.f6852978e, bArr5, 0, bArr5.length);
                        bArr5 = new byte[GQxvISSskbOSSIlR(this.f6852978e)];
                        wvOkAoEmIUxJfiYc(this.f6852978e, bArr5, 0);
                        i11--;
                    }
                    int i12 = this.fc1d03b68;
                    ddRDXdjtHBvvYAqe(bArr5, 0, bArr2, i8 * i12, i12);
                    bArr4[i9] = (byte) (bArr4[i9] >>> this.ff1290186);
                    i8++;
                }
            }
            int i13 = (this.f9d4ce7f5 << this.ff1290186) - i7;
            int i14 = 0;
            while (i14 < this.ff6df73d3) {
                dGHaWaOaFuMZOPTN(this.f3847aba9[i8], 0, bArr5, 0, this.fc1d03b68);
                for (int i15 = i13 & i6; i15 > 0; i15--) {
                    rNWfKhnnUaZlQxuC(this.f6852978e, bArr5, 0, bArr5.length);
                    bArr5 = new byte[CFqstNlFGSzbbncF(this.f6852978e)];
                    NautjifSPvkFpDxn(this.f6852978e, bArr5, 0);
                }
                int i16 = this.fc1d03b68;
                qSZhnlPLrgfdJTsv(bArr5, 0, bArr2, i8 * i16, i16);
                int i17 = this.ff1290186;
                i13 >>>= i17;
                i8++;
                i14 += i17;
            }
        } else if (i4 < 8) {
            int i18 = this.fc1d03b68;
            int i19 = i18 / i4;
            int i20 = (1 << i4) - 1;
            byte[] bArr6 = new byte[i18];
            int i21 = 0;
            int i22 = 0;
            int i23 = 0;
            int i24 = 0;
            while (i21 < i19) {
                bool z2 = z;
                long j = 0;
                for (int i25 = 0; i25 < this.ff1290186; i25++) {
                    j ^= (long) ((bArr4[i22] & 255) << (i25 << 3));
                    i22++;
                }
                for (int i26 = 0; i26 < 8; i26++) {
                    int i27 = (int) (j & ((long) i20));
                    i24 += i27;
                    TSwFIhkWejcheSzc(this.f3847aba9[i23], 0, bArr6, 0, this.fc1d03b68);
                    while (i27 > 0) {
                        mkwMirYvGLtrIVSd(this.f6852978e, bArr6, 0, bArr6.length);
                        bArr6 = new byte[DNmllzcnGzkYDqao(this.f6852978e)];
                        CYkghSmykdaYKPOG(this.f6852978e, bArr6, 0);
                        i27--;
                    }
                    int i28 = this.fc1d03b68;
                    isrsBzJcXbSBMYSc(bArr6, 0, bArr2, i23 * i28, i28);
                    j >>>= this.ff1290186;
                    i23++;
                }
                i21++;
                z = z2;
            }
            int i29 = this.fc1d03b68 % this.ff1290186;
            int i30 = 0;
            long j2 = 0;
            while (i30 < i29) {
                int i31 = i29;
                j2 ^= (long) ((bArr4[i22] & 255) << (i30 << 3));
                i22++;
                i30++;
                i29 = i31;
            }
            int i32 = i29 << 3;
            int i33 = 0;
            while (i33 < i32) {
                int i34 = (int) (((long) i20) & j2);
                i24 += i34;
                dksWQNfoVRyVMzSs(this.f3847aba9[i23], 0, bArr6, 0, this.fc1d03b68);
                while (i34 > 0) {
                    XZimcNwBrpQfvHSk(this.f6852978e, bArr6, 0, bArr6.length);
                    bArr6 = new byte[RKTlNmCwAEmjCPxk(this.f6852978e)];
                    QYSqwFlHygvfsdAU(this.f6852978e, bArr6, 0);
                    i34--;
                }
                int i35 = this.fc1d03b68;
                OiUFHvJWHLHaIPTp(bArr6, 0, bArr2, i23 * i35, i35);
                int i36 = this.ff1290186;
                j2 >>>= i36;
                i23++;
                i33 += i36;
            }
            int i37 = (this.f9d4ce7f5 << this.ff1290186) - i24;
            int i38 = 0;
            while (i38 < this.ff6df73d3) {
                myxBSWLWsLSKZaMW(this.f3847aba9[i23], 0, bArr6, 0, this.fc1d03b68);
                for (int i39 = i37 & i20; i39 > 0; i39--) {
                    CVfRpSIdoWVVLHuB(this.f6852978e, bArr6, 0, bArr6.length);
                    bArr6 = new byte[DrvPwnwdfiGmZXWk(this.f6852978e)];
                    RmWTcqchDLDSFskb(this.f6852978e, bArr6, 0);
                }
                int i40 = this.fc1d03b68;
                gqLCOllaXLglRyaH(bArr6, 0, bArr2, i23 * i40, i40);
                int i41 = this.ff1290186;
                i37 >>>= i41;
                i23++;
                i38 += i41;
            }
        } else if (i4 < 57) {
            int i42 = this.fc1d03b68;
            int i43 = (i42 << 3) - i4;
            int i44 = (1 << i4) - 1;
            byte[] bArr7 = new byte[i42];
            int i45 = 0;
            int i46 = 0;
            int i47 = 0;
            while (i45 <= i43) {
                int i48 = i45 >>> 3;
                int i49 = i45 % 8;
                i45 += this.ff1290186;
                int i50 = (i45 + 7) >>> 3;
                long j3 = 0;
                int i51 = 0;
                while (i48 < i50) {
                    char c2 = c;
                    j3 ^= (long) ((bArr4[i48] & 255) << (i51 << 3));
                    i51++;
                    i48++;
                    c = c2;
                }
                char c3 = c;
                long j4 = (j3 >>> i49) & ((long) i44);
                i47 = (int) (((long) i47) + j4);
                YxOJHVYvpMGiOWXb(this.f3847aba9[i46], 0, bArr7, 0, this.fc1d03b68);
                while (j4 > 0) {
                    uyQjDTolZAIxVAXn(this.f6852978e, bArr7, 0, bArr7.length);
                    bArr7 = new byte[YUIzQUxsfMSHShvY(this.f6852978e)];
                    LBbiRutvIMvQkZuL(this.f6852978e, bArr7, 0);
                    j4--;
                }
                int i52 = this.fc1d03b68;
                EIiTzenIYEkfdutA(bArr7, 0, bArr2, i46 * i52, i52);
                i46++;
                c = c3;
            }
            int i53 = i45 >>> 3;
            if (i53 < this.fc1d03b68) {
                int i54 = i45 % 8;
                long j5 = 0;
                int i55 = 0;
                while (true) {
                    i = this.fc1d03b68;
                    if (i53 >= i) {
                        break;
                    }
                    j5 ^= (long) ((bArr4[i53] & 255) << (i55 << 3));
                    i55++;
                    i53++;
                }
                long j6 = (j5 >>> i54) & ((long) i44);
                i47 = (int) (((long) i47) + j6);
                PmpXNbkfwJhFIOXq(this.f3847aba9[i46], 0, bArr7, 0, i);
                while (j6 > 0) {
                    FGXERpqoundcqYZq(this.f6852978e, bArr7, 0, bArr7.length);
                    bArr7 = new byte[VjGbKsyBOdeykzij(this.f6852978e)];
                    efLwLjlWfJDrTZmc(this.f6852978e, bArr7, 0);
                    j6--;
                }
                int i56 = this.fc1d03b68;
                pRcMSShAUUJqRNeI(bArr7, 0, bArr2, i46 * i56, i56);
                i46++;
            }
            int i57 = (this.f9d4ce7f5 << this.ff1290186) - i47;
            int i58 = 0;
            while (i58 < this.ff6df73d3) {
                CFKPAeFfxXcVyNjV(this.f3847aba9[i46], 0, bArr7, 0, this.fc1d03b68);
                for (long j7 = i57 & i44; j7 > 0; j7--) {
                    yGQyTFqIfUGiFXzh(this.f6852978e, bArr7, 0, bArr7.length);
                    bArr7 = new byte[sCRFhPuAzAcPaouD(this.f6852978e)];
                    nwGcxnMSNixJTzdW(this.f6852978e, bArr7, 0);
                }
                int i59 = this.fc1d03b68;
                RrjMbIUSpLxCytaE(bArr7, 0, bArr2, i46 * i59, i59);
                int i60 = this.ff1290186;
                i57 >>>= i60;
                i46++;
                i58 += i60;
            }
        }
        return bArr2;
    }
}

