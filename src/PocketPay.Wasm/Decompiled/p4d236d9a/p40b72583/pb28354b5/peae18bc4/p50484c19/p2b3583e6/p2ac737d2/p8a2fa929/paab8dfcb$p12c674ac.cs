namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public class paab8dfcb$p12c674ac {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((32 + 14) % 14 > 0) {
        }
        int[] iArr = new int[PNLWmlpehFUmlBqE().length];
        try {
            iArr[PhBahDLugTsTOocd(com.mastercard.terminalsdk.emv.Tag$Format.ans)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[TNoIvEiBsWaTKSaK(com.mastercard.terminalsdk.emv.Tag$Format.ans15)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[sNwralFLlJmNtChK(com.mastercard.terminalsdk.emv.Tag$Format.an8)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }

    public static com.mastercard.terminalsdk.emv.Tag$Format[] PNLWmlpehFUmlBqE() {
        return com.mastercard.terminalsdk.emv.Tag$Format.Values;
    }

    public static int PhBahDLugTsTOocd(com.mastercard.terminalsdk.emv.Tag$Format tag$Format) {
        return tag$Format.ordinal();
    }

    public static int TNoIvEiBsWaTKSaK(com.mastercard.terminalsdk.emv.Tag$Format tag$Format) {
        return tag$Format.ordinal();
    }

    public static int SNwralFLlJmNtChK(com.mastercard.terminalsdk.emv.Tag$Format tag$Format) {
        return tag$Format.ordinal();
    }
}

