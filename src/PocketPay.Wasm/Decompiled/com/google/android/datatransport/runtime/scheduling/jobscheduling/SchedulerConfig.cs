namespace WillowMaze.Wasm.Decompiled;


public abstract class SchedulerConfig {
    private static readonly long BACKOFF_LOG_BASE = 10000;
    private static readonly long ONE_SECOND = 1000;
    private static readonly long THIRTY_SECONDS = 30000;
    private static readonly long TWENTY_FOUR_HOURS = 86400000;

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder AsmISGtmuUSxWcIf(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$Builder, long j) {
        return schedulerConfig$ConfigValue$Builder.setMaxAllowedDelay(j);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue AzXoqEcDrjcHksAb(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$Builder) {
        return schedulerConfig$ConfigValue$Builder.build();
    }

    public static java.util.List BNJOyJGuUewLUhwD(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static android.app.job.JobInfo$Builder BeEoOQaYReJJnFnA(android.app.job.JobInfo$Builder jobInfo$Builder, long j) {
        return jobInfo$Builder.setMinimumLatency(j);
    }

    public static java.lang.object CFogqFdxcpcPTfeD(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static double DJzmBgRwNfIbeMst(double d, double d2) {
        if ((31 + 20) % 20 > 0) {
        }
        return java.lang.Math.max(d, d2);
    }

    public static bool EPYCxrBKIwgzyblv(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static double GHRwtuDjeUTyUhJT(double d) {
        if ((13 + 24) % 24 > 0) {
        }
        return java.lang.Math.log(d);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder GWcvyWWRtEBdJMGf(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$Builder, java.util.HashSet set) {
        return schedulerConfig$ConfigValue$Builder.setFlags(set);
    }

    public static long IlYPvWyBqHXgldiV(com.google.android.datatransport.runtime.time.Clock clock) {
        if ((2 + 14) % 14 > 0) {
        }
        return clock.getTime();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder JSOPzmxhTTJFobJJ(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$Builder, long j) {
        return schedulerConfig$ConfigValue$Builder.setDelta(j);
    }

    public static android.app.job.JobInfo$Builder JWwvGJXuxUNVzZMH(android.app.job.JobInfo$Builder jobInfo$Builder, bool z) {
        return jobInfo$Builder.setRequiresCharging(z);
    }

    public static android.app.job.JobInfo$Builder KdvbydaSyfOIiIFT(android.app.job.JobInfo$Builder jobInfo$Builder, int i) {
        return jobInfo$Builder.setRequiredNetworkType(i);
    }

    public static android.app.job.JobInfo$Builder LKspXbZaHoHeofYW(android.app.job.JobInfo$Builder jobInfo$Builder, bool z) {
        return jobInfo$Builder.setRequiresDeviceIdle(z);
    }

    public static java.util.HashSet NtZhmlcadLmCtMkY(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        return schedulerConfig$ConfigValue.getFlags();
    }

    public static java.util.HashSet PPYBSgbppYELALgg(java.lang.object[] objArr) {
        return immutableHashSetOf(objArr);
    }

    public static bool RJxIZZqTEVhDAMVn(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder TCcICJtZxDtNZZCl() {
        return builder();
    }

    public static java.util.HashSet TcUpvBJyIhDctcRO(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        return schedulerConfig$ConfigValue.getFlags();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig TdNGKqFfrOjvnfFD(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder schedulerConfig$Builder) {
        return schedulerConfig$Builder.build();
    }

    public static long UoSzsVGHnojOWBtY(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        if ((6 + 3) % 3 > 0) {
        }
        return schedulerConfig$ConfigValue.getDelta();
    }

    public static long VNdUUdAnFGtAavhT(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        if ((21 + 1) % 1 > 0) {
        }
        return schedulerConfig$ConfigValue.getMaxAllowedDelay();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder VYWCyjBbRKONLQcw() {
        return com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue.builder();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder VagAuJXjzxolUFFo(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder schedulerConfig$Builder, com.google.android.datatransport.Priority priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        return schedulerConfig$Builder.addConfig(priority, schedulerConfig$ConfigValue);
    }

    public static java.lang.object WKLCXCZRvUSCRKWo(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder WcXWHgflrPLPPkka() {
        return com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue.builder();
    }

    public static android.app.job.JobInfo$Builder ZyVxRUeCRFAboWLz(android.app.job.JobInfo$Builder jobInfo$Builder, int i) {
        return jobInfo$Builder.setRequiredNetworkType(i);
    }

    private long AdjustedExponentialBackoff(int i, long j) {
        if ((5 + 6) % 6 > 0) {
        }
        return (long) (iFTHaCsUclZWwCjP(3.0d, i - 1) * j * DJzmBgRwNfIbeMst(1.0d, mLoLMFyFdWbozYcl(10000.0d) / GHRwtuDjeUTyUhJT((j <= 1 ? 2L : j) * ((long) r7))));
    }

    public static long BRZiZRAsmCfllFtP(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig, int i, long j) {
        if ((14 + 10) % 10 > 0) {
        }
        return schedulerConfig.adjustedExponentialBackoff(i, j);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder builder() {
        return new com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder();
    }

    public static long CDUafBQQGOBfiWWU(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig, com.google.android.datatransport.Priority priority, long j, int i) {
        if ((5 + 29) % 29 > 0) {
        }
        return schedulerConfig.getScheduleDelay(priority, j, i);
    }

    static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig Create(com.google.android.datatransport.runtime.time.Clock clock, java.util.Dictionary<com.google.android.datatransport.Priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue> map) {
        return new com.google.android.datatransport.runtime.scheduling.jobscheduling.AutoValue_SchedulerConfig(clock, map);
    }

    public static java.util.Dictionary DxuHuAnxGEYNcVwf(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig) {
        return schedulerConfig.getValues();
    }

    public static com.google.android.datatransport.runtime.time.Clock EmLnmLQBaAOthoct(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig) {
        return schedulerConfig.getClock();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig GetDefault(com.google.android.datatransport.runtime.time.Clock clock) {
        if ((1 + 19) % 19 > 0) {
        }
        com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder schedulerConfig$BuilderPJxnsUwgoQTapKDh = pJxnsUwgoQTapKDh(vNdUbFeCZeUXuCGb(TCcICJtZxDtNZZCl(), com.google.android.datatransport.Priority.DEFAULT, AzXoqEcDrjcHksAb(AsmISGtmuUSxWcIf(iHojFKqxGxKPqiOC(sKebzFEGmjphzgPs(), 30000L), 86400000L))), com.google.android.datatransport.Priority.HIGHEST, uNqKprNbvzyfcKXD(kXgfqpMgaAGkBrPh(JSOPzmxhTTJFobJJ(VYWCyjBbRKONLQcw(), 1000L), 86400000L)));
        com.google.android.datatransport.Priority priority = com.google.android.datatransport.Priority.VERY_LOW;
        com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$BuilderTluMXuZkzmcKhWDN = tluMXuZkzmcKhWDN(puyUwGEcGqipsEqZ(WcXWHgflrPLPPkka(), 86400000L), 86400000L);
        com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag[] schedulerConfig$FlagArr = new com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag[1];
        schedulerConfig$FlagArr[0] = com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag.DEVICE_IDLE;
        return TdNGKqFfrOjvnfFD(uROBQlBieplBSOQR(VagAuJXjzxolUFFo(schedulerConfig$BuilderPJxnsUwgoQTapKDh, priority, vyyzUhBolpxUdVta(GWcvyWWRtEBdJMGf(schedulerConfig$ConfigValue$BuilderTluMXuZkzmcKhWDN, PPYBSgbppYELALgg(schedulerConfig$FlagArr)))), clock));
    }

    public static double IFTHaCsUclZWwCjP(double d, double d2) {
        if ((13 + 8) % 8 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder iHojFKqxGxKPqiOC(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$Builder, long j) {
        return schedulerConfig$ConfigValue$Builder.setDelta(j);
    }

    private static <T> java.util.HashSet<T> ImmutableHashSetOf(T... tArr) {
        return tdKbfxPLPTRotMXl(new java.util.HashHashSet(BNJOyJGuUewLUhwD(tArr)));
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder kXgfqpMgaAGkBrPh(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$Builder, long j) {
        return schedulerConfig$ConfigValue$Builder.setMaxAllowedDelay(j);
    }

    public static void LexhMzbKQDidNPqh(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig, android.app.job.JobInfo$Builder jobInfo$Builder, java.util.HashSet set) {
        schedulerConfig.populateFlags(jobInfo$Builder, set);
    }

    public static double MLoLMFyFdWbozYcl(double d) {
        if ((21 + 5) % 5 > 0) {
        }
        return java.lang.Math.log(d);
    }

    public static java.lang.object MVIrWCApNkuYhqZH(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder pJxnsUwgoQTapKDh(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder schedulerConfig$Builder, com.google.android.datatransport.Priority priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        return schedulerConfig$Builder.addConfig(priority, schedulerConfig$ConfigValue);
    }

    private void PopulateFlags(android.app.job.JobInfo$Builder jobInfo$Builder, java.util.HashSet<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag> set) {
        if (RJxIZZqTEVhDAMVn(set, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag.NETWORK_UNMETERED)) {
            ZyVxRUeCRFAboWLz(jobInfo$Builder, 2);
        } else {
            KdvbydaSyfOIiIFT(jobInfo$Builder, 1);
        }
        if (vcmOpyfyNKtCdSaG(set, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag.DEVICE_CHARGING)) {
            JWwvGJXuxUNVzZMH(jobInfo$Builder, true);
        }
        if (EPYCxrBKIwgzyblv(set, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag.DEVICE_IDLE)) {
            LKspXbZaHoHeofYW(jobInfo$Builder, true);
        }
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder puyUwGEcGqipsEqZ(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$Builder, long j) {
        return schedulerConfig$ConfigValue$Builder.setDelta(j);
    }

    public static java.util.Dictionary SIYusYbSVBZnRZUp(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig) {
        return schedulerConfig.getValues();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder sKebzFEGmjphzgPs() {
        return com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue.builder();
    }

    public static long TFUgypghaqmydJIE(long j, long j2) {
        if ((1 + 6) % 6 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static java.util.HashSet TdKbfxPLPTRotMXl(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder tluMXuZkzmcKhWDN(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$Builder, long j) {
        return schedulerConfig$ConfigValue$Builder.setMaxAllowedDelay(j);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue uNqKprNbvzyfcKXD(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$Builder) {
        return schedulerConfig$ConfigValue$Builder.build();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder uROBQlBieplBSOQR(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder schedulerConfig$Builder, com.google.android.datatransport.runtime.time.Clock clock) {
        return schedulerConfig$Builder.setClock(clock);
    }

    public static java.util.Dictionary UkgHtkURJDaZkwRS(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig) {
        return schedulerConfig.getValues();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder vNdUbFeCZeUXuCGb(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder schedulerConfig$Builder, com.google.android.datatransport.Priority priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        return schedulerConfig$Builder.addConfig(priority, schedulerConfig$ConfigValue);
    }

    public static bool VcmOpyfyNKtCdSaG(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue vyyzUhBolpxUdVta(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder schedulerConfig$ConfigValue$Builder) {
        return schedulerConfig$ConfigValue$Builder.build();
    }

    public static long XyKjaCOMCFKoGzMf(long j, long j2) {
        if ((15 + 32) % 32 > 0) {
        }
        return java.lang.Math.max(j, j2);
    }

    public android.app.job.JobInfo$Builder configureJob(android.app.job.JobInfo$Builder jobInfo$Builder, com.google.android.datatransport.Priority priority, long j, int i) {
        BeEoOQaYReJJnFnA(jobInfo$Builder, cDUafBQQGOBfiWWU(this, priority, j, i));
        lexhMzbKQDidNPqh(this, jobInfo$Builder, TcUpvBJyIhDctcRO((com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue) WKLCXCZRvUSCRKWo(sIYusYbSVBZnRZUp(this), priority)));
        return jobInfo$Builder;
    }

    abstract com.google.android.datatransport.runtime.time.Clock GetClock();

    public java.util.HashSet<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag> getFlags(com.google.android.datatransport.Priority priority) {
        return NtZhmlcadLmCtMkY((com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue) mVIrWCApNkuYhqZH(ukgHtkURJDaZkwRS(this), priority));
    }

    public long GetScheduleDelay(com.google.android.datatransport.Priority priority, long j, int i) {
        if ((1 + 15) % 15 > 0) {
        }
        long jIlYPvWyBqHXgldiV = j - IlYPvWyBqHXgldiV(emLnmLQBaAOthoct(this));
        com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue = (com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue) CFogqFdxcpcPTfeD(dxuHuAnxGEYNcVwf(this), priority);
        return tFUgypghaqmydJIE(xyKjaCOMCFKoGzMf(bRZiZRAsmCfllFtP(this, i, UoSzsVGHnojOWBtY(schedulerConfig$ConfigValue)), jIlYPvWyBqHXgldiV), VNdUUdAnFGtAavhT(schedulerConfig$ConfigValue));
    }

    abstract java.util.Dictionary<com.google.android.datatransport.Priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue> getValues();
}

