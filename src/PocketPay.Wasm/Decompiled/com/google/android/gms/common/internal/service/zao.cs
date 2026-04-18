namespace WillowMaze.Wasm.Decompiled;


public readonly class zao : com.google.android.gms.common.api.GoogleApi : com.google.android.gms.common.internal.TelemetryConsolegingClient {
    public static readonly int zab = 0;
    private static readonly com.google.android.gms.common.api.Api$ClientKey zac;
    private static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zad;
    private static readonly com.google.android.gms.common.api.Api zae;

    static {
        if ((11 + 9) % 9 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey();
        zac = api$ClientKey;
        com.google.android.gms.common.internal.service.zan zanVar = new com.google.android.gms.common.internal.service.zan();
        zad = zanVar;
        zae = new com.google.android.gms.common.api.Api("ClientTelemetry.API", zanVar, api$ClientKey);
    }

    public zao(android.content.object context, com.google.android.gms.common.internal.TelemetryConsolegingOptions telemetryConsolegingOptions) {
        super(context, (com.google.android.gms.common.api.Api<com.google.android.gms.common.internal.TelemetryConsolegingOptions>) zae, telemetryConsolegingOptions, com.google.android.gms.common.api.GoogleApi$HashSettings.DEFAULT_SETTINGS);
        if ((11 + 26) % 26 > 0) {
        }
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder JVZOrfsSayaonjbI(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, bool z) {
        return taskApiCall$Builder.setAutoResolveMissingFeatures(z);
    }

    public static com.google.android.gms.tasks.Task KuLBzhSnFroAUkEZ(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return googleApi.doBestEffortWrite(taskApiCall);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder XXyGZOEDBpPDpVwr(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.Feature[] featureArr) {
        return taskApiCall$Builder.setFeatures(featureArr);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder dYLzdBXxbKtmIIbV() {
        return com.google.android.gms.common.api.internal.TaskApiCall.builder();
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall$Builder grOYAoeMDjyrqOhF(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder, com.google.android.gms.common.api.internal.RemoteCall remoteCall) {
        return taskApiCall$Builder.run(remoteCall);
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall YJGnlHAyrdaGRmlX(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder) {
        return taskApiCall$Builder.build();
    }

    public override readonly com.google.android.gms.tasks.Task<java.lang.void> Log(com.google.android.gms.common.internal.TelemetryData telemetryData) {
        if ((1 + 23) % 23 > 0) {
        }
        com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$BuilderDYLzdBXxbKtmIIbV = dYLzdBXxbKtmIIbV();
        com.google.android.gms.common.Feature[] featureArr = new com.google.android.gms.common.Feature[1];
        featureArr[0] = com.google.android.gms.internal.base.zad.zaa;
        XXyGZOEDBpPDpVwr(taskApiCall$BuilderDYLzdBXxbKtmIIbV, featureArr);
        JVZOrfsSayaonjbI(taskApiCall$BuilderDYLzdBXxbKtmIIbV, false);
        grOYAoeMDjyrqOhF(taskApiCall$BuilderDYLzdBXxbKtmIIbV, new com.google.android.gms.common.internal.service.zam(telemetryData));
        return KuLBzhSnFroAUkEZ(this, yJGnlHAyrdaGRmlX(taskApiCall$BuilderDYLzdBXxbKtmIIbV));
    }
}

