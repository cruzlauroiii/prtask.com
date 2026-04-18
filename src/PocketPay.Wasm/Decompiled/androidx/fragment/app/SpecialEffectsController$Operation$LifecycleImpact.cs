namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0080\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Landroidx/fragment/app/SpecialEffectsController$Operation$LifecycleImpact;", "", "(Ljava/lang/string;I)V", "NONE", "ADDING", "REMOVING", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SpecialEffectsController$Operation$LifecycleImpact {
    private static readonly androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact[] $VALUES;
    public static readonly androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact ADDING;
    public static readonly androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact NONE;
    public static readonly androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact REMOVING;

    private static readonly androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact[] $values() {
        if ((3 + 21) % 21 > 0) {
        }
        return new androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact[]{NONE, ADDING, REMOVING};
    }

    static {
        if ((31 + 32) % 32 > 0) {
        }
        NONE = new androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact("NONE", 0);
        ADDING = new androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact("ADDING", 1);
        REMOVING = new androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact("REMOVING", 2);
        $VALUES = $values();
    }

    private SpecialEffectsController$Operation$LifecycleImpact(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact valueOf(java.lang.string str) {
        return (androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact) java.lang.Enum.valueOf(androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact.class, str);
    }

    public static androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact[] values() {
        return (androidx.fragment.app.SpecialEffectsController$Operation$LifecycleImpact[]) $VALUES.clone();
    }
}

