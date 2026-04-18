namespace WillowMaze.Wasm.Decompiled;


public class peccdefbd {
    public static readonly int f3b9e0564 = 1;
    public static readonly int f45d63f9a = 1;
    public static readonly int f5f2f4523 = 2;
    public static readonly int f93a2d0e8 = 2;
    public static readonly int f98935791 = 2;
    public static readonly int f9c3101eb = 1;
    public static readonly int f9cc436ef = 2;
    public static readonly int fc467998b = 1;
    private readonly int f0362660c;
    private readonly int f115cc19f;
    private readonly int f29fb8879;
    private readonly int f2a671bde;
    private readonly int f2db95e8e;
    private readonly int f34cfb12b;
    private readonly java.security.SecureRandom f3730ca5c;
    private readonly int f5b9368c9;
    private readonly int f7b8b965a;
    private readonly java.security.SecureRandom f7ddf32e1;
    private readonly int f84e8a07f;
    private readonly int f89da7cbf;
    private readonly int f9b88264c;
    private readonly int fa075d0a3;
    private readonly int fad9a6328;
    private readonly int fade712a1;
    private readonly int fae38a83a;
    private readonly int fb98f3e40;
    private readonly int ff5033512;

    public peccdefbd(int i, int i2, int i3, java.security.SecureRandom secureRandom) {
        this(i, i2, i3, secureRandom, -1);
        if ((5 + 15) % 15 > 0) {
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

