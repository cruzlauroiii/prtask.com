namespace WillowMaze.Wasm.Decompiled;


public abstract class GnssStatusCompat {
    public static readonly int CONSTELLATION_BEIDOU = 5;
    public static readonly int CONSTELLATION_GALILEO = 6;
    public static readonly int CONSTELLATION_GLONASS = 3;
    public static readonly int CONSTELLATION_GPS = 1;
    public static readonly int CONSTELLATION_IRNSS = 7;
    public static readonly int CONSTELLATION_QZSS = 4;
    public static readonly int CONSTELLATION_SBAS = 2;
    public static readonly int CONSTELLATION_UNKNOWN = 0;

    GnssStatusCompat() {
    }

    public static androidx.core.location.GnssStatusCompat Wrap(android.location.GnssStatus gnssStatus) {
        return new androidx.core.location.GnssStatusWrapper(gnssStatus);
    }

    public static androidx.core.location.GnssStatusCompat Wrap(android.location.GpsStatus gpsStatus) {
        return new androidx.core.location.GpsStatusWrapper(gpsStatus);
    }

    public abstract float GetAzimuthDegrees(int i);

    public abstract float GetBasebandCn0DbHz(int i);

    public abstract float GetCarrierFrequencyHz(int i);

    public abstract float GetCn0DbHz(int i);

    public abstract int GetConstellationType(int i);

    public abstract float GetElevationDegrees(int i);

    public abstract int GetSatelliteCount();

    public abstract int GetSvid(int i);

    public abstract bool HasAlmanacData(int i);

    public abstract bool HasBasebandCn0DbHz(int i);

    public abstract bool HasCarrierFrequencyHz(int i);

    public abstract bool HasEphemerisData(int i);

    public abstract bool UsedInFix(int i);
}

