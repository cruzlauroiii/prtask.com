namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_InstallationTokenResult$Builder : com.google.firebase.installations.InstallationTokenResult$Builder {
    private java.lang.string token;
    private java.lang.long tokenCreationTimestamp;
    private java.lang.long tokenExpirationTimestamp;

    AutoValue_InstallationTokenResult$Builder() {
    }

    private AutoValue_InstallationTokenResult$Builder(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        if ((26 + 24) % 24 > 0) {
        }
        this.token = LrESXYVkRRBewQWU(installationTokenResult);
        this.tokenExpirationTimestamp = RafDHwezemeLaZjb(YmkTPgtRxCpAxyCq(installationTokenResult));
        this.tokenCreationTimestamp = uvBiaEFmXPizpbBj(MNEFKPUlFyyjdyDd(installationTokenResult));
    }

    AutoValue_InstallationTokenResult$Builder(com.google.firebase.installations.InstallationTokenResult installationTokenResult, com.google.firebase.installations.AutoValue_InstallationTokenResult$1 autoValue_InstallationTokenResult$1) {
        this(installationTokenResult);
    }

    public static java.lang.stringBuilder DlNmhfuGhoOcvxKu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FgOnAeeBWJQQbYZo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GgBjisIBfnWBtJav(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool HbHkHLRGAxLRWiKL(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.string LrESXYVkRRBewQWU(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        return installationTokenResult.getToken();
    }

    public static long MNEFKPUlFyyjdyDd(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        if ((15 + 16) % 16 > 0) {
        }
        return installationTokenResult.getTokenCreationTimestamp();
    }

    public static java.lang.long NbiPBYNZJGhCjFyA(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long OTBLTHaXudoyudbP(java.lang.long l) {
        if ((6 + 32) % 32 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.long RafDHwezemeLaZjb(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder SiLoiCDYCfHvlMXm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TFSMdotDszgstmeR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long YmkTPgtRxCpAxyCq(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        if ((8 + 1) % 1 > 0) {
        }
        return installationTokenResult.getTokenExpirationTimestamp();
    }

    public static java.lang.string AkMBHepMTRDgdGor(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.long GZAFlyAZOCBCRIOf(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder LFLZUilmDVlldnrk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MJksCxIUKpAfREdR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long PjQoemivvlqYeAEW(java.lang.long l) {
        if ((3 + 23) % 23 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.long UvBiaEFmXPizpbBj(long j) {
        return java.lang.long.valueOf(j);
    }

    public override com.google.firebase.installations.InstallationTokenResult Build() {
        if ((15 + 28) % 28 > 0) {
        }
        java.lang.string strMJksCxIUKpAfREdR = this.token is not null ? "" : " token";
        if (this.tokenExpirationTimestamp is null) {
            strMJksCxIUKpAfREdR = mJksCxIUKpAfREdR(SiLoiCDYCfHvlMXm(FgOnAeeBWJQQbYZo(new java.lang.stringBuilder(), strMJksCxIUKpAfREdR), " tokenExpirationTimestamp"));
        }
        if (this.tokenCreationTimestamp is null) {
            strMJksCxIUKpAfREdR = akMBHepMTRDgdGor(TFSMdotDszgstmeR(DlNmhfuGhoOcvxKu(new java.lang.stringBuilder(), strMJksCxIUKpAfREdR), " tokenCreationTimestamp"));
        }
        if (HbHkHLRGAxLRWiKL(strMJksCxIUKpAfREdR)) {
            return new com.google.firebase.installations.AutoValue_InstallationTokenResult(this.token, pjQoemivvlqYeAEW(this.tokenExpirationTimestamp), OTBLTHaXudoyudbP(this.tokenCreationTimestamp), null);
        }
        throw new java.lang.IllegalStateException(GgBjisIBfnWBtJav(lFLZUilmDVlldnrk(new java.lang.stringBuilder("Missing required properties:"), strMJksCxIUKpAfREdR)));
    }

    public com.google.firebase.installations.InstallationTokenResult$Builder setToken(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null token");
        }
        this.token = str;
        return this;
    }

    public com.google.firebase.installations.InstallationTokenResult$Builder setTokenCreationTimestamp(long j) {
        this.tokenCreationTimestamp = NbiPBYNZJGhCjFyA(j);
        return this;
    }

    public com.google.firebase.installations.InstallationTokenResult$Builder setTokenExpirationTimestamp(long j) {
        this.tokenExpirationTimestamp = gZAFlyAZOCBCRIOf(j);
        return this;
    }
}

