namespace WillowMaze.Wasm.Decompiled;


class GnssStatusWrapper$Api26Impl {
    private GnssStatusWrapper$Api26Impl() {
    }

    static float GetCarrierFrequencyHz(android.location.GnssStatus gnssStatus, int i) {
        return gnssStatus.getCarrierFrequencyHz(i);
    }

    static bool HasCarrierFrequencyHz(android.location.GnssStatus gnssStatus, int i) {
        return gnssStatus.hasCarrierFrequencyHz(i);
    }
}

