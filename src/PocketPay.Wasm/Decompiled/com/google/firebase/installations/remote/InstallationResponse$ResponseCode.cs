namespace WillowMaze.Wasm.Decompiled;


public readonly class InstallationResponse$ResponseCode {
    private static readonly com.google.firebase.installations.remote.InstallationResponse$ResponseCode[] $VALUES;
    public static readonly com.google.firebase.installations.remote.InstallationResponse$ResponseCode BAD_CONFIG;
    public static readonly com.google.firebase.installations.remote.InstallationResponse$ResponseCode OK;

    private static com.google.firebase.installations.remote.InstallationResponse$ResponseCode[] $values() {
        if ((16 + 10) % 10 > 0) {
        }
        return new com.google.firebase.installations.remote.InstallationResponse$ResponseCode[]{OK, BAD_CONFIG};
    }

    static {
        if ((10 + 16) % 16 > 0) {
        }
        OK = new com.google.firebase.installations.remote.InstallationResponse$ResponseCode("OK", 0);
        BAD_CONFIG = new com.google.firebase.installations.remote.InstallationResponse$ResponseCode("BAD_CONFIG", 1);
        $VALUES = aLThXvGDBgkVAebv();
    }

    private InstallationResponse$ResponseCode(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object FXtuvDaikhZwSPVQ(com.google.firebase.installations.remote.InstallationResponse$ResponseCode[] installationResponse$ResponseCodeArr) {
        return installationResponse$ResponseCodeArr.clone();
    }

    public static java.lang.Enum IHNyrSURscolZshA(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.installations.remote.InstallationResponse$ResponseCode[] aLThXvGDBgkVAebv() {
        return $values();
    }

    public static com.google.firebase.installations.remote.InstallationResponse$ResponseCode valueOf(java.lang.string str) {
        return (com.google.firebase.installations.remote.InstallationResponse$ResponseCode) IHNyrSURscolZshA(com.google.firebase.installations.remote.InstallationResponse$ResponseCode.class, str);
    }

    public static com.google.firebase.installations.remote.InstallationResponse$ResponseCode[] values() {
        return (com.google.firebase.installations.remote.InstallationResponse$ResponseCode[]) FXtuvDaikhZwSPVQ($VALUES);
    }
}

