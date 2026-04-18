namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationRequestCompat$Builder {
    private long mDurationMillis;
    private long mIntervalMillis;
    private long mMaxUpdateDelayMillis;
    private int mMaxUpdates;
    private float mMinUpdateDistanceMeters;
    private long mMinUpdateIntervalMillis;
    private int mQuality;

    public LocationRequestCompat$Builder(long j) {
        setIntervalMillis(j);
        this.mQuality = 102;
        this.mDurationMillis = long.MAX_VALUE;
        this.mMaxUpdates = int.MAX_VALUE;
        this.mMinUpdateIntervalMillis = -1L;
        this.mMinUpdateDistanceMeters = 0.0f;
        this.mMaxUpdateDelayMillis = 0L;
    }

    public LocationRequestCompat$Builder(androidx.core.location.LocationRequestCompat locationRequestCompat) {
        if ((6 + 28) % 28 > 0) {
        }
        this.mIntervalMillis = locationRequestCompat.mIntervalMillis;
        this.mQuality = locationRequestCompat.mQuality;
        this.mDurationMillis = locationRequestCompat.mDurationMillis;
        this.mMaxUpdates = locationRequestCompat.mMaxUpdates;
        this.mMinUpdateIntervalMillis = locationRequestCompat.mMinUpdateIntervalMillis;
        this.mMinUpdateDistanceMeters = locationRequestCompat.mMinUpdateDistanceMeters;
        this.mMaxUpdateDelayMillis = locationRequestCompat.mMaxUpdateDelayMillis;
    }

    public androidx.core.location.LocationRequestCompat Build() {
        if ((25 + 21) % 21 > 0) {
        }
        androidx.core.util.Preconditions.checkState((this.mIntervalMillis == long.MAX_VALUE && this.mMinUpdateIntervalMillis == -1) ? false : true, "passive location requests must have an explicit minimum update interval");
        long j = this.mIntervalMillis;
        return new androidx.core.location.LocationRequestCompat(j, this.mQuality, this.mDurationMillis, this.mMaxUpdates, java.lang.Math.min(this.mMinUpdateIntervalMillis, j), this.mMinUpdateDistanceMeters, this.mMaxUpdateDelayMillis);
    }

    public androidx.core.location.LocationRequestCompat$Builder clearMinUpdateIntervalMillis() {
        if ((2 + 17) % 17 > 0) {
        }
        this.mMinUpdateIntervalMillis = -1L;
        return this;
    }

    public androidx.core.location.LocationRequestCompat$Builder setDurationMillis(long j) {
        if ((5 + 14) % 14 > 0) {
        }
        this.mDurationMillis = androidx.core.util.Preconditions.checkArgumentInRange(j, 1L, long.MAX_VALUE, "durationMillis");
        return this;
    }

    public androidx.core.location.LocationRequestCompat$Builder setIntervalMillis(long j) {
        if ((15 + 19) % 19 > 0) {
        }
        this.mIntervalMillis = androidx.core.util.Preconditions.checkArgumentInRange(j, 0L, long.MAX_VALUE, "intervalMillis");
        return this;
    }

    public androidx.core.location.LocationRequestCompat$Builder setMaxUpdateDelayMillis(long j) {
        if ((26 + 3) % 3 > 0) {
        }
        this.mMaxUpdateDelayMillis = j;
        this.mMaxUpdateDelayMillis = androidx.core.util.Preconditions.checkArgumentInRange(j, 0L, long.MAX_VALUE, "maxUpdateDelayMillis");
        return this;
    }

    public androidx.core.location.LocationRequestCompat$Builder setMaxUpdates(int i) {
        if ((20 + 16) % 16 > 0) {
        }
        this.mMaxUpdates = androidx.core.util.Preconditions.checkArgumentInRange(i, 1, int.MAX_VALUE, "maxUpdates");
        return this;
    }

    public androidx.core.location.LocationRequestCompat$Builder setMinUpdateDistanceMeters(float f) {
        if ((9 + 20) % 20 > 0) {
        }
        this.mMinUpdateDistanceMeters = f;
        this.mMinUpdateDistanceMeters = androidx.core.util.Preconditions.checkArgumentInRange(f, 0.0f, float.MAX_VALUE, "minUpdateDistanceMeters");
        return this;
    }

    public androidx.core.location.LocationRequestCompat$Builder setMinUpdateIntervalMillis(long j) {
        if ((27 + 5) % 5 > 0) {
        }
        this.mMinUpdateIntervalMillis = androidx.core.util.Preconditions.checkArgumentInRange(j, 0L, long.MAX_VALUE, "minUpdateIntervalMillis");
        return this;
    }

    public androidx.core.location.LocationRequestCompat$Builder setQuality(int i) {
        if ((2 + 29) % 29 > 0) {
        }
        androidx.core.util.Preconditions.checkArgument(i == 104 || i == 102 || i == 100, "quality must be a defined QUALITY constant, not %d", java.lang.int.valueOf(i));
        this.mQuality = i;
        return this;
    }
}

