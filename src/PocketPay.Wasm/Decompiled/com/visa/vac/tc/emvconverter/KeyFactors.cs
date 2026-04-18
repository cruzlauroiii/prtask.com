namespace WillowMaze.Wasm.Decompiled;


public class KeyFactors {
    private static int e1 = 0;
    private static int setTerminalData = 1;
    private java.math.Bigint BuildConfig;
    private java.math.Bigint ContactlessConfiguration;
    private java.math.Bigint getInstance;
    private java.math.Bigint getTerminalData;

    KeyFactors() {
    }

    public KeyFactors(java.math.Bigint bigint, java.math.Bigint bigint2) {
        this.getInstance = bigint;
        this.ContactlessConfiguration = bigint2;
    }

    public KeyFactors(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this.getTerminalData = bigint;
        this.BuildConfig = bigint2;
        this.ContactlessConfiguration = bigint3;
    }

    public static int ZXFPPhzazmNNACDz(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void ZXFPPhzazmNNACDz(java.lang.object obj, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZXFPPhzazmNNACDz(java.lang.object obj, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZXFPPhzazmNNACDz(java.lang.object obj, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public java.math.Bigint GetExpo() {
        if ((27 + 7) % 7 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData + 121;
        int i3 = i2 % 128;
        e1 = i3;
        int i4 = i2 % 2;
        java.math.Bigint bigint = this.ContactlessConfiguration;
        int i5 = i3 + 107;
        setTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 41 / 0;
        }
        return bigint;
    }

    public java.math.Bigint GetModulus() {
        if ((13 + 15) % 15 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1;
        int i3 = i2 + 89;
        setTerminalData = i3 % 128;
        int i4 = i3 % 2;
        java.math.Bigint bigint = this.getInstance;
        int i5 = i2 + 87;
        setTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return bigint;
    }

    public java.math.Bigint GetP1() {
        if ((10 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData + 123;
        e1 = i2 % 128;
        if (i2 % 2 != 0) {
            throw null;
        }
        return this.getTerminalData;
    }

    public java.math.Bigint GetP2() {
        if ((29 + 26) % 26 > 0) {
        }
        int i = 2 % 2;
        int i2 = setTerminalData + 63;
        int i3 = i2 % 128;
        e1 = i3;
        if (i2 % 2 != 0) {
            zXFPPhzazmNNACDz(null);
            throw null;
        }
        java.math.Bigint bigint = this.BuildConfig;
        int i4 = i3 + 11;
        setTerminalData = i4 % 128;
        int i5 = i4 % 2;
        return bigint;
    }
}

