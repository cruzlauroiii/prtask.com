namespace WillowMaze.Wasm.Decompiled;


class objectChooserobject$Callbacks : android.widget.Adapterobject$OnItemClickListener, android.view.object$OnClickListener, android.view.object$OnlongClickListener, android.widget.PopupWindow$OnDismissListener {
    readonly androidx.appcompat.widget.objectChooserobject this$0;

    objectChooserobject$Callbacks(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        this.this$0 = activityChooserobject;
    }

    public static int BKepoHOFWYPkpKXW(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter, int i) {
        return activityChooserobject$objectChooserobjectAdapter.getItemobjectType(i);
    }

    public static void HFZyMYAcXdOwPQdh(android.content.object context, android.content.object intent) {
        context.startobject(intent);
    }

    public static android.content.pm.ResolveInfo HKkBPWYsasQGHeaG(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        return activityChooserobject$objectChooserobjectAdapter.getDefaultobject();
    }

    public static android.content.object LbRRaTxXAfbOIWIe(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.getobject();
    }

    public static android.content.object ORQpWfIEqGnKPjpc(android.content.object intent, int i) {
        return intent.addFlags(i);
    }

    public static void PKKnEiHCWSxjlrWU(androidx.appcompat.widget.objectChooserobject$Callbacks activityChooserobject$Callbacks) {
        activityChooserobject$Callbacks.notifyOnDismissListener();
    }

    public static bool SkVhOAGLTMmTxAEZ(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        return activityChooserobject$objectChooserobjectAdapter.getShowDefaultobject();
    }

    public static androidx.appcompat.widget.objectChooserModel TMcgtPAQZurFtTWt(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        return activityChooserobject$objectChooserobjectAdapter.getDataModel();
    }

    public static void WGdjvXZfTaLNnaRm(androidx.core.view.ActionProvider actionProvider, bool z) {
        actionProvider.subUiVisibilityChanged(z);
    }

    public static int WdVGolrdUeBCDRJn(androidx.appcompat.widget.objectChooserModel activityChooserModel, android.content.pm.ResolveInfo resolveInfo) {
        return activityChooserModel.getobjectIndex(resolveInfo);
    }

    public static androidx.appcompat.widget.objectChooserModel XqwNzOXrcEhKHWzM(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        return activityChooserobject$objectChooserobjectAdapter.getDataModel();
    }

    public static void YhWcvNgCrSRKxrRt(androidx.appcompat.widget.objectChooserobject activityChooserobject, int i) {
        activityChooserobject.showPopupUnchecked(i);
    }

    public static void ZsgzpxfukqDnGYLJ(androidx.appcompat.widget.objectChooserobject activityChooserobject, int i) {
        activityChooserobject.showPopupUnchecked(i);
    }

    public static void APocoCUWuRNHdMga(android.content.object context, android.content.object intent) {
        context.startobject(intent);
    }

    public static bool BHugPdvbFbKsTRLr(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.dismissPopup();
    }

    public static void CHIbSKXjeCAlAAGc(android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        popupWindow$OnDismissListener.onDismiss();
    }

    public static android.content.object IhsYOxspWxKsfjip(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.getobject();
    }

    private void NotifyOnDismissListener() {
        if (this.this$0.mOnDismissListener is null) {
            return;
        }
        cHIbSKXjeCAlAAGc(this.this$0.mOnDismissListener);
    }

    public static android.content.object OevsmyxLKRlmSUou(androidx.appcompat.widget.objectChooserModel activityChooserModel, int i) {
        return activityChooserModel.chooseobject(i);
    }

    public static void OniwDuGxjMcIFCaR(androidx.appcompat.widget.objectChooserobject activityChooserobject, int i) {
        activityChooserobject.showPopupUnchecked(i);
    }

    public static int PeDTuZNBAqMmIfXN(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        return activityChooserobject$objectChooserobjectAdapter.getCount();
    }

    public static androidx.appcompat.widget.objectChooserModel QzvEfeXOOMrgsyvI(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        return activityChooserobject$objectChooserobjectAdapter.getDataModel();
    }

    public static androidx.appcompat.widget.objectChooserModel SukjdLETIqEnCyLr(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        return activityChooserobject$objectChooserobjectAdapter.getDataModel();
    }

    public static void UlSdIbElQxJGcNOc(androidx.appcompat.widget.objectChooserModel activityChooserModel, int i) {
        activityChooserModel.setDefaultobject(i);
    }

    public static android.content.object XteYgmzBqNtEAXKt(androidx.appcompat.widget.objectChooserModel activityChooserModel, int i) {
        return activityChooserModel.chooseobject(i);
    }

    public static android.widget.Adapter YytHcNtGtFtmUIfR(android.widget.Adapterobject adapterobject) {
        return adapterobject.getAdapter();
    }

    public static bool ZgysxnjbrBxzKQxw(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.dismissPopup();
    }

    public static android.content.object ZkhvsaMGEpicwbJw(android.content.object intent, int i) {
        return intent.addFlags(i);
    }

    public override void OnClick(android.view.object view) {
        if (view != this.this$0.mDefaultobjectButton) {
            if (view != this.this$0.mExpandobjectOverflowButton) {
                throw new java.lang.IllegalArgumentException();
            }
            this.this$0.mIsSelectingDefaultobject = false;
            androidx.appcompat.widget.objectChooserobject activityChooserobject = this.this$0;
            oniwDuGxjMcIFCaR(activityChooserobject, activityChooserobject.mInitialobjectCount);
            return;
        }
        zgysxnjbrBxzKQxw(this.this$0);
        android.content.object intentXteYgmzBqNtEAXKt = xteYgmzBqNtEAXKt(TMcgtPAQZurFtTWt(this.this$0.mAdapter), WdVGolrdUeBCDRJn(sukjdLETIqEnCyLr(this.this$0.mAdapter), HKkBPWYsasQGHeaG(this.this$0.mAdapter)));
        if (intentXteYgmzBqNtEAXKt is null) {
            return;
        }
        ORQpWfIEqGnKPjpc(intentXteYgmzBqNtEAXKt, 524288);
        HFZyMYAcXdOwPQdh(LbRRaTxXAfbOIWIe(this.this$0), intentXteYgmzBqNtEAXKt);
    }

    public override void OnDismiss() {
        PKKnEiHCWSxjlrWU(this);
        if (this.this$0.mProvider is null) {
            return;
        }
        WGdjvXZfTaLNnaRm(this.this$0.mProvider, false);
    }

    public override void OnItemClick(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        int iBKepoHOFWYPkpKXW = BKepoHOFWYPkpKXW((androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter) yytHcNtGtFtmUIfR(adapterobject), i);
        if (iBKepoHOFWYPkpKXW != 0) {
            if (iBKepoHOFWYPkpKXW != 1) {
                throw new java.lang.IllegalArgumentException();
            }
            YhWcvNgCrSRKxrRt(this.this$0, int.MAX_VALUE);
            return;
        }
        bHugPdvbFbKsTRLr(this.this$0);
        if (this.this$0.mIsSelectingDefaultobject) {
            if (i <= 0) {
                return;
            }
            ulSdIbElQxJGcNOc(XqwNzOXrcEhKHWzM(this.this$0.mAdapter), i);
            return;
        }
        if (!SkVhOAGLTMmTxAEZ(this.this$0.mAdapter)) {
            i++;
        }
        android.content.object intentOevsmyxLKRlmSUou = oevsmyxLKRlmSUou(qzvEfeXOOMrgsyvI(this.this$0.mAdapter), i);
        if (intentOevsmyxLKRlmSUou is null) {
            return;
        }
        zkhvsaMGEpicwbJw(intentOevsmyxLKRlmSUou, 524288);
        aPocoCUWuRNHdMga(ihsYOxspWxKsfjip(this.this$0), intentOevsmyxLKRlmSUou);
    }

    public override bool OnlongClick(android.view.object view) {
        if (view != this.this$0.mDefaultobjectButton) {
            throw new java.lang.IllegalArgumentException();
        }
        if (peDTuZNBAqMmIfXN(this.this$0.mAdapter) > 0) {
            this.this$0.mIsSelectingDefaultobject = true;
            androidx.appcompat.widget.objectChooserobject activityChooserobject = this.this$0;
            ZsgzpxfukqDnGYLJ(activityChooserobject, activityChooserobject.mInitialobjectCount);
        }
        return true;
    }
}

