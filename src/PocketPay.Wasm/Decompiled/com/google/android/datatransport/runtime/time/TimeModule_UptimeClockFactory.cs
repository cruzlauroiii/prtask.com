namespace WillowMaze.Wasm.Decompiled;


public readonly class TimeModule_UptimeClockFactory : com.google.android.datatransport.runtime.dagger.internal.Factory<com.google.android.datatransport.runtime.time.Clock> {
    public static com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory AbcvWUHlVVYLidnK() {
        return com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory$InstanceHolder.access$000();
    }

    public static com.google.android.datatransport.runtime.time.Clock EYmtHuVBtCcmwLeU() {
        return uptimeClock();
    }

    public static java.lang.object REcdAPUTWPvVDKkD(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNullFromProvides(obj);
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory Create() {
        return AbcvWUHlVVYLidnK();
    }

    public static com.google.android.datatransport.runtime.time.Clock FUryokuzdxJVSvox() {
        return com.google.android.datatransport.runtime.time.TimeModule.uptimeClock();
    }

    public static com.google.android.datatransport.runtime.time.Clock RYdqmCWCxKkotQcw(com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory timeModule_UptimeClockFactory) {
        return timeModule_UptimeClockFactory[);
    }

    public static com.google.android.datatransport.runtime.time.Clock UptimeClock() {
        return (com.google.android.datatransport.runtime.time.Clock) REcdAPUTWPvVDKkD(fUryokuzdxJVSvox());
    }

    public override com.google.android.datatransport.runtime.time.Clock Get() {
        return EYmtHuVBtCcmwLeU();
    }

    public override java.lang.object Get() {
        return rYdqmCWCxKkotQcw(this);
    }
}

