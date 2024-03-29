﻿namespace SeminarMicroservice.DTO.Pagination
{
    public class PaginationRequest
    {
        public int Page { get; set; }
        public int Amount { get; set; }
        public string? Sort { get; set; }
        public string? SearchText { get; set; }
        public void Format()
        {
            if (string.IsNullOrEmpty(Sort))
            {
                Sort = "";
            }

            if (string.IsNullOrEmpty(SearchText))
            {
                SearchText = "";
            }

            if (Amount <= 0)
            {
                Amount = 10;
            }

            if (Page <= 0)
            {
                Page = 1;
            }
        }
    }
}
