namespace WillowMaze.Wasm.Decompiled;

public interface Pd5de629a
{
    object AddPositionToInspect(pd031d465 P0, object P1);
    object ClearInspectedPositions(object P0);
    object GetInspectedPositions(object P0);
    object GetInspectionReceipt(object P0);
    object IncreaseInspectedPositionQuantity(pd031d465 P0, object P1);
    object RemoveInspectedPosition(pd031d465 P0, object P1);
    object UpdateInspectedPosition(pd031d465 P0, object P1);
    object UpdateInspectedPositions(List<object> P0, object P1);
    object UpdateInspectionReason(string P0, object P1);
}
