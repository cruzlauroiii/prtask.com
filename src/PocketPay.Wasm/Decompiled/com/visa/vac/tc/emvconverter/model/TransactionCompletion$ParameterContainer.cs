namespace WillowMaze.Wasm.Decompiled;


public class TransactionCompletion$ParameterContainer {
    private static int BuildConfig = 1;
    private static int ContactlessConfiguration;

    @com.google.gson.annotations.SerializedName("emv.txp.tm.AdditionalPOIDataSecondGenContainer")
    java.lang.object additionalPOIDataSecondGenContainer;

    @com.google.gson.annotations.SerializedName("emv.txp.tm.TransactionCompletionSecondGenContainer")
    com.visa.vac.tc.emvconverter.Receipt receipt;
    readonly com.visa.vac.tc.emvconverter.model.TransactionCompletion this$0;

    @com.google.gson.annotations.SerializedName("emv.tx.tm.TransactionStatus")
    java.lang.string transactionStatus;

    public TransactionCompletion$ParameterContainer(com.visa.vac.tc.emvconverter.model.TransactionCompletion transactionCompletion) {
        this.this$0 = transactionCompletion;
    }

    public static java.lang.string BHFWmLfgxsLuDAhr(com.google.gson.Gson gson, java.lang.object obj) {
        return gson.toJson(obj);
    }

    public static void BHFWmLfgxsLuDAhr(com.google.gson.Gson gson, java.lang.object obj, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BHFWmLfgxsLuDAhr(com.google.gson.Gson gson, java.lang.object obj, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BHFWmLfgxsLuDAhr(com.google.gson.Gson gson, java.lang.object obj, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OrsioMTTwjtUtUDO(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void OrsioMTTwjtUtUDO(java.lang.object obj, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OrsioMTTwjtUtUDO(java.lang.object obj, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OrsioMTTwjtUtUDO(java.lang.object obj, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WPwLalFcaQDtwEmx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void WPwLalFcaQDtwEmx(java.lang.object obj, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WPwLalFcaQDtwEmx(java.lang.object obj, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WPwLalFcaQDtwEmx(java.lang.object obj, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public java.lang.object GetAdditionalPOIDataSecondGenContainer() {
        if ((13 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 79;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        int i4 = i2 % 2;
        java.lang.object obj = this.additionalPOIDataSecondGenContainer;
        int i5 = i3 + 59;
        BuildConfig = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return obj;
    }

    public com.visa.vac.tc.emvconverter.Receipt GetReceipt() {
        if ((27 + 19) % 19 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 39;
        BuildConfig = i2 % 128;
        int i3 = i2 % 2;
        com.visa.vac.tc.emvconverter.Receipt receipt = this.receipt;
        if (i3 == 0) {
            int i4 = 35 / 0;
        }
        return receipt;
    }

    public java.lang.string GetTransactionStatus() {
        if ((21 + 9) % 9 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 19;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.transactionStatus;
        int i5 = i2 + 107;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public void SetAdditionalPOIDataSecondGenContainer(java.lang.object obj) {
        if ((16 + 31) % 31 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 45;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        this.additionalPOIDataSecondGenContainer = obj;
        int i5 = i2 + 51;
        BuildConfig = i5 % 128;
        if (i5 % 2 == 0) {
            wPwLalFcaQDtwEmx(null);
            throw null;
        }
    }

    public void SetReceipt(com.visa.vac.tc.emvconverter.Receipt receipt) {
        if ((31 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 121;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        if (i2 % 2 == 0) {
            this.receipt = receipt;
        } else {
            this.receipt = receipt;
            int i4 = 76 / 0;
        }
        int i5 = i3 + 101;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetTransactionStatus(java.lang.string str) {
        if ((10 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 75;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        this.transactionStatus = str;
        int i5 = i2 + 59;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
    }

    public java.lang.string Tostring() {
        if ((6 + 15) % 15 > 0) {
        }
        int i = 2 % 2;
        java.lang.string strBHFWmLfgxsLuDAhr = bHFWmLfgxsLuDAhr(new com.google.gson.Gson(), this);
        int i2 = BuildConfig + 15;
        ContactlessConfiguration = i2 % 128;
        if (i2 % 2 == 0) {
            return strBHFWmLfgxsLuDAhr;
        }
        orsioMTTwjtUtUDO(null);
        throw null;
    }
}

