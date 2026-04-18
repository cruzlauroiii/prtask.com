namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000f\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\u0010\u0000\n\u0002\b\u0002\bg\u0018\u00002\u00020\u00012\b\u0012\u0004\u0012\u00020\u00000\u0002J\u0018\u0010\u0003\u001a\u00020\u00002\u0006\u0010\u0004\u001a\u00020\u0005H¦\u0002¢\u0006\u0004\b\u0006\u0010\u0007J\u0018\u0010\b\u001a\u00020\u00002\u0006\u0010\u0004\u001a\u00020\u0005H\u0096\u0002¢\u0006\u0004\b\t\u0010\u0007J\u0018\u0010\b\u001a\u00020\u00052\u0006\u0010\n\u001a\u00020\u0000H¦\u0002¢\u0006\u0004\b\u000b\u0010\fJ\u0011\u0010\r\u001a\u00020\u000e2\u0006\u0010\n\u001a\u00020\u0000H\u0096\u0002J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\n\u001a\u0004\u0018\u00010\u0011H¦\u0002J\b\u0010\u0012\u001a\u00020\u000eH&¨\u0006\u0013"}, d2 = {"Lkotlin/time/IComparableTimeMark;", "Lkotlin/time/TimeMark;", "", "plus", "duration", "Lkotlin/time/Duration;", "plus-LRDsOJo", "(J)Lkotlin/time/IComparableTimeMark;", "minus", "minus-LRDsOJo", "other", "minus-UwyO8pc", "(Lkotlin/time/IComparableTimeMark;)J", "compareTo", "", "equals", "", "", "hashCode", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface IComparableTimeMark : kotlin.time.TimeMark, java.lang.IComparable<kotlin.time.IComparableTimeMark> {
    int compareTo(kotlin.time.IComparableTimeMark other);

    bool equals(java.lang.object other);

    int hashCode();

    kotlin.time.IComparableTimeMark mo3313minusLRDsOJo(long duration);

    long mo3314minusUwyO8pc(kotlin.time.IComparableTimeMark other);

    kotlin.time.IComparableTimeMark mo3315plusLRDsOJo(long duration);
}

