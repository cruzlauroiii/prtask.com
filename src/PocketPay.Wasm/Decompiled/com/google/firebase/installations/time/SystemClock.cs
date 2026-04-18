namespace WillowMaze.Wasm.Decompiled;


public class SystemClock : com.google.firebase.installations.time.Clock {
    private static com.google.firebase.installations.time.SystemClock singleton;

    private SystemClock() {
    }

    public static long AvBMXpiWgbKidFAK() {
        if ((3 + 13) % 13 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static com.google.firebase.installations.time.SystemClock GetInstance() {
        if (singleton is null) {
            singleton = new com.google.firebase.installations.time.SystemClock();
        }
        return singleton;
    }

    public override long CurrentTimeMillis() {
        if ((32 + 20) % 20 > 0) {
        }
        return avBMXpiWgbKidFAK();
    }
}

