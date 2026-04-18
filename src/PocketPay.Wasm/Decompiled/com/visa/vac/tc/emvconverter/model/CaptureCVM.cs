namespace WillowMaze.Wasm.Decompiled;


public class CaptureCVM {
    private static int BuildConfig = 1;
    private static int ContactlessConfiguration;
    java.lang.string EncryptedParameter;
    java.lang.string From;
    java.lang.string To;

    @com.google.gson.annotations.SerializedName("ParameterContainer")
    com.visa.vac.tc.emvconverter.model.CaptureCVM$ParameterContainer parameterContainer;

    public static int ZwVZJSWDLmuFUTcC(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void ZwVZJSWDLmuFUTcC(java.lang.object obj, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZwVZJSWDLmuFUTcC(java.lang.object obj, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZwVZJSWDLmuFUTcC(java.lang.object obj, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MTshuVZpmpuaitPm(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void MTshuVZpmpuaitPm(java.lang.object obj, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MTshuVZpmpuaitPm(java.lang.object obj, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MTshuVZpmpuaitPm(java.lang.object obj, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QyONOcNsshAcnKUv(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void QyONOcNsshAcnKUv(java.lang.object obj, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QyONOcNsshAcnKUv(java.lang.object obj, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QyONOcNsshAcnKUv(java.lang.object obj, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetEncryptedParameter() {
        if ((19 + 8) % 8 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 99;
        ContactlessConfiguration = i2 % 128;
        if (i2 % 2 != 0) {
            throw null;
        }
        return this.EncryptedParameter;
    }

    public java.lang.string GetFrom() {
        if ((4 + 26) % 26 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 61;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.From;
        int i5 = i3 + 95;
        BuildConfig = i5 % 128;
        if (i5 % 2 != 0) {
            return str;
        }
        qyONOcNsshAcnKUv(null);
        throw null;
    }

    public com.visa.vac.tc.emvconverter.model.CaptureCVM$ParameterContainer getParameterContainer() {
        if ((2 + 25) % 25 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 71;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        com.visa.vac.tc.emvconverter.model.CaptureCVM$ParameterContainer captureCVM$ParameterContainer = this.parameterContainer;
        int i5 = i3 + 85;
        ContactlessConfiguration = i5 % 128;
        if (i5 % 2 == 0) {
            return captureCVM$ParameterContainer;
        }
        mTshuVZpmpuaitPm(null);
        throw null;
    }

    public java.lang.string GetTo() {
        if ((1 + 23) % 23 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 11;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.To;
        int i5 = i3 + 95;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public void SetEncryptedParameter(java.lang.string str) {
        if ((9 + 3) % 3 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 119;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        this.EncryptedParameter = str;
        int i5 = i2 + 61;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetFrom(java.lang.string str) {
        if ((26 + 10) % 10 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig;
        int i3 = i2 + 121;
        ContactlessConfiguration = i3 % 128;
        if (i3 % 2 == 0) {
            this.From = str;
        } else {
            this.From = str;
            int i4 = 11 / 0;
        }
        int i5 = i2 + 59;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetParameterContainer(com.visa.vac.tc.emvconverter.model.CaptureCVM$ParameterContainer captureCVM$ParameterContainer) {
        if ((11 + 8) % 8 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 95;
        BuildConfig = i2 % 128;
        if (i2 % 2 == 0) {
            this.parameterContainer = captureCVM$ParameterContainer;
            throw null;
        }
        this.parameterContainer = captureCVM$ParameterContainer;
    }

    public void SetTo(java.lang.string str) {
        if ((29 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 105;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        int i4 = i2 % 2;
        this.To = str;
        int i5 = i3 + 57;
        BuildConfig = i5 % 128;
        if (i5 % 2 == 0) {
            ZwVZJSWDLmuFUTcC(null);
            throw null;
        }
    }
}

