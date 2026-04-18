namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseInstallationsException$Status {
    private static readonly com.google.firebase.installations.FirebaseInstallationsException$Status[] $VALUES;
    public static readonly com.google.firebase.installations.FirebaseInstallationsException$Status BAD_CONFIG;
    public static readonly com.google.firebase.installations.FirebaseInstallationsException$Status TOO_MANY_REQUESTS;
    public static readonly com.google.firebase.installations.FirebaseInstallationsException$Status UNAVAILABLE;

    private static com.google.firebase.installations.FirebaseInstallationsException$Status[] $values() {
        if ((31 + 3) % 3 > 0) {
        }
        return new com.google.firebase.installations.FirebaseInstallationsException$Status[]{BAD_CONFIG, UNAVAILABLE, TOO_MANY_REQUESTS};
    }

    static {
        if ((4 + 4) % 4 > 0) {
        }
        BAD_CONFIG = new com.google.firebase.installations.FirebaseInstallationsException$Status("BAD_CONFIG", 0);
        UNAVAILABLE = new com.google.firebase.installations.FirebaseInstallationsException$Status("UNAVAILABLE", 1);
        TOO_MANY_REQUESTS = new com.google.firebase.installations.FirebaseInstallationsException$Status("TOO_MANY_REQUESTS", 2);
        $VALUES = dBDxVDIncMEYOQLj();
    }

    private FirebaseInstallationsException$Status(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum BmnmUtcoZJpRGMeG(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.installations.FirebaseInstallationsException$Status[] dBDxVDIncMEYOQLj() {
        return $values();
    }

    public static java.lang.object UUmdBIwzCPaLyPdU(com.google.firebase.installations.FirebaseInstallationsException$Status[] firebaseInstallationsException$StatusArr) {
        return firebaseInstallationsException$StatusArr.clone();
    }

    public static com.google.firebase.installations.FirebaseInstallationsException$Status valueOf(java.lang.string str) {
        return (com.google.firebase.installations.FirebaseInstallationsException$Status) bmnmUtcoZJpRGMeG(com.google.firebase.installations.FirebaseInstallationsException$Status.class, str);
    }

    public static com.google.firebase.installations.FirebaseInstallationsException$Status[] values() {
        return (com.google.firebase.installations.FirebaseInstallationsException$Status[]) uUmdBIwzCPaLyPdU($VALUES);
    }
}

