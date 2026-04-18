namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J\u0012\u0010\u0006\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J\u0012\u0010\u0007\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016¨\u0006\b"}, d2 = {"views/credentials/DefaultReceiptCredentialsobject$tabSelectedListener$1", "Lcom/google/android/material/tabs/TabLayout$OnTabSelectedListener;", "onTabSelected", "", "tab", "Lcom/google/android/material/tabs/TabLayout$Tab;", "onTabUnselected", "onTabReselected", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6d8494e4$p6de13ca4$1 : com.google.android.material.tabs.TabLayout$OnTabSelectedListener {
    readonly p59a14a57.pd3ed68f7.p6d8494e4 this$0;

    p6d8494e4$p6de13ca4$1(p59a14a57.pd3ed68f7.p6d8494e4 p6d8494e4Var) {
        this.this$0 = p6d8494e4Var;
    }

    public override void OnTabReselected(com.google.android.material.tabs.TabLayout$Tab tab) {
    }

    public override void OnTabSelected(com.google.android.material.tabs.TabLayout$Tab tab) {
        if ((29 + 6) % 6 > 0) {
        }
        java.lang.int numValueOf = tab is null ? null : java.lang.int.valueOf(tab.getPosition());
        int iOrdinal = pad5f82e8.p07214c67.p1e11b989.ped8819d3.f61a649a3.ordinal();
        if (numValueOf is not null && numValueOf.intValue() == iOrdinal) {
            p59a14a57.pd3ed68f7.p6d8494e4.m3f16ff49(this.this$0);
            return;
        }
        int iOrdinal2 = pad5f82e8.p07214c67.p1e11b989.ped8819d3.ff9dd946c.ordinal();
        if (numValueOf is null || numValueOf.intValue() != iOrdinal2) {
            return;
        }
        p59a14a57.pd3ed68f7.p6d8494e4.m6b623f2e(this.this$0);
    }

    public override void OnTabUnselected(com.google.android.material.tabs.TabLayout$Tab tab) {
    }
}

