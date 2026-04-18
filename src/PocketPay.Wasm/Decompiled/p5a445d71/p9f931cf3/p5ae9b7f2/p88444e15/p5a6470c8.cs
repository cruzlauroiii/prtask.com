namespace WillowMaze.Wasm.Decompiled;


public class p5a6470c8 : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7eacabf6 {
    private static readonly int f00ee52f8 = 17;
    private static readonly int f0600e7e1 = 12;
    private static readonly int f0dddeed4 = 12;
    private static readonly int f0df40cb8 = 16;
    private static readonly int f19a6d776 = 5;
    private static readonly int f1e2e6c8f = 23;
    private static readonly int f1e9c68bf = 15;
    private static readonly int f1ef5f8ca = 20;
    private static readonly int f21263fa2 = 7;
    private static readonly int f23d90bcb = 5;
    private static readonly int f283adfd1 = 11;
    private static readonly int f2b8deb42 = 22;
    private static readonly int f2c9cb9fd = 14;
    private static readonly int f364e259f = 9;
    private static readonly int f36fe8e77 = 17;
    private static readonly int f39126dd7 = 12;
    private static readonly int f3b026a1e = 17;
    private static readonly int f3cae54bb = 10;
    private static readonly int f3da2d004 = 4;
    private static readonly int f3f5e8c26 = 21;
    private static readonly int f416ecda8 = 23;
    private static readonly int f4426c73c = 15;
    private static readonly int f4582481e = 16;
    private static readonly int f47f4371d = 22;
    private static readonly int f4952906c = 16;
    private static readonly int f4bab5e76 = 11;
    private static readonly int f4d6035a9 = 10;
    private static readonly int f5691a406 = 6;
    private static readonly int f56ab3898 = 20;
    private static readonly int f5c46d755 = 7;
    private static readonly int f66232a53 = 21;
    private static readonly int f688b5201 = 17;
    private static readonly int f698df9c8 = 20;
    private static readonly int f69bef73f = 4;
    private static readonly int f6addb255 = 20;
    private static readonly int f6cc9f7bf = 16;
    private static readonly int f6d8809da = 12;
    private static readonly int f6f97afe8 = 7;
    private static readonly int f75804b4c = 9;
    private static readonly int f75ace388 = 14;
    private static readonly int f78c8d612 = 16;
    private static readonly int f79a78a92 = 15;
    private static readonly int f7c25eda1 = 5;
    private static readonly int f7cc9261f = 7;
    private static readonly int f7d2713a8 = 12;
    private static readonly int f8c893c01 = 16;
    private static readonly int f8f3f1e7c = 10;
    private static readonly int f922aa9d1 = 15;
    private static readonly int f934d5d14 = 15;
    private static readonly int f9559115b = 21;
    private static readonly int f9ab1820c = 11;
    private static readonly int f9db0506e = 6;
    private static readonly int f9faa0e15 = 20;
    private static readonly int fa1e28eee = 11;
    private static readonly int fb200f0ee = 4;
    private static readonly int fb49b1a64 = 22;
    private static readonly int fb9bc0289 = 6;
    private static readonly int fc295ece7 = 17;
    private static readonly int fc30f4db3 = 23;
    private static readonly int fcae12cf5 = 16;
    private static readonly int fd7a7fd0f = 16;
    private static readonly int fda1e4d18 = 14;
    private static readonly int fe02913d1 = 22;
    private static readonly int fe4aaf035 = 23;
    private static readonly int fe64cd07c = 11;
    private static readonly int fe6e3e3a2 = 16;
    private static readonly int fe8759067 = 22;
    private static readonly int fee9111d7 = 21;
    private int f00b754f6;
    private int[] f02129bb8;
    private int f106530dc;
    private int f18e0e9a3;
    private int f234db24a;
    private int f2f43ba88;
    private int f364854f5;
    private int f55b4066b;
    private int f6b57370b;
    private int f7400877a;
    private int f8218de84;
    private int f9134fb2b;
    private int[] fa62988b4;
    private int fb1476321;
    private int fb1867ff7;
    private int[] fb36ace58;
    private int fbfeeda91;
    private int fc5a8521a;
    private int fca2bf3f6;
    private int fcb62a247;
    private int fe8909c02;
    private int fed334afe;

    public p5a6470c8() {
        this.f02129bb8 = new int[16];
        reset();
    }

    public p5a6470c8(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5a6470c8 p5a6470c8Var) {
        super(p5a6470c8Var);
        this.f02129bb8 = new int[16];
        me7efa710(p5a6470c8Var);
    }

    public p5a6470c8(byte[] bArr) {
        super(bArr);
        if ((6 + 10) % 10 > 0) {
        }
        this.f02129bb8 = new int[16];
        this.f106530dc = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 16);
        this.fca2bf3f6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 20);
        this.fb1476321 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 24);
        this.f6b57370b = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 28);
        this.fc5a8521a = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 32);
        for (int i = 0; i != this.fc5a8521a; i++) {
            this.f02129bb8[i] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, (i * 4) + 36);
        }
    }

    private int M80061894(int i, int i2, int i3) {
        return (i & i2) | ((~i) & i3);
    }

    private int Ma5f3c6a1(int i, int i2, int i3) {
        return ((~i3) | i) ^ i2;
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
        return (i & i3) | ((~i3) & i2);
    }

    private void Me7efa710(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5a6470c8 p5a6470c8Var) {
        if ((32 + 28) % 28 > 0) {
        }
        super.copyIn(p5a6470c8Var);
        this.f106530dc = p5a6470c8Var.f106530dc;
        this.fca2bf3f6 = p5a6470c8Var.fca2bf3f6;
        this.fb1476321 = p5a6470c8Var.fb1476321;
        this.f6b57370b = p5a6470c8Var.f6b57370b;
        int[] iArr = p5a6470c8Var.f02129bb8;
        java.lang.System.arraycopy(iArr, 0, this.f02129bb8, 0, iArr.length);
        this.fc5a8521a = p5a6470c8Var.fc5a8521a;
    }

    private int Mff847a50(int i, int i2) {
        return (i << i2) | (i >>> (32 - i2));
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5a6470c8(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((14 + 3) % 3 > 0) {
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
        return "MD5";
    }

    public override int GetDigestSize() {
        return 16;
    }

    public override byte[] GetEncodedState() {
        if ((19 + 26) % 26 > 0) {
        }
        byte[] bArr = new byte[(this.fc5a8521a * 4) + 36];
        super.populateState(bArr);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f106530dc, bArr, 16);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fca2bf3f6, bArr, 20);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb1476321, bArr, 24);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f6b57370b, bArr, 28);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fc5a8521a, bArr, 32);
        for (int i = 0; i != this.fc5a8521a; i++) {
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f02129bb8[i], bArr, (i * 4) + 36);
        }
        return bArr;
    }

    protected override void ProcessBlock() {
        if ((28 + 26) % 26 > 0) {
        }
        int i = this.f106530dc;
        int i2 = this.fca2bf3f6;
        int i3 = this.fb1476321;
        int i4 = this.f6b57370b;
        int iMff847a50 = mff847a50(((i + m80061894(i2, i3, i4)) + this.f02129bb8[0]) - 680876936, 7) + i2;
        int iMff847a502 = mff847a50(((i4 + m80061894(iMff847a50, i2, i3)) + this.f02129bb8[1]) - 389564586, 12) + iMff847a50;
        int iMff847a503 = mff847a50(i3 + m80061894(iMff847a502, iMff847a50, i2) + this.f02129bb8[2] + 606105819, 17) + iMff847a502;
        int iMff847a504 = mff847a50(((i2 + m80061894(iMff847a503, iMff847a502, iMff847a50)) + this.f02129bb8[3]) - 1044525330, 22) + iMff847a503;
        int iMff847a505 = mff847a50(((iMff847a50 + m80061894(iMff847a504, iMff847a503, iMff847a502)) + this.f02129bb8[4]) - 176418897, 7) + iMff847a504;
        int iMff847a506 = mff847a50(iMff847a502 + m80061894(iMff847a505, iMff847a504, iMff847a503) + this.f02129bb8[5] + 1200080426, 12) + iMff847a505;
        int iMff847a507 = mff847a50(((iMff847a503 + m80061894(iMff847a506, iMff847a505, iMff847a504)) + this.f02129bb8[6]) - 1473231341, 17) + iMff847a506;
        int iMff847a508 = mff847a50(((iMff847a504 + m80061894(iMff847a507, iMff847a506, iMff847a505)) + this.f02129bb8[7]) - 45705983, 22) + iMff847a507;
        int iMff847a509 = mff847a50(iMff847a505 + m80061894(iMff847a508, iMff847a507, iMff847a506) + this.f02129bb8[8] + 1770035416, 7) + iMff847a508;
        int iMff847a5010 = mff847a50(((iMff847a506 + m80061894(iMff847a509, iMff847a508, iMff847a507)) + this.f02129bb8[9]) - 1958414417, 12) + iMff847a509;
        int iMff847a5011 = mff847a50(((iMff847a507 + m80061894(iMff847a5010, iMff847a509, iMff847a508)) + this.f02129bb8[10]) - 42063, 17) + iMff847a5010;
        int iMff847a5012 = mff847a50(((iMff847a508 + m80061894(iMff847a5011, iMff847a5010, iMff847a509)) + this.f02129bb8[11]) - 1990404162, 22) + iMff847a5011;
        int iMff847a5013 = mff847a50(iMff847a509 + m80061894(iMff847a5012, iMff847a5011, iMff847a5010) + this.f02129bb8[12] + 1804603682, 7) + iMff847a5012;
        int iMff847a5014 = mff847a50(((iMff847a5010 + m80061894(iMff847a5013, iMff847a5012, iMff847a5011)) + this.f02129bb8[13]) - 40341101, 12) + iMff847a5013;
        int iMff847a5015 = mff847a50(((iMff847a5011 + m80061894(iMff847a5014, iMff847a5013, iMff847a5012)) + this.f02129bb8[14]) - 1502002290, 17) + iMff847a5014;
        int iMff847a5016 = mff847a50(iMff847a5012 + m80061894(iMff847a5015, iMff847a5014, iMff847a5013) + this.f02129bb8[15] + 1236535329, 22) + iMff847a5015;
        int iMff847a5017 = mff847a50(((iMff847a5013 + mdfcf28d0(iMff847a5016, iMff847a5015, iMff847a5014)) + this.f02129bb8[1]) - 165796510, 5) + iMff847a5016;
        int iMff847a5018 = mff847a50(((iMff847a5014 + mdfcf28d0(iMff847a5017, iMff847a5016, iMff847a5015)) + this.f02129bb8[6]) - 1069501632, 9) + iMff847a5017;
        int iMff847a5019 = mff847a50(iMff847a5015 + mdfcf28d0(iMff847a5018, iMff847a5017, iMff847a5016) + this.f02129bb8[11] + 643717713, 14) + iMff847a5018;
        int iMff847a5020 = mff847a50(((iMff847a5016 + mdfcf28d0(iMff847a5019, iMff847a5018, iMff847a5017)) + this.f02129bb8[0]) - 373897302, 20) + iMff847a5019;
        int iMff847a5021 = mff847a50(((iMff847a5017 + mdfcf28d0(iMff847a5020, iMff847a5019, iMff847a5018)) + this.f02129bb8[5]) - 701558691, 5) + iMff847a5020;
        int iMff847a5022 = mff847a50(iMff847a5018 + mdfcf28d0(iMff847a5021, iMff847a5020, iMff847a5019) + this.f02129bb8[10] + 38016083, 9) + iMff847a5021;
        int iMff847a5023 = mff847a50(((iMff847a5019 + mdfcf28d0(iMff847a5022, iMff847a5021, iMff847a5020)) + this.f02129bb8[15]) - 660478335, 14) + iMff847a5022;
        int iMff847a5024 = mff847a50(((iMff847a5020 + mdfcf28d0(iMff847a5023, iMff847a5022, iMff847a5021)) + this.f02129bb8[4]) - 405537848, 20) + iMff847a5023;
        int iMff847a5025 = mff847a50(iMff847a5021 + mdfcf28d0(iMff847a5024, iMff847a5023, iMff847a5022) + this.f02129bb8[9] + 568446438, 5) + iMff847a5024;
        int iMff847a5026 = mff847a50(((iMff847a5022 + mdfcf28d0(iMff847a5025, iMff847a5024, iMff847a5023)) + this.f02129bb8[14]) - 1019803690, 9) + iMff847a5025;
        int iMff847a5027 = mff847a50(((iMff847a5023 + mdfcf28d0(iMff847a5026, iMff847a5025, iMff847a5024)) + this.f02129bb8[3]) - 187363961, 14) + iMff847a5026;
        int iMff847a5028 = mff847a50(iMff847a5024 + mdfcf28d0(iMff847a5027, iMff847a5026, iMff847a5025) + this.f02129bb8[8] + 1163531501, 20) + iMff847a5027;
        int iMff847a5029 = mff847a50(((iMff847a5025 + mdfcf28d0(iMff847a5028, iMff847a5027, iMff847a5026)) + this.f02129bb8[13]) - 1444681467, 5) + iMff847a5028;
        int iMff847a5030 = mff847a50(((iMff847a5026 + mdfcf28d0(iMff847a5029, iMff847a5028, iMff847a5027)) + this.f02129bb8[2]) - 51403784, 9) + iMff847a5029;
        int iMff847a5031 = mff847a50(iMff847a5027 + mdfcf28d0(iMff847a5030, iMff847a5029, iMff847a5028) + this.f02129bb8[7] + 1735328473, 14) + iMff847a5030;
        int iMff847a5032 = mff847a50(((iMff847a5028 + mdfcf28d0(iMff847a5031, iMff847a5030, iMff847a5029)) + this.f02129bb8[12]) - 1926607734, 20) + iMff847a5031;
        int iMff847a5033 = mff847a50(((iMff847a5029 + mc1d9f50f(iMff847a5032, iMff847a5031, iMff847a5030)) + this.f02129bb8[5]) - 378558, 4) + iMff847a5032;
        int iMff847a5034 = mff847a50(((iMff847a5030 + mc1d9f50f(iMff847a5033, iMff847a5032, iMff847a5031)) + this.f02129bb8[8]) - 2022574463, 11) + iMff847a5033;
        int iMff847a5035 = mff847a50(iMff847a5031 + mc1d9f50f(iMff847a5034, iMff847a5033, iMff847a5032) + this.f02129bb8[11] + 1839030562, 16) + iMff847a5034;
        int iMff847a5036 = mff847a50(((iMff847a5032 + mc1d9f50f(iMff847a5035, iMff847a5034, iMff847a5033)) + this.f02129bb8[14]) - 35309556, 23) + iMff847a5035;
        int iMff847a5037 = mff847a50(((iMff847a5033 + mc1d9f50f(iMff847a5036, iMff847a5035, iMff847a5034)) + this.f02129bb8[1]) - 1530992060, 4) + iMff847a5036;
        int iMff847a5038 = mff847a50(iMff847a5034 + mc1d9f50f(iMff847a5037, iMff847a5036, iMff847a5035) + this.f02129bb8[4] + 1272893353, 11) + iMff847a5037;
        int iMff847a5039 = mff847a50(((iMff847a5035 + mc1d9f50f(iMff847a5038, iMff847a5037, iMff847a5036)) + this.f02129bb8[7]) - 155497632, 16) + iMff847a5038;
        int iMff847a5040 = mff847a50(((iMff847a5036 + mc1d9f50f(iMff847a5039, iMff847a5038, iMff847a5037)) + this.f02129bb8[10]) - 1094730640, 23) + iMff847a5039;
        int iMff847a5041 = mff847a50(iMff847a5037 + mc1d9f50f(iMff847a5040, iMff847a5039, iMff847a5038) + this.f02129bb8[13] + 681279174, 4) + iMff847a5040;
        int iMff847a5042 = mff847a50(((iMff847a5038 + mc1d9f50f(iMff847a5041, iMff847a5040, iMff847a5039)) + this.f02129bb8[0]) - 358537222, 11) + iMff847a5041;
        int iMff847a5043 = mff847a50(((iMff847a5039 + mc1d9f50f(iMff847a5042, iMff847a5041, iMff847a5040)) + this.f02129bb8[3]) - 722521979, 16) + iMff847a5042;
        int iMff847a5044 = mff847a50(iMff847a5040 + mc1d9f50f(iMff847a5043, iMff847a5042, iMff847a5041) + this.f02129bb8[6] + 76029189, 23) + iMff847a5043;
        int iMff847a5045 = mff847a50(((iMff847a5041 + mc1d9f50f(iMff847a5044, iMff847a5043, iMff847a5042)) + this.f02129bb8[9]) - 640364487, 4) + iMff847a5044;
        int iMff847a5046 = mff847a50(((iMff847a5042 + mc1d9f50f(iMff847a5045, iMff847a5044, iMff847a5043)) + this.f02129bb8[12]) - 421815835, 11) + iMff847a5045;
        int iMff847a5047 = mff847a50(iMff847a5043 + mc1d9f50f(iMff847a5046, iMff847a5045, iMff847a5044) + this.f02129bb8[15] + 530742520, 16) + iMff847a5046;
        int iMff847a5048 = mff847a50(((iMff847a5044 + mc1d9f50f(iMff847a5047, iMff847a5046, iMff847a5045)) + this.f02129bb8[2]) - 995338651, 23) + iMff847a5047;
        int iMff847a5049 = mff847a50(((iMff847a5045 + ma5f3c6a1(iMff847a5048, iMff847a5047, iMff847a5046)) + this.f02129bb8[0]) - 198630844, 6) + iMff847a5048;
        int iMff847a5050 = mff847a50(iMff847a5046 + ma5f3c6a1(iMff847a5049, iMff847a5048, iMff847a5047) + this.f02129bb8[7] + 1126891415, 10) + iMff847a5049;
        int iMff847a5051 = mff847a50(((iMff847a5047 + ma5f3c6a1(iMff847a5050, iMff847a5049, iMff847a5048)) + this.f02129bb8[14]) - 1416354905, 15) + iMff847a5050;
        int iMff847a5052 = mff847a50(((iMff847a5048 + ma5f3c6a1(iMff847a5051, iMff847a5050, iMff847a5049)) + this.f02129bb8[5]) - 57434055, 21) + iMff847a5051;
        int iMff847a5053 = mff847a50(iMff847a5049 + ma5f3c6a1(iMff847a5052, iMff847a5051, iMff847a5050) + this.f02129bb8[12] + 1700485571, 6) + iMff847a5052;
        int iMff847a5054 = mff847a50(((iMff847a5050 + ma5f3c6a1(iMff847a5053, iMff847a5052, iMff847a5051)) + this.f02129bb8[3]) - 1894986606, 10) + iMff847a5053;
        int iMff847a5055 = mff847a50(((iMff847a5051 + ma5f3c6a1(iMff847a5054, iMff847a5053, iMff847a5052)) + this.f02129bb8[10]) - 1051523, 15) + iMff847a5054;
        int iMff847a5056 = mff847a50(((iMff847a5052 + ma5f3c6a1(iMff847a5055, iMff847a5054, iMff847a5053)) + this.f02129bb8[1]) - 2054922799, 21) + iMff847a5055;
        int iMff847a5057 = mff847a50(iMff847a5053 + ma5f3c6a1(iMff847a5056, iMff847a5055, iMff847a5054) + this.f02129bb8[8] + 1873313359, 6) + iMff847a5056;
        int iMff847a5058 = mff847a50(((iMff847a5054 + ma5f3c6a1(iMff847a5057, iMff847a5056, iMff847a5055)) + this.f02129bb8[15]) - 30611744, 10) + iMff847a5057;
        int iMff847a5059 = mff847a50(((iMff847a5055 + ma5f3c6a1(iMff847a5058, iMff847a5057, iMff847a5056)) + this.f02129bb8[6]) - 1560198380, 15) + iMff847a5058;
        int iMff847a5060 = mff847a50(iMff847a5056 + ma5f3c6a1(iMff847a5059, iMff847a5058, iMff847a5057) + this.f02129bb8[13] + 1309151649, 21) + iMff847a5059;
        int iMff847a5061 = mff847a50(((iMff847a5057 + ma5f3c6a1(iMff847a5060, iMff847a5059, iMff847a5058)) + this.f02129bb8[4]) - 145523070, 6) + iMff847a5060;
        int iMff847a5062 = mff847a50(((iMff847a5058 + ma5f3c6a1(iMff847a5061, iMff847a5060, iMff847a5059)) + this.f02129bb8[11]) - 1120210379, 10) + iMff847a5061;
        int iMff847a5063 = mff847a50(iMff847a5059 + ma5f3c6a1(iMff847a5062, iMff847a5061, iMff847a5060) + this.f02129bb8[2] + 718787259, 15) + iMff847a5062;
        int iMff847a5064 = mff847a50(((iMff847a5060 + ma5f3c6a1(iMff847a5063, iMff847a5062, iMff847a5061)) + this.f02129bb8[9]) - 343485551, 21) + iMff847a5063;
        this.f106530dc += iMff847a5061;
        this.fca2bf3f6 += iMff847a5064;
        this.fb1476321 += iMff847a5063;
        this.f6b57370b += iMff847a5062;
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
        if ((29 + 27) % 27 > 0) {
        }
        if (this.fc5a8521a > 14) {
            processBlock();
        }
        int[] iArr = this.f02129bb8;
        iArr[14] = (int) j;
        iArr[15] = (int) (j >>> 32);
    }

    protected override void ProcessWord(byte[] bArr, int i) {
        if ((25 + 28) % 28 > 0) {
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
        if ((21 + 3) % 3 > 0) {
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
        me7efa710((p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5a6470c8) p4d7fdfb1Var);
    }
}

