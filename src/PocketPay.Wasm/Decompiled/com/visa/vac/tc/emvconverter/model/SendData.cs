namespace WillowMaze.Wasm.Decompiled;


public class SendData {
    private static int BuildConfig = 1;
    private static int getTerminalData;
    java.lang.string EncryptedParameter;
    java.lang.string From;
    java.lang.string To;

    @com.google.gson.annotations.SerializedName("ParameterContainer")
    com.visa.vac.tc.emvconverter.model.OpenParameterContainer parameterContainer;

    public static int DSCNrpCOXHjPsYlt(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void DSCNrpCOXHjPsYlt(java.lang.object obj, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DSCNrpCOXHjPsYlt(java.lang.object obj, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DSCNrpCOXHjPsYlt(java.lang.object obj, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LhLSOzdootbLBuiX(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void LhLSOzdootbLBuiX(java.lang.object obj, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LhLSOzdootbLBuiX(java.lang.object obj, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LhLSOzdootbLBuiX(java.lang.object obj, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QWwLFeQaCmazjMJY(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void QWwLFeQaCmazjMJY(java.lang.object obj, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QWwLFeQaCmazjMJY(java.lang.object obj, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QWwLFeQaCmazjMJY(java.lang.object obj, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetEncryptedParameter() {
        if ((5 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 125;
        BuildConfig = i3 % 128;
        if (i3 % 2 == 0) {
            qWwLFeQaCmazjMJY(null);
            throw null;
        }
        java.lang.string str = this.EncryptedParameter;
        int i4 = i2 + 33;
        BuildConfig = i4 % 128;
        int i5 = i4 % 2;
        return str;
    }

    public java.lang.string GetFrom() {
        if ((28 + 22) % 22 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig;
        int i3 = i2 + 1;
        getTerminalData = i3 % 128;
        if (i3 % 2 != 0) {
            throw null;
        }
        java.lang.string str = this.From;
        int i4 = i2 + 99;
        getTerminalData = i4 % 128;
        int i5 = i4 % 2;
        return str;
    }

    public com.visa.vac.tc.emvconverter.model.OpenParameterContainer GetParameterContainer() {
        if ((23 + 23) % 23 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 99;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        com.visa.vac.tc.emvconverter.model.OpenParameterContainer openParameterContainer = this.parameterContainer;
        int i5 = i2 + 57;
        BuildConfig = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return openParameterContainer;
    }

    public java.lang.string GetTo() {
        if ((5 + 23) % 23 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 51;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.To;
        int i5 = i2 + 33;
        BuildConfig = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 89 / 0;
        }
        return str;
    }

    public void SetEncryptedParameter(java.lang.string str) {
        if ((29 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig;
        int i3 = i2 + 99;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        this.EncryptedParameter = str;
        int i5 = i2 + 45;
        getTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            return;
        }
        int i6 = 19 / 0;
    }

    public void SetFrom(java.lang.string str) {
        if ((31 + 23) % 23 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 1;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        this.From = str;
        int i5 = i3 + 119;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetParameterContainer(com.visa.vac.tc.emvconverter.model.OpenParameterContainer openParameterContainer) {
        if ((7 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 13;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        this.parameterContainer = openParameterContainer;
        int i5 = i3 + 3;
        getTerminalData = i5 % 128;
        if (i5 % 2 != 0) {
            DSCNrpCOXHjPsYlt(null);
            throw null;
        }
    }

    public void SetTo(java.lang.string str) {
        if ((12 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 69;
        BuildConfig = i2 % 128;
        if (i2 % 2 != 0) {
            this.To = str;
        } else {
            this.To = str;
            lhLSOzdootbLBuiX(null);
            throw null;
        }
    }
}

