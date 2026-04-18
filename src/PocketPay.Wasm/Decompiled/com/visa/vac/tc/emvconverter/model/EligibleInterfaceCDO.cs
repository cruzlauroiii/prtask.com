namespace WillowMaze.Wasm.Decompiled;


public class EligibleInterfaceCDO {
    private static int ContactlessConfiguration = 1;
    private static int getTerminalData;
    java.lang.string CEID;
    java.lang.string InterfaceID;

    public java.lang.string GetCEID() {
        if ((23 + 22) % 22 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 119;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.CEID;
        int i5 = i3 + 111;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public java.lang.string GetInterfaceID() {
        if ((22 + 8) % 8 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 27;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.InterfaceID;
        int i5 = i2 + 43;
        ContactlessConfiguration = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return str;
    }

    public void SetCEID(java.lang.string str) {
        if ((5 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 69;
        ContactlessConfiguration = i2 % 128;
        if (i2 % 2 != 0) {
            this.CEID = str;
        } else {
            this.CEID = str;
            int i3 = 27 / 0;
        }
    }

    public void SetInterfaceID(java.lang.string str) {
        if ((22 + 23) % 23 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 69;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        this.InterfaceID = str;
        int i5 = i2 + 113;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
    }
}

