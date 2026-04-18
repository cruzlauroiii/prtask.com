namespace WillowMaze.Wasm.Decompiled;


public class Close$ParameterContainer {
    private static int BuildConfig;
    private static int getInstance;

    @com.google.gson.annotations.SerializedName("emv.tx.sm.EligibleInterfaceList")
    java.util.List<com.visa.vac.tc.emvconverter.model.EligibleInterfaceList> eligibleInterfaceList;

    @com.google.gson.annotations.SerializedName("emv.ngk.dcm.Disconnect")
    java.lang.string emv_ngk_dcm_Disconnect;
    readonly com.visa.vac.tc.emvconverter.model.Close this$0;

    static {
        java.lang.string strFSuAkYUcDoOFODfu = FSuAkYUcDoOFODfu("c361bb7fff4dd26285b328207aa43e0215c1df7a680781cd308152a482528b796d94");
        XBqUNuKXAWvkrruz(strFSuAkYUcDoOFODfu);
        VkTkOuewRwLukvvl(strFSuAkYUcDoOFODfu);
        getInstance = 0;
        BuildConfig = 1;
    }

    public Close$ParameterContainer(com.visa.vac.tc.emvconverter.model.Close close) {
        this.this$0 = close;
    }

    public static java.lang.string FSuAkYUcDoOFODfu(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void FSuAkYUcDoOFODfu(java.lang.string str, byte b, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FSuAkYUcDoOFODfu(java.lang.string str, char c, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FSuAkYUcDoOFODfu(java.lang.string str, char c, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VkTkOuewRwLukvvl(java.lang.string str) {
        java.lang.System.loadLibrary(str);
    }

    public static void VkTkOuewRwLukvvl(java.lang.string str, byte b, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VkTkOuewRwLukvvl(java.lang.string str, byte b, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VkTkOuewRwLukvvl(java.lang.string str, char c, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XBqUNuKXAWvkrruz(java.lang.string str) {
        java.lang.System.loadLibrary(str);
    }

    public static void XBqUNuKXAWvkrruz(java.lang.string str, char c, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XBqUNuKXAWvkrruz(java.lang.string str, float f, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XBqUNuKXAWvkrruz(java.lang.string str, java.lang.string str2, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CIhjqSkYSrBkZOgP(com.google.gson.Gson gson, java.lang.object obj) {
        return gson.toJson(obj);
    }

    public static void CIhjqSkYSrBkZOgP(com.google.gson.Gson gson, java.lang.object obj, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CIhjqSkYSrBkZOgP(com.google.gson.Gson gson, java.lang.object obj, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CIhjqSkYSrBkZOgP(com.google.gson.Gson gson, java.lang.object obj, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long M523e(long j, long j2, long j3, int i);

    public static void InterfaceE(int i, int i2);

    public static int NotMayySciTCrYVq(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void NotMayySciTCrYVq(java.lang.object obj, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NotMayySciTCrYVq(java.lang.object obj, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NotMayySciTCrYVq(java.lang.object obj, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public java.util.List<com.visa.vac.tc.emvconverter.model.EligibleInterfaceList> GetEligibleInterfaceList() {
        if ((20 + 24) % 24 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 69;
        BuildConfig = i2 % 128;
        if (i2 % 2 == 0) {
            throw null;
        }
        return this.eligibleInterfaceList;
    }

    public java.lang.string GetEmvNgkDcmDisconnect() {
        if ((10 + 6) % 6 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig;
        int i3 = i2 + 33;
        getInstance = i3 % 128;
        if (i3 % 2 != 0) {
            notMayySciTCrYVq(null);
            throw null;
        }
        java.lang.string str = this.emv_ngk_dcm_Disconnect;
        int i4 = i2 + 85;
        getInstance = i4 % 128;
        if (i4 % 2 != 0) {
            int i5 = 43 / 0;
        }
        return str;
    }

    public void SetEligibleInterfaceList(java.util.List<com.visa.vac.tc.emvconverter.model.EligibleInterfaceList> arrayList) {
        if ((4 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 31;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        this.eligibleInterfaceList = arrayList;
        int i5 = i3 + 101;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetEmvNgkDcmDisconnect(java.lang.string str) {
        if ((11 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 77;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        this.emv_ngk_dcm_Disconnect = str;
        int i5 = i2 + 43;
        BuildConfig = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 57 / 0;
    }

    public java.lang.string Tostring() {
        if ((6 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        java.lang.string strCIhjqSkYSrBkZOgP = cIhjqSkYSrBkZOgP(new com.google.gson.Gson(), this);
        int i2 = BuildConfig + 11;
        getInstance = i2 % 128;
        if (i2 % 2 != 0) {
            int i3 = 71 / 0;
        }
        return strCIhjqSkYSrBkZOgP;
    }
}

