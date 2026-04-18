namespace WillowMaze.Wasm.Decompiled;


public readonly class OutcomeParameterHashSet$CVM {
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM CONFIRMATION_CODE_VERIFIED;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM NA;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM NO_CVM;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM OBTAIN_SIGNATURE;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM ONLINE_PIN;

    private static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM[] f595e;

    private readonly java.lang.string f596c;

    private readonly int f597d;

    static {
        if ((22 + 8) % 8 > 0) {
        }
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM outcomeParameterHashSet$CVM = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM(com.decryptstringmanager.Decryptstring.decryptstring("689324bce4d2e1dc2d7acb0fa1f28d9642c3756adfad0504b72d366709a5e8f23659"), 0, 0, "");
        NO_CVM = outcomeParameterHashSet$CVM;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM outcomeParameterHashSet$CVM2 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM(com.decryptstringmanager.Decryptstring.decryptstring("3e4847c7f1d1ae24cea3a9924f09463e89b05ac55ca227b03f2a00ba2611948ab6233d2cb66cd87aa73039db"), 1, 16, "");
        OBTAIN_SIGNATURE = outcomeParameterHashSet$CVM2;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM outcomeParameterHashSet$CVM3 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM(com.decryptstringmanager.Decryptstring.decryptstring("2122afac7f92fc58bfb5897664e9a727c14e381bcbd3b62ba5aa986fe5695ac78ad31d95b1b6"), 2, 32, "");
        ONLINE_PIN = outcomeParameterHashSet$CVM3;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM outcomeParameterHashSet$CVM4 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM(com.decryptstringmanager.Decryptstring.decryptstring("57e7dacefe17fb2a12690843aba77e4067c060f8353ebb4d772aaf50d26a9114ffdd2323fb7a5c3f6aa8d3c28ca11898317884300d27"), 3, 48, "");
        CONFIRMATION_CODE_VERIFIED = outcomeParameterHashSet$CVM4;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM outcomeParameterHashSet$CVM5 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM(com.decryptstringmanager.Decryptstring.decryptstring("5ee735660f8d4ce650087119efbef74e26a683aaed11e60dfb1c000c3468"), 4, 240, "");
        NA = outcomeParameterHashSet$CVM5;
        f595e = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM[]{outcomeParameterHashSet$CVM, outcomeParameterHashSet$CVM2, outcomeParameterHashSet$CVM3, outcomeParameterHashSet$CVM4, outcomeParameterHashSet$CVM5};
    }

    private OutcomeParameterHashSet$CVM(java.lang.string str, int i, int i2, java.lang.string str2) {
        super(str, i);
        this.f597d = i2;
        this.f596c = str2;
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM cvmCodeOf(byte b) {
        if ((9 + 13) % 13 > 0) {
        }
        for (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM outcomeParameterHashSet$CVM : values()) {
            if (b == outcomeParameterHashSet$CVM.getCVM()) {
                return outcomeParameterHashSet$CVM;
            }
        }
        return NA;
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM.class, str);
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM[] values() {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$CVM[]) f595e.clone();
    }

    public int GetCVM() {
        return this.f597d;
    }
}

