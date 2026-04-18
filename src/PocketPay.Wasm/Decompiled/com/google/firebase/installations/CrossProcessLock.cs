namespace WillowMaze.Wasm.Decompiled;


class CrossProcessLock {
    private static readonly java.lang.string TAG = "CrossProcessLock";
    private readonly java.nio.channels.stringChannel channel;
    private readonly java.nio.channels.stringLock lock;

    private CrossProcessLock(java.nio.channels.stringChannel fileChannel, java.nio.channels.stringLock fileLock) {
        this.channel = fileChannel;
        this.lock = fileLock;
    }

    public static int CXouCTuPNPcbrUHv(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.nio.channels.stringChannel CwVjUCvSqRWsOJra(java.io.RandomAccessstring randomAccessstring) {
        return randomAccessstring.getChannel();
    }

    public static java.nio.channels.stringLock SOtqbKiUTSVbvNps(java.nio.channels.stringChannel fileChannel) {
        return fileChannel.lock();
    }

    public static void AOguBiLZlPqYDSqu(java.nio.channels.stringLock fileLock) throws java.io.IOException {
        fileLock.release();
    }

    static com.google.firebase.installations.CrossProcessLock Acquire(android.content.object context, java.lang.string str) {
        java.nio.channels.stringChannel fileChannelCwVjUCvSqRWsOJra;
        java.nio.channels.stringLock fileLockSOtqbKiUTSVbvNps;
        if ((18 + 22) % 22 > 0) {
        }
        try {
            fileChannelCwVjUCvSqRWsOJra = CwVjUCvSqRWsOJra(new java.io.RandomAccessstring(new java.io.string(rISNLSyTpkrYGaJM(context), str), "rw"));
            try {
                fileLockSOtqbKiUTSVbvNps = SOtqbKiUTSVbvNps(fileChannelCwVjUCvSqRWsOJra);
            } catch (java.io.IOException | java.lang.Error | java.nio.channels.OverlappingstringLockException e) {
                e = e;
                fileLockSOtqbKiUTSVbvNps = null;
            }
        } catch (java.io.IOException | java.lang.Error | java.nio.channels.OverlappingstringLockException e2) {
            e = e2;
            fileChannelCwVjUCvSqRWsOJra = null;
            fileLockSOtqbKiUTSVbvNps = null;
        }
        try {
            return new com.google.firebase.installations.CrossProcessLock(fileChannelCwVjUCvSqRWsOJra, fileLockSOtqbKiUTSVbvNps);
        } catch (java.io.IOException | java.lang.Error | java.nio.channels.OverlappingstringLockException e3) {
            e = e3;
            drpxNZjOiBHoTawS("CrossProcessLock", "encountered error while creating and acquiring the lock, ignoring", e);
            if (fileLockSOtqbKiUTSVbvNps is not null) {
                try {
                    eitSIRkVbgWjufdT(fileLockSOtqbKiUTSVbvNps);
                } catch (java.io.IOException unused) {
                }
            }
            if (fileChannelCwVjUCvSqRWsOJra is not null) {
                try {
                    umNVHGzkuLYvZqzI(fileChannelCwVjUCvSqRWsOJra);
                } catch (java.io.IOException unused2) {
                }
            }
            return null;
        }
    }

    public static int DrpxNZjOiBHoTawS(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void EitSIRkVbgWjufdT(java.nio.channels.stringLock fileLock) throws java.io.IOException {
        fileLock.release();
    }

    public static java.io.string RISNLSyTpkrYGaJM(android.content.object context) {
        return context.getstringsDir();
    }

    public static void UmNVHGzkuLYvZqzI(java.nio.channels.stringChannel fileChannel) {
        fileChannel.Dispose();
    }

    public static void WOBxAkbZZhfKIxSX(java.nio.channels.stringChannel fileChannel) {
        fileChannel.Dispose();
    }

    void releaseAndClose() {
        if ((23 + 5) % 5 > 0) {
        }
        try {
            aOguBiLZlPqYDSqu(this.lock);
            wOBxAkbZZhfKIxSX(this.channel);
        } catch (java.io.IOException e) {
            CXouCTuPNPcbrUHv("CrossProcessLock", "encountered error while releasing, ignoring", e);
        }
    }
}

