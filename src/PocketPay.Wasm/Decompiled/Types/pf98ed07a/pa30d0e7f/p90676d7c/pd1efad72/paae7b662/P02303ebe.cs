namespace WillowMaze.Wasm.Decompiled;

public abstract class P02303ebe : FlowableSubscriber, P5d5a5670
{
    private bool F2aa0d275;
    private p5d5a5670 F304854e2;
    private p787ad0b7 F33df54c5;
    private readonly p992c4a5b F3f461ad2;
    private p5d5a5670 F4120ea54;
    private bool F6b2ded51;
    private p787ad0b7 F710e6722;
    private p787ad0b7 F8e9d216c;
    private p787ad0b7 Fb8410313;
    private p787ad0b7 Fbc3b0556;
    private bool Fc3de74b8;
    private int Fcaab7643;
    private readonly p992c4a5b Fd22a0a80;
    private bool Fde69c67f;
    private readonly p992c4a5b Fe1025fee;
    private int Fe910ccee;
    private bool Feed367bb;

    public static void APNFkpctfBJNWLcH(p787ad0b7 P0, long P1)
    {
        // call: p787ad0b7.request
    }

    public static int FZPfHAwzADUTorVM(p5d5a5670 P0, int P1)
    {
        // call: p5d5a5670.requestFusion
        return 0;
    }

    public static void PsLfsomqURiEqFUI(p02303ebe P0, Exception P1)
    {
        // call: p02303ebe.onError
    }

    public static void TVpsHYdAcFOQEjFc(p5d5a5670 P0)
    {
        // call: p5d5a5670.clear
    }

    public static bool WlGQOsjcIjvTrnDw(p5d5a5670 P0)
    {
        // call: p5d5a5670.isEmpty
        return false;
    }

    public static bool XKAkjZnlcjZTGiEp(p02303ebe P0)
    {
        // call: p02303ebe.beforeDownstream
        return false;
    }

    public static void CooWFukZrDoxuMrD(p787ad0b7 P0)
    {
        // call: p787ad0b7.cancel
    }

    public static bool HGbmHtNskhfNQHYS(p787ad0b7 P0, p787ad0b7 P1)
    {
        // call: p449cd152.validate
        return false;
    }

    public static void HWUYvZKvHHNkYHQh(p02303ebe P0)
    {
        // call: p02303ebe.afterDownstream
    }

    public static void ICrbyUROukkmweII(p992c4a5b P0)
    {
        // call: p992c4a5b.onComplete
    }

    public static void IgRUGBvEuMopPbfF(p787ad0b7 P0)
    {
        // call: p787ad0b7.cancel
    }

    public static void ItYCaxBlUUUbeUcp(Exception P0)
    {
        // call: pd5f1381c.m9f2b335f
    }

    public static void JEGXqTulmJpHsbvk(Exception P0)
    {
        // call: pd36704fd.mdcce2ff2
    }

    public static void LIZsAETQTXlfXPsc(p992c4a5b P0, p787ad0b7 P1)
    {
        // call: p992c4a5b.onSubscribe
    }

    public static void WQtotahnmZtlihjn(p992c4a5b P0, Exception P1)
    {
        // call: p992c4a5b.onError
    }

    private void AfterDownstream()
    {
    }

    private bool BeforeDownstream()
    {
        return false;
    }

    public void Cancel()
    {
        // call: p02303ebe.cooWFukZrDoxuMrD
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.fbc3b0556
    }

    public void Clear()
    {
        // call: p02303ebe.TVpsHYdAcFOQEjFc
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.f304854e2
    }

    private void Fail(Exception P0)
    {
        // call: p02303ebe.igRUGBvEuMopPbfF
        // call: p02303ebe.PsLfsomqURiEqFUI
        // call: p02303ebe.itYCaxBlUUUbeUcp
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.fbc3b0556
    }

    public bool IsEmpty()
    {
        // call: p02303ebe.WlGQOsjcIjvTrnDw
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.f304854e2
        return false;
    }

    public bool Offer(object P0)
    {
        // str: "Should not be called!"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return false;
    }

    public bool Offer(object P0, object P1)
    {
        // str: "Should not be called!"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return false;
    }

    public void OnComplete()
    {
        // call: p02303ebe.iCrbyUROukkmweII
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.f6b2ded51
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.fd22a0a80
    }

    public void OnError(Exception P0)
    {
        // call: p02303ebe.jEGXqTulmJpHsbvk
        // call: p02303ebe.wQtotahnmZtlihjn
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.f6b2ded51
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.fd22a0a80
    }

    public void OnSubscribe(p787ad0b7 P0)
    {
        // call: p02303ebe.XKAkjZnlcjZTGiEp
        // call: p02303ebe.lIZsAETQTXlfXPsc
        // call: p02303ebe.hWUYvZKvHHNkYHQh
        // call: p02303ebe.hGbmHtNskhfNQHYS
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.fbc3b0556
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.f304854e2
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.fd22a0a80
    }

    public void Request(long P0)
    {
        // call: p02303ebe.APNFkpctfBJNWLcH
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.fbc3b0556
    }

    private int TransitiveBoundaryFusion(int P0)
    {
        // call: p02303ebe.FZPfHAwzADUTorVM
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.fe910ccee
        // field: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe.f304854e2
        return 0;
    }

}
