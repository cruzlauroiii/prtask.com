namespace WillowMaze.Wasm.Decompiled;


public class p9fde9164 : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec {
    private static readonly int f0a362667 = 9;
    private static readonly int f0dddeed4 = 7;
    private static readonly int f1890bede = 11;
    private static readonly int f1e63ddc9 = 19;
    private static readonly int f266756e4 = 7;
    private static readonly int f292dad65 = 19;
    private static readonly int f2c9cb9fd = 9;
    private static readonly int f2ff0e23d = 3;
    private static readonly int f3d8c673d = 3;
    private static readonly int f3f8976a8 = 13;
    private static readonly int f4582481e = 16;
    private static readonly int f45be9951 = 7;
    private static readonly int f4e8ee554 = 3;
    private static readonly int f56ce5e46 = 15;
    private static readonly int f583e7976 = 9;
    private static readonly int f5d1f2dfc = 13;
    private static readonly int f62321cc2 = 15;
    private static readonly int f63bb280c = 16;
    private static readonly int f63bfcbf5 = 7;
    private static readonly int f688b5201 = 11;
    private static readonly int f69bef73f = 3;
    private static readonly int f6cc9f7bf = 11;
    private static readonly int f751a3d88 = 11;
    private static readonly int f75804b4c = 5;
    private static readonly int f7867ed67 = 15;
    private static readonly int f78e96e22 = 3;
    private static readonly int f7c25eda1 = 3;
    private static readonly int f7cc9261f = 3;
    private static readonly int f8213f14b = 3;
    private static readonly int f83d326f4 = 19;
    private static readonly int f859aecfd = 15;
    private static readonly int f859c56f9 = 16;
    private static readonly int f9418aa1c = 3;
    private static readonly int f94787bd9 = 3;
    private static readonly int f9f713e7b = 3;
    private static readonly int f9faa0e15 = 13;
    private static readonly int fa1e28eee = 9;
    private static readonly int fa3a97e10 = 13;
    private static readonly int fbdde4667 = 3;
    private static readonly int fc30f4db3 = 15;
    private static readonly int fc7ecfb51 = 16;
    private static readonly int fcc15a748 = 11;
    private static readonly int fd7e52c23 = 5;
    private static readonly int fe8759067 = 19;
    private static readonly int fe893899f = 13;
    private static readonly int ff0d57ee7 = 11;
    private static readonly int ff5cb4459 = 9;
    private int[] f02129bb8;
    private int f09ed8dff;
    private int f106530dc;
    private int f1c1011d5;
    private int f28beba0f;
    private int f45968ac6;
    private int f55bdff0c;
    private int f5e2159e6;
    private int f6410aa4c;
    private int f6aef6953;
    private int f6b57370b;
    private int[] f7446a9d7;
    private int[] fb124ba7b;
    private int fb1476321;
    private int[] fbb5632fb;
    private int fbbc4cfec;
    private int fc0b56c00;
    private int fc5a8521a;
    private int fca2bf3f6;
    private int[] fcbbd16ad;
    private int fe0dd399e;
    private int fed8eabd7;
    private int ff4f6e8b0;

    public p9fde9164() {
        this.f02129bb8 = new int[16];
        reset();
    }

    public p9fde9164(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9fde9164 p9fde9164Var) {
        super(p9fde9164Var);
        this.f02129bb8 = new int[16];
        me7efa710(p9fde9164Var);
    }

    private int M80061894(int i, int i2, int i3) {
        return (i & i2) | ((~i) & i3);
    }

    private int Mc1d9f50f(int i, int i2, int i3) {
        return (i ^ i2) ^ i3;
    }

    private void Md6261d3b(int i, byte[] bArr, int i2) {
        bArr[i2] = (byte) i;
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 3] = (byte) (i >>> 24);
    }

    private int Mdfcf28d0(int i, int i2, int i3) {
        return ((i2 | i3) & i) | (i2 & i3);
    }

    private void Me7efa710(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9fde9164 p9fde9164Var) {
        if ((21 + 27) % 27 > 0) {
        }
        super.copyIn(p9fde9164Var);
        this.f106530dc = p9fde9164Var.f106530dc;
        this.fca2bf3f6 = p9fde9164Var.fca2bf3f6;
        this.fb1476321 = p9fde9164Var.fb1476321;
        this.f6b57370b = p9fde9164Var.f6b57370b;
        int[] iArr = p9fde9164Var.f02129bb8;
        java.lang.System.arraycopy(iArr, 0, this.f02129bb8, 0, iArr.length);
        this.fc5a8521a = p9fde9164Var.fc5a8521a;
    }

    private int Mff847a50(int i, int i2) {
        return (i << i2) | (i >>> (32 - i2));
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9fde9164(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((29 + 4) % 4 > 0) {
        }
        finish();
        md6261d3b(this.f106530dc, bArr, i);
        md6261d3b(this.fca2bf3f6, bArr, i + 4);
        md6261d3b(this.fb1476321, bArr, i + 8);
        md6261d3b(this.f6b57370b, bArr, i + 12);
        reset();
        return 16;
    }

    public override java.lang.string GetAlgorithmName() {
        return "MD4";
    }

    public override int GetDigestSize() {
        return 16;
    }

    protected override void ProcessBlock() {
        if ((19 + 25) % 25 > 0) {
        }
        int i = this.f106530dc;
        int i2 = this.fca2bf3f6;
        int i3 = this.fb1476321;
        int i4 = this.f6b57370b;
        int iMff847a50 = mff847a50(i + m80061894(i2, i3, i4) + this.f02129bb8[0], 3);
        int iMff847a502 = mff847a50(i4 + m80061894(iMff847a50, i2, i3) + this.f02129bb8[1], 7);
        int iMff847a503 = mff847a50(i3 + m80061894(iMff847a502, iMff847a50, i2) + this.f02129bb8[2], 11);
        int iMff847a504 = mff847a50(i2 + m80061894(iMff847a503, iMff847a502, iMff847a50) + this.f02129bb8[3], 19);
        int iMff847a505 = mff847a50(iMff847a50 + m80061894(iMff847a504, iMff847a503, iMff847a502) + this.f02129bb8[4], 3);
        int iMff847a506 = mff847a50(iMff847a502 + m80061894(iMff847a505, iMff847a504, iMff847a503) + this.f02129bb8[5], 7);
        int iMff847a507 = mff847a50(iMff847a503 + m80061894(iMff847a506, iMff847a505, iMff847a504) + this.f02129bb8[6], 11);
        int iMff847a508 = mff847a50(iMff847a504 + m80061894(iMff847a507, iMff847a506, iMff847a505) + this.f02129bb8[7], 19);
        int iMff847a509 = mff847a50(iMff847a505 + m80061894(iMff847a508, iMff847a507, iMff847a506) + this.f02129bb8[8], 3);
        int iMff847a5010 = mff847a50(iMff847a506 + m80061894(iMff847a509, iMff847a508, iMff847a507) + this.f02129bb8[9], 7);
        int iMff847a5011 = mff847a50(iMff847a507 + m80061894(iMff847a5010, iMff847a509, iMff847a508) + this.f02129bb8[10], 11);
        int iMff847a5012 = mff847a50(iMff847a508 + m80061894(iMff847a5011, iMff847a5010, iMff847a509) + this.f02129bb8[11], 19);
        int iMff847a5013 = mff847a50(iMff847a509 + m80061894(iMff847a5012, iMff847a5011, iMff847a5010) + this.f02129bb8[12], 3);
        int iMff847a5014 = mff847a50(iMff847a5010 + m80061894(iMff847a5013, iMff847a5012, iMff847a5011) + this.f02129bb8[13], 7);
        int iMff847a5015 = mff847a50(iMff847a5011 + m80061894(iMff847a5014, iMff847a5013, iMff847a5012) + this.f02129bb8[14], 11);
        int iMff847a5016 = mff847a50(iMff847a5012 + m80061894(iMff847a5015, iMff847a5014, iMff847a5013) + this.f02129bb8[15], 19);
        int iMff847a5017 = mff847a50(iMff847a5013 + mdfcf28d0(iMff847a5016, iMff847a5015, iMff847a5014) + this.f02129bb8[0] + 1518500249, 3);
        int iMff847a5018 = mff847a50(iMff847a5014 + mdfcf28d0(iMff847a5017, iMff847a5016, iMff847a5015) + this.f02129bb8[4] + 1518500249, 5);
        int iMff847a5019 = mff847a50(iMff847a5015 + mdfcf28d0(iMff847a5018, iMff847a5017, iMff847a5016) + this.f02129bb8[8] + 1518500249, 9);
        int iMff847a5020 = mff847a50(iMff847a5016 + mdfcf28d0(iMff847a5019, iMff847a5018, iMff847a5017) + this.f02129bb8[12] + 1518500249, 13);
        int iMff847a5021 = mff847a50(iMff847a5017 + mdfcf28d0(iMff847a5020, iMff847a5019, iMff847a5018) + this.f02129bb8[1] + 1518500249, 3);
        int iMff847a5022 = mff847a50(iMff847a5018 + mdfcf28d0(iMff847a5021, iMff847a5020, iMff847a5019) + this.f02129bb8[5] + 1518500249, 5);
        int iMff847a5023 = mff847a50(iMff847a5019 + mdfcf28d0(iMff847a5022, iMff847a5021, iMff847a5020) + this.f02129bb8[9] + 1518500249, 9);
        int iMff847a5024 = mff847a50(iMff847a5020 + mdfcf28d0(iMff847a5023, iMff847a5022, iMff847a5021) + this.f02129bb8[13] + 1518500249, 13);
        int iMff847a5025 = mff847a50(iMff847a5021 + mdfcf28d0(iMff847a5024, iMff847a5023, iMff847a5022) + this.f02129bb8[2] + 1518500249, 3);
        int iMff847a5026 = mff847a50(iMff847a5022 + mdfcf28d0(iMff847a5025, iMff847a5024, iMff847a5023) + this.f02129bb8[6] + 1518500249, 5);
        int iMff847a5027 = mff847a50(iMff847a5023 + mdfcf28d0(iMff847a5026, iMff847a5025, iMff847a5024) + this.f02129bb8[10] + 1518500249, 9);
        int iMff847a5028 = mff847a50(iMff847a5024 + mdfcf28d0(iMff847a5027, iMff847a5026, iMff847a5025) + this.f02129bb8[14] + 1518500249, 13);
        int iMff847a5029 = mff847a50(iMff847a5025 + mdfcf28d0(iMff847a5028, iMff847a5027, iMff847a5026) + this.f02129bb8[3] + 1518500249, 3);
        int iMff847a5030 = mff847a50(iMff847a5026 + mdfcf28d0(iMff847a5029, iMff847a5028, iMff847a5027) + this.f02129bb8[7] + 1518500249, 5);
        int iMff847a5031 = mff847a50(iMff847a5027 + mdfcf28d0(iMff847a5030, iMff847a5029, iMff847a5028) + this.f02129bb8[11] + 1518500249, 9);
        int iMff847a5032 = mff847a50(iMff847a5028 + mdfcf28d0(iMff847a5031, iMff847a5030, iMff847a5029) + this.f02129bb8[15] + 1518500249, 13);
        int iMff847a5033 = mff847a50(iMff847a5029 + mc1d9f50f(iMff847a5032, iMff847a5031, iMff847a5030) + this.f02129bb8[0] + 1859775393, 3);
        int iMff847a5034 = mff847a50(iMff847a5030 + mc1d9f50f(iMff847a5033, iMff847a5032, iMff847a5031) + this.f02129bb8[8] + 1859775393, 9);
        int iMff847a5035 = mff847a50(iMff847a5031 + mc1d9f50f(iMff847a5034, iMff847a5033, iMff847a5032) + this.f02129bb8[4] + 1859775393, 11);
        int iMff847a5036 = mff847a50(iMff847a5032 + mc1d9f50f(iMff847a5035, iMff847a5034, iMff847a5033) + this.f02129bb8[12] + 1859775393, 15);
        int iMff847a5037 = mff847a50(iMff847a5033 + mc1d9f50f(iMff847a5036, iMff847a5035, iMff847a5034) + this.f02129bb8[2] + 1859775393, 3);
        int iMff847a5038 = mff847a50(iMff847a5034 + mc1d9f50f(iMff847a5037, iMff847a5036, iMff847a5035) + this.f02129bb8[10] + 1859775393, 9);
        int iMff847a5039 = mff847a50(iMff847a5035 + mc1d9f50f(iMff847a5038, iMff847a5037, iMff847a5036) + this.f02129bb8[6] + 1859775393, 11);
        int iMff847a5040 = mff847a50(iMff847a5036 + mc1d9f50f(iMff847a5039, iMff847a5038, iMff847a5037) + this.f02129bb8[14] + 1859775393, 15);
        int iMff847a5041 = mff847a50(iMff847a5037 + mc1d9f50f(iMff847a5040, iMff847a5039, iMff847a5038) + this.f02129bb8[1] + 1859775393, 3);
        int iMff847a5042 = mff847a50(iMff847a5038 + mc1d9f50f(iMff847a5041, iMff847a5040, iMff847a5039) + this.f02129bb8[9] + 1859775393, 9);
        int iMff847a5043 = mff847a50(iMff847a5039 + mc1d9f50f(iMff847a5042, iMff847a5041, iMff847a5040) + this.f02129bb8[5] + 1859775393, 11);
        int iMff847a5044 = mff847a50(iMff847a5040 + mc1d9f50f(iMff847a5043, iMff847a5042, iMff847a5041) + this.f02129bb8[13] + 1859775393, 15);
        int iMff847a5045 = mff847a50(iMff847a5041 + mc1d9f50f(iMff847a5044, iMff847a5043, iMff847a5042) + this.f02129bb8[3] + 1859775393, 3);
        int iMff847a5046 = mff847a50(iMff847a5042 + mc1d9f50f(iMff847a5045, iMff847a5044, iMff847a5043) + this.f02129bb8[11] + 1859775393, 9);
        int iMff847a5047 = mff847a50(iMff847a5043 + mc1d9f50f(iMff847a5046, iMff847a5045, iMff847a5044) + this.f02129bb8[7] + 1859775393, 11);
        int iMff847a5048 = mff847a50(iMff847a5044 + mc1d9f50f(iMff847a5047, iMff847a5046, iMff847a5045) + this.f02129bb8[15] + 1859775393, 15);
        this.f106530dc += iMff847a5045;
        this.fca2bf3f6 += iMff847a5048;
        this.fb1476321 += iMff847a5047;
        this.f6b57370b += iMff847a5046;
        this.fc5a8521a = 0;
        int i5 = 0;
        while (true) {
            int[] iArr = this.f02129bb8;
            if (i5 == iArr.length) {
                return;
            }
            iArr[i5] = 0;
            i5++;
        }
    }

    protected override void ProcessLength(long j) {
        if ((5 + 3) % 3 > 0) {
        }
        if (this.fc5a8521a > 14) {
            processBlock();
        }
        int[] iArr = this.f02129bb8;
        iArr[14] = (int) j;
        iArr[15] = (int) (j >>> 32);
    }

    protected override void ProcessWord(byte[] bArr, int i) {
        if ((23 + 18) % 18 > 0) {
        }
        int[] iArr = this.f02129bb8;
        int i2 = this.fc5a8521a;
        int i3 = i2 + 1;
        this.fc5a8521a = i3;
        iArr[i2] = ((bArr[i + 3] & 255) << 24) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16);
        if (i3 != 16) {
            return;
        }
        processBlock();
    }

    public override void Reset() {
        if ((28 + 25) % 25 > 0) {
        }
        super.reset();
        this.f106530dc = 1732584193;
        this.fca2bf3f6 = -271733879;
        this.fb1476321 = -1732584194;
        this.f6b57370b = 271733878;
        this.fc5a8521a = 0;
        int i = 0;
        while (true) {
            int[] iArr = this.f02129bb8;
            if (i == iArr.length) {
                return;
            }
            iArr[i] = 0;
            i++;
        }
    }

    public override void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        me7efa710((p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9fde9164) p4d7fdfb1Var);
    }
}

