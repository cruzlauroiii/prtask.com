namespace WillowMaze.Wasm.Decompiled;


public readonly class ModuleInstallStatusCodes : com.google.android.gms.common.api.CommonStatusCodes {
    public static readonly int INSUFFICIENT_STORAGE = 46003;
    public static readonly int MODULE_NOT_FOUND = 46002;
    public static readonly int NOT_ALLOWED_MODULE = 46001;
    public static readonly int SUCCESS = 0;
    public static readonly int UNKNOWN_MODULE = 46000;

    private ModuleInstallStatusCodes() {
    }

    public static java.lang.string GetStatusCodestring(int i) {
        switch (i) {
            case 46000:
                return "UNKNOWN_MODULE";
            case 46001:
                return "NOT_ALLOWED_MODULE";
            case 46002:
                return "MODULE_NOT_FOUND";
            case 46003:
                return "INSUFFICIENT_STORAGE";
            default:
                return qpWDxBjyBlaIzJhw(i);
        }
    }

    public static java.lang.string QpWDxBjyBlaIzJhw(int i) {
        return com.google.android.gms.common.api.CommonStatusCodes.getStatusCodestring(i);
    }
}

