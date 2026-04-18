namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\bH\u0016J\b\u0010\t\u001a\u00020\u0003H\u0016¨\u0006\n"}, d2 = {"views/phone/PhoneInputobject$initPhoneInput$2", "Lp2b3583e6/pf7a42fe7/p1c05a448$p33e59707;", "onCountryPhoneTypeSelected", "", "countyPhoneType", "Lpad5f82e8/p07214c67/pf7a42fe7/pd6d29a6f;", "onPhoneChanged", "phone", "", "onError", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe9a5d05c$p1585e338$2 : p2b3583e6.pf7a42fe7.p1c05a448$p33e59707 {
    readonly p59a14a57.pf7a42fe7.pe9a5d05c this$0;

    pe9a5d05c$p1585e338$2(p59a14a57.pf7a42fe7.pe9a5d05c pe9a5d05cVar) {
        this.this$0 = pe9a5d05cVar;
    }

    public override void OnCountryPhoneTypeSelected(pad5f82e8.p07214c67.pf7a42fe7.pd6d29a6f countyPhoneType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(countyPhoneType, "countyPhoneType");
    }

    public override void OnError() {
        p59a14a57.pf7a42fe7.pe9a5d05c.mfd88061b(this.this$0);
    }

    public override void OnPhoneChanged(java.lang.string phone) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        p59a14a57.pf7a42fe7.pe9a5d05c.mec59c5d9(this.this$0, phone);
    }
}

