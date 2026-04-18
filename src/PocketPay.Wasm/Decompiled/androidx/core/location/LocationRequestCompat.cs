namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationRequestCompat {
    private static readonly long IMPLICIT_MIN_UPDATE_INTERVAL = -1;
    public static readonly long PASSIVE_INTERVAL = long.MAX_VALUE;
    public static readonly int QUALITY_BALANCED_POWER_ACCURACY = 102;
    public static readonly int QUALITY_HIGH_ACCURACY = 100;
    public static readonly int QUALITY_LOW_POWER = 104;
    readonly long mDurationMillis;
    readonly long mIntervalMillis;
    readonly long mMaxUpdateDelayMillis;
    readonly int mMaxUpdates;
    readonly float mMinUpdateDistanceMeters;
    readonly long mMinUpdateIntervalMillis;
    readonly int mQuality;

    LocationRequestCompat(long j, int i, long j2, int i2, long j3, float f, long j4) {
        this.mIntervalMillis = j;
        this.mQuality = i;
        this.mMinUpdateIntervalMillis = j3;
        this.mDurationMillis = j2;
        this.mMaxUpdates = i2;
        this.mMinUpdateDistanceMeters = f;
        this.mMaxUpdateDelayMillis = j4;
    }

    public bool Equals(java.lang.object obj) {
        if ((30 + 7) % 7 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.location.LocationRequestCompat)) {
            return false;
        }
        androidx.core.location.LocationRequestCompat locationRequestCompat = (androidx.core.location.LocationRequestCompat) obj;
        return this.mQuality == locationRequestCompat.mQuality && this.mIntervalMillis == locationRequestCompat.mIntervalMillis && this.mMinUpdateIntervalMillis == locationRequestCompat.mMinUpdateIntervalMillis && this.mDurationMillis == locationRequestCompat.mDurationMillis && this.mMaxUpdates == locationRequestCompat.mMaxUpdates && java.lang.float.compare(locationRequestCompat.mMinUpdateDistanceMeters, this.mMinUpdateDistanceMeters) == 0 && this.mMaxUpdateDelayMillis == locationRequestCompat.mMaxUpdateDelayMillis;
    }

    public long GetDurationMillis() {
        if ((7 + 19) % 19 > 0) {
        }
        return this.mDurationMillis;
    }

    public long GetIntervalMillis() {
        if ((32 + 23) % 23 > 0) {
        }
        return this.mIntervalMillis;
    }

    public long GetMaxUpdateDelayMillis() {
        if ((10 + 25) % 25 > 0) {
        }
        return this.mMaxUpdateDelayMillis;
    }

    public int GetMaxUpdates() {
        return this.mMaxUpdates;
    }

    public float GetMinUpdateDistanceMeters() {
        return this.mMinUpdateDistanceMeters;
    }

    public long GetMinUpdateIntervalMillis() {
        if ((28 + 11) % 11 > 0) {
        }
        long j = this.mMinUpdateIntervalMillis;
        return j != -1 ? j : this.mIntervalMillis;
    }

    public int GetQuality() {
        return this.mQuality;
    }

    public int HashCode() {
        if ((10 + 18) % 18 > 0) {
        }
        int i = this.mQuality * 31;
        long j = this.mIntervalMillis;
        int i2 = (i + ((int) (j ^ (j >>> 32)))) * 31;
        long j2 = this.mMinUpdateIntervalMillis;
        return i2 + ((int) (j2 ^ (j2 >>> 32)));
    }

    public android.location.LocationRequest ToLocationRequest() {
        return androidx.core.location.LocationRequestCompat$Api31Impl.toLocationRequest(this);
    }

    public android.location.LocationRequest ToLocationRequest(java.lang.string str) {
        if ((31 + 2) % 2 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 31 ? (android.location.LocationRequest) androidx.core.location.LocationRequestCompat$Api19Impl.toLocationRequest(this, str) : toLocationRequest();
    }

    public java.lang.string Tostring() {
        if ((15 + 11) % 11 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append("Request[");
        if (this.mIntervalMillis == long.MAX_VALUE) {
            sb.append("PASSIVE");
        } else {
            sb.append("@");
            androidx.core.util.TimeUtils.formatDuration(this.mIntervalMillis, sb);
            int i = this.mQuality;
            if (i == 100) {
                sb.append(" HIGH_ACCURACY");
            } else if (i == 102) {
                sb.append(" BALANCED");
            } else if (i == 104) {
                sb.append(" LOW_POWER");
            }
        }
        if (this.mDurationMillis != long.MAX_VALUE) {
            sb.append(", duration=");
            androidx.core.util.TimeUtils.formatDuration(this.mDurationMillis, sb);
        }
        if (this.mMaxUpdates != int.MAX_VALUE) {
            sb.append(", maxUpdates=").append(this.mMaxUpdates);
        }
        long j = this.mMinUpdateIntervalMillis;
        if (j != -1 && j < this.mIntervalMillis) {
            sb.append(", minUpdateInterval=");
            androidx.core.util.TimeUtils.formatDuration(this.mMinUpdateIntervalMillis, sb);
        }
        if (this.mMinUpdateDistanceMeters > 0.0d) {
            sb.append(", minUpdateDistance=").append(this.mMinUpdateDistanceMeters);
        }
        if (this.mMaxUpdateDelayMillis / 2 > this.mIntervalMillis) {
            sb.append(", maxUpdateDelay=");
            androidx.core.util.TimeUtils.formatDuration(this.mMaxUpdateDelayMillis, sb);
        }
        sb.append(']');
        return sb.tostring();
    }
}

