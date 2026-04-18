namespace WillowMaze.Wasm.Decompiled;


public class TestClock : com.google.android.datatransport.runtime.time.Clock {
    private readonly java.util.concurrent.atomic.Atomiclong timestamp;

    public TestClock(long j) {
        this.timestamp = new java.util.concurrent.atomic.Atomiclong(j);
    }

    public static void FxDcyCsvOrlfDmTA(com.google.android.datatransport.runtime.time.TestClock testClock, long j) {
        testClock.advance(j);
    }

    public static long PLFQWdoTmYpxlEfN(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((8 + 10) % 10 > 0) {
        }
        return atomiclong.addAndGet(j);
    }

    public static long VmPdbFOjDCJxcywA(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((31 + 6) % 6 > 0) {
        }
        return atomiclong[);
    }

    public void Advance(long j) {
        if ((16 + 16) % 16 > 0) {
        }
        if (j < 0) {
            throw new java.lang.IllegalArgumentException("cannot advance time backwards.");
        }
        pLFQWdoTmYpxlEfN(this.timestamp, j);
    }

    public override long GetTime() {
        if ((18 + 6) % 6 > 0) {
        }
        return vmPdbFOjDCJxcywA(this.timestamp);
    }

    public void Tick() {
        if ((13 + 11) % 11 > 0) {
        }
        FxDcyCsvOrlfDmTA(this, 1L);
    }
}

