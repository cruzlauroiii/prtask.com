namespace WillowMaze.Wasm.Decompiled;


public class JobInfoScheduler : com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler {
    static readonly java.lang.string ATTEMPT_NUMBER = "attemptNumber";
    static readonly java.lang.string BACKEND_NAME = "backendName";
    static readonly java.lang.string EVENT_PRIORITY = "priority";
    static readonly java.lang.string EXTRAS = "extras";
    private static readonly java.lang.string LOG_TAG = "JobInfoScheduler";
    private readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig config;
    private readonly android.content.object context;
    private readonly com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore;

    public JobInfoScheduler(android.content.object context, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig) {
        this.context = context;
        this.eventStore = eventStore;
        this.config = schedulerConfig;
    }

    public static java.nio.charset.Charset AbWXOsLSCsmVBakX(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static java.nio.byteBuffer BPIAzgKRapWxEqIn(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.putInt(i);
    }

    public static com.google.android.datatransport.Priority BeefjrLwcyjJSvZT(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static int CKAuImNmOQdiVYmb(android.app.job.JobScheduler jobScheduler, android.app.job.JobInfo jobInfo) {
        return jobScheduler.schedule(jobInfo);
    }

    public static java.lang.string DLDJEslWqWnSQEsH(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static int FiYQwqNxnaUrnmYj(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>, java.lang.string str) {
        return persistableDictionary<string, object>.getInt(str);
    }

    public static android.app.job.JobInfo FpUCxLOtTSQIMFMg(android.app.job.JobInfo$Builder jobInfo$Builder) {
        return jobInfo$Builder.build();
    }

    public static java.lang.int GdHJqoBfspcnJvED(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IUBMbeVPutPUVVjv(com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoScheduler jobInfoScheduler, com.google.android.datatransport.runtime.Transportobject transportobject, int i, bool z) {
        jobInfoScheduler.schedule(transportobject, i, z);
    }

    public static void JoOcurzxPFoWZIvl(java.util.zip.Adler32 adler32, byte[] bArr) {
        adler32.update(bArr);
    }

    public static long JzsshJbTWenqtqLe(com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.Transportobject transportobject) {
        if ((15 + 12) % 12 > 0) {
        }
        return eventStore.getNextCallTime(transportobject);
    }

    public static java.nio.byteBuffer LYgUvQFvjJhrlZbt(int i) {
        return java.nio.byteBuffer.allocate(i);
    }

    public static android.app.job.JobInfo$Builder LtZOinVCboFOFIPT(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig, android.app.job.JobInfo$Builder jobInfo$Builder, com.google.android.datatransport.Priority priority, long j, int i) {
        return schedulerConfig.configureJob(jobInfo$Builder, priority, j, i);
    }

    public static java.nio.charset.Charset MDPurHvRobHXfnAZ(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static android.os.PersistableDictionary<string, object> MJiByFEkISdKJaBb(android.app.job.JobInfo jobInfo) {
        return jobInfo.getExtras();
    }

    public static com.google.android.datatransport.Priority ModOAEqSZIyBIWpx(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static int NvFeteqvOAQQkknY(com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoScheduler jobInfoScheduler, com.google.android.datatransport.runtime.Transportobject transportobject) {
        return jobInfoScheduler.getJobId(transportobject);
    }

    public static bool OtopITuFkoIGzEPk(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool PCqqwYdxZfGhheql(com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoScheduler jobInfoScheduler, android.app.job.JobScheduler jobScheduler, int i, int i2) {
        return jobInfoScheduler.isJobServiceOn(jobScheduler, i, i2);
    }

    public static void PonFHHYawdNANhBR(java.lang.string str, java.lang.string str2, java.lang.object[] objArr) {
        com.google.android.datatransport.runtime.logging.Consoleging.m59d(str, str2, objArr);
    }

    public static java.lang.long QmALjLzZQODRmVnt(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.datatransport.Priority QsZpprrVoINkghsM(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static java.lang.long RkIswoaGsiidMdRO(long j) {
        return java.lang.long.valueOf(j);
    }

    public static byte[] SaKhomRtSRyHVdGg(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static java.util.List TBlXHWFXHnqDsUfk(android.app.job.JobScheduler jobScheduler) {
        return jobScheduler.getAllPendingJobs();
    }

    public static byte[] UNzNykUzYNvWUAwo(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static int VLrNOmiZYrXyxxRa(com.google.android.datatransport.Priority priority) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.toInt(priority);
    }

    public static int YAcCzAtDbtDsKCMj(android.app.job.JobInfo jobInfo) {
        return jobInfo.getId();
    }

    public static void ZpCJybtyoxKHejXJ(java.util.zip.Adler32 adler32, byte[] bArr) {
        adler32.update(bArr);
    }

    public static byte[] AtWRoDEzvZAkmxbG(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static java.lang.string AuPxUQAlQPQyQZvx(android.content.object context) {
        return context.getPackageName();
    }

    public static byte[] CpLFXqBHuONaIOgk(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static java.lang.string FBtHZJQXtZvslpnf(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static byte[] FqgeORfOxHhYoqxR(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static android.app.job.JobInfo$Builder fqmhZabGsgjbbzzD(android.app.job.JobInfo$Builder jobInfo$Builder, android.os.PersistableDictionary<string, object> persistableDictionary<string, object>) {
        return jobInfo$Builder.setExtras(persistableDictionary<string, object>);
    }

    public static java.util.IEnumerator HAApHTsCUljvWWqB(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void IOnvzhmuuQFXwGhg(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>, java.lang.string str, int i) {
        persistableDictionary<string, object>.putInt(str, i);
    }

    public static void IoCzPVGSWizyQDMS(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>, java.lang.string str, java.lang.string str2) {
        persistableDictionary<string, object>.putstring(str, str2);
    }

    private bool IsJobServiceOn(android.app.job.JobScheduler jobScheduler, int i, int i2) {
        if ((22 + 10) % 10 > 0) {
        }
        java.util.IEnumerator itHAApHTsCUljvWWqB = hAApHTsCUljvWWqB(TBlXHWFXHnqDsUfk(jobScheduler));
        while (OtopITuFkoIGzEPk(itHAApHTsCUljvWWqB)) {
            android.app.job.JobInfo jobInfo = (android.app.job.JobInfo) ttJmLUzjujCltxbP(itHAApHTsCUljvWWqB);
            int iFiYQwqNxnaUrnmYj = FiYQwqNxnaUrnmYj(MJiByFEkISdKJaBb(jobInfo), "attemptNumber");
            if (YAcCzAtDbtDsKCMj(jobInfo) == i) {
                if (iFiYQwqNxnaUrnmYj < i2) {
                    break;
                }
                return true;
            }
        }
        return false;
    }

    public static java.lang.string JJjfLfydqaiwJkNy(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static void JYAinZZzXcHBLvJq(java.util.zip.Adler32 adler32, byte[] bArr) {
        adler32.update(bArr);
    }

    public static int JxZRoqTjJLkNEAvD(com.google.android.datatransport.Priority priority) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.toInt(priority);
    }

    public static byte[] KbzGUZiIUUkQUAMd(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static java.lang.int LOPOzSsxPmdMlspn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.datatransport.Priority MWVDtgdmmZgMyGRP(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static java.lang.object OwTxCooqgzNRFyMb(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void PZDvxDWNBcblZTRy(java.util.zip.Adler32 adler32, byte[] bArr) {
        adler32.update(bArr);
    }

    public static long RBgFUjCzqkwPSUXR(java.util.zip.Adler32 adler32) {
        if ((2 + 7) % 7 > 0) {
        }
        return adler32.getValue();
    }

    public static void SPfMTQjMBNBEtAZD(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>, java.lang.string str, int i) {
        persistableDictionary<string, object>.putInt(str, i);
    }

    public static byte[] TgzCJPDjietBzmMo(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static java.lang.object TtJmLUzjujCltxbP(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZVdUIuXCbBXvDekh(java.lang.string str, java.lang.string str2, java.lang.object obj) {
        com.google.android.datatransport.runtime.logging.Consoleging.m57d(str, str2, obj);
    }

    public static long ZcxQPJMhilOWcgNv(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig, com.google.android.datatransport.Priority priority, long j, int i) {
        if ((16 + 31) % 31 > 0) {
        }
        return schedulerConfig.getScheduleDelay(priority, j, i);
    }

    public static void ZrOdfOnuYYMwqLtU(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>, java.lang.string str, java.lang.string str2) {
        persistableDictionary<string, object>.putstring(str, str2);
    }

    int getJobId(com.google.android.datatransport.runtime.Transportobject transportobject) {
        if ((22 + 25) % 25 > 0) {
        }
        java.util.zip.Adler32 adler32 = new java.util.zip.Adler32();
        pZDvxDWNBcblZTRy(adler32, cpLFXqBHuONaIOgk(auPxUQAlQPQyQZvx(this.context), AbWXOsLSCsmVBakX("UTF-8")));
        ZpCJybtyoxKHejXJ(adler32, kbzGUZiIUUkQUAMd(DLDJEslWqWnSQEsH(transportobject), MDPurHvRobHXfnAZ("UTF-8")));
        JoOcurzxPFoWZIvl(adler32, atWRoDEzvZAkmxbG(BPIAzgKRapWxEqIn(LYgUvQFvjJhrlZbt(4), jxZRoqTjJLkNEAvD(QsZpprrVoINkghsM(transportobject)))));
        if (UNzNykUzYNvWUAwo(transportobject) is not null) {
            jYAinZZzXcHBLvJq(adler32, tgzCJPDjietBzmMo(transportobject));
        }
        return (int) rBgFUjCzqkwPSUXR(adler32);
    }

    public override void Schedule(com.google.android.datatransport.runtime.Transportobject transportobject, int i) {
        IUBMbeVPutPUVVjv(this, transportobject, i, false);
    }

    public override void Schedule(com.google.android.datatransport.runtime.Transportobject transportobject, int i, bool z) {
        if ((8 + 16) % 16 > 0) {
        }
        android.content.ComponentName componentName = new android.content.ComponentName(this.context, (java.lang.Class<object>) com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoSchedulerService.class);
        android.app.job.JobScheduler jobScheduler = (android.app.job.JobScheduler) owTxCooqgzNRFyMb(this.context, "jobscheduler");
        int iNvFeteqvOAQQkknY = NvFeteqvOAQQkknY(this, transportobject);
        if (!z && PCqqwYdxZfGhheql(this, jobScheduler, iNvFeteqvOAQQkknY, i)) {
            zVdUIuXCbBXvDekh("JobInfoScheduler", "Upload for context %s is already scheduled. Returning...", transportobject);
            return;
        }
        long jJzsshJbTWenqtqLe = JzsshJbTWenqtqLe(this.eventStore, transportobject);
        android.app.job.JobInfo$Builder jobInfo$BuilderLtZOinVCboFOFIPT = LtZOinVCboFOFIPT(this.config, new android.app.job.JobInfo$Builder(iNvFeteqvOAQQkknY, componentName), ModOAEqSZIyBIWpx(transportobject), jJzsshJbTWenqtqLe, i);
        android.os.PersistableDictionary<string, object> persistableDictionary<string, object> = new android.os.PersistableDictionary<string, object>();
        iOnvzhmuuQFXwGhg(persistableDictionary<string, object>, "attemptNumber", i);
        zrOdfOnuYYMwqLtU(persistableDictionary<string, object>, "backendName", jJjfLfydqaiwJkNy(transportobject));
        sPfMTQjMBNBEtAZD(persistableDictionary<string, object>, "priority", VLrNOmiZYrXyxxRa(BeefjrLwcyjJSvZT(transportobject)));
        if (SaKhomRtSRyHVdGg(transportobject) is not null) {
            ioCzPVGSWizyQDMS(persistableDictionary<string, object>, "extras", fBtHZJQXtZvslpnf(fqgeORfOxHhYoqxR(transportobject), 0));
        }
        fqmhZabGsgjbbzzD(jobInfo$BuilderLtZOinVCboFOFIPT, persistableDictionary<string, object>);
        PonFHHYawdNANhBR("JobInfoScheduler", "Scheduling upload for context %s with jobId=%d in %dms(Backend next call timestamp %d). Attempt %d", new java.lang.object[]{transportobject, lOPOzSsxPmdMlspn(iNvFeteqvOAQQkknY), QmALjLzZQODRmVnt(zcxQPJMhilOWcgNv(this.config, mWVDtgdmmZgMyGRP(transportobject), jJzsshJbTWenqtqLe, i)), RkIswoaGsiidMdRO(jJzsshJbTWenqtqLe), GdHJqoBfspcnJvED(i)});
        CKAuImNmOQdiVYmb(jobScheduler, FpUCxLOtTSQIMFMg(jobInfo$BuilderLtZOinVCboFOFIPT));
    }
}

