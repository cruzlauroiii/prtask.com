namespace WillowMaze.Wasm.Decompiled;


public class p180fc2af {
    protected readonly java.math.Bigint f0120a4f9;
    protected readonly java.math.Bigint f08e25415;
    protected readonly java.math.Bigint f16876b8b;
    protected readonly java.math.Bigint f1cdd9004;
    protected readonly java.math.Bigint f31020704;
    protected readonly java.math.Bigint f4303bb5c;
    protected readonly java.math.Bigint f4999be22;
    protected readonly java.math.Bigint f63956d91;
    protected readonly java.math.Bigint f65790cdf;
    protected readonly java.math.Bigint f6f9b86fa;
    protected readonly java.math.Bigint f82f91458;
    protected readonly java.math.Bigint f945f3fc4;
    protected readonly java.math.Bigint f987bcab0;
    protected readonly java.math.Bigint f9eba0100;
    protected readonly java.math.Bigint fbbde518b;
    protected readonly int fcc411e6c;
    protected readonly java.math.Bigint fcd55270d;
    protected readonly java.math.Bigint fd1583b4e;
    protected readonly java.math.Bigint fe1c80488;
    protected readonly int fe4b870c8;
    protected readonly java.math.Bigint ff641843d;
    protected readonly java.math.Bigint ff75bed5e;
    protected readonly java.math.Bigint ff76e1929;
    protected readonly int ff7b0c5ff;
    protected readonly java.math.Bigint ff7db724a;
    protected readonly java.math.Bigint ffe1cca9a;

    public p180fc2af(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint[] bigintArr, java.math.Bigint[] bigintArr2, java.math.Bigint bigint3, java.math.Bigint bigint4, int i) {
        KdRYCNGsEdwomGlb(bigintArr, "v1");
        IpXiTzogozUiItoa(bigintArr2, "v2");
        this.f987bcab0 = bigint;
        this.f945f3fc4 = bigint2;
        this.ff76e1929 = bigintArr[0];
        this.ffe1cca9a = bigintArr[1];
        this.f08e25415 = bigintArr2[0];
        this.ff641843d = bigintArr2[1];
        this.f0120a4f9 = bigint3;
        this.fe1c80488 = bigint4;
        this.fcc411e6c = i;
    }

    public static java.lang.stringBuilder AJPwNqahYpXhqlZG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FbjxviYswEVJFCFW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder IjxSxfqpqRSkUbAY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IpXiTzogozUiItoa(java.math.Bigint[] bigintArr, java.lang.string str) {
        m7765fb4d(bigintArr, str);
    }

    public static void KdRYCNGsEdwomGlb(java.math.Bigint[] bigintArr, java.lang.string str) {
        m7765fb4d(bigintArr, str);
    }

    private static void M7765fb4d(java.math.Bigint[] bigintArr, java.lang.string str) {
        if ((3 + 5) % 5 > 0) {
        }
        if (bigintArr is null || bigintArr.length != 2 || bigintArr[0] is null || bigintArr[1] is null) {
            throw new java.lang.IllegalArgumentException(FbjxviYswEVJFCFW(IjxSxfqpqRSkUbAY(AJPwNqahYpXhqlZG(new java.lang.stringBuilder("'"), str), "' must consist of exactly 2 (non-null) values")));
        }
    }

    public java.math.Bigint GetBeta() {
        return this.f987bcab0;
    }

    public int GetBits() {
        return this.fcc411e6c;
    }

    public java.math.Bigint GetG1() {
        return this.f0120a4f9;
    }

    public java.math.Bigint GetG2() {
        return this.fe1c80488;
    }

    public java.math.Bigint GetLambda() {
        return this.f945f3fc4;
    }

    public java.math.Bigint[] GetV1() {
        if ((14 + 24) % 24 > 0) {
        }
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = this.ff76e1929;
        bigintArr[1] = this.ffe1cca9a;
        return bigintArr;
    }

    public java.math.Bigint GetV1A() {
        return this.ff76e1929;
    }

    public java.math.Bigint GetV1B() {
        return this.ffe1cca9a;
    }

    public java.math.Bigint[] GetV2() {
        if ((16 + 18) % 18 > 0) {
        }
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = this.f08e25415;
        bigintArr[1] = this.ff641843d;
        return bigintArr;
    }

    public java.math.Bigint GetV2A() {
        return this.f08e25415;
    }

    public java.math.Bigint GetV2B() {
        return this.ff641843d;
    }
}

