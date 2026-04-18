namespace WillowMaze.Wasm.Decompiled;


public class TransactionCompletion {
    private static int BuildConfig;
    private static int getInstance;
    java.lang.string EncryptedParameter;
    java.lang.string From;
    java.lang.string To;

    @com.google.gson.annotations.SerializedName("ParameterContainer")
    com.visa.vac.tc.emvconverter.model.TransactionCompletion$ParameterContainer parameterContainer;

    static {
        LhPTojeQTlXivWcO(RIyVfvcmfImXoyuP("d113723cd3cc3f9127da13c4b241cfe70dead717cc62a468857cb5782dad71488c7e"));
        getInstance = 0;
        BuildConfig = 1;
    }

    public static int DLQQkUKduDgOMDim(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void DLQQkUKduDgOMDim(java.lang.object obj, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DLQQkUKduDgOMDim(java.lang.object obj, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DLQQkUKduDgOMDim(java.lang.object obj, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LhPTojeQTlXivWcO(java.lang.string str) {
        java.lang.System.loadLibrary(str);
    }

    public static void LhPTojeQTlXivWcO(java.lang.string str, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LhPTojeQTlXivWcO(java.lang.string str, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LhPTojeQTlXivWcO(java.lang.string str, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RIyVfvcmfImXoyuP(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void RIyVfvcmfImXoyuP(java.lang.string str, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RIyVfvcmfImXoyuP(java.lang.string str, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RIyVfvcmfImXoyuP(java.lang.string str, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int M526a(int i, int i2);

    public static int SHLpBheHeZSOpStc(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void SHLpBheHeZSOpStc(java.lang.object obj, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SHLpBheHeZSOpStc(java.lang.object obj, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SHLpBheHeZSOpStc(java.lang.object obj, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetEncryptedParameter() {
        if ((17 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 51;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.EncryptedParameter;
        int i5 = i3 + 45;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public java.lang.string GetFrom() {
        if ((11 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 95;
        BuildConfig = i2 % 128;
        if (i2 % 2 == 0) {
            throw null;
        }
        return this.From;
    }

    public com.visa.vac.tc.emvconverter.model.TransactionCompletion$ParameterContainer getParameterContainer() {
        if ((14 + 15) % 15 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 105;
        getInstance = i2 % 128;
        int i3 = i2 % 2;
        com.visa.vac.tc.emvconverter.model.TransactionCompletion$ParameterContainer transactionCompletion$ParameterContainer = this.parameterContainer;
        if (i3 != 0) {
            int i4 = 19 / 0;
        }
        return transactionCompletion$ParameterContainer;
    }

    public java.lang.string GetTo() {
        if ((14 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 77;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.To;
        int i5 = i2 + 91;
        BuildConfig = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return str;
    }

    public void SetEncryptedParameter(java.lang.string str) {
        if ((4 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 1;
        getInstance = i2 % 128;
        if (i2 % 2 == 0) {
            this.EncryptedParameter = str;
        } else {
            this.EncryptedParameter = str;
            int i3 = 34 / 0;
        }
    }

    public void SetFrom(java.lang.string str) {
        if ((13 + 6) % 6 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 39;
        getInstance = i2 % 128;
        if (i2 % 2 != 0) {
            this.From = str;
            throw null;
        }
        this.From = str;
    }

    public void SetParameterContainer(com.visa.vac.tc.emvconverter.model.TransactionCompletion$ParameterContainer transactionCompletion$ParameterContainer) {
        if ((21 + 19) % 19 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 37;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        this.parameterContainer = transactionCompletion$ParameterContainer;
        int i5 = i2 + 65;
        BuildConfig = i5 % 128;
        if (i5 % 2 == 0) {
            DLQQkUKduDgOMDim(null);
            throw null;
        }
    }

    public void SetTo(java.lang.string str) {
        if ((23 + 20) % 20 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig;
        int i3 = i2 + 83;
        getInstance = i3 % 128;
        if (i3 % 2 != 0) {
            this.To = str;
            throw null;
        }
        this.To = str;
        int i4 = i2 + 107;
        getInstance = i4 % 128;
        if (i4 % 2 != 0) {
            sHLpBheHeZSOpStc(null);
            throw null;
        }
    }
}

