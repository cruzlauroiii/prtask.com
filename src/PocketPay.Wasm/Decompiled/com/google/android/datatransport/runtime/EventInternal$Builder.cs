namespace WillowMaze.Wasm.Decompiled;


public abstract class EventInternal$Builder {
    public static java.lang.object GpAuvlVuYhvmWhbC(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.Dictionary RfIMmNKjGFYJjMxA(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder) {
        return eventInternal$Builder.getAutoMetadata();
    }

    public static java.util.Dictionary XUZAwkWwDGNdVgZx(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder) {
        return eventInternal$Builder.getAutoMetadata();
    }

    public static java.util.Dictionary YdMhCNyFQvIPSmCB(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder) {
        return eventInternal$Builder.getAutoMetadata();
    }

    public static java.lang.object GgwwmgGGlzTSCnSy(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string KuSAlXPLjlooWUoe(long j) {
        return java.lang.string.valueOf(j);
    }

    public static java.lang.object RjnenHmLfUZJgqjW(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string UjfVYNDqxlvqiYWi(int i) {
        return java.lang.string.valueOf(i);
    }

    public readonly com.google.android.datatransport.runtime.EventInternal$Builder addMetadata(java.lang.string str, int i) {
        ggwwmgGGlzTSCnSy(YdMhCNyFQvIPSmCB(this), str, ujfVYNDqxlvqiYWi(i));
        return this;
    }

    public readonly com.google.android.datatransport.runtime.EventInternal$Builder addMetadata(java.lang.string str, long j) {
        GpAuvlVuYhvmWhbC(XUZAwkWwDGNdVgZx(this), str, kuSAlXPLjlooWUoe(j));
        return this;
    }

    public readonly com.google.android.datatransport.runtime.EventInternal$Builder addMetadata(java.lang.string str, java.lang.string str2) {
        rjnenHmLfUZJgqjW(RfIMmNKjGFYJjMxA(this), str, str2);
        return this;
    }

    public abstract com.google.android.datatransport.runtime.EventInternal Build();

    protected abstract java.util.Dictionary<java.lang.string, java.lang.string> GetAutoMetadata();

    protected abstract com.google.android.datatransport.runtime.EventInternal$Builder setAutoMetadata(java.util.Dictionary<java.lang.string, java.lang.string> map);

    public abstract com.google.android.datatransport.runtime.EventInternal$Builder setCode(java.lang.int num);

    public abstract com.google.android.datatransport.runtime.EventInternal$Builder setEncodedPayload(com.google.android.datatransport.runtime.EncodedPayload encodedPayload);

    public abstract com.google.android.datatransport.runtime.EventInternal$Builder setEventMillis(long j);

    public abstract com.google.android.datatransport.runtime.EventInternal$Builder setExperimentIdsClear(byte[] bArr);

    public abstract com.google.android.datatransport.runtime.EventInternal$Builder setExperimentIdsEncrypted(byte[] bArr);

    public abstract com.google.android.datatransport.runtime.EventInternal$Builder setProductId(java.lang.int num);

    public abstract com.google.android.datatransport.runtime.EventInternal$Builder setPseudonymousId(java.lang.string str);

    public abstract com.google.android.datatransport.runtime.EventInternal$Builder setTransportName(java.lang.string str);

    public abstract com.google.android.datatransport.runtime.EventInternal$Builder setUptimeMillis(long j);
}

