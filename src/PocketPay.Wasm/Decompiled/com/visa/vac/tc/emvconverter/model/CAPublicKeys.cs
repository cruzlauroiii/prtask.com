namespace WillowMaze.Wasm.Decompiled;


public class CAPublicKeys {
    private static int BuildConfig = 0;
    private static int getTerminalData = 1;
    java.lang.string exponent;
    java.lang.string index;
    java.lang.string modulus;
    java.lang.string psid;
    java.lang.string ridIndex;
    java.util.List serialNumberList;

    public java.lang.string GetExponent() {
        if ((5 + 6) % 6 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 119;
        int i3 = i2 % 128;
        getTerminalData = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.exponent;
        int i5 = i3 + 119;
        BuildConfig = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
        return str;
    }

    public java.lang.string GetIndex() {
        if ((28 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 107;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.index;
        int i5 = i2 + 85;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public java.lang.string GetModulus() {
        if ((18 + 8) % 8 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 5;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.modulus;
        int i5 = i2 + 7;
        BuildConfig = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
        return str;
    }

    public java.lang.string GetPsid() {
        if ((8 + 32) % 32 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 117;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.psid;
        int i5 = i2 + 125;
        BuildConfig = i5 % 128;
        if (i5 % 2 != 0) {
            int i6 = 6 / 0;
        }
        return str;
    }

    public java.lang.string GetRidIndex() {
        if ((8 + 24) % 24 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 5;
        BuildConfig = i2 % 128;
        if (i2 % 2 != 0) {
            throw null;
        }
        return this.ridIndex;
    }

    public java.util.List GetSerialNumberList() {
        if ((32 + 29) % 29 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 101;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        java.util.List arrayList = this.serialNumberList;
        int i5 = i2 + 1;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
        return arrayList;
    }

    public void SetExponent(java.lang.string str) {
        if ((19 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 55;
        int i3 = i2 % 128;
        BuildConfig = i3;
        if (i2 % 2 == 0) {
            this.exponent = str;
        } else {
            this.exponent = str;
            int i4 = 26 / 0;
        }
        int i5 = i3 + 79;
        getTerminalData = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 14 / 0;
    }

    public void SetModulus(java.lang.string str) {
        if ((4 + 3) % 3 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 101;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        this.modulus = str;
        int i5 = i3 + 13;
        getTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
    }

    public void SetRidIndex(java.lang.string str) {
        if ((12 + 24) % 24 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig;
        int i3 = i2 + 101;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        this.ridIndex = str;
        int i5 = i2 + 51;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetSerialNumberList(java.util.List arrayList) {
        if ((5 + 4) % 4 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 123;
        int i3 = i2 % 128;
        getTerminalData = i3;
        int i4 = i2 % 2;
        this.serialNumberList = arrayList;
        int i5 = i3 + 81;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
    }
}

