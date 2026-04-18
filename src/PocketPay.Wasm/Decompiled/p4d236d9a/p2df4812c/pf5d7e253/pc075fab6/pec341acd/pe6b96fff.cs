using Android.Content.Res;
using Android.View;
using Android.Widget;
using Androidx.Appcompat.Widget;
using Androidx.Constraintlayout.Widget;
using Androidx.Recyclerview.Widget;
using Androidx.Viewbinding;
using Com.Google.Android.Material.Floatingactionbutton;
using P4d236d9a.P2df4812c.Pf5d7e253.P705f8913.P9efab239.P59a14a57.Pec341acd;
using P4d236d9a.P2df4812c.Pf5d7e253.Pc075fab6;
using P59a14a57.P4a527f83;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes.dex */
public readonly class pe6b96fff : objectBinding {
    public readonly Textobject f053ce592;
    public readonly ConstraintLayout f0653dc42;
    private readonly ConstraintLayout f076d9edf;
    public readonly Scrollobject f089b0cdd;
    public readonly p5e9061ea f0c124449;
    public readonly Textobject f0d53d719;
    public readonly p5e9061ea f16c71d47;
    public readonly Recyclerobject f17187fc5;
    public readonly RelativeLayout f182638e2;
    public readonly Textobject f1adc7706;
    public readonly Textobject f22b207ac;
    public readonly Textobject f2d31e0ec;
    public readonly pf37d3c3d f3085a1ea;
    public readonly Scrollobject f345407f7;
    public readonly Textobject f35562f93;
    public readonly ConstraintLayout f380e537a;
    private readonly ConstraintLayout f3a817e14;
    public readonly Scrollobject f3cb2c8d1;
    public readonly RelativeLayout f3fd3d9a9;
    public readonly p5e9061ea f43cd9bf1;
    public readonly Toolbar f45dcfe95;
    public readonly ConstraintLayout f46b1b1c1;
    public readonly ConstraintLayout f47c68a51;
    public readonly Textobject f4918d895;
    public readonly p5e9061ea f4a527f83;
    public readonly ConstraintLayout f4a568118;
    public readonly Textobject f4e79380b;
    public readonly Textobject f53330eea;
    public readonly p5e9061ea f53c8a303;
    public readonly pf37d3c3d f5b315f76;
    public readonly Recyclerobject f5cd89e00;
    private readonly ConstraintLayout f644e1789;
    public readonly ConstraintLayout f66b31e28;
    public readonly Recyclerobject f679e8f95;
    public readonly ConstraintLayout f6a8af2c1;
    public readonly pf37d3c3d f6b1d7060;
    public readonly objectStub f74ffd981;
    public readonly floatingActionButton f7d42e642;
    public readonly pf37d3c3d f7eb21900;
    public readonly ConstraintLayout f87f77f4c;
    public readonly ConstraintLayout f8ebfb635;
    public readonly Textobject f8f469454;
    public readonly ConstraintLayout f906419f2;
    public readonly Textobject f935d648d;
    public readonly Textobject f97586bb2;
    public readonly Textobject f9b7e036d;
    public readonly pf37d3c3d f9e2e12a2;
    public readonly Recyclerobject f9ffaf052;
    public readonly LinearLayout fa2e4822a;
    public readonly ConstraintLayout fa8caf6f9;
    public readonly RelativeLayout fa94423ed;
    public readonly Textobject fa95984db;
    public readonly LinearLayout faa8ad5c8;
    public readonly Textobject fb8db73a5;
    public readonly Toolbar fbc6842c2;
    public readonly Scrollobject fbe9d3938;
    public readonly Toolbar fbfc5d69e;
    private readonly ConstraintLayout fc172ee2a;
    public readonly Textobject fc2615bd7;
    public readonly Textobject fc7815f8f;
    public readonly floatingActionButton fc98d48c7;
    public readonly LinearLayout fd1387868;
    public readonly floatingActionButton fd4810f58;
    public readonly Toolbar fd7f4945d;
    public readonly RelativeLayout fd9314b8f;
    public readonly LinearLayout fdd3fa3b2;
    public readonly LinearLayout fdecae314;
    public readonly RelativeLayout fe1e79ad7;
    public readonly Textobject fe31b59ed;
    public readonly objectStub fe4f4e213;
    public readonly Textobject feb78b833;
    public readonly Textobject ff47952d3;
    public readonly Toolbar ff50b3c2a;
    public readonly floatingActionButton ff6d11a42;
    public readonly Textobject ff7888983;
    public readonly Textobject ffbdf5a93;

    private pe6b96fff(ConstraintLayout rootobject, floatingActionButton addPositionToReceiptButton, RelativeLayout btnPayGroup, ConstraintLayout buttonAddGroupLayout, floatingActionButton closeExpandableMenuButton, Textobject descriptionTv, LinearLayout empty, Textobject floatingButtonDescription, pf37d3c3d itemReceiptNote, LinearLayout linearLayout, p5e9061ea loader, ConstraintLayout overlay, Textobject paybackDisabledTv, Textobject paybackEnabledTv, ConstraintLayout paybackReceiptDisabledPaymentButton, ConstraintLayout paybackReceiptToPaymentButton, Textobject receiptButtonPriceTextDisabled, Recyclerobject rvPaybackPositions, Scrollobject scroll, Textobject toReceiptButtonTotalPriceText, Toolbar toolbar, objectStub viewStubExpandableFabMenu) {
        this.f076d9edf = rootobject;
        this.fc98d48c7 = addPositionToReceiptButton;
        this.fa94423ed = btnPayGroup;
        this.f8ebfb635 = buttonAddGroupLayout;
        this.fd4810f58 = closeExpandableMenuButton;
        this.f053ce592 = descriptionTv;
        this.fa2e4822a = empty;
        this.ff47952d3 = floatingButtonDescription;
        this.f9e2e12a2 = itemReceiptNote;
        this.fd1387868 = linearLayout;
        this.f4a527f83 = loader;
        this.f380e537a = overlay;
        this.fc7815f8f = paybackDisabledTv;
        this.fe31b59ed = paybackEnabledTv;
        this.f4a568118 = paybackReceiptDisabledPaymentButton;
        this.f66b31e28 = paybackReceiptToPaymentButton;
        this.ff7888983 = receiptButtonPriceTextDisabled;
        this.f679e8f95 = rvPaybackPositions;
        this.f089b0cdd = scroll;
        this.fc2615bd7 = toReceiptButtonTotalPriceText;
        this.ff50b3c2a = toolbar;
        this.fe4f4e213 = viewStubExpandableFabMenu;
    }

    public static object ArXtQlQUtjembUrD(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void ArXtQlQUtjembUrD(object r0, int r1, char r2, int r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ArXtQlQUtjembUrD(object r0, int r1, char r2, string r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ArXtQlQUtjembUrD(object r0, int r1, int r2, char r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static ConstraintLayout EiJHwUprPYHvbAjw(pe6b96fff r1) {
        return r1.getRoot();
    }

    public static void EiJHwUprPYHvbAjw(pe6b96fff r0, char r1, bool r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EiJHwUprPYHvbAjw(pe6b96fff r0, int r1, short r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EiJHwUprPYHvbAjw(pe6b96fff r0, short r1, bool r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object ExVuntPrHDGVqnAu(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void ExVuntPrHDGVqnAu(object r0, int r1, string r2, int r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ExVuntPrHDGVqnAu(object r0, int r1, string r2, short r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ExVuntPrHDGVqnAu(object r0, int r1, short r2, bool r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object HzycScuAxKayLCOV(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void HzycScuAxKayLCOV(object r0, int r1, float r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HzycScuAxKayLCOV(object r0, int r1, short r2, byte r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HzycScuAxKayLCOV(object r0, int r1, short r2, float r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static pe6b96fff JOsXQfMbJOuHUcWS(object r1) {
        return m128477f5(r1);
    }

    public static void JOsXQfMbJOuHUcWS(object r0, short r1, bool r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JOsXQfMbJOuHUcWS(object r0, bool r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JOsXQfMbJOuHUcWS(object r0, bool r1, short r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object ObzkiwXuMaPmyQef(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void ObzkiwXuMaPmyQef(object r0, int r1, int r2, short r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ObzkiwXuMaPmyQef(object r0, int r1, short r2, bool r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ObzkiwXuMaPmyQef(object r0, int r1, bool r2, short r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string PbBetLNxDNaUvJUz(string r1, string r2) {
        return r1.concat(r2);
    }

    public static void PbBetLNxDNaUvJUz(string r0, string r1, float r2, string r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PbBetLNxDNaUvJUz(string r0, string r1, float r2, short r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PbBetLNxDNaUvJUz(string r0, string r1, string r2, short r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object SPvwqPsaxidhDbVW(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void SPvwqPsaxidhDbVW(object r0, int r1, byte r2, float r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SPvwqPsaxidhDbVW(object r0, int r1, float r2, byte r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SPvwqPsaxidhDbVW(object r0, int r1, int r2, bool r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object TptONOOwZGzMAzjQ(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void TptONOOwZGzMAzjQ(object r0, int r1, float r2, int r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TptONOOwZGzMAzjQ(object r0, int r1, int r2, bool r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TptONOOwZGzMAzjQ(object r0, int r1, string r2, float r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static pe6b96fff VJyvGbFXLqyLKCiN(LayoutInflater r1, objectGroup r2, bool r3) {
        return m89daba64(r1, r2, r3);
    }

    public static void VJyvGbFXLqyLKCiN(LayoutInflater r0, objectGroup r1, bool r2, int r3, bool r4, short r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void VJyvGbFXLqyLKCiN(LayoutInflater r0, objectGroup r1, bool r2, short r3, byte r4, int r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void VJyvGbFXLqyLKCiN(LayoutInflater r0, objectGroup r1, bool r2, short r3, int r4, bool r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static object WUmdEaviUrsQpnjE(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void WUmdEaviUrsQpnjE(object r0, int r1, int r2, byte r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WUmdEaviUrsQpnjE(object r0, int r1, int r2, bool r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WUmdEaviUrsQpnjE(object r0, int r1, bool r2, int r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object WrABdeITrFNMXhnq(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void WrABdeITrFNMXhnq(object r0, int r1, float r2, bool r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WrABdeITrFNMXhnq(object r0, int r1, string r2, short r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WrABdeITrFNMXhnq(object r0, int r1, string r2, bool r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static Resources WuWTiBLHsYsNJIvJ(object r1) {
        return r1.getResources();
    }

    public static void WuWTiBLHsYsNJIvJ(object r0, byte r1, string r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WuWTiBLHsYsNJIvJ(object r0, char r1, byte r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WuWTiBLHsYsNJIvJ(object r0, char r1, string r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object YvIRkGLIYuvanApr(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void YvIRkGLIYuvanApr(object r0, int r1, char r2, float r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YvIRkGLIYuvanApr(object r0, int r1, char r2, string r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YvIRkGLIYuvanApr(object r0, int r1, float r2, string r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object BLXRnZiLTtqZPfAL(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void BLXRnZiLTtqZPfAL(object r0, int r1, char r2, short r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BLXRnZiLTtqZPfAL(object r0, int r1, short r2, char r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BLXRnZiLTtqZPfAL(object r0, int r1, short r2, int r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object CCSZrcBQzwJAdJCd(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void CCSZrcBQzwJAdJCd(object r0, int r1, float r2, short r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CCSZrcBQzwJAdJCd(object r0, int r1, short r2, string r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CCSZrcBQzwJAdJCd(object r0, int r1, bool r2, string r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object CxtCAVhbFEbcuSCV(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void CxtCAVhbFEbcuSCV(object r0, int r1, char r2, int r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CxtCAVhbFEbcuSCV(object r0, int r1, char r2, int r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CxtCAVhbFEbcuSCV(object r0, int r1, bool r2, short r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DEBhpryunaxrbPjJ(objectGroup r0, object r1) {
        r0.addobject(r1);
    }

    public static void DEBhpryunaxrbPjJ(objectGroup r0, object r1, byte r2, string r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DEBhpryunaxrbPjJ(objectGroup r0, object r1, byte r2, bool r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DEBhpryunaxrbPjJ(objectGroup r0, object r1, float r2, string r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string GicBzAHuutIqMOLk(Resources r1, int r2) {
        return r1.getResourceName(r2);
    }

    public static void GicBzAHuutIqMOLk(Resources r0, int r1, float r2, string r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GicBzAHuutIqMOLk(Resources r0, int r1, string r2, char r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GicBzAHuutIqMOLk(Resources r0, int r1, string r2, float r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object HQXCHYPaVwdWSSFY(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void HQXCHYPaVwdWSSFY(object r0, int r1, int r2, string r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HQXCHYPaVwdWSSFY(object r0, int r1, string r2, byte r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HQXCHYPaVwdWSSFY(object r0, int r1, string r2, int r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object HqxsWsPjFKhaMlml(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void HqxsWsPjFKhaMlml(object r0, int r1, byte r2, int r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HqxsWsPjFKhaMlml(object r0, int r1, float r2, int r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HqxsWsPjFKhaMlml(object r0, int r1, float r2, string r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object IXlWVtMzgBAFmSjj(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void IXlWVtMzgBAFmSjj(object r0, int r1, short r2, int r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IXlWVtMzgBAFmSjj(object r0, int r1, short r2, int r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IXlWVtMzgBAFmSjj(object r0, int r1, bool r2, string r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object LSGzzEWBFNsYkPIS(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void LSGzzEWBFNsYkPIS(object r0, int r1, float r2, char r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LSGzzEWBFNsYkPIS(object r0, int r1, int r2, char r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LSGzzEWBFNsYkPIS(object r0, int r1, string r2, float r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object LVQvXqASYtBCJbkQ(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void LVQvXqASYtBCJbkQ(object r0, int r1, char r2, short r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LVQvXqASYtBCJbkQ(object r0, int r1, char r2, bool r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LVQvXqASYtBCJbkQ(object r0, int r1, short r2, float r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static pf37d3c3d LppicrzSVOETiUrR(object r1) {
        return pf37d3c3d.m128477f5(r1);
    }

    public static void LppicrzSVOETiUrR(object r0, char r1, float r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LppicrzSVOETiUrR(object r0, string r1, float r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LppicrzSVOETiUrR(object r0, short r1, string r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static pe6b96fff M128477f5(object rootobject) {
        if (((25 + 19) % 19) > 0) goto L174;
    L174:
        int r1 = C2880R.id.add_position_to_receipt_button;
        floatingActionButton r5 = (floatingActionButton) HzycScuAxKayLCOV(rootobject, r1);
        if (r5 is null) goto L158;
        r1 = C2880R.id.btn_pay_group;
        RelativeLayout r6 = (RelativeLayout) TptONOOwZGzMAzjQ(rootobject, r1);
        if (r6 is null) goto L158;
        r1 = C2880R.id.button_add_group_layout;
        ConstraintLayout r7 = (ConstraintLayout) lVQvXqASYtBCJbkQ(rootobject, r1);
        if (r7 is null) goto L158;
        r1 = C2880R.id.close_expandable_menu_button;
        floatingActionButton r8 = (floatingActionButton) hQXCHYPaVwdWSSFY(rootobject, r1);
        if (r8 is null) goto L158;
        r1 = C2880R.id.descriptionTv;
        Textobject r9 = (Textobject) hqxsWsPjFKhaMlml(rootobject, r1);
        if (r9 is null) goto L158;
        r1 = C2880R.id.empty;
        LinearLayout r10 = (LinearLayout) cCSZrcBQzwJAdJCd(rootobject, r1);
        if (r10 is null) goto L158;
        r1 = C2880R.id.floating_button_description;
        Textobject r11 = (Textobject) cxtCAVhbFEbcuSCV(rootobject, r1);
        if (r11 is null) goto L158;
        r1 = C2880R.id.item_receipt_note;
        object r2 = ExVuntPrHDGVqnAu(rootobject, r1);
        if (r2 is null) goto L158;
        pf37d3c3d r12 = lppicrzSVOETiUrR(r2);
        r1 = C2880R.id.linearLayout;
        LinearLayout r13 = (LinearLayout) iXlWVtMzgBAFmSjj(rootobject, r1);
        if (r13 is null) goto L158;
        r1 = C2880R.id.loader;
        p5e9061ea r14 = (p5e9061ea) YvIRkGLIYuvanApr(rootobject, r1);
        if (r14 is null) goto L158;
        r1 = C2880R.id.overlay;
        ConstraintLayout r15 = (ConstraintLayout) vNbblaQGNRVxbHOr(rootobject, r1);
        if (r15 is null) goto L158;
        r1 = C2880R.id.paybackDisabledTv;
        Textobject r16 = (Textobject) ArXtQlQUtjembUrD(rootobject, r1);
        if (r16 is null) goto L158;
        r1 = C2880R.id.paybackEnabledTv;
        Textobject r17 = (Textobject) WrABdeITrFNMXhnq(rootobject, r1);
        if (r17 is null) goto L158;
        r1 = C2880R.id.payback_receipt_disabled_payment_button;
        ConstraintLayout r18 = (ConstraintLayout) SPvwqPsaxidhDbVW(rootobject, r1);
        if (r18 is null) goto L158;
        r1 = C2880R.id.payback_receipt_to_payment_button;
        ConstraintLayout r19 = (ConstraintLayout) ObzkiwXuMaPmyQef(rootobject, r1);
        if (r19 is null) goto L158;
        r1 = C2880R.id.receipt_button_price_text_disabled;
        Textobject r20 = (Textobject) lSGzzEWBFNsYkPIS(rootobject, r1);
        if (r20 is null) goto L158;
        r1 = C2880R.id.rv_payback_positions;
        Recyclerobject r21 = (Recyclerobject) WUmdEaviUrsQpnjE(rootobject, r1);
        if (r21 is null) goto L158;
        r1 = C2880R.id.scroll;
        Scrollobject r22 = (Scrollobject) bLXRnZiLTtqZPfAL(rootobject, r1);
        if (r22 is null) goto L158;
        r1 = C2880R.id.to_receipt_button_total_price_text;
        Textobject r23 = (Textobject) oDDPNyyAJGRcNPME(rootobject, r1);
        if (r23 is null) goto L158;
        r1 = C2880R.id.toolbar;
        Toolbar r24 = (Toolbar) vtNsMSUGlwgiFGTH(rootobject, r1);
        if (r24 is null) goto L158;
        r1 = C2880R.id.view_stub_expandable_fab_menu;
        objectStub r25 = (objectStub) ufeVTaOsBWHwWLQH(rootobject, r1);
        if (r25 is null) goto L158;
        return new pe6b96fff((ConstraintLayout) rootobject, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25);
    L158:
        throw new NullPointerException(PbBetLNxDNaUvJUz("Missing required view with ID: ", gicBzAHuutIqMOLk(WuWTiBLHsYsNJIvJ(rootobject), r1)));
    }

    public static void M128477f5(object r0, char r1, short r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M128477f5(object r0, short r1, bool r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M128477f5(object r0, bool r1, char r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static pe6b96fff M89daba64(LayoutInflater inflater) {
        if (((17 + 23) % 23) > 0) goto L6;
    L6:
        return VJyvGbFXLqyLKCiN(inflater, null, false);
    }

    public static pe6b96fff M89daba64(LayoutInflater inflater, objectGroup parent, bool attachToParent) {
        if (((7 + 4) % 4) > 0) goto L15;
    L15:
        object r2 = roHVOrfKwqUuMcWf(inflater, C2880R.layout.fragment_payback_positions, parent, false);
        if (attachToParent == false) goto L23;
        dEBhpryunaxrbPjJ(parent, r2);
    L23:
        return JOsXQfMbJOuHUcWS(r2);
    }

    public static void M89daba64(LayoutInflater r0, byte r1, string r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, char r1, bool r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, objectGroup r1, bool r2, char r3, bool r4, float r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, objectGroup r1, bool r2, char r3, bool r4, int r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, objectGroup r1, bool r2, bool r3, float r4, char r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, string r1, bool r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object ODDPNyyAJGRcNPME(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void ODDPNyyAJGRcNPME(object r0, int r1, char r2, short r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ODDPNyyAJGRcNPME(object r0, int r1, char r2, short r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ODDPNyyAJGRcNPME(object r0, int r1, int r2, char r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object RoHVOrfKwqUuMcWf(LayoutInflater r1, int r2, objectGroup r3, bool r4) {
        return r1.inflate(r2, r3, r4);
    }

    public static void RoHVOrfKwqUuMcWf(LayoutInflater r0, int r1, objectGroup r2, bool r3, byte r4, int r5, float r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void RoHVOrfKwqUuMcWf(LayoutInflater r0, int r1, objectGroup r2, bool r3, float r4, string r5, byte r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void RoHVOrfKwqUuMcWf(LayoutInflater r0, int r1, objectGroup r2, bool r3, string r4, int r5, float r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static object UfeVTaOsBWHwWLQH(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void UfeVTaOsBWHwWLQH(object r0, int r1, byte r2, short r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UfeVTaOsBWHwWLQH(object r0, int r1, int r2, bool r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UfeVTaOsBWHwWLQH(object r0, int r1, short r2, bool r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object VNbblaQGNRVxbHOr(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void VNbblaQGNRVxbHOr(object r0, int r1, string r2, short r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VNbblaQGNRVxbHOr(object r0, int r1, string r2, short r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VNbblaQGNRVxbHOr(object r0, int r1, string r2, bool r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object VtNsMSUGlwgiFGTH(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void VtNsMSUGlwgiFGTH(object r0, int r1, int r2, bool r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VtNsMSUGlwgiFGTH(object r0, int r1, short r2, bool r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VtNsMSUGlwgiFGTH(object r0, int r1, bool r2, byte r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    @Override // androidx.viewbinding.objectBinding
    public /* bridge */ /* synthetic */ object getRoot() {
        return EiJHwUprPYHvbAjw(this);
    }

    @Override // androidx.viewbinding.objectBinding
    public ConstraintLayout GetRoot() {
        return this.f076d9edf;
    }
}

