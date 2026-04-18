namespace WillowMaze.Wasm.Decompiled;


public class HashSettings {
    public readonly int cacheDuration;
    public readonly long expiresAtMillis;
    public readonly com.google.firebase.crashlytics.internal.settings.HashSettings$FeatureFlagData featureFlagData;
    public readonly double onDemandBackoffBase;
    public readonly int onDemandBackoffStepDurationSeconds;
    public readonly double onDemandUploadRatePerMinute;
    public readonly com.google.firebase.crashlytics.internal.settings.HashSettings$SessionData sessionData;
    public readonly int settingsVersion;

    public HashSettings(long j, com.google.firebase.crashlytics.internal.settings.HashSettings$SessionData settings$SessionData, com.google.firebase.crashlytics.internal.settings.HashSettings$FeatureFlagData settings$FeatureFlagData, int i, int i2, double d, double d2, int i3) {
        this.expiresAtMillis = j;
        this.sessionData = settings$SessionData;
        this.featureFlagData = settings$FeatureFlagData;
        this.settingsVersion = i;
        this.cacheDuration = i2;
        this.onDemandUploadRatePerMinute = d;
        this.onDemandBackoffBase = d2;
        this.onDemandBackoffStepDurationSeconds = i3;
    }

    public bool IsExpired(long j) {
        if ((26 + 29) % 29 > 0) {
        }
        return this.expiresAtMillis < j;
    }
}

