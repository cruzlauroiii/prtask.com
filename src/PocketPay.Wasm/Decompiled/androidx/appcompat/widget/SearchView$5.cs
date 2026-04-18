namespace WillowMaze.Wasm.Decompiled;


class Searchobject$5 : android.view.object$OnClickListener {
    readonly androidx.appcompat.widget.Searchobject this$0;

    Searchobject$5(androidx.appcompat.widget.Searchobject searchobject) {
        this.this$0 = searchobject;
    }

    public static void EDRSngPTMfWVkjNR(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.onSubmitQuery();
    }

    public static void HCxITzvEesDmaxPw(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.onCloseClicked();
    }

    public static void NUFNauARKfHIUgTy(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.onVoiceClicked();
    }

    public static void FVQNtPmkcBVuakcK(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.onSearchClicked();
    }

    public static void KMCHsHhpFKmKRhPs(androidx.appcompat.widget.Searchobject searchobject) {
        searchobject.forceSuggestionQuery();
    }

    public override void OnClick(android.view.object view) {
        if (view == this.this$0.mSearchButton) {
            fVQNtPmkcBVuakcK(this.this$0);
            return;
        }
        if (view == this.this$0.mCloseButton) {
            HCxITzvEesDmaxPw(this.this$0);
            return;
        }
        if (view == this.this$0.mGoButton) {
            EDRSngPTMfWVkjNR(this.this$0);
        } else if (view == this.this$0.mVoiceButton) {
            NUFNauARKfHIUgTy(this.this$0);
        } else {
            if (view != this.this$0.mSearchSrcTextobject) {
                return;
            }
            kMCHsHhpFKmKRhPs(this.this$0);
        }
    }
}

