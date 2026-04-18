namespace WillowMaze.Wasm.Decompiled;


public readonly class TtpOutcome {
    private static readonly com.visa.app.ttpkernel.TtpOutcome[] $VALUES;
    public static readonly com.visa.app.ttpkernel.TtpOutcome ABORTED;
    public static readonly com.visa.app.ttpkernel.TtpOutcome COMPLETED;
    private static int ContactlessConfiguration = 1;
    public static readonly com.visa.app.ttpkernel.TtpOutcome DECLINED;
    public static readonly com.visa.app.ttpkernel.TtpOutcome SELECTAGAIN;
    public static readonly com.visa.app.ttpkernel.TtpOutcome TRYNEXT;
    private static int e1 = 0;
    private static int getInstance = 1;
    private static int getTerminalData;
    private readonly int outcome;

    private static com.visa.app.ttpkernel.TtpOutcome[] $values() {
        if ((25 + 21) % 21 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1 + 47;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        com.visa.app.ttpkernel.TtpOutcome[] ttpOutcomeArr = {COMPLETED, DECLINED, ABORTED, TRYNEXT, SELECTAGAIN};
        int i5 = i3 + 43;
        e1 = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
        return ttpOutcomeArr;
    }

    static {
        if ((29 + 15) % 15 > 0) {
        }
        COMPLETED = new com.visa.app.ttpkernel.TtpOutcome(QXeZmuQZbdbqBQxE("14b227d2fccb95088f150f43dbeeb4d6a1f33d04ac7985a1ed4df0e0fa679a908eed7e51bc"), 0, 0);
        DECLINED = new com.visa.app.ttpkernel.TtpOutcome(OrPTzYIVijoDeRdY("ffd80fae42e5dd996d88d55345f36f6c76fae09ff87ef37f7d1f72bbe177f355575e71b9"), 1, 1);
        ABORTED = new com.visa.app.ttpkernel.TtpOutcome(nTgsanbMyFOuyami("c885911d1462425936a4b2067c8aeb17e3e27a3b642f41420d5938f803857922a4469d"), 2, 2);
        TRYNEXT = new com.visa.app.ttpkernel.TtpOutcome(sNzZJHOyxNbQinQC("6245e5847067a174d41a3a4da7e287406ab0bd2888821c384fc2799680501ec9452579"), 3, 3);
        SELECTAGAIN = new com.visa.app.ttpkernel.TtpOutcome(TeBkiKjCSFCVSVPe("e80706e9fa9b49712d1fb59e0fc55e617579d6b5fc3d9933875ab3910ae9fc0aa15173a1daaae6"), 4, 4);
        $VALUES = LYEgyuioZJUyHDQq();
        int i = getTerminalData + 57;
        ContactlessConfiguration = i % 128;
        int i2 = i % 2;
    }

    private TtpOutcome(java.lang.string str, int i, int i2) {
        super(str, i);
        this.outcome = i2;
    }

    public static java.lang.object GyITJRbOcVzUEtfG(com.visa.app.ttpkernel.TtpOutcome[] ttpOutcomeArr) {
        return ttpOutcomeArr.clone();
    }

    public static com.visa.app.ttpkernel.TtpOutcome[] LYEgyuioZJUyHDQq() {
        return $values();
    }

    public static java.lang.string OrPTzYIVijoDeRdY(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string QXeZmuQZbdbqBQxE(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string TeBkiKjCSFCVSVPe(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string NTgsanbMyFOuyami(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string SNzZJHOyxNbQinQC(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static com.visa.app.ttpkernel.TtpOutcome ValueOf(java.lang.string str) {
        if ((32 + 22) % 22 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1 + 77;
        getInstance = i2 % 128;
        int i3 = i2 % 2;
        com.visa.app.ttpkernel.TtpOutcome ttpOutcome = (com.visa.app.ttpkernel.TtpOutcome) wcWvMFKXHhzclcVr(com.visa.app.ttpkernel.TtpOutcome.class, str);
        if (i3 == 0) {
            int i4 = 9 / 0;
        }
        int i5 = getInstance + 27;
        e1 = i5 % 128;
        int i6 = i5 % 2;
        return ttpOutcome;
    }

    public static com.visa.app.ttpkernel.TtpOutcome[] Values() {
        if ((8 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 119;
        e1 = i2 % 128;
        int i3 = i2 % 2;
        com.visa.app.ttpkernel.TtpOutcome[] ttpOutcomeArr = (com.visa.app.ttpkernel.TtpOutcome[]) GyITJRbOcVzUEtfG($VALUES);
        int i4 = getInstance + 81;
        e1 = i4 % 128;
        int i5 = i4 % 2;
        return ttpOutcomeArr;
    }

    public static java.lang.Enum WcWvMFKXHhzclcVr(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public readonly int GetValue() {
        if ((4 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1 + 15;
        int i3 = i2 % 128;
        getInstance = i3;
        if (i2 % 2 == 0) {
            throw null;
        }
        int i4 = this.outcome;
        int i5 = i3 + 19;
        e1 = i5 % 128;
        int i6 = i5 % 2;
        return i4;
    }
}

