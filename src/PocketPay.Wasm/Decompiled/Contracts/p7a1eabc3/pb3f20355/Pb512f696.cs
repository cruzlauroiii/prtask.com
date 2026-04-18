namespace WillowMaze.Wasm.Decompiled;

public interface Pb512f696
{
    object ClearCommodities(object P0);
    object ClearCommodityGroup(string P0, object P1);
    object ClearCommodityGroups(object P0);
    object DeleteCommodity(string P0, object P1);
    object GetCommodities(string P0, object P1);
    object GetCommoditiesByParentId(string P0, string P1, object P2);
    object GetCommoditiesByQuery(string P0, string P1, object P2);
    object GetCommodityById(string P0, object P1);
    object GetCommodityGroupById(string P0, object P1);
    object GetCommodityGroups(string P0, object P1);
    object GetCommodityGroupsByParentId(string P0, string P1, object P2);
    object ReplaceCommoditiesQuantity(List<object> P0, object P1);
    object SaveCommodities(List<object> P0, object P1);
    object SaveCommodity(p821c9e21 P0, object P1);
    object SaveCommodityGroup(pdf878ad9 P0, object P1);
    object SaveCommodityGroups(List<object> P0, object P1);
    object UpdateCommoditiesQuantity(List<object> P0, object P1);
    object UpdateCommoditiesQuantityAndPrice(List<object> P0, object P1);
}
