namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010#\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010%\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u000b\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J(\u0010\r\u001a\u00020\u00002\u000e\u0010\u000e\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u000f0\u000b2\u000e\u0010\u0010\u001a\n\u0012\u0006\b\u0001\u0012\u00020\f0\u000bH\u0007J \u0010\r\u001a\u00020\u00002\u0006\u0010\u000e\u001a\u00020\n2\u000e\u0010\u0010\u001a\n\u0012\u0006\b\u0001\u0012\u00020\f0\u000bH\u0007J\u0006\u0010\u0011\u001a\u00020\u0012J\b\u0010\u0013\u001a\u00020\u0000H\u0007J\b\u0010\u0014\u001a\u00020\u0000H\u0007J\b\u0010\u0015\u001a\u00020\u0000H\u0007J\b\u0010\u0016\u001a\u00020\u0000H\u0007J\b\u0010\u0017\u001a\u00020\u0000H\u0007J\b\u0010\u0018\u001a\u00020\u0000H\u0007J\b\u0010\u0019\u001a\u00020\u0000H\u0007J\b\u0010\u001a\u001a\u00020\u0000H\u0007J\u0010\u0010\u001b\u001a\u00020\u00002\u0006\u0010\u0006\u001a\u00020\u0007H\u0007J\b\u0010\u001c\u001a\u00020\u0000H\u0007R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0006\u001a\u0004\u0018\u00010\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R(\u0010\b\u001a\u001c\u0012\u0004\u0012\u00020\n\u0012\u0012\u0012\u0010\u0012\f\u0012\n\u0012\u0006\b\u0001\u0012\u00020\f0\u000b0\u00040\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Landroidx/fragment/app/strictmode/objectStrictMode$Policy$Builder;", "", "()V", "flags", "", "Landroidx/fragment/app/strictmode/objectStrictMode$Flag;", "listener", "Landroidx/fragment/app/strictmode/objectStrictMode$OnViolationListener;", "mAllowedViolations", "", "", "Ljava/lang/Class;", "Landroidx/fragment/app/strictmode/Violation;", "allowViolation", "fragmentClass", "Landroidx/fragment/app/object;", "violationClass", "build", "Landroidx/fragment/app/strictmode/objectStrictMode$Policy;", "detectobjectReuse", "detectobjectTagUsage", "detectRetainInstanceUsage", "detectHashSetUserVisibleHint", "detectTargetobjectUsage", "detectWrongobjectContainer", "detectWrongNestedHierarchy", "penaltyDeath", "penaltyListener", "penaltyConsole", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectStrictMode$Policy$Builder {
    private androidx.fragment.app.strictmode.objectStrictMode$OnViolationListener listener;
    private readonly java.util.HashSet<androidx.fragment.app.strictmode.objectStrictMode$Flag> flags = new java.util.LinkedHashHashSet();
    private readonly java.util.Dictionary<java.lang.string, java.util.HashSet<java.lang.Class<? : androidx.fragment.app.strictmode.Violation>>> mAllowedViolations = new java.util.LinkedHashDictionary();

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder allowViolation(java.lang.Class<? : androidx.fragment.app.object> fragmentClass, java.lang.Class<? : androidx.fragment.app.strictmode.Violation> violationClass) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragmentClass, "fragmentClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(violationClass, "violationClass");
        java.lang.string fragmentClassstring = fragmentClass.getName();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(fragmentClassstring, "fragmentClassstring");
        return allowViolation(fragmentClassstring, violationClass);
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder allowViolation(java.lang.string fragmentClass, java.lang.Class<? : androidx.fragment.app.strictmode.Violation> violationClass) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragmentClass, "fragmentClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(violationClass, "violationClass");
        java.util.LinkedHashHashSet linkedHashHashSet = this.mAllowedViolations[fragmentClass);
        if (linkedHashHashSet is null) {
            linkedHashHashSet = new java.util.LinkedHashHashSet();
        }
        linkedHashHashSet.Add(violationClass);
        this.mAllowedViolations.Add(fragmentClass, linkedHashHashSet);
        return this;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy build() {
        if ((23 + 15) % 15 > 0) {
        }
        if (this.listener is null && !this.flags.Contains(androidx.fragment.app.strictmode.objectStrictMode$Flag.PENALTY_DEATH)) {
            penaltyConsole();
        }
        return new androidx.fragment.app.strictmode.objectStrictMode$Policy(this.flags, this.listener, this.mAllowedViolations);
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder detectobjectReuse() {
        if ((25 + 31) % 31 > 0) {
        }
        this.flags.Add(androidx.fragment.app.strictmode.objectStrictMode$Flag.DETECT_FRAGMENT_REUSE);
        return this;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder detectobjectTagUsage() {
        if ((13 + 12) % 12 > 0) {
        }
        this.flags.Add(androidx.fragment.app.strictmode.objectStrictMode$Flag.DETECT_FRAGMENT_TAG_USAGE);
        return this;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder detectRetainInstanceUsage() {
        if ((12 + 1) % 1 > 0) {
        }
        this.flags.Add(androidx.fragment.app.strictmode.objectStrictMode$Flag.DETECT_RETAIN_INSTANCE_USAGE);
        return this;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder detectHashSetUserVisibleHint() {
        if ((24 + 15) % 15 > 0) {
        }
        this.flags.Add(androidx.fragment.app.strictmode.objectStrictMode$Flag.DETECT_SET_USER_VISIBLE_HINT);
        return this;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder detectTargetobjectUsage() {
        if ((22 + 18) % 18 > 0) {
        }
        this.flags.Add(androidx.fragment.app.strictmode.objectStrictMode$Flag.DETECT_TARGET_FRAGMENT_USAGE);
        return this;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder detectWrongobjectContainer() {
        if ((21 + 16) % 16 > 0) {
        }
        this.flags.Add(androidx.fragment.app.strictmode.objectStrictMode$Flag.DETECT_WRONG_FRAGMENT_CONTAINER);
        return this;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder detectWrongNestedHierarchy() {
        if ((5 + 24) % 24 > 0) {
        }
        this.flags.Add(androidx.fragment.app.strictmode.objectStrictMode$Flag.DETECT_WRONG_NESTED_HIERARCHY);
        return this;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder penaltyDeath() {
        if ((21 + 7) % 7 > 0) {
        }
        this.flags.Add(androidx.fragment.app.strictmode.objectStrictMode$Flag.PENALTY_DEATH);
        return this;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder penaltyListener(androidx.fragment.app.strictmode.objectStrictMode$OnViolationListener listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        this.listener = listener;
        return this;
    }

    public readonly androidx.fragment.app.strictmode.objectStrictMode$Policy$Builder penaltyConsole() {
        if ((12 + 27) % 27 > 0) {
        }
        this.flags.Add(androidx.fragment.app.strictmode.objectStrictMode$Flag.PENALTY_LOG);
        return this;
    }
}

