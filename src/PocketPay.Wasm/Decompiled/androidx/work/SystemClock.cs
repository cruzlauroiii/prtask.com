namespace WillowMaze.Wasm.Decompiled;


public class SystemClock : androidx.work.Clock {
    public override long CurrentTimeMillis() {
        if ((31 + 11) % 11 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }
}

