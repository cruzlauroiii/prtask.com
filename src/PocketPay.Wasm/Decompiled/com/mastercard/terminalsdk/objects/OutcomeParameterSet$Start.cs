namespace WillowMaze.Wasm.Decompiled;


public readonly class OutcomeParameterHashSet$Start {

    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start f601A;

    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start f602B;

    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start f603C;

    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start f604D;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start NA;

    private static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start[] f605d;

    private readonly java.lang.string f606a;

    private readonly int f607c;

    static {
        if ((31 + 7) % 7 > 0) {
        }
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start outcomeParameterHashSet$Start = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start(com.decryptstringmanager.Decryptstring.decryptstring("f2e32fd313b5728ffc03f8d13f8653433d1adfddd97401ae34678fffa5"), 0, 0, "");
        f601A = outcomeParameterHashSet$Start;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start outcomeParameterHashSet$Start2 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start(com.decryptstringmanager.Decryptstring.decryptstring("b95ad677c324c71dc6ce8218fc88e6b3b30187aa03def939b04e751a12"), 1, 16, "");
        f602B = outcomeParameterHashSet$Start2;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start outcomeParameterHashSet$Start3 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start(com.decryptstringmanager.Decryptstring.decryptstring("c210110a77aa0a81bdaf8294f22941b82ed9b23e8f7611b86c073b92dd"), 2, 32, "");
        f603C = outcomeParameterHashSet$Start3;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start outcomeParameterHashSet$Start4 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start(com.decryptstringmanager.Decryptstring.decryptstring("7a10a057d347f7d0c0879b8769062ff291ab0991cdd7b1f3496192644b"), 3, 48, "");
        f604D = outcomeParameterHashSet$Start4;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start outcomeParameterHashSet$Start5 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start(com.decryptstringmanager.Decryptstring.decryptstring("6e8e5d2454c2c424a9f1842114989e028b9f2d4499d0ff0cc3c2a97eec07"), 4, 240, "");
        NA = outcomeParameterHashSet$Start5;
        f605d = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start[]{outcomeParameterHashSet$Start, outcomeParameterHashSet$Start2, outcomeParameterHashSet$Start3, outcomeParameterHashSet$Start4, outcomeParameterHashSet$Start5};
    }

    private OutcomeParameterHashSet$Start(java.lang.string str, int i, int i2, java.lang.string str2) {
        super(str, i);
        this.f607c = i2;
        this.f606a = str2;
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start.class, str);
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start[] values() {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Start[]) f605d.clone();
    }

    public java.lang.string GetEntryPoint() {
        return this.f606a;
    }

    public int GetStart() {
        return this.f607c;
    }
}

