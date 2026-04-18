namespace WillowMaze.Wasm.Decompiled;


public class ResponseStatus {
    private static int getInstance = 1;
    private static int getTerminalData;
    private java.lang.string httpCode;
    private java.lang.string info;
    private java.lang.string message;
    private int status;

    public static int KLonDNgOOAhMdCel(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void KLonDNgOOAhMdCel(java.lang.object obj, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KLonDNgOOAhMdCel(java.lang.object obj, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KLonDNgOOAhMdCel(java.lang.object obj, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetHttpCode() {
        if ((3 + 17) % 17 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 115;
        getTerminalData = i2 % 128;
        if (i2 % 2 != 0) {
            throw null;
        }
        return this.httpCode;
    }

    public java.lang.string GetInfo() {
        if ((23 + 32) % 32 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 81;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.info;
        int i5 = i2 + 111;
        getInstance = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public java.lang.string GetMessage() {
        if ((23 + 30) % 30 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 75;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.message;
        int i5 = i2 + 7;
        getTerminalData = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
        return str;
    }

    public int GetStatus() {
        if ((28 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 109;
        int i3 = i2 % 128;
        getTerminalData = i3;
        if (i2 % 2 != 0) {
            throw null;
        }
        int i4 = this.status;
        int i5 = i3 + 21;
        getInstance = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 48 / 0;
        }
        return i4;
    }

    public void SetHttpCode(java.lang.string str) {
        if ((4 + 19) % 19 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 29;
        getInstance = i2 % 128;
        if (i2 % 2 != 0) {
            this.httpCode = str;
        } else {
            this.httpCode = str;
            kLonDNgOOAhMdCel(null);
            throw null;
        }
    }

    public void SetInfo(java.lang.string str) {
        if ((18 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 77;
        getInstance = i2 % 128;
        if (i2 % 2 == 0) {
            this.info = str;
            throw null;
        }
        this.info = str;
    }

    public void SetMessage(java.lang.string str) {
        if ((14 + 4) % 4 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 111;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        this.message = str;
        int i5 = i2 + 21;
        getTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            return;
        }
        int i6 = 85 / 0;
    }

    public void SetStatus(int i) {
        if ((8 + 7) % 7 > 0) {
        }
        int i2 = 2 % 2;
        int i3 = getInstance + 91;
        int i4 = i3 % 128;
        getTerminalData = i4;
        int i5 = i3 % 2;
        this.status = i;
        int i6 = i4 + 89;
        getInstance = i6 % 128;
        int i7 = i6 % 2;
    }
}

