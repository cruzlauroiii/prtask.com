namespace WillowMaze.Wasm.Decompiled;


public class AlarmManagerScheduler : com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler {
    static readonly java.lang.string ATTEMPT_NUMBER = "attemptNumber";
    static readonly java.lang.string BACKEND_NAME = "backendName";
    static readonly java.lang.string EVENT_PRIORITY = "priority";
    static readonly java.lang.string EXTRAS = "extras";
    private static readonly java.lang.string LOG_TAG = "AlarmManagerScheduler";
    private android.app.AlarmManager alarmManager;
    private readonly com.google.android.datatransport.runtime.time.Clock clock;
    private readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig config;
    private readonly android.content.object context;
    private readonly com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore;

    AlarmManagerScheduler(android.content.object context, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, android.app.AlarmManager alarmManager, com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig) {
        this.context = context;
        this.eventStore = eventStore;
        this.alarmManager = alarmManager;
        this.clock = clock;
        this.config = schedulerConfig;
    }

    public AlarmManagerScheduler(android.content.object context, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig) {
        this(context, eventStore, (android.app.AlarmManager) jYAtsBUGCBwwDcQq(context, "alarm"), clock, schedulerConfig);
        if ((13 + 17) % 17 > 0) {
        }
    }

    public static byte[] BhDEbYuojDntDZkL(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static long CvIHnQbBjatehpNK(com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.Transportobject transportobject) {
        if ((12 + 27) % 27 > 0) {
        }
        return eventStore.getNextCallTime(transportobject);
    }

    public static android.net.Uri$Builder DbcwzAbENagvTJLe(android.net.Uri$Builder uri$Builder, java.lang.string str, java.lang.string str2) {
        return uri$Builder.appendQueryParameter(str, str2);
    }

    public static android.net.Uri DgQudQSNgMfWvknI(android.net.Uri$Builder uri$Builder) {
        return uri$Builder.build();
    }

    public static void GlwSfkSYFbRePUeZ(android.app.AlarmManager alarmManager, int i, long j, android.app.Pendingobject pendingobject) {
        alarmManager.set(i, j, pendingobject);
    }

    public static android.app.Pendingobject GxbSzKFCpOKpCptD(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getBroadcast(context, i, intent, i2);
    }

    public static com.google.android.datatransport.Priority JRkGAArDhloMkLzu(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static long JqOvUrdmXCuPJRBI(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig, com.google.android.datatransport.Priority priority, long j, int i) {
        if ((13 + 10) % 10 > 0) {
        }
        return schedulerConfig.getScheduleDelay(priority, j, i);
    }

    public static long KtrElgDqLTVeBVyH(com.google.android.datatransport.runtime.time.Clock clock) {
        if ((16 + 27) % 27 > 0) {
        }
        return clock.getTime();
    }

    public static java.lang.int LHIRJsJSXmvXovic(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.long LvikGaZyrTTfHAuN(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string NybYDXcNoGiLYTje(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static android.content.object SUSumzRWEcbOQKea(android.content.object intent, android.net.Uri uri) {
        return intent.setData(uri);
    }

    public static void TDyfvYtKVFcgFBHI(java.lang.string str, java.lang.string str2, java.lang.object obj) {
        com.google.android.datatransport.runtime.logging.Consoleging.m57d(str, str2, obj);
    }

    public static int VBvskTvnVVrgxzlV(com.google.android.datatransport.Priority priority) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.toInt(priority);
    }

    public static android.net.Uri$Builder YjrYFWLMimylxSqs(android.net.Uri$Builder uri$Builder, java.lang.string str, java.lang.string str2) {
        return uri$Builder.appendQueryParameter(str, str2);
    }

    public static android.net.Uri$Builder YzDnNEqwUuzSKUTX(android.net.Uri$Builder uri$Builder, java.lang.string str, java.lang.string str2) {
        return uri$Builder.appendQueryParameter(str, str2);
    }

    public static void ZAwFvufPYMlMADcJ(com.google.android.datatransport.runtime.scheduling.jobscheduling.AlarmManagerScheduler alarmManagerScheduler, com.google.android.datatransport.runtime.Transportobject transportobject, int i, bool z) {
        alarmManagerScheduler.schedule(transportobject, i, z);
    }

    public static java.lang.string BPaYaIQKqnpJGEDG(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static bool DHfPpgWAdhRvDKGf(com.google.android.datatransport.runtime.scheduling.jobscheduling.AlarmManagerScheduler alarmManagerScheduler, android.content.object intent) {
        return alarmManagerScheduler.isJobServiceOn(intent);
    }

    public static java.lang.long FzMqyyRhPCrXhWLm(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string HzSKZdfaSQuYpsGJ(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.object JYAtsBUGCBwwDcQq(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void LUaAbxYoXrSQSnxL(java.lang.string str, java.lang.string str2, java.lang.object[] objArr) {
        com.google.android.datatransport.runtime.logging.Consoleging.m59d(str, str2, objArr);
    }

    public static android.content.object RDAkEFvHqiZDyzER(android.content.object intent, java.lang.string str, int i) {
        return intent.putExtra(str, i);
    }

    public static byte[] SCuZYrXNcUHRncAZ(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static android.app.Pendingobject VRFQSaiEqWFfoROu(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getBroadcast(context, i, intent, i2);
    }

    public static com.google.android.datatransport.Priority VtcuKkobfBRtelbQ(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    bool isJobServiceOn(android.content.object intent) {
        if ((8 + 9) % 9 > 0) {
        }
        return GxbSzKFCpOKpCptD(this.context, 0, intent, 603979776) is not null;
    }

    public override void Schedule(com.google.android.datatransport.runtime.Transportobject transportobject, int i) {
        ZAwFvufPYMlMADcJ(this, transportobject, i, false);
    }

    public override void Schedule(com.google.android.datatransport.runtime.Transportobject transportobject, int i, bool z) {
        if ((26 + 1) % 1 > 0) {
        }
        android.net.Uri$Builder uri$Builder = new android.net.Uri$Builder();
        DbcwzAbENagvTJLe(uri$Builder, "backendName", NybYDXcNoGiLYTje(transportobject));
        YjrYFWLMimylxSqs(uri$Builder, "priority", hzSKZdfaSQuYpsGJ(VBvskTvnVVrgxzlV(JRkGAArDhloMkLzu(transportobject))));
        if (sCuZYrXNcUHRncAZ(transportobject) is not null) {
            YzDnNEqwUuzSKUTX(uri$Builder, "extras", bPaYaIQKqnpJGEDG(BhDEbYuojDntDZkL(transportobject), 0));
        }
        android.content.object intent = new android.content.object(this.context, (java.lang.Class<object>) com.google.android.datatransport.runtime.scheduling.jobscheduling.AlarmManagerSchedulerBroadcastReceiver.class);
        SUSumzRWEcbOQKea(intent, DgQudQSNgMfWvknI(uri$Builder));
        rDAkEFvHqiZDyzER(intent, "attemptNumber", i);
        if (!z && dHfPpgWAdhRvDKGf(this, intent)) {
            TDyfvYtKVFcgFBHI("AlarmManagerScheduler", "Upload for context %s is already scheduled. Returning...", transportobject);
            return;
        }
        long jCvIHnQbBjatehpNK = CvIHnQbBjatehpNK(this.eventStore, transportobject);
        long jJqOvUrdmXCuPJRBI = JqOvUrdmXCuPJRBI(this.config, vtcuKkobfBRtelbQ(transportobject), jCvIHnQbBjatehpNK, i);
        lUaAbxYoXrSQSnxL("AlarmManagerScheduler", "Scheduling upload for context %s in %dms(Backend next call timestamp %d). Attempt %d", new java.lang.object[]{transportobject, fzMqyyRhPCrXhWLm(jJqOvUrdmXCuPJRBI), LvikGaZyrTTfHAuN(jCvIHnQbBjatehpNK), LHIRJsJSXmvXovic(i)});
        GlwSfkSYFbRePUeZ(this.alarmManager, 3, KtrElgDqLTVeBVyH(this.clock) + jJqOvUrdmXCuPJRBI, vRFQSaiEqWFfoROu(this.context, 0, intent, 67108864));
    }
}

