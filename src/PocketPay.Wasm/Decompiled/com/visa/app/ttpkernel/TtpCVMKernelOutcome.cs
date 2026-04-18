namespace WillowMaze.Wasm.Decompiled;


public readonly class TtpCVMKernelOutcome {
    private static readonly com.visa.app.ttpkernel.TtpCVMKernelOutcome[] $VALUES;
    private static int BuildConfig = 0;
    public static readonly com.visa.app.ttpkernel.TtpCVMKernelOutcome CVM_DECLINED;
    public static readonly com.visa.app.ttpkernel.TtpCVMKernelOutcome CVM_NOT_REQUIRED;
    private static int ContactlessConfiguration = 1;
    public static readonly com.visa.app.ttpkernel.TtpCVMKernelOutcome ONLINE_PIN;
    public static readonly com.visa.app.ttpkernel.TtpCVMKernelOutcome SIGNATURE;
    private static int getInstance = 0;
    private static int getTerminalData = 1;
    private readonly byte outcome;

    private static com.visa.app.ttpkernel.TtpCVMKernelOutcome[] $values() {
        if ((27 + 20) % 20 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 15;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        com.visa.app.ttpkernel.TtpCVMKernelOutcome[] ttpCVMKernelOutcomeArr = {CVM_NOT_REQUIRED, SIGNATURE, ONLINE_PIN, CVM_DECLINED};
        int i5 = i3 + 75;
        getTerminalData = i5 % 128;
        if (i5 % 2 != 0) {
            return ttpCVMKernelOutcomeArr;
        }
        SnnLBBrCMPmJSENf(null);
        throw null;
    }

    static {
        if ((24 + 3) % 3 > 0) {
        }
        CVM_NOT_REQUIRED = new com.visa.app.ttpkernel.TtpCVMKernelOutcome(pCNDmLvPTHLkiHov("b225cda3dad36fb28f40af683c5662058e0ff8f36dfd0c74eb28dd02898ff11dd7333abac548a352dc4a70b2"), 0, 0);
        SIGNATURE = new com.visa.app.ttpkernel.TtpCVMKernelOutcome(ucKeOnovBtaygeKT("ce5ccc2956b61e620c1e5526942d3f7ac0b42acb82234a8be2ccd42709f4800ff08410f1ef"), 1, 1);
        ONLINE_PIN = new com.visa.app.ttpkernel.TtpCVMKernelOutcome(koiiAHwojKTWNlxg("5daaf885a89101f2fcfc628973519d10e43067edc8138669955e588a8ca7867e20a44a78b510"), 2, 2);
        CVM_DECLINED = new com.visa.app.ttpkernel.TtpCVMKernelOutcome(dXqLvhtmOeWbrCZv("811d0c29b900ea87211157ac27c0c9892b61166bbc43fb1392cd67a281ade43b6fa6bf2a8ba0ad93"), 3, 3);
        $VALUES = cqVITeQVUaygqQOK();
        int i = ContactlessConfiguration + 105;
        BuildConfig = i % 128;
        if (i % 2 != 0) {
            throw null;
        }
    }

    private TtpCVMKernelOutcome(java.lang.string str, int i, int i2) {
        super(str, i);
        this.outcome = (byte) i2;
    }

    public static int SnnLBBrCMPmJSENf(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.object UnLfCQxKLhjZDPea(com.visa.app.ttpkernel.TtpCVMKernelOutcome[] ttpCVMKernelOutcomeArr) {
        return ttpCVMKernelOutcomeArr.clone();
    }

    public static com.visa.app.ttpkernel.TtpCVMKernelOutcome[] CqVITeQVUaygqQOK() {
        return $values();
    }

    public static java.lang.string DXqLvhtmOeWbrCZv(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.Enum IQEnMcchPcXGZfHL(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string KoiiAHwojKTWNlxg(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string PCNDmLvPTHLkiHov(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string UcKeOnovBtaygeKT(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static com.visa.app.ttpkernel.TtpCVMKernelOutcome ValueOf(java.lang.string str) {
        if ((29 + 19) % 19 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 11;
        getTerminalData = i2 % 128;
        int i3 = i2 % 2;
        com.visa.app.ttpkernel.TtpCVMKernelOutcome ttpCVMKernelOutcome = (com.visa.app.ttpkernel.TtpCVMKernelOutcome) iQEnMcchPcXGZfHL(com.visa.app.ttpkernel.TtpCVMKernelOutcome.class, str);
        int i4 = getInstance + 119;
        getTerminalData = i4 % 128;
        if (i4 % 2 == 0) {
            int i5 = 41 / 0;
        }
        return ttpCVMKernelOutcome;
    }

    public static com.visa.app.ttpkernel.TtpCVMKernelOutcome[] Values() {
        if ((31 + 15) % 15 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 31;
        getInstance = i2 % 128;
        int i3 = i2 % 2;
        com.visa.app.ttpkernel.TtpCVMKernelOutcome[] ttpCVMKernelOutcomeArr = (com.visa.app.ttpkernel.TtpCVMKernelOutcome[]) UnLfCQxKLhjZDPea($VALUES);
        int i4 = getInstance + 89;
        getTerminalData = i4 % 128;
        int i5 = i4 % 2;
        return ttpCVMKernelOutcomeArr;
    }

    public readonly byte GetValue() {
        if ((32 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 93;
        getInstance = i2 % 128;
        int i3 = i2 % 2;
        byte b = this.outcome;
        if (i3 != 0) {
            int i4 = 36 / 0;
        }
        return b;
    }
}

