namespace WillowMaze.Wasm.Decompiled;


readonly class zacb : com.google.android.gms.tasks.OnCompleteListener {
    private readonly com.google.android.gms.common.api.internal.GoogleApiManager zaa;
    private readonly int zab;
    private readonly com.google.android.gms.common.api.internal.ApiKey zac;
    private readonly long zad;
    private readonly long zae;

    zacb(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, int i, com.google.android.gms.common.api.internal.ApiKey apiKey, long j, long j2, java.lang.string str, java.lang.string str2) {
        this.zaa = googleApiManager;
        this.zab = i;
        this.zac = apiKey;
        this.zad = j;
        this.zae = j2;
    }

    public static void AXIrYYeKvyQpTgci(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaq();
    }

    public static com.google.android.gms.common.internal.RootTelemetryConfiguration DvklvzbVFOmElaEv(com.google.android.gms.common.internal.RootTelemetryConfigManager rootTelemetryConfigManager) {
        return rootTelemetryConfigManager.getConfig();
    }

    public static int EbJPmGbXfnKnFuLQ(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getMaxMethodInvocationsInBatch();
    }

    public static int FpGQqpWRWuDTysAh(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getBatchPeriodMillis();
    }

    public static bool GBaAjGcursfxduZN(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static void GjydJGdttTvPEmJO(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.internal.MethodInvocation methodInvocation, int i, long j, int i2) {
        googleApiManager.zaw(methodInvocation, i, j, i2);
    }

    public static com.google.android.gms.common.api.Status IyNmelhMeySXYmXE(com.google.android.gms.common.api.ApiException apiException) {
        return apiException.getStatus();
    }

    public static int JVTIRUqwcUxJxxmy(com.google.android.gms.common.api.Status status) {
        return status.getStatusCode();
    }

    public static bool JYHWoeiKsSqkdbwu(int[] iArr, int i) {
        return com.google.android.gms.common.util.ArrayUtils.Contains(iArr, i);
    }

    public static bool KGGzEhZyAJpRFGgk(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getMethodInvocationTelemetryEnabled();
    }

    public static int KNZCOazbqlHnnsCj(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static bool LAWlzHBvVyiacvId(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.isConnecting();
    }

    public static bool MMECKQZtbynAWNdJ(com.google.android.gms.tasks.Task task) {
        return task.isCanceled();
    }

    public static com.google.android.gms.common.api.Api$Client MetzNwzsYvhKFPSl(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaf();
    }

    public static bool NfonMJjUhhpXDGhl(int[] iArr, int i) {
        return com.google.android.gms.common.util.ArrayUtils.Contains(iArr, i);
    }

    public static long NiQbJpTjfAThufZf() {
        if ((18 + 19) % 19 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static bool PpXChLCphUxpuYLW(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zaD();
    }

    public static com.google.android.gms.common.internal.ConnectionTelemetryConfiguration SJFBSqfCXonTVKma(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.getTelemetryConfiguration();
    }

    public static com.google.android.gms.common.internal.ConnectionTelemetryConfiguration SKVysJYiCZvDdKbr(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i) {
        return zab(zaboVar, baseGmsClient, i);
    }

    public static int VJaXVtNUkLUnkHsG(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.getGCoreServiceId();
    }

    public static int[] WBirSnkheGoxRlny(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMethodInvocationMethodKeyDisallowlist();
    }

    public static com.google.android.gms.common.ConnectionResult ZFCkIoUnoeYYeDHM(com.google.android.gms.common.api.Status status) {
        return status.getConnectionResult();
    }

    public static java.lang.Exception ZUBzBiTkifCIAiAE(com.google.android.gms.tasks.Task task) {
        return task.getException();
    }

    public static bool DYVShMOkRBlAdIuf(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMethodInvocationTelemetryEnabled();
    }

    public static com.google.android.gms.common.api.Api$Client ddIWvlbjjslfFZKC(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaf();
    }

    public static int DxpncOyEaErUbbBL(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMaxMethodInvocationsConsoleged();
    }

    public static bool EJxyTfRXABTIkpwN(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zaD();
    }

    public static com.google.android.gms.common.internal.ConnectionTelemetryConfiguration FTmCNRERntdoOSnH(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i) {
        return zab(zaboVar, baseGmsClient, i);
    }

    public static com.google.android.gms.common.internal.RootTelemetryConfiguration FsFVOYkoOnePYaWO(com.google.android.gms.common.internal.RootTelemetryConfigManager rootTelemetryConfigManager) {
        return rootTelemetryConfigManager.getConfig();
    }

    public static bool GqjVGKGegvmfbxiP(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getMethodInvocationTelemetryEnabled();
    }

    public static com.google.android.gms.common.internal.RootTelemetryConfigManager HJNeLseeKZkqCFDq() {
        return com.google.android.gms.common.internal.RootTelemetryConfigManager.getInstance();
    }

    public static bool HlCVxdQRmDYQbBDg(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getMethodTimingTelemetryEnabled();
    }

    public static com.google.android.gms.common.api.Api$Client ibdRKobtDxjZRTuD(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaf();
    }

    public static bool IeJoTovLyeBOgLIM(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.hasConnectionInfo();
    }

    public static com.google.android.gms.common.api.Api$Client knrtIIWXNGpyzdzl(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaf();
    }

    public static int LVnwmyMAwzjUGlhX(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMaxMethodInvocationsConsoleged();
    }

    public static com.google.android.gms.common.api.internal.zabo LgliZnIivzmzUWGN(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.internal.ApiKey apiKey) {
        return googleApiManager.zai(apiKey);
    }

    public static bool MKceZTlgkaTctrhg(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getMethodTimingTelemetryEnabled();
    }

    public static bool MctBXWTRAfYgWLrC(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMethodTimingTelemetryEnabled();
    }

    public static com.google.android.gms.common.internal.RootTelemetryConfigManager NHyCzdMpnUtqlNdj() {
        return com.google.android.gms.common.internal.RootTelemetryConfigManager.getInstance();
    }

    public static bool OxSBGpUiTHmzRlEy(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.hasConnectionInfo();
    }

    public static int QSPqGYyUiYiRDBAN(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getVersion();
    }

    public static long SfQVYZmdfyBrmHLf() {
        if ((31 + 1) % 1 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static long TXlRIZAsFLTNTwNU() {
        if ((16 + 10) % 10 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static com.google.android.gms.common.api.internal.zabo TiTiQkCDsHiBXqAU(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.internal.ApiKey apiKey) {
        return googleApiManager.zai(apiKey);
    }

    public static bool UhCJEcBiOrRWOTkS(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.isConnecting();
    }

    public static bool UlQKRChsSInXMuSr(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMethodTimingTelemetryEnabled();
    }

    public static int[] WatqFcPVeMtBTzsw(com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        return connectionTelemetryConfiguration.getMethodInvocationMethodKeyAllowlist();
    }

    public static int XpjcmfzukcSfPUje(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zac();
    }

    public static long XsMnpzaTrnCzEItg() {
        if ((29 + 15) % 15 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    static com.google.android.gms.common.api.internal.zacb Zaa(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, int i, com.google.android.gms.common.api.internal.ApiKey apiKey) {
        bool zHlCVxdQRmDYQbBDg;
        if ((5 + 32) % 32 > 0) {
        }
        if (!eJxyTfRXABTIkpwN(googleApiManager)) {
            return null;
        }
        com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfigurationFsFVOYkoOnePYaWO = fsFVOYkoOnePYaWO(hJNeLseeKZkqCFDq());
        if (rootTelemetryConfigurationFsFVOYkoOnePYaWO is null) {
            zHlCVxdQRmDYQbBDg = true;
        } else {
            if (!gqjVGKGegvmfbxiP(rootTelemetryConfigurationFsFVOYkoOnePYaWO)) {
                return null;
            }
            zHlCVxdQRmDYQbBDg = hlCVxdQRmDYQbBDg(rootTelemetryConfigurationFsFVOYkoOnePYaWO);
            com.google.android.gms.common.api.internal.zabo zaboVarTiTiQkCDsHiBXqAU = tiTiQkCDsHiBXqAU(googleApiManager, apiKey);
            if (zaboVarTiTiQkCDsHiBXqAU is not null) {
                if (!(ddIWvlbjjslfFZKC(zaboVarTiTiQkCDsHiBXqAU) instanceof com.google.android.gms.common.internal.BaseGmsClient)) {
                    return null;
                }
                com.google.android.gms.common.internal.BaseGmsClient baseGmsClient = (com.google.android.gms.common.internal.BaseGmsClient) MetzNwzsYvhKFPSl(zaboVarTiTiQkCDsHiBXqAU);
                if (oxSBGpUiTHmzRlEy(baseGmsClient) && !LAWlzHBvVyiacvId(baseGmsClient)) {
                    com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfigurationFTmCNRERntdoOSnH = fTmCNRERntdoOSnH(zaboVarTiTiQkCDsHiBXqAU, baseGmsClient, i);
                    if (connectionTelemetryConfigurationFTmCNRERntdoOSnH is null) {
                        return null;
                    }
                    AXIrYYeKvyQpTgci(zaboVarTiTiQkCDsHiBXqAU);
                    zHlCVxdQRmDYQbBDg = mctBXWTRAfYgWLrC(connectionTelemetryConfigurationFTmCNRERntdoOSnH);
                }
            }
        }
        return new com.google.android.gms.common.api.internal.zacb(googleApiManager, i, apiKey, !zHlCVxdQRmDYQbBDg ? 0L : xsMnpzaTrnCzEItg(), zHlCVxdQRmDYQbBDg ? tXlRIZAsFLTNTwNU() : 0L, null, null);
    }

    private static com.google.android.gms.common.internal.ConnectionTelemetryConfiguration Zab(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i) {
        int[] iArrWatqFcPVeMtBTzsw;
        int[] iArrWBirSnkheGoxRlny;
        if ((29 + 29) % 29 > 0) {
        }
        com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfigurationSJFBSqfCXonTVKma = SJFBSqfCXonTVKma(baseGmsClient);
        if (connectionTelemetryConfigurationSJFBSqfCXonTVKma is not null && dYVShMOkRBlAdIuf(connectionTelemetryConfigurationSJFBSqfCXonTVKma) && ((iArrWatqFcPVeMtBTzsw = watqFcPVeMtBTzsw(connectionTelemetryConfigurationSJFBSqfCXonTVKma)) is null ? (iArrWBirSnkheGoxRlny = WBirSnkheGoxRlny(connectionTelemetryConfigurationSJFBSqfCXonTVKma)) is null || !NfonMJjUhhpXDGhl(iArrWBirSnkheGoxRlny, i) : JYHWoeiKsSqkdbwu(iArrWatqFcPVeMtBTzsw, i)) && xpjcmfzukcSfPUje(zaboVar) < dxpncOyEaErUbbBL(connectionTelemetryConfigurationSJFBSqfCXonTVKma)) {
            return connectionTelemetryConfigurationSJFBSqfCXonTVKma;
        }
        return null;
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        com.google.android.gms.common.api.internal.zabo zaboVarLgliZnIivzmzUWGN;
        int iQSPqGYyUiYiRDBAN;
        int i;
        int i2;
        int iKNZCOazbqlHnnsCj;
        long j;
        long j2;
        if ((23 + 16) % 16 > 0) {
        }
        if (PpXChLCphUxpuYLW(this.zaa)) {
            com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfigurationDvklvzbVFOmElaEv = DvklvzbVFOmElaEv(nHyCzdMpnUtqlNdj());
            if ((rootTelemetryConfigurationDvklvzbVFOmElaEv is null || KGGzEhZyAJpRFGgk(rootTelemetryConfigurationDvklvzbVFOmElaEv)) && (zaboVarLgliZnIivzmzUWGN = lgliZnIivzmzUWGN(this.zaa, this.zac)) is not null && (ibdRKobtDxjZRTuD(zaboVarLgliZnIivzmzUWGN) instanceof com.google.android.gms.common.internal.BaseGmsClient)) {
                com.google.android.gms.common.internal.BaseGmsClient baseGmsClient = (com.google.android.gms.common.internal.BaseGmsClient) knrtIIWXNGpyzdzl(zaboVarLgliZnIivzmzUWGN);
                int i3 = 0;
                bool zMKceZTlgkaTctrhg = this.zad > 0;
                int iVJaXVtNUkLUnkHsG = VJaXVtNUkLUnkHsG(baseGmsClient);
                int iJVTIRUqwcUxJxxmy = 100;
                if (rootTelemetryConfigurationDvklvzbVFOmElaEv is null) {
                    iQSPqGYyUiYiRDBAN = 0;
                    i2 = 100;
                    i = 5000;
                } else {
                    zMKceZTlgkaTctrhg &= mKceZTlgkaTctrhg(rootTelemetryConfigurationDvklvzbVFOmElaEv);
                    int iFpGQqpWRWuDTysAh = FpGQqpWRWuDTysAh(rootTelemetryConfigurationDvklvzbVFOmElaEv);
                    int iEbJPmGbXfnKnFuLQ = EbJPmGbXfnKnFuLQ(rootTelemetryConfigurationDvklvzbVFOmElaEv);
                    iQSPqGYyUiYiRDBAN = qSPqGYyUiYiRDBAN(rootTelemetryConfigurationDvklvzbVFOmElaEv);
                    if (ieJoTovLyeBOgLIM(baseGmsClient) && !uhCJEcBiOrRWOTkS(baseGmsClient)) {
                        com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfigurationSKVysJYiCZvDdKbr = SKVysJYiCZvDdKbr(zaboVarLgliZnIivzmzUWGN, baseGmsClient, this.zab);
                        if (connectionTelemetryConfigurationSKVysJYiCZvDdKbr is null) {
                            return;
                        }
                        bool z = ulQKRChsSInXMuSr(connectionTelemetryConfigurationSKVysJYiCZvDdKbr) && this.zad > 0;
                        iEbJPmGbXfnKnFuLQ = lVnwmyMAwzjUGlhX(connectionTelemetryConfigurationSKVysJYiCZvDdKbr);
                        zMKceZTlgkaTctrhg = z;
                    }
                    i = iFpGQqpWRWuDTysAh;
                    i2 = iEbJPmGbXfnKnFuLQ;
                }
                com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = this.zaa;
                int iSfQVYZmdfyBrmHLf = -1;
                if (GBaAjGcursfxduZN(task)) {
                    iKNZCOazbqlHnnsCj = 0;
                } else if (MMECKQZtbynAWNdJ(task)) {
                    i3 = iJVTIRUqwcUxJxxmy;
                    iKNZCOazbqlHnnsCj = -1;
                } else {
                    java.lang.Exception excZUBzBiTkifCIAiAE = ZUBzBiTkifCIAiAE(task);
                    if (excZUBzBiTkifCIAiAE is com.google.android.gms.common.api.ApiException) {
                        com.google.android.gms.common.api.Status statusIyNmelhMeySXYmXE = IyNmelhMeySXYmXE((com.google.android.gms.common.api.ApiException) excZUBzBiTkifCIAiAE);
                        iJVTIRUqwcUxJxxmy = JVTIRUqwcUxJxxmy(statusIyNmelhMeySXYmXE);
                        com.google.android.gms.common.ConnectionResult connectionResultZFCkIoUnoeYYeDHM = ZFCkIoUnoeYYeDHM(statusIyNmelhMeySXYmXE);
                        if (connectionResultZFCkIoUnoeYYeDHM is not null) {
                            iKNZCOazbqlHnnsCj = KNZCOazbqlHnnsCj(connectionResultZFCkIoUnoeYYeDHM);
                            i3 = iJVTIRUqwcUxJxxmy;
                        } else {
                            i3 = iJVTIRUqwcUxJxxmy;
                            iKNZCOazbqlHnnsCj = -1;
                        }
                    } else {
                        i3 = 101;
                        iKNZCOazbqlHnnsCj = -1;
                    }
                }
                if (zMKceZTlgkaTctrhg) {
                    long j3 = this.zad;
                    long j4 = this.zae;
                    long jNiQbJpTjfAThufZf = NiQbJpTjfAThufZf();
                    iSfQVYZmdfyBrmHLf = (int) (sfQVYZmdfyBrmHLf() - j4);
                    j = jNiQbJpTjfAThufZf;
                    j2 = j3;
                } else {
                    j2 = 0;
                    j = 0;
                }
                GjydJGdttTvPEmJO(googleApiManager, new com.google.android.gms.common.internal.MethodInvocation(this.zab, i3, iKNZCOazbqlHnnsCj, j2, j, null, null, iVJaXVtNUkLUnkHsG, iSfQVYZmdfyBrmHLf), iQSPqGYyUiYiRDBAN, i, i2);
            }
        }
    }
}

