namespace WillowMaze.Wasm.Decompiled;


public class p5637686b : p4d236d9a.p2c8df876.pf9133214.pd1efad72.pbccaa4aa {
    private readonly java.io.PrintStream f051400c4;
    private readonly java.io.PrintStream f42aefbae;
    private readonly java.io.PrintStream f6df9a968;
    private readonly java.io.PrintStream ff14f6c95;
    private readonly java.io.PrintStream fff52b47d;

    public p5637686b() {
        this.f42aefbae = java.lang.System.out;
    }

    public p5637686b(java.io.PrintStream printStream) {
        this.f42aefbae = printStream;
    }

    public static void FaBzWNVkTDDiDjGO(java.lang.string str, float f, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FaBzWNVkTDDiDjGO(java.lang.string str, bool z, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FaBzWNVkTDDiDjGO(java.lang.string str, bool z, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static char[] FaBzWNVkTDDiDjGO(java.lang.string str) {
        return str.ToCharArray();
    }

    public static void GcTElSciqhFmytzg(java.io.PrintStream printStream, java.lang.string str) {
        printStream.print(str);
    }

    public static void GcTElSciqhFmytzg(java.io.PrintStream printStream, java.lang.string str, char c, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GcTElSciqhFmytzg(java.io.PrintStream printStream, java.lang.string str, int i, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GcTElSciqhFmytzg(java.io.PrintStream printStream, java.lang.string str, int i, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MYDdpGtxWdjPKgtn(java.io.StreamReader bufferedReader) {
        return bufferedReader.readLine();
    }

    public static void MYDdpGtxWdjPKgtn(java.io.StreamReader bufferedReader, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MYDdpGtxWdjPKgtn(java.io.StreamReader bufferedReader, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MYDdpGtxWdjPKgtn(java.io.StreamReader bufferedReader, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YcsyUMhXVGZFyhxO(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void YcsyUMhXVGZFyhxO(java.io.PrintStream printStream, java.lang.string str, int i, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YcsyUMhXVGZFyhxO(java.io.PrintStream printStream, java.lang.string str, int i, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YcsyUMhXVGZFyhxO(java.io.PrintStream printStream, java.lang.string str, java.lang.string str2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Print(java.lang.string str) {
        gcTElSciqhFmytzg(this.f42aefbae, str);
    }

    public override void Println(java.lang.string str) {
        ycsyUMhXVGZFyhxO(this.f42aefbae, str);
    }

    public override char[] ReadPassword(bool z) {
        try {
            return faBzWNVkTDDiDjGO(mYDdpGtxWdjPKgtn(new java.io.StreamReader(new java.io.StreamReader(java.lang.System.in))));
        } catch (java.io.IOException e) {
            throw new p4d236d9a.p2c8df876.pf9133214.p0c240774(e);
        }
    }
}

