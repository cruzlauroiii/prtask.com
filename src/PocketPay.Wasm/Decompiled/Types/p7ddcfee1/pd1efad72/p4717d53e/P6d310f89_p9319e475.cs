namespace WillowMaze.Wasm.Decompiled;

public class P6d310f89_p9319e475 : Action
{
    private int F145820c5;
    private readonly p406c70d6 F22069ea2;
    private int F25baa91d;
    private readonly p406c70d6 F3b0b6b0e;
    private int F4a4972b8;
    private int F6f911dd4;
    private int Fa3dbd60c;
    private readonly p6d310f89 This$0;

    public void ExecuteOn(TaskScheduler P0)
    {
        // str: " MUST NOT hold lock on "
        // str: "executor rejected"
        // str: "executorService"
        // str: "Thread "
        // call: p1cda7fcc.dispatcher
        // call: InterruptedIOException.<init>
        // call: InterruptedIOException.initCause
        // call: p6d310f89.noMoreExchanges$okhttp
        // call: p406c70d6.onFailure
        // call: p6d310f89.getClient
        // call: pdbfcc2e9.finished$okhttp
        // call: StringBuilder.append
        // call: Thread.currentThread
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: TaskScheduler.execute
        // call: AssertionError.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: Thread.holdsLock
        // call: Thread.getName
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89$p9319e475.this$0
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89$p9319e475.f22069ea2
        // type: InterruptedIOException
        // type: StringBuilder
        // type: AssertionError
    }

    public p6d310f89 GetCall()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89$p9319e475.this$0
        return default!;
    }

    public int GetCallsPerHost()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89$p9319e475.f4a4972b8
        return 0;
    }

    public string GetHost()
    {
        // call: pdfadebdd.host
        // call: p15c2d85f.url
        // call: p6d310f89.getOriginalRequest
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89$p9319e475.this$0
        return string.Empty;
    }

    public p15c2d85f GetRequest()
    {
        // call: p6d310f89.getOriginalRequest
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89$p9319e475.this$0
        return default!;
    }

    public void ReuseCallsPerHostFrom(p6d310f89$p9319e475 P0)
    {
        // str: "other"
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89$p9319e475.f4a4972b8
    }

    public void Run()
    {
        // str: "OkHttp "
        // str: "canceled due to "
        // str: "Callback failure for "
        // call: Thread.setName
        // call: p6d310f89.redactedUrl$okhttp
        // call: p6d310f89.access$getTimeout$p
        // call: p6d310f89$p90272dda$1.enter
        // call: p6d310f89.getResponseWithInterceptorChain$okhttp
        // call: Thread.currentThread
        // call: p6d310f89.getClient
        // call: p1cda7fcc.dispatcher
        // call: pdbfcc2e9.finished$okhttp
        // call: Intrinsics.stringPlus
        // call: p406c70d6.onResponse
        // call: Thread.getName
        // call: p6d310f89.cancel
        // call: IOException.<init>
        // call: ExceptionsKt.addSuppressed
        // call: p406c70d6.onFailure
        // call: p419f3742$p910eef8c.get
        // call: p6d310f89.access$toLoggableString
        // call: p419f3742.log
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89$p9319e475.this$0
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89$p9319e475.f22069ea2
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // type: IOException
    }

}
