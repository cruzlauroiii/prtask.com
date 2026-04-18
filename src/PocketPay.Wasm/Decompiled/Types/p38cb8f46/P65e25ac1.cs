namespace WillowMaze.Wasm.Decompiled;

public class P65e25ac1 : Pc85a251c
{
    private static int F008d652c;
    private static Condition F0d8c5003;
    private static Condition F1532d9e8;
    private static p65e25ac1 F187fff55;
    private static long F1a6c61bc;
    private static int F316c0168;
    private static Condition F3f9178c2;
    private static Lock F4d651fc5;
    public static p65e25ac1$p910eef8c F6ad9523d;
    private static int F791b8a8e;
    private static Lock F8d23a564;
    public static p65e25ac1$p910eef8c F910eef8c;
    private static p65e25ac1 F96e89a29;
    public static p65e25ac1$p910eef8c Fa60b8a67;
    private static long Fb4dabec4;
    private static long Fb908321b;
    private static Lock Fdce7c417;
    private static p65e25ac1 Fde425ba0;
    private static int Fdeaa2c6a;
    private static int Fe0361c84;
    private static Condition Fed127805;
    private static long Ffad7e6ab;
    public static p65e25ac1$p910eef8c Fff4031e1;
    private bool F15b13048;
    private bool F19aac816;
    private p65e25ac1 F1b486002;
    private p65e25ac1 F29cee7c4;
    private p65e25ac1 F702aa82a;
    private long F7edaf2f7;
    private bool F82afe820;
    private long F8916414d;
    private bool Fc4c3d014;
    private bool Fcadfc746;
    private p65e25ac1 Fd0cab90d;
    private long Fe58e0cd0;

    public static long M048f335d()
    {
        // field: p38cb8f46.p65e25ac1.ffad7e6ab
        return 0;
    }

    public static void M0945c617(p65e25ac1 P0, bool P1)
    {
        // field: p38cb8f46.p65e25ac1.fc4c3d014
    }

    public static Lock M1053c222()
    {
        // field: p38cb8f46.p65e25ac1.fdce7c417
        return default!;
    }

    public static long M35edcdfa()
    {
        // field: p38cb8f46.p65e25ac1.f1a6c61bc
        return 0;
    }

    private long M3b4849e3(long P0)
    {
        // field: p38cb8f46.p65e25ac1.f8916414d
        return 0;
    }

    public static void M3ef75f6c(p65e25ac1 P0, long P1)
    {
        // field: p38cb8f46.p65e25ac1.f8916414d
    }

    public static p65e25ac1 M5118124e(p65e25ac1 P0)
    {
        // field: p38cb8f46.p65e25ac1.fd0cab90d
        return default!;
    }

    public static void M6a275a6f(p65e25ac1 P0, p65e25ac1 P1)
    {
        // field: p38cb8f46.p65e25ac1.fd0cab90d
    }

    public static bool M726c53bc(p65e25ac1 P0)
    {
        // field: p38cb8f46.p65e25ac1.fc4c3d014
        return false;
    }

    public static p65e25ac1 Mb46e0a02()
    {
        // field: p38cb8f46.p65e25ac1.f96e89a29
        return default!;
    }

    public static Condition Mbad45449()
    {
        // field: p38cb8f46.p65e25ac1.f3f9178c2
        return default!;
    }

    public static long Mcb23885c(p65e25ac1 P0, long P1)
    {
        // call: p65e25ac1.m3b4849e3
        return 0;
    }

    public static void Mdfb0d185(p65e25ac1 P0)
    {
        // field: p38cb8f46.p65e25ac1.f96e89a29
    }

    public IOException Access$newTimeoutException(IOException P0)
    {
        // call: p65e25ac1.newTimeoutException
        return default!;
    }

    public void Enter()
    {
        // call: p65e25ac1.hasDeadline
        // call: p65e25ac1.timeoutNanos
        // call: p65e25ac1$p910eef8c.m20ac200f
        // field: p38cb8f46.p65e25ac1.f910eef8c
    }

    public bool Exit()
    {
        // call: p65e25ac1$p910eef8c.m146cac6c
        // field: p38cb8f46.p65e25ac1.f910eef8c
        return false;
    }

    private IOException NewTimeoutException(IOException P0)
    {
        // str: "timeout"
        // call: InterruptedIOException.initCause
        // call: InterruptedIOException.<init>
        // type: InterruptedIOException
        return default!;
    }

    public p1eb558b5 Sink(p1eb558b5 P0)
    {
        // str: "sink"
        // call: Intrinsics.checkNotNullParameter
        // call: p65e25ac1$pf6e04117$1.<init>
        // type: p65e25ac1$pf6e04117$1
        return default!;
    }

    public pf31bbdd1 Source(pf31bbdd1 P0)
    {
        // str: "source"
        // call: Intrinsics.checkNotNullParameter
        // call: p65e25ac1$p36cd38f4$1.<init>
        // type: p65e25ac1$p36cd38f4$1
        return default!;
    }

    private void TimedOut()
    {
    }

    public object WithTimeout(Func<object> P0)
    {
        // str: "block"
        // call: p65e25ac1.exit
        // call: p65e25ac1.access$newTimeoutException
        // call: Intrinsics.checkNotNullParameter
        // call: p65e25ac1.enter
        // call: Func<object>.invoke
        return default!;
    }

}
