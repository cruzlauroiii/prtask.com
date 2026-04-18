namespace WillowMaze.Wasm.Decompiled;


public class CaptureCVM$ParameterContainer {
    private static int getInstance = 1;
    private static int getTerminalData;

    @com.google.gson.annotations.SerializedName("emv.tx.cvm.CVMToCaptureCDO")
    com.visa.vac.tc.emvconverter.model.CvmToCaptureCDO cvmToCapture;
    readonly com.visa.vac.tc.emvconverter.model.CaptureCVM this$0;

    public CaptureCVM$ParameterContainer(com.visa.vac.tc.emvconverter.model.CaptureCVM captureCVM) {
        this.this$0 = captureCVM;
    }

    public static java.lang.string NWOivdWmozyjNpdh(com.google.gson.Gson gson, java.lang.object obj) {
        return gson.toJson(obj);
    }

    public static void NWOivdWmozyjNpdh(com.google.gson.Gson gson, java.lang.object obj, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NWOivdWmozyjNpdh(com.google.gson.Gson gson, java.lang.object obj, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NWOivdWmozyjNpdh(com.google.gson.Gson gson, java.lang.object obj, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SNeQTxBiAvklmtZr(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void SNeQTxBiAvklmtZr(java.lang.object obj, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SNeQTxBiAvklmtZr(java.lang.object obj, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SNeQTxBiAvklmtZr(java.lang.object obj, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public com.visa.vac.tc.emvconverter.model.CvmToCaptureCDO GetCvmToCapture() {
        if ((7 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 47;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        com.visa.vac.tc.emvconverter.model.CvmToCaptureCDO cvmToCaptureCDO = this.cvmToCapture;
        int i5 = i2 + 59;
        getInstance = i5 % 128;
        if (i5 % 2 != 0) {
            return cvmToCaptureCDO;
        }
        SNeQTxBiAvklmtZr(null);
        throw null;
    }

    public void SetCvmToCapture(com.visa.vac.tc.emvconverter.model.CvmToCaptureCDO cvmToCaptureCDO) {
        if ((26 + 6) % 6 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 53;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        this.cvmToCapture = cvmToCaptureCDO;
        int i5 = i2 + 71;
        getInstance = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
    }

    public java.lang.string Tostring() {
        if ((22 + 5) % 5 > 0) {
        }
        int i = 2 % 2;
        java.lang.string strNWOivdWmozyjNpdh = NWOivdWmozyjNpdh(new com.google.gson.Gson(), this);
        int i2 = getInstance + 33;
        getTerminalData = i2 % 128;
        int i3 = i2 % 2;
        return strNWOivdWmozyjNpdh;
    }
}

