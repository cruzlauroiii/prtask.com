using Android.Content.Res;
using Android.View;
using Android.Widget;
using Androidx.Appcompat.Widget;
using Androidx.Cardview.Widget;
using Androidx.Constraintlayout.Widget;
using Androidx.Core.Widget;
using Androidx.Viewbinding;
using Com.Google.Android.Material.Appbar;
using Com.Google.Android.Material.Button;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes.dex */
public readonly class p96d30f99 : objectBinding {
    public readonly Textobject f05882d51;
    public readonly AppCompatImageobject f060c58fd;
    public readonly Textobject f06f12463;
    private readonly ConstraintLayout f076d9edf;
    public readonly Cardobject f0b248f64;
    public readonly Cardobject f0b33c718;
    public readonly FrameLayout f0fa010a6;
    public readonly Textobject f1140ba51;
    public readonly FrameLayout f12f6837b;
    public readonly pcdc83945 f145087a8;
    public readonly NestedScrollobject f19b6db05;
    public readonly AppCompatImageobject f1b90ea4a;
    public readonly Button f1ba8dcac;
    public readonly MaterialToolbar f1f7b0ad0;
    public readonly pcdc83945 f2005da6f;
    public readonly Textobject f247a38b5;
    public readonly Cardobject f265efc5d;
    public readonly Textobject f2e7ec588;
    public readonly Cardobject f30eabffc;
    public readonly Textobject f3577b896;
    public readonly Textobject f368ea36f;
    public readonly Textobject f36b18a86;
    public readonly Textobject f3933453f;
    public readonly AppCompatImageobject f3c0c550b;
    public readonly pcdc83945 f3d869acf;
    public readonly Textobject f419d8bc3;
    public readonly ConstraintLayout f4c53361a;
    private readonly ConstraintLayout f4c64ad14;
    public readonly ConstraintLayout f5403bd0f;
    public readonly Textobject f5421b40e;
    public readonly AppCompatImageobject f570d1aef;
    public readonly AppCompatImageobject f57ca0ce8;
    public readonly Textobject f59a3ca27;
    public readonly AppCompatImageobject f5cd4b3e4;
    public readonly MaterialButton f61182e34;
    public readonly Textobject f61e1a3ef;
    public readonly SwitchCompat f6244f310;
    public readonly Textobject f65037edd;
    private readonly ConstraintLayout f6587d5d1;
    public readonly Textobject f65b3f2dc;
    public readonly Textobject f67595656;
    public readonly AppCompatImageobject f6b659ded;
    public readonly Cardobject f6d3e4c73;
    public readonly SwitchCompat f6d7b6ac9;
    public readonly AppCompatImageobject f6e1d094c;
    public readonly Textobject f6e74e8a9;
    public readonly Textobject f6f43c5ff;
    public readonly Textobject f700d2018;
    public readonly AppCompatImageobject f704d21b3;
    public readonly AppCompatImageobject f7572f776;
    private readonly ConstraintLayout f75c9fc28;
    public readonly AppCompatImageobject f764fb28a;
    public readonly Textobject f7d6e6f48;
    public readonly Textobject f806d8d73;
    public readonly Textobject f80e9725a;
    public readonly AppCompatImageobject f85bafdb9;
    public readonly Textobject f87663eb2;
    public readonly AppCompatImageobject f8a13f93f;
    public readonly Cardobject f8a1a751e;
    public readonly Textobject f8e085b00;
    public readonly Textobject f904117ea;
    public readonly Cardobject f944536f7;
    public readonly ConstraintLayout f9a0364b9;
    public readonly NestedScrollobject f9b84a485;
    public readonly AppCompatImageobject f9c3dcb3f;
    public readonly SwitchCompat fa1d18615;
    public readonly AppCompatImageobject fa3f8f5e5;
    public readonly Textobject fa51f6955;
    public readonly Cardobject fa6918e21;
    public readonly FrameLayout fa86f32cc;
    public readonly Textobject fa88b5f4f;
    public readonly Textobject fa916c10c;
    public readonly Button fac8e374f;
    public readonly Cardobject facb1831c;
    public readonly Textobject fb186bc65;
    public readonly AppCompatImageobject fbba33f8c;
    public readonly Textobject fbde9b59d;
    public readonly Textobject fbe59f135;
    public readonly Textobject fc2aa2106;
    public readonly Textobject fc3b3ab8a;
    public readonly AppCompatImageobject fc4cc52a8;
    public readonly Textobject fc5b6020a;
    public readonly SwitchCompat fc6f6cb33;
    public readonly AppCompatImageobject fc869f517;
    public readonly Textobject fcbdddb69;
    public readonly Textobject fd1d29ace;
    public readonly AppCompatImageobject fd3c67329;
    public readonly Textobject fd452f0e9;
    public readonly AppCompatImageobject fd56559d4;
    public readonly Textobject fd5f0eabd;
    public readonly Textobject fd6055f8a;
    public readonly FrameLayout fd67c009e;
    public readonly Button fda3709b9;
    public readonly pcdc83945 fdb276d10;
    public readonly Textobject fdf7032ba;
    public readonly AppCompatImageobject fe187f033;
    public readonly Textobject fe21839eb;
    public readonly Textobject fe742d116;
    public readonly Textobject febed5f24;
    public readonly AppCompatImageobject fef208795;
    public readonly Button fefd3a81a;
    public readonly FrameLayout ff3191642;
    public readonly Textobject ff35c1898;
    public readonly MaterialToolbar ff50b3c2a;
    public readonly MaterialButton ff86d38ae;
    public readonly Textobject ff8f3b761;
    public readonly Textobject ffabc5d24;
    public readonly Textobject ffb9b34b3;
    public readonly AppCompatImageobject fff359355;

    private p96d30f99(ConstraintLayout r1, ConstraintLayout r2, pcdc83945 r3, Button r4, NestedScrollobject r5, AppCompatImageobject r6, Textobject r7, FrameLayout r8, Cardobject r9, AppCompatImageobject r10, Textobject r11, MaterialButton r12, AppCompatImageobject r13, Cardobject r14, AppCompatImageobject r15, Textobject r16, SwitchCompat r17, Textobject r18, AppCompatImageobject r19, Textobject r20, AppCompatImageobject r21, Textobject r22, Textobject r23, Textobject r24, Textobject r25, Textobject r26, Textobject r27, Textobject r28, MaterialToolbar r29) {
        this.f076d9edf = r1;
        this.f9a0364b9 = r2;
        this.fdb276d10 = r3;
        this.fac8e374f = r4;
        this.f9b84a485 = r5;
        this.f6e1d094c = r6;
        this.f80e9725a = r7;
        this.f12f6837b = r8;
        this.f30eabffc = r9;
        this.f570d1aef = r10;
        this.f67595656 = r11;
        this.ff86d38ae = r12;
        this.fa3f8f5e5 = r13;
        this.f8a1a751e = r14;
        this.f85bafdb9 = r15;
        this.f368ea36f = r16;
        this.f6244f310 = r17;
        this.fe21839eb = r18;
        this.fc4cc52a8 = r19;
        this.fbde9b59d = r20;
        this.f1b90ea4a = r21;
        this.f6f43c5ff = r22;
        this.ffabc5d24 = r23;
        this.f05882d51 = r24;
        this.fcbdddb69 = r25;
        this.f1140ba51 = r26;
        this.fc2aa2106 = r27;
        this.f8e085b00 = r28;
        this.ff50b3c2a = r29;
    }

    public static ConstraintLayout AKfroqQAUlRCQFEN(p96d30f99 r1) {
        return r1.getRoot();
    }

    public static void AKfroqQAUlRCQFEN(p96d30f99 r0, float r1, bool r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AKfroqQAUlRCQFEN(p96d30f99 r0, short r1, float r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AKfroqQAUlRCQFEN(p96d30f99 r0, bool r1, float r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object AOmgmAgDqQCfhONk(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void AOmgmAgDqQCfhONk(object r0, int r1, int r2, bool r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AOmgmAgDqQCfhONk(object r0, int r1, bool r2, int r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AOmgmAgDqQCfhONk(object r0, int r1, bool r2, string r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object BAhTMcxmdXPrnWcd(LayoutInflater r1, int r2, objectGroup r3, bool r4) {
        return r1.inflate(r2, r3, r4);
    }

    public static void BAhTMcxmdXPrnWcd(LayoutInflater r0, int r1, objectGroup r2, bool r3, char r4, float r5, byte r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void BAhTMcxmdXPrnWcd(LayoutInflater r0, int r1, objectGroup r2, bool r3, char r4, bool r5, float r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void BAhTMcxmdXPrnWcd(LayoutInflater r0, int r1, objectGroup r2, bool r3, float r4, char r5, byte r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static object COnMmLvjtuCDRfad(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void COnMmLvjtuCDRfad(object r0, int r1, byte r2, float r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void COnMmLvjtuCDRfad(object r0, int r1, float r2, int r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void COnMmLvjtuCDRfad(object r0, int r1, short r2, int r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object CUARMmvDpobyOqcu(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void CUARMmvDpobyOqcu(object r0, int r1, char r2, float r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CUARMmvDpobyOqcu(object r0, int r1, float r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CUARMmvDpobyOqcu(object r0, int r1, short r2, char r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object CbFlyyvfDyglXvzd(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void CbFlyyvfDyglXvzd(object r0, int r1, char r2, float r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CbFlyyvfDyglXvzd(object r0, int r1, float r2, string r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CbFlyyvfDyglXvzd(object r0, int r1, string r2, float r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object DpGZcomVRxabOIpQ(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void DpGZcomVRxabOIpQ(object r0, int r1, byte r2, bool r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DpGZcomVRxabOIpQ(object r0, int r1, int r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DpGZcomVRxabOIpQ(object r0, int r1, bool r2, short r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object LVLjPxVNWDlvKQsB(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void LVLjPxVNWDlvKQsB(object r0, int r1, char r2, float r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LVLjPxVNWDlvKQsB(object r0, int r1, float r2, short r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LVLjPxVNWDlvKQsB(object r0, int r1, short r2, float r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object MUQnXrtQzzbRiYEI(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void MUQnXrtQzzbRiYEI(object r0, int r1, float r2, short r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MUQnXrtQzzbRiYEI(object r0, int r1, string r2, float r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MUQnXrtQzzbRiYEI(object r0, int r1, string r2, float r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object MZeujOBwOdxJjlMv(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void MZeujOBwOdxJjlMv(object r0, int r1, byte r2, float r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MZeujOBwOdxJjlMv(object r0, int r1, string r2, float r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MZeujOBwOdxJjlMv(object r0, int r1, string r2, int r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object MsXGzdXQzaPqQmXA(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void MsXGzdXQzaPqQmXA(object r0, int r1, float r2, byte r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MsXGzdXQzaPqQmXA(object r0, int r1, float r2, byte r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MsXGzdXQzaPqQmXA(object r0, int r1, short r2, byte r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object NbmnJGvbwSXauxAH(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void NbmnJGvbwSXauxAH(object r0, int r1, char r2, byte r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NbmnJGvbwSXauxAH(object r0, int r1, char r2, short r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NbmnJGvbwSXauxAH(object r0, int r1, float r2, short r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object OhtfARMSlyNhIakk(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void OhtfARMSlyNhIakk(object r0, int r1, char r2, int r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OhtfARMSlyNhIakk(object r0, int r1, char r2, bool r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OhtfARMSlyNhIakk(object r0, int r1, bool r2, char r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object PBkJxfCKPeiPTrbR(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void PBkJxfCKPeiPTrbR(object r0, int r1, char r2, string r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PBkJxfCKPeiPTrbR(object r0, int r1, string r2, byte r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PBkJxfCKPeiPTrbR(object r0, int r1, string r2, float r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static Resources PfVntRmbztFoaRWG(object r1) {
        return r1.getResources();
    }

    public static void PfVntRmbztFoaRWG(object r0, byte r1, int r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfVntRmbztFoaRWG(object r0, string r1, int r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfVntRmbztFoaRWG(object r0, bool r1, string r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string UHzJHcjHJGcyAvoB(Resources r1, int r2) {
        return r1.getResourceName(r2);
    }

    public static void UHzJHcjHJGcyAvoB(Resources r0, int r1, char r2, short r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UHzJHcjHJGcyAvoB(Resources r0, int r1, string r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UHzJHcjHJGcyAvoB(Resources r0, int r1, string r2, bool r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object UdlpWqGtQHncQeXC(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void UdlpWqGtQHncQeXC(object r0, int r1, string r2, char r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UdlpWqGtQHncQeXC(object r0, int r1, bool r2, char r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UdlpWqGtQHncQeXC(object r0, int r1, bool r2, float r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object UweXwnLNCXZAdEDt(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void UweXwnLNCXZAdEDt(object r0, int r1, byte r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UweXwnLNCXZAdEDt(object r0, int r1, char r2, string r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UweXwnLNCXZAdEDt(object r0, int r1, string r2, byte r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static pcdc83945 VsAMgGLfIJGoMAzl(object r1) {
        return pcdc83945.m128477f5(r1);
    }

    public static void VsAMgGLfIJGoMAzl(object r0, float r1, string r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VsAMgGLfIJGoMAzl(object r0, int r1, short r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VsAMgGLfIJGoMAzl(object r0, short r1, int r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object WClFPPkiwMGDaFwK(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void WClFPPkiwMGDaFwK(object r0, int r1, int r2, bool r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WClFPPkiwMGDaFwK(object r0, int r1, string r2, byte r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WClFPPkiwMGDaFwK(object r0, int r1, bool r2, int r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object WbwqbrBzbrYYsfha(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void WbwqbrBzbrYYsfha(object r0, int r1, byte r2, bool r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WbwqbrBzbrYYsfha(object r0, int r1, int r2, byte r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WbwqbrBzbrYYsfha(object r0, int r1, short r2, int r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object YzBGiqPULpHSFnzU(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void YzBGiqPULpHSFnzU(object r0, int r1, char r2, bool r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YzBGiqPULpHSFnzU(object r0, int r1, float r2, bool r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YzBGiqPULpHSFnzU(object r0, int r1, string r2, bool r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object ZfbWOcqGRhyWESrz(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void ZfbWOcqGRhyWESrz(object r0, int r1, byte r2, int r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZfbWOcqGRhyWESrz(object r0, int r1, int r2, string r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZfbWOcqGRhyWESrz(object r0, int r1, short r2, int r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object ZwjtIkLkNhoUnwGo(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void ZwjtIkLkNhoUnwGo(object r0, int r1, float r2, byte r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZwjtIkLkNhoUnwGo(object r0, int r1, string r2, float r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZwjtIkLkNhoUnwGo(object r0, int r1, short r2, byte r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BuAYCaZjNgWqPmbf(objectGroup r0, object r1) {
        r0.addobject(r1);
    }

    public static void BuAYCaZjNgWqPmbf(objectGroup r0, object r1, char r2, string r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BuAYCaZjNgWqPmbf(objectGroup r0, object r1, float r2, string r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BuAYCaZjNgWqPmbf(objectGroup r0, object r1, string r2, float r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static p96d30f99 CFPgvuVesIFZcCYo(LayoutInflater r1, objectGroup r2, bool r3) {
        return m89daba64(r1, r2, r3);
    }

    public static void CFPgvuVesIFZcCYo(LayoutInflater r0, objectGroup r1, bool r2, char r3, bool r4, int r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void CFPgvuVesIFZcCYo(LayoutInflater r0, objectGroup r1, bool r2, bool r3, char r4, string r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void CFPgvuVesIFZcCYo(LayoutInflater r0, objectGroup r1, bool r2, bool r3, int r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static object EtpHofCgsRgkCBDE(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void EtpHofCgsRgkCBDE(object r0, int r1, char r2, bool r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EtpHofCgsRgkCBDE(object r0, int r1, short r2, char r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EtpHofCgsRgkCBDE(object r0, int r1, bool r2, char r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string HGJTEZWlMdEPRROJ(string r1, string r2) {
        return r1.concat(r2);
    }

    public static void HGJTEZWlMdEPRROJ(string r0, string r1, byte r2, char r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HGJTEZWlMdEPRROJ(string r0, string r1, char r2, float r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HGJTEZWlMdEPRROJ(string r0, string r1, float r2, char r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static p96d30f99 HkmMTcwoDfUdoRvJ(object r1) {
        return m128477f5(r1);
    }

    public static void HkmMTcwoDfUdoRvJ(object r0, byte r1, float r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HkmMTcwoDfUdoRvJ(object r0, float r1, string r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HkmMTcwoDfUdoRvJ(object r0, string r1, short r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static p96d30f99 M128477f5(object r33) {
        if (((22 + 17) % 17) > 0) goto L188;
    L188:
        int r1 = C2815R.id.content;
        ConstraintLayout r5 = (ConstraintLayout) UdlpWqGtQHncQeXC(r33, r1);
        if (r5 is null) goto L137;
        r1 = C2815R.id.loaderLayout;
        object r2 = ZwjtIkLkNhoUnwGo(r33, r1);
        if (r2 is null) goto L137;
        pcdc83945 r6 = VsAMgGLfIJGoMAzl(r2);
        r1 = C2815R.id.returnBtn;
        Button r7 = (Button) PBkJxfCKPeiPTrbR(r33, r1);
        if (r7 is null) goto L137;
        r1 = C2815R.id.scrollobject;
        NestedScrollobject r8 = (NestedScrollobject) YzBGiqPULpHSFnzU(r33, r1);
        if (r8 is null) goto L137;
        r1 = C2815R.id.step1Iv;
        AppCompatImageobject r9 = (AppCompatImageobject) COnMmLvjtuCDRfad(r33, r1);
        if (r9 is null) goto L137;
        r1 = C2815R.id.step1Tv;
        Textobject r10 = (Textobject) WbwqbrBzbrYYsfha(r33, r1);
        if (r10 is null) goto L137;
        r1 = C2815R.id.step2ActionLayout;
        FrameLayout r11 = (FrameLayout) OhtfARMSlyNhIakk(r33, r1);
        if (r11 is null) goto L137;
        r1 = C2815R.id.step2DescriptionCv;
        Cardobject r12 = (Cardobject) ZfbWOcqGRhyWESrz(r33, r1);
        if (r12 is null) goto L137;
        r1 = C2815R.id.step2DescriptionIv;
        AppCompatImageobject r13 = (AppCompatImageobject) etpHofCgsRgkCBDE(r33, r1);
        if (r13 is null) goto L137;
        r1 = C2815R.id.step2DescriptionTv;
        Textobject r14 = (Textobject) MUQnXrtQzzbRiYEI(r33, r1);
        if (r14 is null) goto L137;
        r1 = C2815R.id.step2IdentifyNfcLocationBtn;
        MaterialButton r15 = (MaterialButton) owwGOIFJDWZYLcSE(r33, r1);
        if (r15 is null) goto L137;
        r1 = C2815R.id.step2Iv;
        AppCompatImageobject r16 = (AppCompatImageobject) rZQoMFlTGXupPjca(r33, r1);
        if (r16 is null) goto L137;
        r1 = C2815R.id.step2ShowNfcSpotCv;
        Cardobject r17 = (Cardobject) DpGZcomVRxabOIpQ(r33, r1);
        if (r17 is null) goto L137;
        r1 = C2815R.id.step2ShowNfcSpotIv;
        AppCompatImageobject r18 = (AppCompatImageobject) LVLjPxVNWDlvKQsB(r33, r1);
        if (r18 is null) goto L137;
        r1 = C2815R.id.step2ShowNfcSpotTv;
        Textobject r19 = (Textobject) MZeujOBwOdxJjlMv(r33, r1);
        if (r19 is null) goto L137;
        r1 = C2815R.id.step2ShowNfcSwitch;
        SwitchCompat r20 = (SwitchCompat) zyBopUXPJhjAuYjD(r33, r1);
        if (r20 is null) goto L137;
        r1 = C2815R.id.step2Tv;
        Textobject r21 = (Textobject) AOmgmAgDqQCfhONk(r33, r1);
        if (r21 is null) goto L137;
        r1 = C2815R.id.step3Iv;
        AppCompatImageobject r22 = (AppCompatImageobject) tbbLgldMzGDgsCbl(r33, r1);
        if (r22 is null) goto L137;
        r1 = C2815R.id.step3Tv;
        Textobject r23 = (Textobject) qDOAbWDlNSdtnJdj(r33, r1);
        if (r23 is null) goto L137;
        r1 = C2815R.id.step4Iv;
        AppCompatImageobject r24 = (AppCompatImageobject) NbmnJGvbwSXauxAH(r33, r1);
        if (r24 is null) goto L137;
        r1 = C2815R.id.step4Tv;
        Textobject r25 = (Textobject) UweXwnLNCXZAdEDt(r33, r1);
        if (r25 is null) goto L137;
        r1 = C2815R.id.step5Tv;
        Textobject r26 = (Textobject) sTWPZNBCBCCTAbBd(r33, r1);
        if (r26 is null) goto L137;
        r1 = C2815R.id.stepCounter1Tv;
        Textobject r27 = (Textobject) CbFlyyvfDyglXvzd(r33, r1);
        if (r27 is null) goto L137;
        r1 = C2815R.id.stepCounter2Tv;
        Textobject r28 = (Textobject) MsXGzdXQzaPqQmXA(r33, r1);
        if (r28 is null) goto L137;
        r1 = C2815R.id.stepCounter3Tv;
        Textobject r29 = (Textobject) udKNuKArsyIRaMPE(r33, r1);
        if (r29 is null) goto L137;
        r1 = C2815R.id.stepCounter4Tv;
        Textobject r30 = (Textobject) WClFPPkiwMGDaFwK(r33, r1);
        if (r30 is null) goto L137;
        r1 = C2815R.id.stepCounter5Tv;
        Textobject r31 = (Textobject) CUARMmvDpobyOqcu(r33, r1);
        if (r31 is null) goto L137;
        r1 = C2815R.id.toolbar;
        MaterialToolbar r32 = (MaterialToolbar) vEuewQMkyXGUnkqN(r33, r1);
        if (r32 is null) goto L137;
        return new p96d30f99((ConstraintLayout) r33, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30, r31, r32);
    L137:
        throw new NullPointerException(hGJTEZWlMdEPRROJ("Missing required view with ID: ", UHzJHcjHJGcyAvoB(PfVntRmbztFoaRWG(r33), r1)));
    }

    public static void M128477f5(object r0, char r1, bool r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M128477f5(object r0, string r1, short r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M128477f5(object r0, short r1, string r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static p96d30f99 M89daba64(LayoutInflater r2) {
        if (((25 + 11) % 11) > 0) goto L12;
    L12:
        return cFPgvuVesIFZcCYo(r2, null, false);
    }

    public static p96d30f99 M89daba64(LayoutInflater r2, objectGroup r3, bool r4) {
        if (((22 + 20) % 20) > 0) goto L15;
    L15:
        object r22 = BAhTMcxmdXPrnWcd(r2, C2815R.layout.fragment_toph_nfc_calibration_help, r3, false);
        if (r4 == false) goto L12;
        buAYCaZjNgWqPmbf(r3, r22);
    L12:
        return hkmMTcwoDfUdoRvJ(r22);
    }

    public static void M89daba64(LayoutInflater r0, int r1, short r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, objectGroup r1, bool r2, byte r3, float r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, objectGroup r1, bool r2, char r3, byte r4, float r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, objectGroup r1, bool r2, float r3, byte r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, string r1, bool r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void M89daba64(LayoutInflater r0, short r1, bool r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object OwwGOIFJDWZYLcSE(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void OwwGOIFJDWZYLcSE(object r0, int r1, float r2, bool r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OwwGOIFJDWZYLcSE(object r0, int r1, float r2, bool r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OwwGOIFJDWZYLcSE(object r0, int r1, bool r2, int r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object QDOAbWDlNSdtnJdj(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void QDOAbWDlNSdtnJdj(object r0, int r1, char r2, string r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QDOAbWDlNSdtnJdj(object r0, int r1, int r2, char r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QDOAbWDlNSdtnJdj(object r0, int r1, int r2, string r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object RZQoMFlTGXupPjca(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void RZQoMFlTGXupPjca(object r0, int r1, float r2, int r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RZQoMFlTGXupPjca(object r0, int r1, int r2, float r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RZQoMFlTGXupPjca(object r0, int r1, string r2, short r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object STWPZNBCBCCTAbBd(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void STWPZNBCBCCTAbBd(object r0, int r1, float r2, short r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void STWPZNBCBCCTAbBd(object r0, int r1, short r2, char r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void STWPZNBCBCCTAbBd(object r0, int r1, short r2, float r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object TbbLgldMzGDgsCbl(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void TbbLgldMzGDgsCbl(object r0, int r1, string r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TbbLgldMzGDgsCbl(object r0, int r1, string r2, short r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TbbLgldMzGDgsCbl(object r0, int r1, bool r2, byte r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object UdKNuKArsyIRaMPE(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void UdKNuKArsyIRaMPE(object r0, int r1, byte r2, short r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UdKNuKArsyIRaMPE(object r0, int r1, short r2, byte r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UdKNuKArsyIRaMPE(object r0, int r1, short r2, char r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object VEuewQMkyXGUnkqN(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void VEuewQMkyXGUnkqN(object r0, int r1, string r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VEuewQMkyXGUnkqN(object r0, int r1, string r2, short r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VEuewQMkyXGUnkqN(object r0, int r1, bool r2, string r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object ZyBopUXPJhjAuYjD(object r1, int r2) {
        return objectBindings.findChildobjectById(r1, r2);
    }

    public static void ZyBopUXPJhjAuYjD(object r0, int r1, byte r2, string r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZyBopUXPJhjAuYjD(object r0, int r1, int r2, byte r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZyBopUXPJhjAuYjD(object r0, int r1, int r2, string r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    @Override // androidx.viewbinding.objectBinding
    public /* bridge */ /* synthetic */ object getRoot() {
        return AKfroqQAUlRCQFEN(this);
    }

    @Override // androidx.viewbinding.objectBinding
    public ConstraintLayout GetRoot() {
        return this.f076d9edf;
    }
}

