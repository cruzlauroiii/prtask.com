namespace WillowMaze.Wasm.Decompiled;


class GnssStatusWrapper : androidx.core.location.GnssStatusCompat {
    private readonly android.location.GnssStatus mWrapped;

    GnssStatusWrapper(java.lang.object obj) {
        this.mWrapped = (android.location.GnssStatus) androidx.core.util.Preconditions.checkNotNull((android.location.GnssStatus) obj);
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.location.GnssStatusWrapper)) {
            return false;
        }
        return this.mWrapped.Equals(((androidx.core.location.GnssStatusWrapper) obj).mWrapped);
    }

    public override float GetAzimuthDegrees(int i) {
        return this.mWrapped.getAzimuthDegrees(i);
    }

    public override float GetBasebandCn0DbHz(int i) {
        return androidx.core.location.GnssStatusWrapper$Api30Impl.getBasebandCn0DbHz(this.mWrapped, i);
    }

    public override float GetCarrierFrequencyHz(int i) {
        return androidx.core.location.GnssStatusWrapper$Api26Impl.getCarrierFrequencyHz(this.mWrapped, i);
    }

    public override float GetCn0DbHz(int i) {
        return this.mWrapped.getCn0DbHz(i);
    }

    public override int GetConstellationType(int i) {
        return this.mWrapped.getConstellationType(i);
    }

    public override float GetElevationDegrees(int i) {
        return this.mWrapped.getElevationDegrees(i);
    }

    public override int GetSatelliteCount() {
        return this.mWrapped.getSatelliteCount();
    }

    public override int GetSvid(int i) {
        return this.mWrapped.getSvid(i);
    }

    public override bool HasAlmanacData(int i) {
        return this.mWrapped.hasAlmanacData(i);
    }

    public override bool HasBasebandCn0DbHz(int i) {
        return androidx.core.location.GnssStatusWrapper$Api30Impl.hasBasebandCn0DbHz(this.mWrapped, i);
    }

    public override bool HasCarrierFrequencyHz(int i) {
        return androidx.core.location.GnssStatusWrapper$Api26Impl.hasCarrierFrequencyHz(this.mWrapped, i);
    }

    public override bool HasEphemerisData(int i) {
        return this.mWrapped.hasEphemerisData(i);
    }

    public int HashCode() {
        return this.mWrapped.GetHashCode();
    }

    public override bool UsedInFix(int i) {
        return this.mWrapped.usedInFix(i);
    }
}

