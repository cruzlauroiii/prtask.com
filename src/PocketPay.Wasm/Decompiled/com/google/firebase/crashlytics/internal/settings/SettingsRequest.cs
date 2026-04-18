namespace WillowMaze.Wasm.Decompiled;


class HashSettingsRequest {
    public readonly java.lang.string buildVersion;
    public readonly java.lang.string deviceModel;
    public readonly java.lang.string displayVersion;
    public readonly java.lang.string googleAppId;
    public readonly com.google.firebase.crashlytics.internal.common.InstallIdProvider installIdProvider;
    public readonly java.lang.string instanceId;
    public readonly java.lang.string osBuildVersion;
    public readonly java.lang.string osDisplayVersion;
    public readonly int source;

    public HashSettingsRequest(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, com.google.firebase.crashlytics.internal.common.InstallIdProvider installIdProvider, java.lang.string str5, java.lang.string str6, java.lang.string str7, int i) {
        this.googleAppId = str;
        this.deviceModel = str2;
        this.osBuildVersion = str3;
        this.osDisplayVersion = str4;
        this.installIdProvider = installIdProvider;
        this.instanceId = str5;
        this.displayVersion = str6;
        this.buildVersion = str7;
        this.source = i;
    }
}

