namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class Consoleger$AndroidConsoleger$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((22 + 2) % 2 > 0) {
        }
        int[] iArr = new int[oSNBpEioviohEwFd().length];
        try {
            iArr[JgxdKYOzAMpOQRVg(com.google.firebase.logger.Consoleger$Level.VERBOSE)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[DiFrfNSHYrZRSlgT(com.google.firebase.logger.Consoleger$Level.DEBUG)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[jbonNsAuVNHimYue(com.google.firebase.logger.Consoleger$Level.INFO)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            iArr[bpvsjUfRmbjtCwMj(com.google.firebase.logger.Consoleger$Level.WARN)] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            iArr[iOHZtvBURMVJCXuv(com.google.firebase.logger.Consoleger$Level.ERROR)] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }

    public static int DiFrfNSHYrZRSlgT(com.google.firebase.logger.Consoleger$Level logger$Level) {
        return logger$Level.ordinal();
    }

    public static int JgxdKYOzAMpOQRVg(com.google.firebase.logger.Consoleger$Level logger$Level) {
        return logger$Level.ordinal();
    }

    public static int BpvsjUfRmbjtCwMj(com.google.firebase.logger.Consoleger$Level logger$Level) {
        return logger$Level.ordinal();
    }

    public static int IOHZtvBURMVJCXuv(com.google.firebase.logger.Consoleger$Level logger$Level) {
        return logger$Level.ordinal();
    }

    public static int JbonNsAuVNHimYue(com.google.firebase.logger.Consoleger$Level logger$Level) {
        return logger$Level.ordinal();
    }

    public static com.google.firebase.logger.Consoleger$Level[] oSNBpEioviohEwFd() {
        return com.google.firebase.logger.Consoleger$Level.Values;
    }
}

