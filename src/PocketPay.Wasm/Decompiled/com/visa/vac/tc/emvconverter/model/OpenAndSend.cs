namespace WillowMaze.Wasm.Decompiled;


public class OpenAndSend {
    private static int BuildConfig = 0;
    private static int getInstance = 1;
    java.lang.string EncryptedParameter;
    java.lang.string From;
    java.lang.string To;

    @com.google.gson.annotations.SerializedName("ParameterContainer")
    com.visa.vac.tc.emvconverter.model.OpenParameterContainer parameterContainer;

    public static int IpnwcroSCGJUSgBu(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void IpnwcroSCGJUSgBu(java.lang.object obj, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IpnwcroSCGJUSgBu(java.lang.object obj, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IpnwcroSCGJUSgBu(java.lang.object obj, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FGCuFMrEbUqOSxhV(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void FGCuFMrEbUqOSxhV(java.lang.object obj, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FGCuFMrEbUqOSxhV(java.lang.object obj, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FGCuFMrEbUqOSxhV(java.lang.object obj, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OuSoqrpIDSWDWubU(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void OuSoqrpIDSWDWubU(java.lang.object obj, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OuSoqrpIDSWDWubU(java.lang.object obj, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OuSoqrpIDSWDWubU(java.lang.object obj, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetEncryptedParameter() {
        if ((5 + 32) % 32 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 111;
        getInstance = i2 % 128;
        if (i2 % 2 != 0) {
            return this.EncryptedParameter;
        }
        IpnwcroSCGJUSgBu(null);
        throw null;
    }

    public java.lang.string GetFrom() {
        if ((22 + 7) % 7 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 91;
        BuildConfig = i2 % 128;
        if (i2 % 2 != 0) {
            throw null;
        }
        return this.From;
    }

    public com.visa.vac.tc.emvconverter.model.OpenParameterContainer GetParameterContainer() {
        if ((13 + 22) % 22 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 89;
        int i3 = i2 % 128;
        BuildConfig = i3;
        if (i2 % 2 != 0) {
            ouSoqrpIDSWDWubU(null);
            throw null;
        }
        com.visa.vac.tc.emvconverter.model.OpenParameterContainer openParameterContainer = this.parameterContainer;
        int i4 = i3 + 45;
        getInstance = i4 % 128;
        if (i4 % 2 != 0) {
            return openParameterContainer;
        }
        fGCuFMrEbUqOSxhV(null);
        throw null;
    }

    public java.lang.string GetTo() {
        if ((10 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 71;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.To;
        int i5 = i3 + 43;
        getInstance = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 3 / 0;
        }
        return str;
    }

    public void SetEncryptedParameter(java.lang.string str) {
        if ((24 + 4) % 4 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 93;
        getInstance = i2 % 128;
        if (i2 % 2 == 0) {
            this.EncryptedParameter = str;
            throw null;
        }
        this.EncryptedParameter = str;
    }

    public void SetFrom(java.lang.string str) {
        if ((24 + 5) % 5 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 115;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        this.From = str;
        int i5 = i3 + 105;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetParameterContainer(com.visa.vac.tc.emvconverter.model.OpenParameterContainer openParameterContainer) {
        if ((29 + 4) % 4 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 35;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        this.parameterContainer = openParameterContainer;
        int i5 = i3 + 23;
        getInstance = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 25 / 0;
    }

    public void SetTo(java.lang.string str) {
        if ((27 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 57;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        this.To = str;
        int i5 = i2 + 57;
        BuildConfig = i5 % 128;
        if (i5 % 2 == 0) {
            return;
        }
        int i6 = 87 / 0;
    }
}

