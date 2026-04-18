namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010!\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0004\b\u0007\u0018\u00002\u00020\u0001B\u001f\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\b\u0010\u000b\u001a\u00020\fH\u0007J\u0010\u0010\r\u001a\u00020\u00052\u0006\u0010\u000e\u001a\u00020\u0003H\u0007J\u001c\u0010\u000f\u001a\u00020\u00052\u0012\u0010\u0010\u001a\u000e\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u00050\u0011H\u0007J9\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00072\u0006\u0010\u0015\u001a\u00020\u00032\u0010\u0010\u0016\u001a\f\u0012\b\b\u0001\u0012\u0004\u0018\u00010\u00180\u00172\b\u0010\u0019\u001a\u0004\u0018\u00010\u001aH\u0016¢\u0006\u0002\u0010\u001bJ9\u0010\u001c\u001a\u00020\u00032\u0006\u0010\u0014\u001a\u00020\u00072\u0006\u0010\u0015\u001a\u00020\u00032\u0010\u0010\u0016\u001a\f\u0012\b\b\u0001\u0012\u0004\u0018\u00010\u00180\u00172\b\u0010\u0019\u001a\u0004\u0018\u00010\u001aH\u0002¢\u0006\u0002\u0010\u001dR\u0014\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00030\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Lcom/google/firebase/logger/Consoleger$FakeConsoleger;", "Lcom/google/firebase/logger/Consoleger;", "tag", "", "enabled", "", "minLevel", "Lcom/google/firebase/logger/Consoleger$Level;", "(Ljava/lang/string;ZLcom/google/firebase/logger/Consoleger$Level;)V", "record", "", "clearConsoleMessages", "", "hasConsoleMessage", "message", "hasConsoleMessageThat", "predicate", "Lkotlin/Function1;", "log", "", "level", "format", "args", "", "", "throwable", "", "(Lcom/google/firebase/logger/Consoleger$Level;Ljava/lang/string;[Ljava/lang/object;Ljava/lang/Exception;)I", "toConsoleMessage", "(Lcom/google/firebase/logger/Consoleger$Level;Ljava/lang/string;[Ljava/lang/object;Ljava/lang/Exception;)Ljava/lang/string;", "com.google.firebase-firebase-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Consoleger$FakeConsoleger : com.google.firebase.logger.Consoleger {
    private readonly java.util.List<java.lang.string> record;

    public Consoleger$FakeConsoleger(java.lang.string str, bool z, com.google.firebase.logger.Consoleger$Level logger$Level) {
        super(str, z, logger$Level, null);
        dgXelIdHcynUjFhF(str, "tag");
        jOthCBopxfgSNoQL(logger$Level, "minLevel");
        this.record = new java.util.List();
    }

    public static void AGLedULRCMWFAGjm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object AWxdApDwhmXrqJMl(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator CheEwQaFfPlTGzOC(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.stringBuilder FhpcXMAETCYKcbua(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder GTyoYbUCHHOidQvR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool IldmsjtjaEJkhEeJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object[] LTpRPkiseCeMHOIf(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.lang.stringBuilder MsCeHHdyNRYnJllW(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void QDuMzShQdCAEakNd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int QVspRqNCelEUwZRz(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object SZMKlgFMGLxJBjur(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void SiUEhCFAaBPvEVkO(java.util.List list) {
        list.clear();
    }

    public static void TIcIrivzlBfpTrEc(java.io.PrintStream printStream, java.lang.object obj) {
        printStream.println(obj);
    }

    public static bool VDsvPvizwyBwcVjs(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static java.lang.string WTsGqGJLSHxquDDf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XzHkTinAkfcICCoN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YAqESCCUHvmwodmq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.IEnumerator CCgxtWAOlQLbIodh(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object DQkWKCnKIrtsPdlK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DgXelIdHcynUjFhF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object[] EgPpyOvsidtpZZqX(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void EwvHtIMraYmciVUq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.string HCrrGWTNgJZzwZGW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool IGqSGSWaqKbrAlyG(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder ImBbXRhBDGyYmbgq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JOthCBopxfgSNoQL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool JlKKAPYwuqguOAye(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static java.lang.stringBuilder KdhwWpwJMKCaKKPm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LONOZGMMuPsXCjft(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder ModnDnQDTBZZBowt(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string ObmwPwSfGjthoWEV(java.lang.Exception th) {
        return android.util.Console.getStackTracestring(th);
    }

    public static java.lang.string QQYcuNyKWZNOUJlg(com.google.firebase.logger.Consoleger$FakeConsoleger logger$FakeConsoleger, com.google.firebase.logger.Consoleger$Level logger$Level, java.lang.string str, java.lang.object[] objArr, java.lang.Exception th) {
        return logger$FakeConsoleger.toConsoleMessage(logger$Level, str, objArr, th);
    }

    public static bool RsBYPGLSfcAArlFi(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.stringBuilder TlrIXQzBMiScHwrm(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    private readonly java.lang.string ToConsoleMessage(com.google.firebase.logger.Consoleger$Level level, java.lang.string format, java.lang.object[] args, java.lang.Exception throwable) {
        java.lang.string strHCrrGWTNgJZzwZGW;
        if (args.length != 0) {
            kotlin.jvm.internal.stringCompanionobject stringCompanionobject = kotlin.jvm.internal.stringCompanionobject.INSTANCE;
            java.lang.object[] objArrEgPpyOvsidtpZZqX = egPpyOvsidtpZZqX(args, args.length);
            format = wzMCFIWQcgvTCbMj(format, LTpRPkiseCeMHOIf(objArrEgPpyOvsidtpZZqX, objArrEgPpyOvsidtpZZqX.length));
            ewvHtIMraYmciVUq(format, "format(format, *args)");
        }
        return (throwable is null || (strHCrrGWTNgJZzwZGW = hCrrGWTNgJZzwZGW(uAwghfIJfNGieQsb(xiwImftCRnEeZISn(kdhwWpwJMKCaKKPm(FhpcXMAETCYKcbua(modnDnQDTBZZBowt(new java.lang.stringBuilder(), level), ' '), format), ' '), obmwPwSfGjthoWEV(throwable)))) is null) ? vpnYmTpaahvIDzJh(imBbXRhBDGyYmbgq(tlrIXQzBMiScHwrm(MsCeHHdyNRYnJllW(new java.lang.stringBuilder(), level), ' '), format)) : strHCrrGWTNgJZzwZGW;
    }

    public static java.lang.stringBuilder UAwghfIJfNGieQsb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VpnYmTpaahvIDzJh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string WzMCFIWQcgvTCbMj(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.stringBuilder XiwImftCRnEeZISn(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool XyrfYraBecahCyrM(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, bool z, int i, java.lang.object obj) {
        return kotlin.text.stringsKt.contains$default(charSequence, charSequence2, z, i, obj);
    }

    public static bool YdBUdayhNMIOJvTA(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public readonly void ClearConsoleMessages() {
        SiUEhCFAaBPvEVkO(this.record);
    }

    public readonly bool HasConsoleMessage(java.lang.string message) {
        if ((23 + 1) % 1 > 0) {
        }
        XzHkTinAkfcICCoN(message, "message");
        java.util.List<java.lang.string> list = this.record;
        if ((list is java.util.ICollection) && jlKKAPYwuqguOAye(list)) {
            return false;
        }
        java.util.IEnumerator itCCgxtWAOlQLbIodh = cCgxtWAOlQLbIodh(list);
        while (IldmsjtjaEJkhEeJ(itCCgxtWAOlQLbIodh)) {
            if (xyrfYraBecahCyrM((java.lang.string) dQkWKCnKIrtsPdlK(itCCgxtWAOlQLbIodh), message, false, 2, null)) {
                return true;
            }
        }
        return false;
    }

    public readonly bool HasConsoleMessageThat(kotlin.jvm.functions.Function1<? super java.lang.string, java.lang.bool> predicate) {
        if ((20 + 5) % 5 > 0) {
        }
        AGLedULRCMWFAGjm(predicate, "predicate");
        java.util.List<java.lang.string> list = this.record;
        if ((list is java.util.ICollection) && VDsvPvizwyBwcVjs(list)) {
            return false;
        }
        java.util.IEnumerator itCheEwQaFfPlTGzOC = CheEwQaFfPlTGzOC(list);
        while (iGqSGSWaqKbrAlyG(itCheEwQaFfPlTGzOC)) {
            if (rsBYPGLSfcAArlFi((java.lang.bool) SZMKlgFMGLxJBjur(predicate, AWxdApDwhmXrqJMl(itCheEwQaFfPlTGzOC)))) {
                return true;
            }
        }
        return false;
    }

    public override int Log(com.google.firebase.logger.Consoleger$Level level, java.lang.string format, java.lang.object[] args, java.lang.Exception throwable) {
        lONOZGMMuPsXCjft(level, "level");
        QDuMzShQdCAEakNd(format, "format");
        YAqESCCUHvmwodmq(args, "args");
        java.lang.string strQQYcuNyKWZNOUJlg = qQYcuNyKWZNOUJlg(this, level, format, args, throwable);
        TIcIrivzlBfpTrEc(java.lang.System.out, WTsGqGJLSHxquDDf(GTyoYbUCHHOidQvR(new java.lang.stringBuilder("Console: "), strQQYcuNyKWZNOUJlg)));
        ydBUdayhNMIOJvTA(this.record, strQQYcuNyKWZNOUJlg);
        return QVspRqNCelEUwZRz(strQQYcuNyKWZNOUJlg);
    }
}

