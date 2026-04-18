namespace WillowMaze.Wasm.Decompiled;


public class DetectAndOpenAndSend {
    private static int BuildConfig = 0;
    private static int getTerminalData = 1;
    java.lang.string EncryptedParameter;
    java.lang.string From;
    java.lang.string To;

    @com.google.gson.annotations.SerializedName("ParameterContainer")
    com.visa.vac.tc.emvconverter.model.OpenParameterContainer parameterContainer;

    public static int VafjqNBbQPEeMtMx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void VafjqNBbQPEeMtMx(java.lang.object obj, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VafjqNBbQPEeMtMx(java.lang.object obj, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VafjqNBbQPEeMtMx(java.lang.object obj, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GNeEtmUyloKNiqdz(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void GNeEtmUyloKNiqdz(java.lang.object obj, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GNeEtmUyloKNiqdz(java.lang.object obj, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNeEtmUyloKNiqdz(java.lang.object obj, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MlhOXrjMebGuJNgI(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void MlhOXrjMebGuJNgI(java.lang.object obj, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MlhOXrjMebGuJNgI(java.lang.object obj, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MlhOXrjMebGuJNgI(java.lang.object obj, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TqQfPMxROdwubAbj(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void TqQfPMxROdwubAbj(java.lang.object obj, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TqQfPMxROdwubAbj(java.lang.object obj, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TqQfPMxROdwubAbj(java.lang.object obj, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetEncryptedParameter() {
        if ((21 + 22) % 22 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 43;
        int i3 = i2 % 128;
        getTerminalData = i3;
        if (i2 % 2 == 0) {
            gNeEtmUyloKNiqdz(null);
            throw null;
        }
        java.lang.string str = this.EncryptedParameter;
        int i4 = i3 + 57;
        BuildConfig = i4 % 128;
        int i5 = i4 % 2;
        return str;
    }

    public java.lang.string GetFrom() {
        if ((17 + 19) % 19 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig;
        int i3 = i2 + 15;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.From;
        int i5 = i2 + 117;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public com.visa.vac.tc.emvconverter.model.OpenParameterContainer GetParameterContainer() {
        if ((29 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 27;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        com.visa.vac.tc.emvconverter.model.OpenParameterContainer openParameterContainer = this.parameterContainer;
        int i5 = i3 + 65;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return openParameterContainer;
    }

    public java.lang.string GetTo() {
        if ((21 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 105;
        BuildConfig = i2 % 128;
        int i3 = i2 % 2;
        java.lang.string str = this.To;
        if (i3 != 0) {
            int i4 = 87 / 0;
        }
        return str;
    }

    public void SetEncryptedParameter(java.lang.string str) {
        if ((11 + 31) % 31 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 75;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        this.EncryptedParameter = str;
        int i5 = i3 + 51;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetFrom(java.lang.string str) {
        if ((12 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 95;
        getTerminalData = i2 % 128;
        if (i2 % 2 != 0) {
            this.From = str;
        } else {
            this.From = str;
            VafjqNBbQPEeMtMx(null);
            throw null;
        }
    }

    public void SetParameterContainer(com.visa.vac.tc.emvconverter.model.OpenParameterContainer openParameterContainer) {
        if ((6 + 11) % 11 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 69;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        this.parameterContainer = openParameterContainer;
        int i5 = i3 + 51;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetTo(java.lang.string str) {
        if ((32 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 65;
        int i3 = i2 % 128;
        BuildConfig = i3;
        if (i2 % 2 != 0) {
            this.To = str;
            mlhOXrjMebGuJNgI(null);
            throw null;
        }
        this.To = str;
        int i4 = i3 + 11;
        getTerminalData = i4 % 128;
        if (i4 % 2 == 0) {
            tqQfPMxROdwubAbj(null);
            throw null;
        }
    }
}

