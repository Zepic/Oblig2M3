namespace Oblig2
{
    class Rook : Piece
    {
        public Rook() : base("Rook")
        {
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}