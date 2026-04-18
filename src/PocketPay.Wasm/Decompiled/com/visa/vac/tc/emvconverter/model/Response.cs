namespace WillowMaze.Wasm.Decompiled;


public class Response {
    private static int BuildConfig = 0;
    private static int getTerminalData = 1;
    private java.lang.string error;
    private com.visa.vac.tc.emvconverter.model.ErrorResponse errorResponse;
    private java.lang.string error_description;
    private com.visa.vac.tc.emvconverter.model.ResponseStatus responseStatus;

    public static int UxstXrLjTvEnGbwb(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void UxstXrLjTvEnGbwb(java.lang.object obj, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UxstXrLjTvEnGbwb(java.lang.object obj, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UxstXrLjTvEnGbwb(java.lang.object obj, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetError() {
        if ((29 + 9) % 9 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 75;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.error;
        int i5 = i2 + 39;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public com.visa.vac.tc.emvconverter.model.ErrorResponse GetErrorResponse() {
        if ((6 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 15;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        com.visa.vac.tc.emvconverter.model.ErrorResponse errorResponse = this.errorResponse;
        int i5 = i2 + 121;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
        return errorResponse;
    }

    public java.lang.string GetErrorDescription() {
        if ((19 + 31) % 31 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 25;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.error_description;
        int i5 = i3 + 9;
        getTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 69 / 0;
        }
        return str;
    }

    public com.visa.vac.tc.emvconverter.model.ResponseStatus GetResponseStatus() {
        if ((26 + 8) % 8 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 79;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        com.visa.vac.tc.emvconverter.model.ResponseStatus responseStatus = this.responseStatus;
        if (i4 != 0) {
            int i5 = 19 / 0;
        }
        int i6 = i3 + 17;
        getTerminalData = i6 % 128;
        int i7 = i6 % 2;
        return responseStatus;
    }

    public void SetError(java.lang.string str) {
        if ((23 + 6) % 6 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 39;
        int i3 = i2 % 128;
        getTerminalData = i3;
        if (i2 % 2 == 0) {
            this.error = str;
            throw null;
        }
        this.error = str;
        int i4 = i3 + 17;
        BuildConfig = i4 % 128;
        if (i4 % 2 != 0) {
            UxstXrLjTvEnGbwb(null);
            throw null;
        }
    }

    public void SetErrorResponse(com.visa.vac.tc.emvconverter.model.ErrorResponse errorResponse) {
        if ((31 + 26) % 26 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 13;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        this.errorResponse = errorResponse;
        int i5 = i3 + 85;
        getTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
    }

    public void SetErrorDescription(java.lang.string str) {
        if ((20 + 11) % 11 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 55;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        this.error_description = str;
        int i5 = i3 + 23;
        getTerminalData = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 49 / 0;
    }

    public void SetResponseStatus(com.visa.vac.tc.emvconverter.model.ResponseStatus responseStatus) {
        if ((13 + 8) % 8 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 81;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        this.responseStatus = responseStatus;
        int i5 = i2 + 9;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
    }
}

