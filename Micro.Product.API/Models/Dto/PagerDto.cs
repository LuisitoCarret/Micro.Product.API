namespace Micro.Product.API.Models.Dto
{
    public record PagerDto(int Page = 1, int RecordsPerPage = 10)
    {
        private const int MaxRecordPage = 50;

        public int Page { get; set; } = Math.Max(0, Page);
        /// <summary>
        ///  clamp me permite indetificar un valor valido entre 1 y el valor maximo por la pagina
        /// </summary>
        public int RecordsPerPage { get; init; } = Math.Clamp(RecordsPerPage, 1, MaxRecordPage);
    }
}
