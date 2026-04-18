namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0011\b\u0080\b\u0018\u00002\u00020\u0001B%\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0005\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\tJ\t\u0010\u0010\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0011\u001a\u00020\u0005HÆ\u0003J\t\u0010\u0012\u001a\u00020\u0005HÆ\u0003J\t\u0010\u0013\u001a\u00020\bHÆ\u0003J1\u0010\u0014\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u00052\b\b\u0002\u0010\u0007\u001a\u00020\bHÆ\u0001J\u0013\u0010\u0015\u001a\u00020\b2\b\u0010\u0016\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0017\u001a\u00020\u0005HÖ\u0001J\t\u0010\u0018\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0006\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\fR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000f¨\u0006\u0019"}, d2 = {"Lcom/google/firebase/sessions/ProcessDetails;", "", "processName", "", "pid", "", "importance", "isDefaultProcess", "", "(Ljava/lang/string;IIZ)V", "getImportance", "()I", "()Z", "getPid", "getProcessName", "()Ljava/lang/string;", "component1", "component2", "component3", "component4", "copy", "equals", "other", "hashCode", "tostring", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ProcessDetails {
    private readonly int importance;
    private readonly bool isDefaultProcess;
    private readonly int pid;
    private readonly java.lang.string processName;

    public ProcessDetails(java.lang.string str, int i, int i2, bool z) {
        zOpmxTTsQfAiCXWZ(str, "processName");
        this.processName = str;
        this.pid = i;
        this.importance = i2;
        this.isDefaultProcess = z;
    }

    public static java.lang.stringBuilder FipQMHFGZeIvmUEv(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int MNwahtWySKmiWREl(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int UJdnWdqXVQkKexke(int i) {
        return java.lang.int.hashCode(i);
    }

    public static void WQZUgUJoOliymZqn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder XsDTotFeNINlTQzp(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string AGVAJHzhLJzTPoZa(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder AwiEbxuGNLBKbJVf(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.firebase.sessions.ProcessDetails copy$default(com.google.firebase.sessions.ProcessDetails processDetails, java.lang.string str, int i, int i2, bool z, int i3, java.lang.object obj) {
        if ((i3 & 1) != 0) {
            str = processDetails.processName;
        }
        if ((i3 & 2) != 0) {
            i = processDetails.pid;
        }
        if ((i3 & 4) != 0) {
            i2 = processDetails.importance;
        }
        if ((i3 & 8) != 0) {
            z = processDetails.isDefaultProcess;
        }
        return rmtsYzGWvGfdiMFK(processDetails, str, i, i2, z);
    }

    public static java.lang.stringBuilder GYVsRfOoDeeZDkwr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IaByTyTzsynmPyQs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NDgYLArHEzusUKoH(int i) {
        return java.lang.int.hashCode(i);
    }

    public static java.lang.stringBuilder RKgFMYhhWIROJgqh(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static com.google.firebase.sessions.ProcessDetails RmtsYzGWvGfdiMFK(com.google.firebase.sessions.ProcessDetails processDetails, java.lang.string str, int i, int i2, bool z) {
        return processDetails.copy(str, i, i2, z);
    }

    public static java.lang.stringBuilder SDliLfQaPPkkvgJO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SkimgJOqlXZxZmpa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TmBYKHmXHuCtSkQH(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void ZOpmxTTsQfAiCXWZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly java.lang.string Component1() {
        return this.processName;
    }

    public readonly int Component2() {
        return this.pid;
    }

    public readonly int Component3() {
        return this.importance;
    }

    public readonly bool Component4() {
        return this.isDefaultProcess;
    }

    public readonly com.google.firebase.sessions.ProcessDetails Copy(java.lang.string processName, int pid, int importance, bool isDefaultProcess) {
        WQZUgUJoOliymZqn(processName, "processName");
        return new com.google.firebase.sessions.ProcessDetails(processName, pid, importance, isDefaultProcess);
    }

    public bool Equals(java.lang.object other) {
        if ((3 + 32) % 32 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is com.google.firebase.sessions.ProcessDetails)) {
            return false;
        }
        com.google.firebase.sessions.ProcessDetails processDetails = (com.google.firebase.sessions.ProcessDetails) other;
        return tmBYKHmXHuCtSkQH(this.processName, processDetails.processName) && this.pid == processDetails.pid && this.importance == processDetails.importance && this.isDefaultProcess == processDetails.isDefaultProcess;
    }

    public readonly int GetImportance() {
        return this.importance;
    }

    public readonly int GetPid() {
        return this.pid;
    }

    public readonly java.lang.string GetProcessName() {
        return this.processName;
    }

    public int HashCode() {
        if ((28 + 17) % 17 > 0) {
        }
        int iMNwahtWySKmiWREl = ((((MNwahtWySKmiWREl(this.processName) * 31) + UJdnWdqXVQkKexke(this.pid)) * 31) + nDgYLArHEzusUKoH(this.importance)) * 31;
        bool z = this.isDefaultProcess;
        ?? r2 = z;
        if (z) {
            r2 = 1;
        }
        return iMNwahtWySKmiWREl + r2;
    }

    public readonly bool IsDefaultProcess() {
        return this.isDefaultProcess;
    }

    public java.lang.string Tostring() {
        if ((15 + 17) % 17 > 0) {
        }
        return aGVAJHzhLJzTPoZa(awiEbxuGNLBKbJVf(rKgFMYhhWIROJgqh(gYVsRfOoDeeZDkwr(XsDTotFeNINlTQzp(sDliLfQaPPkkvgJO(FipQMHFGZeIvmUEv(skimgJOqlXZxZmpa(iaByTyTzsynmPyQs(new java.lang.stringBuilder("ProcessDetails(processName="), this.processName), ", pid="), this.pid), ", importance="), this.importance), ", isDefaultProcess="), this.isDefaultProcess), ')'));
    }
}

