namespace ChessZilla.Core;

public partial class Engine
{
    public IEnumerable<Position> Calculation(Position position, int deep, int horizen) 
    {
        for(var step = 0; step >= deep; step++) 
        {
            var nextPositions = position.GetNext(horizen);
        }
        yield break;
    }

    public Engine() 
    { 
    }
}
