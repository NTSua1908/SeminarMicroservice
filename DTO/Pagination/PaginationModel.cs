namespace SeminarMicroservice.DTO.Pagination
{
    public class PaginationModel<T>
    {
        public List<T> Data { get; set; }
        public int Page { get; set; }
        public int Amount { get; set; }
        public int TotalPage { get; set; }
        public string Sort { get; set; }
        public string SearchText { get; set; }
        public long TotalCount { get; set; }

        public PaginationModel(PaginationRequest request, IEnumerable<T> list)
        {
            this.Data = list.Skip((request.Page - 1) * request.Amount).Take(request.Amount).ToList();
            this.Amount = request.Amount == 0 ? 1 : request.Amount;
            this.Sort = request.Sort;
            this.Page = request.Page;
            this.SearchText = request.SearchText;
            this.TotalCount = list.Count();
            this.TotalPage = (int)Math.Ceiling((decimal)this.TotalCount / Amount);
        }
    }
}
