namespace PrTask.Git.Generated;

internal static partial class Gc
{
    internal const string FAILED_RUN = "failed to run %s";
    internal static void CleanPackGarbage()
    {
    }

    internal static void ReportPackGarbage(uint SeenBits, string Path)
    {
    }

    internal static void ProcessLogFile()
    {
    }

    internal static void ProcessLogFileAtExit()
    {
    }

    internal static int GcConfigIsTimestampNever(string Var)
        => default;

    internal static void GcConfigRelease(nint Cfg)
    {
    }

    internal static void GcConfig(nint Cfg)
    {
    }

    internal enum SchedulePriority
    {
        SCHEDULE_NONE = 0,
        SCHEDULE_WEEKLY = 1,
        SCHEDULE_DAILY = 2,
        SCHEDULE_HOURLY = 3,
    }
    internal static SchedulePriority ParseSchedule(string Value)
        => default;

    internal enum MaintenanceTaskLabel
    {
        TASK_PREFETCH,
        TASK_LOOSE_OBJECTS,
        TASK_INCREMENTAL_REPACK,
        TASK_GEOMETRIC_REPACK,
        TASK_GC,
        TASK_COMMIT_GRAPH,
        TASK_PACK_REFS,
        TASK_REFLOG_EXPIRE,
        TASK_WORKTREE_PRUNE,
        TASK_RERERE_GC,
        TASK__COUNT,
    }
    internal static void MaintenanceRunOptsRelease(nint Opts)
    {
    }

    internal static int PackRefsCondition(nint Cfg)
        => default;

    internal static int ReflogExpireCondition(nint UNUSED)
        => default;

    internal static int WorktreePruneCondition(nint Cfg)
        => default;

    internal static int RerereGcCondition(nint UNUSED)
        => default;

    internal static int TooManyLooseObjects(int Limit)
        => default;

    internal static int TooManyPacks(nint Cfg)
        => default;

    internal static ulong TotalRam()
        => default;

    internal static int KeepOnePack(nint Item, nint Data)
        => default;

    internal static void AddRepackIncrementalOption(nint Args)
    {
    }

    internal static int NeedToGc(nint Cfg, nint RepackArgs)
        => default;

    internal static int ReportLastGcError()
        => default;

    internal static int DfsOnRef(nint Ref, nint CbData)
        => default;

    internal static int ShouldWriteCommitGraph(nint UNUSED)
        => default;

    internal static int RunWriteCommitGraph(nint Opts)
        => default;

    internal static int FetchRemote(nint Remote, nint Cbdata)
        => default;

    internal static int GcCondition(nint Cfg)
        => default;

    internal static int PrunePacked(nint Opts)
        => default;

    internal static int LooseObjectAutoCondition(nint UNUSED)
        => default;

    internal static int PackLoose(nint Opts)
        => default;

    internal static int IncrementalRepackAutoCondition(nint UNUSED)
        => default;

    internal static int MultiPackIndexWrite(nint Opts)
        => default;

    internal static int MultiPackIndexExpire(nint Opts)
        => default;

    internal static long GetAutoPackSize()
        => default;

    internal static int MultiPackIndexRepack(nint Opts)
        => default;

    internal static int GeometricRepackAutoCondition(nint UNUSED)
        => default;

    internal enum TaskPhase
    {
        TASK_PHASE_FOREGROUND,
        TASK_PHASE_BACKGROUND,
    }
    internal enum MaintenanceType
    {
        MAINTENANCE_TYPE_SCHEDULED = (1 << 0),
        MAINTENANCE_TYPE_MANUAL    = (1 << 1),
    }
    internal static MaintenanceStrategy ParseMaintenanceStrategy(string Name)
        => default;

    internal static int GetScheduleCmd(string Cmd, nint IsAvailable, string Out)
        => default;

    internal static int GetRandomMinute()
        => default;

    internal static int IsLaunchctlAvailable()
        => default;

    internal static int LaunchctlBootPlist(int Enable, string Filename)
        => default;

    internal static int LaunchctlRemovePlist(SchedulePriority Schedule)
        => default;

    internal static int LaunchctlRemovePlists()
        => default;

    internal static int LaunchctlListContainsPlist(string Name, string Cmd)
        => default;

    internal static int LaunchctlSchedulePlist(string ExecPath, SchedulePriority Schedule)
        => default;

    internal static int LaunchctlAddPlists()
        => default;

    internal static int LaunchctlUpdateSchedule(int RunMaintenance, Int fd UNUSED)
        => default;

    internal static int IsSchtasksAvailable()
        => default;

    internal static int SchtasksRemoveTask(SchedulePriority Schedule)
        => default;

    internal static int SchtasksRemoveTasks()
        => default;

    internal static int SchtasksScheduleTask(string ExecPath, SchedulePriority Schedule)
        => default;

    internal static int SchtasksScheduleTasks()
        => default;

    internal static int SchtasksUpdateSchedule(int RunMaintenance, Int fd UNUSED)
        => default;

    internal static int CheckCrontabProcess(string Cmd)
        => default;

    internal static int IsCrontabAvailable()
        => default;

    internal const string BEGIN_LINE = "# BEGIN GIT MAINTENANCE SCHEDULE";
    internal const string END_LINE = "# END GIT MAINTENANCE SCHEDULE";
    internal static int CrontabUpdateSchedule(int RunMaintenance, int Fd)
        => default;

    internal static int RealIsSystemdTimerAvailable()
        => default;

    internal static int IsSystemdTimerAvailable()
        => default;

    internal const string SYSTEMD_UNIT_FORMAT = "git-maintenance@%s.%s";
    internal static int SystemdTimerDeleteTimerFile(SchedulePriority Priority)
        => default;

    internal static int SystemdTimerDeleteServiceTemplate()
        => default;

    internal static int SystemdTimerWriteServiceTemplate(string ExecPath)
        => default;

    internal static void SystemdTimerDeleteStaleTimerTemplates()
    {
    }

    internal static int SystemdTimerDeleteUnitFiles()
        => default;

    internal static int SystemdTimerDeleteUnits()
        => default;

    internal static int SystemdTimerSetupUnits()
        => default;

    internal static int SystemdTimerUpdateSchedule(int RunMaintenance, Int fd UNUSED)
        => default;

    internal enum Scheduler
    {
        SCHEDULER_INVALID = -1,
        SCHEDULER_AUTO,
        SCHEDULER_CRON,
        SCHEDULER_SYSTEMD,
        SCHEDULER_LAUNCHCTL,
        SCHEDULER_SCHTASKS,
    }
    internal static Scheduler ParseScheduler(string Value)
        => default;

    internal static Scheduler ResolveScheduler(Scheduler Scheduler)
        => default;

    internal static void ValidateScheduler(Scheduler Scheduler)
    {
    }

}
