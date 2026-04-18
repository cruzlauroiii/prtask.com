namespace WillowMaze.Wasm.Decompiled;


public class pb804e69d {
    private readonly int f28a1e282;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f3e87967c;
    private readonly int f3f21b898;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f3feba6a5;
    private readonly int f47f00c95;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f49c85378;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f59971427;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f7694f4a6;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f83878c91;
    private readonly int f9f9bd1d1;
    private readonly int fa54d7449;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f fb28f4e57;
    private readonly int fd8a31b58;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f ff819eded;
    private readonly int ff888db7e;
    private readonly int ff89ed0d1;

    public pb804e69d(int i, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2, int i2) {
        if ((7 + 4) % 4 > 0) {
        }
        if (!bTXWJIHAjSkrbGPr(sTjCveroAAEojiKM(p53a5793fVar), fgIMQrtncpSDFYKW(p53a5793fVar2))) {
            throw new java.lang.IllegalArgumentException("points need to be on the same curve");
        }
        this.f28a1e282 = i;
        this.f83878c91 = p53a5793fVar;
        this.f7694f4a6 = p53a5793fVar2;
        this.ff89ed0d1 = i2;
    }

    public static int HLLGJBWXmOlTFuGL(int i) {
        return m7b1a5a4d(i);
    }

    public static int ZikiciiLOTifBlwi(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        return pa827ecfaVar.getFieldSize();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa ANalbpHWkfZjIRmR(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.getCurve();
    }

    public static bool BTXWJIHAjSkrbGPr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar2) {
        return pa827ecfaVar.Equals(pa827ecfaVar2);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa BuWadcviWNWhuuhN(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.getCurve();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa FgIMQrtncpSDFYKW(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.getCurve();
    }

    public static int GOAihSMIgJmyaoJf(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        return pa827ecfaVar.getFieldSize();
    }

    private static int M7b1a5a4d(int i) {
        int i2 = 0;
        while (true) {
            i >>= 1;
            if (i == 0) {
                return i2;
            }
            i2++;
        }
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa STjCveroAAEojiKM(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.getCurve();
    }

    public int GetCofactor() {
        return this.ff89ed0d1;
    }

    public int GetMaxOutlen() {
        return ((ZikiciiLOTifBlwi(buWadcviWNWhuuhN(this.f83878c91)) - (HLLGJBWXmOlTFuGL(this.ff89ed0d1) + 13)) / 8) * 8;
    }

    public p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f GetP() {
        return this.f83878c91;
    }

    public p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f GetQ() {
        return this.f7694f4a6;
    }

    public int GetSecurityStrength() {
        return this.f28a1e282;
    }

    public int GetSeedLen() {
        return gOAihSMIgJmyaoJf(aNalbpHWkfZjIRmR(this.f83878c91));
    }
}

