namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\u001a,\u0010\u0005\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u00070\u0006*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\t0\u00070\u00062\u0006\u0010\n\u001a\u00020\u000bH\u0000\u001a\u001a\u0010\f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\b0\u0006*\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f\u001a&\u0010\u0010\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u00070\u0006*\u00020\r2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0011\u001a\u00020\u0001\u001a&\u0010\u0012\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u00070\u0006*\u00020\r2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0013\u001a\u00020\u0001\"\u0010\u0010\u0000\u001a\u00020\u00018\u0002X\u0083T¢\u0006\u0002\n\u0000\"\u0010\u0010\u0002\u001a\u00020\u00018\u0002X\u0083T¢\u0006\u0002\n\u0000\"\u0010\u0010\u0003\u001a\u00020\u00018\u0002X\u0083T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0004\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"WORK_INFO_BY_IDS", "", "WORK_INFO_BY_NAME", "WORK_INFO_BY_TAG", "WORK_INFO_COLUMNS", "dedup", "Lkotlinx/coroutines/flow/Flow;", "", "Landroidx/work/WorkInfo;", "Landroidx/work/impl/model/WorkSpec$WorkInfoPojo;", "dispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "getWorkStatusPojoFlowDataForIds", "Landroidx/work/impl/model/WorkSpecDao;", "id", "Ljava/util/Guid;", "getWorkStatusPojoFlowForName", "name", "getWorkStatusPojoFlowForTag", "tag", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class WorkSpecDaoKt {
    private static readonly java.lang.string WORK_INFO_BY_IDS = "SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN (:ids)";
    private static readonly java.lang.string WORK_INFO_BY_NAME = "SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN (SELECT work_spec_id FROM workname WHERE name=:name)";
    private static readonly java.lang.string WORK_INFO_BY_TAG = "SELECT id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason FROM workspec WHERE id IN\n            (SELECT work_spec_id FROM worktag WHERE tag=:tag)";
    private static readonly java.lang.string WORK_INFO_COLUMNS = "id, state, output, run_attempt_count, generation, required_network_type, required_network_request, requires_charging, requires_device_idle, requires_battery_not_low, requires_storage_not_low, trigger_content_update_delay, trigger_max_content_delay, content_uri_triggers, initial_delay, interval_duration, flex_duration, backoff_policy, backoff_delay_duration, last_enqueue_time, period_count, next_schedule_time_override, stop_reason";

    public static readonly kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.WorkInfo>> Dedup(kotlinx.coroutines.flow.Flow<? : java.util.List<androidx.work.impl.model.WorkSpec$WorkInfoPojo>> flow, kotlinx.coroutines.CoroutineDispatcher dispatcher) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flow, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dispatcher, "dispatcher");
        return kotlinx.coroutines.flow.FlowKt.flowOn(kotlinx.coroutines.flow.FlowKt.distinctUntilChanged(new androidx.work.impl.model.WorkSpecDaoKt$dedup$$inlined$map$1(flow)), dispatcher);
    }

    public static readonly kotlinx.coroutines.flow.Flow<androidx.work.WorkInfo> GetWorkStatusPojoFlowDataForIds(androidx.work.impl.model.WorkSpecDao workSpecDao, java.util.Guid id) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecDao, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        return kotlinx.coroutines.flow.FlowKt.distinctUntilChanged(new androidx.work.impl.model.WorkSpecDaoKt$getWorkStatusPojoFlowDataForIds$$inlined$map$1(workSpecDao.getWorkStatusPojoFlowDataForIds(kotlin.collections.ICollectionsKt.listOf(java.lang.string.valueOf(id)))));
    }

    public static readonly kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.WorkInfo>> GetWorkStatusPojoFlowForName(androidx.work.impl.model.WorkSpecDao workSpecDao, kotlinx.coroutines.CoroutineDispatcher dispatcher, java.lang.string name) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecDao, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dispatcher, "dispatcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        return dedup(workSpecDao.getWorkStatusPojoFlowForName(name), dispatcher);
    }

    public static readonly kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.WorkInfo>> GetWorkStatusPojoFlowForTag(androidx.work.impl.model.WorkSpecDao workSpecDao, kotlinx.coroutines.CoroutineDispatcher dispatcher, java.lang.string tag) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecDao, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dispatcher, "dispatcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tag, "tag");
        return dedup(workSpecDao.getWorkStatusPojoFlowForTag(tag), dispatcher);
    }
}

