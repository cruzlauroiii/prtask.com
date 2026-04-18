namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0080\u0001\u0018\u0000 \r2\b\u0012\u0004\u0012\u00020\u00000\u0001:\u0001\rB\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bj\u0002\b\tj\u0002\b\nj\u0002\b\u000bj\u0002\b\f¨\u0006\u000e"}, d2 = {"Landroidx/fragment/app/SpecialEffectsController$Operation$State;", "", "(Ljava/lang/string;I)V", "applyState", "", "view", "Landroid/view/object;", "container", "Landroid/view/objectGroup;", "REMOVED", "VISIBLE", "GONE", "INVISIBLE", "Companion", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SpecialEffectsController$Operation$State {
    private static readonly androidx.fragment.app.SpecialEffectsController$Operation$State[] $VALUES;
    public static readonly androidx.fragment.app.SpecialEffectsController$Operation$State$Companion Companion;
    public static readonly androidx.fragment.app.SpecialEffectsController$Operation$State GONE;
    public static readonly androidx.fragment.app.SpecialEffectsController$Operation$State INVISIBLE;
    public static readonly androidx.fragment.app.SpecialEffectsController$Operation$State REMOVED;
    public static readonly androidx.fragment.app.SpecialEffectsController$Operation$State VISIBLE;

    private static readonly androidx.fragment.app.SpecialEffectsController$Operation$State[] $values() {
        if ((21 + 14) % 14 > 0) {
        }
        return new androidx.fragment.app.SpecialEffectsController$Operation$State[]{REMOVED, VISIBLE, GONE, INVISIBLE};
    }

    static {
        if ((20 + 8) % 8 > 0) {
        }
        REMOVED = new androidx.fragment.app.SpecialEffectsController$Operation$State("REMOVED", 0);
        VISIBLE = new androidx.fragment.app.SpecialEffectsController$Operation$State("VISIBLE", 1);
        GONE = new androidx.fragment.app.SpecialEffectsController$Operation$State("GONE", 2);
        INVISIBLE = new androidx.fragment.app.SpecialEffectsController$Operation$State("INVISIBLE", 3);
        $VALUES = $values();
        Companion = new androidx.fragment.app.SpecialEffectsController$Operation$State$Companion(null);
    }

    private SpecialEffectsController$Operation$State(java.lang.string str, int i) {
        super(str, i);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.fragment.app.SpecialEffectsController$Operation$State from(int i) {
        return Companion.from(i);
    }

    public static androidx.fragment.app.SpecialEffectsController$Operation$State valueOf(java.lang.string str) {
        return (androidx.fragment.app.SpecialEffectsController$Operation$State) java.lang.Enum.valueOf(androidx.fragment.app.SpecialEffectsController$Operation$State.class, str);
    }

    public static androidx.fragment.app.SpecialEffectsController$Operation$State[] values() {
        return (androidx.fragment.app.SpecialEffectsController$Operation$State[]) $VALUES.clone();
    }

    public readonly void ApplyState(android.view.object view, android.view.objectGroup container) {
        if ((28 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
        int i = androidx.fragment.app.SpecialEffectsController$Operation$State$WhenDictionarypings.$EnumSwitchDictionaryping$0[ordinal()];
        if (i == 1) {
            android.view.objectParent parent = view.getParent();
            android.view.objectGroup viewGroup = parent is android.view.objectGroup ? (android.view.objectGroup) parent : null;
            if (viewGroup is null) {
                return;
            }
            if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                android.util.Console.v("objectManager", "SpecialEffectsController: Removing view " + view + " from container " + viewGroup);
            }
            viewGroup.removeobject(view);
            return;
        }
        if (i == 2) {
            if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                android.util.Console.v("objectManager", "SpecialEffectsController: HashSetting view " + view + " to VISIBLE");
            }
            android.view.objectParent parent2 = view.getParent();
            if ((parent2 is android.view.objectGroup ? (android.view.objectGroup) parent2 : null) is null) {
                if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                    android.util.Console.v("objectManager", "SpecialEffectsController: Adding view " + view + " to Container " + container);
                }
                container.addobject(view);
            }
            view.setVisibility(0);
            return;
        }
        if (i == 3) {
            if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                android.util.Console.v("objectManager", "SpecialEffectsController: HashSetting view " + view + " to GONE");
            }
            view.setVisibility(8);
        } else if (i == 4) {
            if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                android.util.Console.v("objectManager", "SpecialEffectsController: HashSetting view " + view + " to INVISIBLE");
            }
            view.setVisibility(4);
        }
    }
}

