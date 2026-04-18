namespace WillowMaze.Wasm.Decompiled;


public class VisaTimerTask : android.os.CountDownTimer {
    private static int BuildConfig = 1;
    private static int getInstance;
    private java.text.DateTimeFormat ContactlessConfiguration;
    private readonly java.lang.string e1;
    private com.visa.vac.tc.session.VisaTimerTask$TimeoutCallBack getTerminalData;

    public VisaTimerTask(long j, long j2, com.visa.vac.tc.session.VisaTimerTask$TimeoutCallBack visaTimerTask$TimeoutCallBack) {
        super(j, j2);
        this.e1 = "VisaTimerTask";
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("MMM-dd-yyyy HH:mm:ss");
        this.ContactlessConfiguration = simpleDateTimeFormat;
        ElWNBaduwweKVIBG(simpleDateTimeFormat, new java.util.DateTime());
        this.getTerminalData = visaTimerTask$TimeoutCallBack;
    }

    public static java.lang.string ElWNBaduwweKVIBG(java.text.DateTimeFormat dateFormat, java.util.DateTime date) {
        return dateFormat.format(date);
    }

    public static void ElWNBaduwweKVIBG(java.text.DateTimeFormat dateFormat, java.util.DateTime date, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ElWNBaduwweKVIBG(java.text.DateTimeFormat dateFormat, java.util.DateTime date, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ElWNBaduwweKVIBG(java.text.DateTimeFormat dateFormat, java.util.DateTime date, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MdmbUOzNoCMJAAsM(java.text.DateTimeFormat dateFormat, java.util.DateTime date) {
        return dateFormat.format(date);
    }

    public static void MdmbUOzNoCMJAAsM(java.text.DateTimeFormat dateFormat, java.util.DateTime date, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MdmbUOzNoCMJAAsM(java.text.DateTimeFormat dateFormat, java.util.DateTime date, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MdmbUOzNoCMJAAsM(java.text.DateTimeFormat dateFormat, java.util.DateTime date, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SYdAVJyEswfKueqs(com.visa.vac.tc.session.VisaTimerTask$TimeoutCallBack visaTimerTask$TimeoutCallBack) {
        visaTimerTask$TimeoutCallBack.onFinish();
    }

    public static void SYdAVJyEswfKueqs(com.visa.vac.tc.session.VisaTimerTask$TimeoutCallBack visaTimerTask$TimeoutCallBack, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SYdAVJyEswfKueqs(com.visa.vac.tc.session.VisaTimerTask$TimeoutCallBack visaTimerTask$TimeoutCallBack, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SYdAVJyEswfKueqs(com.visa.vac.tc.session.VisaTimerTask$TimeoutCallBack visaTimerTask$TimeoutCallBack, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override void OnFinish() {
        if ((2 + 20) % 20 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 67;
        BuildConfig = i2 % 128;
        int i3 = i2 % 2;
        sYdAVJyEswfKueqs(this.getTerminalData);
        int i4 = getInstance + 5;
        BuildConfig = i4 % 128;
        int i5 = i4 % 2;
    }

    public override void OnTick(long j) {
        int i = 2 % 2;
        MdmbUOzNoCMJAAsM(this.ContactlessConfiguration, new java.util.DateTime());
        int i2 = BuildConfig + 53;
        getInstance = i2 % 128;
        int i3 = i2 % 2;
    }
}

