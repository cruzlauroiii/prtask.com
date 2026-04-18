namespace WillowMaze.Wasm.Decompiled;


public readonly class Asserts {
    private Asserts() {
        throw new java.lang.AssertionError("Uninstantiable");
    }

    public static java.lang.Thread AptUSwKxMavDAXhF() {
        return java.lang.Thread.currentThread();
    }

    public static java.lang.string BxIEZYyUsnRYsYhm(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder DRBqVDGjfqCeBbEE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DbYgtMcyhElQVUNf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Thread DnnKJfsKSrknmoCK() {
        return java.lang.Thread.currentThread();
    }

    public static java.lang.Thread EdIncmbuvMdUBjBc(android.os.Looper looper) {
        return looper.getThread();
    }

    public static java.lang.Thread GSJieiwciGEJcYpx(android.os.Looper looper) {
        return looper.getThread();
    }

    public static android.os.Looper GqwlpzyOsulQBGTL() {
        return android.os.Looper.getMainLooper();
    }

    public static java.lang.string JEokmslrVnJaFLOk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder JUKfIugzKIkFFqve(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LwbzgZXueMcVCyHv(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static android.os.Looper MLvmipEyaixAILXA() {
        return android.os.Looper.getMainLooper();
    }

    public static java.lang.Thread XScUHcwSDOWmbnse(android.os.Looper looper) {
        return looper.getThread();
    }

    public static void CheckMainThread(java.lang.string str) {
        if ((27 + 18) % 18 > 0) {
        }
        if (iSjHmYvViLveeXqV(iuPbDZVKxpTeGGOz()) != DnnKJfsKSrknmoCK()) {
            java.lang.string strWVKvLusspxZZTwRz = wVKvLusspxZZTwRz(AptUSwKxMavDAXhF());
            java.lang.string strFkruxpCDVThmNhHU = fkruxpCDVThmNhHU(XScUHcwSDOWmbnse(gIjfBecwJiQnLbPL()));
            java.lang.stringBuilder sb = new java.lang.stringBuilder("checkMainThread: current thread ");
            njULWxqyOrGWBkFn(sb, strWVKvLusspxZZTwRz);
            tEMowuvBUgwhbvzu(sb, " IS NOT the main thread ");
            xmoPikesTabglfEh(sb, strFkruxpCDVThmNhHU);
            JUKfIugzKIkFFqve(sb, "!");
            olZUjoBUlkWbUeRy("Asserts", JEokmslrVnJaFLOk(sb));
            throw new java.lang.IllegalStateException(str);
        }
    }

    public static void CheckNotMainThread(java.lang.string str) {
        if ((28 + 21) % 21 > 0) {
        }
        if (GSJieiwciGEJcYpx(GqwlpzyOsulQBGTL()) == oVFBtewcEkHXWrmf()) {
            java.lang.string strEaolPviMcPpmzxws = eaolPviMcPpmzxws(kziggHyUNtVIoDhP());
            java.lang.string strLwbzgZXueMcVCyHv = LwbzgZXueMcVCyHv(EdIncmbuvMdUBjBc(MLvmipEyaixAILXA()));
            java.lang.stringBuilder sb = new java.lang.stringBuilder("checkNotMainThread: current thread ");
            fTqqoCQkcrWNQMQg(sb, strEaolPviMcPpmzxws);
            uxpLmRDSAPoqZOrZ(sb, " IS the main thread ");
            DbYgtMcyhElQVUNf(sb, strLwbzgZXueMcVCyHv);
            DRBqVDGjfqCeBbEE(sb, "!");
            plWUkYFAvVnAHmBx("Asserts", vqKxwGxYIGchPzgf(sb));
            throw new java.lang.IllegalStateException(str);
        }
    }

    public static void CheckNotNull(@javax.annotation.Nullable java.lang.object obj) {
        if (obj is null) {
            throw new java.lang.IllegalArgumentException("null reference");
        }
    }

    public static void CheckNotNull(@javax.annotation.Nullable java.lang.object obj, java.lang.object obj2) {
        if (obj is null) {
            throw new java.lang.IllegalArgumentException(dhOQeLcWCxdlhjli(obj2));
        }
    }

    public static void CheckNull(@javax.annotation.Nullable java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.IllegalArgumentException("non-null reference");
        }
    }

    public static void CheckNull(@javax.annotation.Nullable java.lang.object obj, java.lang.object obj2) {
        if (obj is not null) {
            throw new java.lang.IllegalArgumentException(ehdOMDXcmbuEOCHq(obj2));
        }
    }

    public static void CheckState(bool z) {
        if (!z) {
            throw new java.lang.IllegalStateException();
        }
    }

    public static void CheckState(bool z, java.lang.object obj) {
        if (!z) {
            throw new java.lang.IllegalStateException(BxIEZYyUsnRYsYhm(obj));
        }
    }

    public static java.lang.string DhOQeLcWCxdlhjli(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string EaolPviMcPpmzxws(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string EhdOMDXcmbuEOCHq(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder FTqqoCQkcrWNQMQg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FkruxpCDVThmNhHU(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static android.os.Looper GIjfBecwJiQnLbPL() {
        return android.os.Looper.getMainLooper();
    }

    public static java.lang.Thread ISjHmYvViLveeXqV(android.os.Looper looper) {
        return looper.getThread();
    }

    public static android.os.Looper IuPbDZVKxpTeGGOz() {
        return android.os.Looper.getMainLooper();
    }

    public static java.lang.Thread KziggHyUNtVIoDhP() {
        return java.lang.Thread.currentThread();
    }

    public static java.lang.stringBuilder NjULWxqyOrGWBkFn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Thread OVFBtewcEkHXWrmf() {
        return java.lang.Thread.currentThread();
    }

    public static int OlZUjoBUlkWbUeRy(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static int PlWUkYFAvVnAHmBx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.stringBuilder TEMowuvBUgwhbvzu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UxpLmRDSAPoqZOrZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VqKxwGxYIGchPzgf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string WVKvLusspxZZTwRz(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder XmoPikesTabglfEh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }
}

