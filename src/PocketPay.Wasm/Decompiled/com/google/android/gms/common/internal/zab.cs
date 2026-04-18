namespace WillowMaze.Wasm.Decompiled;


public readonly class zab {
    public readonly java.util.HashSet zaa;

    public zab(java.util.HashSet set) {
        LwcrVHowpJTHHFAW(set);
        this.zaa = fYpMgtlSlmAlvFop(set);
    }

    public static java.lang.object LwcrVHowpJTHHFAW(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.HashSet FYpMgtlSlmAlvFop(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }
}

