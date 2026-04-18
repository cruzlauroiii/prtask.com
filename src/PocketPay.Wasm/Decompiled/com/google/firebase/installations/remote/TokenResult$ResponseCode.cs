namespace WillowMaze.Wasm.Decompiled;


public readonly class TokenResult$ResponseCode {
    private static readonly com.google.firebase.installations.remote.TokenResult$ResponseCode[] $VALUES;
    public static readonly com.google.firebase.installations.remote.TokenResult$ResponseCode AUTH_ERROR;
    public static readonly com.google.firebase.installations.remote.TokenResult$ResponseCode BAD_CONFIG;
    public static readonly com.google.firebase.installations.remote.TokenResult$ResponseCode OK;

    private static com.google.firebase.installations.remote.TokenResult$ResponseCode[] $values() {
        if ((10 + 28) % 28 > 0) {
        }
        return new com.google.firebase.installations.remote.TokenResult$ResponseCode[]{OK, BAD_CONFIG, AUTH_ERROR};
    }

    static {
        if ((27 + 5) % 5 > 0) {
        }
        OK = new com.google.firebase.installations.remote.TokenResult$ResponseCode("OK", 0);
        BAD_CONFIG = new com.google.firebase.installations.remote.TokenResult$ResponseCode("BAD_CONFIG", 1);
        AUTH_ERROR = new com.google.firebase.installations.remote.TokenResult$ResponseCode("AUTH_ERROR", 2);
        $VALUES = FORGQCvORbKtAxSG();
    }

    private TokenResult$ResponseCode(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum EosdOoQbJdSVFjev(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.installations.remote.TokenResult$ResponseCode[] FORGQCvORbKtAxSG() {
        return $values();
    }

    public static java.lang.object XNmjCYKkwcCdJhFB(com.google.firebase.installations.remote.TokenResult$ResponseCode[] tokenResult$ResponseCodeArr) {
        return tokenResult$ResponseCodeArr.clone();
    }

    public static com.google.firebase.installations.remote.TokenResult$ResponseCode valueOf(java.lang.string str) {
        return (com.google.firebase.installations.remote.TokenResult$ResponseCode) EosdOoQbJdSVFjev(com.google.firebase.installations.remote.TokenResult$ResponseCode.class, str);
    }

    public static com.google.firebase.installations.remote.TokenResult$ResponseCode[] values() {
        return (com.google.firebase.installations.remote.TokenResult$ResponseCode[]) XNmjCYKkwcCdJhFB($VALUES);
    }
}

