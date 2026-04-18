namespace WillowMaze.Wasm.Decompiled;

public class P6d310f89 : Pc3755e61
{
    private p992374d8 F000a96cb;
    private bool F06de4d74;
    private p992374d8 F0959d6e5;
    private readonly p4f9a1811 F09d7ec30;
    private readonly p4f9a1811 F0bfbfe82;
    private readonly bool F0d86ea45;
    private readonly bool F15e28b5a;
    private readonly p4f9a1811 F201bbc40;
    private readonly bool F26ad4fa8;
    private bool F37396dc9;
    private bool F3bcfd1d4;
    private readonly p15c2d85f F45c838ea;
    private object F46a451a9;
    private pc2c7dd60 F4717d53e;
    private bool F4cb1b79d;
    private bool F535e3ac0;
    private readonly p15c2d85f F539f42cd;
    private object F53dcd216;
    private bool F55594c2d;
    private readonly bool F578c56f2;
    private bool F583c6ea3;
    private readonly p4f9a1811 F598df8b9;
    private p992374d8 F5b9f3274;
    private p992374d8 F5c731c8c;
    private bool F618f9dec;
    private readonly p1cda7fcc F62608e08;
    private bool F6642a9bc;
    private p24a07cca F6c1f63b3;
    private p992374d8 F6ea20e55;
    private pc2c7dd60 F71de8f5d;
    private bool F73459ede;
    private readonly p15c2d85f F734f9b22;
    private readonly p1cda7fcc F754fe0f1;
    private p24a07cca F783b7af6;
    private readonly p4f9a1811 F809cd717;
    private pc2c7dd60 F87252cc6;
    private readonly p6d310f89$p90272dda$1 F8ac5e7ac;
    private pc2c7dd60 F8d83a265;
    private readonly p6d310f89$p90272dda$1 F90272dda;
    private readonly pe5e1ca24 F99874bde;
    private readonly bool Fa6a909b5;
    private readonly p15c2d85f Fafb5e836;
    private pc2c7dd60 Fb56f430d;
    private pc2c7dd60 Fb636bf70;
    private bool Fb8081c4a;
    private bool Fba04e445;
    private readonly p6d310f89$p90272dda$1 Fbd2507e9;
    private bool Fc2ac29ae;
    private bool Fc85c8666;
    private pc2c7dd60 Fccb101d1;
    private pc2c7dd60 Fd180dc8c;
    private bool Fd5c39a1d;
    private readonly p15c2d85f Fda380e71;
    private bool Fdbe7fbf5;
    private readonly p6d310f89$p90272dda$1 Fe7ea9b9a;
    private readonly pe5e1ca24 Ff1e0f49a;
    private bool Ffe69ee57;

    public static p6d310f89$p90272dda$1 Access$getTimeout$p(p6d310f89 P0)
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f90272dda
        return default!;
    }

    public static string Access$toLoggableString(p6d310f89 P0)
    {
        // call: p6d310f89.toLoggableString
        return string.Empty;
    }

    private IOException CallDone(IOException P0)
    {
        // str: "Thread "
        // str: " MUST NOT hold lock on "
        // str: "Check failed."
        // call: p23e8a4b4.closeQuietly
        // call: p6d310f89.releaseConnectionNoEvents$okhttp
        // call: Thread.holdsLock
        // call: p6d310f89.timeoutExit
        // call: Intrinsics.checkNotNull
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: p4f9a1811.connectionReleased
        // call: p4f9a1811.callFailed
        // call: Thread.getName
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: Thread.currentThread
        // call: AssertionError.<init>
        // call: p4f9a1811.callEnd
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f4717d53e
        // type: StringBuilder
        // type: AssertionError
        // type: IllegalStateException
        return default!;
    }

    private void CallStart()
    {
        // str: "response.body().close()"
        // call: p4f9a1811.callStart
        // call: p419f3742$p910eef8c.get
        // call: p419f3742.getStackTraceForCloseable
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f09d7ec30
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f53dcd216
    }

    private pdd7bf230 CreateAddress(pdfadebdd P0)
    {
        // call: p1cda7fcc.dns
        // call: p1cda7fcc.proxySelector
        // call: p1cda7fcc.proxyAuthenticator
        // call: pdd7bf230.<init>
        // call: p1cda7fcc.proxy
        // call: p1cda7fcc.connectionSpecs
        // call: p1cda7fcc.socketFactory
        // call: pdfadebdd.isHttps
        // call: p1cda7fcc.protocols
        // call: p1cda7fcc.sslSocketFactory
        // call: pdfadebdd.port
        // call: p1cda7fcc.certificatePinner
        // call: p1cda7fcc.hostnameVerifier
        // call: pdfadebdd.host
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f62608e08
        // type: pdd7bf230
        return default!;
    }

    private IOException TimeoutExit(IOException P0)
    {
        // str: "timeout"
        // call: p6d310f89$p90272dda$1.exit
        // call: InterruptedIOException.initCause
        // call: InterruptedIOException.<init>
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f618f9dec
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f90272dda
        // type: InterruptedIOException
        return default!;
    }

    private string ToLoggableString()
    {
        // str: "call"
        // str: "canceled "
        // str: " to "
        // str: "web socket"
        // str: ""
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: p6d310f89.redactedUrl$okhttp
        // call: StringBuilder.toString
        // call: p6d310f89.isCanceled
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f578c56f2
        // type: StringBuilder
        return string.Empty;
    }

    public void AcquireConnectionNoEvents(pc2c7dd60 P0)
    {
        // str: " MUST hold lock on "
        // str: "Check failed."
        // str: "connection"
        // str: "Thread "
        // call: Intrinsics.checkNotNullParameter
        // call: Thread.getName
        // call: IllegalStateException.<init>
        // call: pc2c7dd60.getCalls
        // call: StringBuilder.toString
        // call: AssertionError.<init>
        // call: StringBuilder.append
        // call: p6d310f89$p73392f00.<init>
        // call: StringBuilder.<init>
        // call: List<object>.add
        // call: object.toString
        // call: Thread.holdsLock
        // call: Thread.currentThread
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f53dcd216
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f4717d53e
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: IllegalStateException
        // type: StringBuilder
        // type: p6d310f89$p73392f00
        // type: AssertionError
    }

    public void Cancel()
    {
        // call: pc2c7dd60.cancel
        // call: p4f9a1811.canceled
        // call: p992374d8.cancel
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.fd5c39a1d
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.fccb101d1
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f5c731c8c
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f09d7ec30
    }

    public object Clone()
    {
        // call: p6d310f89.clone
        return default!;
    }

    public pc3755e61 Clone()
    {
        // call: p6d310f89.clone
        return default!;
    }

    public p6d310f89 Clone()
    {
        // call: p6d310f89.<init>
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f539f42cd
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f62608e08
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f578c56f2
        // type: p6d310f89
        return default!;
    }

    public void Enqueue(p406c70d6 P0)
    {
        // str: "responseCallback"
        // str: "Already Executed"
        // call: p6d310f89.callStart
        // call: object.toString
        // call: bool.compareAndSet
        // call: IllegalStateException.<init>
        // call: pdbfcc2e9.enqueue$okhttp
        // call: Intrinsics.checkNotNullParameter
        // call: p6d310f89$p9319e475.<init>
        // call: p1cda7fcc.dispatcher
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.fa6a909b5
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f62608e08
        // type: IllegalStateException
        // type: p6d310f89$p9319e475
    }

    public void EnterNetworkInterceptorExchange(p15c2d85f P0, bool P1)
    {
        // str: "request"
        // str: "Check failed."
        // str: "cannot make a new request because the previous response is still open: please call response.close()"
        // call: p24a07cca.<init>
        // call: p15c2d85f.url
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: p6d310f89.createAddress
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.ffe69ee57
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f73459ede
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f000a96cb
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f99874bde
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f783b7af6
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f09d7ec30
        // type: p24a07cca
        // type: IllegalStateException
    }

    public pd64ed3e9 Execute()
    {
        // str: "Already Executed"
        // call: p1cda7fcc.dispatcher
        // call: pdbfcc2e9.finished$okhttp
        // call: object.toString
        // call: bool.compareAndSet
        // call: IllegalStateException.<init>
        // call: p6d310f89.callStart
        // call: pdbfcc2e9.executed$okhttp
        // call: p6d310f89.getResponseWithInterceptorChain$okhttp
        // call: p6d310f89$p90272dda$1.enter
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f62608e08
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f90272dda
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.fa6a909b5
        // type: IllegalStateException
        return default!;
    }

    public void ExitNetworkInterceptorExchange$okhttp(bool P0)
    {
        // str: "released"
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: p992374d8.detachWithViolence
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f000a96cb
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f55594c2d
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f5c731c8c
        // type: IllegalStateException
    }

    public p1cda7fcc GetClient()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f62608e08
        return default!;
    }

    public pc2c7dd60 GetConnection()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f4717d53e
        return default!;
    }

    public pc2c7dd60 GetConnectionToCancel()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.fccb101d1
        return default!;
    }

    public p4f9a1811 GetEventListener$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f09d7ec30
        return default!;
    }

    public bool GetForWebSocket()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f578c56f2
        return false;
    }

    public p992374d8 GetInterceptorScopedExchange$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f000a96cb
        return default!;
    }

    public p15c2d85f GetOriginalRequest()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f539f42cd
        return default!;
    }

    public pd64ed3e9 GetResponseWithInterceptorChain$okhttp()
    {
        // str: "Canceled"
        // str: "null cannot be cast to non-null type kotlin.Throwable"
        // call: CollectionsKt.addAll
        // call: ICollection<object>.add
        // call: p1cda7fcc.cache
        // call: pf1d5187f.proceed
        // call: p6d310f89.isCanceled
        // call: p23e8a4b4.closeQuietly
        // call: IOException.<init>
        // call: pa757ef60.<init>
        // call: p6d310f89.noMoreExchanges$okhttp
        // call: p7cbe1951.<init>
        // call: p1cda7fcc.interceptors
        // call: p1cda7fcc.networkInterceptors
        // call: NullPointerException.<init>
        // call: p1cda7fcc.connectTimeoutMillis
        // call: p1cda7fcc.readTimeoutMillis
        // call: p1cda7fcc.cookieJar
        // call: p09a340b9.<init>
        // call: pf80857dd.<init>
        // call: p1cda7fcc.writeTimeoutMillis
        // call: List<object>.<init>
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f578c56f2
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f62608e08
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f539f42cd
        // field: p7ddcfee1.pd1efad72.p4717d53e.p1336f499.f76425f17
        // type: List<object>
        // type: IOException
        // type: p09a340b9
        // type: pa757ef60
        // type: NullPointerException
        // type: p7cbe1951
        // type: pf80857dd
        // type: pf1d5187f
        return default!;
    }

    public p992374d8 InitExchange$okhttp(pf1d5187f P0)
    {
        // str: "Canceled"
        // str: "chain"
        // str: "Check failed."
        // str: "released"
        // call: IOException.<init>
        // call: p24a07cca.find
        // call: p992374d8.<init>
        // call: object.toString
        // call: IllegalStateException.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.fd5c39a1d
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f55594c2d
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.ffe69ee57
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f73459ede
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f62608e08
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f000a96cb
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f5c731c8c
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f783b7af6
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f09d7ec30
        // type: p992374d8
        // type: IllegalStateException
        // type: IOException
        return default!;
    }

    public bool IsCanceled()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.fd5c39a1d
        return false;
    }

    public bool IsExecuted()
    {
        // call: bool.get
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.fa6a909b5
        return false;
    }

    public IOException MessageDone$okhttp(p992374d8 P0, bool P1, bool P2, IOException P3)
    {
        // str: "exchange"
        // call: Intrinsics.areEqual
        // call: Intrinsics.checkNotNullParameter
        // call: p6d310f89.callDone
        // call: pc2c7dd60.incrementSuccessCount$okhttp
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f5c731c8c
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f4717d53e
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f73459ede
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.ffe69ee57
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f55594c2d
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public IOException NoMoreExchanges$okhttp(IOException P0)
    {
        // call: p6d310f89.callDone
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f55594c2d
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f73459ede
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.ffe69ee57
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public string RedactedUrl$okhttp()
    {
        // call: pdfadebdd.redact
        // call: p15c2d85f.url
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f539f42cd
        return string.Empty;
    }

    public Socket ReleaseConnectionNoEvents$okhttp()
    {
        // str: "Check failed."
        // str: " MUST hold lock on "
        // str: "Thread "
        // call: StringBuilder.append
        // call: pc2c7dd60.socket
        // call: StringBuilder.toString
        // call: Intrinsics.areEqual
        // call: Thread.holdsLock
        // call: IllegalStateException.<init>
        // call: Reference.get
        // call: List<object>.iterator
        // call: Thread.currentThread
        // call: IEnumerator<object>.next
        // call: pc2c7dd60.setIdleAtNs$okhttp
        // call: AssertionError.<init>
        // call: object.toString
        // call: IEnumerator<object>.hasNext
        // call: System.nanoTime
        // call: List<object>.isEmpty
        // call: StringBuilder.<init>
        // call: pc2c7dd60.getCalls
        // call: Intrinsics.checkNotNull
        // call: Thread.getName
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f99874bde
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f4717d53e
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: AssertionError
        // type: IllegalStateException
        // type: StringBuilder
        return default!;
    }

    public p15c2d85f Request()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f539f42cd
        return default!;
    }

    public bool RetryAfterFailure()
    {
        // call: p24a07cca.retryAfterFailure
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f783b7af6
        return false;
    }

    public void SetConnectionToCancel(pc2c7dd60 P0)
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.fccb101d1
    }

    public p65e25ac1 Timeout()
    {
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f90272dda
        return default!;
    }

    public pc85a251c Timeout()
    {
        // call: p6d310f89.timeout
        return default!;
    }

    public void TimeoutEarlyExit()
    {
        // str: "Check failed."
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: p6d310f89$p90272dda$1.exit
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f90272dda
        // field: p7ddcfee1.pd1efad72.p4717d53e.p6d310f89.f618f9dec
        // type: IllegalStateException
    }

}
