namespace WillowMaze.Wasm.Decompiled;


public class CvmToCaptureCDO {
    private static int ContactlessConfiguration = 1;
    private static int getTerminalData;
    java.lang.string DataDelivery;
    java.lang.string MethodID;
    java.lang.string TerminalInteraction;
    java.lang.string Validator;
    com.visa.vac.tc.emvconverter.model.SCDataToCVEDContainer scDataToCVEDContainer;

    public static int BEqXfFQgYrsAprAp(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void BEqXfFQgYrsAprAp(java.lang.object obj, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BEqXfFQgYrsAprAp(java.lang.object obj, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BEqXfFQgYrsAprAp(java.lang.object obj, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int PtwGmugiiIHQicZQ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void PtwGmugiiIHQicZQ(java.lang.object obj, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PtwGmugiiIHQicZQ(java.lang.object obj, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PtwGmugiiIHQicZQ(java.lang.object obj, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetDataDelivery() {
        if ((26 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 75;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.DataDelivery;
        if (i4 == 0) {
            int i5 = 38 / 0;
        }
        int i6 = i3 + 33;
        getTerminalData = i6 % 128;
        int i7 = i6 % 2;
        return str;
    }

    public java.lang.string GetMethodID() {
        if ((7 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 43;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.MethodID;
        int i5 = i2 + 95;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public com.visa.vac.tc.emvconverter.model.SCDataToCVEDContainer GetScDataToCVEDContainer() {
        if ((24 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 43;
        getTerminalData = i2 % 128;
        if (i2 % 2 != 0) {
            throw null;
        }
        return this.scDataToCVEDContainer;
    }

    public java.lang.string GetTerminalInteraction() {
        if ((27 + 7) % 7 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 99;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.TerminalInteraction;
        int i5 = i2 + 27;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public java.lang.string GetValidator() {
        if ((1 + 10) % 10 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 19;
        ContactlessConfiguration = i2 % 128;
        if (i2 % 2 == 0) {
            throw null;
        }
        return this.Validator;
    }

    public void SetDataDelivery(java.lang.string str) {
        if ((28 + 3) % 3 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 7;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        this.DataDelivery = str;
        int i5 = i2 + 45;
        ContactlessConfiguration = i5 % 128;
        if (i5 % 2 == 0) {
            BEqXfFQgYrsAprAp(null);
            throw null;
        }
    }

    public void SetMethodID(java.lang.string str) {
        if ((15 + 9) % 9 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 7;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        this.MethodID = str;
        int i5 = i2 + 103;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetScDataToCVEDContainer(com.visa.vac.tc.emvconverter.model.SCDataToCVEDContainer sCDataToCVEDContainer) {
        if ((30 + 5) % 5 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 13;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        int i4 = i2 % 2;
        this.scDataToCVEDContainer = sCDataToCVEDContainer;
        int i5 = i3 + 105;
        getTerminalData = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
    }

    public void SetTerminalInteraction(java.lang.string str) {
        if ((27 + 8) % 8 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 49;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        this.TerminalInteraction = str;
        int i5 = i2 + 123;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetValidator(java.lang.string str) {
        if ((28 + 17) % 17 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 123;
        ContactlessConfiguration = i3 % 128;
        if (i3 % 2 == 0) {
            this.Validator = str;
            ptwGmugiiIHQicZQ(null);
            throw null;
        }
        this.Validator = str;
        int i4 = i2 + 53;
        ContactlessConfiguration = i4 % 128;
        if (i4 % 2 == 0) {
            throw null;
        }
    }
}

