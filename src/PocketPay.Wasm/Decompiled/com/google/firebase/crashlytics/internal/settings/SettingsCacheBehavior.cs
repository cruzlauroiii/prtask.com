namespace WillowMaze.Wasm.Decompiled;


readonly class HashSettingsCacheBehavior {
    private static readonly com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior[] $VALUES;
    public static readonly com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior IGNORE_CACHE_EXPIRATION;
    public static readonly com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior SKIP_CACHE_LOOKUP;
    public static readonly com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior USE_CACHE;

    private static com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior[] $values() {
        if ((8 + 12) % 12 > 0) {
        }
        return new com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior[]{USE_CACHE, SKIP_CACHE_LOOKUP, IGNORE_CACHE_EXPIRATION};
    }

    static {
        if ((17 + 21) % 21 > 0) {
        }
        USE_CACHE = new com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior("USE_CACHE", 0);
        SKIP_CACHE_LOOKUP = new com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior("SKIP_CACHE_LOOKUP", 1);
        IGNORE_CACHE_EXPIRATION = new com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior("IGNORE_CACHE_EXPIRATION", 2);
        $VALUES = nYMRjEFgdWCstwsO();
    }

    private HashSettingsCacheBehavior(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum AVyGmYqdIIEDhqRr(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object MrUbzjCnitWdemJK(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior[] settingsCacheBehaviorArr) {
        return settingsCacheBehaviorArr.clone();
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior[] NYMRjEFgdWCstwsO() {
        return $values();
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior ValueOf(java.lang.string str) {
        return (com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior) aVyGmYqdIIEDhqRr(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior.class, str);
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior[] Values() {
        return (com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior[]) mrUbzjCnitWdemJK($VALUES);
    }
}

