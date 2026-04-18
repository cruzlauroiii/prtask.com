namespace WillowMaze.Wasm.Decompiled;


public class EmvTxSmPreProcessingList {
    private static int ContactlessConfiguration = 1;
    private static int getTerminalData;
    bool CardholderChoiceAvailable;
    java.lang.string CardholderChoiceOrder;
    java.lang.string InterfaceID;
    java.util.List<com.visa.vac.tc.emvconverter.model.SvIDCDO> SvIDList;

    public static int BqlscxKnPMRmAeUZ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void BqlscxKnPMRmAeUZ(java.lang.object obj, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BqlscxKnPMRmAeUZ(java.lang.object obj, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BqlscxKnPMRmAeUZ(java.lang.object obj, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int HaLaQdVebXtICwmI(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void HaLaQdVebXtICwmI(java.lang.object obj, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HaLaQdVebXtICwmI(java.lang.object obj, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HaLaQdVebXtICwmI(java.lang.object obj, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VXpxihGYqjsFgZby(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void VXpxihGYqjsFgZby(java.lang.object obj, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VXpxihGYqjsFgZby(java.lang.object obj, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VXpxihGYqjsFgZby(java.lang.object obj, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public bool GetCardholderChoiceAvailable() {
        if ((11 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 81;
        getTerminalData = i2 % 128;
        if (i2 % 2 == 0) {
            return this.CardholderChoiceAvailable;
        }
        BqlscxKnPMRmAeUZ(null);
        throw null;
    }

    public java.lang.string GetCardholderChoiceOrder() {
        if ((32 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 29;
        int i3 = i2 % 128;
        getTerminalData = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.CardholderChoiceOrder;
        if (i4 != 0) {
            int i5 = 77 / 0;
        }
        int i6 = i3 + 71;
        ContactlessConfiguration = i6 % 128;
        int i7 = i6 % 2;
        return str;
    }

    public java.lang.string GetInterfaceID() {
        if ((27 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 65;
        int i3 = i2 % 128;
        getTerminalData = i3;
        if (i2 % 2 != 0) {
            throw null;
        }
        java.lang.string str = this.InterfaceID;
        int i4 = i3 + 7;
        ContactlessConfiguration = i4 % 128;
        if (i4 % 2 != 0) {
            return str;
        }
        VXpxihGYqjsFgZby(null);
        throw null;
    }

    public java.util.List<com.visa.vac.tc.emvconverter.model.SvIDCDO> GetSvIDList() {
        if ((31 + 29) % 29 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 25;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        int i4 = i2 % 2;
        java.util.List<com.visa.vac.tc.emvconverter.model.SvIDCDO> arrayList = this.SvIDList;
        if (i4 == 0) {
            int i5 = 87 / 0;
        }
        int i6 = i3 + 1;
        getTerminalData = i6 % 128;
        int i7 = i6 % 2;
        return arrayList;
    }

    public void SetCardholderChoiceAvailable(bool z) {
        if ((14 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 39;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        this.CardholderChoiceAvailable = z;
        int i5 = i2 + 29;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetCardholderChoiceOrder(java.lang.string str) {
        if ((3 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 121;
        getTerminalData = i3 % 128;
        if (i3 % 2 != 0) {
            this.CardholderChoiceOrder = str;
            HaLaQdVebXtICwmI(null);
            throw null;
        }
        this.CardholderChoiceOrder = str;
        int i4 = i2 + 41;
        getTerminalData = i4 % 128;
        if (i4 % 2 != 0) {
            throw null;
        }
    }

    public void SetInterfaceID(java.lang.string str) {
        if ((1 + 17) % 17 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 67;
        int i3 = i2 % 128;
        getTerminalData = i3;
        int i4 = i2 % 2;
        this.InterfaceID = str;
        int i5 = i3 + 39;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetSvIDList(java.util.List<com.visa.vac.tc.emvconverter.model.SvIDCDO> arrayList) {
        if ((12 + 25) % 25 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 61;
        getTerminalData = i2 % 128;
        if (i2 % 2 == 0) {
            this.SvIDList = arrayList;
        } else {
            this.SvIDList = arrayList;
            int i3 = 90 / 0;
        }
    }
}

