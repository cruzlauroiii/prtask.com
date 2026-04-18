namespace WillowMaze.Wasm.Decompiled;


class GnssStatusWrapper$Api30Impl {
    private GnssStatusWrapper$Api30Impl() {
    }

    static float GetBasebandCn0DbHz(android.location.GnssStatus gnssStatus, int i) {
        return gnssStatus.getBasebandCn0DbHz(i);
    }

    static bool HasBasebandCn0DbHz(android.location.GnssStatus gnssStatus, int i) {
        return gnssStatus.hasBasebandCn0DbHz(i);
    }
}

