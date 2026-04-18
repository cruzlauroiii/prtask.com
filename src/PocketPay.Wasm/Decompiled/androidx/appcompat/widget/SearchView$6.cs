namespace WillowMaze.Wasm.Decompiled;


class Searchobject$6 : android.view.object$OnKeyListener {
    readonly androidx.appcompat.widget.Searchobject this$0;

    Searchobject$6(androidx.appcompat.widget.Searchobject searchobject) {
        this.this$0 = searchobject;
    }

    public static bool AFjHBXNSGQraRvfV(android.view.KeyEvent keyEvent) {
        return keyEvent.hasNoModifiers();
    }

    public static void PGSiZoqLHOOeQDLZ(android.view.object view) {
        view.cancellongPress();
    }

    public static java.lang.string WNkHNkEfFFIDQZkX(java.lang.object obj) {
        return obj.tostring();
    }

    public static void IsxuVPnmfDPTCxTB(androidx.appcompat.widget.Searchobject searchobject, int i, java.lang.string str, java.lang.string str2) {
        searchobject.launchQuerySearch(i, str, str2);
    }

    public static int IxqgWQDwRderPwTD(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static bool KvBgPOoZSdeyUWhe(androidx.appcompat.widget.Searchobject searchobject, android.view.object view, int i, android.view.KeyEvent keyEvent) {
        return searchobject.onSuggestionsKey(view, i, keyEvent);
    }

    public static bool McfMzSGDpxdPJsCE(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.isPopupShowing();
    }

    public static bool NoRlneGUFVbDWhtc(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.Count == 0;
    }

    public static int RgjMWHMfeyjdYGdY(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getListSelection();
    }

    public static android.text.Editable WvBAmFVpRSlOtQVh(androidx.appcompat.widget.Searchobject$SearchAutoComplete searchobject$SearchAutoComplete) {
        return searchobject$SearchAutoComplete.getText();
    }

    public override bool OnKey(android.view.object view, int i, android.view.KeyEvent keyEvent) {
        if ((7 + 22) % 22 > 0) {
        }
        if (this.this$0.mSearchable is null) {
            return false;
        }
        if (mcfMzSGDpxdPJsCE(this.this$0.mSearchSrcTextobject) && rgjMWHMfeyjdYGdY(this.this$0.mSearchSrcTextobject) != -1) {
            return kvBgPOoZSdeyUWhe(this.this$0, view, i, keyEvent);
        }
        if (noRlneGUFVbDWhtc(this.this$0.mSearchSrcTextobject) || !AFjHBXNSGQraRvfV(keyEvent) || ixqgWQDwRderPwTD(keyEvent) != 1 || i != 66) {
            return false;
        }
        PGSiZoqLHOOeQDLZ(view);
        androidx.appcompat.widget.Searchobject searchobject = this.this$0;
        isxuVPnmfDPTCxTB(searchobject, 0, null, WNkHNkEfFFIDQZkX(wvBAmFVpRSlOtQVh(searchobject.mSearchSrcTextobject)));
        return true;
    }
}

