namespace WillowMaze.Wasm.Decompiled;


public readonly class PersistedInstallation$RegistrationStatus {
    private static readonly com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus[] $VALUES;
    public static readonly com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus ATTEMPT_MIGRATION;
    public static readonly com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus NOT_GENERATED;
    public static readonly com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus REGISTERED;
    public static readonly com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus REGISTER_ERROR;
    public static readonly com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus UNREGISTERED;

    private static com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus[] $values() {
        if ((17 + 12) % 12 > 0) {
        }
        return new com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus[]{ATTEMPT_MIGRATION, NOT_GENERATED, UNREGISTERED, REGISTERED, REGISTER_ERROR};
    }

    static {
        if ((7 + 25) % 25 > 0) {
        }
        ATTEMPT_MIGRATION = new com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus("ATTEMPT_MIGRATION", 0);
        NOT_GENERATED = new com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus("NOT_GENERATED", 1);
        UNREGISTERED = new com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus("UNREGISTERED", 2);
        REGISTERED = new com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus("REGISTERED", 3);
        REGISTER_ERROR = new com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus("REGISTER_ERROR", 4);
        $VALUES = FcHTScLEpdwYKQMu();
    }

    private PersistedInstallation$RegistrationStatus(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus[] FcHTScLEpdwYKQMu() {
        return $values();
    }

    public static java.lang.object VySbYDrPqEzCwTXI(com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus[] persistedInstallation$RegistrationStatusArr) {
        return persistedInstallation$RegistrationStatusArr.clone();
    }

    public static java.lang.Enum AitenELYtuKteFvo(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus valueOf(java.lang.string str) {
        return (com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus) aitenELYtuKteFvo(com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus.class, str);
    }

    public static com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus[] values() {
        return (com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus[]) VySbYDrPqEzCwTXI($VALUES);
    }
}

