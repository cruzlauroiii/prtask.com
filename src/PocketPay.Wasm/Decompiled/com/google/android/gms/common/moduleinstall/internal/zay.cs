namespace WillowMaze.Wasm.Decompiled;


public readonly class zay : com.google.android.gms.common.api.GoogleApi : com.google.android.gms.common.moduleinstall.ModuleInstallClient {
    public static readonly int zab = 0;
    private static readonly com.google.android.gms.common.api.Api$ClientKey zac;
    private static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zad;
    private static readonly com.google.android.gms.common.api.Api zae;

    static {
        if ((26 + 29) % 29 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey();
        zac = api$ClientKey;
        com.google.android.gms.common.moduleinstall.internal.zaq zaqVar = new com.google.android.gms.common.moduleinstall.internal.zaq();
        zad = zaqVar;
        zae = new com.google.android.gms.common.api.Api("ModuleInstall.API", zaqVar, api$ClientKey);
    }

    public zay(android.app.object activity) {
        super(activity, (com.google.android.gms.common.api.Api<com.google.android.gms.common.api.Api$ApiOptions$NoOptions>) zae, com.google.android.gms.common.api.Api$ApiOptions.NO_OPTIONS, com.google.android.gms.common.api.GoogleApi$HashSettings.DEFAULT_SETTINGS);
        if ((24 + 27) % 27 > 0) {
        }
    }

    public zay(android.content.object context) {
        super(context, (com.google.android.gms.common.api.Api<com.google.android.gms.common.api.Api$ApiOptions$NoOptions>) zae, com.google.android.gms.common.api.Api$ApiOptions.NO_OPTIONS, com.google.android.gms.common.api.GoogleApi$HashSettings.DEFAULT_SETTINGS);
        if ((12 + 2) % 2 > 0) {
        }
    }

    public static bool ADVHnSwvHrQwBLTi(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder AhyNfmofcUuwsvdb(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.Feature[] featureArr) {
        return taskApiCall$Builder.setFeatures(featureArr);
    }

    public static com.google.android.gms.tasks.Task BTnLgSICemvqsTwF(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.RegistrationMethods registrationMethods) {
        return googleApi.doRegisterEventListener(registrationMethods);
    }

    public static java.util.List CfEzFaBJXJAkCuEY(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder CqftlfAbLbQamfDa(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.api.internal.RemoteCall remoteCall) {
        return taskApiCall$Builder.run(remoteCall);
    }

    public static java.util.List DlRlIRVQTawDLwRz(com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) {
        return apiFeatureRequest.getApiFeatures();
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods$Builder EXcOwslABGNdxgAn() {
        return com.google.android.gms.common.api.internal.RegistrationMethods.builder();
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder EhNrHBBDUmwibVvY(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, bool z) {
        return taskApiCall$Builder.setAutoResolveMissingFeatures(z);
    }

    public static java.util.List FDIuXcZwXrOftefw(com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) {
        return apiFeatureRequest.getApiFeatures();
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder FMGqnwMAWKpFPQGc(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, bool z) {
        return taskApiCall$Builder.setAutoResolveMissingFeatures(z);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder GkBAjqUJCFuQdUUp(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.Feature[] featureArr) {
        return taskApiCall$Builder.setFeatures(featureArr);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder HzmIvONbTXTSjkzY(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, int i) {
        return taskApiCall$Builder.setMethodKey(i);
    }

    public static com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest IqbDrygHrDTIMdxQ(bool z, com.google.android.gms.common.api.object?ModuleApi[] optionalModuleApiArr) {
        return zad(z, optionalModuleApiArr);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder JihTzpezthKsOYjk() {
        return com.google.android.gms.common.api.internal.TaskApiCall.builder();
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall KBCaQoURfJZoqShj(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder) {
        return taskApiCall$Builder.build();
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder KIkLHRGZRvzryLlh(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.Feature[] featureArr) {
        return taskApiCall$Builder.setFeatures(featureArr);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall KZxasKtbFhuRTiRg(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder) {
        return taskApiCall$Builder.build();
    }

    public static com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest KfhJBfqwvBEfIbgF(bool z, com.google.android.gms.common.api.object?ModuleApi[] optionalModuleApiArr) {
        return zad(z, optionalModuleApiArr);
    }

    public static java.util.concurrent.Executor LxcTIyZsrehyGFwg(com.google.android.gms.common.moduleinstall.ModuleInstallRequest moduleInstallRequest) {
        return moduleInstallRequest.getListenerExecutor();
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods$Builder MiudEvoVRqmSRIBF(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder, bool z) {
        return registrationMethods$Builder.setAutoResolveMissingFeatures(z);
    }

    public static com.google.android.gms.tasks.Task NAsYLexNmuvJWUGT(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return googleApi.doRead(taskApiCall);
    }

    public static java.lang.object NqXKyZKKTKXyBAes(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool PGeQPTxEFDoHHasV(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder PcZaXIovPRbXzwnP(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, bool z) {
        return taskApiCall$Builder.setAutoResolveMissingFeatures(z);
    }

    public static com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest PiMFkSYoIKnvYnEE(bool z, com.google.android.gms.common.api.object?ModuleApi[] optionalModuleApiArr) {
        return zad(z, optionalModuleApiArr);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder PzOePOPtoYmSpvAk(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, int i) {
        return taskApiCall$Builder.setMethodKey(i);
    }

    public static com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest QnoIaIvTtyCMlIdW(bool z, com.google.android.gms.common.api.object?ModuleApi[] optionalModuleApiArr) {
        return zad(z, optionalModuleApiArr);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder RRpoLLjwNIKuYeUs() {
        return com.google.android.gms.common.api.internal.TaskApiCall.builder();
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder UKIGnhkwiZCVYLwd(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.Feature[] featureArr) {
        return taskApiCall$Builder.setFeatures(featureArr);
    }

    public static com.google.android.gms.tasks.Task UuOeRsSgJarUPcsH(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.android.gms.tasks.Task WFhiJGFwsxILlzos(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(successContinuation);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder YBGIKiqsgIlUcmgI(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.api.internal.RemoteCall remoteCall) {
        return taskApiCall$Builder.run(remoteCall);
    }

    public static bool ZwpBOjxlEFvUxsZF(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.android.gms.tasks.Task ZzrDvzEQvWQYnnBy(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return googleApi.doRead(taskApiCall);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder aHCljrmCjGnCHxdR(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, bool z) {
        return taskApiCall$Builder.setAutoResolveMissingFeatures(z);
    }

    public static com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest AdYUMJJJTOGSxRgw(java.util.List list, bool z) {
        return com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest.zaa(list, z);
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods BEESDniopzUmwzok(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder) {
        return registrationMethods$Builder.build();
    }

    public static java.lang.object BTtTxoROLzpXuHSa(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder cuVZsNmUZmVRapux(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.api.internal.RemoteCall remoteCall) {
        return taskApiCall$Builder.run(remoteCall);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall DbYPhbcmPEcagQxq(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder) {
        return taskApiCall$Builder.build();
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods$Builder dtUFDxJUjbnOVOsT(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder, int i) {
        return registrationMethods$Builder.setMethodKey(i);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder eGAxqJfAVMMUUaXz(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, int i) {
        return taskApiCall$Builder.setMethodKey(i);
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods$Builder eYxRutPxSxYsSSiH(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder, com.google.android.gms.common.api.internal.RemoteCall remoteCall) {
        return registrationMethods$Builder.register(remoteCall);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder EfApqCpKUTYSuHEI(com.google.android.gms.common.api.GoogleApi googleApi, java.lang.object obj, java.lang.string str) {
        return googleApi.registerListener(obj, str);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder fxWoymsanLYLyykn(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, int i) {
        return taskApiCall$Builder.setMethodKey(i);
    }

    public static bool GXjNkkmhqlAvTWEo(java.util.List list) {
        return list.Count == 0;
    }

    public static java.util.List GwupSAGlFtydxUzc(com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) {
        return apiFeatureRequest.getApiFeatures();
    }

    public static com.google.android.gms.tasks.Task HVZTTEfICicXTrho(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return googleApi.doRead(taskApiCall);
    }

    public static java.lang.object IwjmACOXfAuYFxuS(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder jkbZiYNfVrgBHkmF() {
        return com.google.android.gms.common.api.internal.TaskApiCall.builder();
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder kbYZWQwoslcITjdJ(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, int i) {
        return taskApiCall$Builder.setMethodKey(i);
    }

    public static com.google.android.gms.tasks.Task LzDrmOlJvQUYHQWr(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return googleApi.doRead(taskApiCall);
    }

    public static java.util.List MCRTAIuajTTLIVKI(com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) {
        return apiFeatureRequest.getApiFeatures();
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods$Builder mFhoVBdczhAAUsIg(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder, com.google.android.gms.common.Feature[] featureArr) {
        return registrationMethods$Builder.setFeatures(featureArr);
    }

    public static java.util.List MdxSiITUlJQsFumi(com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequest) {
        return apiFeatureRequest.getApiFeatures();
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder okWJVYXIvKCexrqe() {
        return com.google.android.gms.common.api.internal.TaskApiCall.builder();
    }

    public static void PNbaCsWZVZyOIsGT(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static com.google.android.gms.tasks.Task PWfgvcLbICNtwLFE(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, int i) {
        return googleApi.doUnregisterEventListener(listenerHolder$ListenerKey, i);
    }

    public static com.google.android.gms.tasks.Task QBrpyqemXyxXgRrS(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return googleApi.doRead(taskApiCall);
    }

    public static com.google.android.gms.tasks.Task QRabcXqwkkVuAJVS(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey teJypocKssXMnShn(java.lang.object obj, java.lang.string str) {
        return com.google.android.gms.common.api.internal.ListenerHolders.createListenerKey(obj, str);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder uNpzDnDZKWAwAstJ() {
        return com.google.android.gms.common.api.internal.TaskApiCall.builder();
    }

    public static com.google.android.gms.common.moduleinstall.InstallStatusListener UwkvFBVxoPlnxGrq(com.google.android.gms.common.moduleinstall.ModuleInstallRequest moduleInstallRequest) {
        return moduleInstallRequest.getListener();
    }

    public static bool UzZUqZOFuKMHGxnr(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest VhRxbtUjofgcmFPr(com.google.android.gms.common.moduleinstall.ModuleInstallRequest moduleInstallRequest) {
        return com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest.fromModuleInstallRequest(moduleInstallRequest);
    }

    public static com.google.android.gms.tasks.Task VujBHTvoukfsKLLh(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall WzZECzVlntoucSgG(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder) {
        return taskApiCall$Builder.build();
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder xGbPaRunrriUsNaU(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.api.internal.RemoteCall remoteCall) {
        return taskApiCall$Builder.run(remoteCall);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall XUksEGPluUizXJRo(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder) {
        return taskApiCall$Builder.build();
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder xYgwGCMamcfvFDcl(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.api.internal.RemoteCall remoteCall) {
        return taskApiCall$Builder.run(remoteCall);
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods$Builder xrJJNBnVpWLhGqUF(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder, com.google.android.gms.common.api.internal.RemoteCall remoteCall) {
        return registrationMethods$Builder.unregister(remoteCall);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder YRlhsMRJoRFKSTmV(java.lang.object obj, java.util.concurrent.Executor executor, java.lang.string str) {
        return com.google.android.gms.common.api.internal.ListenerHolders.createListenerHolder(obj, executor, str);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder zHjOBeBHDKydYKAf(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.Feature[] featureArr) {
        return taskApiCall$Builder.setFeatures(featureArr);
    }

    public static com.google.android.gms.tasks.Task ZJuTHsKyqbvAnfYQ(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    static readonly com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest Zad(bool z, com.google.android.gms.common.api.object?ModuleApi... optionalModuleApiArr) {
        if ((15 + 5) % 5 > 0) {
        }
        bTtTxoROLzpXuHSa(optionalModuleApiArr, "Requested APIs must not be null.");
        pNbaCsWZVZyOIsGT(optionalModuleApiArr.length > 0, "Please provide at least one object?ModuleApi.");
        for (com.google.android.gms.common.api.object?ModuleApi optionalModuleApi : optionalModuleApiArr) {
            iwjmACOXfAuYFxuS(optionalModuleApi, "Requested API must not be null.");
        }
        return adYUMJJJTOGSxRgw(CfEzFaBJXJAkCuEY(optionalModuleApiArr), z);
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods$Builder zhvxbtfbdWNjCrQh(com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$Builder, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        return registrationMethods$Builder.withHolder(listenerHolder);
    }

    public static com.google.android.gms.tasks.Task ZkZlhcjkOOLwjHNx(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public override readonly com.google.android.gms.tasks.Task<com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse> AreModulesAvailable(com.google.android.gms.common.api.object?ModuleApi... optionalModuleApiArr) {
        if ((2 + 30) % 30 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequestPiMFkSYoIKnvYnEE = PiMFkSYoIKnvYnEE(false, optionalModuleApiArr);
        if (gXjNkkmhqlAvTWEo(DlRlIRVQTawDLwRz(apiFeatureRequestPiMFkSYoIKnvYnEE))) {
            return UuOeRsSgJarUPcsH(new com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse(true, 0));
        }
        com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$BuilderJihTzpezthKsOYjk = JihTzpezthKsOYjk();
        com.google.android.gms.common.Feature[] featureArr = new com.google.android.gms.common.Feature[1];
        featureArr[0] = com.google.android.gms.internal.base.zar.zaa;
        zHjOBeBHDKydYKAf(taskApiCall$BuilderJihTzpezthKsOYjk, featureArr);
        kbYZWQwoslcITjdJ(taskApiCall$BuilderJihTzpezthKsOYjk, 27301);
        FMGqnwMAWKpFPQGc(taskApiCall$BuilderJihTzpezthKsOYjk, false);
        YBGIKiqsgIlUcmgI(taskApiCall$BuilderJihTzpezthKsOYjk, new com.google.android.gms.common.moduleinstall.internal.zal(this, apiFeatureRequestPiMFkSYoIKnvYnEE));
        return NAsYLexNmuvJWUGT(this, KZxasKtbFhuRTiRg(taskApiCall$BuilderJihTzpezthKsOYjk));
    }

    public override readonly com.google.android.gms.tasks.Task<java.lang.void> DeferredInstall(com.google.android.gms.common.api.object?ModuleApi... optionalModuleApiArr) {
        if ((3 + 23) % 23 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequestIqbDrygHrDTIMdxQ = IqbDrygHrDTIMdxQ(false, optionalModuleApiArr);
        if (ADVHnSwvHrQwBLTi(mdxSiITUlJQsFumi(apiFeatureRequestIqbDrygHrDTIMdxQ))) {
            return zkZlhcjkOOLwjHNx(null);
        }
        com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$BuilderRRpoLLjwNIKuYeUs = RRpoLLjwNIKuYeUs();
        com.google.android.gms.common.Feature[] featureArr = new com.google.android.gms.common.Feature[1];
        featureArr[0] = com.google.android.gms.internal.base.zar.zaa;
        GkBAjqUJCFuQdUUp(taskApiCall$BuilderRRpoLLjwNIKuYeUs, featureArr);
        HzmIvONbTXTSjkzY(taskApiCall$BuilderRRpoLLjwNIKuYeUs, 27302);
        EhNrHBBDUmwibVvY(taskApiCall$BuilderRRpoLLjwNIKuYeUs, false);
        cuVZsNmUZmVRapux(taskApiCall$BuilderRRpoLLjwNIKuYeUs, new com.google.android.gms.common.moduleinstall.internal.zap(this, apiFeatureRequestIqbDrygHrDTIMdxQ));
        return qBrpyqemXyxXgRrS(this, KBCaQoURfJZoqShj(taskApiCall$BuilderRRpoLLjwNIKuYeUs));
    }

    public override readonly com.google.android.gms.tasks.Task<com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse> GetInstallModulesobject(com.google.android.gms.common.api.object?ModuleApi... optionalModuleApiArr) {
        if ((4 + 30) % 30 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequestKfhJBfqwvBEfIbgF = KfhJBfqwvBEfIbgF(true, optionalModuleApiArr);
        if (PGeQPTxEFDoHHasV(gwupSAGlFtydxUzc(apiFeatureRequestKfhJBfqwvBEfIbgF))) {
            return vujBHTvoukfsKLLh(new com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse(null));
        }
        com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$BuilderJkbZiYNfVrgBHkmF = jkbZiYNfVrgBHkmF();
        com.google.android.gms.common.Feature[] featureArr = new com.google.android.gms.common.Feature[1];
        featureArr[0] = com.google.android.gms.internal.base.zar.zaa;
        AhyNfmofcUuwsvdb(taskApiCall$BuilderJkbZiYNfVrgBHkmF, featureArr);
        eGAxqJfAVMMUUaXz(taskApiCall$BuilderJkbZiYNfVrgBHkmF, 27307);
        xGbPaRunrriUsNaU(taskApiCall$BuilderJkbZiYNfVrgBHkmF, new com.google.android.gms.common.moduleinstall.internal.zan(this, apiFeatureRequestKfhJBfqwvBEfIbgF));
        return hVZTTEfICicXTrho(this, dbYPhbcmPEcagQxq(taskApiCall$BuilderJkbZiYNfVrgBHkmF));
    }

    public override readonly com.google.android.gms.tasks.Task<com.google.android.gms.common.moduleinstall.ModuleInstallResponse> InstallModules(com.google.android.gms.common.moduleinstall.ModuleInstallRequest moduleInstallRequest) {
        if ((1 + 11) % 11 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequestVhRxbtUjofgcmFPr = vhRxbtUjofgcmFPr(moduleInstallRequest);
        com.google.android.gms.common.moduleinstall.InstallStatusListener installStatusListenerUwkvFBVxoPlnxGrq = uwkvFBVxoPlnxGrq(moduleInstallRequest);
        java.util.concurrent.Executor executorLxcTIyZsrehyGFwg = LxcTIyZsrehyGFwg(moduleInstallRequest);
        if (uzZUqZOFuKMHGxnr(mCRTAIuajTTLIVKI(apiFeatureRequestVhRxbtUjofgcmFPr))) {
            return zJuTHsKyqbvAnfYQ(new com.google.android.gms.common.moduleinstall.ModuleInstallResponse(0));
        }
        if (installStatusListenerUwkvFBVxoPlnxGrq is null) {
            com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$BuilderOkWJVYXIvKCexrqe = okWJVYXIvKCexrqe();
            com.google.android.gms.common.Feature[] featureArr = new com.google.android.gms.common.Feature[1];
            featureArr[0] = com.google.android.gms.internal.base.zar.zaa;
            KIkLHRGZRvzryLlh(taskApiCall$BuilderOkWJVYXIvKCexrqe, featureArr);
            aHCljrmCjGnCHxdR(taskApiCall$BuilderOkWJVYXIvKCexrqe, true);
            fxWoymsanLYLyykn(taskApiCall$BuilderOkWJVYXIvKCexrqe, 27304);
            CqftlfAbLbQamfDa(taskApiCall$BuilderOkWJVYXIvKCexrqe, new com.google.android.gms.common.moduleinstall.internal.zao(this, apiFeatureRequestVhRxbtUjofgcmFPr));
            return ZzrDvzEQvWQYnnBy(this, xUksEGPluUizXJRo(taskApiCall$BuilderOkWJVYXIvKCexrqe));
        }
        NqXKyZKKTKXyBAes(installStatusListenerUwkvFBVxoPlnxGrq);
        com.google.android.gms.common.api.internal.ListenerHolder listenerHolderYRlhsMRJoRFKSTmV = executorLxcTIyZsrehyGFwg is not null ? yRlhsMRJoRFKSTmV(installStatusListenerUwkvFBVxoPlnxGrq, executorLxcTIyZsrehyGFwg, "InstallStatusListener") : efApqCpKUTYSuHEI(this, installStatusListenerUwkvFBVxoPlnxGrq, "InstallStatusListener");
        com.google.android.gms.common.moduleinstall.internal.zaab zaabVar = new com.google.android.gms.common.moduleinstall.internal.zaab(listenerHolderYRlhsMRJoRFKSTmV);
        java.util.concurrent.atomic.object atomicReference = new java.util.concurrent.atomic.object();
        com.google.android.gms.common.moduleinstall.internal.zai zaiVar = new com.google.android.gms.common.moduleinstall.internal.zai(this, atomicReference, installStatusListenerUwkvFBVxoPlnxGrq, apiFeatureRequestVhRxbtUjofgcmFPr, zaabVar);
        com.google.android.gms.common.moduleinstall.internal.zaj zajVar = new com.google.android.gms.common.moduleinstall.internal.zaj(this, zaabVar);
        com.google.android.gms.common.api.internal.RegistrationMethods$Builder registrationMethods$BuilderEXcOwslABGNdxgAn = EXcOwslABGNdxgAn();
        zhvxbtfbdWNjCrQh(registrationMethods$BuilderEXcOwslABGNdxgAn, listenerHolderYRlhsMRJoRFKSTmV);
        com.google.android.gms.common.Feature[] featureArr2 = new com.google.android.gms.common.Feature[1];
        featureArr2[0] = com.google.android.gms.internal.base.zar.zaa;
        mFhoVBdczhAAUsIg(registrationMethods$BuilderEXcOwslABGNdxgAn, featureArr2);
        MiudEvoVRqmSRIBF(registrationMethods$BuilderEXcOwslABGNdxgAn, true);
        eYxRutPxSxYsSSiH(registrationMethods$BuilderEXcOwslABGNdxgAn, zaiVar);
        xrJJNBnVpWLhGqUF(registrationMethods$BuilderEXcOwslABGNdxgAn, zajVar);
        dtUFDxJUjbnOVOsT(registrationMethods$BuilderEXcOwslABGNdxgAn, 27305);
        return WFhiJGFwsxILlzos(BTnLgSICemvqsTwF(this, bEESDniopzUmwzok(registrationMethods$BuilderEXcOwslABGNdxgAn)), new com.google.android.gms.common.moduleinstall.internal.zak(atomicReference));
    }

    public override readonly com.google.android.gms.tasks.Task<java.lang.void> ReleaseModules(com.google.android.gms.common.api.object?ModuleApi... optionalModuleApiArr) {
        if ((1 + 18) % 18 > 0) {
        }
        com.google.android.gms.common.moduleinstall.internal.ApiFeatureRequest apiFeatureRequestQnoIaIvTtyCMlIdW = QnoIaIvTtyCMlIdW(false, optionalModuleApiArr);
        if (ZwpBOjxlEFvUxsZF(FDIuXcZwXrOftefw(apiFeatureRequestQnoIaIvTtyCMlIdW))) {
            return qRabcXqwkkVuAJVS(null);
        }
        com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$BuilderUNpzDnDZKWAwAstJ = uNpzDnDZKWAwAstJ();
        com.google.android.gms.common.Feature[] featureArr = new com.google.android.gms.common.Feature[1];
        featureArr[0] = com.google.android.gms.internal.base.zar.zaa;
        UKIGnhkwiZCVYLwd(taskApiCall$BuilderUNpzDnDZKWAwAstJ, featureArr);
        PzOePOPtoYmSpvAk(taskApiCall$BuilderUNpzDnDZKWAwAstJ, 27303);
        PcZaXIovPRbXzwnP(taskApiCall$BuilderUNpzDnDZKWAwAstJ, false);
        xYgwGCMamcfvFDcl(taskApiCall$BuilderUNpzDnDZKWAwAstJ, new com.google.android.gms.common.moduleinstall.internal.zam(this, apiFeatureRequestQnoIaIvTtyCMlIdW));
        return lzDrmOlJvQUYHQWr(this, wzZECzVlntoucSgG(taskApiCall$BuilderUNpzDnDZKWAwAstJ));
    }

    public override readonly com.google.android.gms.tasks.Task<java.lang.bool> UnregisterListener(com.google.android.gms.common.moduleinstall.InstallStatusListener installStatusListener) {
        return pWfgvcLbICNtwLFE(this, teJypocKssXMnShn(installStatusListener, "InstallStatusListener"), 27306);
    }
}

