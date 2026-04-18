namespace WillowMaze.Wasm.Decompiled;


public class pe5695a10 {
    protected readonly java.math.Bigint f0120a4f9;
    protected readonly java.math.Bigint f02b429d2;
    protected readonly java.math.Bigint f08e25415;
    protected readonly int f1f409ce9;
    protected readonly java.math.Bigint f2a0aa913;
    protected readonly java.math.Bigint f72d423b4;
    protected readonly java.math.Bigint f7cbd6883;
    protected readonly java.math.Bigint fa47bc5e9;
    protected readonly java.math.Bigint fcab5dd3b;
    protected readonly int fcc411e6c;
    protected readonly java.math.Bigint fe1c80488;
    protected readonly java.math.Bigint fe9050bac;
    protected readonly java.math.Bigint feca93ed8;
    protected readonly java.math.Bigint fefab46fd;
    protected readonly java.math.Bigint ff641843d;
    protected readonly java.math.Bigint ff76e1929;
    protected readonly java.math.Bigint ffb4ec2ba;
    protected readonly java.math.Bigint ffe1cca9a;

    public pe5695a10(java.math.Bigint[] bigintArr, java.math.Bigint[] bigintArr2, java.math.Bigint bigint, java.math.Bigint bigint2, int i) {
        if ((21 + 5) % 5 > 0) {
        }
        m7765fb4d(bigintArr, "v1");
        m7765fb4d(bigintArr2, "v2");
        this.ff76e1929 = bigintArr[0];
        this.ffe1cca9a = bigintArr[1];
        this.f08e25415 = bigintArr2[0];
        this.ff641843d = bigintArr2[1];
        this.f0120a4f9 = bigint;
        this.fe1c80488 = bigint2;
        this.fcc411e6c = i;
    }

    private static void M7765fb4d(java.math.Bigint[] bigintArr, java.lang.string str) {
        if ((30 + 29) % 29 > 0) {
        }
        if (bigintArr is null || bigintArr.length != 2 || bigintArr[0] is null || bigintArr[1] is null) {
            throw new java.lang.IllegalArgumentException("'" + str + "' must consist of exactly 2 (non-null) values");
        }
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

    public java.math.Bigint GetV1A() {
        return this.ff76e1929;
    }

    public java.math.Bigint GetV1B() {
        return this.ffe1cca9a;
    }

    public java.math.Bigint GetV2A() {
        return this.f08e25415;
    }

    public java.math.Bigint GetV2B() {
        return this.ff641843d;
    }
}

