namespace MoneyTrackAPI.Data.Response
{
    public class BaseResponse
    {
        public int Code { get; set; }
        public string? Message { get; set; }
    }

    public class SingleDataResponse<T> : BaseResponse
    {
        public T? Data { get; set; }
    }
}
