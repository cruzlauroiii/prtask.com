using Android.Content.Res;
using Android.View;
using Android.Widget;
using Androidx.Appcompat.Widget;
using Androidx.Constraintlayout.Widget;
using Androidx.Recyclerview.Widget;
using Androidx.Viewbinding;
using Com.Google.Android.Material.Floatingactionbutton;
using P4d236d9a.P2df4812c.Pf5d7e253.P705f8913.P518a4861.P8325324b.P86ccec3d;
using P4d236d9a.P2df4812c.Pf5d7e253.P705f8913.P9efab239.P59a14a57.Pec341acd;
using P59a14a57.P4a527f83;
using P8325324b.P2486923a.Pde95b43b.P1bda80f2;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes18.dex */
public readonly class p41ac465e : objectBinding {
    public readonly ConstraintLayout f00bc0ff0;
    public readonly ConstraintLayout f051da4e5;
    private readonly ConstraintLayout f076d9edf;
    public readonly Scrollobject f089b0cdd;
    public readonly pf37d3c3d f0b1c19f7;
    public readonly Scrollobject f0fe7ac5d;
    public readonly ConstraintLayout f178f6c86;
    public readonly ConstraintLayout f183c26fd;
    public readonly ConstraintLayout f1ecf9f88;
    public readonly ConstraintLayout f21012ebe;
    public readonly RelativeLayout f24a97f1d;
    public readonly Recyclerobject f27cc82f1;
    public readonly floatingActionButton f2b4fd2fa;
    public readonly floatingActionButton f2ce144d6;
    public readonly floatingActionButton f2d56ce77;
    public readonly RelativeLayout f31291d52;
    public readonly p702df4cc f329754e4;
    public readonly Toolbar f3598b02c;
    public readonly Textobject f35abb3d8;
    public readonly ConstraintLayout f380e537a;
    public readonly ConstraintLayout f3ff6f0f3;
    public readonly Textobject f42c7979e;
    public readonly p5e9061ea f4a527f83;
    public readonly ConstraintLayout f5781d349;
    public readonly ConstraintLayout f608955fe;
    public readonly Textobject f61494514;
    public readonly AppCompatImageobject f64c28636;
    public readonly Textobject f655c1250;
    public readonly Textobject f65976208;
    public readonly p702df4cc f66a2adaf;
    public readonly ConstraintLayout f6cbc18f1;
    public readonly Textobject f6cf13f1b;
    public readonly Scrollobject f7548b258;
    public readonly LinearLayout f79be0062;
    public readonly Textobject f7b39c910;
    public readonly Textobject f7b5a7cbc;
    public readonly Scrollobject f7ce3cf85;
    public readonly Recyclerobject f815540b1;
    public readonly Textobject f8c404eb1;
    public readonly Textobject f8dda5ad6;
    public readonly ConstraintLayout f8ebfb635;
    public readonly ConstraintLayout f921700e4;
    public readonly ConstraintLayout f93c383b2;
    public readonly ConstraintLayout f97c2cfa6;
    public readonly ConstraintLayout f9a0364b9;
    public readonly p702df4cc f9aba3abc;
    public readonly ConstraintLayout f9ceb192d;
    public readonly pf37d3c3d f9e2e12a2;
    public readonly Textobject fa01c757d;
    public readonly AppCompatImageobject fa05845c3;
    public readonly LinearLayout fa2e4822a;
    public readonly p5e9061ea fa6423bd7;
    public readonly Textobject fa6ee3755;
    public readonly p702df4cc fa7d64593;
    public readonly ConstraintLayout fa8d57d5f;
    public readonly RelativeLayout fa94423ed;
    public readonly objectStub fad28bb6d;
    public readonly p5e9061ea fb0208885;
    public readonly p5e9061ea fb6d5a7a9;
    public readonly p5e9061ea fbb39a4a3;
    public readonly LinearLayout fbbeecad4;
    public readonly floatingActionButton fc13306a5;
    public readonly Textobject fc2615bd7;
    public readonly Textobject fc3079249;
    public readonly LinearLayout fc82ef934;
    public readonly Textobject fc834a80b;
    public readonly floatingActionButton fc91eb6a7;
    public readonly floatingActionButton fc98d48c7;
    public readonly LinearLayout fd1387868;
    public readonly floatingActionButton fd4810f58;
    public readonly Textobject fd4dc8172;
    public readonly RelativeLayout fd5f57c8f;
    private readonly ConstraintLayout fd6babce2;
    public readonly AppCompatImageobject fdce7c417;
    public readonly ConstraintLayout fe452cdb4;
    public readonly objectStub fe4f4e213;
    public readonly Scrollobject fe8ac0270;
    public readonly objectStub fe8df9f0d;
    public readonly ConstraintLayout fe9d36ad7;
    public readonly LinearLayout fea662dad;
    public readonly AppCompatImageobject fee5db9e7;
    public readonly Textobject ff2a0859b;
    public readonly Textobject ff47952d3;
    public readonly Toolbar ff50b3c2a;
    private readonly ConstraintLayout ff74db45b;
    public readonly Textobject ff7888983;
    public readonly AppCompatImageobject ff9726854;

    private p41ac465e(ConstraintLayout rootobject, Textobject addPositionDescriptionTv, floatingActionButton addPositionToReceiptButton, RelativeLayout btnPayGroup, ConstraintLayout buttonAddGroupLayout, floatingActionButton closeExpandableMenuButton, ConstraintLayout content, LinearLayout empty, Textobject floatingButtonDescription, pf37d3c3d itemReceiptNote, LinearLayout linearLayout, p5e9061ea loader, AppCompatImageobject lock, ConstraintLayout overlay, Textobject receiptButtonPriceTextDisabled, Scrollobject scroll, ConstraintLayout sellReceiptDisabledPaymentButton, Recyclerobject sellReceiptPositionsRecyclerobject, ConstraintLayout sellReceiptToPaymentButton, Textobject toPayDisabledTv, Textobject toPayEnabledTv, Textobject toReceiptButtonTotalPriceText, Toolbar toolbar, p702df4cc viewReceiptBoarding, objectStub viewStubExpandableFabMenu) {
        this.f076d9edf = rootobject;
        this.fc834a80b = addPositionDescriptionTv;
        this.fc98d48c7 = addPositionToReceiptButton;
        this.fa94423ed = btnPayGroup;
        this.f8ebfb635 = buttonAddGroupLayout;
        this.fd4810f58 = closeExpandableMenuButton;
        this.f9a0364b9 = content;
        this.fa2e4822a = empty;
        this.ff47952d3 = floatingButtonDescription;
        this.f9e2e12a2 = itemReceiptNote;
        this.fd1387868 = linearLayout;
        this.f4a527f83 = loader;
        this.fdce7c417 = lock;
        this.f380e537a = overlay;
        this.ff7888983 = receiptButtonPriceTextDisabled;
        this.f089b0cdd = scroll;
        this.f3ff6f0f3 = sellReceiptDisabledPaymentButton;
        this.f815540b1 = sellReceiptPositionsRecyclerobject;
        this.f183c26fd = sellReceiptToPaymentButton;
        this.f42c7979e = toPayDisabledTv;
        this.f7b5a7cbc = toPayEnabledTv;
        this.fc2615bd7 = toReceiptButtonTotalPriceText;
        this.ff50b3c2a = toolbar;
        this.f9aba3abc = viewReceiptBoarding;
        this.fe4f4e213 = viewStubExpandableFabMenu;
    }

    public static object CobnmzEYhkAYtLZe(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void CobnmzEYhkAYtLZe(object r0, int r1, string r2, short r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CobnmzEYhkAYtLZe(object r0, int r1, string r2, bool r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CobnmzEYhkAYtLZe(object r0, int r1, short r2, int r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object DihXAUpzlYLYxiGE(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void DihXAUpzlYLYxiGE(object r0, int r1, float r2, bool r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DihXAUpzlYLYxiGE(object r0, int r1, bool r2, float r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DihXAUpzlYLYxiGE(object r0, int r1, bool r2, int r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object EDNfFaRjsAyrEzHr(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void EDNfFaRjsAyrEzHr(object r0, int r1, char r2, short r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EDNfFaRjsAyrEzHr(object r0, int r1, short r2, bool r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EDNfFaRjsAyrEzHr(object r0, int r1, bool r2, char r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object EbqBLgsUfhRMiNLE(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void EbqBLgsUfhRMiNLE(object r0, int r1, string r2, byte r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EbqBLgsUfhRMiNLE(object r0, int r1, string r2, float r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EbqBLgsUfhRMiNLE(object r0, int r1, string r2, bool r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object GcosPLZLWKEvpOtO(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void GcosPLZLWKEvpOtO(object r0, int r1, byte r2, float r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GcosPLZLWKEvpOtO(object r0, int r1, float r2, byte r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GcosPLZLWKEvpOtO(object r0, int r1, float r2, char r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object HDOZeAenqWJHiEZS(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void HDOZeAenqWJHiEZS(object r0, int r1, char r2, float r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HDOZeAenqWJHiEZS(object r0, int r1, char r2, string r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HDOZeAenqWJHiEZS(object r0, int r1, string r2, float r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object HeNLPvcuevyazQdY(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void HeNLPvcuevyazQdY(object r0, int r1, int r2, bool r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HeNLPvcuevyazQdY(object r0, int r1, bool r2, int r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HeNLPvcuevyazQdY(object r0, int r1, bool r2, int r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object LhrmyOtrZPxUGqTI(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void LhrmyOtrZPxUGqTI(object r0, int r1, float r2, string r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LhrmyOtrZPxUGqTI(object r0, int r1, string r2, float r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LhrmyOtrZPxUGqTI(object r0, int r1, bool r2, byte r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object MrKNBgNgidYJETRF(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void MrKNBgNgidYJETRF(object r0, int r1, byte r2, int r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MrKNBgNgidYJETRF(object r0, int r1, int r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MrKNBgNgidYJETRF(object r0, int r1, int r2, short r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string NOrCIrqKiCuAkGMZ(Resources r1, int r2) {
        return r1.getResourceName(r2);
    }

    public static void NOrCIrqKiCuAkGMZ(Resources r0, int r1, float r2, int r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NOrCIrqKiCuAkGMZ(Resources r0, int r1, float r2, string r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NOrCIrqKiCuAkGMZ(Resources r0, int r1, int r2, char r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static p41ac465e OoqztbRsjZGRBTwF(LayoutInflater r1, objectGroup r2, bool r3) {
        return m89daba64(r1, r2, r3);
    }

    public static void OoqztbRsjZGRBTwF(LayoutInflater r0, objectGroup r1, bool r2, float r3, short r4, bool r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void OoqztbRsjZGRBTwF(LayoutInflater r0, objectGroup r1, bool r2, float r3, bool r4, int r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void OoqztbRsjZGRBTwF(LayoutInflater r0, objectGroup r1, bool r2, bool r3, int r4, float r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static object PNJQRBdHyDsyVoaM(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void PNJQRBdHyDsyVoaM(object r0, int r1, byte r2, string r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PNJQRBdHyDsyVoaM(object r0, int r1, char r2, string r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PNJQRBdHyDsyVoaM(object r0, int r1, string r2, char r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QPINGYSYyfCOGaHJ(objectGroup r0, object r1) {
        r0.addobject(r1);
    }

    public static void QPINGYSYyfCOGaHJ(objectGroup r0, object r1, float r2, int r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QPINGYSYyfCOGaHJ(objectGroup r0, object r1, short r2, float r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QPINGYSYyfCOGaHJ(objectGroup r0, object r1, bool r2, short r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object VPVmaduyukvcYDGb(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void VPVmaduyukvcYDGb(object r0, int r1, int r2, char r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VPVmaduyukvcYDGb(object r0, int r1, int r2, short r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VPVmaduyukvcYDGb(object r0, int r1, short r2, byte r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object XgBMWCpFCiAdPtez(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void XgBMWCpFCiAdPtez(object r0, int r1, byte r2, int r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XgBMWCpFCiAdPtez(object r0, int r1, float r2, byte r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XgBMWCpFCiAdPtez(object r0, int r1, float r2, short r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object AFpgIVCbBGGvKqGk(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void AFpgIVCbBGGvKqGk(object r0, int r1, int r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AFpgIVCbBGGvKqGk(object r0, int r1, int r2, bool r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AFpgIVCbBGGvKqGk(object r0, int r1, int r2, bool r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object ClwzZNuxDwrKiDBU(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void ClwzZNuxDwrKiDBU(object r0, int r1, int r2, float r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ClwzZNuxDwrKiDBU(object r0, int r1, short r2, float r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ClwzZNuxDwrKiDBU(object r0, int r1, short r2, string r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object EfeAKwGJxixrcTVH(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void EfeAKwGJxixrcTVH(object r0, int r1, byte r2, int r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EfeAKwGJxixrcTVH(object r0, int r1, char r2, int r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EfeAKwGJxixrcTVH(object r0, int r1, char r2, string r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static pf37d3c3d EtvbQMWPZbQcTlLy(object r1) {
        return pf37d3c3d.m128477f5(r1);
    }

    public static void EtvbQMWPZbQcTlLy(object r0, byte r1, string r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EtvbQMWPZbQcTlLy(object r0, float r1, string r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EtvbQMWPZbQcTlLy(object r0, string r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object KkFfwStgRKwCdjHY(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void KkFfwStgRKwCdjHY(object r0, int r1, byte r2, char r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KkFfwStgRKwCdjHY(object r0, int r1, char r2, int r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KkFfwStgRKwCdjHY(object r0, int r1, int r2, float r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object LDEynuzHOoNgYIlt(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void LDEynuzHOoNgYIlt(object r0, int r1, bool r2, byte r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LDEynuzHOoNgYIlt(object r0, int r1, bool r2, int r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LDEynuzHOoNgYIlt(object r0, int r1, bool r2, short r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object LVMczEtSvmEScakx(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void LVMczEtSvmEScakx(object r0, int r1, byte r2, short r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LVMczEtSvmEScakx(object r0, int r1, float r2, byte r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LVMczEtSvmEScakx(object r0, int r1, float r2, short r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static p41ac465e M128477f5(object rootobject) {
        if (((22 + 1) % 1) > 0) goto L91;
    L91:
        int r1 = C2845R.id.addPositionDescriptionTv;
        Textobject r5 = (Textobject) clwzZNuxDwrKiDBU(rootobject, r1);
        if (r5 is null) goto L43;
        r1 = C2845R.id.add_position_to_receipt_button;
        floatingActionButton r6 = (floatingActionButton) lDEynuzHOoNgYIlt(rootobject, r1);
        if (r6 is null) goto L43;
        r1 = C2845R.id.btn_pay_group;
        RelativeLayout r7 = (RelativeLayout) uXpxCZQVqnCCIKIN(rootobject, r1);
        if (r7 is null) goto L43;
        r1 = C2845R.id.button_add_group_layout;
        ConstraintLayout r8 = (ConstraintLayout) HeNLPvcuevyazQdY(rootobject, r1);
        if (r8 is null) goto L43;
        r1 = C2845R.id.close_expandable_menu_button;
        floatingActionButton r9 = (floatingActionButton) yZhzCgLRMJmPbaLV(rootobject, r1);
        if (r9 is null) goto L43;
        r1 = C2845R.id.content;
        ConstraintLayout r10 = (ConstraintLayout) EbqBLgsUfhRMiNLE(rootobject, r1);
        if (r10 is null) goto L43;
        r1 = C2845R.id.empty;
        LinearLayout r11 = (LinearLayout) kkFfwStgRKwCdjHY(rootobject, r1);
        if (r11 is null) goto L43;
        r1 = C2845R.id.floating_button_description;
        Textobject r12 = (Textobject) PNJQRBdHyDsyVoaM(rootobject, r1);
        if (r12 is null) goto L43;
        r1 = C2845R.id.item_receipt_note;
        object r2 = lVMczEtSvmEScakx(rootobject, r1);
        if (r2 is null) goto L43;
        pf37d3c3d r13 = etvbQMWPZbQcTlLy(r2);
        r1 = C2845R.id.linearLayout;
        LinearLayout r14 = (LinearLayout) MrKNBgNgidYJETRF(rootobject, r1);
        if (r14 is null) goto L43;
        r1 = C2845R.id.loader;
        p5e9061ea r15 = (p5e9061ea) DihXAUpzlYLYxiGE(rootobject, r1);
        if (r15 is null) goto L43;
        r1 = C2845R.id.lock;
        AppCompatImageobject r16 = (AppCompatImageobject) EDNfFaRjsAyrEzHr(rootobject, r1);
        if (r16 is null) goto L43;
        r1 = C2845R.id.overlay;
        ConstraintLayout r17 = (ConstraintLayout) HDOZeAenqWJHiEZS(rootobject, r1);
        if (r17 is null) goto L43;
        r1 = C2845R.id.receipt_button_price_text_disabled;
        Textobject r18 = (Textobject) srUvfmNrFXehLsRI(rootobject, r1);
        if (r18 is null) goto L43;
        r1 = C2845R.id.scroll;
        Scrollobject r19 = (Scrollobject) XgBMWCpFCiAdPtez(rootobject, r1);
        if (r19 is null) goto L43;
        r1 = C2845R.id.sell_receipt_disabled_payment_button;
        ConstraintLayout r20 = (ConstraintLayout) CobnmzEYhkAYtLZe(rootobject, r1);
        if (r20 is null) goto L43;
        r1 = C2845R.id.sell_receipt_positions_recycler_view;
        Recyclerobject r21 = (Recyclerobject) ztCfJxIieZNeqdQH(rootobject, r1);
        if (r21 is null) goto L43;
        r1 = C2845R.id.sell_receipt_to_payment_button;
        ConstraintLayout r22 = (ConstraintLayout) GcosPLZLWKEvpOtO(rootobject, r1);
        if (r22 is null) goto L43;
        r1 = C2845R.id.toPayDisabledTv;
        Textobject r23 = (Textobject) efeAKwGJxixrcTVH(rootobject, r1);
        if (r23 is null) goto L43;
        r1 = C2845R.id.toPayEnabledTv;
        Textobject r24 = (Textobject) aFpgIVCbBGGvKqGk(rootobject, r1);
        if (r24 is null) goto L43;
        r1 = C2845R.id.to_receipt_button_total_price_text;
        Textobject r25 = (Textobject) mlpBAOOWLDyymjch(rootobject, r1);
        if (r25 is null) goto L43;
        r1 = C2845R.id.toolbar;
        Toolbar r26 = (Toolbar) LhrmyOtrZPxUGqTI(rootobject, r1);
        if (r26 is null) goto L43;
        r1 = C2845R.id.view_receipt_boarding;
        p702df4cc r27 = (p702df4cc) oOirJCOivivfcQFt(rootobject, r1);
        if (r27 is null) goto L43;
        r1 = C2845R.id.view_stub_expandable_fab_menu;
        objectStub r28 = (objectStub) VPVmaduyukvcYDGb(rootobject, r1);
        if (r28 is null) goto L43;
        return new p41ac465e((ConstraintLayout) rootobject, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28);
    L43:
        throw new NullPointerException(nVfNxGCTMsLddNWT("Missing required view with ID: ", NOrCIrqKiCuAkGMZ(wMioFdDFjrxgoveJ(rootobject), r1)));
    }

    public static void M128477f5(object r0, char r1, short r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M128477f5(object r0, string r1, char r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M128477f5(object r0, string r1, short r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static p41ac465e M89daba64(LayoutInflater inflater) {
        if (((13 + 31) % 31) > 0) goto L20;
    L20:
        return OoqztbRsjZGRBTwF(inflater, null, false);
    }

    public static p41ac465e M89daba64(LayoutInflater inflater, objectGroup parent, bool attachToParent) {
        if (((25 + 11) % 11) > 0) goto L6;
    L6:
        object r2 = yEgnCfdGdvtWAMeI(inflater, C2845R.layout.fragment_edit_sell_receipt, parent, false);
        if (attachToParent == false) goto L13;
        QPINGYSYyfCOGaHJ(parent, r2);
    L13:
        return rvNbtMgxTVsYbdOD(r2);
    }

    public static void M89daba64(LayoutInflater r0, char r1, short r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, int r1, short r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, objectGroup r1, bool r2, char r3, string r4, byte r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, objectGroup r1, bool r2, short r3, char r4, byte r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, objectGroup r1, bool r2, short r3, char r4, string r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, short r1, int r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object MlpBAOOWLDyymjch(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void MlpBAOOWLDyymjch(object r0, int r1, char r2, bool r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MlpBAOOWLDyymjch(object r0, int r1, char r2, bool r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MlpBAOOWLDyymjch(object r0, int r1, string r2, bool r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string NVfNxGCTMsLddNWT(string r1, string r2) {
        return r1.concat(r2);
    }

    public static void NVfNxGCTMsLddNWT(string r0, string r1, float r2, string r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NVfNxGCTMsLddNWT(string r0, string r1, float r2, short r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NVfNxGCTMsLddNWT(string r0, string r1, int r2, short r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object OOirJCOivivfcQFt(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void OOirJCOivivfcQFt(object r0, int r1, byte r2, int r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OOirJCOivivfcQFt(object r0, int r1, int r2, byte r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OOirJCOivivfcQFt(object r0, int r1, string r2, float r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static p41ac465e RvNbtMgxTVsYbdOD(object r1) {
        return m128477f5(r1);
    }

    public static void RvNbtMgxTVsYbdOD(object r0, byte r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RvNbtMgxTVsYbdOD(object r0, float r1, byte r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RvNbtMgxTVsYbdOD(object r0, float r1, short r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static ConstraintLayout SjgyeIsfLVfbcino(p41ac465e r1) {
        return r1.getRoot();
    }

    public static void SjgyeIsfLVfbcino(p41ac465e r0, char r1, int r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SjgyeIsfLVfbcino(p41ac465e r0, char r1, string r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SjgyeIsfLVfbcino(p41ac465e r0, string r1, short r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object SrUvfmNrFXehLsRI(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void SrUvfmNrFXehLsRI(object r0, int r1, byte r2, string r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SrUvfmNrFXehLsRI(object r0, int r1, float r2, byte r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SrUvfmNrFXehLsRI(object r0, int r1, string r2, char r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object UXpxCZQVqnCCIKIN(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void UXpxCZQVqnCCIKIN(object r0, int r1, char r2, short r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UXpxCZQVqnCCIKIN(object r0, int r1, int r2, short r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UXpxCZQVqnCCIKIN(object r0, int r1, short r2, char r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static Resources WMioFdDFjrxgoveJ(object r1) {
        return r1.getResources();
    }

    public static void WMioFdDFjrxgoveJ(object r0, byte r1, bool r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WMioFdDFjrxgoveJ(object r0, float r1, bool r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WMioFdDFjrxgoveJ(object r0, bool r1, byte r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object YEgnCfdGdvtWAMeI(LayoutInflater r1, int r2, objectGroup r3, bool r4) {
        return r1.inflate(r2, r3, r4);
    }

    public static void YEgnCfdGdvtWAMeI(LayoutInflater r0, int r1, objectGroup r2, bool r3, char r4, byte r5, int r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void YEgnCfdGdvtWAMeI(LayoutInflater r0, int r1, objectGroup r2, bool r3, float r4, byte r5, char r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void YEgnCfdGdvtWAMeI(LayoutInflater r0, int r1, objectGroup r2, bool r3, float r4, byte r5, int r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static object YZhzCgLRMJmPbaLV(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void YZhzCgLRMJmPbaLV(object r0, int r1, byte r2, short r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YZhzCgLRMJmPbaLV(object r0, int r1, string r2, short r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YZhzCgLRMJmPbaLV(object r0, int r1, short r2, string r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object ZtCfJxIieZNeqdQH(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void ZtCfJxIieZNeqdQH(object r0, int r1, char r2, int r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZtCfJxIieZNeqdQH(object r0, int r1, float r2, char r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZtCfJxIieZNeqdQH(object r0, int r1, int r2, char r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    @Override // androidx.viewbinding.objectBinding
    public /* bridge */ /* synthetic */ object getRoot() {
        return sjgyeIsfLVfbcino(this);
    }

    @Override // androidx.viewbinding.objectBinding
    public ConstraintLayout GetRoot() {
        return this.f076d9edf;
    }
}

