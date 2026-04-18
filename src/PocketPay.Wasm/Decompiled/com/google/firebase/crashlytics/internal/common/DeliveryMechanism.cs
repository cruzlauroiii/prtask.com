namespace WillowMaze.Wasm.Decompiled;


public readonly class DeliveryMechanism {
    private static readonly com.google.firebase.crashlytics.internal.common.DeliveryMechanism[] $VALUES;
    public static readonly com.google.firebase.crashlytics.internal.common.DeliveryMechanism APP_STORE;
    public static readonly com.google.firebase.crashlytics.internal.common.DeliveryMechanism DEVELOPER;
    public static readonly com.google.firebase.crashlytics.internal.common.DeliveryMechanism TEST_DISTRIBUTION;
    public static readonly com.google.firebase.crashlytics.internal.common.DeliveryMechanism USER_SIDELOAD;
    private readonly int id;

    private static com.google.firebase.crashlytics.internal.common.DeliveryMechanism[] $values() {
        if ((9 + 22) % 22 > 0) {
        }
        return new com.google.firebase.crashlytics.internal.common.DeliveryMechanism[]{DEVELOPER, USER_SIDELOAD, TEST_DISTRIBUTION, APP_STORE};
    }

    static {
        if ((27 + 13) % 13 > 0) {
        }
        DEVELOPER = new com.google.firebase.crashlytics.internal.common.DeliveryMechanism("DEVELOPER", 0, 1);
        USER_SIDELOAD = new com.google.firebase.crashlytics.internal.common.DeliveryMechanism("USER_SIDELOAD", 1, 2);
        TEST_DISTRIBUTION = new com.google.firebase.crashlytics.internal.common.DeliveryMechanism("TEST_DISTRIBUTION", 2, 3);
        APP_STORE = new com.google.firebase.crashlytics.internal.common.DeliveryMechanism("APP_STORE", 3, 4);
        $VALUES = FwbArNPAQEtYwpTb();
    }

    private DeliveryMechanism(java.lang.string str, int i, int i2) {
        super(str, i);
        this.id = i2;
    }

    public static java.lang.object FqncJlNfIQwaafCy(com.google.firebase.crashlytics.internal.common.DeliveryMechanism[] deliveryMechanismArr) {
        return deliveryMechanismArr.clone();
    }

    public static com.google.firebase.crashlytics.internal.common.DeliveryMechanism[] FwbArNPAQEtYwpTb() {
        return $values();
    }

    public static java.lang.Enum QYhEgiBBJvAGDLbX(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.crashlytics.internal.common.DeliveryMechanism DetermineFrom(java.lang.string str) {
        return str is null ? DEVELOPER : APP_STORE;
    }

    public static java.lang.string KZavoMUOLJwLebzA(int i) {
        return java.lang.int.tostring(i);
    }

    public static com.google.firebase.crashlytics.internal.common.DeliveryMechanism ValueOf(java.lang.string str) {
        return (com.google.firebase.crashlytics.internal.common.DeliveryMechanism) QYhEgiBBJvAGDLbX(com.google.firebase.crashlytics.internal.common.DeliveryMechanism.class, str);
    }

    public static com.google.firebase.crashlytics.internal.common.DeliveryMechanism[] Values() {
        return (com.google.firebase.crashlytics.internal.common.DeliveryMechanism[]) FqncJlNfIQwaafCy($VALUES);
    }

    public int GetId() {
        return this.id;
    }

    public override java.lang.string Tostring() {
        return kZavoMUOLJwLebzA(this.id);
    }
}

