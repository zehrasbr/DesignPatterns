namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIDQuery
    {
        public int Id { get; set; }

        public GetProductByIDQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
