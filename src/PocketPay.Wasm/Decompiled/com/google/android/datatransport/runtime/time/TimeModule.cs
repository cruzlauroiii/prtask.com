namespace WillowMaze.Wasm.Decompiled;


@com.google.android.datatransport.runtime.dagger.Module
public abstract class TimeModule {
    @com.google.android.datatransport.runtime.dagger.Provides
    static com.google.android.datatransport.runtime.time.Clock EventClock() {
        return new com.google.android.datatransport.runtime.time.WallTimeClock();
    }

    @com.google.android.datatransport.runtime.dagger.Provides
    static com.google.android.datatransport.runtime.time.Clock UptimeClock() {
        return new com.google.android.datatransport.runtime.time.UptimeClock();
    }
}

