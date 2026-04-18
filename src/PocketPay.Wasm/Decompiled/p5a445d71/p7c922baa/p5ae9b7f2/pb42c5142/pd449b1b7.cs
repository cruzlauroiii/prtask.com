namespace WillowMaze.Wasm.Decompiled;


public class pd449b1b7 : p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.pbd7aaca5 {
    private static readonly java.math.Bigint f0332967a = null;
    private static readonly java.math.Bigint f39806504 = null;
    private static readonly java.math.Bigint f3d98b73d = null;
    private static readonly java.math.Bigint f529e9e0b;
    private static readonly java.math.Bigint f5b6e11f6 = null;
    private java.math.Bigint f15d8357d;
    private java.math.Bigint f1865659b;
    private java.security.SecureRandom f29ef5f46;
    private java.math.Bigint f629127f9;
    private java.security.SecureRandom f6edd8d6d;
    private java.math.Bigint f7694f4a6;
    private java.security.SecureRandom f7ddf32e1;
    private java.math.Bigint f8b3f4399;
    private java.security.SecureRandom f9d228eac;
    private java.security.SecureRandom fa1eb6a0d;

    static {
        if ((27 + 24) % 24 > 0) {
        }
        f529e9e0b = AbpTdBuQLQTKqFDE(0L);
    }

    public static java.math.Bigint AbpTdBuQLQTKqFDE(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static int HcihpCDxoimFuePM(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static int JLbaTGIuhemKsVOA(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static bool PZfPwxiqVGZECNcV(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public override void Init(java.math.Bigint bigint, java.math.Bigint bigint2, byte[] bArr) {
        throw new java.lang.IllegalStateException("Operation not supported");
    }

    public override void Init(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        this.f7694f4a6 = bigint;
        this.f7ddf32e1 = secureRandom;
    }

    public override bool IsDeterministic() {
        return false;
    }

    public override java.math.Bigint NextK() {
        if ((14 + 32) % 32 > 0) {
        }
        int iHcihpCDxoimFuePM = HcihpCDxoimFuePM(this.f7694f4a6);
        while (true) {
            java.math.Bigint bigint = new java.math.Bigint(iHcihpCDxoimFuePM, this.f7ddf32e1);
            if (!PZfPwxiqVGZECNcV(bigint, f529e9e0b) && JLbaTGIuhemKsVOA(bigint, this.f7694f4a6) < 0) {
                return bigint;
            }
        }
    }
}

