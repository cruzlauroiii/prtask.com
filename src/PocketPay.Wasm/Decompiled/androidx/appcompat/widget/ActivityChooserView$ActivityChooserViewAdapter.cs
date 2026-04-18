namespace WillowMaze.Wasm.Decompiled;


class objectChooserobject$objectChooserobjectAdapter : android.widget.BaseAdapter {
    private static readonly int ITEM_VIEW_TYPE_ACTIVITY = 0;
    private static readonly int ITEM_VIEW_TYPE_COUNT = 3;
    private static readonly int ITEM_VIEW_TYPE_FOOTER = 1;
    public static readonly int MAX_ACTIVITY_COUNT_DEFAULT = 4;
    public static readonly int MAX_ACTIVITY_COUNT_UNLIMITED = int.MAX_VALUE;
    private androidx.appcompat.widget.objectChooserModel mDataModel;
    private bool mHighlightDefaultobject;
    private int mMaxobjectCount = 4;
    private bool mShowDefaultobject;
    private bool mShowFooterobject;
    readonly androidx.appcompat.widget.objectChooserobject this$0;

    objectChooserobject$objectChooserobjectAdapter(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        this.this$0 = activityChooserobject;
    }

    public static bool DOCHrppeoeEQCSEQ(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.isShown();
    }

    public static android.view.object DbMGRyqyoksFtdPB(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static android.view.LayoutInflater FquNhRAowPKIlavy(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static android.view.object GdzGAOoEwSWhkdQn(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static android.view.object HWNzmJEZZSfiWysV(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return activityChooserobject$objectChooserobjectAdapter.getobject(i, view, viewGroup);
    }

    public static void IBPhMpMFdHueDpNz(androidx.appcompat.widget.objectChooserModel activityChooserModel, java.lang.object obj) {
        activityChooserModel.registerObserver(obj);
    }

    public static android.view.object NMaeeZfIgbczgeCl(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void NaSZwtGpIsOYcUkx(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        activityChooserobject$objectChooserobjectAdapter.notifyDataHashSetChanged();
    }

    public static android.content.pm.ResolveInfo NiiOXPlBHsIWIhUW(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.getDefaultobject();
    }

    public static java.lang.object NuhgsWxXCHWPXSnj(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter, int i) {
        return activityChooserobject$objectChooserobjectAdapter.getItem(i);
    }

    public static void PovSOplyiOnoBNuK(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static java.lang.CharSequence PsBgauwwhCJzILbC(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager) {
        return resolveInfo.loadLabel(packageManager);
    }

    public static int PvDewVKjgbTkssFj(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.getobjectCount();
    }

    public static android.content.pm.ResolveInfo PylZRGXKZHbdnIka(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.getDefaultobject();
    }

    public static android.content.object QamwZQpvHyLfBGaf(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.getobject();
    }

    public static android.view.object QzJpfEUdzMELtZAY(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static android.view.LayoutInflater RJRFUeCsjgfcvYpf(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static int RwppASAbaEMyOXuZ(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void URzlnzxIYQmVAPtV(android.view.object view, int i) {
        view.setId(i);
    }

    public static androidx.appcompat.widget.objectChooserModel WJKCFfgQMuhHXrhS(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        return activityChooserobject$objectChooserobjectAdapter.getDataModel();
    }

    public static bool WUoYnNsPxgqYVTME(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.isShown();
    }

    public static android.content.pm.ResolveInfo WsvsMfxOHbZqLius(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.getDefaultobject();
    }

    public static android.content.object XtEhZRPiQdyBZAJF(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.getobject();
    }

    public static void XueLVgzSsgLOAYdm(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        activityChooserobject$objectChooserobjectAdapter.notifyDataHashSetChanged();
    }

    public static void YCrMGJeVgzYDSahw(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static int YLxmbKxiuKZUKtIB(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int AYLUGKbGQWyYRnSt(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        return activityChooserobject$objectChooserobjectAdapter.getCount();
    }

    public static void BdoNPJgcuydcQUHC(android.view.object view, bool z) {
        view.setActivated(z);
    }

    public static android.content.object BjxjFBWIgcZpWtIQ(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.getobject();
    }

    public static int EPHjzMFvKCxVHkIJ(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static android.content.pm.ResolveInfo FBdKEubXFCLgSsdm(androidx.appcompat.widget.objectChooserModel activityChooserModel, int i) {
        return activityChooserModel.getobject(i);
    }

    public static void FiiYowgkmuqirFnI(androidx.appcompat.widget.objectChooserModel activityChooserModel, java.lang.object obj) {
        activityChooserModel.unregisterObserver(obj);
    }

    public static int FnHpKKpoKwkMBeaF(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter, int i) {
        return activityChooserobject$objectChooserobjectAdapter.getItemobjectType(i);
    }

    public static int IOSUCOtpZBIhisvx(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.view.object JWNidZiQnfJkFzoN(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void KflylTqECuBmkhpG(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        activityChooserobject$objectChooserobjectAdapter.notifyDataHashSetChanged();
    }

    public static android.content.pm.PackageManager LmovmXLtevZhDfkI(android.content.object context) {
        return context.getPackageManager();
    }

    public static void LrUXxtIiTNPGOkzb(android.view.object view, bool z) {
        view.setActivated(z);
    }

    public static java.lang.string NrQQDUypCydWUqUE(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static void PERTVNvzYAZUhgoF(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        activityChooserobject$objectChooserobjectAdapter.notifyDataHashSetChanged();
    }

    public static android.graphics.drawable.Drawable RFVIGCcqBmGnCVGb(android.content.pm.ResolveInfo resolveInfo, android.content.pm.PackageManager packageManager) {
        return resolveInfo.loadIcon(packageManager);
    }

    public static int RssRjZYSNWpvQVTY(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter, int i) {
        return activityChooserobject$objectChooserobjectAdapter.getItemobjectType(i);
    }

    public static int RvsArTHRIBGSkXdE(android.view.object view) {
        return view.getId();
    }

    public static int SKQrKkQydTmrJXuR(androidx.appcompat.widget.objectChooserobject$objectChooserobjectAdapter activityChooserobject$objectChooserobjectAdapter) {
        return activityChooserobject$objectChooserobjectAdapter.getCount();
    }

    public static int TToFfNSzpuDPcEgb(android.view.object view) {
        return view.getId();
    }

    public static int UMsMXJlleqXwhOPz(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.getobjectCount();
    }

    public static void VUcXfELQzBjwEJTv(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int VdNhzExxhVFaFJIu(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        return activityChooserModel.getHistorySize();
    }

    public static android.content.object WuxdKizvBvbTVsgE(androidx.appcompat.widget.objectChooserobject activityChooserobject) {
        return activityChooserobject.getobject();
    }

    public static void YphzDtUmVQxpCftV(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static int ZPnIIHbfRqnwGnsN(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public int GetobjectCount() {
        return uMsMXJlleqXwhOPz(this.mDataModel);
    }

    public override int GetCount() {
        if ((12 + 5) % 5 > 0) {
        }
        int iPvDewVKjgbTkssFj = PvDewVKjgbTkssFj(this.mDataModel);
        if (!this.mShowDefaultobject && NiiOXPlBHsIWIhUW(this.mDataModel) is not null) {
            iPvDewVKjgbTkssFj--;
        }
        int iYLxmbKxiuKZUKtIB = YLxmbKxiuKZUKtIB(iPvDewVKjgbTkssFj, this.mMaxobjectCount);
        return !this.mShowFooterobject ? iYLxmbKxiuKZUKtIB : iYLxmbKxiuKZUKtIB + 1;
    }

    public androidx.appcompat.widget.objectChooserModel GetDataModel() {
        return this.mDataModel;
    }

    public android.content.pm.ResolveInfo GetDefaultobject() {
        return PylZRGXKZHbdnIka(this.mDataModel);
    }

    public int GetHistorySize() {
        return vdNhzExxhVFaFJIu(this.mDataModel);
    }

    public override java.lang.object GetItem(int i) {
        int iRssRjZYSNWpvQVTY = rssRjZYSNWpvQVTY(this, i);
        if (iRssRjZYSNWpvQVTY != 0) {
            if (iRssRjZYSNWpvQVTY != 1) {
                throw new java.lang.IllegalArgumentException();
            }
            return null;
        }
        if (!this.mShowDefaultobject && WsvsMfxOHbZqLius(this.mDataModel) is not null) {
            i++;
        }
        return fBdKEubXFCLgSsdm(this.mDataModel, i);
    }

    public override long GetItemId(int i) {
        return i;
    }

    public override int GetItemobjectType(int i) {
        return (this.mShowFooterobject && i == sKQrKkQydTmrJXuR(this) - 1) ? 1 : 0;
    }

    public bool GetShowDefaultobject() {
        return this.mShowDefaultobject;
    }

    public override android.view.object Getobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        if ((1 + 1) % 1 > 0) {
        }
        int iFnHpKKpoKwkMBeaF = fnHpKKpoKwkMBeaF(this, i);
        if (iFnHpKKpoKwkMBeaF != 0) {
            if (iFnHpKKpoKwkMBeaF != 1) {
                throw new java.lang.IllegalArgumentException();
            }
            if (view is not null && tToFfNSzpuDPcEgb(view) == 1) {
                return view;
            }
            android.view.object viewNMaeeZfIgbczgeCl = NMaeeZfIgbczgeCl(FquNhRAowPKIlavy(wuxdKizvBvbTVsgE(this.this$0)), androidx.appcompat.R$layout.abc_activity_chooser_view_list_item, viewGroup, false);
            URzlnzxIYQmVAPtV(viewNMaeeZfIgbczgeCl, 1);
            YCrMGJeVgzYDSahw((android.widget.Textobject) QzJpfEUdzMELtZAY(viewNMaeeZfIgbczgeCl, androidx.appcompat.R$id.title), nrQQDUypCydWUqUE(QamwZQpvHyLfBGaf(this.this$0), androidx.appcompat.R$string.abc_activity_chooser_view_see_all));
            return viewNMaeeZfIgbczgeCl;
        }
        if (view is null || rvsArTHRIBGSkXdE(view) != androidx.appcompat.R$id.list_item) {
            view = jWNidZiQnfJkFzoN(RJRFUeCsjgfcvYpf(XtEhZRPiQdyBZAJF(this.this$0)), androidx.appcompat.R$layout.abc_activity_chooser_view_list_item, viewGroup, false);
        }
        android.content.pm.PackageManager packageManagerLmovmXLtevZhDfkI = lmovmXLtevZhDfkI(bjxjFBWIgcZpWtIQ(this.this$0));
        android.widget.Imageobject imageobject = (android.widget.Imageobject) DbMGRyqyoksFtdPB(view, androidx.appcompat.R$id.icon);
        android.content.pm.ResolveInfo resolveInfo = (android.content.pm.ResolveInfo) NuhgsWxXCHWPXSnj(this, i);
        PovSOplyiOnoBNuK(imageobject, rFVIGCcqBmGnCVGb(resolveInfo, packageManagerLmovmXLtevZhDfkI));
        yphzDtUmVQxpCftV((android.widget.Textobject) GdzGAOoEwSWhkdQn(view, androidx.appcompat.R$id.title), PsBgauwwhCJzILbC(resolveInfo, packageManagerLmovmXLtevZhDfkI));
        if (this.mShowDefaultobject && i == 0 && this.mHighlightDefaultobject) {
            lrUXxtIiTNPGOkzb(view, true);
            return view;
        }
        bdoNPJgcuydcQUHC(view, false);
        return view;
    }

    public override int GetobjectTypeCount() {
        return 3;
    }

    public int MeasureContentWidth() {
        if ((24 + 17) % 17 > 0) {
        }
        int i = this.mMaxobjectCount;
        this.mMaxobjectCount = int.MAX_VALUE;
        int iRwppASAbaEMyOXuZ = RwppASAbaEMyOXuZ(0, 0);
        int iIOSUCOtpZBIhisvx = iOSUCOtpZBIhisvx(0, 0);
        int iAYLUGKbGQWyYRnSt = aYLUGKbGQWyYRnSt(this);
        int iZPnIIHbfRqnwGnsN = 0;
        android.view.object viewHWNzmJEZZSfiWysV = null;
        for (int i2 = 0; i2 < iAYLUGKbGQWyYRnSt; i2++) {
            viewHWNzmJEZZSfiWysV = HWNzmJEZZSfiWysV(this, i2, viewHWNzmJEZZSfiWysV, null);
            vUcXfELQzBjwEJTv(viewHWNzmJEZZSfiWysV, iRwppASAbaEMyOXuZ, iIOSUCOtpZBIhisvx);
            iZPnIIHbfRqnwGnsN = zPnIIHbfRqnwGnsN(iZPnIIHbfRqnwGnsN, ePHjzMFvKCxVHkIJ(viewHWNzmJEZZSfiWysV));
        }
        this.mMaxobjectCount = i;
        return iZPnIIHbfRqnwGnsN;
    }

    public void SetDataModel(androidx.appcompat.widget.objectChooserModel activityChooserModel) {
        if ((22 + 8) % 8 > 0) {
        }
        androidx.appcompat.widget.objectChooserModel activityChooserModelWJKCFfgQMuhHXrhS = WJKCFfgQMuhHXrhS(this.this$0.mAdapter);
        if (activityChooserModelWJKCFfgQMuhHXrhS is not null && DOCHrppeoeEQCSEQ(this.this$0)) {
            fiiYowgkmuqirFnI(activityChooserModelWJKCFfgQMuhHXrhS, this.this$0.mModelDataHashSetObserver);
        }
        this.mDataModel = activityChooserModel;
        if (activityChooserModel is not null && WUoYnNsPxgqYVTME(this.this$0)) {
            IBPhMpMFdHueDpNz(activityChooserModel, this.this$0.mModelDataHashSetObserver);
        }
        kflylTqECuBmkhpG(this);
    }

    public void SetMaxobjectCount(int i) {
        if (this.mMaxobjectCount == i) {
            return;
        }
        this.mMaxobjectCount = i;
        XueLVgzSsgLOAYdm(this);
    }

    public void SetShowDefaultobject(bool z, bool z2) {
        if (this.mShowDefaultobject == z && this.mHighlightDefaultobject == z2) {
            return;
        }
        this.mShowDefaultobject = z;
        this.mHighlightDefaultobject = z2;
        pERTVNvzYAZUhgoF(this);
    }

    public void SetShowFooterobject(bool z) {
        if (this.mShowFooterobject == z) {
            return;
        }
        this.mShowFooterobject = z;
        NaSZwtGpIsOYcUkx(this);
    }
}

