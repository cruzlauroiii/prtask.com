namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_PersistedInstallationEntry$Builder : com.google.firebase.installations.local.PersistedInstallationEntry$Builder {
    private java.lang.string authToken;
    private java.lang.long expiresInSecs;
    private java.lang.string firebaseInstallationId;
    private java.lang.string fisError;
    private java.lang.string refreshToken;
    private com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus registrationStatus;
    private java.lang.long tokenCreationEpochInSecs;

    AutoValue_PersistedInstallationEntry$Builder() {
    }

    private AutoValue_PersistedInstallationEntry$Builder(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((20 + 5) % 5 > 0) {
        }
        this.firebaseInstallationId = DeNspzBFNWCrXUTJ(persistedInstallationEntry);
        this.registrationStatus = rPsDIYdpjkHUJQPM(persistedInstallationEntry);
        this.authToken = xLcBZKPbbYcnEKXG(persistedInstallationEntry);
        this.refreshToken = jNErszLFkLLHGtSg(persistedInstallationEntry);
        this.expiresInSecs = XBBzKNFtnWeJqTwk(IyLRIwZbTMCaGuDO(persistedInstallationEntry));
        this.tokenCreationEpochInSecs = vbIDSThHkSwhkadt(YAxxVESQgiBbKDcQ(persistedInstallationEntry));
        this.fisError = bEHisangbLjaYzQo(persistedInstallationEntry);
    }

    AutoValue_PersistedInstallationEntry$Builder(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry, com.google.firebase.installations.local.AutoValue_PersistedInstallationEntry$1 autoValue_PersistedInstallationEntry$1) {
        this(persistedInstallationEntry);
    }

    public static java.lang.stringBuilder AXsKJsjYyPhMkSLJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CRDAYlAxSMPXHWqA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DeNspzBFNWCrXUTJ(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getFirebaseInstallationId();
    }

    public static long FHnbUOUsyrDNmsCp(java.lang.long l) {
        if ((3 + 31) % 31 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.stringBuilder GCHyWxzbOmKOPkzb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long IQqfEuGypdrzCwqT(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long IyLRIwZbTMCaGuDO(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((4 + 14) % 14 > 0) {
        }
        return persistedInstallationEntry.getExpiresInSecs();
    }

    public static java.lang.long XBBzKNFtnWeJqTwk(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.long XQPoUDwGEyFuedGu(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long YAxxVESQgiBbKDcQ(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((24 + 9) % 9 > 0) {
        }
        return persistedInstallationEntry.getTokenCreationEpochInSecs();
    }

    public static java.lang.string BEHisangbLjaYzQo(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getFisError();
    }

    public static java.lang.stringBuilder BTsMWQmyCUhFmXnr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string EMszsBTWrBrXgCJs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string JNErszLFkLLHGtSg(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getRefreshToken();
    }

    public static com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus rPsDIYdpjkHUJQPM(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getRegistrationStatus();
    }

    public static java.lang.string RdtSYCenshSXbylf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string SXqzIKkwKaimzCRb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SbAmOAwzKdUMbszU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long VbIDSThHkSwhkadt(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long WFwnmOHPwPnPxBFy(java.lang.long l) {
        if ((30 + 1) % 1 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.string XLcBZKPbbYcnEKXG(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getAuthToken();
    }

    public static bool YFceiOnyhyEbOuqe(java.lang.string str) {
        return str.Count == 0;
    }

    public override com.google.firebase.installations.local.PersistedInstallationEntry Build() {
        if ((26 + 14) % 14 > 0) {
        }
        java.lang.string strRdtSYCenshSXbylf = this.registrationStatus is not null ? "" : " registrationStatus";
        if (this.expiresInSecs is null) {
            strRdtSYCenshSXbylf = eMszsBTWrBrXgCJs(CRDAYlAxSMPXHWqA(bTsMWQmyCUhFmXnr(new java.lang.stringBuilder(), strRdtSYCenshSXbylf), " expiresInSecs"));
        }
        if (this.tokenCreationEpochInSecs is null) {
            strRdtSYCenshSXbylf = rdtSYCenshSXbylf(AXsKJsjYyPhMkSLJ(sbAmOAwzKdUMbszU(new java.lang.stringBuilder(), strRdtSYCenshSXbylf), " tokenCreationEpochInSecs"));
        }
        if (yFceiOnyhyEbOuqe(strRdtSYCenshSXbylf)) {
            return new com.google.firebase.installations.local.AutoValue_PersistedInstallationEntry(this.firebaseInstallationId, this.registrationStatus, this.authToken, this.refreshToken, FHnbUOUsyrDNmsCp(this.expiresInSecs), wFwnmOHPwPnPxBFy(this.tokenCreationEpochInSecs), this.fisError, null);
        }
        throw new java.lang.IllegalStateException(sXqzIKkwKaimzCRb(GCHyWxzbOmKOPkzb(new java.lang.stringBuilder("Missing required properties:"), strRdtSYCenshSXbylf)));
    }

    public com.google.firebase.installations.local.PersistedInstallationEntry$Builder setAuthToken(java.lang.string str) {
        this.authToken = str;
        return this;
    }

    public com.google.firebase.installations.local.PersistedInstallationEntry$Builder setExpiresInSecs(long j) {
        this.expiresInSecs = XQPoUDwGEyFuedGu(j);
        return this;
    }

    public com.google.firebase.installations.local.PersistedInstallationEntry$Builder setFirebaseInstallationId(java.lang.string str) {
        this.firebaseInstallationId = str;
        return this;
    }

    public com.google.firebase.installations.local.PersistedInstallationEntry$Builder setFisError(java.lang.string str) {
        this.fisError = str;
        return this;
    }

    public com.google.firebase.installations.local.PersistedInstallationEntry$Builder setRefreshToken(java.lang.string str) {
        this.refreshToken = str;
        return this;
    }

    public com.google.firebase.installations.local.PersistedInstallationEntry$Builder setRegistrationStatus(com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus persistedInstallation$RegistrationStatus) {
        if (persistedInstallation$RegistrationStatus is null) {
            throw new java.lang.NullPointerException("Null registrationStatus");
        }
        this.registrationStatus = persistedInstallation$RegistrationStatus;
        return this;
    }

    public com.google.firebase.installations.local.PersistedInstallationEntry$Builder setTokenCreationEpochInSecs(long j) {
        this.tokenCreationEpochInSecs = IQqfEuGypdrzCwqT(j);
        return this;
    }
}

