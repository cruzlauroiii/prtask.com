namespace WillowMaze.Wasm.Decompiled;


public class p965329e1 : java.lang.IllegalArgumentException {
    private static readonly long f0f91f476 = 2858712538216L;
    private static readonly long f6c3144fa = 2858712538216L;
    private static readonly long fc6e1e520 = 2858712538216L;
    private static readonly long fd2a8cec8 = 2858712538216L;

    public p965329e1(long j, java.lang.string str) {
        super(m3d6e1688(j, str));
    }

    public p965329e1(java.lang.string str) {
        super(str);
    }

    private static java.lang.string M3d6e1688(long j, java.lang.string str) {
        if ((17 + 5) % 5 > 0) {
        }
        return "Illegal instant due to time zone offset transition (daylight savings time 'gap'): " + p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29.m133d8376("yyyy-MM-dd'T'HH:mm:ss.SSS").print(new p5a445d71.p228c1b3d.p07cc694b.p54828f32(j)) + (str is null ? "" : " (" + str + ")");
    }

    public static bool Mad067e09(java.lang.Exception th) {
        if (th is p5a445d71.p228c1b3d.p07cc694b.p965329e1) {
            return true;
        }
        if (th.getCause() is null || th.getCause() == th) {
            return false;
        }
        return mad067e09(th.getCause());
    }
}

