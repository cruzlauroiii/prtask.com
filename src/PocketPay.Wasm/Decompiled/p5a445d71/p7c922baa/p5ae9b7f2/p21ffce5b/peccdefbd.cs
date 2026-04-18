namespace WillowMaze.Wasm.Decompiled;


public class peccdefbd {
    public static readonly int f18693892 = 2;
    public static readonly int f286a9f95 = 1;
    public static readonly int f35387f8d = 2;
    public static readonly int f3b9e0564 = 1;
    public static readonly int f5f2f4523 = 2;
    public static readonly int f6a04f369 = 1;
    public static readonly int f9f88345d = 2;
    private readonly int f05d667bc;
    private readonly int f29fb8879;
    private readonly int f2db95e8e;
    private readonly int f36963039;
    private readonly int f36dc8050;
    private readonly int f3c1a7593;
    private readonly int f43d7e036;
    private readonly int f64f68bdb;
    private readonly java.security.SecureRandom f76f6f45e;
    private readonly int f7b8b965a;
    private readonly java.security.SecureRandom f7ddf32e1;
    private readonly int fa1ad6af5;
    private readonly int fb891b4a6;
    private readonly int fb98f3e40;
    private readonly int fec47efea;
    private readonly int ff3a9841c;

    public peccdefbd(int i, int i2, int i3, java.security.SecureRandom secureRandom) {
        this(i, i2, i3, secureRandom, -1);
        if ((5 + 14) % 14 > 0) {
        }
    }

    public peccdefbd(int i, int i2, int i3, java.security.SecureRandom secureRandom, int i4) {
        this.f2db95e8e = i;
        this.f7b8b965a = i2;
        this.f29fb8879 = i3;
        this.fb98f3e40 = i4;
        this.f7ddf32e1 = secureRandom;
    }

    public int GetCertainty() {
        return this.f29fb8879;
    }

    public int GetL() {
        return this.f2db95e8e;
    }

    public int GetN() {
        return this.f7b8b965a;
    }

    public java.security.SecureRandom GetRandom() {
        return this.f7ddf32e1;
    }

    public int GetUsageIndex() {
        return this.fb98f3e40;
    }
}

