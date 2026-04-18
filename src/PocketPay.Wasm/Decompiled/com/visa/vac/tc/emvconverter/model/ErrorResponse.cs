namespace WillowMaze.Wasm.Decompiled;


public class ErrorResponse {
    private static int BuildConfig = 1;
    private static int getInstance;
    private java.util.List<com.visa.vac.tc.emvconverter.model.ErrorResponse$ErrorResponseDetail> details;
    private java.lang.string message;
    private java.lang.string reason;
    private int status;

    public static int UrPPnbGNEAnIjjfe(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void UrPPnbGNEAnIjjfe(java.lang.object obj, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UrPPnbGNEAnIjjfe(java.lang.object obj, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UrPPnbGNEAnIjjfe(java.lang.object obj, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public java.util.List<com.visa.vac.tc.emvconverter.model.ErrorResponse$ErrorResponseDetail> getDetails() {
        if ((18 + 11) % 11 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 119;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        java.util.List<com.visa.vac.tc.emvconverter.model.ErrorResponse$ErrorResponseDetail> list = this.details;
        int i5 = i3 + 95;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
        return list;
    }

    public java.lang.string GetMessage() {
        if ((16 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig;
        int i3 = i2 + 79;
        getInstance = i3 % 128;
        if (i3 % 2 != 0) {
            throw null;
        }
        java.lang.string str = this.message;
        int i4 = i2 + 111;
        getInstance = i4 % 128;
        int i5 = i4 % 2;
        return str;
    }

    public java.lang.string GetReason() {
        if ((17 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 101;
        BuildConfig = i2 % 128;
        if (i2 % 2 != 0) {
            return this.reason;
        }
        UrPPnbGNEAnIjjfe(null);
        throw null;
    }

    public int GetStatus() {
        if ((2 + 32) % 32 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 111;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        int i5 = this.status;
        if (i4 == 0) {
            int i6 = 66 / 0;
        }
        int i7 = i2 + 61;
        BuildConfig = i7 % 128;
        if (i7 % 2 == 0) {
            throw null;
        }
        return i5;
    }

    public void SetDetails(java.util.List<com.visa.vac.tc.emvconverter.model.ErrorResponse$ErrorResponseDetail> list) {
        if ((18 + 11) % 11 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 117;
        getInstance = i2 % 128;
        if (i2 % 2 == 0) {
            this.details = list;
        } else {
            this.details = list;
            int i3 = 0 / 0;
        }
    }

    public void SetMessage(java.lang.string str) {
        if ((4 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 15;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        this.message = str;
        int i5 = i3 + 17;
        BuildConfig = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
    }

    public void SetResponse(java.lang.string str) {
        if ((10 + 15) % 15 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 81;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        this.reason = str;
        int i5 = i3 + 115;
        getInstance = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
    }

    public void SetStatus(int i) {
        if ((30 + 2) % 2 > 0) {
        }
        int i2 = 2 % 2;
        int i3 = BuildConfig;
        int i4 = i3 + 57;
        getInstance = i4 % 128;
        if (i4 % 2 == 0) {
            this.status = i;
        } else {
            this.status = i;
            int i5 = 63 / 0;
        }
        int i6 = i3 + 57;
        getInstance = i6 % 128;
        if (i6 % 2 != 0) {
            throw null;
        }
    }
}

