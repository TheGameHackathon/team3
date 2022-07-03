namespace thegame.Models;

public class CellDto
{
    /// <summary>
    /// Frontend animate transition of the cell from old to new state.
    /// </summary>
    /// <param name="id">Id is used to identificate cell to apply right animation</param>
    /// <param name="pos">Logical position of the cell in the game grid. Upper left corner is `new Vec(0, 0)`</param>
    /// <param name="type">Frontend apply images and other styling to the cell according to this type</param>
    /// <param name="content">Frontend can put this text in the cell</param>
    /// <param name="zIndex">Frontend render cells with higher zIndex above cells with lower zIndex</param>
    public CellDto(string id, VectorDto pos, string type, string content, int zIndex)
    {
        Id = id;
        Pos = pos;
        Type = type;
        Content = content;
        ZIndex = zIndex;
    }

    public string Id { get; set; }
    public VectorDto Pos { get; set; }
    public int ZIndex { get; set; }
    public string Type { get; set; }
    public string Content { get; set; }
}