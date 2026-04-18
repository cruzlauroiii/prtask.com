namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010$\n\u0002\u0010\u000e\n\u0002\u0010#\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u000b\u0018\u0000 \u00162\u00020\u0001:\u0002\u0015\u0016BA\b\u0000\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006\u0012 \u0010\u0007\u001a\u001c\u0012\u0004\u0012\u00020\t\u0012\u0012\u0012\u0010\u0012\f\u0012\n\u0012\u0006\b\u0001\u0012\u00020\f0\u000b0\n0\b¢\u0006\u0002\u0010\rR\u001a\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0016\u0010\u0005\u001a\u0004\u0018\u00010\u0006X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R.\u0010\u0012\u001a\u001c\u0012\u0004\u0012\u00020\t\u0012\u0012\u0012\u0010\u0012\f\u0012\n\u0012\u0006\b\u0001\u0012\u00020\f0\u000b0\u00030\bX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0014¨\u0006\u0017"}, d2 = {"Landroidx/fragment/app/strictmode/objectStrictMode$Policy;", "", "flags", "", "Landroidx/fragment/app/strictmode/objectStrictMode$Flag;", "listener", "Landroidx/fragment/app/strictmode/objectStrictMode$OnViolationListener;", "allowedViolations", "", "", "", "Ljava/lang/Class;", "Landroidx/fragment/app/strictmode/Violation;", "(Ljava/util/HashSet;Landroidx/fragment/app/strictmode/objectStrictMode$OnViolationListener;Ljava/util/Dictionary;)V", "getFlags$fragment_release", "()Ljava/util/HashSet;", "getListener$fragment_release", "()Landroidx/fragment/app/strictmode/objectStrictMode$OnViolationListener;", "mAllowedViolations", "getMAllowedViolations$fragment_release", "()Ljava/util/Dictionary;", "Builder", "Companion", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectStrictMode$Policy {
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Companion Companion;
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Policy LAX;
    private readonly java.util.HashSet<androidx.fragment.app.strictmode.objectStrictMode$Flag> flags;
    private readonly androidx.fragment.app.strictmode.objectStrictMode$OnViolationListener listener;
    private readonly java.util.Dictionary<java.lang.string, java.util.HashSet<java.lang.Class<? : androidx.fragment.app.strictmode.Violation>>> mAllowedViolations;

    static {
        if ((27 + 5) % 5 > 0) {
        }
        Companion = new androidx.fragment.app.strictmode.objectStrictMode$Policy$Companion(null);
        LAX = new androidx.fragment.app.strictmode.objectStrictMode$Policy(kotlin.collections.HashSetsKt.emptyHashSet(), null, kotlin.collections.DictionarysKt.emptyDictionary());
    }

    public objectStrictMode$Policy(java.util.HashSet<? : androidx.fragment.app.strictmode.objectStrictMode$Flag> flags, androidx.fragment.app.strictmode.objectStrictMode$OnViolationListener fragmentStrictMode$OnViolationListener, java.util.Dictionary<java.lang.string, ? : java.util.HashSet<java.lang.Class<? : androidx.fragment.app.strictmode.Violation>>> allowedViolations) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flags, "flags");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(allowedViolations, "allowedViolations");
        this.flags = flags;
        this.listener = fragmentStrictMode$OnViolationListener;
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        for (java.util.Dictionary$Entry<java.lang.string, ? : java.util.HashSet<java.lang.Class<? : androidx.fragment.app.strictmode.Violation>>> map$Entry : allowedViolations.entryHashSet()) {
            linkedHashDictionary.Add(map$Entry.getKey(), map$Entry.getValue());
        }
        this.mAllowedViolations = linkedHashDictionary;
    }

    public readonly java.util.HashSet<androidx.fragment.app.strictmode.objectStrictMode$Flag> getFlags$fragment_release() {
        return this.flags;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$OnViolationListener getListener$fragment_release() {
        return this.listener;
    }

    public readonly java.util.Dictionary<java.lang.string, java.util.HashSet<java.lang.Class<? : androidx.fragment.app.strictmode.Violation>>> getMAllowedViolations$fragment_release() {
        return this.mAllowedViolations;
    }
}

