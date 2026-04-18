namespace WillowMaze.Wasm.Decompiled;

public class ViewBinderHelper
{
    private static string BUNDLE_MAP_KEY;
    private HashSet<object> LockedSwipeSet;
    private Dictionary<string, object> MapLayouts;
    private Dictionary<string, object> MapStates;
    private bool OpenOnlyOne;
    private readonly object StateChangeLock;

    private static Dictionary<string, object> Access$000(ViewBinderHelper P0)
    {
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapStates
        return default!;
    }

    private static bool Access$100(ViewBinderHelper P0)
    {
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.openOnlyOne
        return false;
    }

    private static void Access$200(ViewBinderHelper P0, string P1, SwipeRevealLayout P2)
    {
        // call: ViewBinderHelper.closeOthers
    }

    private void CloseOthers(string P0, SwipeRevealLayout P1)
    {
        // call: ViewBinderHelper.getOpenCount
        // call: Dictionary<string, object>.entrySet
        // call: HashSet<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: Map$Entry.getKey
        // call: string.equals
        // call: int.valueOf
        // call: Map$Entry.setValue
        // call: Dictionary<string, object>.values
        // call: ICollection<object>.iterator
        // call: SwipeRevealLayout.close
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapStates
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapLayouts
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.stateChangeLock
    }

    private int GetOpenCount()
    {
        // call: int.intValue
        // call: Dictionary<string, object>.values
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: ICollection<object>.iterator
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapStates
        return 0;
    }

    private void SetLockSwipe(bool P0, string[] P1)
    {
        // call: Arrays.asList
        // call: Dictionary<string, object>.get
        // call: HashSet<object>.removeAll
        // call: SwipeRevealLayout.setLockDrag
        // call: HashSet<object>.addAll
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.lockedSwipeSet
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapLayouts
    }

    public void Bind(SwipeRevealLayout P0, string P1)
    {
        // call: SwipeRevealLayout.shouldRequestLayout
        // call: Dictionary<string, object>.containsKey
        // call: Dictionary<string, object>.values
        // call: int.valueOf
        // call: SwipeRevealLayout.setDragStateChangeListener
        // call: Dictionary<string, object>.put
        // call: ICollection<object>.remove
        // call: SwipeRevealLayout.open
        // call: ViewBinderHelper$1.<init>
        // call: SwipeRevealLayout.close
        // call: Dictionary<string, object>.get
        // call: SwipeRevealLayout.abort
        // call: SwipeRevealLayout.setLockDrag
        // call: SwipeRevealLayout.requestLayout
        // call: int.intValue
        // call: HashSet<object>.contains
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.lockedSwipeSet
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapLayouts
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapStates
        // type: ViewBinderHelper$1
    }

    public void CloseLayout(string P0)
    {
        // call: int.valueOf
        // call: Dictionary<string, object>.put
        // call: Dictionary<string, object>.containsKey
        // call: Dictionary<string, object>.get
        // call: SwipeRevealLayout.close
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapStates
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapLayouts
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.stateChangeLock
    }

    public void LockSwipe(string[] P0)
    {
        // call: ViewBinderHelper.setLockSwipe
    }

    public void OpenLayout(string P0)
    {
        // call: int.valueOf
        // call: Dictionary<string, object>.put
        // call: Dictionary<string, object>.containsKey
        // call: Dictionary<string, object>.get
        // call: SwipeRevealLayout.open
        // call: ViewBinderHelper.closeOthers
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.stateChangeLock
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapStates
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapLayouts
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.openOnlyOne
    }

    public void RestoreStates(Dictionary<string, object> P0)
    {
        // str: "c3aa7614977ce4ad4b406b725464b6961cc170962fd41b9c71b39a2a3d06293651b9aa18b86eb3852c9028aae8fc923da..."
        // call: DecryptString.decryptString
        // call: HashSet<object>.iterator
        // call: Dictionary<string, object>.containsKey
        // call: IEnumerator<object>.next
        // call: Dictionary<string, object>.<init>
        // call: Dictionary<string, object>.getInt
        // call: Dictionary<string, object>.put
        // call: Dictionary<string, object>.keySet
        // call: Dictionary<string, object>.getBundle
        // call: IEnumerator<object>.hasNext
        // call: int.valueOf
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapStates
        // type: Dictionary<string, object>
    }

    public void SaveStates(Dictionary<string, object> P0)
    {
        // str: "ce828686a6b69b441ae831d7523c7c276b7bf39c5108173101d8e269e3c556c3ca79438da1e4bd519710978ceb12df10f..."
        // call: Dictionary<string, object>.entrySet
        // call: int.intValue
        // call: Dictionary<string, object>.putBundle
        // call: DecryptString.decryptString
        // call: HashSet<object>.iterator
        // call: Map$Entry.getKey
        // call: IEnumerator<object>.next
        // call: Dictionary<string, object>.<init>
        // call: Map$Entry.getValue
        // call: Dictionary<string, object>.putInt
        // call: IEnumerator<object>.hasNext
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.mapStates
        // type: Dictionary<string, object>
    }

    public void SetOpenOnlyOne(bool P0)
    {
        // field: com.chauthai.swipereveallayout.ViewBinderHelper.openOnlyOne
    }

    public void UnlockSwipe(string[] P0)
    {
        // call: ViewBinderHelper.setLockSwipe
    }

}
