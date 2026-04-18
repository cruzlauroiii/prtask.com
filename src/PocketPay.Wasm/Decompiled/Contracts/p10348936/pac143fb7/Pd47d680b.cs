namespace WillowMaze.Wasm.Decompiled;

public interface Pd47d680b
{
    object AddPositionToCurrentInventorization(pd031d465 P0, object P1);
    object ClearCurrentInventorizationPositions(object P0);
    object ClearCurrentInventorizations(object P0);
    object CreateCurrentInventorization(object P0);
    object CreateInventorizationReceipt(p0690dac5 P0, object P1);
    object GetCurrentInventorization(object P0);
    object GetCurrentInventorizationPositions(object P0);
    object GetCurrentInventorizationRemainingPositions(List<object> P0, p14abd389 P1, object P2);
    object HasCurrentInventorizationRemainingPositions(List<object> P0, object P1);
    object RemoveCurrentInventorizationPosition(pd031d465 P0, object P1);
    object SaveCurrentInventorization(p0690dac5 P0, object P1);
    object UpdateCurrentInventorizationPosition(pd031d465 P0, object P1);
    object UpdateCurrentInventorizationStatus(p14abd389 P0, object P1);
}
