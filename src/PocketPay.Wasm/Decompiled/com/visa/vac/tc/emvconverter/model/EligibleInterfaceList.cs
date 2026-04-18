namespace WillowMaze.Wasm.Decompiled;


public class EligibleInterfaceList {
    private static int ContactlessConfiguration = 0;
    private static int getInstance = 1;
    java.util.List<com.visa.vac.tc.emvconverter.model.EligibleInterfaceCDO> EligibleInterfaceCDO;
    java.lang.string InterfaceID;
    java.lang.string SecureChannelRequirement;

    public java.util.List<com.visa.vac.tc.emvconverter.model.EligibleInterfaceCDO> GetEligibleInterfaceCDO() {
        if ((27 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 35;
        getInstance = i2 % 128;
        if (i2 % 2 == 0) {
            throw null;
        }
        return this.EligibleInterfaceCDO;
    }

    public java.lang.string GetInterfaceID() {
        if ((15 + 6) % 6 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 23;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.InterfaceID;
        int i5 = i2 + 73;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public java.lang.string GetSecureChannelRequirement() {
        if ((29 + 10) % 10 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 27;
        getInstance = i3 % 128;
        if (i3 % 2 == 0) {
            throw null;
        }
        java.lang.string str = this.SecureChannelRequirement;
        int i4 = i2 + 81;
        getInstance = i4 % 128;
        int i5 = i4 % 2;
        return str;
    }

    public void SetEligibleInterfaceCDO(java.util.List<com.visa.vac.tc.emvconverter.model.EligibleInterfaceCDO> arrayList) {
        if ((26 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 111;
        getInstance = i3 % 128;
        if (i3 % 2 != 0) {
            this.EligibleInterfaceCDO = arrayList;
        } else {
            this.EligibleInterfaceCDO = arrayList;
            int i4 = 33 / 0;
        }
        int i5 = i2 + 29;
        getInstance = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetInterfaceID(java.lang.string str) {
        if ((11 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 93;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        this.InterfaceID = str;
        int i5 = i2 + 29;
        getInstance = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetSecureChannelRequirement(java.lang.string str) {
        if ((2 + 15) % 15 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 111;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        this.SecureChannelRequirement = str;
        int i5 = i2 + 25;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
    }
}

