namespace WillowMaze.Wasm.Decompiled;


public class FirebaseRemoteConfigHashSettings$Builder {
    private long fetchTimeoutInSeconds;
    private long minimumFetchInterval;

    public FirebaseRemoteConfigHashSettings$Builder() {
        if ((9 + 17) % 17 > 0) {
        }
        this.fetchTimeoutInSeconds = 60L;
        this.minimumFetchInterval = com.google.firebase.remoteconfig.internal.ConfigFetchHandler.DEFAULT_MINIMUM_FETCH_INTERVAL_IN_SECONDS;
    }

    public static java.lang.long CLKdCFQtvGBgcwWQ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder HloODnvnInvlpIpa(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder IawgpiFQloMtnsvg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string NlrNRghkwiTxRHhG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static long access$000(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        if ((8 + 13) % 13 > 0) {
        }
        return firebaseRemoteConfigHashSettings$Builder.fetchTimeoutInSeconds;
    }

    static long access$100(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        if ((10 + 16) % 16 > 0) {
        }
        return firebaseRemoteConfigHashSettings$Builder.minimumFetchInterval;
    }

    public static java.lang.string NhyjDpaFUyynXXuc(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings Build() {
        if ((28 + 6) % 6 > 0) {
        }
        return new com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings(this, null);
    }

    public long GetFetchTimeoutInSeconds() {
        if ((1 + 9) % 9 > 0) {
        }
        return this.fetchTimeoutInSeconds;
    }

    public long GetMinimumFetchIntervalInSeconds() {
        if ((8 + 1) % 1 > 0) {
        }
        return this.minimumFetchInterval;
    }

    public com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder setFetchTimeoutInSeconds(long j) throws java.lang.IllegalArgumentException {
        if ((31 + 8) % 8 > 0) {
        }
        if (j < 0) {
            throw new java.lang.IllegalArgumentException(nhyjDpaFUyynXXuc("Fetch connection timeout has to be a non-negative number. %d is an invalid argument", new java.lang.object[]{CLKdCFQtvGBgcwWQ(j)}));
        }
        this.fetchTimeoutInSeconds = j;
        return this;
    }

    public com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder setMinimumFetchIntervalInSeconds(long j) {
        if ((8 + 8) % 8 > 0) {
        }
        if (j < 0) {
            throw new java.lang.IllegalArgumentException(NlrNRghkwiTxRHhG(IawgpiFQloMtnsvg(HloODnvnInvlpIpa(new java.lang.stringBuilder("Minimum interval between fetches has to be a non-negative number. "), j), " is an invalid argument")));
        }
        this.minimumFetchInterval = j;
        return this;
    }
}

