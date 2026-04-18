namespace WillowMaze.Wasm.Decompiled;


public readonly class UserInterfaceData$ValueQualifier {
    public static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier AMOUNT;
    public static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier BALANCE;
    public static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier NONE;

    private static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier[] f665a;

    private int f666b;

    static {
        if ((15 + 20) % 20 > 0) {
        }
        com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier userInterfaceData$ValueQualifier = new com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier(com.decryptstringmanager.Decryptstring.decryptstring("1e6b6837a3746938eae4221baea248c1740543ff1856b770f459168ddfa1870a"), 0, 0);
        NONE = userInterfaceData$ValueQualifier;
        com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier userInterfaceData$ValueQualifier2 = new com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier(com.decryptstringmanager.Decryptstring.decryptstring("cb6768a9b795ada9e96d4eba29a880642b4cee0d4e7b27444d252d4d1f648d4b4fe2"), 1, 16);
        AMOUNT = userInterfaceData$ValueQualifier2;
        com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier userInterfaceData$ValueQualifier3 = new com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier(com.decryptstringmanager.Decryptstring.decryptstring("181dbfebc7d49ce7b1d05a4f024fe9519764527bea6529dd13694bde740322f3d244f5"), 2, 32);
        BALANCE = userInterfaceData$ValueQualifier3;
        f665a = new com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier[]{userInterfaceData$ValueQualifier, userInterfaceData$ValueQualifier2, userInterfaceData$ValueQualifier3};
    }

    private UserInterfaceData$ValueQualifier(java.lang.string str, int i, int i2) {
        super(str, i);
        this.f666b = i2;
    }

    public static com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier.class, str);
    }

    public static com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier[] values() {
        return (com.mastercard.terminalsdk.objects.UserInterfaceData$ValueQualifier[]) f665a.clone();
    }

    public int GetValueQualifier() {
        return this.f666b;
    }
}

