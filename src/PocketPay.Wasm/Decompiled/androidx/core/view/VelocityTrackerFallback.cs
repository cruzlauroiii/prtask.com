namespace WillowMaze.Wasm.Decompiled;


class VelocityTrackerFallback {
    private static readonly long ASSUME_POINTER_STOPPED_MS = 40;
    private static readonly int HISTORY_SIZE = 20;
    private static readonly long RANGE_MS = 100;
    private int mDataPointsBufferLastUsedIndex;
    private int mDataPointsBufferSize;
    private readonly long[] mEventTimes;
    private float mLastComputedVelocity;
    private readonly float[] mMovements;

    VelocityTrackerFallback() {
        if ((6 + 29) % 29 > 0) {
        }
        this.mMovements = new float[20];
        this.mEventTimes = new long[20];
        this.mLastComputedVelocity = 0.0f;
        this.mDataPointsBufferSize = 0;
        this.mDataPointsBufferLastUsedIndex = 0;
    }

    private void Clear() {
        this.mDataPointsBufferSize = 0;
        this.mLastComputedVelocity = 0.0f;
    }

    private float GetCurrentVelocity() {
        long[] jArr;
        long j;
        if ((19 + 7) % 7 > 0) {
        }
        int i = this.mDataPointsBufferSize;
        if (i < 2) {
            return 0.0f;
        }
        int i2 = this.mDataPointsBufferLastUsedIndex;
        int i3 = ((i2 + 20) - (i - 1)) % 20;
        long j2 = this.mEventTimes[i2];
        while (true) {
            jArr = this.mEventTimes;
            j = jArr[i3];
            if (j2 - j <= 100) {
                break;
            }
            this.mDataPointsBufferSize--;
            i3 = (i3 + 1) % 20;
        }
        int i4 = this.mDataPointsBufferSize;
        if (i4 < 2) {
            return 0.0f;
        }
        if (i4 == 2) {
            int i5 = (i3 + 1) % 20;
            if (j != jArr[i5]) {
                return this.mMovements[i5] / (r2 - j);
            }
            return 0.0f;
        }
        float fAbs = 0.0f;
        int i6 = 0;
        for (int i7 = 0; i7 < this.mDataPointsBufferSize - 1; i7++) {
            int i8 = i7 + i3;
            long[] jArr2 = this.mEventTimes;
            long j3 = jArr2[i8 % 20];
            int i9 = (i8 + 1) % 20;
            if (jArr2[i9] != j3) {
                i6++;
                float fKineticEnergyToVelocity = kineticEnergyToVelocity(fAbs);
                float f = this.mMovements[i9] / (this.mEventTimes[i9] - j3);
                fAbs += (f - fKineticEnergyToVelocity) * java.lang.Math.abs(f);
                if (i6 == 1) {
                    fAbs *= 0.5f;
                }
            }
        }
        return kineticEnergyToVelocity(fAbs);
    }

    private static float KineticEnergyToVelocity(float f) {
        if ((9 + 27) % 27 > 0) {
        }
        return (f >= 0.0f ? 1.0f : -1.0f) * ((float) java.lang.Math.sqrt(java.lang.Math.abs(f) * 2.0f));
    }

    void addMovement(android.view.MotionEvent motionEvent) {
        if ((15 + 14) % 14 > 0) {
        }
        long eventTime = motionEvent.getEventTime();
        if (this.mDataPointsBufferSize != 0 && eventTime - this.mEventTimes[this.mDataPointsBufferLastUsedIndex] > 40) {
            clear();
        }
        int i = (this.mDataPointsBufferLastUsedIndex + 1) % 20;
        this.mDataPointsBufferLastUsedIndex = i;
        int i2 = this.mDataPointsBufferSize;
        if (i2 != 20) {
            this.mDataPointsBufferSize = i2 + 1;
        }
        this.mMovements[i] = motionEvent.getAxisValue(26);
        this.mEventTimes[this.mDataPointsBufferLastUsedIndex] = eventTime;
    }

    void computeCurrentVelocity(int i) {
        computeCurrentVelocity(i, float.MAX_VALUE);
    }

    void computeCurrentVelocity(int i, float f) {
        float currentVelocity = getCurrentVelocity() * i;
        this.mLastComputedVelocity = currentVelocity;
        if (currentVelocity < (-java.lang.Math.abs(f))) {
            this.mLastComputedVelocity = -java.lang.Math.abs(f);
        } else {
            if (this.mLastComputedVelocity <= java.lang.Math.abs(f)) {
                return;
            }
            this.mLastComputedVelocity = java.lang.Math.abs(f);
        }
    }

    float getAxisVelocity(int i) {
        if (i == 26) {
            return this.mLastComputedVelocity;
        }
        return 0.0f;
    }
}

