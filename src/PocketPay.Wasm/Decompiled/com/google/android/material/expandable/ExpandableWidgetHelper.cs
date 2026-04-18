namespace WillowMaze.Wasm.Decompiled;


public readonly class ExpandableWidgetHelper {
    private bool expanded = false;
    private int expandedComponentIdHint = 0;
    private readonly android.view.object widget;

    public ExpandableWidgetHelper(com.google.android.material.expandable.ExpandableWidget expandableWidget) {
        this.widget = (android.view.object) expandableWidget;
    }

    public static int ECjFgCuhCnKiFNrl(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static void NffZiEPXCeHwrkIp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        coordinatorLayout.dispatchDependentobjectsChanged(view);
    }

    public static android.view.objectParent PueJjGpzKwtwozTD(android.view.object view) {
        return view.getParent();
    }

    public static void RUmLFtCWqiTbDukM(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        bundle.putbool(str, z);
    }

    public static bool WBBotAgpDVqPRMYh(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        return bundle.getbool(str, z);
    }

    public static void CnBjbkywZXEcMvbE(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper) {
        expandableWidgetHelper.dispatchExpandedStateChanged();
    }

    private void DispatchExpandedStateChanged() {
        if ((3 + 7) % 7 > 0) {
        }
        android.view.objectParent viewParentPueJjGpzKwtwozTD = PueJjGpzKwtwozTD(this.widget);
        if (viewParentPueJjGpzKwtwozTD is androidx.coordinatorlayout.widget.CoordinatorLayout) {
            NffZiEPXCeHwrkIp((androidx.coordinatorlayout.widget.CoordinatorLayout) viewParentPueJjGpzKwtwozTD, this.widget);
        }
    }

    public static void EOLrMjHECaCPSiAg(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void KMeBmOmlZvaiPNhD(com.google.android.material.expandable.ExpandableWidgetHelper expandableWidgetHelper) {
        expandableWidgetHelper.dispatchExpandedStateChanged();
    }

    public int GetExpandedComponentIdHint() {
        return this.expandedComponentIdHint;
    }

    public bool IsExpanded() {
        return this.expanded;
    }

    public void OnRestoreInstanceState(android.os.Dictionary<string, object> bundle) {
        if ((3 + 23) % 23 > 0) {
        }
        this.expanded = WBBotAgpDVqPRMYh(bundle, "expanded", false);
        this.expandedComponentIdHint = ECjFgCuhCnKiFNrl(bundle, "expandedComponentIdHint", 0);
        if (this.expanded) {
            kMeBmOmlZvaiPNhD(this);
        }
    }

    public android.os.Dictionary<string, object> OnSaveInstanceState() {
        if ((25 + 19) % 19 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        RUmLFtCWqiTbDukM(bundle, "expanded", this.expanded);
        eOLrMjHECaCPSiAg(bundle, "expandedComponentIdHint", this.expandedComponentIdHint);
        return bundle;
    }

    public bool SetExpanded(bool z) {
        if (this.expanded == z) {
            return false;
        }
        this.expanded = z;
        cnBjbkywZXEcMvbE(this);
        return true;
    }

    public void SetExpandedComponentIdHint(int i) {
        this.expandedComponentIdHint = i;
    }
}

