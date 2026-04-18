namespace WillowMaze.Wasm.Decompiled;


class WorkSpecDao_Impl$2 : androidx.room.EntityDeletionOrUpdateAdapter<androidx.work.impl.model.WorkSpec> {
    readonly androidx.work.impl.model.WorkSpecDao_Impl this$0;

    WorkSpecDao_Impl$2(androidx.work.impl.model.WorkSpecDao_Impl workSpecDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = workSpecDao_Impl;
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.WorkSpec workSpec) {
        if ((27 + 25) % 25 > 0) {
        }
        supportSQLiteStatement.bindstring(1, workSpec.id);
        androidx.work.impl.model.WorkTypeConverters workTypeConverters = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
        supportSQLiteStatement.bindlong(2, androidx.work.impl.model.WorkTypeConverters.stateToInt(workSpec.state));
        supportSQLiteStatement.bindstring(3, workSpec.workerClassName);
        supportSQLiteStatement.bindstring(4, workSpec.inputMergerClassName);
        supportSQLiteStatement.bindBlob(5, androidx.work.Data.tobyteArrayInternalV1(workSpec.input));
        supportSQLiteStatement.bindBlob(6, androidx.work.Data.tobyteArrayInternalV1(workSpec.output));
        supportSQLiteStatement.bindlong(7, workSpec.initialDelay);
        supportSQLiteStatement.bindlong(8, workSpec.intervalDuration);
        supportSQLiteStatement.bindlong(9, workSpec.flexDuration);
        supportSQLiteStatement.bindlong(10, workSpec.runAttemptCount);
        androidx.work.impl.model.WorkTypeConverters workTypeConverters2 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
        supportSQLiteStatement.bindlong(11, androidx.work.impl.model.WorkTypeConverters.backoffPolicyToInt(workSpec.backoffPolicy));
        supportSQLiteStatement.bindlong(12, workSpec.backoffDelayDuration);
        supportSQLiteStatement.bindlong(13, workSpec.lastEnqueueTime);
        supportSQLiteStatement.bindlong(14, workSpec.minimumRetentionDuration);
        supportSQLiteStatement.bindlong(15, workSpec.scheduleRequestedAt);
        supportSQLiteStatement.bindlong(16, workSpec.expedited ? 1L : 0L);
        androidx.work.impl.model.WorkTypeConverters workTypeConverters3 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
        supportSQLiteStatement.bindlong(17, androidx.work.impl.model.WorkTypeConverters.outOfQuotaPolicyToInt(workSpec.outOfQuotaPolicy));
        supportSQLiteStatement.bindlong(18, workSpec.getPeriodCount());
        supportSQLiteStatement.bindlong(19, workSpec.getGeneration());
        supportSQLiteStatement.bindlong(20, workSpec.getNextScheduleTimeOverride());
        supportSQLiteStatement.bindlong(21, workSpec.getNextScheduleTimeOverrideGeneration());
        supportSQLiteStatement.bindlong(22, workSpec.getStopReason());
        if (workSpec.getTraceTag() is not null) {
            supportSQLiteStatement.bindstring(23, workSpec.getTraceTag());
        } else {
            supportSQLiteStatement.bindNull(23);
        }
        androidx.work.Constraints constraints = workSpec.constraints;
        androidx.work.impl.model.WorkTypeConverters workTypeConverters4 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
        supportSQLiteStatement.bindlong(24, androidx.work.impl.model.WorkTypeConverters.networkTypeToInt(constraints.getRequiredNetworkType()));
        androidx.work.impl.model.WorkTypeConverters workTypeConverters5 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
        supportSQLiteStatement.bindBlob(25, androidx.work.impl.model.WorkTypeConverters.fromNetworkRequest$work_runtime_release(constraints.getRequiredNetworkRequestCompat$work_runtime_release()));
        supportSQLiteStatement.bindlong(26, constraints.requiresCharging() ? 1L : 0L);
        supportSQLiteStatement.bindlong(27, constraints.requiresDeviceIdle() ? 1L : 0L);
        supportSQLiteStatement.bindlong(28, constraints.requiresBatteryNotLow() ? 1L : 0L);
        supportSQLiteStatement.bindlong(29, constraints.requiresStorageNotLow() ? 1L : 0L);
        supportSQLiteStatement.bindlong(30, constraints.getContentTriggerUpdateDelayMillis());
        supportSQLiteStatement.bindlong(31, constraints.getContentTriggerMaxDelayMillis());
        androidx.work.impl.model.WorkTypeConverters workTypeConverters6 = androidx.work.impl.model.WorkTypeConverters.INSTANCE;
        supportSQLiteStatement.bindBlob(32, androidx.work.impl.model.WorkTypeConverters.setOfTriggersTobyteArray(constraints.getContentUriTriggers()));
        supportSQLiteStatement.bindstring(33, workSpec.id);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.WorkSpec workSpec) {
        bind2(supportSQLiteStatement, workSpec);
    }

    protected override java.lang.string CreateQuery() {
        return "UPDATE OR ABORT `WorkSpec` SET `id` = ?,`state` = ?,`worker_class_name` = ?,`input_merger_class_name` = ?,`input` = ?,`output` = ?,`initial_delay` = ?,`interval_duration` = ?,`flex_duration` = ?,`run_attempt_count` = ?,`backoff_policy` = ?,`backoff_delay_duration` = ?,`last_enqueue_time` = ?,`minimum_retention_duration` = ?,`schedule_requested_at` = ?,`run_in_foreground` = ?,`out_of_quota_policy` = ?,`period_count` = ?,`generation` = ?,`next_schedule_time_override` = ?,`next_schedule_time_override_generation` = ?,`stop_reason` = ?,`trace_tag` = ?,`required_network_type` = ?,`required_network_request` = ?,`requires_charging` = ?,`requires_device_idle` = ?,`requires_battery_not_low` = ?,`requires_storage_not_low` = ?,`trigger_content_update_delay` = ?,`trigger_max_content_delay` = ?,`content_uri_triggers` = ? WHERE `id` = ?";
    }
}

