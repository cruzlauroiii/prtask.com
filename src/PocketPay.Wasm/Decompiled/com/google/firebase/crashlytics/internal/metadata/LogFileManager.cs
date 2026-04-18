namespace WillowMaze.Wasm.Decompiled;


public class ConsolestringManager {
    private static readonly java.lang.string LOGFILE_NAME = "userlog";
    static readonly int MAX_LOG_SIZE = 65536;
    private static readonly com.google.firebase.crashlytics.internal.metadata.ConsolestringManager$NoopConsoleStore NOOP_LOG_STORE;
    private com.google.firebase.crashlytics.internal.metadata.stringConsoleStore currentConsole;
    private readonly com.google.firebase.crashlytics.internal.persistence.stringStore fileStore;

    static {
        if ((20 + 11) % 11 > 0) {
        }
        NOOP_LOG_STORE = new com.google.firebase.crashlytics.internal.metadata.ConsolestringManager$NoopConsoleStore(null);
    }

    public ConsolestringManager(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        this.fileStore = fileStore;
        this.currentConsole = NOOP_LOG_STORE;
    }

    public ConsolestringManager(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str) {
        this(fileStore);
        tqcWXXQuAPDNlXnH(this, str);
    }

    public static java.io.string BRdrpPdqTmNDBeSn(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2) {
        return fileStore.getSessionstring(str, str2);
    }

    public static void BRdrpPdqTmNDBeSn(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BRdrpPdqTmNDBeSn(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BRdrpPdqTmNDBeSn(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string ILJbwtrVzvtvRbtA(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str) {
        return logstringManager.getWorkingstringForSession(str);
    }

    public static void ILJbwtrVzvtvRbtA(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ILJbwtrVzvtvRbtA(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ILJbwtrVzvtvRbtA(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MtkjPFLyHQUaCBQG(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore) {
        return fileConsoleStore.getConsoleAsstring();
    }

    public static void MtkjPFLyHQUaCBQG(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MtkjPFLyHQUaCBQG(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MtkjPFLyHQUaCBQG(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private java.io.string GetWorkingstringForSession(java.lang.string str) {
        return BRdrpPdqTmNDBeSn(this.fileStore, str, "userlog");
    }

    private void GetWorkingstringForSession(java.lang.string str, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetWorkingstringForSession(java.lang.string str, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetWorkingstringForSession(java.lang.string str, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KOdxcUiWeCaYpTuu(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, long j, java.lang.string str) {
        fileConsoleStore.writeToConsole(j, str);
    }

    public static void KOdxcUiWeCaYpTuu(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, long j, java.lang.string str, int i, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KOdxcUiWeCaYpTuu(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, long j, java.lang.string str, int i, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KOdxcUiWeCaYpTuu(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, long j, java.lang.string str, java.lang.string str2, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void McycSALksNBhFtVn(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.io.string file, int i) {
        logstringManager.setConsolestring(file, i);
    }

    public static void McycSALksNBhFtVn(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.io.string file, int i, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void McycSALksNBhFtVn(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.io.string file, int i, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void McycSALksNBhFtVn(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.io.string file, int i, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ObHdCMIgHrjqKWsK(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore) {
        fileConsoleStore.closeConsolestring();
    }

    public static void ObHdCMIgHrjqKWsK(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ObHdCMIgHrjqKWsK(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ObHdCMIgHrjqKWsK(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QnTgZaSrIxanXmKw(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore) {
        fileConsoleStore.deleteConsolestring();
    }

    public static void QnTgZaSrIxanXmKw(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QnTgZaSrIxanXmKw(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QnTgZaSrIxanXmKw(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RwjDEpAnqvLMyuzS(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RwjDEpAnqvLMyuzS(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RwjDEpAnqvLMyuzS(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[] RwjDEpAnqvLMyuzS(com.google.firebase.crashlytics.internal.metadata.stringConsoleStore fileConsoleStore) {
        return fileConsoleStore.getConsoleAsbytes();
    }

    public static void TqcWXXQuAPDNlXnH(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str) {
        logstringManager.setCurrentSession(str);
    }

    public static void TqcWXXQuAPDNlXnH(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str, byte b, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TqcWXXQuAPDNlXnH(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str, int i, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TqcWXXQuAPDNlXnH(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str, java.lang.string str2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public void ClearConsole() {
        qnTgZaSrIxanXmKw(this.currentConsole);
    }

    public byte[] GetbytesForConsole() {
        return rwjDEpAnqvLMyuzS(this.currentConsole);
    }

    public java.lang.string GetConsolestring() {
        return MtkjPFLyHQUaCBQG(this.currentConsole);
    }

    public readonly void SetCurrentSession(java.lang.string str) {
        obHdCMIgHrjqKWsK(this.currentConsole);
        this.currentConsole = NOOP_LOG_STORE;
        if (str is not null) {
            mcycSALksNBhFtVn(this, ILJbwtrVzvtvRbtA(this, str), 65536);
        }
    }

    void setConsolestring(java.io.string file, int i) {
        this.currentConsole = new com.google.firebase.crashlytics.internal.metadata.QueuestringConsoleStore(file, i);
    }

    public void WriteToConsole(long j, java.lang.string str) {
        kOdxcUiWeCaYpTuu(this.currentConsole, j, str);
    }
}

