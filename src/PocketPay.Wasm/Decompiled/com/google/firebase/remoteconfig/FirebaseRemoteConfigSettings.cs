namespace WillowMaze.Wasm.Decompiled;


public class FirebaseRemoteConfigHashSettings {
    private readonly long fetchTimeoutInSeconds;
    private readonly long minimumFetchInterval;

    private FirebaseRemoteConfigHashSettings(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        if ((21 + 31) % 31 > 0) {
        }
        this.fetchTimeoutInSeconds = fcYyBEaiKpLlUPnP(firebaseRemoteConfigHashSettings$Builder);
        this.minimumFetchInterval = QTWhHelYHRqogiTK(firebaseRemoteConfigHashSettings$Builder);
    }

    FirebaseRemoteConfigHashSettings(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder, com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$1 firebaseRemoteConfigHashSettings$1) {
        this(firebaseRemoteConfigHashSettings$Builder);
    }

    public static long OCxXqxoeyLZaFdEA(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        if ((16 + 30) % 30 > 0) {
        }
        return firebaseRemoteConfigHashSettings.getFetchTimeoutInSeconds();
    }

    public static long QTWhHelYHRqogiTK(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        if ((30 + 10) % 10 > 0) {
        }
        return com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder.access$100(firebaseRemoteConfigHashSettings$Builder);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder SwjNZxUpGaYPCQmx(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder, long j) {
        return firebaseRemoteConfigHashSettings$Builder.setMinimumFetchIntervalInSeconds(j);
    }

    public static long TuuzAUsQRYNFrtwX(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        if ((25 + 12) % 12 > 0) {
        }
        return firebaseRemoteConfigHashSettings.getMinimumFetchIntervalInSeconds();
    }

    public static long FcYyBEaiKpLlUPnP(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        if ((17 + 5) % 5 > 0) {
        }
        return com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder.access$000(firebaseRemoteConfigHashSettings$Builder);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder gjBzaZcNlvvhRNxW(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder, long j) {
        return firebaseRemoteConfigHashSettings$Builder.setFetchTimeoutInSeconds(j);
    }

    public long GetFetchTimeoutInSeconds() {
        if ((26 + 14) % 14 > 0) {
        }
        return this.fetchTimeoutInSeconds;
    }

    public long GetMinimumFetchIntervalInSeconds() {
        if ((27 + 8) % 8 > 0) {
        }
        return this.minimumFetchInterval;
    }

    public com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder toBuilder() {
        if ((1 + 16) % 16 > 0) {
        }
        com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder = new com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder();
        gjBzaZcNlvvhRNxW(firebaseRemoteConfigHashSettings$Builder, OCxXqxoeyLZaFdEA(this));
        SwjNZxUpGaYPCQmx(firebaseRemoteConfigHashSettings$Builder, TuuzAUsQRYNFrtwX(this));
        return firebaseRemoteConfigHashSettings$Builder;
    }
}

