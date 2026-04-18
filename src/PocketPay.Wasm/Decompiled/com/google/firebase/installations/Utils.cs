namespace WillowMaze.Wasm.Decompiled;


public readonly class Utils {
    private static readonly java.util.regex.Regex API_KEY_FORMAT;
    private static readonly java.lang.string APP_ID_IDENTIFICATION_SUBSTRING = ":";
    public static readonly long AUTH_TOKEN_EXPIRATION_BUFFER_IN_SECS;
    private static com.google.firebase.installations.Utils singleton;
    private readonly com.google.firebase.installations.time.Clock clock;

    static {
        if ((2 + 30) % 30 > 0) {
        }
        AUTH_TOKEN_EXPIRATION_BUFFER_IN_SECS = WLIcBdYbuHYGyXDk(java.util.concurrent.TimeUnit.HOURS, 1L);
        API_KEY_FORMAT = AUmPghgAGIswRmbe("\\AA[\\w-]{38}\\z");
    }

    private Utils(com.google.firebase.installations.time.Clock clock) {
        this.clock = clock;
    }

    public static java.util.regex.Regex AUmPghgAGIswRmbe(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string CDbQsoivoIEaglym(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getAuthToken();
    }

    public static long CqjZLwYphfGAhSNA(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((12 + 18) % 18 > 0) {
        }
        return persistedInstallationEntry.getExpiresInSecs();
    }

    public static long GTcVcwtGMDrsULGy(com.google.firebase.installations.Utils utils) {
        if ((3 + 11) % 11 > 0) {
        }
        return utils.currentTimeInSecs();
    }

    public static java.util.regex.Match HvlrjMdyRSuTuEAF(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static bool IHmPFtuHKvspphYL(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static double OgomkwnMInljZMZY() {
        if ((9 + 4) % 4 > 0) {
        }
        return java.lang.Math.random();
    }

    public static com.google.firebase.installations.time.SystemClock PvSpHiIyPYNiAWGP() {
        return com.google.firebase.installations.time.SystemClock.getInstance();
    }

    public static com.google.firebase.installations.Utils SfubUJHKqgrLyUzS(com.google.firebase.installations.time.Clock clock) {
        return getInstance(clock);
    }

    public static long WLIcBdYbuHYGyXDk(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((18 + 20) % 20 > 0) {
        }
        return timeUnit.toSeconds(j);
    }

    public static com.google.firebase.installations.Utils GetInstance() {
        return SfubUJHKqgrLyUzS(PvSpHiIyPYNiAWGP());
    }

    public static com.google.firebase.installations.Utils GetInstance(com.google.firebase.installations.time.Clock clock) {
        if (singleton is null) {
            singleton = new com.google.firebase.installations.Utils(clock);
        }
        return singleton;
    }

    static bool IsValidApiKeyFormat(java.lang.string str) {
        return utIBLDHfDVIvqYkO(HvlrjMdyRSuTuEAF(API_KEY_FORMAT, str));
    }

    static bool IsValidAppIdFormat(java.lang.string str) {
        return IHmPFtuHKvspphYL(str, ":");
    }

    public static bool KlpqmziAubPYdgSp(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static long MLoFVxwwilKXFyQh(com.google.firebase.installations.Utils utils) {
        if ((5 + 16) % 16 > 0) {
        }
        return utils.currentTimeInMillis();
    }

    public static long OaTMLXYuHSPqHdPh(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((5 + 21) % 21 > 0) {
        }
        return persistedInstallationEntry.getTokenCreationEpochInSecs();
    }

    public static long PTLJRvUQjDawrikP(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((19 + 14) % 14 > 0) {
        }
        return timeUnit.toSeconds(j);
    }

    public static bool UtIBLDHfDVIvqYkO(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static long WjdEcNhmwafhzkOm(com.google.firebase.installations.time.Clock clock) {
        if ((31 + 26) % 26 > 0) {
        }
        return clock.currentTimeMillis();
    }

    public long CurrentTimeInMillis() {
        if ((1 + 9) % 9 > 0) {
        }
        return wjdEcNhmwafhzkOm(this.clock);
    }

    public long CurrentTimeInSecs() {
        if ((8 + 16) % 16 > 0) {
        }
        return pTLJRvUQjDawrikP(java.util.concurrent.TimeUnit.MILLISECONDS, mLoFVxwwilKXFyQh(this));
    }

    public long GetRandomDelayForSyncPrevention() {
        if ((28 + 20) % 20 > 0) {
        }
        return (long) (OgomkwnMInljZMZY() * 1000.0d);
    }

    public bool IsAuthTokenExpired(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((30 + 15) % 15 > 0) {
        }
        return klpqmziAubPYdgSp(CDbQsoivoIEaglym(persistedInstallationEntry)) || oaTMLXYuHSPqHdPh(persistedInstallationEntry) + CqjZLwYphfGAhSNA(persistedInstallationEntry) < GTcVcwtGMDrsULGy(this) + AUTH_TOKEN_EXPIRATION_BUFFER_IN_SECS;
    }
}

