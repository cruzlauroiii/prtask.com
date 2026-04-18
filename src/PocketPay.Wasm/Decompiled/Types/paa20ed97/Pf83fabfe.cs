namespace WillowMaze.Wasm.Decompiled;

public class Pf83fabfe : Pc3755e61
{
    private readonly pc3755e61$p1c6e980e F0bd66785;
    private readonly p60ad5b1d F0e8b170c;
    private Exception F18ac595a;
    private readonly pc7611810 F22c692d6;
    private readonly p60ad5b1d F319395c2;
    private readonly pc7611810 F3998e075;
    private Exception F4c61baa6;
    private readonly p60ad5b1d F5237a940;
    private bool F55d6b793;
    private pc3755e61 F66279646;
    private bool F6757a2cb;
    private bool F75157d05;
    private readonly p60ad5b1d F8a26362c;
    private bool F8ce7926b;
    private readonly object[] F92e5f554;
    private bool Fa6a909b5;
    private readonly object[] Fa956af09;
    private pc3755e61 Fb675a7a4;
    private readonly pc3755e61$p1c6e980e Fc9e298d7;
    private pc3755e61 Fd0b7e09e;
    private bool Fd5c39a1d;
    private readonly pc7611810 Fd75e7dc3;
    private readonly pc3755e61$p1c6e980e Fe625afb0;
    private readonly p60ad5b1d Fe7a96269;

    private pc3755e61 CreateRawCall()
    {
        // str: "Call.Factory returned null."
        // call: pc3755e61$p1c6e980e.newCall
        // call: NullPointerException.<init>
        // call: pc7611810.create
        // field: paa20ed97.pf83fabfe.f22c692d6
        // field: paa20ed97.pf83fabfe.fc9e298d7
        // field: paa20ed97.pf83fabfe.fa956af09
        // type: NullPointerException
        return default!;
    }

    private pc3755e61 GetRawCall()
    {
        // call: pf83fabfe.createRawCall
        // call: pa470a233.throwIfFatal
        // field: paa20ed97.pf83fabfe.f66279646
        // field: paa20ed97.pf83fabfe.f4c61baa6
        return default!;
    }

    public void Cancel()
    {
        // call: pc3755e61.cancel
        // field: paa20ed97.pf83fabfe.f66279646
        // field: paa20ed97.pf83fabfe.fd5c39a1d
    }

    public object Clone()
    {
        // call: pf83fabfe.clone
        return default!;
    }

    public pc3755e61 Clone()
    {
        // call: pf83fabfe.clone
        return default!;
    }

    public pf83fabfe Clone()
    {
        // call: pf83fabfe.<init>
        // field: paa20ed97.pf83fabfe.fa956af09
        // field: paa20ed97.pf83fabfe.f5237a940
        // field: paa20ed97.pf83fabfe.fc9e298d7
        // field: paa20ed97.pf83fabfe.f22c692d6
        // type: pf83fabfe
        return default!;
    }

    public void Enqueue(p406c70d6 P0)
    {
        // str: "Already executed."
        // str: "callback == null"
        // call: pc3755e61.cancel
        // call: pc3755e61.enqueue
        // call: IllegalStateException.<init>
        // call: Objects.requireNonNull
        // call: pf83fabfe.createRawCall
        // call: pf83fabfe$1.<init>
        // call: pa470a233.throwIfFatal
        // call: p406c70d6.onFailure
        // field: paa20ed97.pf83fabfe.fd5c39a1d
        // field: paa20ed97.pf83fabfe.fa6a909b5
        // field: paa20ed97.pf83fabfe.f66279646
        // field: paa20ed97.pf83fabfe.f4c61baa6
        // type: pf83fabfe$1
        // type: IllegalStateException
    }

    public Response Execute()
    {
        // str: "Already executed."
        // call: pc3755e61.cancel
        // call: IllegalStateException.<init>
        // call: pf83fabfe.parseResponse
        // call: pc3755e61.execute
        // call: pf83fabfe.getRawCall
        // field: paa20ed97.pf83fabfe.fd5c39a1d
        // field: paa20ed97.pf83fabfe.fa6a909b5
        // type: IllegalStateException
        return default!;
    }

    public bool IsCanceled()
    {
        // call: pc3755e61.isCanceled
        // field: paa20ed97.pf83fabfe.fd5c39a1d
        // field: paa20ed97.pf83fabfe.f66279646
        return false;
    }

    public bool IsExecuted()
    {
        // field: paa20ed97.pf83fabfe.fa6a909b5
        return false;
    }

    private Response ParseResponse(pd64ed3e9 P0)
    {
        // call: pd64ed3e9$p2bd4a59b.build
        // call: p42c567ea.close
        // call: pd64ed3e9.newBuilder
        // call: pf83fabfe$p16890fbe.<init>
        // call: pa470a233.buffer
        // call: Response.error
        // call: p42c567ea.contentType
        // call: p42c567ea.contentLength
        // call: Response.success
        // call: pf83fabfe$p45cf3335.throwIfCaught
        // call: pd64ed3e9$p2bd4a59b.body
        // call: pf83fabfe$p45cf3335.<init>
        // call: p60ad5b1d.convert
        // call: pd64ed3e9.body
        // call: pd64ed3e9.code
        // field: paa20ed97.pf83fabfe.f5237a940
        // type: pf83fabfe$p45cf3335
        // type: pf83fabfe$p16890fbe
        return default!;
    }

    public p15c2d85f Request()
    {
        // str: "Unable to create request."
        // call: pf83fabfe.getRawCall
        // call: pc3755e61.request
        // call: Exception.<init>
        // type: Exception
        return default!;
    }

    public pc85a251c Timeout()
    {
        // str: "Unable to create call."
        // call: pf83fabfe.getRawCall
        // call: pc3755e61.timeout
        // call: Exception.<init>
        // type: Exception
        return default!;
    }

}
