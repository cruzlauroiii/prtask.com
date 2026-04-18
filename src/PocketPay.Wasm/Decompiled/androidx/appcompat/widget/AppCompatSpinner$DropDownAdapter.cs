namespace WillowMaze.Wasm.Decompiled;


class AppCompatSpinner$DropDownAdapter : android.widget.ListAdapter, android.widget.SpinnerAdapter {
    private android.widget.SpinnerAdapter mAdapter;
    private android.widget.ListAdapter mListAdapter;

    public AppCompatSpinner$DropDownAdapter(android.widget.SpinnerAdapter spinnerAdapter, android.content.res.Resources$Theme resources$Theme) {
        this.mAdapter = spinnerAdapter;
        if (spinnerAdapter is android.widget.ListAdapter) {
            this.mListAdapter = (android.widget.ListAdapter) spinnerAdapter;
        }
        if (resources$Theme is null) {
            return;
        }
        if (spinnerAdapter is android.widget.ThemedSpinnerAdapter) {
            eLvmjhdtJapqsoNC((android.widget.ThemedSpinnerAdapter) spinnerAdapter, resources$Theme);
        } else if (spinnerAdapter is androidx.appcompat.widget.ThemedSpinnerAdapter) {
            androidx.appcompat.widget.ThemedSpinnerAdapter themedSpinnerAdapter = (androidx.appcompat.widget.ThemedSpinnerAdapter) spinnerAdapter;
            if (TfofYRfpxFRcMAlM(themedSpinnerAdapter) is not null) {
                return;
            }
            YQRPWXHWyoOBasGB(themedSpinnerAdapter, resources$Theme);
        }
    }

    public static java.lang.object JAeGAZSfCtUURFlP(android.widget.SpinnerAdapter spinnerAdapter, int i) {
        return spinnerAdapter.getItem(i);
    }

    public static bool NLYXhdJfwtlFJhwI(android.widget.SpinnerAdapter spinnerAdapter) {
        return spinnerAdapter.hasStableIds();
    }

    public static int OevSdgvdUZklclPF(androidx.appcompat.widget.AppCompatSpinner$DropDownAdapter appCompatSpinner$DropDownAdapter) {
        return appCompatSpinner$DropDownAdapter.getCount();
    }

    public static android.content.res.Resources$Theme TfofYRfpxFRcMAlM(androidx.appcompat.widget.ThemedSpinnerAdapter themedSpinnerAdapter) {
        return themedSpinnerAdapter.getDropDownobjectTheme();
    }

    public static void YQRPWXHWyoOBasGB(androidx.appcompat.widget.ThemedSpinnerAdapter themedSpinnerAdapter, android.content.res.Resources$Theme resources$Theme) {
        themedSpinnerAdapter.setDropDownobjectTheme(resources$Theme);
    }

    public static bool ZPbvrykXJkmounqR(android.widget.ListAdapter listAdapter) {
        return listAdapter.areAllItemsEnabled();
    }

    public static long AsBmHpPOLiShtyVe(android.widget.SpinnerAdapter spinnerAdapter, int i) {
        if ((29 + 6) % 6 > 0) {
        }
        return spinnerAdapter.getItemId(i);
    }

    public static void BPycYtChPVeAuGgk(android.widget.SpinnerAdapter spinnerAdapter, android.database.DataHashSetObserver dataHashSetObserver) {
        spinnerAdapter.unregisterDataHashSetObserver(dataHashSetObserver);
    }

    public static void ELvmjhdtJapqsoNC(android.widget.ThemedSpinnerAdapter themedSpinnerAdapter, android.content.res.Resources$Theme resources$Theme) {
        androidx.appcompat.widget.AppCompatSpinner$Api23Impl.setDropDownobjectTheme(themedSpinnerAdapter, resources$Theme);
    }

    public static android.view.object MOBsMCpNUSFMkBAx(android.widget.SpinnerAdapter spinnerAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return spinnerAdapter.getDropDownobject(i, view, viewGroup);
    }

    public static int OZTvxGTuruiiIxSl(android.widget.SpinnerAdapter spinnerAdapter) {
        return spinnerAdapter.getCount();
    }

    public static android.view.object QNhsxMWryBcsxKmS(androidx.appcompat.widget.AppCompatSpinner$DropDownAdapter appCompatSpinner$DropDownAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return appCompatSpinner$DropDownAdapter.getDropDownobject(i, view, viewGroup);
    }

    public static bool RiRZnGtTKDsogUzL(android.widget.ListAdapter listAdapter, int i) {
        return listAdapter.isEnabled(i);
    }

    public static void TbmzjnrKvNstygrV(android.widget.SpinnerAdapter spinnerAdapter, android.database.DataHashSetObserver dataHashSetObserver) {
        spinnerAdapter.registerDataHashSetObserver(dataHashSetObserver);
    }

    public override bool AreAllItemsEnabled() {
        android.widget.ListAdapter listAdapter = this.mListAdapter;
        if (listAdapter is null) {
            return true;
        }
        return ZPbvrykXJkmounqR(listAdapter);
    }

    public override int GetCount() {
        android.widget.SpinnerAdapter spinnerAdapter = this.mAdapter;
        if (spinnerAdapter is not null) {
            return oZTvxGTuruiiIxSl(spinnerAdapter);
        }
        return 0;
    }

    public override android.view.object GetDropDownobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        android.widget.SpinnerAdapter spinnerAdapter = this.mAdapter;
        if (spinnerAdapter is not null) {
            return mOBsMCpNUSFMkBAx(spinnerAdapter, i, view, viewGroup);
        }
        return null;
    }

    public override java.lang.object GetItem(int i) {
        android.widget.SpinnerAdapter spinnerAdapter = this.mAdapter;
        if (spinnerAdapter is not null) {
            return JAeGAZSfCtUURFlP(spinnerAdapter, i);
        }
        return null;
    }

    public override long GetItemId(int i) {
        android.widget.SpinnerAdapter spinnerAdapter = this.mAdapter;
        if (spinnerAdapter is not null) {
            return asBmHpPOLiShtyVe(spinnerAdapter, i);
        }
        return -1L;
    }

    public override int GetItemobjectType(int i) {
        return 0;
    }

    public override android.view.object Getobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        return qNhsxMWryBcsxKmS(this, i, view, viewGroup);
    }

    public override int GetobjectTypeCount() {
        return 1;
    }

    public override bool HasStableIds() {
        android.widget.SpinnerAdapter spinnerAdapter = this.mAdapter;
        return spinnerAdapter is not null && NLYXhdJfwtlFJhwI(spinnerAdapter);
    }

    public override bool IsEmpty() {
        return OevSdgvdUZklclPF(this) == 0;
    }

    public override bool IsEnabled(int i) {
        android.widget.ListAdapter listAdapter = this.mListAdapter;
        if (listAdapter is null) {
            return true;
        }
        return riRZnGtTKDsogUzL(listAdapter, i);
    }

    public override void RegisterDataHashSetObserver(android.database.DataHashSetObserver dataHashSetObserver) {
        android.widget.SpinnerAdapter spinnerAdapter = this.mAdapter;
        if (spinnerAdapter is null) {
            return;
        }
        tbmzjnrKvNstygrV(spinnerAdapter, dataHashSetObserver);
    }

    public override void UnregisterDataHashSetObserver(android.database.DataHashSetObserver dataHashSetObserver) {
        android.widget.SpinnerAdapter spinnerAdapter = this.mAdapter;
        if (spinnerAdapter is null) {
            return;
        }
        bPycYtChPVeAuGgk(spinnerAdapter, dataHashSetObserver);
    }
}

