namespace WillowMaze.Wasm.Decompiled;


public class Close {
    private static int ContactlessConfiguration = 1;
    private static int getInstance;
    java.lang.string EncryptedParameter;
    java.lang.string From;
    java.lang.string To;

    @com.google.gson.annotations.SerializedName("ParameterContainer")
    com.visa.vac.tc.emvconverter.model.Close$ParameterContainer parameterContainer;

    public static int BBdoJRfZmiGZVVpf(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void BBdoJRfZmiGZVVpf(java.lang.object obj, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BBdoJRfZmiGZVVpf(java.lang.object obj, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BBdoJRfZmiGZVVpf(java.lang.object obj, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GKRbclHzbtDPmjbx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void GKRbclHzbtDPmjbx(java.lang.object obj, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GKRbclHzbtDPmjbx(java.lang.object obj, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GKRbclHzbtDPmjbx(java.lang.object obj, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetEncryptedParameter() {
        if ((28 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 55;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.EncryptedParameter;
        int i5 = i2 + 37;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public java.lang.string GetFrom() {
        if ((11 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 15;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.From;
        int i5 = i2 + 17;
        ContactlessConfiguration = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 0 / 0;
        }
        return str;
    }

    public com.visa.vac.tc.emvconverter.model.Close$ParameterContainer getParameterContainer() {
        if ((7 + 10) % 10 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 101;
        getInstance = i2 % 128;
        int i3 = i2 % 2;
        com.visa.vac.tc.emvconverter.model.Close$ParameterContainer close$ParameterContainer = this.parameterContainer;
        if (i3 != 0) {
            int i4 = 20 / 0;
        }
        return close$ParameterContainer;
    }

    public java.lang.string GetTo() {
        if ((5 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 49;
        int i3 = i2 % 128;
        getInstance = i3;
        if (i2 % 2 != 0) {
            GKRbclHzbtDPmjbx(null);
            throw null;
        }
        java.lang.string str = this.To;
        int i4 = i3 + 79;
        ContactlessConfiguration = i4 % 128;
        if (i4 % 2 == 0) {
            throw null;
        }
        return str;
    }

    public void SetEncryptedParameter(java.lang.string str) {
        if ((25 + 10) % 10 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 53;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        this.EncryptedParameter = str;
        int i5 = i2 + 117;
        ContactlessConfiguration = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 70 / 0;
    }

    public void SetFrom(java.lang.string str) {
        if ((28 + 9) % 9 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 113;
        getInstance = i2 % 128;
        if (i2 % 2 != 0) {
            this.From = str;
            throw null;
        }
        this.From = str;
    }

    public void SetParameterContainer(com.visa.vac.tc.emvconverter.model.Close$ParameterContainer close$ParameterContainer) {
        if ((14 + 23) % 23 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 45;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        if (i2 % 2 == 0) {
            this.parameterContainer = close$ParameterContainer;
            BBdoJRfZmiGZVVpf(null);
            throw null;
        }
        this.parameterContainer = close$ParameterContainer;
        int i4 = i3 + 33;
        getInstance = i4 % 128;
        if (i4 % 2 != 0) {
            throw null;
        }
    }

    public void SetTo(java.lang.string str) {
        if ((2 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 101;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        this.To = str;
        int i5 = i2 + 29;
        getInstance = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
    }
}

