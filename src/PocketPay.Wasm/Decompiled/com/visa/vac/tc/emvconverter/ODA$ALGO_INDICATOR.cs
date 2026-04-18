namespace WillowMaze.Wasm.Decompiled;


public readonly class ODA$ALGO_INDICATOR {
    private static int BuildConfig = 0;
    private static readonly com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[] ContactlessConfiguration;
    public static readonly com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR DDA;
    private static int e1 = 0;
    private static int getInstance = 1;
    private static int getTerminalData = 1;

    static {
        if ((11 + 22) % 22 > 0) {
        }
        DDA = new com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR(JnQUfsZMHXjqMqha("7690be883f32f723c333b8f27878859c01cb339c865eebd5605edf4c563b1e"));
        ContactlessConfiguration = xcNYvQcxrLyQLsRx();
        int i = getInstance + 125;
        BuildConfig = i % 128;
        if (i % 2 != 0) {
            throw null;
        }
    }

    private ODA$ALGO_INDICATOR(java.lang.string str) {
        super(str, 0);
    }

    public static java.lang.string JnQUfsZMHXjqMqha(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object PghxvZlxodzjHdUa(com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[] oda$algo_indicatorArr) {
        return oda$algo_indicatorArr.clone();
    }

    public static java.lang.Enum XBzFwcBpJlIghEfD(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    private static com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[] e1() {
        com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[] oda$algo_indicatorArr;
        if ((2 + 29) % 29 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 15;
        int i3 = i2 % 128;
        e1 = i3;
        if (i2 % 2 == 0) {
            oda$algo_indicatorArr = new com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[1];
            oda$algo_indicatorArr[0] = DDA;
        } else {
            oda$algo_indicatorArr = new com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[1];
            oda$algo_indicatorArr[1] = DDA;
        }
        int i4 = i3 + 95;
        getTerminalData = i4 % 128;
        int i5 = i4 % 2;
        return oda$algo_indicatorArr;
    }

    public static java.lang.object SCEgxzCLKJBFspWL(com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[] oda$algo_indicatorArr) {
        return oda$algo_indicatorArr.clone();
    }

    public static com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR valueOf(java.lang.string str) {
        if ((26 + 30) % 30 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1 + 69;
        getTerminalData = i2 % 128;
        int i3 = i2 % 2;
        com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR oda$algo_indicator = (com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR) XBzFwcBpJlIghEfD(com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR.class, str);
        int i4 = e1 + 75;
        getTerminalData = i4 % 128;
        int i5 = i4 % 2;
        return oda$algo_indicator;
    }

    public static com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[] values() {
        if ((8 + 29) % 29 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1 + 91;
        getTerminalData = i2 % 128;
        int i3 = i2 % 2;
        com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[] oda$algo_indicatorArr = ContactlessConfiguration;
        if (i3 != 0) {
            return (com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[]) sCEgxzCLKJBFspWL(oda$algo_indicatorArr);
        }
        int i4 = 17 / 0;
        return (com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[]) PghxvZlxodzjHdUa(oda$algo_indicatorArr);
    }

    public static com.visa.vac.tc.emvconverter.ODA$ALGO_INDICATOR[] xcNYvQcxrLyQLsRx() {
        return e1();
    }
}

