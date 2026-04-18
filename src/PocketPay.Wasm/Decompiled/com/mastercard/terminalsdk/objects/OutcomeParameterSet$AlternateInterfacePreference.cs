namespace WillowMaze.Wasm.Decompiled;


public readonly class OutcomeParameterHashSet$AlternateInterfacePreference {
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference NA;

    private static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference[] f592a;

    private readonly int f593b;

    private readonly java.lang.string f594e;

    static {
        if ((13 + 7) % 7 > 0) {
        }
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference outcomeParameterHashSet$AlternateInterfacePreference = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference(com.decryptstringmanager.Decryptstring.decryptstring("b2f3970933b23cc425a27242d94e396fa53dee8d063c49cede3e81e1ea10"), 0, 240, "");
        NA = outcomeParameterHashSet$AlternateInterfacePreference;
        f592a = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference[]{outcomeParameterHashSet$AlternateInterfacePreference};
    }

    private OutcomeParameterHashSet$AlternateInterfacePreference(java.lang.string str, int i, int i2, java.lang.string str2) {
        super(str, i);
        this.f593b = i2;
        this.f594e = str2;
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference.class, str);
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference[] values() {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$AlternateInterfacePreference[]) f592a.clone();
    }

    public int GetAlternateInterfacePreference() {
        return this.f593b;
    }
}

