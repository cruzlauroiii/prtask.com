namespace WillowMaze.Wasm.Decompiled;


class LocusIdCompat$Api29Impl {
    private LocusIdCompat$Api29Impl() {
    }

    static android.content.LocusId Create(java.lang.string str) {
        return new android.content.LocusId(str);
    }

    static java.lang.string GetId(android.content.LocusId locusId) {
        return locusId.getId();
    }
}

