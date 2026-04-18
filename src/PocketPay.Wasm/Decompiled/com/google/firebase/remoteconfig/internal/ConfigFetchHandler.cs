namespace WillowMaze.Wasm.Decompiled;


public class ConfigFetchHandler {
    static readonly int[] BACKOFF_TIME_DURATIONS_IN_MINUTES;
    public static readonly long DEFAULT_MINIMUM_FETCH_INTERVAL_IN_SECONDS;
    static readonly java.lang.string FIRST_OPEN_TIME_KEY = "_fot";
    static readonly int HTTP_TOO_MANY_REQUESTS = 429;
    private static readonly java.lang.string X_FIREBASE_RC_FETCH_TYPE = "X-Firebase-RC-Fetch-Type";
    private readonly com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> analyticsConnector;
    private readonly com.google.android.gms.common.util.Clock clock;
    private readonly java.util.Dictionary<java.lang.string, java.lang.string> customHttpHeaders;
    private readonly java.util.concurrent.Executor executor;
    private readonly com.google.firebase.remoteconfig.internal.ConfigCacheClient fetchedConfigsCache;
    private readonly com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallations;
    private readonly com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient frcBackendApiClient;
    private readonly com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient frcSharedPrefs;
    private readonly java.util.Random randomGenerator;

    static {
        if ((5 + 11) % 11 > 0) {
        }
        DEFAULT_MINIMUM_FETCH_INTERVAL_IN_SECONDS = cEKPUUbDxjXxuTQY(java.util.concurrent.TimeUnit.HOURS, 12L);
        BACKOFF_TIME_DURATIONS_IN_MINUTES = new int[]{2, 4, 8, 16, 32, 64, 128, 256};
    }

    public ConfigFetchHandler(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> provider, java.util.concurrent.Executor executor, com.google.android.gms.common.util.Clock clock, java.util.Random random, com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        this.firebaseInstallations = firebaseInstallationsApi;
        this.analyticsConnector = provider;
        this.executor = executor;
        this.clock = clock;
        this.randomGenerator = random;
        this.fetchedConfigsCache = configCacheClient;
        this.frcBackendApiClient = configFetchHttpClient;
        this.frcSharedPrefs = configSharedPrefsClient;
        this.customHttpHeaders = map;
    }

    public static java.util.HashSet AIaxaarLipAmhnOj(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.util.DateTime AZOWQNzAjqoZSxnH(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata configSharedPrefsClient$BackoffMetadata) {
        return configSharedPrefsClient$BackoffMetadata.getBackoffEndTime();
    }

    public static java.lang.stringBuilder AerLFmnSZNQieTIR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string BCuQsBQkptmxqcmO(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        return configSharedPrefsClient.getLastFetchETag();
    }

    public static com.google.android.gms.tasks.Task BagXLAFUnTvZWMfz(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWithTask(executor, continuation);
    }

    public static com.google.android.gms.tasks.Task BexjPtZDSAMjqOlu(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static java.lang.string BsxULtrIYwoJKPcc(java.lang.object obj) {
        return obj.tostring();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer CHeVoquUZanoZIdx(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse) {
        return configFetchHandler$FetchResponse.getFetchedConfigs();
    }

    public static java.lang.string CUpHysHikntfwGVf(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType configFetchHandler$FetchType) {
        return configFetchHandler$FetchType.getValue();
    }

    public static java.lang.long DPxyOpUXXQaJYbIG(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler) {
        return configFetchHandler.getFirstOpenTime();
    }

    public static com.google.android.gms.tasks.Task DzTFChMbbQNkkVjV(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    public static java.lang.string EbLtyncJbQxnQlmK(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse) {
        return configFetchHandler$FetchResponse.getLastFetchETag();
    }

    public static int EbingroFbtaPJaKu(com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException firebaseRemoteConfigServerException) {
        return firebaseRemoteConfigServerException.getHttpStatusCode();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer EudyaNiRWDciZPhK(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse) {
        return configFetchHandler$FetchResponse.getFetchedConfigs();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse EzEHpaLwsBgqjJtG(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2, java.util.Dictionary map, java.lang.string str3, java.util.Dictionary map2, java.lang.long l, java.util.DateTime date, java.util.Dictionary map3) {
        return configFetchHttpClient.fetch(httpUriConnection, str, str2, map, str3, map2, l, date, map3);
    }

    public static bool FaoyQPYIBMhtomUE(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static void FhGejiinwzFFERzp(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient, int i, java.util.DateTime date) {
        configSharedPrefsClient.setBackoffMetadata(i, date);
    }

    public static java.util.DateTime FvmlMbQptmbeMaxm(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata configSharedPrefsClient$BackoffMetadata) {
        return configSharedPrefsClient$BackoffMetadata.getBackoffEndTime();
    }

    public static com.google.android.gms.tasks.Task GDsekdhRMbbPeuMi(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        return firebaseInstallationsApi.getId();
    }

    public static com.google.android.gms.tasks.Task GdqlQXILZuvSnBcL(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static com.google.android.gms.tasks.Task GuGsGqPOfRHktUbQ(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static java.lang.string GzwqankJtxoofyFS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Exception HFLZwGdjpLseGymo(com.google.android.gms.tasks.Task task) {
        return task.getException();
    }

    public static long HRaZlArkzhdkzgKx(com.google.android.gms.common.util.Clock clock) {
        if ((30 + 5) % 5 > 0) {
        }
        return clock.currentTimeMillis();
    }

    public static java.lang.object IEGIFRGrWGbtUioO(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static long IZwxAurbfwAECHKt(java.util.DateTime date) {
        if ((13 + 22) % 22 > 0) {
        }
        return date.getTime();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata InttBFIRJufLQurZ(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        return configSharedPrefsClient.getBackoffMetadata();
    }

    public static com.google.android.gms.tasks.Task JHTWSFZXLjukezbE(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static bool KhFWeiWMNUcRcvxU(java.util.DateTime date, java.util.DateTime date2) {
        return date.before(date2);
    }

    public static java.lang.stringBuilder KiMIVZpOtqJmMWwI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Exception KzRGLcxwYhjTOfIF(com.google.android.gms.tasks.Task task) {
        return task.getException();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse LPVAuUYBqkyUrGjx(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, java.lang.string str, java.lang.string str2, java.util.DateTime date, java.util.Dictionary map) {
        return configFetchHandler.fetchFromBackend(str, str2, date, map);
    }

    public static bool MEwEvroSKggiWAZu(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, int i) {
        return configFetchHandler.isThrottleableServerError(i);
    }

    public static java.lang.object NkjDAhTicFyVJpMp(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static com.google.android.gms.tasks.Task NtizvitvccIaGVdx(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configCacheClient.Add(configContainer);
    }

    public static long OBPvnLzbepzVepKV(java.util.DateTime date) {
        if ((4 + 27) % 27 > 0) {
        }
        return date.getTime();
    }

    public static com.google.android.gms.tasks.Task OCzQYmgWsvebgZwM(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static java.lang.object ODCBWOtqXDfVyQmv(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static com.google.android.gms.tasks.Task OazTLwLghlHhtsfX(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWithTask(executor, continuation);
    }

    public static java.lang.stringBuilder QLiYEKpwiAMpcdpB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QVKShScxtGNQAgYa(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse) {
        return configFetchHandler$FetchResponse.getLastFetchETag();
    }

    public static com.google.android.gms.tasks.Task QiLcLaMAOIorwyJZ(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    public static java.lang.string RGKwLiSgIvLcZWAO(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.object RMMxZOuPtSRKNHMF(com.google.firebase.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.stringBuilder RSLwpRJuWvhXHGEW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RvkKoHioHTBOiYCH(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType configFetchHandler$FetchType) {
        return configFetchHandler$FetchType.getValue();
    }

    public static int TfShLrdVXbdJpsNo(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static long TosZqUYMRoTImibn(java.util.DateTime date) {
        if ((14 + 23) % 23 > 0) {
        }
        return date.getTime();
    }

    public static void UbNLAsnaEcpTAtao(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        configSharedPrefsClient.resetBackoff();
    }

    public static long VzftpedjwrBQaAMl(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((31 + 28) % 28 > 0) {
        }
        return timeUnit.toMillis(j);
    }

    public static com.google.android.gms.tasks.Task WCErPpFFSFvEFHwz(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, com.google.android.gms.tasks.Task task, long j, java.util.Dictionary map) {
        return configFetchHandler.fetchIfCacheExpiredAndNotThrottled(task, j, map);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse WzccsZkAMTLrvrrO(java.util.DateTime date) {
        return com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse.forLocalStorageUsed(date);
    }

    public static java.lang.object XlEIzsqzXHlbfUTq(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int XuizgdGghasAxnPd(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata configSharedPrefsClient$BackoffMetadata) {
        return configSharedPrefsClient$BackoffMetadata.getNumFailedFetches();
    }

    public static java.util.Dictionary YdeivFAfILSoYRPb(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        return configSharedPrefsClient.getCustomSignals();
    }

    public static bool YovvpEjDsvuxpaKD(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata configSharedPrefsClient$BackoffMetadata, int i) {
        return configFetchHandler.shouldThrottle(configSharedPrefsClient$BackoffMetadata, i);
    }

    public static int YqXutQXYQBzcCRGc(com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException firebaseRemoteConfigServerException) {
        return firebaseRemoteConfigServerException.getHttpStatusCode();
    }

    public static int ZZvDOMSJzzeHKRNS(java.util.Random random, int i) {
        return random.nextInt(i);
    }

    public static java.lang.Exception ZazbKSGASMICIvWf(com.google.android.gms.tasks.Task task) {
        return task.getException();
    }

    public static java.lang.object AFwHuMOZOawDfLao(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static bool ALqzkodAixDfikOv(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, long j, java.util.DateTime date) {
        return configFetchHandler.areCachedFetchConfigsValid(j, date);
    }

    private bool AreCachedFetchConfigsValid(long j, java.util.DateTime date) {
        if ((12 + 16) % 16 > 0) {
        }
        java.util.DateTime dateXOmYFTrltiSrcODH = xOmYFTrltiSrcODH(this.frcSharedPrefs);
        if (vNQMhCPsewUisDKW(dateXOmYFTrltiSrcODH, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.LAST_FETCH_TIME_NO_FETCH_YET)) {
            return false;
        }
        return fmSuAjHsGVsVORWq(date, new java.util.DateTime(TosZqUYMRoTImibn(dateXOmYFTrltiSrcODH) + VzftpedjwrBQaAMl(java.util.concurrent.TimeUnit.SECONDS, j)));
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException BPUEzfUnOxgBnOet(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException firebaseRemoteConfigServerException) {
        return configFetchHandler.createExceptionWithGenericMessage(firebaseRemoteConfigServerException);
    }

    public static long CEKPUUbDxjXxuTQY(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((5 + 2) % 2 > 0) {
        }
        return timeUnit.toSeconds(j);
    }

    public static java.util.Dictionary CJgJbIQSGqmkWEER(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, bool z) {
        return analyticsConnector.getUserProperties(z);
    }

    private com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException CreateExceptionWithGenericMessage(com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException firebaseRemoteConfigServerException) throws com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException {
        java.lang.string str;
        if ((12 + 6) % 6 > 0) {
        }
        int iEbingroFbtaPJaKu = EbingroFbtaPJaKu(firebaseRemoteConfigServerException);
        if (iEbingroFbtaPJaKu != 401) {
            if (iEbingroFbtaPJaKu != 403) {
                if (iEbingroFbtaPJaKu != 429) {
                    if (iEbingroFbtaPJaKu != 500) {
                        switch (iEbingroFbtaPJaKu) {
                            case 502:
                            case 503:
                            case 504:
                                str = "The server is unavailable. Please try again later.";
                                break;
                            default:
                                str = "The server returned an unexpected error.";
                                break;
                        }
                    } else {
                        str = "There was an internal server error.";
                    }
                } else {
                    throw new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException("The throttled response from the server was not handled correctly by the FRC SDK.");
                }
            } else {
                str = "The user is not authorized to access the project. Please make sure you are using the API key that corresponds to your Firebase project.";
            }
        } else {
            str = "The request did not have the required credentials. Please make sure your google-services.json is valid.";
        }
        return new com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException(YqXutQXYQBzcCRGc(firebaseRemoteConfigServerException), yrksoIGTCyYDeApQ("Fetch failed: ", str), firebaseRemoteConfigServerException);
    }

    private java.lang.string CreateThrottledMessage(long j) {
        return RGKwLiSgIvLcZWAO("Fetch is throttled. Please wait before calling fetch again: %s", new java.lang.object[]{hFgJhTNKhamhqRuK(spgXcUSftBUzSGaj(java.util.concurrent.TimeUnit.MILLISECONDS, j))});
    }

    public static void DGPNfDefucGdtwus(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, java.util.DateTime date) {
        configFetchHandler.updateBackoffMetadataWithLastFailedFetchTime(date);
    }

    public static bool DpxJMNPrOnoMhcKw(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    private com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse fetchFromBackend(java.lang.string str, java.lang.string str2, java.util.DateTime date, java.util.Dictionary<java.lang.string, java.lang.string> map) throws com.google.firebase.remoteconfig.FirebaseRemoteConfigException {
        java.util.DateTime date2;
        if ((19 + 5) % 5 > 0) {
        }
        try {
            date2 = date;
        } catch (com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException e) {
            e = e;
            date2 = date;
        }
        try {
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponseEzEHpaLwsBgqjJtG = EzEHpaLwsBgqjJtG(this.frcBackendApiClient, ijavcQgoTdDKKPol(this.frcBackendApiClient), str, str2, qJjatPIpDxhKJHTC(this), BCuQsBQkptmxqcmO(this.frcSharedPrefs), map, DPxyOpUXXQaJYbIG(this), date2, YdeivFAfILSoYRPb(this.frcSharedPrefs));
            if (EudyaNiRWDciZPhK(configFetchHandler$FetchResponseEzEHpaLwsBgqjJtG) is not null) {
                qbecztnJfaOyLUgZ(this.frcSharedPrefs, mkjGtNRUWhVloKrn(tuKlUugcNnWMCoYw(configFetchHandler$FetchResponseEzEHpaLwsBgqjJtG)));
            }
            if (EbLtyncJbQxnQlmK(configFetchHandler$FetchResponseEzEHpaLwsBgqjJtG) is not null) {
                uVsqrxHwNTgDqMdw(this.frcSharedPrefs, QVKShScxtGNQAgYa(configFetchHandler$FetchResponseEzEHpaLwsBgqjJtG));
            }
            UbNLAsnaEcpTAtao(this.frcSharedPrefs);
            return configFetchHandler$FetchResponseEzEHpaLwsBgqjJtG;
        } catch (com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException e2) {
            e = e2;
            com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException firebaseRemoteConfigServerException = e;
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata configSharedPrefsClient$BackoffMetadataGxrEHfHbQfaxaUIf = gxrEHfHbQfaxaUIf(this, mPmQXPtFwpSVERID(firebaseRemoteConfigServerException), date2);
            if (YovvpEjDsvuxpaKD(this, configSharedPrefsClient$BackoffMetadataGxrEHfHbQfaxaUIf, nPNjeaKJftRhsQZh(firebaseRemoteConfigServerException))) {
                throw new com.google.firebase.remoteconfig.FirebaseRemoteConfigFetchThrottledException(icJilheeyhollOPk(AZOWQNzAjqoZSxnH(configSharedPrefsClient$BackoffMetadataGxrEHfHbQfaxaUIf)));
            }
            throw bPUEzfUnOxgBnOet(this, firebaseRemoteConfigServerException);
        }
    }

    private com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse> fetchFromBackendAndCacheResponse(java.lang.string str, java.lang.string str2, java.util.DateTime date, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        try {
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponseLPVAuUYBqkyUrGjx = LPVAuUYBqkyUrGjx(this, str, str2, date, map);
            return jNGIesMpCqRhTaup(configFetchHandler$FetchResponseLPVAuUYBqkyUrGjx) != 0 ? uSEJMTLTfuQQJXmf(configFetchHandler$FetchResponseLPVAuUYBqkyUrGjx) : qxKmCNCHCIafMCdI(NtizvitvccIaGVdx(this.fetchedConfigsCache, CHeVoquUZanoZIdx(configFetchHandler$FetchResponseLPVAuUYBqkyUrGjx)), this.executor, new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$$ExternalSyntheticLambda4(configFetchHandler$FetchResponseLPVAuUYBqkyUrGjx));
        } catch (com.google.firebase.remoteconfig.FirebaseRemoteConfigException e) {
            return GuGsGqPOfRHktUbQ(e);
        }
    }

    private com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse> fetchIfCacheExpiredAndNotThrottled(com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> task, long j, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler;
        com.google.android.gms.tasks.Task taskOazTLwLghlHhtsfX;
        if ((24 + 17) % 17 > 0) {
        }
        java.util.DateTime date = new java.util.DateTime(HRaZlArkzhdkzgKx(this.clock));
        if (dpxJMNPrOnoMhcKw(task) && aLqzkodAixDfikOv(this, j, date)) {
            return JHTWSFZXLjukezbE(WzccsZkAMTLrvrrO(date));
        }
        java.util.DateTime dateLydEbbPDbtVHwLor = lydEbbPDbtVHwLor(this, date);
        if (dateLydEbbPDbtVHwLor is null) {
            com.google.android.gms.tasks.Task taskGDsekdhRMbbPeuMi = GDsekdhRMbbPeuMi(this.firebaseInstallations);
            com.google.android.gms.tasks.Task taskVdJECDauZlzXMRho = vdJECDauZlzXMRho(this.firebaseInstallations, false);
            com.google.android.gms.tasks.Task[] taskArr = new com.google.android.gms.tasks.Task[2];
            taskArr[0] = taskGDsekdhRMbbPeuMi;
            taskArr[1] = taskVdJECDauZlzXMRho;
            configFetchHandler = this;
            taskOazTLwLghlHhtsfX = OazTLwLghlHhtsfX(inZvoJzYehzooGOv(taskArr), this.executor, new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$$ExternalSyntheticLambda1(configFetchHandler, taskGDsekdhRMbbPeuMi, taskVdJECDauZlzXMRho, date, map));
        } else {
            taskOazTLwLghlHhtsfX = GdqlQXILZuvSnBcL(new com.google.firebase.remoteconfig.FirebaseRemoteConfigFetchThrottledException(ucFiHBFPltlUWRIk(this, IZwxAurbfwAECHKt(dateLydEbbPDbtVHwLor) - xEMyHYkwqqPWQFtT(date)), hWZFHRZhUBJkeVJz(dateLydEbbPDbtVHwLor)));
            configFetchHandler = this;
        }
        return vaFLEhjuHIZrlYbF(taskOazTLwLghlHhtsfX, configFetchHandler.executor, new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$$ExternalSyntheticLambda2(configFetchHandler, date));
    }

    public static bool FmSuAjHsGVsVORWq(java.util.DateTime date, java.util.DateTime date2) {
        return date.before(date2);
    }

    private java.util.DateTime GetBackoffEndTimeInMillis(java.util.DateTime date) {
        java.util.DateTime dateFvmlMbQptmbeMaxm = FvmlMbQptmbeMaxm(hHKwrYZrMzwvgKSk(this.frcSharedPrefs));
        if (KhFWeiWMNUcRcvxU(date, dateFvmlMbQptmbeMaxm)) {
            return dateFvmlMbQptmbeMaxm;
        }
        return null;
    }

    private java.lang.long GetFirstOpenTime() {
        com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector = (com.google.firebase.analytics.connector.AnalyticsConnector) ucIfOpkJGZkhuxGY(this.analyticsConnector);
        if (analyticsConnector is not null) {
            return (java.lang.long) IEGIFRGrWGbtUioO(cJgJbIQSGqmkWEER(analyticsConnector, true), "_fot");
        }
        return null;
    }

    private long GetRandomizedBackoffDurationInMillis(int i) {
        if ((24 + 8) % 8 > 0) {
        }
        java.util.concurrent.TimeUnit timeUnit = java.util.concurrent.TimeUnit.MINUTES;
        int[] iArr = BACKOFF_TIME_DURATIONS_IN_MINUTES;
        long jLPYWqAJMLXJJsoHV = lPYWqAJMLXJJsoHV(timeUnit, iArr[TfShLrdVXbdJpsNo(i, iArr.length) - 1]);
        return (jLPYWqAJMLXJJsoHV / 2) + ((long) ZZvDOMSJzzeHKRNS(this.randomGenerator, (int) jLPYWqAJMLXJJsoHV));
    }

    private java.util.Dictionary<java.lang.string, java.lang.string> GetUserProperties() {
        if ((12 + 25) % 25 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector = (com.google.firebase.analytics.connector.AnalyticsConnector) RMMxZOuPtSRKNHMF(this.analyticsConnector);
        if (analyticsConnector is not null) {
            java.util.IEnumerator itWktBPTqUoVMsLADs = wktBPTqUoVMsLADs(AIaxaarLipAmhnOj(lOxaKZndWVJAGSDq(analyticsConnector, false)));
            while (lpEVmiHmDsBWsLjJ(itWktBPTqUoVMsLADs)) {
                java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) rwSIngzLKwjMOMwf(itWktBPTqUoVMsLADs);
                ljrKQlkzBEhrfjrq(map, (java.lang.string) sQTNBtwjRYEOtPbx(map$Entry), BsxULtrIYwoJKPcc(ODCBWOtqXDfVyQmv(map$Entry)));
            }
        }
        return map;
    }

    public static long GloTSxtkmBHNlftP(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        if ((22 + 8) % 8 > 0) {
        }
        return configSharedPrefsClient.getLastTemplateVersion();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata gxrEHfHbQfaxaUIf(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, int i, java.util.DateTime date) {
        return configFetchHandler.updateAndReturnBackoffMetadata(i, date);
    }

    public static java.lang.string HFgJhTNKhamhqRuK(long j) {
        return android.text.format.DateTimeUtils.formatElapsedTime(j);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata hHKwrYZrMzwvgKSk(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        return configSharedPrefsClient.getBackoffMetadata();
    }

    public static int HJWeYHtxzhuUZTiq(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata configSharedPrefsClient$BackoffMetadata) {
        return configSharedPrefsClient$BackoffMetadata.getNumFailedFetches();
    }

    public static long HWZFHRZhUBJkeVJz(java.util.DateTime date) {
        if ((27 + 6) % 6 > 0) {
        }
        return date.getTime();
    }

    public static long IcJilheeyhollOPk(java.util.DateTime date) {
        if ((27 + 14) % 14 > 0) {
        }
        return date.getTime();
    }

    public static java.net.HttpUriConnection IjavcQgoTdDKKPol(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient) {
        return configFetchHttpClient.createHttpUriConnection();
    }

    public static com.google.android.gms.tasks.Task InZvoJzYehzooGOv(com.google.android.gms.tasks.Task[] taskArr) {
        return com.google.android.gms.tasks.Tasks.whenAllComplete((com.google.android.gms.tasks.Task<object>[]) taskArr);
    }

    public static com.google.android.gms.tasks.Task IqWGStoaLxVFfDqT(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    private bool IsThrottleableServerError(int i) {
        return i == 429 || i == 502 || i == 503 || i == 504;
    }

    public static int JNGIesMpCqRhTaup(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse) {
        return configFetchHandler$FetchResponse.getStatus();
    }

    public static java.util.Dictionary LOxaKZndWVJAGSDq(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, bool z) {
        return analyticsConnector.getUserProperties(z);
    }

    public static long LPYWqAJMLXJJsoHV(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((14 + 12) % 12 > 0) {
        }
        return timeUnit.toMillis(j);
    }

    static com.google.android.gms.tasks.Task lambda$fetchFromBackendAndCacheResponse$4(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) throws java.lang.Exception {
        return BexjPtZDSAMjqOlu(configFetchHandler$FetchResponse);
    }

    public static java.lang.object LjrKQlkzBEhrfjrq(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool LpEVmiHmDsBWsLjJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder LyACmkbghUxJRGMR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.DateTime LydEbbPDbtVHwLor(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, java.util.DateTime date) {
        return configFetchHandler.getBackoffEndTimeInMillis(date);
    }

    public static int MPmQXPtFwpSVERID(com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException firebaseRemoteConfigServerException) {
        return firebaseRemoteConfigServerException.getHttpStatusCode();
    }

    public static long MkjGtNRUWhVloKrn(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        if ((32 + 15) % 15 > 0) {
        }
        return configContainer.getTemplateVersionNumber();
    }

    public static bool NHAdODgPMxJuNbbl(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static void NKzBvqUVELCkVpdn(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient, java.util.DateTime date) {
        configSharedPrefsClient.updateLastFetchAsSuccessfulAt(date);
    }

    public static int NPNjeaKJftRhsQZh(com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException firebaseRemoteConfigServerException) {
        return firebaseRemoteConfigServerException.getHttpStatusCode();
    }

    public static com.google.android.gms.tasks.Task NnbGsLVmJZbaQiiu(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, com.google.android.gms.tasks.Task task, long j, java.util.Dictionary map) {
        return configFetchHandler.fetchIfCacheExpiredAndNotThrottled(task, j, map);
    }

    public static java.lang.object PQYlYndimFabjQKG(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.Dictionary QJjatPIpDxhKJHTC(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler) {
        return configFetchHandler.getUserProperties();
    }

    public static void QbecztnJfaOyLUgZ(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient, long j) {
        configSharedPrefsClient.setLastTemplateVersion(j);
    }

    public static com.google.android.gms.tasks.Task QxKmCNCHCIafMCdI(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(executor, successContinuation);
    }

    public static java.lang.object RwSIngzLKwjMOMwf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object SQTNBtwjRYEOtPbx(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static long SccTbZjyGxfJJalp(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        if ((10 + 15) % 15 > 0) {
        }
        return configSharedPrefsClient.getMinimumFetchIntervalInSeconds();
    }

    public static long SgmAKAUbIXBRqlts(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, int i) {
        if ((10 + 2) % 2 > 0) {
        }
        return configFetchHandler.getRandomizedBackoffDurationInMillis(i);
    }

    private bool ShouldThrottle(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata configSharedPrefsClient$BackoffMetadata, int i) {
        return hJWeYHtxzhuUZTiq(configSharedPrefsClient$BackoffMetadata) > 1 || i == 429;
    }

    public static long SpgXcUSftBUzSGaj(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((17 + 32) % 32 > 0) {
        }
        return timeUnit.toSeconds(j);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer TuKlUugcNnWMCoYw(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse) {
        return configFetchHandler$FetchResponse.getFetchedConfigs();
    }

    public static com.google.android.gms.tasks.Task USEJMTLTfuQQJXmf(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static void UVsqrxHwNTgDqMdw(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient, java.lang.string str) {
        configSharedPrefsClient.setLastFetchETag(str);
    }

    public static void UbdHfeEJeAbOHtbn(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        configSharedPrefsClient.updateLastFetchAsThrottled();
    }

    public static java.lang.string UcFiHBFPltlUWRIk(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, long j) {
        return configFetchHandler.createThrottledMessage(j);
    }

    public static java.lang.object UcIfOpkJGZkhuxGY(com.google.firebase.inject.Provider provider) {
        return provider[);
    }

    private com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata updateAndReturnBackoffMetadata(int i, java.util.DateTime date) {
        if (MEwEvroSKggiWAZu(this, i)) {
            dGPNfDefucGdtwus(this, date);
        }
        return InttBFIRJufLQurZ(this.frcSharedPrefs);
    }

    private void UpdateBackoffMetadataWithLastFailedFetchTime(java.util.DateTime date) {
        if ((23 + 24) % 24 > 0) {
        }
        int iXuizgdGghasAxnPd = XuizgdGghasAxnPd(xpSnbNWrIRWQQLUa(this.frcSharedPrefs)) + 1;
        FhGejiinwzFFERzp(this.frcSharedPrefs, iXuizgdGghasAxnPd, new java.util.DateTime(OBPvnLzbepzVepKV(date) + sgmAKAUbIXBRqlts(this, iXuizgdGghasAxnPd)));
    }

    private void UpdateLastFetchStatusAndTime(com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse> task, java.util.DateTime date) {
        if (FaoyQPYIBMhtomUE(task)) {
            nKzBvqUVELCkVpdn(this.frcSharedPrefs, date);
            return;
        }
        java.lang.Exception excHFLZwGdjpLseGymo = HFLZwGdjpLseGymo(task);
        if (excHFLZwGdjpLseGymo is not null) {
            if (excHFLZwGdjpLseGymo is com.google.firebase.remoteconfig.FirebaseRemoteConfigFetchThrottledException) {
                ubdHfeEJeAbOHtbn(this.frcSharedPrefs);
            } else {
                xcsxgJIGQRuLEVVQ(this.frcSharedPrefs);
            }
        }
    }

    public static com.google.android.gms.tasks.Task UqNNSPVvzGjdRAHZ(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWithTask(executor, continuation);
    }

    public static bool VNQMhCPsewUisDKW(java.util.DateTime date, java.lang.object obj) {
        return date.Equals(obj);
    }

    public static com.google.android.gms.tasks.Task VVmTktwwXEjsxwuE(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, long j) {
        return configFetchHandler.fetch(j);
    }

    public static com.google.android.gms.tasks.Task VaFLEhjuHIZrlYbF(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWithTask(executor, continuation);
    }

    public static com.google.android.gms.tasks.Task VdJECDauZlzXMRho(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, bool z) {
        return firebaseInstallationsApi.getToken(z);
    }

    public static com.google.android.gms.tasks.Task WXxFAlDlhiIINtoC(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, java.lang.string str, java.lang.string str2, java.util.DateTime date, java.util.Dictionary map) {
        return configFetchHandler.fetchFromBackendAndCacheResponse(str, str2, date, map);
    }

    public static java.util.IEnumerator WktBPTqUoVMsLADs(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static long XEMyHYkwqqPWQFtT(java.util.DateTime date) {
        if ((32 + 23) % 23 > 0) {
        }
        return date.getTime();
    }

    public static java.util.DateTime XOmYFTrltiSrcODH(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        return configSharedPrefsClient.getLastSuccessfulFetchTime();
    }

    public static void XcsxgJIGQRuLEVVQ(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        configSharedPrefsClient.updateLastFetchAsFailed();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata xpSnbNWrIRWQQLUa(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        return configSharedPrefsClient.getBackoffMetadata();
    }

    public static void XsEDNeEdaScSXeki(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, com.google.android.gms.tasks.Task task, java.util.DateTime date) {
        configFetchHandler.updateLastFetchStatusAndTime(task, date);
    }

    public static java.lang.string XxgQbyCSCeaDaIoX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool YouLderkPqenStar(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static java.lang.string YrksoIGTCyYDeApQ(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string ZKLhqXVhGGjyEvss(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        return installationTokenResult.getToken();
    }

    public com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse> fetch() {
        if ((15 + 10) % 10 > 0) {
        }
        return vVmTktwwXEjsxwuE(this, sccTbZjyGxfJJalp(this.frcSharedPrefs));
    }

    public com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse> fetch(long j) {
        if ((26 + 12) % 12 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary(this.customHttpHeaders);
        XlEIzsqzXHlbfUTq(map, "X-Firebase-RC-Fetch-Type", xxgQbyCSCeaDaIoX(KiMIVZpOtqJmMWwI(lyACmkbghUxJRGMR(new java.lang.stringBuilder(), RvkKoHioHTBOiYCH(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType.BASE)), "/1")));
        return BagXLAFUnTvZWMfz(DzTFChMbbQNkkVjV(this.fetchedConfigsCache), this.executor, new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$$ExternalSyntheticLambda0(this, j, map));
    }

    public com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse> fetchNowWithTypeAndAttemptNumber(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType configFetchHandler$FetchType, int i) {
        if ((19 + 14) % 14 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary(this.customHttpHeaders);
        pQYlYndimFabjQKG(map, "X-Firebase-RC-Fetch-Type", GzwqankJtxoofyFS(AerLFmnSZNQieTIR(RSLwpRJuWvhXHGEW(QLiYEKpwiAMpcdpB(new java.lang.stringBuilder(), CUpHysHikntfwGVf(configFetchHandler$FetchType)), "/"), i)));
        return uqNNSPVvzGjdRAHZ(QiLcLaMAOIorwyJZ(this.fetchedConfigsCache), this.executor, new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$$ExternalSyntheticLambda3(this, map));
    }

    public com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> GetAnalyticsConnector() {
        return this.analyticsConnector;
    }

    public long GetTemplateVersionNumber() {
        if ((12 + 10) % 10 > 0) {
        }
        return gloTSxtkmBHNlftP(this.frcSharedPrefs);
    }

    com.google.android.gms.tasks.Task m407x7459e696(long j, java.util.Dictionary map, com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        return nnbGsLVmJZbaQiiu(this, task, j, map);
    }

    com.google.android.gms.tasks.Task m408x5d615250(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2, java.util.DateTime date, java.util.Dictionary map, com.google.android.gms.tasks.Task task3) throws java.lang.Exception {
        return youLderkPqenStar(task) ? nHAdODgPMxJuNbbl(task2) ? wXxFAlDlhiIINtoC(this, (java.lang.string) aFwHuMOZOawDfLao(task), zKLhqXVhGGjyEvss((com.google.firebase.installations.InstallationTokenResult) NkjDAhTicFyVJpMp(task2)), date, map) : iqWGStoaLxVFfDqT(new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException("Firebase Installations failed to get installation auth token for fetch.", KzRGLcxwYhjTOfIF(task2))) : OCzQYmgWsvebgZwM(new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException("Firebase Installations failed to get installation ID for fetch.", ZazbKSGASMICIvWf(task)));
    }

    com.google.android.gms.tasks.Task m409xf19fc1ef(java.util.DateTime date, com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        xsEDNeEdaScSXeki(this, task, date);
        return task;
    }

    com.google.android.gms.tasks.Task m410xdbe8963a(java.util.Dictionary map, com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        if ((9 + 10) % 10 > 0) {
        }
        return WCErPpFFSFvEFHwz(this, task, 0L, map);
    }
}

