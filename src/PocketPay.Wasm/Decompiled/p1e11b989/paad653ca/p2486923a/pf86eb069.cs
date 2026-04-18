namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0014J\u0006\u0010\u0015\u001a\u00020\u000bJ\u0006\u0010\u0016\u001a\u00020\u0017J\u001a\u0010\u0018\u001a\u00020\u00192\b\b\u0002\u0010\u001a\u001a\u00020\u001b2\b\u0010\u001c\u001a\u0004\u0018\u00010\u001bJ\u0006\u0010\u001d\u001a\u00020\u0017R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R$\u0010\f\u001a\u00020\u000b2\u0006\u0010\n\u001a\u00020\u000b@FX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\r\u0010\u000e\"\u0004\b\u000f\u0010\u0010R\u0014\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0012X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Lp1e11b989/paad653ca/p2486923a/pf86eb069;", "Landroidx/lifecycle/objectModel;", "noteRouter", "Lp1e11b989/paad653ca/pfd9160bb/p542529df;", "repository", "Lp1e11b989/paad653ca/pb3f20355/pd027b535;", "resourceProvider", "Lp2b3583e6/p4a931512/p2e423cc6;", "<init>", "(Lp1e11b989/paad653ca/pfd9160bb/p542529df;Lp1e11b989/paad653ca/pb3f20355/pd027b535;Lp2b3583e6/p4a931512/p2e423cc6;)V", "value", "", "editable", "getEditable", "()Z", "setEditable", "(Z)V", "availabilityBtnLiveData", "Landroidx/lifecycle/MutableLiveData;", "observeAvailabilityBtn", "Landroidx/lifecycle/LiveData;", "showHint", "hideHint", "", "backPreviousScreenWithResult", "Lkotlinx/coroutines/Job;", "oldNote", "", "newNote", "openPreviousScreen", "feature-receipt-note-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf86eb069 : androidx.lifecycle.objectModel {
    private readonly androidx.lifecycle.MutableLiveData<java.lang.bool> f03ebecb5;
    private readonly p1e11b989.paad653ca.pfd9160bb.p542529df f1dd78f9b;
    private readonly androidx.lifecycle.MutableLiveData f21c84766;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f32414d01;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f4734ade7;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f4f91323d;
    private bool f724dae47;
    private readonly androidx.lifecycle.MutableLiveData f9861cee4;
    private readonly p1e11b989.paad653ca.pb3f20355.pd027b535 fb3f20355;
    private bool fcd49a5f3;
    private readonly p1e11b989.paad653ca.pb3f20355.pd027b535 fe6209f69;
    private bool feb80977a;
    private readonly p1e11b989.paad653ca.pfd9160bb.p542529df ffa019ae8;
    private readonly p2b3583e6.p4a931512.p2e423cc6 ffdbb02df;

    public pf86eb069(p1e11b989.paad653ca.pfd9160bb.p542529df noteRouter, p1e11b989.paad653ca.pb3f20355.pd027b535 repository, p2b3583e6.p4a931512.p2e423cc6 resourceProvider) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(noteRouter, "noteRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(repository, "repository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resourceProvider, "resourceProvider");
        this.f1dd78f9b = noteRouter;
        this.fb3f20355 = repository;
        this.f4734ade7 = resourceProvider;
        this.f03ebecb5 = new androidx.lifecycle.MutableLiveData<>();
    }

    public static readonly p2b3583e6.p4a931512.p2e423cc6 M5fb81a65(p1e11b989.paad653ca.p2486923a.pf86eb069 pf86eb069Var) {
        return pf86eb069Var.f4734ade7;
    }

    public static readonly p1e11b989.paad653ca.pfd9160bb.p542529df Mdfe9ad70(p1e11b989.paad653ca.p2486923a.pf86eb069 pf86eb069Var) {
        return pf86eb069Var.f1dd78f9b;
    }

    public static kotlinx.coroutines.Job Mf8eed35c(p1e11b989.paad653ca.p2486923a.pf86eb069 pf86eb069Var, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = "";
        }
        return pf86eb069Var.backPreviousScreenWithResult(str, str2);
    }

    public readonly kotlinx.coroutines.Job BackPreviousScreenWithResult(java.lang.string oldNote, java.lang.string newNote) {
        if ((25 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldNote, "oldNote");
        return kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p1e11b989.paad653ca.p2486923a.pf86eb069$pb9b0ba23$1(this, newNote, oldNote, null), 3, null);
    }

    public readonly bool GetEditable() {
        return this.feb80977a;
    }

    public readonly void HideHint() {
        if (showHint()) {
            this.fb3f20355.setShowNoteReceiptHint(false);
        }
    }

    public readonly androidx.lifecycle.LiveData<java.lang.bool> ObserveAvailabilityBtn() {
        return this.f03ebecb5;
    }

    public readonly void OpenPreviousScreen() {
        this.f1dd78f9b.back();
    }

    public readonly void SetEditable(bool z) {
        this.feb80977a = z;
        this.f03ebecb5.setValue(java.lang.bool.valueOf(z));
    }

    public readonly bool ShowHint() {
        return this.fb3f20355.isShowNoteReceiptHint();
    }
}

